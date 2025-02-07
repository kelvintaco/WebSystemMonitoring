using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class ICS
    {
        [Key]
        public int ICSID { get; set; }
        [ForeignKey ("ItemCode")]
        public int ItemCode { get; set; }
        public string Description { get; set; }
        [ForeignKey ("CstCode")]
        public string CSTCode { get; set; }
        public string ICSName { get; set; }
        public double ICSPrice { get; set; }
        public int Life { get; set; }
        public int Qty { get; set; }
        public DateOnly IcsDate { get; set; }
    }
}
