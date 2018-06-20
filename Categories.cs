using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BlueRibbonsReview.Models
{
    public enum Categories
    {
        [Display(Name = "Clothing")] Clothing,
        [Display(Name ="Food & Drink")] FoodAndDrink,
        [Display(Name = "Health & Beauty")] HealthAndBeauty,
        [Display(Name = "Home Products")] HomeProducts,
        [Display(Name = "Children")] Children,
        [Display(Name = "Technology")] Technology,
        [Display(Name = "Miscellaneous")] Miscellaneous
    }

    public static class CategoriesHelper
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                .First().GetCustomAttribute<DisplayAttribute>().GetName();
        }
    }
}