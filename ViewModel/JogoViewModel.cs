using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogo_jogos_DIO.ViewModel
{
  public class JogoViewModel
  {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Produtora { get; set; }
    public double preco{set;get;}
  }
}