namespace Blazor.Infrastructure.Database
{
    /// <summary>
    /// Audit class for tables
    /// </summary>
    public interface IBlazorAudit
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }

    /// <summary>
    /// Table inherits the Audit class
    /// </summary>
    public partial class SampleTable : IBlazorAudit{}
}
