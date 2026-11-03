// Questão 1 C#
int votosAna = 0;
int votosBruno = 0;
int nulos = 0;
string voto = "";
bool votacaoAberta = true;

while (votacaoAberta)
{
    System.Console.WriteLine("Voto (1 Ana, 2 Bruno, 0 Encerra)");
    voto = Console.ReadLine();

    if (voto == "0")
        votacaoAberta = false;
   
    else if (voto == "1")
        votosAna++;
   
    else if (voto == "2")
        votosBruno++;
   
    else
        nulos++;
}
System.Console.WriteLine($"Ana: {votosAna} | Bruno: {votosBruno} | Nulos: {nulos} ");
if (votosAna > votosBruno)
    System.Console.WriteLine("Vencedora: Ana");
else if (votosAna < votosBruno)
    System.Console.WriteLine("Vencedor: Bruno");
else
    System.Console.WriteLine("Empate");
