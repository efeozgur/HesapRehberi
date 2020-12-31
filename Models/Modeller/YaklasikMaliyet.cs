using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HesapRehberi.Models.Modeller
{
    [Table("YaklasikMaliyet")]
    public class YaklasikMaliyet
    {
        public int ID { get; set; }
        public double birimFiyat { get; set; }
        public virtual List<Firma> Firma { get; set; }
        public virtual IsTanimi IsTanimi { get; set; }
        public virtual List<Kisiler> Kisiler { get; set; }
        public virtual List<Malzeme> Malzeme { get; set; }
        public double BirimOrtalama
        {
            get
            {
                return BirimOrtalama;
            }
            set
            {
                foreach (var item in Firma)
                {
                    BirimOrtalama += item.birimfiyat;
                }
            }
        }
        public double ToplamOrtalama { get; set; }

        
       
    }

    
}