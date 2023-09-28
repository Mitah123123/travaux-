// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour quelle monnaie voulez vous convertir ? (CAD/USD/EURO)");
string type = Console.ReadLine();
Console.WriteLine("En quoi voulez vous convertir ? (CAD/USD/EURO) ");
string type2 = Console.ReadLine();  
Console.WriteLine("Choisissez le montant que vous voulez convertir");
double argent1 = Convert.ToDouble(Console.ReadLine());


if (type == "USD" && type2 == "CAD")
{
    double argent2 = 1.35 * argent1;
    Console.WriteLine(argent1 + " USD équivaut à " + argent2 + " CAD. ");
}
if (type == "USD" && type2 == "EURO")
{
    double argent2 = 0.95 * argent1;
    Console.WriteLine(argent1 + " USD équivaut à " + argent2 + " Euro. ");
}


if (type == "CAD" && type2 == "USD")
{
    double argent2 = 0.74 * argent1;
    Console.WriteLine(argent1 + " CAD équivaut à " + argent2 + " USD. ");
}
if (type == "CAD" && type2 == "EURO")
{
    double argent2 = 0.70 * argent1;
    Console.WriteLine(argent1 + " CAD équivautà " + argent2 + " Euro. ");
}


if (type == "EURO" && type2 == "CAD")
{
    double argent3 = 0.70 * argent1;
    Console.WriteLine(argent1 + " Euro équivaut à " + argent3 + " CAD. ");
}

if (type == "EURO" && type2 == "USD")
{
    double argent3 = 0.95 * argent1;
    Console.WriteLine(argent1 + " Euro équivaut à " + argent3 + " USD. ");
}
