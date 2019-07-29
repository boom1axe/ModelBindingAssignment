using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingAssignment.Models
{
    /// <summary>
    /// data of a toy
    /// </summary>
    public class Toy
    {
        /// <summary>
        /// ToyDB key
        /// </summary>
        public int ToyID { get; set; }

        /// <summary>
        /// Legal brand name of toy
        /// </summary>
        [Required(ErrorMessage = "Toy brand name required")]
        [Display(Name = "Toy Brand Name")]
        public String Title { get; set; }

        /// <summary>
        /// Short description of toy or other info
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Color of a toy
        /// Only Required for toys 
        /// that share a brand name but
        /// has more then one color
        /// </summary>
        public String Color { get; set; }
        [Required]
        public String Company { get; set; }
        public string Type { get; set; }
    }
}
