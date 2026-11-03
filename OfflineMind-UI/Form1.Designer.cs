namespace OfflineMind_UI
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
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(12, 37);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(932, 22);
            this.txtPergunta.TabIndex = 0;
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(388, 65);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(187, 77);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask OfflineMind";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(-6, 161);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(950, 340);
            this.txtResposta.TabIndex = 2;
            this.txtResposta.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 513);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtPergunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.RichTextBox txtResposta;
    }
}

