namespace testeImagem
{
    partial class cadastro
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
            this.nomeC = new System.Windows.Forms.Label();
            this.nomeCC = new System.Windows.Forms.TextBox();
            this.fotoC = new System.Windows.Forms.PictureBox();
            this.diretorio = new System.Windows.Forms.TextBox();
            this.inserir = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoC)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeC
            // 
            this.nomeC.AutoSize = true;
            this.nomeC.Location = new System.Drawing.Point(3, 9);
            this.nomeC.Name = "nomeC";
            this.nomeC.Size = new System.Drawing.Size(47, 16);
            this.nomeC.TabIndex = 0;
            this.nomeC.Text = "Nome:";
            // 
            // nomeCC
            // 
            this.nomeCC.Location = new System.Drawing.Point(12, 28);
            this.nomeCC.Name = "nomeCC";
            this.nomeCC.Size = new System.Drawing.Size(300, 22);
            this.nomeCC.TabIndex = 3;
            // 
            // fotoC
            // 
            this.fotoC.Location = new System.Drawing.Point(12, 61);
            this.fotoC.Name = "fotoC";
            this.fotoC.Size = new System.Drawing.Size(300, 234);
            this.fotoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoC.TabIndex = 4;
            this.fotoC.TabStop = false;
            // 
            // diretorio
            // 
            this.diretorio.Location = new System.Drawing.Point(12, 307);
            this.diretorio.Name = "diretorio";
            this.diretorio.Size = new System.Drawing.Size(300, 22);
            this.diretorio.TabIndex = 5;
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(94, 354);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(124, 32);
            this.inserir.TabIndex = 6;
            this.inserir.Text = "Inserir Imagem";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(94, 392);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(124, 32);
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.diretorio);
            this.Controls.Add(this.fotoC);
            this.Controls.Add(this.nomeCC);
            this.Controls.Add(this.nomeC);
            this.Name = "cadastro";
            this.Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.fotoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeC;
        private System.Windows.Forms.TextBox nomeCC;
        private System.Windows.Forms.PictureBox fotoC;
        private System.Windows.Forms.TextBox diretorio;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Button salvar;
    }
}