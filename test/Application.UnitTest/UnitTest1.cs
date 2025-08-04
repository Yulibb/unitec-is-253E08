using Xunit;
using Application253E08;

namespace Application.UnitTest
{
    public class FiguraTests
    {
        // PRUEBAS DEL PERÍMETRO: P = 2πr
        [Theory]
        [InlineData(1, 6.283)]
        [InlineData(2, 12.566)]
        [InlineData(3, 18.850)]
        [InlineData(4, 25.133)]
        [InlineData(5, 31.416)]
        [InlineData(6, 37.699)]
        [InlineData(7, 43.982)]
        [InlineData(8, 50.265)]
        [InlineData(9, 56.549)]
        [InlineData(10, 62.832)]
        public void CalcularPerimetro_Radios_ResultadoEsperado(int radio, double esperado)
        {
            double resultado = Figura253E08.CalcularPerimetro(radio);
            Assert.Equal(esperado, resultado, 1);
        }

        // PRUEBAS DEL ÁREA: A = πr²
        [Theory]
        [InlineData(1, 3.142)]
        [InlineData(2, 12.566)]
        [InlineData(3, 28.274)]
        [InlineData(4, 50.265)]
        [InlineData(5, 78.540)]
        [InlineData(6, 113.097)]
        [InlineData(7, 153.938)]
        [InlineData(8, 201.062)]
        [InlineData(9, 254.469)]
        [InlineData(10, 314.159)]
        public void CalcularArea_Radios_ResultadoEsperado(int radio, double esperado)
        {
            double resultado = Figura253E08.CalcularArea(radio);
            Assert.Equal(esperado, resultado, 1);
        }

        // PRUEBAS DEL VOLUMEN: V = Área × altura
        [Theory]
        [InlineData(3.142, 2, 6.284)]
        [InlineData(12.566, 3, 37.698)]
        [InlineData(28.274, 4, 113.096)]
        [InlineData(50.265, 5, 251.325)]
        [InlineData(78.540, 2, 157.080)]
        [InlineData(113.097, 3, 339.291)]
        [InlineData(153.938, 2, 307.876)]
        [InlineData(201.062, 1, 201.062)]
        [InlineData(254.469, 2, 508.938)]
        [InlineData(314.159, 1, 314.159)]
        public void CalcularVolumen_ConAreaAltura_ResultadoEsperado(double area, double altura, double esperado)
        {
            double resultado = Figura253E08.CalcularVolumen(area, altura);
            Assert.Equal(esperado, resultado, 1);
        }
    }
}
