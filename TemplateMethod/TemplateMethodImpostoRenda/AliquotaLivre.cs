namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class AliquotaLivre : TemplateDeCalculoParaImpostoDeRenda
    {
        protected override decimal AplicaTaxaImpostoDeRenda(Salario salario) => salario.SalarioTotal();

        protected override bool DeveUsarTaxaNoSalario(Salario salario) => salario.SalarioTotal() <= 1903.99M;
    }
}
