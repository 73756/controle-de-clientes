namespace Atividade;

class Clientes
{
    public string nome { get; set; } = "";
    public string endereco { get; set; } = "";

    public float valor { get; protected set; }
    public float valor_imposto { get; protected set; }
    public float total { get; protected set; }

    public virtual void Pagar_Imposto(float v)
    {
        valor = v;
        valor_imposto = valor * 0.10f; // 10% PF
        total = valor + valor_imposto;
    }
}
