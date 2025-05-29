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
        public string ItemDesc { get; set; }
        public string ParName { get; set; }
        public string DprHeadName { get; set; }
        public string ParDate { get; set; }
        public string Classification { get; set; }
        public string FundCls { get; set; }
        public string SourceCopies { get; set; }
        public int refNo { get; set; }
        public float _value { get; set; }
        public int ParQty { get; set; }
        public string Unit { get; set; }
    }
}
