using RegistradorDeUsuarios.Windows;
using RegistradorDeUsuarios.Windows.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistradorDeUsuarios
{
    public partial class Form1 : Form
    {

        public static List<TextBox> pessoasBox = new List<TextBox>();
       public List<Pessoa>pessoas = new List<Pessoa>();

        bool isTexted;


        public Form1()
        {
            InitializeComponent();
            pessoasBox.Add(tb_cpf);
            pessoasBox.Add(tb_nome);


        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nome.Text) || string.IsNullOrWhiteSpace(tb_cpf.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Pessoa novaPessoa = new Pessoa
            {
                Nome = tb_nome.Text,
                CPF = tb_cpf.Text,
                DataNascimento = dateTimePicker1.Value
            };

            pessoas.Add(novaPessoa);

            tb_nome.Clear();
            tb_cpf.Clear();

            MessageBox.Show("Usuário adicionado com sucesso!");
        }
    
        


        private void button1_Click(object sender, EventArgs e)
        {

            F_Dados dados = new F_Dados(pessoas);
            dados.ShowDialog();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            
        }
    }
}
