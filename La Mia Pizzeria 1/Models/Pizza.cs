using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using La_Mia_Pizzeria_1.Controllers;
using La_Mia_Pizzeria_1.Database;
using System.ComponentModel.DataAnnotations;

namespace La_Mia_Pizzeria_1.Models
{

    public class Pizza
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage ="Il testo non deve superare i 100 caratteri0")]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [StringLength(500, ErrorMessage = "Il testo non deve superare i 500 caratteri0")]

        public string Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        [StringLength(500, ErrorMessage = "Il testo non deve superare i 500 caratteri0")]
        [Url]
        
        public string Image { get; set; }

        


        public Pizza()
        {

        }

        public Pizza(string title, string description, string image)
        {
            Title = title;
            Description = description;
            Image = image;
        }


    }
}
