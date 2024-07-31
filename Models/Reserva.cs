using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Hospedagem.Models;

namespace Sistema_Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes) 
        {
            try 
            {
                if (Suite.Capacidade >= hospedes.Count) 
                {
                    Hospedes = hospedes;
                } 
                else 
                {
                    Exception e = new Exception("A capacidade da suíte é menor do que o número de hospedes");
                    System.Console.WriteLine(e.Message);
                }

            } 
            catch 
            {
                Exception e = new Exception("A capacidade da suíte é menor do que o número de hospedes");
                System.Console.WriteLine(e.Message);
            }
        }
        public void CadastrarSuite(Suite suite) 
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria() 
        {
            if (DiasReservados >= 10) 
            {
                return ((DiasReservados * Suite.ValorDiaria) / 100)*90;
            }
            else
            {
                return DiasReservados * Suite.ValorDiaria;
            }
        }
    }
}