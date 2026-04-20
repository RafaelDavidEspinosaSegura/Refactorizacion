//Replace Magic Number sin refactorizar

double precio = 1000;
double descuento = precio * 0.9; // ¿Qué significa 0.9?
Console.WriteLine("Precio con descuento: " + descuento);

//REPLACE MAGIC NUMBER REFACOTRIZADO

const double VIP_DISCOUNT = 0.9;
double precio = 1000;
double descuento = precio * VIP_DISCOUNT;
Console.WriteLine("Precio con descuento: " + descuento);

//Replace Magic Number refactorizado

const double VIP_DISCOUNT = 0.9;
double precio = 1000;
double descuento = precio * VIP_DISCOUNT;
Console.WriteLine("Precio con descuento: " + descuento);

//Se reemplaza el número mágico 0.9 por una constante con un nombre descriptivo, lo que mejora la legibilidad del código y facilita su mantenimiento.
//Evitando numeros magicos que no explican su proposito
//Facilita el mantenimiento del codigo, ya que si se necesita cambiar el valor del descuento, solo se debe modificar la constante en un lugar, en lugar de buscar y reemplazar todos los números mágicos en el código.
