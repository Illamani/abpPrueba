using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Libreria.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    //Book es una entity, anda a saber que es eso
    //Hereda caracteristicas o propiedades de "AuditedAggregateRoot" 
    //Algo que ABP hace automatico, te amo ABP
    //Por ultimo GUID es la llave primaria
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
