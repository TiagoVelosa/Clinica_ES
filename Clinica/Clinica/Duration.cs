using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica
{
    public class Duration
    {
        private int _hours;
        private int _minutes;

        public Duration(int hours, int minutes)
        {
            this._hours = hours;
            this._minutes = minutes;
        }
        public int hours {
            get { return _hours; }
            set { _hours = value; }
                         }
        public int minutes {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} horas, {1} minutos",_hours,_minutes);
            
        }
    }

    
}
