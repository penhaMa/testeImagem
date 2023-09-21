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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cad = new cadastro();

            cad.Show();
        }

        private void jogar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=cadastro;Uid=root;password=";

            MySqlConnection CONEXAO = new MySqlConnection(conexao);

            MySqlCommand comando_buscar = new MySqlCommand("SELECT * FROM pessoas ORDER BY RAND() LIMIT 1", CONEXAO);

            MySqlDataReader reader;

            try
            {
                CONEXAO.Open();

                reader = comando_buscar.ExecuteReader();

                while (reader.Read()) 
                { 
                    string nome = reader.GetString("nome");

                    txt_nome.Text = nome.ToString();

                    byte[] imagem = (byte[])(reader["foto"]);

                    if (imagem == null)
                    {
                        fotoG.Image = null;
                    }
                    else
                    { 
                        MemoryStream mstream = new MemoryStream(imagem);

                        fotoG.Image = System.Drawing.Image.FromStream(mstream);
                    }
                    MessageBox.Show("Parabens" + nome.ToString() + "!");
                }

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
    }
}
