using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
      //  [Display(Name = "Descrição")]
      //  public List<Produto> Produtos { get; set; }

    }
}
