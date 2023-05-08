using PI_P1_4_IMC;

class Program
{
    private static void Main(string[] args)
    {

        Persona p01;
        p01 = new Persona();

        p01.pNombre = "Agustin";

        Persona p02 = new Persona("Juan",24,"H",72.5,1.74);

        Persona p03 = new Persona();

        Console.WriteLine("Escriba el nombre de la persona...");
        p03.pNombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad de la persona...");
        p03.pEdad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(p01.ToString());
        Console.WriteLine(p02.ToString());
        Console.WriteLine(p03.ToString());




        Console.WriteLine("Presione una tecla para finalizar");
        Console.ReadLine();
        


    }
}

/*
Problema 1.4:
Persona. Se nos pide modelar una clase Persona con las siguientes
condiciones:
- Sus atributos son: nombre, edad, sexo (H hombre, M mujer), peso y altura.
- Los métodos que se implementarán son:
1) calcularIMC(): calculará si la persona está en su peso ideal (peso en
kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la
función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos),
significa que está por debajo de su peso ideal la función devuelve un 0
y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la
función devuelve un 1. Se recomienda usar constantes para devolver
estos valores.
2) o esMayorDeEdad(): indica si es mayor de edad(21 años), devuelve un
booleano.
 */
