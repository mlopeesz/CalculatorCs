Menu();

static void Soma()
{
  Console.Clear();

  Console.WriteLine("Primeiro valor:");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float num2 = float.Parse(Console.ReadLine());

  float soma = num1 + num2;
  Console.WriteLine($"O resultado da soma é: {soma}");
  Console.ReadKey();
  Menu();
}

static void Subtracao()
{
  Console.Clear();

  Console.WriteLine("Primeiro valor:");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float num2 = float.Parse(Console.ReadLine());

  float subtracao = num1 - num2;
  Console.WriteLine($"O resultado da subtração é: {subtracao}");
  Console.ReadKey();
  Menu();
}

static void Divisao()
{
  Console.Clear();

  Console.WriteLine("Primeiro valor:");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float num2 = float.Parse(Console.ReadLine());

  float divisao = num1 / num2;
  Console.WriteLine($"O resultado da subtração é: {divisao}");
  Console.ReadKey();
  Menu();
}

static void Multiplicacao()
{
  Console.Clear();

  Console.WriteLine("Primeiro valor:");
  float num1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float num2 = float.Parse(Console.ReadLine());

  float multiplicacao = num1 * num2;
  Console.WriteLine($"O resultado da subtração é: {multiplicacao}");
  Console.ReadKey();
  Menu();
}

static void Menu()
{
  Console.Clear();

  Console.WriteLine("Qual operação deseja fazer?");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Divisão");
  Console.WriteLine("4 - Multiplicação");
  Console.WriteLine("5 - Sair");
  Console.WriteLine("-----------------");
  Console.WriteLine("Selecione uma opção: ");
  short opcao = short.Parse(Console.ReadLine());

  switch (opcao)
  {
    case 1: Soma(); break;
    case 2: Subtracao(); break;
    case 3: Divisao(); break;
    case 4: Multiplicacao(); break;
    case 5: System.Environment.Exit(0); break;
    default: Menu(); break;
  }
}