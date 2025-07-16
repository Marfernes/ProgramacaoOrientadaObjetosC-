
Console.WriteLine("Digite ano do carro: ");


Carro carro = new Carro();
carro.Fabricante = "Toyota";
carro.Modelo = "Hylux";
carro.AnoCarro = int.Parse(Console.ReadLine());

carro.ExibirAnoDoCarro();
Console.WriteLine(carro.DescricaoDetalhada);



