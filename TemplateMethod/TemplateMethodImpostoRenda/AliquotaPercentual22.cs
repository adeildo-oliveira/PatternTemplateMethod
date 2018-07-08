namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class AliquotaPercentual22 : TemplateDeCalculoParaImpostoDeRenda
    {
        protected override decimal AplicaTaxaImpostoDeRenda(Salario salario) =>
            salario.SalarioTotal() - 636.13M;

        protected override bool DeveUsarTaxaNoSalario(Salario salario) => 
            salario.SalarioTotal() >= 3751.06M && salario.SalarioTotal() <= 4664.68M;
    }
}
