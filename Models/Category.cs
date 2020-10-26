using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocThemNetCoreB2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentCategoryID { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string Class { get; set; }
        public string Image { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string LanguageId { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<bool> ShowIndex { get; set; }
        public Nullable<int> OrderBy { get; set; }
    }
}
