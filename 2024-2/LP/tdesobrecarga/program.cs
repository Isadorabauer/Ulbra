Retangulo retangulo1 = new Retangulo();
Retangulo retangulo2 = new Retangulo(5);
Retangulo retangulo3 = new Retangulo(4, 6);

Console.WriteLine($"Retângulo 1: Área = {retangulo1.CalcularArea()}, Perímetro = {retangulo1.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 2: Área = {retangulo2.CalcularArea()}, Perímetro = {retangulo2.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 3: Área = {retangulo3.CalcularArea()}, Perímetro = {retangulo3.CalcularPerimetro()}");

retangulo3.Redimensionar(2);
Console.WriteLine($"Retângulo 3 Redimensionado: Área = {retangulo3.CalcularArea()}, Perímetro = {retangulo3.CalcularPerimetro()}");

retangulo2.Redimensionar(10, 15);
Console.WriteLine($"Retângulo 2 Redimensionado: Área = {retangulo2.CalcularArea()}, Perímetro = {retangulo2.CalcularPerimetro()}");