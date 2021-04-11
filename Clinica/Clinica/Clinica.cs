using System;
using System.Collections;
using System.Text;

namespace Clinica
{
    public class Clinic
    {
        
        private ArrayList _animals;
        private ArrayList _clients;
        private ArrayList _services;
        private ArrayList _medicos;

        public Clinic() {
            _animals = new ArrayList();
            _clients = new ArrayList();
            _services = new ArrayList();
            _medicos = new ArrayList();
        }

        public ArrayList animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public ArrayList medicos
        {
            get { return _medicos; }
            set { _medicos = value; }
        }

        public ArrayList services
        {
            get { return _services; }
            set { _services = value; }
        }

        public ArrayList clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public Client obterclient_id(int id)
        {
            
            foreach(Client c in this.clients)
            {
                if(id == c.id)
                {
                    return c;
                }
            }
            return null;
        }


        
        public void imprimeServices()
        {
            
            foreach( Service serv in _services)
            {
                Console.WriteLine(serv);
                
            }
        }

        public void imprimeServices_whit_index()
        {
            int index = 0;
            foreach (Service serv in _services)
            {
                Console.WriteLine($" {index} -> {serv.name} ");
                index++;
            }
        }

        public void imprimeMedicos()
        {
            int index = 0;
            foreach (Professional med in _medicos)
            {
                Console.WriteLine($" {index} -> {med.name} ");
                index++;
            }
        }

        public void imprimeClientes()
        {
            int index = 0;
            foreach (Client cli in _clients)
            {
                Console.WriteLine($" {index} -> {cli.name} -> id:  {cli.id}");
                index++;
            }
        }


    }
}
