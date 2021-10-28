using System.Collections.Generic;

namespace BurneechWebToolbox.Models
{
    public class ToolboxCategory
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Href { get; set; }
        public string Summary { get; set; }
        public List<ToolboxCategoryPage> Pages { get; set; }
    }
}
