namespace PesoIDeal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnMasculino);
            this.groupBox1.Controls.Add(this.rbnFeminino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbnMasculino.ForeColor = System.Drawing.Color.Black;
            this.rbnMasculino.Location = new System.Drawing.Point(6, 29);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(79, 18);
            this.rbnMasculino.TabIndex = 1;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbnFeminino.Location = new System.Drawing.Point(99, 28);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(73, 18);
            this.rbnFeminino.TabIndex = 0;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            this.rbnFeminino.CheckedChanged += new System.EventHandler(this.rbnFeminino_CheckedChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.White;
            this.txtAltura.Location = new System.Drawing.Point(201, 40);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(70, 20);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.PeachPuff;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resultado.Location = new System.Drawing.Point(94, 82);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(70, 25);
            this.resultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(282, 110);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PesoIdeal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox resultado;
    }
}

