using SMTPSendEmail.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPSendEmail
{
    public partial class MainForm : Form
    {
        #region Constants

        const int SMTP_CLIENT_TIMEOUT = 30000;
        const string SAFE_FILE_EXTENSION = ".txt";

        #endregion

        #region Properties

        List<string> AttachmentFilePaths { get; set; } = new List<string>();

        List<string> AttachmentFileNames { get; set; } = new List<string>();

        BindingSource MyBindingSource { get; set; } = new BindingSource();

        long FilesTotalLength { get; set; } = 0;

        #endregion

        #region AppSettings

        static readonly List<string> _keys = new List<string>
        {
            "ServerHostname",
            "ServerPort",
            "CredentialsUsername",
            "CredentialsPassword",
            "From",
            "To"
        };

        #endregion

        #region Fields

        // flag, that indicates, if email was successfully sent to the recipient
        bool _emailSent = false;
        readonly AppConfig _appConfig = null;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            MyBindingSource.DataSource = AttachmentFileNames;
            attachmentListBox.DataSource = MyBindingSource;

            _appConfig = new AppConfig();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $"{Program.ProgramHeader}";

            toolTip.SetToolTip(serverHostnameTextBox, "SMTP server hostname");
            toolTip.SetToolTip(serverPortTextBox, "SMTP server port");
            toolTip.SetToolTip(toTextBox, "format - Addr1;Addr2;...");
            toolTip.SetToolTip(ccTextBox, "format - Addr1;Addr2;...");

            if (_appConfig.AssemblyExist())
            {
                if (_appConfig.KeyExist(_keys[0]))
                {
                    serverHostnameTextBox.Text = _appConfig.ReadKey(_keys[0]);
                }

                if (_appConfig.KeyExist(_keys[1]))
                {
                    serverPortTextBox.Text = _appConfig.ReadKey(_keys[1]);
                }

                if (_appConfig.KeyExist(_keys[2]))
                {
                    usernameTextBox.Text = _appConfig.ReadKey(_keys[2]);
                }

                if (_appConfig.KeyExist(_keys[3]))
                {
                    passwordTextBox.Text = _appConfig.ReadKey(_keys[3]);
                }

                if (_appConfig.KeyExist(_keys[4]))
                {
                    fromTextBox.Text = _appConfig.ReadKey(_keys[4]);
                }

                if (_appConfig.KeyExist(_keys[5]))
                {
                    toTextBox.Text = _appConfig.ReadKey(_keys[5]);
                }
            }

#if DEBUG
            // set debug info to 'Subject' field
            subjectTextBox.Text = Program.ProgramHeader;
#endif
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            await SendEmailAsync();
        }

        private async Task SendEmailAsync()
        {
            try
            {
                var client = new SmtpClient()
                {
                    Host = serverHostnameTextBox.Text,
                    Port = int.Parse(serverPortTextBox.Text),
                    Timeout = SMTP_CLIENT_TIMEOUT,
                    Credentials = new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text),
                    EnableSsl = useSslCheckBox.Checked
                };

                using var mail = new MailMessage();

                // validate 'From' email address
                ValidateEmail(fromTextBox.Text);
                mail.From = new MailAddress(fromTextBox.Text);

                // add 'To' recipients
                if (!string.IsNullOrEmpty(toTextBox.Text))
                {
                    string[] toRecipients = toTextBox.Text.Split(';');

                    foreach (string recipient in toRecipients)
                    {
                        // validate email address
                        ValidateEmail(recipient);
                        mail.To.Add(new MailAddress(recipient));
                    }
                }

                // add 'CC' recipients
                if (!string.IsNullOrEmpty(ccTextBox.Text))
                {
                    string[] ccRecipients = ccTextBox.Text.Split(';');

                    foreach (string recipient in ccRecipients)
                    {
                        // validate email address
                        ValidateEmail(recipient);
                        mail.CC.Add(new MailAddress(recipient));
                    }
                }

                mail.Subject = subjectTextBox.Text;
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = htmlBodyCheckBox.Checked;

                if (mail.IsBodyHtml)
                {
                    // replace '\n' chars with "<br/>"
                    var sb = new StringBuilder(messageRichTextBox.Text);
                    sb.Replace("\n", "<br/>");

                    string timestamp = string.Empty;

                    // check, if timestamp is required
                    if (timestampCheckBox.Checked)
                    {
                        timestamp = $"<p><b>{GetUtcTimestamp()}</b></p>";
                    }

                    string htmlBody = "<html>" +
                                      $"<head>" +
                                      $"<title></title>" +
                                      $"</head>" +
                                      $"<body>" +
                                      $"<p>{sb.ToString()}</p>" +
                                      timestamp +
                                      $"</body>" +
                                      $"</html>";

                    mail.Body = htmlBody;
                }
                else
                {
                    string timestamp = string.Empty;

                    // check, if timestamp is required
                    if (timestampCheckBox.Checked)
                    {
                        timestamp = $"\n\n{GetUtcTimestamp()}";
                    }

                    mail.Body = messageRichTextBox.Text + timestamp;
                }

                // add attachements, if required
                if (AttachmentFilePaths.Any())
                {
                    foreach (string file in AttachmentFilePaths)
                    {
                        var attachment = new Attachment(file);

                        if (safeExtensionCheckBox.Checked)
                        {
                            // remove file extension and then append the 'safe' one
                            attachment.Name = Path.GetFileNameWithoutExtension(file);
                            attachment.Name += SAFE_FILE_EXTENSION;
                        }

                        mail.Attachments.Add(attachment);
                    }
                }

                using (var sendingForm = new SendingForm())
                {
                    sendingForm.sendingLabel.Text = $"Sending email to {mail.To}";
                    toolStripStatusLabel.Text = $"Sending email to {mail.To}";
                    sendingForm.Show();

                    await Task.Run(() =>
                    {
                        try
                        {
                            _emailSent = false;

                            client.Send(mail);

                            _emailSent = true;
                        }
                        catch (Exception ex)
                        {
                            toolStripStatusLabel.Text = "Exception occured";

#if DEBUG
                            MessageBox.Show($"{ex.Message}\n{ex.InnerException}\n{ex.StackTrace}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                            MessageBox.Show($"{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

                            return;
                        }
                    });
                }

                if (_emailSent)
                {
                    toolStripStatusLabel.Text = $"Email successfully sent to {mail.To}";
                    MessageBox.Show($"Email successfully sent to {mail.To}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Exception occured";

#if DEBUG
                MessageBox.Show($"{ex.Message}\n{ex.InnerException}\n{ex.StackTrace}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show($"{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private string GetUtcTimestamp()
        {
            // ISO 8601 format: 2019-11-06T22:15:11+00:00
            return (DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss+00:00"));
        }

        private void ValidateEmail(string email)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(email, pattern))
            {
                return;
            }

            throw new Exception($"'{email}' is not a valid email address");
        }

        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    // check, if list contains current file
                    if (AttachmentFilePaths.Contains(file))
                    {
                        MessageBox.Show($"File '{file}' already added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        continue;
                    }

                    long fileLength = new FileInfo(file).Length;

                    if (FilesTotalLength + fileLength > (long.Parse(fileSizeLimitTextBox.Text) * 1048576))
                    {
                        toolStripStatusLabel.Text = string.Empty;
                        MessageBox.Show($"Attachment(s) total file size exceeds the limit allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        continue;
                    }
                    else
                    {
                        // increment total file size
                        FilesTotalLength += fileLength;
                    }

                    AttachmentFilePaths.Add(file);
                    AttachmentFileNames.Add(Path.GetFileName(file));
                }

                UpdateTotalFilesLengthInfo();

                UpdateBindings();

                toolStripStatusLabel.Text = "File(s) added";
            }
        }

        private void RemoveAttachedFileButton_Click(object sender, EventArgs e)
        {
            for (int x = attachmentListBox.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int element = attachmentListBox.SelectedIndices[x];

                // decrement total file size
                FilesTotalLength -= new FileInfo(AttachmentFilePaths[element]).Length;

                AttachmentFilePaths.RemoveAt(element);
                AttachmentFileNames.RemoveAt(element);
            }

            UpdateTotalFilesLengthInfo();

            UpdateBindings();

            toolStripStatusLabel.Text = string.Empty;
        }

        private void UpdateTotalFilesLengthInfo()
        {
            double totalFilesLengthMB = (double)FilesTotalLength / 1048576;

            if (totalFilesLengthMB <= 0 || AttachmentFilePaths.Count == 0)
            {
                attachmentGroupBox.Text = $"Attachment(s) - none";
            }
            else
            {
                attachmentGroupBox.Text = $"Attachment(s) - {totalFilesLengthMB.ToString("0.00")} MB";
            }
        }

        private void UpdateBindings()
        {
            MyBindingSource.ResetBindings(false);

            attachmentListBox.Refresh();
            attachmentListBox.Update();
        }

        private void MessageRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (messageRichTextBox.SelectionFont.Bold)
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Regular);
            }
            else
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Bold);
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (messageRichTextBox.SelectionFont.Italic)
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Regular);
            }
            else
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Italic);
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (messageRichTextBox.SelectionFont.Underline)
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Regular);
            }
            else
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Underline);
            }
        }

        private void StrikeoutButton_Click(object sender, EventArgs e)
        {
            if (messageRichTextBox.SelectionFont.Strikeout)
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Regular);
            }
            else
            {
                messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Strikeout);
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog
            DialogResult dialogResult = colorDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // set the selected text foreground color
                messageRichTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void RemoveFormattingButton_Click(object sender, EventArgs e)
        {
            messageRichTextBox.SelectionFont = new Font(messageRichTextBox.Font, FontStyle.Regular);
            messageRichTextBox.SelectionColor = SystemColors.WindowText;
        }

        private void ShowFilePathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showFilePathCheckBox.Checked)
            {
                MyBindingSource.DataSource = AttachmentFilePaths;
            }
            else
            {
                MyBindingSource.DataSource = AttachmentFileNames;
            }

            MyBindingSource.ResetBindings(true);
        }

        private void FileSizeLimitTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                long.Parse(fileSizeLimitTextBox.Text);

                e.Cancel = false;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show($"{ex.Message}\n{ex.InnerException}\n{ex.StackTrace}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show($"{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

                e.Cancel = true;
            }
        }
    }
}
