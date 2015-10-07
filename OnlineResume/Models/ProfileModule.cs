//-------------------------------------------------------------
// Name : ProfileModule.cs
// Purpose : Module for storing contact address
// Developer : Hilal Paray
// BA : Hilal Paray
// Dated : 2015/10/06
// Updated :
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace OnlineResume.Models
{
    public class ProfileModule
    {
        /// <summary>
        /// For storing contact person name
        /// </summary>
        [Required(ErrorMessage = "You need to fill your name")]
        [Display(Name = "ContactName", ResourceType = typeof(OnlineResumeRes))]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Name should be greater than 5 characters and should not exceed 150 characters")]
        public string ContactName { get; set; }

        /// <summary>
        /// Contact person company name optional
        /// </summary>
        [Display(Name = "CompanyName", ResourceType = typeof(OnlineResumeRes))]
        public string CompanyName { get; set; }

        /// <summary>
        /// Contact person email address required
        /// </summary>
        [Required(ErrorMessage = "You need to fill your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "ContactEmail", ResourceType = typeof(OnlineResumeRes))]
        public string ContactEmail { get; set; }

        
        /// <summary>
        /// Comments optional
        /// </summary>
        [Display(Name = "ContactComment", ResourceType = typeof(OnlineResumeRes))]
        public string ContactComment { get; set; }
    }
}