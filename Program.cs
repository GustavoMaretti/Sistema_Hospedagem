
using Sistema_Hospedagem.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("José", "Silva");
Pessoa p2 = new Pessoa("Maria", "Santos");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("Premium", 1, 30);

Reserva reserva= new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");