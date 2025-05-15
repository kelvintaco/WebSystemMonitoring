using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinal.Models
{
    public class Items
    {
        [Key]
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDeets { get; set; }
        public double Price { get; set; }
        public int isonBorrow { get; set; }
        public int isnotonBorrow { get; set; }
        public bool Servicable { get; set; }
        public bool NonServ { get; set; }
        public string Place { get; set; }
        public int LifeTime { get; set; }
    }
}
