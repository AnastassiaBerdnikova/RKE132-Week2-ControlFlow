//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema Perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab rakendusr järgmist:
//"Welcome, Mr.[kasutaja Perekonnanimi]/ "Welcome, Ms.[Kasutaja Perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");


//char userGender = Console.ReadLine(); //loeb konsoolist andmed string (sõne) formaadis

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your Lastname");

string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname} !");
}
else
{ Console.WriteLine($"Welcome, {userLastname}!"); 
}
















