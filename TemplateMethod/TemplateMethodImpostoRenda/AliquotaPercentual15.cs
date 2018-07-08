namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class AliquotaPercentual15 : TemplateDeCalculoParaImpostoDeRenda
    {
        protected override decimal AplicaTaxaImpostoDeRenda(Salario salario) => 
            salario.SalarioTotal() - 354.80M;

        protected override bool DeveUsarTaxaNoSalario(Salario salario) => 
            salario.SalarioTotal() >= 2826.66M && salario.SalarioTotal() <= 3751.05M;
    }
}
