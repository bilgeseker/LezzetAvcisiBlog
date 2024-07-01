using System;
namespace LezzetAvcısıBlog.Models
{
	public class Kullanici
	{
        
		public int id { get; set; }
		public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }
        public int? tarif_id { get; set; }
    }
}

