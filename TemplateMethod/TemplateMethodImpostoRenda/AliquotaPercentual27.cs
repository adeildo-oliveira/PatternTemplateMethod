namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class AliquotaPercentual27 : TemplateDeCalculoParaImpostoDeRenda
    {
        protected override decimal AplicaTaxaImpostoDeRenda(Salario salario) =>
            salario.SalarioTotal() - 869.36M;

        protected override bool DeveUsarTaxaNoSalario(Salario salario) =>
            salario.SalarioTotal() >= 4664.68M;
    }
}
