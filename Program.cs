//KiNBebe n inclui crianças
int Crianca, adulto, kiBebe, kiNBebe, pessoa;

Console.WriteLine("Bem-vindo ao Churras! quantos adultos irão vir?");
adulto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Certo, e quantos consomem bebidas alcoólicas?");
kiBebe = Convert.ToInt32(Console.ReadLine());

kiNBebe = adulto - kiBebe;

Console.WriteLine("Virão crianças? Se sim, quantas?");
Crianca = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Supimpa! Em um momento enviaremos os itens necessários.");

pessoa = adulto+Crianca;
adulto = kiBebe+kiNBebe;
double Carne = (200*Crianca+400*adulto)/1000;
double Acompanhamento = (200*pessoa/1000);
double Cerveja = 2*kiBebe;
double Refrigerante = (500*pessoa/1000);
double Agua = (400*pessoa/1000);

Console.WriteLine($"Carne.............: {Carne}Kg"); 
Console.WriteLine($"Acompanhamentos...: {Acompanhamento}Kg");
Console.WriteLine($"Cerveja...........: {Cerveja}L");
Console.WriteLine($"Refrigerante......: {Refrigerante}L");
Console.WriteLine($"Água..............: {Agua}L");

