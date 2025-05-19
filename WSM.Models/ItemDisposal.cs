using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class ItemDisposal
    {
        [Key]
        public string NonServCode { get; set; }
        public string disposalName { get; set; }
        public int StockOfDisposal { get; set; }
        public string Description { get; set; }
        public DateOnly disposalDate { get; set; }
    }
}
