using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace WcfSampleService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Single)]
    public class WcfDataTypeService : IWcfDataTypeService
    {
        #region Instance Fields

        private Dictionary<int, string> employees =
            new Dictionary<int, string>();

        #endregion

        #region Constructor(s)

        public WcfDataTypeService()
        {
            employees.Add(1, "Bruce");
            employees.Add(2, "Matthew");
            employees.Add(3, "Andrew");
            employees.Add(4, "John");
            employees.Add(5, "Edward");
        }

        #endregion

        #region IWcfDataTypeService Members

        public IDictionary<int, string> GetEmployeesAsDictionary()
        {
            return employees;
        }

        public ICollection<string> GetEmployeesAsCollection()
        {            
            ICollection<string> result = employees.Values;
            return result;            
        }

        #endregion
    }
}
