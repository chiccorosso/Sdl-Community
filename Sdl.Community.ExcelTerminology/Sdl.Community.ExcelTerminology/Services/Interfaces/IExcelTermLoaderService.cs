using System.Collections.Generic;
using System.Threading.Tasks;
using Sdl.Community.ExcelTerminology.Model;

namespace Sdl.Community.ExcelTerminology.Services.Interfaces
{
    public interface IExcelTermLoaderService
    {
        Task<Dictionary<int, ExcelTerm>> LoadTerms();
        Task AddOrUpdateTerm(int entryId, ExcelTerm excelTerm);
        Task DeleteTerm(int id);
    }
}