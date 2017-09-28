namespace CapaPresentacion
{
    partial class ConsultarCaategoria
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
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnagregarcateg = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtconsultarCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoria.AllowUserToDeleteRows = false;
            this.dataGridViewCategoria.AllowUserToOrderColumns = true;
            this.dataGridViewCategoria.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridViewCategoria.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCategoria.MultiSelect = false;
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.ReadOnly = true;
            this.dataGridViewCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(1102, 398);
            this.dataGridViewCategoria.TabIndex = 2;
            this.dataGridViewCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoria_CellDoubleClick_1);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELIMINAR";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnagregarcateg
            // 
            this.btnagregarcateg.Location = new System.Drawing.Point(597, 21);
            this.btnagregarcateg.Name = "btnagregarcateg";
            this.btnagregarcateg.Size = new System.Drawing.Size(75, 23);
            this.btnagregarcateg.TabIndex = 3;
            this.btnagregarcateg.Text = "Agregar";
            this.btnagregarcateg.UseVisualStyleBackColor = true;
            this.btnagregarcateg.Click += new System.EventHandler(this.btnagregarcateg_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(705, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtconsultarCategoria
            // 
            this.txtconsultarCategoria.Location = new System.Drawing.Point(342, 24);
            this.txtconsultarCategoria.Name = "txtconsultarCategoria";
            this.txtconsultarCategoria.Size = new System.Drawing.Size(213, 20);
            this.txtconsultarCategoria.TabIndex = 5;
            this.txtconsultarCategoria.TextChanged += new System.EventHandler(this.txtconsultarCategoria_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BuscarCategoria:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultarCaategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconsultarCategoria);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnagregarcateg);
            this.Controls.Add(this.dataGridViewCategoria);
            this.Name = "ConsultarCaategoria";
            this.Text = "Consultar Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnagregarcateg;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtconsultarCategoria;
        private System.Windows.Forms.Label label1;
    }
}