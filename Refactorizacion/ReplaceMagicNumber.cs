//Replace Magic Number sin refactorizar

double precio = 1000;
double descuento = precio * 0.9; // ¿Qué significa 0.9?
Console.WriteLine("Precio con descuento: " + descuento);

//REPLACE MAGIC NUMBER REFACOTRIZADO

const double VIP_DISCOUNT = 0.9;
double precio = 1000;
double descuento = precio * VIP_DISCOUNT;
Console.WriteLine("Precio con descuento: " + descuento);

