// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust rakendus tervitab kasutajat järgmiselt:
//"Welcom, Mr. [kasutaja perekonnanimi] / "Welcom, Ms. [kasutaja perekonnanimi]" 

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha string (sõne) formaadis

Console.WriteLine("Please, enter your last name");
string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Wecome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Wecome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Wecome, {userLastName}!");
}

