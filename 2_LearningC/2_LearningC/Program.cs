using System;

//TIPOS DE VARIABLE
int inter = 5;
long l = 353535325352;
double d = 12.34;
decimal de = 12.66236262m;
char c = 'c';
string s = "hi";
bool ok = true;

Console.WriteLine(inter);



//CONDICIONES
EmptyMethod();

int sum = Calculations(10, 20);
Console.WriteLine(sum);

bool greater = IsItGreater(sum);
Console.WriteLine(greater);

if(sum > 10 && sum != 11)
{
    Console.WriteLine("Greater than 10");
}
else if (sum > 5)
{
    Console.WriteLine("Greater than 5 but lesser than 10");
}
else
{
    Console.WriteLine("Lesser than 10");
}

switch (sum)
{
    case 1:
        Console.WriteLine("It is 1");
        break;
    case 2:
        Console.WriteLine("It is 2");
        break;
    default:
        Console.WriteLine("It is something else");
        break;
}



//COLECCIONES
//#Array: no se puede cambiar el tamaño una vez definido
int[] array = new int[3];
int[] array2 = new int[] { 4, 5, 6 };
//#List: es dinamica, no hace falta definir elementos de antemano
List<int> list = new List<int>();
List<int> list2 = new List<int>() { 4, 5, 6 };
list.Add(10);
list.Remove(4);



//LOOPS
foreach (int item in list)
{
    Console.WriteLine(item);
}

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("index:" + i + ", item: " + list[i]);
}

int condition = 0;
while(condition < 4)
{
    Console.WriteLine(condition);
    condition++;
}

do
{
    Console.WriteLine(condition);
}
while (condition < 4);


//CLASES Y OBJETOS
//C# es un lenguaje orientado a objetos, en C# todo es un objeto. La forma de definir objetos es con clases
/*
//Declarar un objeto
MyFirstClass testClass = new MyFirstClass();
MyFirstClass testClass2 = new MyFirstClass(10);
//Llamada a metodos de clase
Console.WriteLine(testClass.GetNumber());

//Clase
class MyFirstClass
{
    int a;
    //Constructores
    public MyFirstClass()
    {

    }

    public MyFirstClass(int i)
    {
        a = i;
    }
    
    //Metodos de clase
    public int GetNumber()
    {
        return a + 1;
    }
}
*/

Console.ReadKey();



//METODOS
void EmptyMethod()
{
    Console.WriteLine("Hello");
}

int Calculations(int a, int b)
{
    return a + b;
}

bool IsItGreater(int a)
{
    return a > 10;
}

