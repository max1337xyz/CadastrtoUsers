using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistradorDeUsuarios.Windows.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return Nome; // Mostra só o nome no ListBox
        }
    }
}