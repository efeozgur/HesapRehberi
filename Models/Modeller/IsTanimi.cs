using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("IsTanimi")]
    public class IsTanimi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(15), Required]
        public string dosyaNo { get; set; }
        [StringLength(100), Required]
        public string isinAdi { get; set; }

        public virtual List<YaklasikMaliyet> YaklasikMaliyet { get; set; }        
        public virtual List<KanitlayiciBelgeler> KanitlayiciBelge { get; set; }


    }
}