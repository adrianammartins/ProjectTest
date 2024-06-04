using NewProject;

namespace TestNewProject
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = "03/06/2024";
            Calculadora calc = new Calculadora("03/06/2024");
            return calc;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resulatdo)
        {
            Calculadora calc = contruirClasse();

            int resulatdoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resulatdo, resulatdoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resulatdo)
        {
            Calculadora calc = contruirClasse();

            int resulatdoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resulatdo, resulatdoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resulatdo)
        {
            Calculadora calc = contruirClasse();

            int resulatdoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resulatdo, resulatdoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resulatdo)
        {
            Calculadora calc = contruirClasse();

            int resulatdoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resulatdo, resulatdoCalculadora);
        }
        [Fact]

        public void TesteDivisaoPrZero()
        {

            Calculadora calc = contruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {

            Calculadora calc = contruirClasse();

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3,lista.Count);

        }
    }
}