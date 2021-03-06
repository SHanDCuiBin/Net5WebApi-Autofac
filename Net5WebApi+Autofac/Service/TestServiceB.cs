using Net5WebApi_Autofac.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5WebApi_Autofac.Service
{
    public class TestServiceB : ITestServiceB
    {
        private ITestServiceA _testServiceA;

        public void SetService(ITestServiceA testServiceA)
        {
            _testServiceA = testServiceA;
        }

        public TestServiceB()
        {
            Console.WriteLine($"{this.GetType().Name} 被构造了...");
        }

        public void Show()
        {
             Console.WriteLine($"This is a {this.GetType().Name} Instance...");
        }
    }
}
