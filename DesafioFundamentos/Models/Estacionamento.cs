using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            
            veiculos.Add(Console.ReadLine());
            

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine();
        

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            
                Console.WriteLine("Por gentileza, digite a quantidade de horas permanecidas no estacionamento.");
                string horasPermanecidas = Console.ReadLine();

                int horas = int.Parse(horasPermanecidas);

                
                decimal valorTotal = 0; 

                valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int i = 0; i <= veiculos.Count; i++){
                    Console.WriteLine($"Veiculo: {veiculos[i] }");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
