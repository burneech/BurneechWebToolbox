using System.Collections.Generic;

namespace BurneechWebToolbox.Models
{
    public class ToolboxCategory
    {
        public string CategoryTitle { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryHref { get; set; }
        public string CategoryIcon { get; set; }
        public string CategorySummary { get; set; }
        public List<ToolboxSubcategory> Subcategories { get; set; }
    }
}
