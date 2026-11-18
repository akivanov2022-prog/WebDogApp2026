using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using WebDogApp.Infrastucture.WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Infrastructure.Data.Domain
{
    public class Breed
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Dog> Dogs { get; set; } = new List<Dog>();
    }
}