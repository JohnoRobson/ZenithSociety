using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenithSociety.Models {
    public class Activity {
        [Key]
        [Display(Name = "Activity")]
        public int ActivityId { get; set; }

        [Display(Name = "Activity Description")]
        [Required]
        public string ActivityDescription { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
    }
}
