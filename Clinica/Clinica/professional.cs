using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica
{
    public class Professional
    {
        private string _name;
        private int _inicio;
        private int _fim;
        private string[] _dias;

        public Professional(string name, int inicio, int fim, string[] dias, Clinic clinica)
        {
            this._name = name;

            if (inicio < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(inicio), inicio, "A hora de inicio deverá ser valor positivo!");
            }
            else if (inicio > 24)
            {
                throw new ArgumentOutOfRangeException(nameof(inicio), inicio, "A hora de inicio deverá ser menor que 24!");
            }

            this._inicio = inicio;

            if (fim < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fim), fim, "A hora do fim do horário deverá ser valor positivo!");
            }
            else if (fim <= inicio)
            {
                throw new ArgumentOutOfRangeException(nameof(fim), fim, "A hora do fim do horário deverá ser maior que a do inicio!");

            }
            else if (fim > 24)
            {
                throw new ArgumentOutOfRangeException(nameof(fim), fim, "A hora do fim do horário deverá ser menor do que 24!");
            }

            this._fim = fim;
            this._dias =dias;
            clinica.medicos.Add(this);
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        public int fim
        {
            get { return _fim; }
            set { _fim = value; }
        }

        public string[] dias
        {
            get { return _dias; }
            set { _dias = value; }
        }

    }
}
