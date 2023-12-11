using System;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class About
    {
        public int ID { get; set; }

         [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Name { get; set; }


         [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string HeadName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Established { get; set; }

         [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Area { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Fees { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        [StringLength(5)]
        [Required]
        public int Buildings { get; set;}


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(5)]
        public string Rating {get; set;}
    
    }
}

//dotnet-aspnet-codegenerator razorpage -m About -dc SchoolContext -udl -outDir Pages/Abouts --referenceScriptLibraries -sqlite