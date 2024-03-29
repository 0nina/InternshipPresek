﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using internshipForm.Mappings;
using MySql;

namespace internshipForm
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();


        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {                                                      
                    try
                    {
                
                       var cfg = MsSqlConfiguration.MsSql2012
                        .ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Lazar & Nina\\source\\repos\\Internship\\internshipForm\\db.mdf\";Integrated Security=True").ShowSql();

                        return Fluently.Configure()
                            .Database(cfg)
                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMapping>())
                            .BuildSessionFactory();
                    }
                    catch (Exception ec)
                    {
                        System.Windows.Forms.MessageBox.Show(ec.Message);
                        return null;
                    }

        }
    }
}
