namespace Atividade
{
    // Classe-pai
    class Clientes
    {
        public string nome { get; set; } = "";
        public string endereco { get; set; } = "";

        // Encapsulamento: set protegido
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        // Polimorfismo: virtual permite override
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10f / 100f; // 10% PF
            this.total = this.valor + this.valor_imposto;
        }
    }
}
