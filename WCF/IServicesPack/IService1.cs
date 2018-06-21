using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IServicesPack
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
