using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AppVacunas.Client.Helpers {
    public class PatchObject {
        [DataMember(Name = "op")]
        public string Op { get; set; }
        [DataMember(Name = "path")]
        public string Path { get; set; }
        [DataMember(Name = "value")]
        public object Value { get; set; }
    }
}
