namespace Atividade
{
    // Herança a partir de Clientes
    class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; } = "";
        public string rg  { get; set; } = "";
        // Usa Pagar_Imposto da classe-pai (10%)
    }
}
