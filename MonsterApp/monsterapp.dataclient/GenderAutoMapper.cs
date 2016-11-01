using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using monsterapp.dataclient.Models;
using MonsterApp.DataAccess.models;

namespace monsterapp.dataclient
{
    private MapperConfiguration mapper = new MapperConfiguration(m => m.CreateMap<Gender, GenderDAO>().ForMember(d => d.Id, o => o.MapFrom(s => s.Genderid)));

    public object MapTo(object o, object o1)
    {
        var m = Mapper.CreateMapper();

        return m.Map(o, o1);
    }


}
