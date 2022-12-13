using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid MovieTypeId { get; set; }
    }
}
