using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
        //navigation property

        [Display(Name = "Number available")]
        public byte NumberAvailable { get; set; }

        public Genre Genre { get; set; }
        //add foreign key

        [Required]
        [Display(Name = "Genre")]
        public short GenreId { get; set; }

    }
}