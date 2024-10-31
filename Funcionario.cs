using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFuncionario
{
    public abstract class Funcionario : IFuncionario
    {
        public Funcionario(string nome, string cargo, decimal salarioBase) 
        { 
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set;}

        public abstract decimal CalcularSalario();

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Calculado: {CalcularSalario()}");
        }

    }
}
