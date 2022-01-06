using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCMD
{
    internal class Program{
        enum Menu {Listar=1,Adicionar =2,Remover=3, Entrada,Saida,Sair}
        static void Main(string[] args){
            bool escolheuSair=false;    
            while (!escolheuSair) {             
                Console.WriteLine("Sistema de Estoque.");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saida\n6-Sair");
                Menu opcao=(Menu)int.Parse(Console.ReadLine());
                switch (opcao){
                    case Menu.Listar:
                        break;
                    case Menu.Adicionar:
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Entrada:
                        break;
                    case Menu.Saida:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        escolheuSair = true;
                        break;
                }


            }

               
        }
    }
}
