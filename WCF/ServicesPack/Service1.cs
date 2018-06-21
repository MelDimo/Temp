using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPack
{
    public class Service1 : IServicesPack.IService1
    {
        public string GetMessage(string name)
        {
            return $"Hello {name}";
        }
    }
}
