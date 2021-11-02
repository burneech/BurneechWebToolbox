using BurneechWebToolbox.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BurneechWebToolbox.Services
{
    public interface IDataService
    {
        Task<List<ToolboxCategory>> GetToolboxCategories();
    }
}
