using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MonsterApp.DataAccess.models;

namespace monsterapp.dataclient
{
    public class GenderAutoMapper
    {
        private MapperConfiguration mapper = new MapperConfiguration(m => m.CreateMap<Gender, Models.GenderDAO>().ForMember(d => d.id, o => o.MapFrom (s => s.Genderid)));



    }
}