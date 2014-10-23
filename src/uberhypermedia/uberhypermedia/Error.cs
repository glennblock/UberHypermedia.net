using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CollectionJson;

namespace UberHypermedia
{
    [DataContract]
    public class Error : ExtensibleObject
    {
        [DataMember(Name = "data")]
        public IList<Data> Children { get; set; } 
    }
}
