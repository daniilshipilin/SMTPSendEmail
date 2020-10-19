using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SMTPSendEmail.Helpers
{
    public class AppConfig
    {
        public bool AssemblyExist()
        {
            return (File.Exists(Assembly.GetEntryAssembly().Location + ".config"));
        }

        public void ReadAllKeys()
        {
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings are empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading App settings");
            }
        }

        public string ReadKey(string key)
        {
            var appSettings = System.Configuration.ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? throw new ConfigurationErrorsException();

            return (result);
        }

        public bool KeyExist(string key)
        {
            var appSettings = System.Configuration.ConfigurationManager.AppSettings;

            if (appSettings.AllKeys.Contains(key))
            {
                return (true);
            }

            return (false);
        }

        public void UpdateKey(string key, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);

            RefreshAppSettings();
        }

        public void AddKey(string key, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);

            RefreshAppSettings();
        }

        public void DeleteKey(string key)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);

            RefreshAppSettings();
        }

        public void RefreshAppSettings()
        {
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
