using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string TagName { get; set; }

        public ICollection<InterArticleTag> InterArticleTags { get; set; }


    }
}