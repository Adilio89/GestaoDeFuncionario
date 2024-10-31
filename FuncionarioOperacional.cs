using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFuncionario
{
    public class FuncionarioOperacional : Funcionario
    {
        public FuncionarioOperacional(string nome, string cargo, decimal salarioBase) 
            : base(nome, cargo, salarioBase) { }

        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.1m;
        }

    }
}
