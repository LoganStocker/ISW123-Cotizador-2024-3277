using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioM
{

    public static class SistemaViejo
    {
        public static decimal CalcularDeposito(decimal total)
        {
            decimal porcentaje = 0.30m;
            decimal deposito = total * porcentaje;
            return deposito;
        }

        public static decimal APesos(decimal dolares, decimal tasa)
        {
            decimal pesos = dolares * tasa;
            return pesos;
        }

        public static decimal TarifaFinDeSemana(decimal tarifa, bool esFinDeSemana)
        {
            if (esFinDeSemana)
            {
                return tarifa * 1.15m;
            }
            return tarifa;
        }

        public static decimal TotalExcursion(int personas, decimal precioPorPersona)
        {
            decimal subtotal = personas * precioPorPersona;
            decimal descuento = personas >= 4 ? subtotal * 0.10m : 0m;
            return subtotal - descuento;
        }

        public static decimal TotalMinibar(int cantidad, decimal precioUnitario)
        {
            decimal subtotal = cantidad * precioUnitario;
            decimal itbis = subtotal * 0.18m;
            return subtotal + itbis;
        }
    }
}
