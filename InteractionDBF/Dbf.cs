using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace InteractionDBF
{
    public class DBF
    {
        private OleDbConnection con;
        private DbfConnProperties dbfConnProperties;

        public DBF(DbfConnProperties pDbfConnProperties)
        {
            dbfConnProperties = pDbfConnProperties;
        }

        private void checkExistFile(string pPath)
        {
            if (File.Exists(pPath)) File.Delete(pPath);
        }

        public void CreateTable(string pTableName)
        {
            using (OleDbConnection con = new OleDbConnection(string.Format("Provider={0}; Data Source={1};Extended Properties={2}",
                dbfConnProperties.Provider, dbfConnProperties.DataSource, dbfConnProperties.ExtendedProperties)))
            {
                con.Open();

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = con;
                    checkExistFile(string.Format("{0}\\{1}.dbf", dbfConnProperties.DataSource, pTableName));
                    command.CommandText = string.Format("CREATE TABLE {0}(TN int)", pTableName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertData()
        {
            using (OleDbConnection con = new OleDbConnection(string.Format("Provider={0}; Data Source={1};Extended Properties={2}",
                dbfConnProperties.Provider, dbfConnProperties.DataSource, dbfConnProperties.ExtendedProperties)))
            {
                con.Open();

                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = con;
                    command.CommandText = "INSERT INTO Test(TN) VALUES(@TN)";

                    command.Parameters.Add("TN", OleDbType.Integer);

                    for (int i = 1; i < 10; i++)
                    {
                        command.Parameters["TN"].Value = i;
                        command.ExecuteNonQuery();
                    }

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
