
using Newtonsoft.Json;
using SerializaçãoJSON.Models;

//Istanciando um Objeto
Venda v1 = new Venda(1, "Material de escritório", 25.00M);

//Conventendo este objeto em JSON
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

//Escrevendo o JSON em um Arquivo
File.WriteAllText("Arquivos/vendas.json", serializado);

//Imprimindo o JSON
Console.WriteLine(serializado);