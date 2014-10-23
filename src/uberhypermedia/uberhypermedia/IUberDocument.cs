using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UberHypermedia
{
    public interface IUberDocument
    {
        [DataMember(Name = "version")]
        string Version { get; set; }

        [DataMember(Name = "data")]
        IList<Data> Data { get; set; }

        [DataMember(Name = "error")]
        Error Error { get; set; }
    }
}