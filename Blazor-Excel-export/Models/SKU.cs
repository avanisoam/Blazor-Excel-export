namespace BlazorExcelExport.Models
{
    public class SKU
    {
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public string? Attribute1 { get; set; }
        public string? Attribute2 { get; set; }
        public string? Attribute3 { get; set; }

        public string? GenerateSku { get; set; }
    }
}
