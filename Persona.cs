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
		// SOBRE ESCRITURA DEL CONSTRUCTOR SIN PARAMETROS QUE VIENE POR DEFECTO.
        public Persona()
        {
			nombre = string.Empty;
			edad = 0;
			sexo = string.Empty;
			peso = 0.00;
			altura = 0.00;
        }

		public Persona(string nombre, double peso, double altura)
		{
			this.nombre = nombre;
			this.peso = peso;
			this.altura = altura;
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

		// METODO TOSTRING() para RETORNAR UNA CADENA DE CARACTERES QUE REPRESENTAN EL OBJETO
		public override string ToString()
		{
			return "|Nombre: " + nombre + " |Edad: " + edad + " |Sexo: " + sexo + " |Peso: " + peso + " |Altura: " + altura;
				
		
		}



	}
}
