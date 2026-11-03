// Questão 3 C#
List<string> dias = new List<string> {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"};
List<int> paes = new List<int>();

int dia = 0;
while (dia < dias.Count)
{
    Console.WriteLine($"{dias[dia]} - pães vendidos: ");
    string texto = (Console.ReadLine() ?? "").Trim(); // aceita tanto texto, como texto vazio

    bool valido = texto != "";
    foreach (char letra in texto)
    {
        if (letra < '0' || letra > '9')
            valido = false;
    }
    if (valido)
    {
        paes.Add(int.Parse(texto));
        dia++;
    }
    else
        Console.WriteLine("Digite só números. Tente de novo.");
}

decimal total = 0m;
int posicaoMaior = 0;

for (int i = 0; i < paes.Count; i++)
{
    total = total + paes[i];

    if (paes[i] > paes[posicaoMaior])
        posicaoMaior = i;
}

Console.WriteLine($"Total da semana: {total} pães");
Console.WriteLine($"Média por dia: {total / paes.Count:F2} pães");
Console.WriteLine($"Dia com mais vendas: {dias[posicaoMaior]} ({paes[posicaoMaior]}) pães");
