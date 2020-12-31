using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("FiyatIsteme")]
    public class FiyatIsteme
    {
        public int ID { get; set; }
        public string metin { get; set; }
        public Dictionary<string, double> Sartlar { get; set; }

        public virtual List<Kisiler> Kisiler { get; set; }

        public virtual List<Malzeme> Malzemeler { get; set; }


    }
}