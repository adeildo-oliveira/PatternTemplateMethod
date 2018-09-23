using System;
using TemplateMethod.TemplateMethodImpostoRenda;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new Salario(2900M, 2500M);
            Console.WriteLine(new AliquotaLivre().CalculaImpostoDeRenda(salario));
            Console.WriteLine(new AliquotaPercentual7().CalculaImpostoDeRenda(salario));
            Console.WriteLine(new AliquotaPercentual15().CalculaImpostoDeRenda(salario));
            Console.WriteLine(new AliquotaPercentual22().CalculaImpostoDeRenda(salario));
            Console.WriteLine(new AliquotaPercentual27().CalculaImpostoDeRenda(salario));
            //Console.ReadKey();
        }
    }
}
