using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Models
{
    [DataContract]
    public class Hl7Msh
    {
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [DataMember(Name = "Msh1")]
        public string Msh1         { get; set; }

        [DataMember(Name = "Msh2")]
        public string Msh2         { get; set; }

        [DataMember(Name = "Msh3_1")]
        public string Msh3_1       { get; set; }

        [DataMember(Name = "Msh3_2")]
        public string Msh3_2       { get; set; }

        [DataMember(Name = "Msh3_3")]
        public string Msh3_3       { get; set; }

        [DataMember(Name = "Msh4_1")]
        public string Msh4_1       { get; set; }

        [DataMember(Name = "Msh4_2")]
        public string Msh4_2       { get; set; }

        [DataMember(Name = "Msh4_3")]
        public string Msh4_3       { get; set; }

        [DataMember(Name = "Msh5_1")]
        public string Msh5_1       { get; set; }

        [DataMember(Name = "Msh5_2")]
        public string Msh5_2       { get; set; }

        [DataMember(Name = "Msh5_3")]
        public string Msh5_3       { get; set; }

        [DataMember(Name = "Msh6_1")]
        public string Msh6_1       { get; set; }

        [DataMember(Name = "Msh6_2")]
        public string Msh6_2       { get; set; }

        [DataMember(Name = "Msh6_3")]
        public string Msh6_3       { get; set; }

        [DataMember(Name = "Msh7")]
        public string Msh7         { get; set; }

        [DataMember(Name = "Msh8")]
        public string Msh8         { get; set; }

        [DataMember(Name = "Msh9_1")]
        public string Msh9_1       { get; set; }

        [DataMember(Name = "Msh9_2")]
        public string Msh9_2       { get; set; }

        [DataMember(Name = "Msh10")]
        public string Msh10        { get; set; }

        [DataMember(Name = "Msh11_1")]
        public string Msh11_1      { get; set; }

        [DataMember(Name = "Msh11_2")]
        public string Msh11_2      { get; set; }

        [DataMember(Name = "Msh12")]
        public string Msh12        { get; set; }

        [DataMember(Name = "Msh13")]
        public string Msh13        { get; set; }

        [DataMember(Name = "Msh14")]
        public string Msh14        { get; set; }

        [DataMember(Name = "Msh15")]
        public string Msh15        { get; set; }

        [DataMember(Name = "Msh16")]
        public string Msh16        { get; set; }

        [DataMember(Name = "Msh17")]
        public string Msh17        { get; set; }

        [DataMember(Name = "Msh18")]
        public string Msh18        { get; set; }

        [DataMember(Name = "Msh19")]
        public string Msh19 { get; set; }
    }
}
