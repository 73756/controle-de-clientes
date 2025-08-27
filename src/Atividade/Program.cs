using System;
using System.Globalization;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Informar Nome: ");
            string var_nome = Console.ReadLine() ?? "";

            Console.Write("Informar Endereço: ");
            string var_endereco = Console.ReadLine() ?? "";

            Console.Write("Pessoa Física (f) ou Jurídica (j)? ");
            string var_tipo = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            float LerValor(string prompt)
            {
                Console.Write(prompt);
                float valor;
                while (true)
                {
                    var s = Console.ReadLine() ?? "";
                    if (float.TryParse(s, NumberStyles.Any, new CultureInfo("pt-BR"), out valor) ||
                        float.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                        return valor;

                    Console.Write("Valor inválido. Tente novamente: ");
                }
            }

            var cultura = new CultureInfo("pt-BR");

            if (var_tipo == "f")
            {
                var pf = new Pessoa_Fisica
                {
                    nome = var_nome,
                    endereco = var_endereco
                };

                Console.Write("Informar CPF: ");
                pf.cpf = Console.ReadLine() ?? "";

                Console.Write("Informar RG: ");
                pf.rg = Console.ReadLine() ?? "";

                float val_pag = LerValor("Informar Valor de Compra: ");
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("\n-------- Pessoa Física ---------\n");
                Console.WriteLine($"Nome ..........: {pf.nome}");
                Console.WriteLine($"Endereço ......: {pf.endereco}");
                Console.WriteLine($"CPF ...........: {pf.cpf}");
                Console.WriteLine($"RG ............: {pf.rg}");
                Console.WriteLine($"Valor de Compra: {pf.valor.ToString("C", cultura)}");
                Console.WriteLine($"Imposto .......: {pf.valor_imposto.ToString("C", cultura)}");
                Console.WriteLine($"Total a Pagar .: {pf.total.ToString("C", cultura)}");
            }
            else if (var_tipo == "j")
            {
                var pj = new Pessoa_Juridica
                {
                    nome = var_nome,
                    endereco = var_endereco
                };

                Console.Write("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine() ?? "";

                Console.Write("Informar IE: ");
                pj.ie = Console.ReadLine() ?? "";

                float val_pag = LerValor("Informar Valor de Compra: ");
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("\n-------- Pessoa Jurídica ---------\n");
                Console.WriteLine($"Nome ..........: {pj.nome}");
                Console.WriteLine($"Endereço ......: {pj.endereco}");
                Console.WriteLine($"CNPJ ..........: {pj.cnpj}");
                Console.WriteLine($"IE ............: {pj.ie}");
                Console.WriteLine($"Valor de Compra: {pj.valor.ToString("C", cultura)}");
                Console.WriteLine($"Imposto .......: {pj.valor_imposto.ToString("C", cultura)}");
                Console.WriteLine($"Total a Pagar .: {pj.total.ToString("C", cultura)}");
            }
            else
            {
                Console.WriteLine("Tipo inválido. Execute novamente informando 'f' ou 'j'.");
            }
        }
    }
}
