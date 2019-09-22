using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace AireLogicBugTrackingFrontend.Models
{
    public class BugsModel
    {
        public int BugId { get; set; }

        [Required]
        public string BugTitle { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public string TypeOfBug { get; set; }

        [Required]
        public string Description { get; set; }

        public  string Priority { get; set; }

        [Required]
        public UserModel Author { get; set; }

        public bool IsOpen { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
