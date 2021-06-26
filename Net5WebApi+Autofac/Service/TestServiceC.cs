using Net5WebApi_Autofac.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5WebApi_Autofac.Service
{
    public class TestServiceC : ITestServiceC
    {
        public TestServiceC()
        {
            Console.WriteLine($"{this.GetType().Name} 被构造了...");
        }
        public void Show()
        {
             Console.WriteLine($"This is a {this.GetType().Name} Instance...");
        }
    }
}
