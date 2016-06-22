using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Models
{
    public class Book
    {
        public int Id { set; get; }

        [Required]
        public string Title { set; get; }

        public int Year { set; get; }

        
        public decimal Price { set; get; }


        public string Genre { set; get; }

        // Foreign Key
        public int  AuthorId { set; get; }

        // Navigation property
        public Author Author { set; get; }

    }
}
