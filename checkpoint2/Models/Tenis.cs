using System.ComponentModel.DataAnnotations;
namespace Checkpoint2.Models
{
    public class Tenis
    {
        public int Id { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public GeneroTenis Genero { get; set; }
        public int Numero { get; set; }

        public decimal Preco { get; set; }

        [Display(Name = "Disponível")]
        public bool EmEstoque { get; set; }

    }
    public enum GeneroTenis
    {
        Feminino,Masculino,Unisex
    }
}
