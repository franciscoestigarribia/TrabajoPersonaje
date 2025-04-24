using personaje;
using System.Security.Cryptography;

int swit=0;

Personaje p1 = new Personaje();
Console.WriteLine("carga del personaje 1");
Carga(p1);
Personaje p2 = new Personaje();
Console.WriteLine("carga del personaje 2");
Carga(p2);

do
{
    Console.Clear();
    Console.WriteLine("Personaje 1");
    Muestra(p1);
    Console.WriteLine("Personaje 2");
    Muestra(p2);
    Console.WriteLine("ingrese una opcion");
    Console.WriteLine("1: cambiar color");
    Console.WriteLine("2: Recibir daño");
    Console.WriteLine("3: atacar");
    swit = int.Parse(Console.ReadLine());
    switch (swit)
    {
        case 1:
            Console.WriteLine("elija otro color");
            p1.CambiarColor(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("ingrese el daño recibido");
            p1.RecibirDaño(int.Parse(Console.ReadLine()));
            break;
            case 3:
            p1.Atacar(p2);
            break;

        default:
            Console.WriteLine("sos mogolico?, ingresa 1 o 2 imbecilo");
            break;
    }
    if(p2.Vida==0)
    {
        Console.WriteLine("Ganaste");
    }
} while (p2.Vida!=0);

Console.ReadKey();

void Carga(Personaje p)
{
    Console.WriteLine("ingrese su color");
    p.Color = Console.ReadLine();
    Console.WriteLine("ingrese el valor de fuerza");
    p.Mana = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el valor de defensa");
    p.Defensa = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su valor de vida");
    p.Fuerza = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese su valor de mana");
    p.Vida = int.Parse(Console.ReadLine());
}
void Muestra(Personaje mues)
{
    Console.WriteLine("color: "+ mues.Color); 
    Console.WriteLine("fuerza: "+ mues.Fuerza);
    Console.WriteLine("defensa: "+ mues.Defensa);
    Console.WriteLine("vida: "+ mues.Vida);
    Console.WriteLine("mana: " + mues.Mana);
}



