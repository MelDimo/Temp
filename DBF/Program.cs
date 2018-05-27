using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF
{
    class Program
    {
        static void Main(string[] args)
        {
            InteractionDBF.DBF dBF = new InteractionDBF.DBF(new InteractionDBF.DbfConnProperties());
            dBF.CreateTable("Test");
            dBF.InsertData();
            Console.ReadKey();
        }
    }
}
