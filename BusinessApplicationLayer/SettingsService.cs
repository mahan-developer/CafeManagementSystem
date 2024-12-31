﻿using BusinessEntitiesLayer;
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
                            new Settings { SettingsKey = "BackupPath", SettingsValue = @"C:\cafemanager" },
                            new Settings { SettingsKey = "AutoBackup", SettingsValue = "true" },
                            new Settings { SettingsKey = "BackgroundImage", SettingsValue = "null" }
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
