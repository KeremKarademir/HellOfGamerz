using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.Models
{
    public class Article
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ICollection<InterArticleTag> InterArticleTags { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public DateTime PublishedIn { get; set; }
    }
}