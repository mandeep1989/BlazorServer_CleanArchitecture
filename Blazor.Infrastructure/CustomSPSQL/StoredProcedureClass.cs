using Blazor.Infrastructure.Database;
using Blazor.Infrastructure.SPModals;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Infrastructure.CustomSPSQL
{
    /// <summary>
    /// StoredProcedureClass
    /// </summary>
    public class StoredProcedureClass : Billing_POCBlazorContext
    {
        /// <summary>
        /// StoredProcedureClass Constructor
        /// </summary>
        /// <param name="options"></param>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public StoredProcedureClass(DbContextOptions<Billing_POCBlazorContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        /// <summary>
        /// CustomSPModel_Get_Result
        /// </summary>
        public virtual DbSet<CustomSPModel_Get_Result> CustomSPModel_Get_Result { get; set; }
    }
}
