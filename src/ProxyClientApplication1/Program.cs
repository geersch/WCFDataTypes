using System;
using System.Collections.Generic;

namespace ProxyClientApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Proxy generated using SvcUtil.exe with default settings *****\n");

            using (WcfDataTypeServiceClient proxy = new WcfDataTypeServiceClient())
            {
                Console.WriteLine("***** Dictionary<int, string> *****");
                IDictionary<int, string> employees = proxy.GetEmployeesAsDictionary();
                foreach (string employee in employees.Values)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();

                Console.WriteLine("***** String array? *****");
                string[] stringArray = proxy.GetEmployeesAsCollection();
                foreach (string employee in stringArray)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
