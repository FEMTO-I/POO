using System;

namespace Bicicleta
{
    class Bici{
        private string color;
        private int velocidad;//Default 1
        private int num_vel;//max 24, min 1
        public Bici (string color, int n)
        {
            this.color=color;
            if(n>24)
            {
                n=24;
            }
            if(n<1)
            {
                n=1;
            }
            num_vel=n;
            velocidad=1;
        }
        public int get velocidad()
        {
            return velocidad;
        }
        public void sube(){
            if(velocidad<num_vel)
            {
                velocidad++;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Bici a =new Bici ("rojo",12);
            Bici b=new Bici("Azul",26);
            Console.Writeline(b.get velocidad());
            b.sube();
            Console.Writeline(b.get velocidad());
        }
    }
}
