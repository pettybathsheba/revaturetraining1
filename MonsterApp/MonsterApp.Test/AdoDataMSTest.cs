using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterApp.DataAccess;

namespace MonsterApp.Test
{
    [TestClass]
    public class AdoDataMSTest
    {
        private DataAccess.models.Gender gender;
        private DataAccess.models.Monster monster;

    
        public void Initialize()
            {
            
                gender = new DataAccess.models.Gender() { GenderName = "TestGender" };
                monster = new DataAccess.models.Monster() { Name = "TestMonster", TypeId = 1 };
            }

    [TestCleanup]
        public void Cleanup()
            {
                GC.Collect();
            }


        [TestMethod]
            public void Test_InsertGender()
                {
                    var data = new AdoData();
                    var actual = data.InsertGender(gender);

                    Assert.IsTrue(actual);
                }

    [TestMethod]
            public void Test_InsertMonster()
                {
                    var data = new AdoData();
                    var actual = data.InsertMonster(monster);

                    Assert.IsTrue(actual);
                }


    }
}
