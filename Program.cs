using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFuncionario funcionarioAdm = new FuncionarioAdministrativo("João", "Gerente Administrativo", 5000);
            IFuncionario funcionarioOpr = new FuncionarioOperacional("Maria Souza", "Operadora de Máquinas", 3000);

            funcionarioAdm.ExibirDados();
            Console.WriteLine();

            funcionarioOpr.ExibirDados();
            Console.ReadLine();

        }
    }
}
