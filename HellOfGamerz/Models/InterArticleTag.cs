using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.Models
{
    public class InterArticleTag
    {
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}