using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterAppWorking.Data;
using Xunit;

namespace MonsterWorkingTest
{
    public partial class AdoDataTests
    {
        private MonsterAppWorking.Data.Models.Gender gender;

        public AdoDataTests()
        {
            gender = new MonsterAppWorking.Data.Models.Gender() { GenderName = "TestGender" };
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }
    }
}
