using Xunit;
using Application253E08;

namespace Application.UnitTest
{
    public class IntegrationTests
    {
        // Prueba de integración para área y volumen con precision 1
        [Theory]
        [InlineData(3, 4, 28.274, 113.096)]
        [InlineData(2, 3, 12.566, 37.699)]
        [InlineData(5, 2, 78.540, 157.080)]
        [InlineData(7, 1, 153.938, 153.938)]
        [InlineData(1, 10, 3.142, 31.416)]
        [InlineData(9, 2, 254.469, 508.938)]
        [InlineData(4, 5, 50.265, 251.325)]
        [InlineData(6, 3, 113.097, 339.291)]
        [InlineData(8, 1, 201.062, 201.062)]
        [InlineData(10, 1, 314.159, 314.159)]
        public void CalculoIntegrado_AreaYVolumen_Correcto(int radio, double altura, double areaEsperada, double volumenEsperado)
        {
            double areaCalculada = Figura253E08.CalcularArea(radio);
            double volumenCalculado = Figura253E08.CalcularVolumen(areaCalculada, altura);

            Assert.Equal(areaEsperada, areaCalculada, precision: 1);
            Assert.Equal(volumenEsperado, volumenCalculado, precision: 1);
        }
    }
}
