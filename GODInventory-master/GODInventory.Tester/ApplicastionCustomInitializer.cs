using System;
using System.Collections.Generic;
using System.Text;


namespace GODInventory.Tester
{
    class ApplicastionCustomInitializer
    {
        //private static log4net.ILog logger = log4net.LogManager.GetLogger("Logger");
        //private static readonly log4net.ILog applicationInfoLog = LogManager.GetLogger("ApplicationInfoLog");

        private static ApplicastionCustomInitializer _instance = null;
        private ApplicastionCustomInitializer() { }
        public static ApplicastionCustomInitializer CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new ApplicastionCustomInitializer();
            }
            return _instance;
        }


        public void Setup() {
            // https://github.com/jagregory/fluent-nhibernate/wiki/Fluent-configuration
            //Fluently.Configure()
            //  .Database(FluentNHibernate.Cfg.Db.MySQLConfiguration.Standard
            //    .ConnectionString(c => c
            //      .Is(Properties.Settings.Default.DBConnectionString))
            //    .ShowSql())
            //  .Mappings(m => m
            //    .FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()))
            //  .BuildSessionFactory();

            //log4net.Config.XmlConfigurator.Configure();

// Logger.Default.Append(new LogFile( "dev_log", "development.log"));
// Logger.Info("Logger setup");

        }

        public void Down() {
           //Logger.Flush();
          // Logger.ShutDown();
        }
    }
}
