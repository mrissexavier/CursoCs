double pFabrica, pImpostos, pRevendedor, pFinal;
double porcImpostos = 0.45, porcRevendedor = 0.28;
string nomeAutomovel;

Console.WriteLine("Qual automóvel irá comprar?");
nomeAutomovel = Console.ReadLine();

Console.WriteLine("Qual o preço de fábrica do autimpovel?");
pFabrica = double.Parse(Console.ReadLine());

pImpostos = pFabrica * porcImpostos;
pRevendedor = pFabrica * porcRevendedor;

pFinal = pFabrica + pImpostos + pRevendedor;

Console.WriteLine($"Seu novo automóvel {nomeAutomovel} custará {pFinal}");
