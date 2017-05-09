using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization

namespace Happersett_B
{
    [DataContract]
    public class product
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

    }
}