//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerSideDatatables
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
