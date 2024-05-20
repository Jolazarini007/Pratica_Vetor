using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_Vetor
{
    internal class Pessoa
    {
        private int idade;
        private string nome;
        private string cpf;
        private string rg;
        private int senha;
        private bool especial;
        
        public void cadastrar()
        {
            Console.WriteLine("\nInsira o nome do cliente");
            this.nome = Console.ReadLine();
            Console.WriteLine("Insira o idade do cliente");
            this.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira cpf do cliente");
            this.cpf = Console.ReadLine();
            Console.WriteLine("Insira o rg do cliente");
            this.rg = Console.ReadLine();
            Console.WriteLine("O cliente possui alguma condição especial? (Gestante, lactante, deficiente, etc)\nSim[1]\tNão[Qualquer outra tecla]");
            char esp = char.Parse(Console.ReadLine());
            if (esp == '1')
            {
                this.especial = true;
            }
            else
            {
                this.especial = false;
            };
            Console.WriteLine("Insira a senha do cliente");
            this.senha = int.Parse(Console.ReadLine());
        }
        public string Nome { get { return this.nome; } }
        public int Idade { get { return this.idade; } }
        public string Cpf { get { return this.cpf; } }
        public int Senha { get { return this.senha; } }
        public string Rg { get { return this.rg; } }
        public bool Especial { get { return this.especial; } }

        
    }
}
