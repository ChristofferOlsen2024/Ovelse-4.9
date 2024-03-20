// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvad vil du have at drikke?");
string drik = Console.ReadLine();

if (String.Equals(drik, "Kaffe", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Det er et godt valg");
}
else
{
    Console.WriteLine("Det er også  okay");
}
