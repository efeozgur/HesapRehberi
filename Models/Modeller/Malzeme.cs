using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("Malzeme")]
    public class Malzeme
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string malzemeAdi { get; set; }
        [StringLength(200)]
        public string malzemeOzelligi { get; set; }        
        public int miktari { get; set; }
        [StringLength(15),Required]
        public string olcuBirimi { get; set; }
        public int kdvOrani { get; set; }
        public virtual YaklasikMaliyet YaklasikMaliyet { get; set; }
        public virtual FiyatIsteme FiyatIsteme { get; set; }


    }
}