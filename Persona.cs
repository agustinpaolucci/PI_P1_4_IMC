using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_P1_4_IMC
{
    class Persona
    {
		
		// ATRIBUTOS PRIVADOS
		private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;


        // METODOS CONSTRUCTORES 
		// CONSTRUCTOR SIN PARAMETROS QUE VIENE POR DEFECTO PERO LO HACEMOS EXPLICITO
		// INICIALIZAMOS VARIABLES
        public Persona()
        {
			nombre = string.Empty;
			edad = 0;
			sexo = string.Empty;
			peso = 0.0;
			altura = 0.0;
        }

		public Persona(string nombre, int edad, string sexo, double peso, double altura)
		{
			this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }


        // PROPIEDADES PÚBLICAS
        public string pNombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public int pEdad
		{
			get { return edad; }
			set { edad = value; }
		}

		public string pSexo
		{
			get { return sexo; }
			set { sexo = value; }
		}

		public double pPeso
		{
			get { return peso; }
			set { peso = value; }
		}

		public double pAltura
		{
			get { return altura; }
			set { altura = value; }
		}

	

		// METODOS DE CONTROL
		
		public int CalcularIMC()
		{
			double imc = 0.0;
			imc = peso / (altura * altura);
			int valor;

			if (imc < 20)
			{
				return valor = -1;
			}

			else
			{
				if (imc > 25)
				{
					return valor = 1;
				}
				else
				{
					return valor = 0;
				}
			}
            
        }

		public bool EsMayorDeEdad()
		{	
			if (edad >= 21)
			{
				return true;
			}
			else
			{
				return false;
			}
		}




		// METODO TOSTRING() para RETORNAR UNA CADENA DE CARACTERES QUE REPRESENTAN EL OBJETO
		public override string ToString()
		{
			return "|Nombre: " + this.nombre + " |Edad: " + edad + " |Sexo: " + sexo + " |Peso: " + peso + " |Altura: " + altura +" |IMC: " + this.CalcularIMC() +" |Es mayor de edad? " +this.EsMayorDeEdad();

		}



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