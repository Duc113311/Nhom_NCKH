//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EclassWebAPI.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class Student
    {
        public string StudentID { get; set; }
        public string ClassID { get; set; }
        public string FullName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [JsonIgnore]
        [XmlIgnore]
        public virtual Class Class { get; set; }
    }
}