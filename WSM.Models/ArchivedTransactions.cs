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
        //public string DprName { get; set; }
        public string Description { get; set; }
        public string archiveDate { get; set; }
        public float Value { get; set; }
        public string Clasification { get; set; }
        public string Copies { get; set; }
        public string ItemCond { get; set; }
        public int SurQTY { get; set; }
    }
}
