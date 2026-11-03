// Questão 2 C#
List<string> usuarios = new List<string> {"lia.souza", "noah.lima", "davi.rocha"};

System.Console.WriteLine("Nome de usuário: ");
string usuario = (System.Console.ReadLine()).Trim(); // tira os espaços extras (no meio e no final)

bool jaCadastrado = false;
foreach (string cadastrado in usuarios)
{
    if (cadastrado.ToLower() == usuario.ToLower())
        jaCadastrado = true;
}
if (usuario.Length < 4 || usuario.Length > 12)
    System.Console.WriteLine("O usuário precisa de 4 a 12 caracteres.");
else if (usuario.Contains(" "))
    System.Console.WriteLine("O usuário não pode ter espaços.");
else if (jaCadastrado)
    System.Console.WriteLine("Este usuário ja está cadastrado.");
else
{
    usuarios.Add(usuario);
    System.Console.WriteLine($"O usuário {usuario} foi cadastrado com sucesso! O total de usuários é: {usuarios.Count}");
}
