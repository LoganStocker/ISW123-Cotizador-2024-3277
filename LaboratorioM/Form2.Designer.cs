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
            btnLimpiar = new Button();
            btnCalcular = new Button();
            Temporada = new CheckBox();
            txtTarifaPorNoche = new TextBox();
            lblTarifaPorNoche = new Label();
            nudNoches = new NumericUpDown();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            lblHuesped = new Label();
            gbTotales = new GroupBox();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblItbis = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            gpCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // gpCotizador
            // 
            gpCotizador.Controls.Add(Temporada);
            gpCotizador.Controls.Add(txtTarifaPorNoche);
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
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(129, 475);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 475);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Temporada
            // 
            Temporada.AutoSize = true;
            Temporada.Location = new Point(13, 214);
            Temporada.Name = "Temporada";
            Temporada.Size = new Size(178, 24);
            Temporada.TabIndex = 15;
            Temporada.Text = "Temporada alta +25%";
            Temporada.UseVisualStyleBackColor = true;
            // 
            // txtTarifaPorNoche
            // 
            txtTarifaPorNoche.Location = new Point(10, 178);
            txtTarifaPorNoche.Name = "txtTarifaPorNoche";
            txtTarifaPorNoche.Size = new Size(125, 27);
            txtTarifaPorNoche.TabIndex = 14;
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
            // gbTotales
            // 
            gbTotales.Controls.Add(label1);
            gbTotales.Controls.Add(label2);
            gbTotales.Controls.Add(label3);
            gbTotales.Controls.Add(label4);
            gbTotales.Controls.Add(label5);
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
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(13, 59);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento";
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
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 137);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
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
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(13, 85);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(46, 20);
            lblItbis.TabIndex = 4;
            lblItbis.Text = "ITIBIS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 84);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 9;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 110);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 8;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 136);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 7;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 32);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 58);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 5;
            label5.Text = "0";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
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
            gpCotizador.ResumeLayout(false);
            gpCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpCotizador;
        private CheckBox Temporada;
        private TextBox txtTarifaPorNoche;
        private Label lblTarifaPorNoche;
        private NumericUpDown nudNoches;
        private TextBox txtHuesped;
        private Label lblNoches;
        private Label lblHuesped;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox gbTotales;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblItbis;
        private Label lblServicio;
        private Label lblTotal;
        private Label lblSubtotal;
        private Label lblDescuento;
    }
}