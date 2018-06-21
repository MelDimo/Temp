using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Reflection;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assm = Assembly.LoadFrom(@"D:\MicrosoftVisualStudio\2017\Project\Temp\WCF\ServicesPack\bin\Debug\ServicesPack.dll");
            using (ServiceHost host = new ServiceHost(assm.GetType(), new Uri("http://localhost:8080")))
            {
                
                host.Open();
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
