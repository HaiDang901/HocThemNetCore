using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HocThemNetCoreB2.Models
{
    public class ProductModel
    {

    
            public int ProductID { get; set; }

            [Required(ErrorMessage = "Bắt buột nhập")]
            [StringLength(100, ErrorMessage = "ko quá 100 kí tự")]
            public string ProductName { get; set; }


            public string Description { get; set; }

            public string ImagePath { get; set; }

            [Required(ErrorMessage = "Bắt buột nhập")]
            [Range(50000, 10000000, ErrorMessage = "Enter number between 50.000 to 10.000.000")]
            public Nullable<double> UnitPrice { get; set; }

            [Required(ErrorMessage = "Bắt buột nhập")]
            [Range(50000, 10000000, ErrorMessage = "Enter number between 50.000 to 10.000.000")]
            public Nullable<double> UnitPriceNew { get; set; }

            [Required(ErrorMessage = "Bắt buột nhập")]
            public Nullable<int> CategoryID { get; set; }

            public string MetaKeywords { get; set; }

            public string MetaDescription { get; set; }

            public string MetaTitle { get; set; }

            public Nullable<bool> Published { get; set; }

            public Nullable<bool> IsNew { get; set; }

            [Required(ErrorMessage = "Bắt buột nhập")]
            [RegularExpression(@"^[a-zA-Z0-9]+")]
            public string Code { get; set; } //Chỉ nhập chữ a-z và A-Z 0 9

            public Nullable<bool> IsDelete { get; set; }

            public Nullable<System.DateTime> CreateDate { get; set; }

            public Nullable<System.DateTime> UpdateDate { get; set; }

            public string CreateBy { get; set; }

            public string UpdateBy { get; set; }
            public List<SelectListItem> lstcategory { get; set; }

            public ProductModel()
            {
                using (var db = new SchoolContext())
                {
                List<Category> lstData = db.Categories.ToList();
                this.lstcategory = new List<SelectListItem>();
                var temTemp = new SelectListItem();
                temTemp.Text = "--Bạn hãy chọn danh mục--";
                temTemp.Value = "";
                this.lstcategory.Add(temTemp);

                foreach (var item in lstData)
                {
                    temTemp = new SelectListItem();
                    temTemp.Text = item.CategoryName;
                    temTemp.Value = item.CategoryID.ToString();
                    this.lstcategory.Add(temTemp);

                }
            }
        }

    }
}
