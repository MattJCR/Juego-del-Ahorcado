using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    class ControladorDeJuego
    {
        private string palabra;

        public string Palabra { get => palabra; set => palabra = value; }
        public string pintarPalabra(string letrasJugadas)
        {
            string resultado = "";
            string auxiliar = "";
            bool check = false;
            foreach (char letraPalabra in palabra)
            {
                auxiliar = "";
                check = false;
                for (int i = 0; i < letrasJugadas.Length & !check; i++)
                {
                    if (letrasJugadas[i] == letraPalabra)
                    {
                        auxiliar = letrasJugadas[i] + " ";
                        i = letrasJugadas.Length;
                        check = true;
                    }
                }
                if (!check)
                {
                    auxiliar = "_ ";
                }
                resultado += auxiliar;
            }
            return resultado;
        }
        public List<String> getDiccionario(string rutaDiccionario)
        {
            string palabraLimpia = "";
            string[] dic = File.ReadAllLines(rutaDiccionario);
            List<String> result = new List<String>();
            bool check = false;
            foreach (string palabraEnBruto in dic)
            {
                palabraLimpia = "";
                check = false;
                foreach (char palabra in palabraEnBruto)
                {
                    if (palabra != '/' && !check)
                    {
                        palabraLimpia += palabra;
                    }
                    else
                    {
                        check = true;
                    }
                }
                string textoNormalizado = palabraLimpia.Normalize(NormalizationForm.FormD);
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string textoSinAcentos = reg.Replace(textoNormalizado, "");
                result.Add(textoSinAcentos);
            }
            return result;
        }
        public string getPalabra(List<String> diccionario)
        {
            Random random = new Random();
            int posicion = random.Next(0, diccionario.Count - 1);
            Console.WriteLine("posicion: " + posicion);
            Console.WriteLine("palabra: " + diccionario[posicion]);
            return diccionario[posicion].ToString();
        }
        public string getPistas(int dificultad)
        {
            string pistas = "";
            while (pistas.Length < dificultad)
            {
                Random random = new Random();
                int posicion = random.Next(0, Palabra.Length - 1);
                if (pistas == "")
                {
                    pistas += Palabra[posicion];
                }
                else if (pistas != Palabra[posicion].ToString())
                {
                    pistas += Palabra[posicion];
                }
            }
            string aux = "";
            foreach (char item in pistas)
            {
                aux += item + " ";
            }
            //Console.WriteLine("PISTAS: " + aux);
            return aux;
        }
    }
}
