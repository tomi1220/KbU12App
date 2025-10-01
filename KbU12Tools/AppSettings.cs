using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class AppSetting
    {
        private readonly Configuration _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private Dictionary<string, string> Settings { get; set; } = [];
        public string this[string name] { get { return Get(name); } set { Set(name, value); } }

        public AppSetting()
        {
            //App.configに存在するキーと値を辞書に読み込む
            foreach (var key in _configuration.AppSettings.Settings.AllKeys)
            {
                Settings.Add(key, _configuration.AppSettings.Settings[key].Value);
            }
        }

        /// <summary>
        /// 指定したキー名で値を参照
        /// キーが存在しなければ、値が空の新しいキーを登録し、その値を返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            if (!Settings.ContainsKey(key))
            {
                Set(key, "");
            }
            return Settings[key];
        }

        /// <summary>
        /// 指定したキーで値を登録
        /// キーが存在しなければ、新しいキーを登録する
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, string value)
        {
            if (Settings.TryAdd(key, value))
            {
                Settings.Add(key, value);
                _configuration.AppSettings.Settings.Add(key, value);
            }
            Settings[key] = value;
            _configuration.AppSettings.Settings[key].Value = value;
        }

        /// <summary>
        /// 指定したキーを削除する
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Settings.Remove(key);
            _configuration.AppSettings.Settings.Remove(key);
        }

        /// <summary>
        /// App.config に保存する
        /// </summary>
        public void Save()
        {
            _configuration.Save();
        }
    }
}
