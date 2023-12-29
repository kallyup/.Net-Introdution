using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto2.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome { 
            get =>_nome.ToUpper(); //com {} ou com => sem return

            set {
                if(value ==""){
                    throw new ArgumentException("o nome não pode ser vazio");
                }

                _nome = value;
            }
         }

        public string Sobrenome{
            get;
            set;
        } 
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade { 
            get => _idade;
            set{
                if(Idade<0){
                    throw new ArgumentException("a idade n pode ser menor que 0");
                }
                _idade = value;
            }

        }

        public void Apresentar()

        {
            Console.WriteLine($"Olá meu nome é {NomeCompleto}, tenho {Idade} anos");
        }

    }
}