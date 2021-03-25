using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Models
{
    public class EntryResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please enter a category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter a director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a rating")]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }


    }
}
