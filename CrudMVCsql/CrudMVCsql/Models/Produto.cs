using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVCsql.Models
{
    [Table("produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Fabricante")]
        [Display(Name = "fabricante")]
        public string fabricante { get; set; }

        [Column("Categoria")]
        [Display(Name = "categoria")]
        public string categoria { get; set; }

        [Column("Quantidade")]
        [Display(Name = "quantidade")]
        public int quantidade{ get; set; }

        [Column("valor")]
        [Display(Name = "valor")]
        public double valor{ get; set; }





    }
}
