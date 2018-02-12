namespace FactuxD
{
    partial class MantenimientoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_Pro = new MiLibreria.ErrorTxtBox();
            this.txtDes = new MiLibreria.ErrorTxtBox();
            this.txtPre = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID_Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // txtID_Pro
            // 
            this.txtID_Pro.Location = new System.Drawing.Point(207, 98);
            this.txtID_Pro.Name = "txtID_Pro";
            this.txtID_Pro.Size = new System.Drawing.Size(100, 20);
            this.txtID_Pro.SoloNumeros = true;
            this.txtID_Pro.TabIndex = 11;
            this.txtID_Pro.Validar = true;
            this.txtID_Pro.TextChanged += new System.EventHandler(this.txtID_Pro_TextChanged);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(207, 145);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.SoloNumeros = false;
            this.txtDes.TabIndex = 12;
            this.txtDes.Validar = true;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(207, 192);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(100, 20);
            this.txtPre.SoloNumeros = true;
            this.txtPre.TabIndex = 13;
            this.txtPre.Validar = true;
            this.txtPre.TextChanged += new System.EventHandler(this.txtPre_TextChanged);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 458);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtID_Pro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Load += new System.EventHandler(this.MantenimientoProducto_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtID_Pro, 0);
            this.Controls.SetChildIndex(this.txtDes, 0);
            this.Controls.SetChildIndex(this.txtPre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTxtBox txtID_Pro;
        private MiLibreria.ErrorTxtBox txtDes;
        private MiLibreria.ErrorTxtBox txtPre;
    }
}