// See https://aka.ms/new-console-template for more information

//Funcion sin parametros
void a() { }

//FUNCION CON PARAMETROS
int duplicar(int x) { return x * 2; }

//FUNCION PCON PARAMETROS POR DEFECTO, HAY QUE PNOERLOS DESPUES DE LOS REQUERIDOS

int duplicar2(int x, int y = 2) { return x * 2; }

//FUNCION CON PARAMETROS INDETERMINADOS
int sumar(params int[] x)  //tambien funciona sin params
{
    return 0;
}

//FUNCION POR REFERENCIA REF | ENTRADA Y SALIDA | HAY QUE INICIALIZARLO

int cantidad = 5;
void triplicar(ref int n)
{
    n *= 3;
}
/*
Console.WriteLine(cantidad);
triplicar(ref cantidad);
Console.WriteLine(cantidad);
*/

//FUNCION POR REFERENCIA OUT | SALIDA | NO SE INICIALIZA

int cantidad2;

void triplicar2(out int n)
{
    n = 1;
    n *= 3;
}
/*
triplicar2(out cantidad);
Console.WriteLine(cantidad);
*/