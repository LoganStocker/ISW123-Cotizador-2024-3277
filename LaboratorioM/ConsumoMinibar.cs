using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioM
{
  public class ConsumoMinibar
   {
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal => Cantidad * PrecioUnitario;
    public decimal Itbis => Subtotal * 0.18m;
    public decimal Total => Subtotal + Itbis;

   }
   
}
