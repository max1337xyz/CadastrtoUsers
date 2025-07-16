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

namespace RegistradorDeUsuarios.Windows
{
    public partial class F_Dados : Form
    {

        private List<Pessoa> pessoa = new List<Pessoa>();

        public F_Dados(List<Pessoa> pessoas)
        {
            InitializeComponent();
            pessoa = pessoas;
            foreach (var p in pessoas)
            {
                ll_users.Items.Add(p);
            }







        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (ll_users.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um usuário para remover.");
                return;
            }
            pessoa.RemoveAt(ll_users.SelectedIndex);
            ll_users.Items.RemoveAt(ll_users.SelectedIndex);
            MessageBox.Show("Usuário removido com sucesso!");
        }


        private void btn_exibir_Click(object sender, EventArgs e)
        {
            var selecionado = ll_users.SelectedItem;

            if (selecionado != null && selecionado is Pessoa pessoaSelecionada)
            {
                MessageBox.Show($"Usuário: {pessoaSelecionada.Nome}\n" +
                                $"CPF: {pessoaSelecionada.CPF}\n" +
                                $"Data de Nascimento: {pessoaSelecionada.DataNascimento.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Selecione um usuário.");
            }
        }
    }
}
