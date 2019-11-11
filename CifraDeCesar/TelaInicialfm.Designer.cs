namespace CifraDeCesar
{
    partial class TelaInicialfm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.CaixaChave = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCriptografia = new System.Windows.Forms.CheckBox();
            this.checkBoxDescriptografia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaixaChave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(89, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CIFRA DE CESAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAVE";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(12, 130);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(331, 34);
            this.lblTitulo2.TabIndex = 0;
            this.lblTitulo2.Text = "ESCOLHA UM MODO:";
            // 
            // CaixaChave
            // 
            this.CaixaChave.BackColor = System.Drawing.Color.Black;
            this.CaixaChave.Cursor = System.Windows.Forms.Cursors.Default;
            this.CaixaChave.ForeColor = System.Drawing.Color.White;
            this.CaixaChave.Location = new System.Drawing.Point(278, 73);
            this.CaixaChave.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.CaixaChave.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CaixaChave.Name = "CaixaChave";
            this.CaixaChave.Size = new System.Drawing.Size(41, 20);
            this.CaixaChave.TabIndex = 1;
            this.CaixaChave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaixaChave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxCriptografia
            // 
            this.checkBoxCriptografia.AutoSize = true;
            this.checkBoxCriptografia.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCriptografia.ForeColor = System.Drawing.Color.White;
            this.checkBoxCriptografia.Location = new System.Drawing.Point(18, 187);
            this.checkBoxCriptografia.Name = "checkBoxCriptografia";
            this.checkBoxCriptografia.Size = new System.Drawing.Size(190, 25);
            this.checkBoxCriptografia.TabIndex = 2;
            this.checkBoxCriptografia.Text = "CRIPTOGRAFIA";
            this.checkBoxCriptografia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCriptografia.UseVisualStyleBackColor = true;
            this.checkBoxCriptografia.CheckedChanged += new System.EventHandler(this.checkBoxCriptografia_CheckedChanged);
            // 
            // checkBoxDescriptografia
            // 
            this.checkBoxDescriptografia.AutoSize = true;
            this.checkBoxDescriptografia.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDescriptografia.ForeColor = System.Drawing.Color.White;
            this.checkBoxDescriptografia.Location = new System.Drawing.Point(225, 187);
            this.checkBoxDescriptografia.Name = "checkBoxDescriptografia";
            this.checkBoxDescriptografia.Size = new System.Drawing.Size(230, 25);
            this.checkBoxDescriptografia.TabIndex = 2;
            this.checkBoxDescriptografia.Text = "DESCRIPTOGRAFIA";
            this.checkBoxDescriptografia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDescriptografia.UseVisualStyleBackColor = true;
            this.checkBoxDescriptografia.CheckedChanged += new System.EventHandler(this.checkBoxDescriptografia_CheckedChanged);
            // 
            // TelaInicialfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.checkBoxDescriptografia);
            this.Controls.Add(this.checkBoxCriptografia);
            this.Controls.Add(this.CaixaChave);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "TelaInicialfm";
            this.Text = "Cifra De Cesar";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaixaChave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.NumericUpDown CaixaChave;
        private System.Windows.Forms.CheckBox checkBoxCriptografia;
        private System.Windows.Forms.CheckBox checkBoxDescriptografia;
    }
}

