using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ing
{
    [TestClass()]
    public class PrintTests
    {
        [TestMethod()]
        public void VerifyIfExpectedListIsGot()
        {
            PrintNumbers print = new PrintNumbers();

            String[] result = print.Print();
            String[] testArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            CollectionAssert.AreEqual(result, testArray);
        }

        [TestMethod()]
        public void VerifyIfTestDetectsChangesAtBeginningInExpectedList()
        {
            PrintNumbers print1 = new PrintNumbers();

            String[] result = print1.Print();
            String[] testArray = { "2", "1", "3", "4", "5", "6", "7", "8", "9", "10" };

            CollectionAssert.AreNotEqual(result, testArray);
        }

        [TestMethod()]
        public void VerifyIfTestDetectsChangesAtEndInExpectedList()
        {
            PrintNumbers print1 = new PrintNumbers();

            String[] result = print1.Print();
            String[] testArray = { "1", "2", "3", "4", "5", "6", "7", "8", "10", "9" };

            CollectionAssert.AreNotEqual(result, testArray);
        }
    }
}