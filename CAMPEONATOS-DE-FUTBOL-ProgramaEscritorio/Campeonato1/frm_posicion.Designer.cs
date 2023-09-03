namespace Campeonato1
{
    partial class frm_posicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_posicion));
            this.dgv_posicion = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_posicion
            // 
            this.dgv_posicion.AllowUserToAddRows = false;
            this.dgv_posicion.AllowUserToDeleteRows = false;
            this.dgv_posicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_posicion.Location = new System.Drawing.Point(12, 12);
            this.dgv_posicion.Name = "dgv_posicion";
            this.dgv_posicion.ReadOnly = true;
            this.dgv_posicion.RowTemplate.Height = 24;
            this.dgv_posicion.Size = new System.Drawing.Size(702, 279);
            this.dgv_posicion.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(605, 311);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(109, 41);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_posicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_posicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_posicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de posiciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_posicion;
        private System.Windows.Forms.Button btn_salir;
    }
}