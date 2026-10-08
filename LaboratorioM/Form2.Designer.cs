namespace LaboratorioM
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpCotizador = new GroupBox();
            nudTarifa = new NumericUpDown();
            chkTemporadaAlta = new CheckBox();
            txtTarifa = new TextBox();
            lblTarifaPorNoche = new Label();
            nudNoches = new NumericUpDown();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            lblHuesped = new Label();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            gbTotales = new GroupBox();
            lblitibis = new Label();
            lblservicio1 = new Label();
            lbltotal1 = new Label();
            lblsubtotal2 = new Label();
            lbldescuento1 = new Label();
            lblItbis = new Label();
            lblServicio = new Label();
            lblTotal = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            btncopiar = new Button();
            lstResultados = new ListBox();
            btnimperativo = new Button();
            btnNivel1 = new Button();
            btnNivel2 = new Button();
            nudTasa = new NumericUpDown();
            label1 = new Label();
            btnPesos = new Button();
            nudPersonas = new NumericUpDown();
            btnPorPersona = new Button();
            label2 = new Label();
            btnDeposito = new Button();
            chkFinSemana = new CheckBox();
            button1 = new Button();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            gpCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            SuspendLayout();
            // 
            // gpCotizador
            // 
            gpCotizador.Controls.Add(nudTarifa);
            gpCotizador.Controls.Add(chkTemporadaAlta);
            gpCotizador.Controls.Add(txtTarifa);
            gpCotizador.Controls.Add(lblTarifaPorNoche);
            gpCotizador.Controls.Add(nudNoches);
            gpCotizador.Controls.Add(txtHuesped);
            gpCotizador.Controls.Add(lblNoches);
            gpCotizador.Controls.Add(lblHuesped);
            gpCotizador.Location = new Point(29, 12);
            gpCotizador.Name = "gpCotizador";
            gpCotizador.Size = new Size(431, 289);
            gpCotizador.TabIndex = 9;
            gpCotizador.TabStop = false;
            gpCotizador.Text = "Cotizador";
            gpCotizador.Enter += gpCotizador_Enter;
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(159, 178);
            nudTarifa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 16;
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Location = new Point(13, 214);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(178, 24);
            chkTemporadaAlta.TabIndex = 15;
            chkTemporadaAlta.Text = "Temporada alta +25%";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(10, 178);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 14;
            // 
            // lblTarifaPorNoche
            // 
            lblTarifaPorNoche.AutoSize = true;
            lblTarifaPorNoche.Location = new Point(9, 150);
            lblTarifaPorNoche.Name = "lblTarifaPorNoche";
            lblTarifaPorNoche.Size = new Size(149, 20);
            lblTarifaPorNoche.TabIndex = 13;
            lblTarifaPorNoche.Text = "Tarifa por noche USD";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(10, 111);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 12;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(9, 58);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(408, 27);
            txtHuesped.TabIndex = 11;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(9, 88);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(61, 20);
            lblNoches.TabIndex = 10;
            lblNoches.Text = "Noches:";
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(9, 30);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 9;
            lblHuesped.Text = "Huesped:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(129, 475);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 475);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblitibis);
            gbTotales.Controls.Add(lblservicio1);
            gbTotales.Controls.Add(lbltotal1);
            gbTotales.Controls.Add(lblsubtotal2);
            gbTotales.Controls.Add(lbldescuento1);
            gbTotales.Controls.Add(lblItbis);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Location = new Point(29, 307);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(431, 162);
            gbTotales.TabIndex = 18;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblitibis
            // 
            lblitibis.AutoSize = true;
            lblitibis.Location = new Point(101, 84);
            lblitibis.Name = "lblitibis";
            lblitibis.Size = new Size(17, 20);
            lblitibis.TabIndex = 9;
            lblitibis.Text = "0";
            // 
            // lblservicio1
            // 
            lblservicio1.AutoSize = true;
            lblservicio1.Location = new Point(101, 110);
            lblservicio1.Name = "lblservicio1";
            lblservicio1.Size = new Size(17, 20);
            lblservicio1.TabIndex = 8;
            lblservicio1.Text = "0";
            // 
            // lbltotal1
            // 
            lbltotal1.AutoSize = true;
            lbltotal1.Location = new Point(101, 136);
            lbltotal1.Name = "lbltotal1";
            lbltotal1.Size = new Size(17, 20);
            lbltotal1.TabIndex = 7;
            lbltotal1.Text = "0";
            // 
            // lblsubtotal2
            // 
            lblsubtotal2.AutoSize = true;
            lblsubtotal2.Location = new Point(101, 32);
            lblsubtotal2.Name = "lblsubtotal2";
            lblsubtotal2.Size = new Size(17, 20);
            lblsubtotal2.TabIndex = 6;
            lblsubtotal2.Text = "0";
            // 
            // lbldescuento1
            // 
            lbldescuento1.AutoSize = true;
            lbldescuento1.Location = new Point(101, 58);
            lbldescuento1.Name = "lbldescuento1";
            lbldescuento1.Size = new Size(17, 20);
            lbldescuento1.TabIndex = 5;
            lbldescuento1.Text = "0";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(13, 85);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(46, 20);
            lblItbis.TabIndex = 4;
            lblItbis.Text = "ITIBIS";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(13, 111);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(61, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "Servicio";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 137);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(13, 33);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(13, 59);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento";
            // 
            // btncopiar
            // 
            btncopiar.Location = new Point(31, 513);
            btncopiar.Name = "btncopiar";
            btncopiar.Size = new Size(415, 29);
            btncopiar.TabIndex = 19;
            btncopiar.Text = "COPIAR PARA WHATSAPP";
            btncopiar.UseVisualStyleBackColor = true;
            btncopiar.Click += btncopiar_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(800, 12);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(440, 464);
            lstResultados.TabIndex = 20;
            // 
            // btnimperativo
            // 
            btnimperativo.Location = new Point(800, 492);
            btnimperativo.Name = "btnimperativo";
            btnimperativo.Size = new Size(94, 29);
            btnimperativo.TabIndex = 21;
            btnimperativo.Text = "Imperativo";
            btnimperativo.UseVisualStyleBackColor = true;
            btnimperativo.Click += btnimperativo_Click;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(41, 583);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 22;
            btnNivel1.Text = "NIVEL1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // btnNivel2
            // 
            btnNivel2.Location = new Point(141, 583);
            btnNivel2.Name = "btnNivel2";
            btnNivel2.Size = new Size(94, 29);
            btnNivel2.TabIndex = 23;
            btnNivel2.Text = "NIVEL 2";
            btnNivel2.UseVisualStyleBackColor = true;
            btnNivel2.Click += button1_Click;
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(489, 70);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(150, 27);
            nudTasa.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 42);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 25;
            label1.Text = "Tasa del dólar";
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(489, 103);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(129, 29);
            btnPesos.TabIndex = 27;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(489, 178);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(150, 27);
            nudPersonas.TabIndex = 28;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(489, 213);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(197, 29);
            btnPorPersona.TabIndex = 29;
            btnPorPersona.Text = "Personas por personas";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 30;
            label2.Text = "Personas";
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(487, 248);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(94, 29);
            btnDeposito.TabIndex = 31;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(489, 293);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 32;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 33;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(489, 323);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(94, 29);
            btnFinSemana.TabIndex = 34;
            btnFinSemana.Text = "FinSemana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.UseWaitCursor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(489, 361);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(94, 29);
            btnDesglose.TabIndex = 35;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 763);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(button1);
            Controls.Add(chkFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(label2);
            Controls.Add(btnPorPersona);
            Controls.Add(nudPersonas);
            Controls.Add(btnPesos);
            Controls.Add(label1);
            Controls.Add(nudTasa);
            Controls.Add(btnNivel2);
            Controls.Add(btnNivel1);
            Controls.Add(btnimperativo);
            Controls.Add(lstResultados);
            Controls.Add(btncopiar);
            Controls.Add(btnLimpiar);
            Controls.Add(gbTotales);
            Controls.Add(btnCalcular);
            Controls.Add(gpCotizador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral Logan Stocker 2024 3277";
            Load += frmInicio_Load;
            gpCotizador.ResumeLayout(false);
            gpCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpCotizador;
        private CheckBox chkTemporadaAlta;
        private TextBox txtTarifa;
        private Label lblTarifaPorNoche;
        private NumericUpDown nudNoches;
        private TextBox txtHuesped;
        private Label lblNoches;
        private Label lblHuesped;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox gbTotales;
        private Label lblitibis;
        private Label lblservicio1;
        private Label lbltotal1;
        private Label lblsubtotal2;
        private Label lbldescuento1;
        private Label lblItbis;
        private Label lblServicio;
        private Label lblTotal;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Button btncopiar;
        private ListBox lstResultados;
        private Button btnimperativo;
        private Button btnNivel1;
        private Button btnNivel2;
        private NumericUpDown nudTarifa;
        private NumericUpDown nudTasa;
        private Label label1;
        private Button btnPesos;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Label label2;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button button1;
        private Button btnFinSemana;
        private Button btnDesglose;
    }
}