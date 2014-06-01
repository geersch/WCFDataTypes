using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyClientApplication2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Proxy generated using SvcUtil.exe with /collectionType option *****\n");

            using (WcfDataTypeServiceClient proxy = new WcfDataTypeServiceClient())
            {
                Console.WriteLine("***** Dictionary<int, string> *****");
                IDictionary<int, string> employees = proxy.GetEmployeesAsDictionary();
                foreach (string employee in employees.Values)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();

                Console.WriteLine("***** Collection<string> *****");
                ICollection<string> collection = proxy.GetEmployeesAsCollection();
                foreach (string employee in collection)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
