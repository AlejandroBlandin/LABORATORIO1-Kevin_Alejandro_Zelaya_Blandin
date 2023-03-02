using System;

class Persona
{
    public string nombre;
    public int edad;
    public char sexo;
    public double peso;
    public double altura;

    public Persona(string nombre, int edad, char sexo, double peso, double altura)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public void CalcularIMC()
    {
        double imc = peso / Math.Pow(altura, 2);
        if (imc < 24)
        {
            Console.WriteLine("Peso ideal");
        }
        else if (imc > 25)
        {
            Console.WriteLine("Tiene sobrepeso");
        }
        else
        {
            Console.WriteLine("Pesa dentro de los límites normales");
        }
    }

    public void esMayorDeEdad()
    {
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es MENOR de edad");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese sexo (M o F): ");
        char sexo = Convert.ToChar(Console.ReadLine());
        Console.Write("Ingrese peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Persona persona = new Persona(nombre, edad, sexo, peso, altura);
        Console.Write(nombre + ", con " + edad + " años de edad y ");
        persona.CalcularIMC();
        persona.esMayorDeEdad();

    }
}

