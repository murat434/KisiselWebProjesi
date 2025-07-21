using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesi.Models.siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string profil { get; set; }
        public string isim { get; set; }
        public string unvan { get; set; }
        public string aciklama { get; set; }
        public int iletisim { get; set; }


    }
}