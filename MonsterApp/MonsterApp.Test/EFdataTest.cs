using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess;
using Xunit;
using System.Data.Entity;


namespace MonsterApp.Tests
{
  /// <summary>
  /// 
  /// </summary>
public class EfDataTests
{
    [Fact]
    public void Test_GetGenders()
    {
        var data = new EFData();
        var actual = data.GetGenders();

        Assert.NotNull(actual);
    }

    [Fact]
    public void Test_InsertGender()
    {
        var data = new EFData();
        var expected = new Gender() { GenderName = "Martian", Active = true };

        var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

        Assert.True(actual);
    }
}
}