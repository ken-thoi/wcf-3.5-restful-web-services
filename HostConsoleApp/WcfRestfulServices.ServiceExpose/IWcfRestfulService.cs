using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfRestfulServices.ServiceExpose
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfRestfulService" in both code and config file together.
    [ServiceContract]
    public interface IWcfRestfulService
    {
        [OperationContract]
        string GetData(int value);
    }
}
