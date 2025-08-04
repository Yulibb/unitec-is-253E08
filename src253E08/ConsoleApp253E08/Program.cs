
Console.Write("Ingresa el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresa el ALTRA del círculo: ");
double altura = Convert.ToDouble(Console.ReadLine());

double perimetro = Application253E08.Figura253E08.CalcularPerimetro(radio);
double area = Application253E08.Figura253E08.CalcularArea(radio);
double volumen = Application253E08.Figura253E08.CalcularVolumen(area, altura);

Console.WriteLine($"Perímetro: {perimetro:F2}");
Console.WriteLine($"Área: {area:F2}");
Console.WriteLine($"Volumen (como esfera): {volumen:F2}");

