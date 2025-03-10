﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace teamProject.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Fax { get; set; }
        [Display(Name = "Manager")]
        [ForeignKey("Manager")]
        public string? Manager_Id { get; set; }
        public virtual ApplicationUser? Manager { get; set; }
        public virtual List<ApplicationUser>? Employees { get; } = new List<ApplicationUser>();
        public virtual List<Governerate>? Governerates { get; } = new List<Governerate>();
        public virtual BranchMobile? BranchMobiles { get; set; }
        public virtual BranchPhone? BranchPhones { get; set; }
    }
}
