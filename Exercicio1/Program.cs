Console.WriteLine("CADASTRO DE USUÁRIO");
Console.WriteLine("A nova senha deve conter:");
Console.WriteLine("\t- Mínimo de 8 caracteres");
Console.WriteLine("\t- Pelo menos uma letra maiúscula");
Console.WriteLine("\t- Pelo menos um número");
Console.WriteLine("\t- Pelo menos um caractere especial (ex: !, @, #)");
Console.Write("\nDigite a senha: ");
string senha = Console.ReadLine();

List<string> erros = new List<string>();

if (senha.Length < 8)
{
    erros.Add("A senha deve ter no mínimo 8 caracteres!");
}

bool maiusculas = false;
bool numeros = false;
bool char_especial = false;

foreach (char caractere in senha)
{
    if (Char.IsUpper(caractere))
    {
        maiusculas = true;
    }

    if (Char.IsDigit(caractere))
    {
        numeros = true;
    }

    string caracteresEspeciais = @"!#$%&/()=?»«@£§€{}.-;'<>_,";
    if (caracteresEspeciais.Contains(caractere))
    {
        char_especial = true;
    }
}

if (!maiusculas)
{
    erros.Add("A senha deve ter pelo menos 1 letra maiúscula!");
}
if (!numeros)
{
    erros.Add("A senha deve ter pelo menos 1 número!");
}
if (!char_especial)
{
    erros.Add("A senha deve ter pelo menos 1 caractere especial!");
}

if (erros.Count == 0)
{
    Console.WriteLine("Senha criada com sucesso!");
}
else
{
    Console.WriteLine("Verifique os erros abaixo:");
    foreach (var erro in erros)
    {
        Console.WriteLine(erro);
    }
}