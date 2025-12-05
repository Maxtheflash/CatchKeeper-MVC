using System;
using System.ComponentModel.DataAnnotations;

namespace CatchKeeperMVC.Models
{
    public class Catch
    {
        public int Id { get; set; }

        [Display(Name = "Date Caught")]
        [DataType(DataType.Date)]
        public DateTime CatchDate { get; set; }

        [Required, StringLength(50)]
        public string Species { get; set; }

        [Display(Name = "Length (inches)")]
        public double? LengthInInches { get; set; }

        [Display(Name = "Weight (lbs)")]
        public double? WeightInPounds { get; set; }

        [Display(Name = "Bait Used"), StringLength(50)]
        public string BaitUsed { get; set; }

        [Display(Name = "Location"), StringLength(100)]
        public string LocationName { get; set; }

        [StringLength(100)]
        public string Weather { get; set; }

        [StringLength(100)]
        public string Technique { get; set; }

        [Display(Name = "Photo URL")]
        [DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
