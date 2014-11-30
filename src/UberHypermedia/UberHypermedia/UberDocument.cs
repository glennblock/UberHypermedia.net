using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using DynamicUtils;

namespace UberHypermedia
{
    [DataContract]
    public class UberDocument : ExtensibleObject, IUberDocument
    {
        [DataMember(Name="version")]
        public string Version { get; set; }

        [DataMember(Name = "data")]
        public IList<Data> Data { get; set; }
            
        [DataMember(Name = "error")]
        public Error Error { get; set; }
    }
}
