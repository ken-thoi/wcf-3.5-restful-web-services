using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRestfulServices.ServiceExpose
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfRestfulService" in both code and config file together.
    public class WcfRestfulService : IWcfRestfulService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
