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

        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberInStock { get; set; }
        //navigation property

        [Required]
        public Genre Genre { get; set; }
        //add foreign key
        public short GenreId { get; set; }
    }
}