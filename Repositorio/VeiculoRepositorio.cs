using System;
using System.IO;
using Ex.Estacionamento.Models;

namespace Ex.Estacionamento.Repositorio
{
    public class VeiculoRepositorio
    {
        private const string PATH = "Database/Registros.csv";
        public bool Inserir(VeiculoModel veiculo){
            try{
            if(!File.Exists(PATH).Close()){
                //Codigo de criação do arquivo
                File.Create(PATH).Close();
            }
            var registro =$"{veiculo.Id};{veiculo.Nome};{veiculo.Modelo};{veiculo.Marca};{veiculo.Placa}";
                // Codigo de gravação
            File.AppendAllText(PATH,registro);
            }catch(Exception e){
                System.Console.WriteLine("Chegou no CATCH!");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }
    }
}