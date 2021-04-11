    using System;
using System.Collections;
using System.Text;

namespace Clinica //(Nome, Contacto, Endereço)
{
    public class Client
    {
        private string _name;
        private int _contact;
        private string _mail;
        private ArrayList _consultas;
        private ArrayList _animais;
        private static int _idseed = 1000;
        private int _id;

        public Client(string name, int contact, string mail, Clinic clinic) {
            this._name = name;
            this._contact = contact;
            this._mail = mail;
            this._consultas = new ArrayList();
            this._animais = new ArrayList();
            this._id = _idseed;
            clinic.clients.Add(this);
            _idseed++;
        }

        public string name { get { return _name; }
            set { _name = value; }
        }
        public int contact { get { return _contact; }
            set { _contact = value; }
        }
        public string mail { get { return _mail; }
            set { _mail = value; }
        }
        public ArrayList consultas
        {
            get { return _consultas; }
            set { _consultas = value; }
        }

        public ArrayList animais
        {
            get { return _animais; }
            set { _animais = value; }
        }

        public int id { get { return _id; } }

        public void geraRelatorio_Cliente()
        {
            Console.WriteLine($"  ***  Relatório {this.name}  ***  ");
            Console.WriteLine($" Nome: {this.name}");
            Console.WriteLine($" Contacto: {this.contact}");
            Console.WriteLine($" Serviços Prestados: \n");
            foreach(Consulta cons in consultas)
            {
                if(cons.realizada == true)
                {
                    Console.WriteLine(cons.ToString());
                }
            }
            Console.WriteLine($" Consultas Marcadas : ");
            foreach (Consulta cons in consultas)
            {
                if (cons.realizada == false)
                {
                    Console.WriteLine(cons.ToString());
                }
            }

        }
        public void imprimeAnimais()
        {
            int index = 0;
            foreach (Animal pet in animais)
            {
                Console.WriteLine($" {index} -> {pet.name}");
                index++;
            }
        }

    }

    
}
