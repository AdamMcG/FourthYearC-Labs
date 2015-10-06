using System;
using EntSWDevLab7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab7_Unit_Testingh
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student myStudent = new Student("X00098814", "Adam", "Trans Male");
            Assert.AreEqual(myStudent.Name,"Adam");
        }

        [TestMethod]
        public void TestMethod2()
        {
            StudentClass myClassOfStudents = new StudentClass("C2334", @"Software Development 2");
            for (int i = 0; i < 10; i++)
            {
                myClassOfStudents.AddStudent(new Student("1233", "Testing" + i, "Male"));
            }

            foreach (var student in myClassOfStudents.Students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
