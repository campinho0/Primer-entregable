//PUNTO 1
Console.WriteLine("Ingrese los valore semestrales del año");
int valor = int.Parse(Console.ReadLine());
Console.WriteLine("Su renta anual es de: " + (valor*2));
Console.WriteLine("----------------------------");
if(valor< 10000){
    //5%
    Console.WriteLine("El total de renta es:" + (valor + (valor*0.05)));
    Console.WriteLine("El impuesto agregado es: 5%");
}
if(valor>= 10000 && valor < 20000){
    //10%
    Console.WriteLine("El total de renta es:" + (valor + (valor*0.1)));
    Console.WriteLine("El impuesto agregado es: 10%");
}
if(valor>= 20000 && valor < 35000){
    //15%
    Console.WriteLine("El total de renta es:" + (valor + (valor*0.15)));
    Console.WriteLine("El impuesto agregado es: 15%");
}
if(valor >= 35000 && valor <= 45000){
     //20%
    Console.WriteLine("El total de renta es:" + (valor + (valor*0.2)));
    Console.WriteLine("El impuesto agregado es: 20%");
}
if(valor > 45000){
    //30%
    Console.WriteLine("El total de renta es:" + (valor + (valor*0.3)));
    Console.WriteLine("El impuesto agregado es: 30%");
} 
//-----------------------------------------------------------------------------------------------------
//PUNTO 2
string nombre;
int edad; 
double pagoTotal = 0;
Console.WriteLine("Escribe tu nombre completo");
nombre = Console.ReadLine();
Console.WriteLine(" Hola {0}, Cuantos años tienes? ", nombre);
edad = int.Parse(Console.ReadLine());
Console.WriteLine("{0},  tienes {1} años ", nombre, edad);         
if (edad < 4){
    Console.WriteLine("tu tienes " + edad + " Entras gratis ");
}else if (edad >= 4 && edad < 18){
    pagoTotal = 15000 - (15000 * 0.05);
    Console.WriteLine("Hola " + nombre + " tu tienes " + edad + " El descuento  del 5% " + pagoTotal);
    }
else if (edad > 18){
    pagoTotal = 15000 - (15000 * 0.03);
    Console.WriteLine("Hola " + nombre + " tu tienes " + edad + " El descuento  del 3% " + pagoTotal);
}
//-----------------------------------------------------------------------------------------------------
//PUNTO 3
string veg = "Vegetariana \n 1- Pimiento \n 2- Champinones";
string noveg = "No Vegetariana \n 1- Peperoni \n 2- Salami \n 3- Pollo";
string dIngred = "Queso mazzarella y tomate";
Console.WriteLine("Elija el tipo de pizza:\n 1-Vegetariana \n 2- No vegetariana \n (Ingrese el indicativo)");
int eleccion1 = int.Parse(Console.ReadLine());
if(eleccion1 == 1){
    Console.WriteLine(veg);
    int eleccion2 = int.Parse(Console.ReadLine());
    if(eleccion2 == 1){
        Console.WriteLine("Su pizza vegetariana se despachara con pimientos, " + dIngred);
    }else if(eleccion2 == 2){
        Console.WriteLine("Su pizza vegetariana se despachara con champinones, " + dIngred);
    }else{Console.WriteLine("Ingrese un valor de la lista validos");}
}else if(eleccion1 == 2){
    Console.WriteLine(noveg);
    int eleccion2 = int.Parse(Console.ReadLine());
    if(eleccion2 == 1){
        Console.WriteLine("Su pizza no vegetariana se despachara con peperoni, " + dIngred);
    }else if(eleccion2 == 2){
            Console.WriteLine("Su pizza vegetariana se despachara con salami, " + dIngred);
    }else if(eleccion2 == 3){
            Console.WriteLine("Su pizza vegetariana se despachara con pollo, " + dIngred);
    }else{Console.WriteLine("Ingrese un valor de la lista validos");}
}else{
Console.WriteLine("Ingrese un valor de la lista validos");
}
//-----------------------------------------------------------------------------------------------------
//PUNTO 4
Console.WriteLine("Ingrese sus puntos de evalucion separado con punto(.)");
float puntos = float.Parse(Console.ReadLine());
if(puntos == float.Parse("0.0")){
    Console.WriteLine("Su nivel es inaceptable y su bonificacion es de 0");
    Environment.Exit(0);
}if(puntos == float.Parse("0.4")){
    Console.WriteLine("Su nivel es aceptable y su bonificacion es de: " + (50000 * 0.4 ));
    Environment.Exit(0);
}if(puntos == float.Parse("0.6")){
    Console.WriteLine("Su nivel es meritorio y su bonificacion es de " + (50000 * 0.6));
    Environment.Exit(0);
}
Console.WriteLine("Ingrese puntos validos");
//-----------------------------------------------------------------------------------------------------