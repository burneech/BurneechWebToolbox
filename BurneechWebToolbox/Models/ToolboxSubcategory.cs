using System.Collections.Generic;

namespace BurneechWebToolbox.Models
{
    public class ToolboxSubcategory
    {
        public string SubcategoryTitle { get; set; }
        public List<ToolboxSubcategoryPage> SubcategoryPages { get; set; }
    }
}
