using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP2
{
    class Gerente : Funcionario
    {

        private int Senha;

        public Gerente(string Nome, int Matricula, int senha) : base(Nome, Matricula)
        {
            this.Senha = senha;
        }

        public void DescontoGerente(double valorTotal)
        {
            double totdesc = valorTotal - (valorTotal * 0.15);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total com 15% de desconto: R$ {totdesc}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
    

        
        
        



