using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapWSUnitTestProject.FibonacciWSReference;

namespace SoapWSUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacci()
        {
            LemonWayWebServiceSoap obj = new LemonWayWebServiceSoapClient();
            FibonacciRequest req = new FibonacciRequest(new FibonacciRequestBody(10));
  
            Assert.AreEqual("55", obj.Fibonacci(req).Body.FibonacciResult);

            FibonacciRequest req2 = new FibonacciRequest(new FibonacciRequestBody(102));

            Assert.AreEqual("-1", obj.Fibonacci(req).Body.FibonacciResult);

            FibonacciRequest req3 = new FibonacciRequest(new FibonacciRequestBody(-1));

            Assert.AreEqual("-1", obj.Fibonacci(req).Body.FibonacciResult);
        }

       
    }
}
