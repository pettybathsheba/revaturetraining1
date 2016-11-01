using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DA = monsterapp.dataclient.Models;
using MonsterApp.DataAccess;

namespace monsterapp.dataclient
{
    public class GenderMapper
    {

        public static DA.GenderDAO MapToGenderDAO(Gender gender)
        {
            var g = new DA.GenderDAO();

            g.id = gender.GenderId;
            g.name = gender.GenderName;

            return g;
        }

        public static Gender MapToGender(DA.GenderDAO gender)
        {
            throw new NotImplementedException();
        }

        public static object MapTo(object o)
        {
            var properties = o.GetType().GetProperties();
            var ob = new object();

            foreach (var item in properties.ToList())
            {
                ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
            }

            return ob;
        }

    }

    }
