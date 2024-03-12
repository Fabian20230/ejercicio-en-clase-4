

//     NUMERO MAYOR Y MENOR 

static void mayorymenor() { 

int mayor = int.MinValue; 
int menor = int.MaxValue;
int numero;
do  
{
        Console.WriteLine("INGRESE LOS NUMEROS QUE DESEE ");
        Console.WriteLine("TERMINARA CUANDO INNGRESE 0");
        numero = int.Parse(Console.ReadLine());
        if (numero == 0)
        {
            break;
        }
        if (numero > mayor)
        {
            mayor = numero;
        } if (numero < menor)
        {
            menor = numero;
        }

    }while (numero != 0);

    Console.WriteLine($"El numero mayor es: {mayor} mientras que el menor es: {menor}");
}










// ADIVINA ADIVINADOR
static void ADIVINADOR()
{

    Console.WriteLine("PIENSE EN EL NUMERO QUE LE GUSTE MAS");
    Console.WriteLine("");    
    Console.WriteLine("AHORA MULTIPLICA E NUMERO POR DOS");
    Console.WriteLine("");
    Console.WriteLine("AHORA SUMALE 8");
    Console.WriteLine("");
    Console.WriteLine("Y A ESE RESULTADO MULTIPLICALO POR 5");
    Console.WriteLine("");
    Console.WriteLine("INGRESE EL RESULTADO DE SUS OPERACIONES");
    string num = Console.ReadLine();
    Console.WriteLine($"El numero en el que pensaba es: {num.Substring(0, 2)}");
}



// PALINDROMOS


static void palin()
{

    Console.WriteLine("Ingrese una cadena");
    string palabra = Console.ReadLine();
    palabra = palabra.ToLower();
    string inversa = "";
    for (int i = palabra.Length - 1; i >= 0; i--)
    {
        inversa += palabra[i];

    }
    bool palindromo = palabra.Equals(inversa);
    if (palindromo)
    {
        Console.WriteLine("ES PALINDROMO");
    }
    else
    {
        Console.WriteLine("NO ES PALINDROMO");

    }
}


int opcion;

do
{
    Console.WriteLine("");
    Console.WriteLine("QUE DESEA HACER?");
    Console.WriteLine("OPCION 1:  AVERGUAR EL NUMERO MAYOR Y EL MENOR");
    Console.WriteLine("OPCION 2:  ADIVINADOR DE NUMEROS");
    Console.WriteLine("OPCION 3:  VERIFICADOR DE PALINDROMOS");
    Console.WriteLine("OPCION 0:  SALIR");
     opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            mayorymenor();
            break;
            case 2:
            ADIVINADOR();
            break;
            case 3:
            palin();
            break;
        default:
            Console.WriteLine("NUMERO ERRONEO");
            break;
        case 0:
            Console.WriteLine("CERRANDO PROGRAMA .........");
            break;
    }




} while (opcion != 0);


