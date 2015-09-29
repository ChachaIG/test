using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //1 Arrange => instancie
            Activity a = new Activity("env log", false);
            Pupil p = new Pupil("jane",6);
            p.AddActivity(a);
            p.AddEvaluation("env log", 'T');
            //2 Act => utiliser le système
            var eval = p.getEvaluationFor("env log");
            //3 Assert => on compare résultat obtenu et attendu
            Assert.AreEqual('T', eval);

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestMethod2()
        {
            //AAA
            //1 Arrange => instancie
            Activity a = new Activity("env log", false);
            Pupil p2 = new Pupil("jade", 6);
            
            //2 Act => utiliser le système
            var eval = p2.getEvaluationFor("env log");
            //3 Assert => on compare résultat obtenu et attendu
            Assert.AreEqual('T', eval);

        }
    }
}
