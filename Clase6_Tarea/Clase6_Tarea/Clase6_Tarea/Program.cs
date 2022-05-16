//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
Console.WriteLine(numeroSecreto);
//Línea para comprobar el funcionamiento

int n = 0;
int numeroIngresado;
do{
    n++;
    Console.Write("Adivine el número entre 1 y 20: ");
    if (!int.TryParse(Console.ReadLine(), out numeroIngresado))
    { //Comprobacion de que se ingresó un numero
        Console.WriteLine("Debe ingresar un número");
        Console.ReadKey();
        n--;}        //En caso de que no se ingrese un numero no se cuenta el intento
    
    else if (numeroIngresado > numeroSecreto) {
        Console.WriteLine("El número es demasiado grande, intenté nuevamente");
        Console.ReadKey();}

    else if (numeroIngresado < numeroSecreto){
        Console.WriteLine("El número es demasiado pequeño, intenté nuevamente");
        Console.ReadKey();}

    Console.Clear();
}while (numeroSecreto != numeroIngresado);

Console.WriteLine($"Felicitaciones, has adivinado el secreto que era:  {numeroSecreto}");
Console.WriteLine($"Lo has logrado en {n} intentos!!");
