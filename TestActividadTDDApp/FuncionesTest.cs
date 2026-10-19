using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-1, -1)]
        [DataRow(-5, -1)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("abc", false)]
        [DataRow("abcdef", false)]
        [DataRow("abcdefg", false)] 
        [DataRow("abcdefgh", true)]
        [DataRow("Hola1234_", true)]
        public void EsContrasenyaValida_VariosCasos(string contrasenya, bool esperado)
        {
            bool result = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(esperado, result);
        }
    }
}