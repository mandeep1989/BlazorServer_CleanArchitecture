namespace Blazor.Infrastructure.Database
{
    public partial class SampleTable : IBlazorAudit
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
