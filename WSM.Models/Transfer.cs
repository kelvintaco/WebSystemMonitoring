using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class Transfer
    {
        [Key]
        public int PtrId { get; set; }
        [ForeignKey ("ItemCode")]
        public int ItemCode { get; set; }
        public string Description { get; set; }
        [ForeignKey ("CstCode")]
        public int CstCode { get; set; }
        public string Name { get; set; }
        public DateOnly dateTransferred { get; set; }
        public string Condition { get; set; }
        public string receiveName { get; set; }
        public string TransferType { get; set; }
    }
}
