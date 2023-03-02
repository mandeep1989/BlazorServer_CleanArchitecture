using Microsoft.EntityFrameworkCore;

namespace Blazor.Infrastructure.SPModals
{
    /// <summary>
    /// Custom SP class
    /// </summary>
    [Keyless]
    public class CustomSPModel_Get_Result
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
    }
}
