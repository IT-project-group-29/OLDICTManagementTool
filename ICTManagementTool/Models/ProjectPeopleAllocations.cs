//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICTManagementTool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectPeopleAllocations
    {
        public int projectID { get; set; }
        public int personID { get; set; }
        public string personRole { get; set; }
        public System.DateTime dateCreated { get; set; }
        public int creatorID { get; set; }
        public string creatorComment { get; set; }
    
        protected virtual Projects Projects { get; set; }
    }
}