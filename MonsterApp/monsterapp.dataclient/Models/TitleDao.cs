using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace monsterapp.dataclient.NewFolder1
{
    [DataContract]

    public class TitleDAO
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int name { get; set; }
    }
}