using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace la_mia_pizzeria_static.data
{
    [Table("Pizze")]
    public class Pizze
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descrizione { get; set; }
        [Required]
        public string UrlFoto { get; set; }
        [Required]
        public double Prezzo { get; set; }

        public Pizze() { }
        public Pizze( string nome, string descrizione, string urlfoto, double prezzo)
        {
          
            Nome = nome;
            Descrizione = descrizione;
            UrlFoto = urlfoto;
            Prezzo = prezzo;
        }
    }

}


