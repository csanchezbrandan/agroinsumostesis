namespace CapaPresentacion
{
    partial class FrmIngresarCategoria
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblcateg = new System.Windows.Forms.Label();
            this.txtNombCateg = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripCateg = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85026F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.14974F));
            this.tableLayoutPanel1.Controls.Add(this.lblcateg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombCateg, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(109, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblcateg
            // 
            this.lblcateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcateg.AutoSize = true;
            this.lblcateg.Location = new System.Drawing.Point(3, 11);
            this.lblcateg.Name = "lblcateg";
            this.lblcateg.Size = new System.Drawing.Size(150, 13);
            this.lblcateg.TabIndex = 0;
            this.lblcateg.Text = "NOMBRE CATEGORIA :";
            this.lblcateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombCateg
            // 
            this.txtNombCateg.Location = new System.Drawing.Point(159, 3);
            this.txtNombCateg.Name = "txtNombCateg";
            this.txtNombCateg.Size = new System.Drawing.Size(251, 20);
            this.txtNombCateg.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbldescripcion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtdescripCateg, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(112, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.32967F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.67033F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 154);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbldescripcion.Location = new System.Drawing.Point(3, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(575, 31);
            this.lbldescripcion.TabIndex = 0;
            this.lbldescripcion.Text = "DESCRIPCION  :";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdescripCateg
            // 
            this.txtdescripCateg.Location = new System.Drawing.Point(3, 34);
            this.txtdescripCateg.Multiline = true;
            this.txtdescripCateg.Name = "txtdescripCateg";
            this.txtdescripCateg.Size = new System.Drawing.Size(575, 117);
            this.txtdescripCateg.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.btncancelar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btneditar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnguardar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(339, 255);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(351, 60);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btncancelar
            // 
            this.btncancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelar.Location = new System.Drawing.Point(119, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(111, 54);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneditar.Location = new System.Drawing.Point(3, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(110, 54);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "NUEVO";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnguardar.Location = new System.Drawing.Point(236, 3);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(112, 54);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85026F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.14974F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(109, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(581, 35);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(6, 83);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 4;
            // 
            // FrmIngresarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 318);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmIngresarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIA";
            this.Load += new System.EventHandler(this.FrmIngresarCategoria_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblcateg;
        private System.Windows.Forms.TextBox txtNombCateg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtdescripCateg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtcategoria;
    }
}