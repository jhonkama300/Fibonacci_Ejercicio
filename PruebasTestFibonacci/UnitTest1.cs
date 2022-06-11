using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PruebasTestFibonacci;
using Fibonacci_Ejercicio;

namespace PruebasTestFibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           int result = Fibonacci_Ejercicio.Program.fibonacci(10);
           Assert.AreEqual(55,result);
        }
    }
}
