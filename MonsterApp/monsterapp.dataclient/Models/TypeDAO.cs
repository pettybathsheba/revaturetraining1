using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace monsterapp.dataclient.Models
{

    [DataContract]
    public class TypeDAO
    {


        [DataMember]
        public int id { get; set; }


        [DataMember]
        public int name { get; set; }
    }
}