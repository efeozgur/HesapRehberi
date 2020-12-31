using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("KanitlayiciBelgeler")]
    public class KanitlayiciBelgeler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required]
        public string belgeAdi { get; set; }
        public virtual IsTanimi IsTanimi { get; set; }
    }
}