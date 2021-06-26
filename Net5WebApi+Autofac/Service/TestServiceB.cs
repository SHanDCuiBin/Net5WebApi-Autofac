using Net5WebApi_Autofac.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5WebApi_Autofac.Service
{
    public class TestServiceB : ITestServiceB
    {
        public void Show()
        {
             Console.WriteLine($"This is a {this.GetType().Name} Instance...");
        }
    }
}
