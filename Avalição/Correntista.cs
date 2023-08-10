using Avalição;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Avalição
{
    internal class Correntista
    {
        private int _id;
        public int Id
            
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {


                    throw new Exception("id não pode ser menor que zero");

                }
                else
                {


                    this._id = value;
                }
            }
        }

       public string Nome { get; set; }
        private int cpf;
        public Correntista(int id, Label txtcpf, string nome, DialogResult dialogResult)
        {
            this._id=id;
            this.Nome = nome;
            this.cpf = cpf;         
               
        
            }
        }

    }

















