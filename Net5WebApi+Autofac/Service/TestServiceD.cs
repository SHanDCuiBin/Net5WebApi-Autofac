using Net5WebApi_Autofac.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5WebApi_Autofac.Service
{
    public class TestServiceD : ITestServiceD
    {
        public ITestServiceA TestServiceA { get; set; }
        public ITestServiceB TestServiceB { get; set; }
        public ITestServiceC TestServiceC { get; set; }

        public TestServiceD()
        {
            Console.WriteLine($"{this.GetType().Name} 被构造了...");
        }

        public void Show()
        {
            // TestServiceA.Show();
            // TestServiceB.Show();
            // TestServiceC.Show();
            Console.WriteLine($"This is a {this.GetType().Name} Instance...");
        }

    }
}
