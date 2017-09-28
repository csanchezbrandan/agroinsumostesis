namespace CapaPresentacion
{
   

    partial class ConsultarProveedor
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
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnagregarcateg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.AllowUserToAddRows = false;
            this.dataGridViewProveedor.AllowUserToDeleteRows = false;
            this.dataGridViewProveedor.AllowUserToOrderColumns = true;
            this.dataGridViewProveedor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridViewProveedor.Location = new System.Drawing.Point(0, 9);
            this.dataGridViewProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProveedor.MultiSelect = false;
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.ReadOnly = true;
            this.dataGridViewProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProveedor.Size = new System.Drawing.Size(805, 452);
            this.dataGridViewProveedor.TabIndex = 2;
            this.dataGridViewProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedor_CellContentClick);
            this.dataGridViewProveedor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedor_CellContentDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELIMINAR";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnagregarcateg
            // 
            this.btnagregarcateg.Location = new System.Drawing.Point(825, 24);
            this.btnagregarcateg.Name = "btnagregarcateg";
            this.btnagregarcateg.Size = new System.Drawing.Size(75, 23);
            this.btnagregarcateg.TabIndex = 3;
            this.btnagregarcateg.Text = "Agregar";
            this.btnagregarcateg.UseVisualStyleBackColor = true;
            this.btnagregarcateg.Click += new System.EventHandler(this.btnagregarcateg_Click);
            // 
            // ConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 461);
            this.Controls.Add(this.btnagregarcateg);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Name = "ConsultarProveedor";
            this.Text = "ConsultarCaategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnagregarcateg;
    }
}

       
