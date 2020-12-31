using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("Firma")]
    public class Firma
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string firmaAdi { get; set; }
        [StringLength(11)]
        public string firmaTelefon { get; set; }
        [StringLength(200), Required]
        public string firmaAdresi { get; set; }
        public double birimfiyat { get; set; }        
        

    }
}