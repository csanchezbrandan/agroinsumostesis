namespace CapaPresentacion
{
    partial class Cliente
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelEdAgEl = new System.Windows.Forms.TableLayoutPanel();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelbuscar = new System.Windows.Forms.TableLayoutPanel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefre = new System.Windows.Forms.Button();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelEdAgEl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanelbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelGeneral.ColumnCount = 1;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.dataGridViewCliente, 0, 1);
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 3;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(1013, 520);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.1161F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8839F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelEdAgEl, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labeltitulo, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1013, 81);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // tableLayoutPanelEdAgEl
            // 
            this.tableLayoutPanelEdAgEl.ColumnCount = 3;
            this.tableLayoutPanelEdAgEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdAgEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdAgEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdAgEl.Controls.Add(this.btneliminar, 2, 0);
            this.tableLayoutPanelEdAgEl.Controls.Add(this.btnagregar, 1, 0);
            this.tableLayoutPanelEdAgEl.Controls.Add(this.btneditar, 0, 0);
            this.tableLayoutPanelEdAgEl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEdAgEl.Location = new System.Drawing.Point(751, 3);
            this.tableLayoutPanelEdAgEl.Name = "tableLayoutPanelEdAgEl";
            this.tableLayoutPanelEdAgEl.RowCount = 1;
            this.tableLayoutPanelEdAgEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEdAgEl.Size = new System.Drawing.Size(259, 75);
            this.tableLayoutPanelEdAgEl.TabIndex = 0;
            // 
            // btneliminar
            // 
            this.btneliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(172, 0);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 75);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnagregar.Image = global::CapaPresentacion.Properties.Resources.agregar;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(86, 0);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(83, 75);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneditar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(0, 0);
            this.btneditar.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(83, 75);
            this.btneditar.TabIndex = 0;
            this.btneditar.Text = "EDITAR";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanelbuscar);
            this.groupBox1.Location = new System.Drawing.Point(489, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR CLIENTE";
            // 
            // tableLayoutPanelbuscar
            // 
            this.tableLayoutPanelbuscar.ColumnCount = 2;
            this.tableLayoutPanelbuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbuscar.Controls.Add(this.txtbuscar, 1, 0);
            this.tableLayoutPanelbuscar.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelbuscar.Controls.Add(this.btnrefre, 1, 1);
            this.tableLayoutPanelbuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelbuscar.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelbuscar.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tableLayoutPanelbuscar.Name = "tableLayoutPanelbuscar";
            this.tableLayoutPanelbuscar.RowCount = 2;
            this.tableLayoutPanelbuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbuscar.Size = new System.Drawing.Size(250, 56);
            this.tableLayoutPanelbuscar.TabIndex = 0;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(128, 3);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(119, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrefre
            // 
            this.btnrefre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnrefre.Location = new System.Drawing.Point(128, 31);
            this.btnrefre.Name = "btnrefre";
            this.btnrefre.Size = new System.Drawing.Size(119, 22);
            this.btnrefre.TabIndex = 2;
            this.btnrefre.Text = "REFREZCAR";
            this.btnrefre.UseVisualStyleBackColor = true;
            // 
            // labeltitulo
            // 
            this.labeltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labeltitulo.Location = new System.Drawing.Point(0, 0);
            this.labeltitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(194, 81);
            this.labeltitulo.TabIndex = 1;
            this.labeltitulo.Text = "CLIENTE";
            this.labeltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AllowUserToOrderColumns = true;
            this.dataGridViewCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCliente.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.Size = new System.Drawing.Size(1013, 439);
            this.dataGridViewCliente.TabIndex = 1;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Cliente";
            this.Size = new System.Drawing.Size(1016, 497);
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tableLayoutPanelEdAgEl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanelbuscar.ResumeLayout(false);
            this.tableLayoutPanelbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEdAgEl;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrefre;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
    }
}
