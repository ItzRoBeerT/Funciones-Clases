using POO;

var x = new Clase();

x.Nombre = "Manolo";

String cadena = "hola";
cadena.imprimirPantalla();

List<int> lista= Enumerable.Range(0,10).ToList();
lista.mostrarLista();

Coche c1 = new Coche("Lambo");
c1.acelerar(20);
c1.acelerar(0);
Console.WriteLine("\n"+c1.Velocidad);