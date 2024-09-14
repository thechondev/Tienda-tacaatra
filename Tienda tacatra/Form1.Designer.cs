namespace Tienda_tacatra
{
    partial class Wtienda
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
            lblproducto = new Label();
            cmdquitar = new Button();
            txtproducto = new TextBox();
            cmdagregarprod = new Button();
            cmdAgventa = new Button();
            lblvalorunitario = new Label();
            lblproductos = new Label();
            label4 = new Label();
            txtvaloruni = new TextBox();
            cboAProductos = new ComboBox();
            txtcantidadven = new TextBox();
            lblPRmasvendido = new Label();
            lblPRmenosvendido = new Label();
            lblmenosvendidot = new Label();
            lblmasvendidotexto = new Label();
            dgvProductos = new DataGridView();
            Cproductos = new DataGridViewTextBoxColumn();
            Ccantidad = new DataGridViewTextBoxColumn();
            Cvalor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblproducto.Location = new Point(39, 26);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(64, 17);
            lblproducto.TabIndex = 0;
            lblproducto.Text = "Producto";
            // 
            // cmdquitar
            // 
            cmdquitar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmdquitar.Location = new Point(390, 110);
            cmdquitar.Name = "cmdquitar";
            cmdquitar.Size = new Size(75, 23);
            cmdquitar.TabIndex = 1;
            cmdquitar.Text = "Quitar";
            cmdquitar.UseVisualStyleBackColor = true;
            cmdquitar.Click += cmdquitar_Click;
            // 
            // txtproducto
            // 
            txtproducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtproducto.Location = new Point(124, 22);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(205, 25);
            txtproducto.TabIndex = 2;
            // 
            // cmdagregarprod
            // 
            cmdagregarprod.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmdagregarprod.Location = new Point(359, 22);
            cmdagregarprod.Name = "cmdagregarprod";
            cmdagregarprod.Size = new Size(146, 25);
            cmdagregarprod.TabIndex = 3;
            cmdagregarprod.Text = "Agregar producto";
            cmdagregarprod.UseVisualStyleBackColor = true;
            cmdagregarprod.Click += cmdagregarprod_Click;
            // 
            // cmdAgventa
            // 
            cmdAgventa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cmdAgventa.Location = new Point(359, 152);
            cmdAgventa.Name = "cmdAgventa";
            cmdAgventa.Size = new Size(146, 25);
            cmdAgventa.TabIndex = 4;
            cmdAgventa.Text = "Agregar venta";
            cmdAgventa.UseVisualStyleBackColor = true;
            cmdAgventa.Click += cmdAgventa_Click;
            // 
            // lblvalorunitario
            // 
            lblvalorunitario.AutoSize = true;
            lblvalorunitario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblvalorunitario.Location = new Point(27, 69);
            lblvalorunitario.Name = "lblvalorunitario";
            lblvalorunitario.Size = new Size(89, 17);
            lblvalorunitario.TabIndex = 5;
            lblvalorunitario.Text = "Valor unitario";
            // 
            // lblproductos
            // 
            lblproductos.AutoSize = true;
            lblproductos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblproductos.Location = new Point(36, 113);
            lblproductos.Name = "lblproductos";
            lblproductos.Size = new Size(70, 17);
            lblproductos.TabIndex = 6;
            lblproductos.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(14, 156);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 7;
            label4.Text = "Cantidad vendida";
            // 
            // txtvaloruni
            // 
            txtvaloruni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtvaloruni.Location = new Point(178, 65);
            txtvaloruni.Name = "txtvaloruni";
            txtvaloruni.Size = new Size(97, 25);
            txtvaloruni.TabIndex = 8;
            txtvaloruni.KeyPress += txtvaloruni_KeyPress;
            // 
            // cboAProductos
            // 
            cboAProductos.FormattingEnabled = true;
            cboAProductos.Location = new Point(124, 110);
            cboAProductos.Name = "cboAProductos";
            cboAProductos.Size = new Size(205, 23);
            cboAProductos.TabIndex = 10;
            cboAProductos.KeyPress += cboAProductos_KeyPress;
            // 
            // txtcantidadven
            // 
            txtcantidadven.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtcantidadven.Location = new Point(202, 152);
            txtcantidadven.Name = "txtcantidadven";
            txtcantidadven.Size = new Size(49, 25);
            txtcantidadven.TabIndex = 11;
            // 
            // lblPRmasvendido
            // 
            lblPRmasvendido.AutoSize = true;
            lblPRmasvendido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPRmasvendido.Location = new Point(246, 446);
            lblPRmasvendido.Name = "lblPRmasvendido";
            lblPRmasvendido.Size = new Size(222, 17);
            lblPRmasvendido.TabIndex = 12;
            lblPRmasvendido.Text = "No hay productos menos vendidos";
            // 
            // lblPRmenosvendido
            // 
            lblPRmenosvendido.AutoSize = true;
            lblPRmenosvendido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPRmenosvendido.Location = new Point(254, 475);
            lblPRmenosvendido.Name = "lblPRmenosvendido";
            lblPRmenosvendido.Size = new Size(206, 17);
            lblPRmenosvendido.TabIndex = 13;
            lblPRmenosvendido.Text = "No hay productos mas vendidos";
            // 
            // lblmenosvendidot
            // 
            lblmenosvendidot.AutoSize = true;
            lblmenosvendidot.FlatStyle = FlatStyle.Popup;
            lblmenosvendidot.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblmenosvendidot.Location = new Point(14, 475);
            lblmenosvendidot.Name = "lblmenosvendidot";
            lblmenosvendidot.Size = new Size(183, 17);
            lblmenosvendidot.TabIndex = 14;
            lblmenosvendidot.Text = "Producto de menos ingresos";
            // 
            // lblmasvendidotexto
            // 
            lblmasvendidotexto.AutoSize = true;
            lblmasvendidotexto.FlatStyle = FlatStyle.Popup;
            lblmasvendidotexto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblmasvendidotexto.Location = new Point(14, 446);
            lblmasvendidotexto.Name = "lblmasvendidotexto";
            lblmasvendidotexto.Size = new Size(146, 17);
            lblmasvendidotexto.TabIndex = 15;
            lblmasvendidotexto.Text = "Producto mas vendido";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Cproductos, Ccantidad, Cvalor });
            dgvProductos.Location = new Point(14, 207);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(491, 209);
            dgvProductos.TabIndex = 16;
            // 
            // Cproductos
            // 
            Cproductos.HeaderText = "Productos";
            Cproductos.Name = "Cproductos";
            // 
            // Ccantidad
            // 
            Ccantidad.HeaderText = "Cantidad";
            Ccantidad.Name = "Ccantidad";
            // 
            // Cvalor
            // 
            Cvalor.HeaderText = "Valor";
            Cvalor.Name = "Cvalor";
            // 
            // Wtienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 514);
            Controls.Add(dgvProductos);
            Controls.Add(lblmasvendidotexto);
            Controls.Add(lblmenosvendidot);
            Controls.Add(lblPRmenosvendido);
            Controls.Add(lblPRmasvendido);
            Controls.Add(txtcantidadven);
            Controls.Add(cboAProductos);
            Controls.Add(txtvaloruni);
            Controls.Add(label4);
            Controls.Add(lblproductos);
            Controls.Add(lblvalorunitario);
            Controls.Add(cmdAgventa);
            Controls.Add(cmdagregarprod);
            Controls.Add(txtproducto);
            Controls.Add(cmdquitar);
            Controls.Add(lblproducto);
            Name = "Wtienda";
            Text = "Tienda tacaatra";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblproducto;
        private Button cmdquitar;
        private TextBox txtproducto;
        private Button cmdagregarprod;
        private Button cmdAgventa;
        private Label lblvalorunitario;
        private Label lblproductos;
        private Label label4;
        private TextBox txtvaloruni;
        private ComboBox cboAProductos;
        private TextBox txtcantidadven;
        private Label lblPRmasvendido;
        private Label lblPRmenosvendido;
        private Label lblmenosvendidot;
        private Label lblmasvendidotexto;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Cproductos;
        private DataGridViewTextBoxColumn Ccantidad;
        private DataGridViewTextBoxColumn Cvalor;
    }
}
