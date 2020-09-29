using System;

namespace Lancamento_oblicuo
{
    class Program
    {
        static void Main(string[] args)
        {
            Double V0, A, G = 19.6133 ;
            String T;
           do
           {
               Console.Clear();
               Moldura();
               Console.Write("\nvelocidade do projetil, m/s: ");
               V0 = Convert.ToDouble(Console.ReadLine());            
               Console.Write("Angulo de lançameto de 0° a 90°: ");
               A = Convert.ToDouble(Console.ReadLine());     // terei que forçar que os angulos fiquem nos valores 0 e 90
              
Console.SetCursorPosition(0,8);
                //******* Altura Maxima   ******
               Double senA = Math.Sin(A * (Math.PI/180));
               Double Hmax =Math.Round((Math.Pow((V0*senA),2))/G,2);
               Console.Write("\nAltura Maxima : "+Hmax+" metros");

               //******* Distacia maxima ******
               Double Dist = Math.Round((Math.Pow(V0,2)* Math.Sin((A*2) * (Math.PI/180)))/(G/2),2);
               Console.Write("\nAlcance : "+Dist+" metros");

               Console.ResetColor();
               Console.Write("\n\n(S)air?:");           
               T = Console.ReadLine().ToUpper();
           }
            while(T != "S");
            Console.Clear();
         
        }

            static void Moldura()// Metodo Moldura
            {
            string titulo;
             titulo = "Lançamento Oblicuo";
             int tamanho = titulo.Length;               //tamanho do titulo
            
             Console.ForegroundColor = ConsoleColor.DarkYellow;
             string lin = new string('*', tamanho+4);   // monta linha de *
             string Esp = new string(' ', tamanho);     // espaço vazio onde sera impresso o titulo
             Console.WriteLine(lin);                    // linha superior
             Console.WriteLine("* "+Esp+" *");          // linha do titulo com paredes *
             Console.WriteLine(lin);                    // linha inferior

             Console.ResetColor();
             Console.SetCursorPosition(2, 1);
             Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine(titulo);                 // Imprime o titulo dentro da caixa
             Console.SetCursorPosition(0,7);
             Console.WriteLine(lin);
             Console.SetCursorPosition(0, 3);
             
             
            }
        
    }
}
