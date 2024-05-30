// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;

Console.WriteLine("Inicio do processamento");

Car car = new Car
{   
    Name = "Carro muito legal",
    Color = "Vermelho",
    Year = 2025
};
/*
for (int i = 1; i <= 10000; i++)
{
    car.Name = "Teste - " + i.ToString();
    Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido - " + car.Name : "Erro ao inserir Registro");
}*/


foreach (var item in new CarController().GetAll().Where(x => x.Id > 990).ToList().Take(10))
{
    Console.WriteLine(item); 
}

//Console.WriteLine(car);

/*Console.WriteLine("EXEMPLO INSERT: ");
Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir Registro");

Console.WriteLine("VALIDACAO: ");
foreach (var item in new CarController().GetAll())
{
    Console.WriteLine(item);
}

Console.WriteLine("EXEMPLO UPDATE: ");
Console.WriteLine(new CarController().Update(car) ? "Registro Atualizado" : "Erro ao atualizar Registro");

Console.WriteLine("VALIDACAO: ");
foreach (var item in new CarController().GetAll())
{
    Console.WriteLine(item);
}

Console.WriteLine("EXEMPLO DELETE: ");
Console.WriteLine(new CarController().Delete(2) ? "Registro Deletado" : "Erro ao deletar Registro");

Console.WriteLine("VALIDACAO: ");
foreach (var item in new CarController().GetAll())
{
    Console.WriteLine(item);
}



Console.WriteLine("EXEMPLO GET: ");
Console.WriteLine(new CarController().Get(1));
*/
