using PI_P1_4_IMC;

class Program
{
    private static void Main(string[] args)
    {

        Persona p01; // P01 ES UNA VARIABLE DE TIPO PERSONA
        p01 = new Persona(); // P01 ES UN OBJETO INSTANCIA DE LA CLASE PERSONA HECHO CON NEW 

        Persona p02 = new Persona();

        Console.WriteLine("Ingrese el nombre de la persona...");
        p02.pNombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad de "+p02.pNombre+"...");
        p02.pEdad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Indique el sexo respetando 'H' para Hombre y 'M' para Mujer...");
        p02.pSexo = Console.ReadLine();

        Console.WriteLine("Ingrese el peso en Kg...");
        p02.pPeso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indique la altura en mts...");
        p02.pAltura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Presione una tecla para ver la info completa con IMC y Mayoria de edad...");
        
        Console.WriteLine(p02.ToString());

        Persona p03 = new Persona("Sonia", 25, "M", 132.5, 1.85);

        Console.WriteLine(p03.ToString());
        Console.WriteLine("Presione una tecla para finalizar...");
       
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
