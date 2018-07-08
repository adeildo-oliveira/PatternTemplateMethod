namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class AliquotaPercentual7 : TemplateDeCalculoParaImpostoDeRenda
    {
        protected override decimal AplicaTaxaImpostoDeRenda(Salario salario) => 
            salario.SalarioTotal() - 142.80M;

        protected override bool DeveUsarTaxaNoSalario(Salario salario) => 
            salario.SalarioTotal() >= 1903.99M && salario.SalarioTotal() <= 2826.65M;
    }
}
