using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica
{
    public class Animal
    {
        private string _name; 
        private int _age;
        private string _genre;
        private string _specie;
        private int _id_number;
        private static int _id_seed = 100;
        private Client _owner;

        public Animal(string name, int age, string genre, string specie, Client owner, Clinic clinic)
        {
            this._name = name;
            this._age = age;
            this._genre = genre;
            this._specie = specie;            
            this._id_number = _id_seed;
            _id_seed++;
            this._owner = owner;
            owner.animais.Add(this);
            clinic.animals.Add(this);
        }

        public Animal()
        {
        }

        public string name {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value; }        
        }
        public string genre { get { return _genre; }
            set { _genre = value; }
        }
        public string specie { get { return _specie; }
            set { _specie = value; }
        }
        public int id_number { get { return _id_number; }
            set { _id_number = value; }
        }

        

    }
}
