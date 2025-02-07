using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class Custodian
    {
        [Key]
        public string CSTCode { get; set; }
        public string CSTName { get; set; }
        public string DPRName { get; set; }
    }
}
