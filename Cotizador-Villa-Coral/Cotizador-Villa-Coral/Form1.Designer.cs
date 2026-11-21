namespace Cotizador_Villa_Coral
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHuesped = new Label();
            lblTarifa = new Label();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            txtbHuesped = new TextBox();
            gbCotizacion = new GroupBox();
            lblTOTALn = new Label();
            lblServicioN = new Label();
            lblITBISn = new Label();
            lblDescuentoN = new Label();
            lblSubtotalN = new Label();
            lblTOTAL = new Label();
            lblSubTotal = new Label();
            lblDescuento = new Label();
            lblITBIS = new Label();
            lblServicio = new Label();
            btnImperativo = new Button();
            btnObjetos = new Button();
            btnFuncional = new Button();
            nudTarifa = new NumericUpDown();
            lstResultados = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(63, 72);
            lblHuesped.Margin = new Padding(4, 0, 4, 0);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(95, 30);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(63, 250);
            lblTarifa.Margin = new Padding(4, 0, 4, 0);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(230, 30);
            lblTarifa.TabIndex = 1;
            lblTarifa.Text = "Tarifa por noches (USD)";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(63, 159);
            lblNoches.Margin = new Padding(4, 0, 4, 0);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(83, 30);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches";
            lblNoches.Click += label3_Click;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(448, 159);
            nudNoches.Margin = new Padding(4);
            nudNoches.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(225, 35);
            nudNoches.TabIndex = 4;
            nudNoches.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // txtbHuesped
            // 
            txtbHuesped.Location = new Point(448, 72);
            txtbHuesped.Margin = new Padding(4);
            txtbHuesped.Name = "txtbHuesped";
            txtbHuesped.Size = new Size(186, 35);
            txtbHuesped.TabIndex = 6;
            // 
            // gbCotizacion
            // 
            gbCotizacion.Controls.Add(lblTOTALn);
            gbCotizacion.Controls.Add(lblServicioN);
            gbCotizacion.Controls.Add(lblITBISn);
            gbCotizacion.Controls.Add(lblDescuentoN);
            gbCotizacion.Controls.Add(lblSubtotalN);
            gbCotizacion.Controls.Add(lblTOTAL);
            gbCotizacion.Controls.Add(lblSubTotal);
            gbCotizacion.Controls.Add(lblDescuento);
            gbCotizacion.Controls.Add(lblITBIS);
            gbCotizacion.Controls.Add(lblServicio);
            gbCotizacion.Location = new Point(63, 489);
            gbCotizacion.Margin = new Padding(4);
            gbCotizacion.Name = "gbCotizacion";
            gbCotizacion.Padding = new Padding(4);
            gbCotizacion.Size = new Size(692, 339);
            gbCotizacion.TabIndex = 9;
            gbCotizacion.TabStop = false;
            gbCotizacion.Text = "Cotizacion";
            gbCotizacion.Enter += groupBox1_Enter;
            // 
            // lblTOTALn
            // 
            lblTOTALn.AutoSize = true;
            lblTOTALn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTOTALn.Location = new Point(498, 278);
            lblTOTALn.Margin = new Padding(4, 0, 4, 0);
            lblTOTALn.Name = "lblTOTALn";
            lblTOTALn.Size = new Size(67, 36);
            lblTOTALn.TabIndex = 19;
            lblTOTALn.Text = "0.00";
            // 
            // lblServicioN
            // 
            lblServicioN.AutoSize = true;
            lblServicioN.Location = new Point(498, 220);
            lblServicioN.Margin = new Padding(4, 0, 4, 0);
            lblServicioN.Name = "lblServicioN";
            lblServicioN.Size = new Size(51, 30);
            lblServicioN.TabIndex = 18;
            lblServicioN.Text = "0.00";
            // 
            // lblITBISn
            // 
            lblITBISn.AutoSize = true;
            lblITBISn.Location = new Point(498, 170);
            lblITBISn.Margin = new Padding(4, 0, 4, 0);
            lblITBISn.Name = "lblITBISn";
            lblITBISn.Size = new Size(51, 30);
            lblITBISn.TabIndex = 17;
            lblITBISn.Text = "0.00";
            // 
            // lblDescuentoN
            // 
            lblDescuentoN.AutoSize = true;
            lblDescuentoN.Location = new Point(498, 112);
            lblDescuentoN.Margin = new Padding(4, 0, 4, 0);
            lblDescuentoN.Name = "lblDescuentoN";
            lblDescuentoN.Size = new Size(51, 30);
            lblDescuentoN.TabIndex = 16;
            lblDescuentoN.Text = "0.00";
            // 
            // lblSubtotalN
            // 
            lblSubtotalN.AutoSize = true;
            lblSubtotalN.Location = new Point(498, 62);
            lblSubtotalN.Margin = new Padding(4, 0, 4, 0);
            lblSubtotalN.Name = "lblSubtotalN";
            lblSubtotalN.Size = new Size(51, 30);
            lblSubtotalN.TabIndex = 15;
            lblSubtotalN.Text = "0.00";
            // 
            // lblTOTAL
            // 
            lblTOTAL.AutoSize = true;
            lblTOTAL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTOTAL.Location = new Point(22, 278);
            lblTOTAL.Margin = new Padding(4, 0, 4, 0);
            lblTOTAL.Name = "lblTOTAL";
            lblTOTAL.Size = new Size(92, 36);
            lblTOTAL.TabIndex = 14;
            lblTOTAL.Text = "TOTAL";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(22, 62);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(92, 30);
            lblSubTotal.TabIndex = 10;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(22, 112);
            lblDescuento.Margin = new Padding(4, 0, 4, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(112, 30);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "Descuento";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(22, 170);
            lblITBIS.Margin = new Padding(4, 0, 4, 0);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(104, 30);
            lblITBIS.TabIndex = 12;
            lblITBIS.Text = "ITBIS 18%";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(22, 220);
            lblServicio.Margin = new Padding(4, 0, 4, 0);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(129, 30);
            lblServicio.TabIndex = 13;
            lblServicio.Text = "Servicio 10%";
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(76, 381);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(131, 40);
            btnImperativo.TabIndex = 10;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            // 
            // btnObjetos
            // 
            btnObjetos.Location = new Point(268, 381);
            btnObjetos.Name = "btnObjetos";
            btnObjetos.Size = new Size(131, 40);
            btnObjetos.TabIndex = 11;
            btnObjetos.Text = "Objetos";
            btnObjetos.UseVisualStyleBackColor = true;
            // 
            // btnFuncional
            // 
            btnFuncional.Location = new Point(463, 381);
            btnFuncional.Name = "btnFuncional";
            btnFuncional.Size = new Size(131, 40);
            btnFuncional.TabIndex = 12;
            btnFuncional.Text = "Funcional";
            btnFuncional.UseVisualStyleBackColor = true;
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(448, 250);
            nudTarifa.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(210, 35);
            nudTarifa.TabIndex = 13;
            nudTarifa.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.IntegralHeight = false;
            lstResultados.Location = new Point(878, 85);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(500, 180);
            lstResultados.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(893, 139);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 15;
            label1.Text = "Resultados de los paradigmas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 848);
            Controls.Add(label1);
            Controls.Add(lstResultados);
            Controls.Add(nudTarifa);
            Controls.Add(btnFuncional);
            Controls.Add(btnObjetos);
            Controls.Add(btnImperativo);
            Controls.Add(gbCotizacion);
            Controls.Add(txtbHuesped);
            Controls.Add(nudNoches);
            Controls.Add(lblNoches);
            Controls.Add(lblTarifa);
            Controls.Add(lblHuesped);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Cotizador Villa Coral - Eudy Acosta Gutierrez 2026-0581";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizacion.ResumeLayout(false);
            gbCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private Label lblTarifa;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private TextBox txtbTarifa;
        private TextBox txtbHuesped;
        private GroupBox gbCotizacion;
        private Label lblSubtotalN;
        private Label lblTOTAL;
        private Label lblSubTotal;
        private Label lblDescuento;
        private Label lblITBIS;
        private Label lblServicio;
        private Label lblTOTALn;
        private Label lblServicioN;
        private Label lblITBISn;
        private Label lblDescuentoN;
        private Button btnImperativo;
        private Button btnObjetos;
        private Button btnFuncional;
        private NumericUpDown nudTarifa;
        private ListBox lstResultados;
        private Label label1;
    }
}
