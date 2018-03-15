using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
    }
}