using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ECCI_Test.ECCI_HolaMundoPortClient client = new ECCI_Test.ECCI_HolaMundoPortClient();
        string nombreUsuario = "emmanuel";
        Random _random = new Random();

        [TestMethod]
        public void TestIniciarSesion()
        {
            string res = client.iniciarJuego(nombreUsuario);
            Assert.AreEqual(nombreUsuario, res);
        }

        [TestMethod]
        public void TestLetraEsta()
        {
            string palabra = client.obtenerPalabra();
            string palabraParcial = client.obtenerPalabraParcial();
            char l = palabra[0];

            // espero que la primera esté
            string parcialEsperada = l.ToString() + palabraParcial.Substring(1);
            
            client.ingresarLetra(l.ToString());

            string resPalabraParcial = client.obtenerPalabraParcial();
            long intentos = client.obtenerIntentosRestantes();


            Assert.AreEqual(5, intentos);
            Assert.AreEqual(parcialEsperada, resPalabraParcial);

        }
        [TestMethod]
        public void TestLetraNoEsta()
        {
            string palabra = client.obtenerPalabra();
            string palabraParcial = client.obtenerPalabraParcial();

            char l;
            do
            {
                int num = _random.Next(0, 26); // Zero to 25
                l = (char)('a' + num);
            } while (palabra.Contains(l.ToString()));

    
            client.ingresarLetra(l.ToString());

            string resPalabraParcial = client.obtenerPalabraParcial();
            long intentos = client.obtenerIntentosRestantes();

            Assert.AreEqual(4, intentos);
            Assert.AreEqual(palabraParcial, resPalabraParcial);
        }

        [TestMethod]
        public void TestGano()
        {
            client.iniciarJuego(nombreUsuario);
            string palabra = client.obtenerPalabra();
            char[] letras = palabra.ToCharArray();

            foreach(char let in letras)
            {
                client.ingresarLetra(let.ToString());
            }
            long intentos = client.obtenerIntentosRestantes();
            bool g = client.gano();

            Assert.AreEqual(5, intentos);
            Assert.AreEqual(true, g);

        }

        [TestMethod]
        public void TestPerdio()
        {
            client.iniciarJuego(nombreUsuario);
            string palabra = client.obtenerPalabra();
            char l;
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    int num = _random.Next(0, 26); // Zero to 25
                    l = (char)('a' + num);
                } while (palabra.Contains(l.ToString()));

                client.ingresarLetra(l.ToString());
            }
            long intentos = client.obtenerIntentosRestantes();
            bool g = client.gano();

            Assert.AreEqual(0, intentos);
            Assert.AreEqual(false, g);
        }

        [TestMethod]
        public void TestScore()
        {
            string top = client.obtenerTop(); 
            Assert.AreNotEqual("", top);
        }
    }
}
