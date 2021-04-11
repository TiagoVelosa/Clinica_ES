using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clinica
{
    public class Service //(Preço, Duração, Medicamentos)        

    {

        private string _name;
        private double _price;
        private Duration _duration;
        private ArrayList _medicines;
        private Professional _professional;

        public Service(string name, double price, int hours, int minutes, Professional professional, Clinic clinic)
        {
            this._name = name;
            this._price = price;
            this._duration = new Duration(hours, minutes);
            this._medicines = new ArrayList();
            this._professional = professional;
            clinic.services.Add(this);

        }

        public Service(string name, double price, int hours, int minutes, Professional professional, string[] medicines, Clinic clinic)
        {
            this._name = name;
            this._price = price;
            this._duration = new Duration(hours, minutes);
            this._medicines = new ArrayList();
            foreach(string x in medicines)
            {
                this._medicines.Add(x);
            }
            this._professional = professional;
            clinic.services.Add(this);

        }


        public string name {
            get { return _name; }
            set { _name = value; }
        }
        public double price {
            get { return _price; }
            set { _price = value; }
        }
        public Duration duration {
            get { return _duration; }
            set { _duration = value; }
        }
        public ArrayList medicines {
            get { return _medicines; }
            set { _medicines = value; }
        }
        public Professional professional
        {
            get { return _professional; }
            set { _professional = value; }
        }

        public override string ToString()
        {

            var builder = new System.Text.StringBuilder();
            builder.Append($"Serviço: {name} \nCusto: {price} euros \nDuração: {duration} \nMedico: {professional.name} \nNos dias: " );
            foreach(string x in professional.dias)
            {
                builder.Append($"{x} ");
            }
            builder.Append($"\nDas {professional.inicio} até as {professional.fim}  \n");
            if (medicines.Count > 0) {
                builder.Append("Medicamentos: ");
                foreach (string med in medicines)
                {
                    builder.Append(med+" ");
                }
                
            }
            builder.Append("\n");
            return builder.ToString();

        }


    }
}
