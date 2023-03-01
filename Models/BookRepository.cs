using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_msperry6.Models
{
    public interface BookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
