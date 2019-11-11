namespace TelaDescriptografia
{
    partial class TelaDescriptografiafm
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
            this.TextoDescriptografia = new System.Windows.Forms.TextBox();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.TextoDescriptografado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o texto para Descriptografar";
            // 
            // TextoDescriptografia
            // 
            this.TextoDescriptografia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoDescriptografia.Location = new System.Drawing.Point(94, 49);
            this.TextoDescriptografia.MaxLength = 80;
            this.TextoDescriptografia.Multiline = true;
            this.TextoDescriptografia.Name = "TextoDescriptografia";
            this.TextoDescriptografia.Size = new System.Drawing.Size(267, 51);
            this.TextoDescriptografia.TabIndex = 2;
            this.TextoDescriptografia.TextChanged += new System.EventHandler(this.TextoDescriptografia_TextChanged);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDescriptografar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDescriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografar.Location = new System.Drawing.Point(137, 106);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(182, 46);
            this.btnDescriptografar.TabIndex = 3;
            this.btnDescriptografar.Text = "DESCRIPTOGRAFAR";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // TextoDescriptografado
            // 
            this.TextoDescriptografado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoDescriptografado.Location = new System.Drawing.Point(94, 158);
            this.TextoDescriptografado.MaxLength = 80;
            this.TextoDescriptografado.Multiline = true;
            this.TextoDescriptografado.Name = "TextoDescriptografado";
            this.TextoDescriptografado.ReadOnly = true;
            this.TextoDescriptografado.Size = new System.Drawing.Size(267, 51);
            this.TextoDescriptografado.TabIndex = 4;
            // 
            // TelaDescriptografiafm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.TextoDescriptografado);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.TextoDescriptografia);
            this.Controls.Add(this.label1);
            this.Name = "TelaDescriptografiafm";
            this.Text = "Descriptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextoDescriptografia;
        private System.Windows.Forms.Button btnDescriptografar;
        public System.Windows.Forms.NumericUpDown ValorGuardado;
        private System.Windows.Forms.TextBox TextoDescriptografado;
    }
}

