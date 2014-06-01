using System;
using System.ServiceModel;
using System.Collections.Generic;

namespace WcfSampleService
{
    // The Namespace property is provided for illustrative purposes    
    [ServiceContract(Namespace = "cgeers.wordpress.com")]        
    public interface IWcfDataTypeService
    {
        [OperationContract]
        IDictionary<int, string> GetEmployeesAsDictionary();        
        [OperationContract]
        ICollection<string> GetEmployeesAsCollection();
    }
}
