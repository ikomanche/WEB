//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaSystem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInfo
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string passwd { get; set; }
        public string realName_Surname { get; set; }
        public Nullable<decimal> phoneNumber { get; set; }
        public string Sex { get; set; }
        public System.DateTime DateOfBirth { get; set; }
    }
}
