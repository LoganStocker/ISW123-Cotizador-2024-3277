using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioM
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void gpCotizador_Enter(object sender, EventArgs e)
        {

        }

        private void btnimperativo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;
            lstResultados.Items.Add($" [imperativo] {huesped}: US$ {total:N2}");

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            txtHuesped.Clear();
            txtTarifa.Clear();
            nudNoches.Value = 1;
            chkTemporadaAlta.Checked = false;

            lblsubtotal2.Text = lbldescuento1.Text = lblitibis.Text =
                lblservicio1.Text = lbltotal1.Text = "0.00";

            txtHuesped.Focus();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHuesped.Text))
            {
                MessageBox.Show("Escribe el nombre del huésped.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuesped.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Dato incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                txtTarifa.SelectAll();
                return;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa,
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };

            lblsubtotal2.Text = reserva.Subtotal.ToString("N2");
            lbldescuento1.Text = "-" + reserva.Descuento.ToString("N2");
            lblitibis.Text = reserva.Itbis.ToString("N2");
            lblservicio1.Text = reserva.Servicio.ToString("N2");
            lbltotal1.Text = reserva.Total.ToString("N2");
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0.00")
            {
                MessageBox.Show("Primero calcula una cotización.", "Nada que copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var texto = $"""
            *Cotización Villa Coral*
            Huésped: {txtHuesped.Text}
            Noches: {nudNoches.Value}
            Subtotal: US$ {lblsubtotal2.Text}
            Descuento: US$ {lbldescuento1.Text}
            ITBIS 18%: US$ {lblitibis.Text}
            Servicio 10%: US$ {lblservicio1.Text}
            *TOTAL: US$ {lbltotal1.Text}*
            """;

            Clipboard.SetText(texto);

            MessageBox.Show("Cotización copiada. Ya puedes pegarla en WhatsApp.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b;

            decimal r2 = 10 / 4m;

            int x = 5;
            x = x + 2;
            x = x * 3;

            decimal p = 200m;
            decimal r3 = p * 0.18m;

            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }

            int n2 = 7;
            bool larga = n2 >= 7;

            string s = "Villa" + "Coral";

            int n3 = 4;
            decimal t = 100m;
            decimal total = n3 * t * 1.28m;

            decimal t2 = 120m;
            t2 = t2 + t2 * 0.25m;

            int noches = (int)8.9m;

            MessageBox.Show(
            $"r = {r}\n" +
            $"r2 = {r2}\n" +
            $"x = {x}\n" +
            $"r3 = {r3}\n" +
            $"d = {d}\n" +
            $"larga = {larga}\n" +
            $"s = {s}\n" +
            $"total = {total}\n" +
            $"t2 = {t2}\n" +
            $"noches = {noches}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal tasa = nudTasa.Value;
            decimal pesos = reserva.Total * tasa;
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal porPersona = reserva.Total / nudPersonas.Value;
            lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;

            lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal tarifa = nudTarifa.Value;
            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };

            lstResultados.Items.Add($"Total: US$ {reserva.Total:N2}");
        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            lstResultados.Items.Add($"Subtotal: US$ {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento: US$ {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base imponible: US$ {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"ITBIS: US$ {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio: US$ {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total: US$ {reserva.Total:N2}");
        }

        private void btnTrasladoA_Click(object sender, EventArgs e)
        {
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = 3,
                Nocturno = true
            };

            lstResultados.Items.Add($"Total traslado: US$ {traslado.Total:N2}");
        }

        private void btnExcursion_Click(object sender, EventArgs e)
        {
            var excursion = new Excursion
            {
                Personas = 5,
                PrecioPorPersona = 80m
            };

            lstResultados.Items.Add($"Total excursión: US$ {excursion.Total:N2}");
        }

        private void btnConsumoMinibar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = 9,
                PrecioUnitario = 3.50m
            };

            lstResultados.Items.Add($"Total minibar: US$ {minibar.Total:N2}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = 3,
                Nocturno = true
            };

            var excursion = new Excursion
            {
                Personas = 5,
                PrecioPorPersona = 80m
            };

            var minibar = new ConsumoMinibar
            {
                Cantidad = 9,
                PrecioUnitario = 3.50m
            };

            decimal cuentaTotal = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
            lstResultados.Items.Add($"Cuenta total: US$ {cuentaTotal:N2}");
        }
    }
}
