namespace Atividade;

class Pessoa_Juridica : Clientes
{
    public string cnpj { get; set; } = "";
    public string ie   { get; set; } = "";

    public override void Pagar_Imposto(float v)
    {
        valor = v;
        valor_imposto = valor * 0.20f; // 20% PJ
        total = valor + valor_imposto;
    }
}
