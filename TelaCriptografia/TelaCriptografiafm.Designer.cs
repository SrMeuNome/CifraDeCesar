namespace TelaCriptografia
{
    partial class TelaCriptografiafm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextoCriptografia = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.TextoCriptografado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o texto para Criptografar";
            // 
            // TextoCriptografia
            // 
            this.TextoCriptografia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCriptografia.Location = new System.Drawing.Point(94, 49);
            this.TextoCriptografia.MaxLength = 80;
            this.TextoCriptografia.Multiline = true;
            this.TextoCriptografia.Name = "TextoCriptografia";
            this.TextoCriptografia.Size = new System.Drawing.Size(267, 51);
            this.TextoCriptografia.TabIndex = 1;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriptografar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.Location = new System.Drawing.Point(153, 106);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(150, 46);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "CRIPTOGRAFAR";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // TextoCriptografado
            // 
            this.TextoCriptografado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCriptografado.Location = new System.Drawing.Point(94, 158);
            this.TextoCriptografado.MaxLength = 80;
            this.TextoCriptografado.Multiline = true;
            this.TextoCriptografado.Name = "TextoCriptografado";
            this.TextoCriptografado.ReadOnly = true;
            this.TextoCriptografado.Size = new System.Drawing.Size(267, 51);
            this.TextoCriptografado.TabIndex = 1;
            // 
            // TelaCriptografiafm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.TextoCriptografado);
            this.Controls.Add(this.TextoCriptografia);
            this.Controls.Add(this.label1);
            this.Name = "TelaCriptografiafm";
            this.Text = "Criptografia";
            this.Load += new System.EventHandler(this.TelaCriptografiafm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextoCriptografia;
        private System.Windows.Forms.Button btnCriptografar;
        public System.Windows.Forms.NumericUpDown ValorGuardado;
        private System.Windows.Forms.TextBox TextoCriptografado;
    }
}

