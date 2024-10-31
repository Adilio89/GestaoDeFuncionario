using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeFuncionario
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        string Cargo { get; set; }
        decimal SalarioBase { get; set; }
        void ExibirDados();
        decimal CalcularSalario();
    }
}
