using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteractionDBF
{
    public class DbfConnProperties
    {
        public string Provider { get; set; }
        public string DataSource { get; set; }
        public string ExtendedProperties { get; set; }

        public DbfConnProperties()
        {
            Provider = "Microsoft.Jet.OLEDB.4.0";
            DataSource = @"D:\Temp\dBase";
            ExtendedProperties = "dBase III";
        }
    }
}
