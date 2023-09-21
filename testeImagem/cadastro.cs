using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testeImagem
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|Allfiles(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                diretorio.Text = foto;
                fotoC.ImageLocation = foto;
            }

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            byte[] imagem_byte = null;
            
            FileStream fstream = new FileStream(this.diretorio.Text, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fstream);

            imagem_byte = br.ReadBytes((int)fstream.Length);

            string sintax = "INSERT INTO pessoa (nome,foto) values (@nome,@foto)";
            string conexao = "server=localhost;database=cadastro;Uid=root;password=";

            MySqlConnection CONEXAO = new MySqlConnection(conexao);

            MySqlCommand comando_inserir = new MySqlCommand(sintax, CONEXAO);

            MySqlDataReader reader;

            try
            {
                CONEXAO.Open();

                comando_inserir.Parameters.Add(new MySqlParameter("@nome", nomeCC.Text));

                comando_inserir.Parameters.Add(new MySqlParameter("@foto", imagem_byte));

                reader = comando_inserir.ExecuteReader();

                MessageBox.Show("Pessoa Salva!");
            }
            catch (Exception E)
            { 
                MessageBox.Show(E.Message.ToString());
            }
            finally
            { 
                CONEXAO.Close(); 
            }

        }
    }//Fim da classe
}//Fim do Projeto
