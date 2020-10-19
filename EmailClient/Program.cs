using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace SMTPSendEmail
{
    static class Program
    {
        #region Program configuration

#if DEBUG
        const string BUILD_CONFIGURATION = " [Debug]";
#else
        const string BUILD_CONFIGURATION = "";
#endif

        #endregion

        #region Build/program info

        static Version Ver { get; } = new AssemblyName(Assembly.GetExecutingAssembly().FullName).Version;
        public static string ProgramVer { get; } = $"{Ver.Major}.{Ver.Minor}.{Ver.Build}";
        public static string ProgramName { get; } = Assembly.GetExecutingAssembly().GetName().Name;
        public static string ProgramHeader { get; } = $"{ProgramName} v{ProgramVer}{BUILD_CONFIGURATION}";
        public static string ProgramBaseDirectory { get; } = AppDomain.CurrentDomain.BaseDirectory;
        public static string ProgramPath { get; } = Assembly.GetEntryAssembly().Location;

        #endregion

        #region Cmd arguments

        public static List<string> CmdArgs { get; private set; }
        public static bool CmdArgsExist { get; private set; }

        #endregion

        #region Exitcode enum

        public enum ExitCode : int
        {
            Success = 0,
            AnotherInstanceRunning = 1,
            IncorrectArgs = 2,
            Error = 4
        }

        #endregion

        [STAThread]
        static void Main(string[] args)
        {
            // check, if there is another instance running
            if (CheckAnotherInstanceRunning(ProgramName))
            {
                Environment.Exit((int)ExitCode.AnotherInstanceRunning);
            }

            // check if arguments provided
            if (args.Length >= 1)
            {
                EnumCmdArgs(args);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            ProgramExit((int)ExitCode.Success);
        }

        private static void EnumCmdArgs(string[] args)
        {
            // handle special case, when we pass single argument
            if (args.Length == 1 && args[0] == "/?")
            {
                // TODO - program info
                Console.WriteLine(GetInfo());

                ProgramExit((int)ExitCode.Success);
            }

            CmdArgs = new List<string>();

            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    // add argument value to the CmdArgs list
                    CmdArgs.Add(args[i]);
                }

                CmdArgsExist = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                ExceptionHandler(ex, "Provided incorrect number of cmd arguments", ExitCode.IncorrectArgs);
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex);
            }
        }

        private static bool CheckAnotherInstanceRunning(string programName)
        {
            using var singleton = new Mutex(true, programName);

            // check, if there is already another instance running
            if (!singleton.WaitOne(TimeSpan.Zero, true))
            {
                return (true);
            }

            return (false);
        }

        public static void ProgramExit(int exitCode)
        {
            Environment.Exit(exitCode);
        }

        public static void ExceptionHandler(Exception ex, string infoMessage = null, ExitCode exitCode = ExitCode.Error)
        {
            DialogResult dr;

            if (!string.IsNullOrEmpty(infoMessage))
            {
                dr = MessageBox.Show($"{infoMessage}\n{ex.Message}\nExit program?", "Exception handler", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                dr = MessageBox.Show($"{ex.Message}\nExit program?", "Exception handler", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

            if (dr == DialogResult.Yes)
            {
                ProgramExit((int)exitCode);
            }
        }

        public static string GetInfo()
        {
            string programInfo = $"{ProgramHeader}\n" +
                                 $"Author: Daniil Shipilin\n" +
                                 $"\n" +
                                 $"Description:\n" +
                                 $"  The SMTP email sending client.";

            return (programInfo);
        }
    }
}
