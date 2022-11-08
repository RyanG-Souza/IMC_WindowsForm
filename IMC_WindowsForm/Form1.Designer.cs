namespace IMC_WindowsForm
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
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.btm_Calcular = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txb_Altura = new System.Windows.Forms.TextBox();
            this.txb_Peso = new System.Windows.Forms.TextBox();
            this.lbl_Saude = new System.Windows.Forms.Label();
            this.txb_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.Location = new System.Drawing.Point(102, 109);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(33, 15);
            this.lbl_Peso.TabIndex = 0;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(93, 157);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(43, 15);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.Location = new System.Drawing.Point(171, 41);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(51, 24);
            this.lbl_Título.TabIndex = 4;
            this.lbl_Título.Text = "IMC";
            // 
            // btm_Calcular
            // 
            this.btm_Calcular.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Calcular.Location = new System.Drawing.Point(142, 213);
            this.btm_Calcular.Name = "btm_Calcular";
            this.btm_Calcular.Size = new System.Drawing.Size(112, 76);
            this.btm_Calcular.TabIndex = 5;
            this.btm_Calcular.Text = "Calcular";
            this.btm_Calcular.UseVisualStyleBackColor = true;
            this.btm_Calcular.Click += new System.EventHandler(this.btm_Calcular_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(160, 318);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(74, 17);
            this.lbl_Resultado.TabIndex = 6;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txb_Altura
            // 
            this.txb_Altura.Location = new System.Drawing.Point(142, 157);
            this.txb_Altura.Name = "txb_Altura";
            this.txb_Altura.Size = new System.Drawing.Size(112, 20);
            this.txb_Altura.TabIndex = 7;
            // 
            // txb_Peso
            // 
            this.txb_Peso.Location = new System.Drawing.Point(142, 109);
            this.txb_Peso.Name = "txb_Peso";
            this.txb_Peso.Size = new System.Drawing.Size(112, 20);
            this.txb_Peso.TabIndex = 7;
            // 
            // lbl_Saude
            // 
            this.lbl_Saude.AutoSize = true;
            this.lbl_Saude.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saude.Location = new System.Drawing.Point(145, 361);
            this.lbl_Saude.Name = "lbl_Saude";
            this.lbl_Saude.Size = new System.Drawing.Size(0, 15);
            this.lbl_Saude.TabIndex = 8;
            // 
            // txb_Resultado
            // 
            this.txb_Resultado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Resultado.Location = new System.Drawing.Point(142, 338);
            this.txb_Resultado.Name = "txb_Resultado";
            this.txb_Resultado.ReadOnly = true;
            this.txb_Resultado.Size = new System.Drawing.Size(112, 22);
            this.txb_Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 438);
            this.Controls.Add(this.txb_Resultado);
            this.Controls.Add(this.lbl_Saude);
            this.Controls.Add(this.txb_Peso);
            this.Controls.Add(this.txb_Altura);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btm_Calcular);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_Peso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Button btm_Calcular;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txb_Altura;
        private System.Windows.Forms.TextBox txb_Peso;
        private System.Windows.Forms.Label lbl_Saude;
        private System.Windows.Forms.TextBox txb_Resultado;
    }
}

