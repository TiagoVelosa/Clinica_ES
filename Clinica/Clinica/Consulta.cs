using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica
{
    public class Consulta
    {
        private Service _tipo_servico;
        private Professional _professional;
        private Client _cliente;
        private Animal _animal;
        private String _data;
        private Boolean _realizada;

        public Consulta(Service servico, Professional medico, Client cliente, Animal animal, String data, Boolean realizada) {
            this._tipo_servico = servico;
            this._professional = medico;
            this._cliente = cliente;
            this._animal = animal;
            this._data = data;
            this._realizada = realizada;
            cliente.consultas.Add(this);
            
        }

        public Service tipo_servico
        {
            get { return _tipo_servico; }
            set { _tipo_servico = value; }
        }
        public Professional professional
        {
            get { return _professional; }
            set { _professional = value; }
        }
        public Client cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        public Animal animal
        {
            get { return _animal; }
            set { _animal = value; }
        }
        public String data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Boolean realizada
        {
            get { return _realizada; }
            set { _realizada = value; }
        }

        public override string ToString()
        {
            var builder = new System.Text.StringBuilder();
            builder.Append("##############################################\n");
            builder.Append($"Consulta: {tipo_servico.name} no dia {data} \n");
            builder.Append($"Responsável: {professional.name} \n");
            builder.Append($"Cliente: {cliente.name} \n");
            builder.Append($"Animal: {animal.name} \n");
            builder.Append($"Valor: {tipo_servico.price} euros \n");
            builder.Append($"Duração: {tipo_servico.duration} \n");
            builder.Append("##############################################\n");
            return builder.ToString();
        }
    }
}
