using System;
namespace LezzetAvcısıBlog.Models
{
	public class Tarif
	{
		public int id { get; set; }
        public string baslik { get; set; }
        public string tarif { get; set; }
        public string resimImgPath { get; set; }
        public int kullanici_id { get; set; }
    }
}

