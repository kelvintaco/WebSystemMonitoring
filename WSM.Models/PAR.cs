using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class PAR
    {
        [Key]
        public string ParID { get; set; }
        [ForeignKey ("ItemCode")]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        [ForeignKey("CstCode")]
        public string ParName { get; set; }
        public string DprName { get; set; }
        public string ParDate { get; set; }
        public int refNo { get; set; }
        public int ParQty { get; set; }
    }
}
