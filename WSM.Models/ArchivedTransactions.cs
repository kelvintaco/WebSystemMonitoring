using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class ArchivedTransactions
    {
        [Key]
        public int archiveID { get; set; }
        public string SurName { get; set; }
        public string PrpName { get; set; }
        public string DprName { get; set; }
        public DateOnly archiveDate { get; set; }
        public double Value { get; set; }
        public string ItemCond { get; set; }
        public int SurQTY { get; set; }
    }
}
