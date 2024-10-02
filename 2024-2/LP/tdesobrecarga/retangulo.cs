public class Retangulo
{
    double largura;
    double altura;

    public Retangulo()
    {
        largura = 0;
        altura = 0;
    }

    public Retangulo (double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

    public void Redimensionar(double novaLargura, double novaAltura)
    {
        largura = novaLargura;
        altura = novaAltura;
    }

    public void Redimensionar(double fator)
    {
        largura *= fator;
        altura *= fator;
    }

    public void Redimensionar()
    {
        
    }

    public Retangulo(double lado)
    {
        largura = lado;
        altura = lado;
    }

}