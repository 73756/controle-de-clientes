namespace Atividade
{
    // Herança a partir de Clientes
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; } = "";
        public string ie   { get; set; } = "";

        // Polimorfismo: regra de imposto diferente (20%)
        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20f / 100f; // 20% PJ
            this.total = this.valor + this.valor_imposto;
        }
    }
}
