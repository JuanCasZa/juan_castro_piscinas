Console.WriteLine("Parcial #1 --- Tema piscinas");


Piscinas piscinaAdultos = new Piscinas();
piscinaAdultos.ancho = 10;
piscinaAdultos.largo = 10;
piscinaAdultos.profundidad = 2;

piscinaAdultos.toboganes.Add(new Toboganes { altura = 20, largo = 15, color = "rojo" });
piscinaAdultos.duchas.Add(new Duchas { tipoDeAgua = "Caliente" });

Console.WriteLine("Ancho piscina: " + piscinaAdultos.ancho);
Console.WriteLine("Largo piscina: " + piscinaAdultos.largo);
Console.WriteLine("Profundo piscina: " + piscinaAdultos.ancho);

public class Piscinas
{
    public decimal largo;
    public decimal ancho;
    public decimal profundidad;
    public List<Toboganes> toboganes = new List<Toboganes>();
    public List<Duchas> duchas = new List<Duchas>();
    public List<Flotadores> flotadores = new List<Flotadores>();
}

public class Toboganes
{
    public decimal altura;
    public decimal largo;
    public String color;
}

public class Duchas
{
    public String tipoDeAgua;
}

public class Flotadores
{
    public String tipoFlotador;
    public String colorFlotador;
    public int cantidadFlotador;
}

<<<<<<< HEAD
//Cambio desde rama desarrollo para generar conflicto
=======
//Cambio desde la nube para generar conflicto...

>>>>>>> af832caf592c0a531c9a5de2ea12a59f680bfbf6


