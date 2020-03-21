using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}