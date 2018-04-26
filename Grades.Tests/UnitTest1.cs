using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {

            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);
            book.AddGrade(100f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(100f, stats.HighestGrade);

           // bool value = true;
           // Assert.IsTrue(value);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("", book.Name);
        }

        void SetName(GradeBook book)
        {
            book.Name = "Name set";
        }
    }
}
