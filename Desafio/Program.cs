// desafio C#
List<string> fila = [];
string opcao = "1";
while (opcao != "0")
{   
    Console.WriteLine("----------MENU----------");
    Console.WriteLine("Digite o que deseja fazer: ");
    Console.WriteLine("[1] Adicionar pessoa à fila / [2] Listar fila / [3] Atender próximo cliente / [0] Encerrar programa");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":   
            Console.WriteLine("Qual o nome da pessoa? ");
            string nome = Console.ReadLine().Trim();
            if (nome.Length < 3)
                Console.WriteLine("Nome inválido. Informe pelo menos 3 caracteres...");
            else
            {
                fila.Add(nome);
                Console.WriteLine($"{nome} entrou no final da fila!");
            }
            break;

        case "2":
            if (fila.Count == 0)
                System.Console.WriteLine("A fila está vazia... Não é possível listar");
            else
            {
                Console.WriteLine("Fila de Atendimento...");
                for (int i = 0; i < fila.Count; i++)
                {
                    Console.WriteLine($"{i+1}° {fila[i]}");
                }
            }
            break;

        case "3":
            if (fila.Count == 0)
                System.Console.WriteLine("A fila está vazia... Não há clientes para atender...");
            else
            {
                Console.WriteLine("Serviços disponíveis: ");
                Console.WriteLine("[1] Corte de cabelo | Preço: R$ 40,00");
                Console.WriteLine("[2] Barba | Preço: R$ 25,00");
                Console.WriteLine("[3] Corte + barba | Preço: R$ 55,00");
                Console.WriteLine("Serviço escolhido (1, 2 ou 3): ");
                string servico = Console.ReadLine();
                if (servico == "1")
                {
                    Console.WriteLine($"Atendimento de {fila[0]} concluído. Serviço: Corte de cabelo. Valor cobrado: R$ 40,00");
                    fila.RemoveAt(0);
                }
                else if (servico == "2")
                {
                    Console.WriteLine($"Atendimento de {fila[0]} concluído. Serviço: Barba. Valor cobrado: R$ 25,00");
                    fila.RemoveAt(0);
                }
                else if (servico == "3")
                {
                    Console.WriteLine($"Atendimento de {fila[0]} concluído. Serviço: Corte + barba. Valor cobrado: R$ 55,00");
                    fila.RemoveAt(0);
                }
                else
                    Console.WriteLine($"Código de serviço inválido. {fila[0]} continua no início da fila.");
            }
            break;

        case "0":
            Console.WriteLine("Encerrando programa");
            break;

        default:
            Console.WriteLine("Escreva um número válido");
            break;
    }
} 