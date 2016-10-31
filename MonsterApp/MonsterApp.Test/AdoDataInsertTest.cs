using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess;
using MonsterApp.DataAccess.models;
using Xunit;

namespace MonsterApp.Tests
{
    public partial class AdoDataTests
    {
        private DataAccess.models.Gender gender;
        private DataAccess.models.Monster monster;


        public AdoDataTests()
        {
            gender = new DataAccess.models.Gender() { GenderName = "TestGender" };
            monster = new DataAccess.models.Monster() { Name = "TestMonster", TypeId = 1 };
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new AdoData();
            var actual = data.InsertMonster(monster);

            Assert.True(actual);
        }


        //[Theory(gender = new DataAccess.models.Gender() { GenderName = "cookie", Active = True })]
        //public void Theory_insertGender(gender);
        //{
        //var data = new AdoData();
        //var actual = data.InsertGender(gender);

        //Assert.True(actual);
        
        //}


    }
}
