using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4_4_22
{
    class Persona22
    {
        public Persona22(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura22 = altura;
            this.colorOjos22 = colorOjos;
            this.colorPelo22 = colorPelo;
            this.peso22 = peso;
        }

        private int peso22;
        private int altura22;
        private string colorOjos22;
        private string colorPelo22;


        public string ColorOjos22
        {
            get { return colorOjos22; }
            set { colorOjos22 = value; }
        }
      
        public string ColorPelo22
        {
            get { return colorPelo22; }
            set { colorPelo22 = value; }
        }

        public int Altura22
        {
            get { return altura22; }
            set { altura22 = value; }
        }
       

        public int Peso22
        {
            get { return peso22; }
            set { peso22 = value; }
        }
       

        public void PonerLentillas22(string colorLentillas)
        {
         if (ComprobarColor22(colorLentillas))
         this.colorOjos22 = colorLentillas;

        }

        public void Engordar22(int cantidad)
        {
            int nuevoPeso = this.peso22 + cantidad;
            if (ComprobarPeso22(nuevoPeso))
            {
                Console.WriteLine("CUIDADO no se puede incrementar mas el peso");
            }
            else
            {
                this.peso22 = nuevoPeso;
            }
        }
    

        public void Adelgazar22(int cantidad)
        {
            int nuevoPeso = this.peso22 - cantidad;
            if (ComprobarPeso22(nuevoPeso))
            {                
          Console.WriteLine(" CUIDADO no puedes perder más peso");
            }
            else
            {
                this.peso22 = nuevoPeso;
            }
        }

        public bool ComprobarPeso22(int nuevoPeso)
        {
            return nuevoPeso > 180 || nuevoPeso < 40; ;
        }
        public bool ComprobarColor22(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("marron") || colorLentillas.Equals("verde");
        }
    }
}
