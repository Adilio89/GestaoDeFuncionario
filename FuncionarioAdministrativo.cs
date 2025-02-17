﻿namespace GestaoDeFuncionario
{
    internal class FuncionarioAdministrativo : Funcionario
    {
        public FuncionarioAdministrativo(string nome, string cargo, decimal salarioBase) : base(nome, cargo, salarioBase) { }

        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.2m;
        }
    }
}
