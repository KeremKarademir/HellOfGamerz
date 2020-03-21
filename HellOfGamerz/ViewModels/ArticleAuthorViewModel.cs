using HellOfGamerz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HellOfGamerz.ViewModels
{
    public class ArticleAuthorViewModel
    {
        public Article Article { get; set; }
        public Author Author { get; set; }
    }
}