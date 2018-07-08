namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public abstract class TemplateDeCalculoParaImpostoDeRenda
    {
        public decimal CalculaImpostoDeRenda(Salario salario)
        {
            if (DeveUsarTaxaNoSalario(salario))
                return AplicaTaxaImpostoDeRenda(salario);
            else
                return salario.SalarioTotal();
        }

        protected abstract bool DeveUsarTaxaNoSalario(Salario salario);
        protected abstract decimal AplicaTaxaImpostoDeRenda(Salario salario);
    }
}
