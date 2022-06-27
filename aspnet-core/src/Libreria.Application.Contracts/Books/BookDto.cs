using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Libreria.Books
{
    public class BookDto :AuditedEntityDto<Guid>//Este DTO se usa para transferir la info de los libros para poder mostrar en el UI
    {
        public string Name { get; set; }
        public BookType Type  { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
//Esto es un DTO, se utiliza para transferencia de Datos entre la capa de presentacion y la capa de aplicacion
//