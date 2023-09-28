// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour quel monnaie voulez vous convertir ? (CAD/USD)");
string type = Console.ReadLine();
Console.WriteLine("Choisissez la montant que vous voulez convertir");
double argent1 = Convert.ToDouble(Console.ReadLine());

if (type == "USD"|| type == "usd")
{
    double argent2 = 1.35 * argent1;
    Console.WriteLine(argent1 + " USD équivaut à " + argent2 + " CAD. ");
}

if (type == "CAD"|| type == "cad")
{
    double argent2 = 0.74 * argent1;
    Console.WriteLine(argent1 + "CAD équivaut à " + argent2 + " USD. ");
}
