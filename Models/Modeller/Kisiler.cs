using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("Kisiler")]
    public class Kisiler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50), Required]
        public string adSoyad { get; set; }
        [StringLength(50), Required]
        public string unvan { get; set; }
        public virtual YaklasikMaliyet YaklasikMaliyet { get; set; }
        public virtual FiyatIsteme FiyatIsteme { get; set; } 
    }
}