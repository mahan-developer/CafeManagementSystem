using BusinessEntitiesLayer;
using CommonUtilities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationLayer
{
    
    public class SettingsService
    {
        private readonly SettingsRepository _settingsRepository;
        public SettingsService()
        {
            _settingsRepository = new SettingsRepository();
        }

        public bool AddSetting(Settings settings)
        {
            try
            {
                int result = _settingsRepository.InsertSetting(settings);
                return result > 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }

        public bool EditSetting(Settings settings)
        {
            try
            {
                bool result = _settingsRepository.EditSetting(settings);
                return result;
            }
            catch (Exception ex)
            {
                ErrorHandler.LogException(ex);
                throw new Exception(ErrorHandler.GetFriendlyMessage(ex));
            }
        }


        public void AddDefaultSetting()
        {
            var initialSettings = new List<Settings>
                        {
                            new Settings { SettingsKey = "Password", SettingsValue = "admin" },
                            new Settings { SettingsKey = "BackupPath", SettingsValue = @"C:\CafeManagerBackup" },
                            new Settings { SettingsKey = "AutoBackup", SettingsValue = "false" },
                            new Settings { SettingsKey = "BackgroundImage", SettingsValue = "null" },
                            new Settings { SettingsKey = "LogoPath", SettingsValue = "null" },
                            new Settings { SettingsKey = "CafeName", SettingsValue = "My Cafe" },
                            new Settings { SettingsKey = "CafeAddress", SettingsValue = "Hello str 123\r\nErkrath 40699" },
                            new Settings { SettingsKey = "PhoneNumber", SettingsValue = "+491223432132" },
                            new Settings { SettingsKey = "InvoiceDescription", SettingsValue = "All price include applicable taxses.\r\nThank you for your purchase!" },
                            new Settings { SettingsKey = "ImageMode", SettingsValue = "Normal" },
                            new Settings { SettingsKey = "Version", SettingsValue = "1.0.0" },
                            new Settings { SettingsKey = "PrinterCustomerName", SettingsValue = "" },
                            new Settings { SettingsKey = "PrinterBarName", SettingsValue = "" },
                            new Settings { SettingsKey = "PrinterCustomerChecked", SettingsValue = "true" },
                            new Settings { SettingsKey = "PrinterBarChecked", SettingsValue = "true" },
                            new Settings { SettingsKey = "PrintPreview", SettingsValue = "true" }
                        };

            foreach (var setting in initialSettings)
            {
                AddSetting(setting);
            }
        }

        public List<Settings> GetSettingByField(Dictionary<string, object> searchParameters)
        {
            return _settingsRepository.GetSetting(searchParameters);
        }


    }
}
