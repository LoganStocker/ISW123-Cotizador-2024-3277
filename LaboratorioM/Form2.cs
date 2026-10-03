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
    }
}
