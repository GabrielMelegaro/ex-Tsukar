using System;

namespace Ex.Estacionamento.Models
{
    public class VeiculoModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Modelo {get;set;}
        public string Marca {get;set;}
        public string Placa {get;set;}
        public DateTime DataHorario {get;set;}
    }
}