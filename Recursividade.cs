using System;

namespace AulaDia25
{
    public class Recursividade
    {
        public void GerarSequenciaFibonacci(int num1, int num2, int x){
            if(x >= 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, x - 1);
            }
        }        


        // 1, 1, 2, 4, 7, 13, 24
        // num1 = 1, num2 = 1, num3 =2
        // console = 1
        // num1 = 1, num2 = (1 + 1), num3 = (1 + 1 + 2)
        public void GerarSequenciaTribonacci(int num1, int num2, int num3, int x){
            if(x >= 0){
                Console.WriteLine(num1);
                GerarSequenciaTribonacci(num2, num3, num1 + num2 + num3 , x - 1);
            }
        }
        public int GerarFatorial(int numero){
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    }
}