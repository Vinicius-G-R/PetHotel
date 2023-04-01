string especie, raça, alcunha, idade, pelagemcor;

Console.WriteLine("Qual é a espécie do seu Pet? ");
especie = Console.ReadLine()!;

Console.WriteLine("Qual é a raça do seu Pet? ");
raça = Console.ReadLine()!;

Console.WriteLine("Qual é o nome do seu Pet? ");
alcunha = Console.ReadLine()!;

Console.WriteLine("Qual é a idade do seu Pet? ");
idade = Console.ReadLine()!;

Console.WriteLine("Qual é a pelagem do seu Pet? ");
pelagemcor = Console.ReadLine()!;

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel Beach Pet                     |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Espécie: {especie.PadLeft(17,'.')}  | Raça: {raça.PadLeft(19,'.')} |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de: {alcunha.PadLeft(31,'.')} |");
Console.WriteLine($"| Idade: {idade.PadLeft(12,'.')} anos(s) | Pelagem/cor: {pelagemcor.PadLeft(12,'.')} |");
Console.WriteLine("+=========================================================+");
