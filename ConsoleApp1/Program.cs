using System;


class Pessoa
{
    public int Id { get; }
    public string Nome { get; }
    public int Idade { get; }


    public Pessoa(int id, string nome, int idade)
    {
        Id = id;
        Nome = nome;
        Idade = idade >= 0 ? idade : throw new ArgumentOutOfRangeException(nameof(idade), "A idade deve ser um número positivo.");
    }
}

class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public static decimal BonusAnual { get; }

    static Funcionario()
    {
        BonusAnual = 1520;
    }

    public Funcionario(int id, string nome, int idade, decimal salario)
        : base(id, nome, idade)
    {
        Salario = salario >= 0 ? salario : throw new ArgumentOutOfRangeException(nameof(salario), "O salário deve ser um número positivo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var funcionario1 = new Funcionario(1, "Souza", 19, 4000);
        var funcionario2 = new Funcionario(2, "Richard", 20, 3500);

        Console.WriteLine($"Funcionário {funcionario1.Nome}: Salário mensal do funcionário = {funcionario1.Salario:C}, Salário anual com o bônus = {(funcionario1.Salario * 13) + Funcionario.BonusAnual:C}");
        Console.WriteLine($"Funcionário {funcionario2.Nome}: Salário mensal do funcionário= {funcionario2.Salario:C}, Salário anual com o bônus = {(funcionario2.Salario * 13) + Funcionario.BonusAnual:C}");
    }

}

