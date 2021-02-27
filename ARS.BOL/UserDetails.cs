﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.BOL
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string UserName_Email { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserGender { get; set; }
        public string Mobile { get; set; }
        public bool IsActive { get; set; }
        public DateTime UserDob { get; set; }
        public string SkillsSet { get; set; }
        public string Experience { get; set; }
        public int RoleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
