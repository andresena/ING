using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;


namespace Ing.Tests
{
    [TestClass()]
    public class ListCompareTests
    {
        [TestMethod()]
        public void VerifyIfThereIsNoDifferenceWhenListAreTheSame()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "1" };
                String[] array2 = { "1" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void VerifyIfThereIsDifferenceWhenList1HasTwoComponentsButOnlyOneInList2()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "1", "2" };
                String[] array2 = { "1" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsTrue(result);
            }
        }

        [TestMethod()]
        public void VerifyIfThereIsNoDifferenceWhenList1HasOneComponentThatIsInList2()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "1" };
                String[] array2 = { "1", "8" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void VerifyIfThereIsNoDifferenceWhenList1HasTwoComponentsThatAreInList2()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "1", "3" };
                String[] array2 = { "1", "3", "8" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void VerifyIfThereIsNoDifferenceWhenList1HasFiveComponentsWithRepetitionThatAreInList2()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "1", "3", "3", "7", "9", "0", "9", "1" };
                String[] array2 = { "3", "7", "3", "1", "1", "0", "9", "9", "8" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsFalse(result);
            }
        }

        [TestMethod()]
        public void VerifyIfThereIsDifferenceWhenList1HasSixComponentsWithRepetitionWhereOneIsNotInList2()
        {
            ListCompare listcompare = new ListCompare();
            {

                String[] array1 = { "3", "7", "3", "1", "1", "0", "9", "9", " 8" };
                String[] array2 = { "1", "3", "3", "7", "9", "0", "9", "1" };

                bool result = listcompare.VerifyArraysDifferences(array1, array2);

                Assert.IsTrue(result);
            }
        }
    }
}