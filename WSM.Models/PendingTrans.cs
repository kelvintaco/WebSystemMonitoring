using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class PendingTrans
    {
        [Key]
        public int PtrId { get; set; }
        [ForeignKey("ItemCode")]
        public int ItemCode { get; set; }
        public string Description { get; set; }
        [ForeignKey("CstCode")]
        public string CstCode { get; set; }
        public string Name { get; set; }
        public DateOnly dateTransferred { get; set; }
        public string Condition { get; set; }
        public string rvName { get; set; }
        public string TransferType { get; set; }
        public string fundccl { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string reason { get; set; }
        public string apprvdBy { get; set; }
        public string designationOf { get; set; }
        public string approvedByDate { get; set; }
        public string releaseBy { get; set; }
        public string designationRelease { get; set; }
        public string releaseByDate { get; set; }
        public string receivedBy { get; set; }
        public string designationReceived { get; set; }
        public string receivedByDate { get; set; }
        public string dateAcquired { get; set; }
        public int Amount { get; set; }
    }
}
