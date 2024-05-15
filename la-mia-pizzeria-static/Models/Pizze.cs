using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace la_mia_pizzeria_static.Models
{
    [Table("Pizze")]
    public class Pizze
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string UrlFoto { get; set; }
        public double Prezzo { get; set; }

        public Pizze() { }
        public Pizze(int id ,string nome, string descrizione, string urlfoto, double prezzo)
        {
            this.ID = id;
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.UrlFoto = urlfoto;
            this.Prezzo = prezzo;
        }
    }

}


