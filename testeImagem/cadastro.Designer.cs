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
            this.unidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoC)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeC
            // 
            this.nomeC.AutoSize = true;
            this.nomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeC.Location = new System.Drawing.Point(14, 49);
            this.nomeC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeC.Name = "nomeC";
            this.nomeC.Size = new System.Drawing.Size(67, 24);
            this.nomeC.TabIndex = 0;
            this.nomeC.Text = "Nome:";
            // 
            // nomeCC
            // 
            this.nomeCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCC.Location = new System.Drawing.Point(104, 46);
            this.nomeCC.Margin = new System.Windows.Forms.Padding(2);
            this.nomeCC.Name = "nomeCC";
            this.nomeCC.Size = new System.Drawing.Size(226, 29);
            this.nomeCC.TabIndex = 3;
            this.nomeCC.TextChanged += new System.EventHandler(this.nomeCC_TextChanged);
            // 
            // fotoC
            // 
            this.fotoC.Location = new System.Drawing.Point(400, 24);
            this.fotoC.Margin = new System.Windows.Forms.Padding(2);
            this.fotoC.Name = "fotoC";
            this.fotoC.Size = new System.Drawing.Size(225, 190);
            this.fotoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoC.TabIndex = 4;
            this.fotoC.TabStop = false;
            // 
            // diretorio
            // 
            this.diretorio.Location = new System.Drawing.Point(400, 229);
            this.diretorio.Margin = new System.Windows.Forms.Padding(2);
            this.diretorio.Name = "diretorio";
            this.diretorio.Size = new System.Drawing.Size(226, 20);
            this.diretorio.TabIndex = 5;
            // 
            // inserir
            // 
            this.inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserir.Location = new System.Drawing.Point(438, 262);
            this.inserir.Margin = new System.Windows.Forms.Padding(2);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(152, 36);
            this.inserir.TabIndex = 6;
            this.inserir.Text = "Inserir Imagem";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // salvar
            // 
            this.salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.Location = new System.Drawing.Point(457, 308);
            this.salvar.Margin = new System.Windows.Forms.Padding(2);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(104, 37);
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // unidade
            // 
            this.unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidade.Location = new System.Drawing.Point(104, 95);
            this.unidade.Margin = new System.Windows.Forms.Padding(2);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(226, 29);
            this.unidade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unidade:";
            // 
            // CPF
            // 
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(104, 147);
            this.CPF.Margin = new System.Windows.Forms.Padding(2);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(226, 29);
            this.CPF.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPF:";
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(104, 197);
            this.cidade.Margin = new System.Windows.Forms.Padding(2);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(226, 29);
            this.cidade.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cidade:";
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(104, 248);
            this.estado.Margin = new System.Windows.Forms.Padding(2);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(226, 29);
            this.estado.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Estado:";
            // 
            // celular
            // 
            this.celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular.Location = new System.Drawing.Point(104, 297);
            this.celular.Margin = new System.Windows.Forms.Padding(2);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(226, 29);
            this.celular.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Celular:";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 366);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.diretorio);
            this.Controls.Add(this.fotoC);
            this.Controls.Add(this.nomeCC);
            this.Controls.Add(this.nomeC);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox unidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.Label label5;
    }
}