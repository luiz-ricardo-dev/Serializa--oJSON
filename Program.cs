
using Newtonsoft.Json;
using SerializaçãoJSON.Models;

DateTime dataAtual = DateTime.Now;

//Criando Uma Lista
List<Venda> listaVendas =  new List<Venda>();   

//Istanciando um Objeto
Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
Venda v3 = new Venda(3, "Hardware", 250.00M, dataAtual);

//Adicionando os objetos na lista
listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);

//Conventendo este objeto em JSON
//string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
//Serializando uma Colection 
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

//Escrevendo o JSON em um Arquivo
File.WriteAllText("Arquivos/vendas.json", serializado);

//Imprimindo o JSON
Console.WriteLine(serializado);