namespace Campeonato1
{
    partial class frm_equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_equipos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_escudo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_equipo = new System.Windows.Forms.TextBox();
            this.pic_escudo = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_anotados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_escudo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_escudo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_equipo);
            this.groupBox1.Controls.Add(this.pic_escudo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(736, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar equipo";
            // 
            // chk_escudo
            // 
            this.chk_escudo.AutoSize = true;
            this.chk_escudo.Location = new System.Drawing.Point(96, 242);
            this.chk_escudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_escudo.Name = "chk_escudo";
            this.chk_escudo.Size = new System.Drawing.Size(194, 28);
            this.chk_escudo.TabIndex = 6;
            this.chk_escudo.Text = "Con escudo propio";
            this.chk_escudo.UseVisualStyleBackColor = true;
            this.chk_escudo.CheckedChanged += new System.EventHandler(this.chk_escudo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre equipo nuevo:";
            // 
            // txt_equipo
            // 
            this.txt_equipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_equipo.Location = new System.Drawing.Point(58, 178);
            this.txt_equipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_equipo.MaxLength = 49;
            this.txt_equipo.Name = "txt_equipo";
            this.txt_equipo.Size = new System.Drawing.Size(263, 32);
            this.txt_equipo.TabIndex = 3;
            // 
            // pic_escudo
            // 
            this.pic_escudo.Image = ((System.Drawing.Image)(resources.GetObject("pic_escudo.Image")));
            this.pic_escudo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_escudo.InitialImage")));
            this.pic_escudo.Location = new System.Drawing.Point(441, 95);
            this.pic_escudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_escudo.Name = "pic_escudo";
            this.pic_escudo.Size = new System.Drawing.Size(249, 214);
            this.pic_escudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_escudo.TabIndex = 0;
            this.pic_escudo.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(591, 488);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(111, 43);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(456, 488);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(111, 43);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar Equipo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipos Anotados:";
            // 
            // lbl_anotados
            // 
            this.lbl_anotados.AutoSize = true;
            this.lbl_anotados.Location = new System.Drawing.Point(307, 18);
            this.lbl_anotados.Name = "lbl_anotados";
            this.lbl_anotados.Size = new System.Drawing.Size(13, 16);
            this.lbl_anotados.TabIndex = 4;
            this.lbl_anotados.Text = "..";
            // 
            // frm_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 556);
            this.Controls.Add(this.lbl_anotados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Equipos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_escudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_escudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_equipo;
        private System.Windows.Forms.PictureBox pic_escudo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_anotados;
    }
}