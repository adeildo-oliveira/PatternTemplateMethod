namespace TemplateMethod.TemplateMethodImpostoRenda
{
    public class Salario
    {
        public decimal Pagamento { get; private set; }
        public decimal Adiantamento { get; private set; }

        public Salario(decimal pagamento, decimal adiantamento)
        {
            Pagamento = pagamento;
            Adiantamento = adiantamento;
        }

        public virtual decimal SalarioTotal() => Pagamento + Adiantamento;
    }
}
