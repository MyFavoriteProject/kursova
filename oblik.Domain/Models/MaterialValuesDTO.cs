using System;

namespace oblik.Domain.Models
{
    public class MaterialValuesDTO
    {
        public string NameMaterialValues { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime RemoveDate { get; set; }
        public string YearIssue { get; set; }
        public decimal Count { get; set; }
        public double Sum { get; set; }
        public double Price { get; set; }
        public string PlaceStorage { get; set; }
        public string ResponsiblePerson { get; set; }
    }
}
