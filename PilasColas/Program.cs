using Arreglos;
using Listas;

Console.WriteLine("-------------------ARREGLOS PILAS-------------------");

Arreglos.Pilas pilas = new Arreglos.Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("----------------------------------------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-------------------ARREGLOS COLAS-------------------");

Arreglos.Colas colas = new Arreglos.Colas(10);
colas.Agregar("cero");
colas.Agregar("uno");
colas.Agregar("dos");
colas.Agregar("tres");
colas.Agregar("cuatro");
colas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------------------");
        colas.Eliminar();
        Console.WriteLine(colas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-------------------LISTAS COLAS---------------------");

Listas.Colas Colas = new Listas.Colas();
Colas.Agregar("cero");
Colas.Agregar("uno");
Colas.Agregar("dos");
Colas.Agregar("tres");
Colas.Agregar("cuatro");
Colas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("----------------------------------------------------");
        Colas.Eliminar();
        Console.WriteLine(Colas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("-------------------LISTAS PILAS-------------------");

Listas.Pilas Pilas = new Listas.Pilas();
Pilas.Agregar("cero");
Pilas.Agregar("uno");
Pilas.Agregar("dos");
Pilas.Agregar("tres");
Pilas.Agregar("cuatro");
Pilas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("----------------------------------------------------");
        Pilas.Eliminar();
        Console.WriteLine(Pilas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}




//Listas.Pilas listas = new Listas.Pilas();





