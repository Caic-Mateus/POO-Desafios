using System;

namespace Elevador
{
    public class Elevador
    {
        public int andar= 0;  // 0 = terreo

        public int andares = 10;

        public int capacidade = 4;

        public int presentes=0 ;

        public void Inicio(){
            Console.WriteLine($"A capacidade do elevador é de {capacidade} pessoas e tem {andares} andares.");
        }

        public void Entrar(){
            if(presentes <4) {
              presentes ++;}

              Console.WriteLine($"Agora estão {presentes} no elevador");
              
        } 
    }
}