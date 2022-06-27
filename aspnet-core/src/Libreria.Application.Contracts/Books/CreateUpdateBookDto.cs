using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libreria.Books
{
    public class CreateUpdateBookDto
        //Esta clase se usa para tener la info del libro del interfaz del usuario mientras se crea o renueva un libro
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }


        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

    }
}
