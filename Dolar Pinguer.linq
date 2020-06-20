<Query Kind="Program">
  <Namespace>RestSharp</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

void Main()
{
	var clienteBanco = new RestClient(new Uri("http://www.bancoprovincia.com.ar/"));

	var request = new RestRequest("Principal/Dolar", Method.GET).AddHeader("Accept", "application/json");

	var result = clienteBanco.Execute(request);
	
	var content = JArray.Parse(result.Content).ToObject<string[]>();
	
	var response = new DolarServiceResponse(content);
	
	Console.WriteLine(response);
}

public class DolarServiceResponse
{
	public string Compra { get; set; }
	public string Venta { get; set; }
	public string Actualizado { get; set; }

	public DolarServiceResponse(string[] response)
	{
		Compra = string.Format("Compra: {0}", response[0]);
		Venta = string.Format("Venta {0}", response[1]);
		Actualizado = response[2];
	}

	public override string ToString()
	{
		return string.Join(", ", new string[] { Compra, Venta, Actualizado });
	}
}
