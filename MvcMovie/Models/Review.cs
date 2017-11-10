using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Review
    {

        [DatabaseGenerated(DatabaseGenerationOption.Identity)]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(100000, MinimumLength = 10)]
        [Required]
        public string MovieReview { get; set; }
    }
}
