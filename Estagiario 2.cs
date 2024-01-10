using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP2
{
    class Estagiario : Funcionario
    {
        private int senha;
        public Estagiario(string Nome, int Matricula, int senha) : base(Nome, Matricula)
        {
            this.senha = senha;
        }

        public void DescontoEstagiario(double a)
        {
            double totdesc = a - (a * 0.05);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total com 5% de desconto: R$ {totdesc}");
            Console.WriteLine("-------------------------------------");
        }
    }
}

