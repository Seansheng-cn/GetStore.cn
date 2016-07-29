using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GODInventoryWinForm
{
    class DBConfiguration
    {
       
            /// 
            /// 获取ConnectionStrings 
            /// 
            /// 
            /// 
            public static string GetConnectionString(string connectionName)
            {
                string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                return connectionString;
            }

            /// 
            /// 更新连接字符串 
            /// 
            /// 
            /// 
            /// 
            public static void SetConnectionString(string newName, string newConString, string newProviderName)
            {
                bool isModified = false;    //记录该连接串是否已经存在 
                if (ConfigurationManager.ConnectionStrings[newName] != null)
                {
                    isModified = true;
                }
                //新建一个连接字符串实例 
                ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);

                // 打开可执行的配置文件*.exe.config 
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // 如果连接串已存在，首先删除它 
                if (isModified)
                {
                    config.ConnectionStrings.ConnectionStrings.Remove(newName);
                    // 将新的连接串添加到配置文件中. 
                    config.ConnectionStrings.ConnectionStrings.Add(mySettings);
                    // 保存对配置文件所作的更改 
                    config.Save(ConfigurationSaveMode.Modified);
                    // 强制重新载入配置文件的ConnectionStrings配置节  
                    ConfigurationManager.RefreshSection("ConnectionStrings");
                }
            }
        
    }
}
