using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.Models
{
    public class Comment
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string ArticleId { get; set; }

        public Article Article { get; set; }

        public DateTime PostedIn { get; set; }
    }
}