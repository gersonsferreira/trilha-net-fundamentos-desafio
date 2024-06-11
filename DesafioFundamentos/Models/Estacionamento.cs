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

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            //Implementado 
            string placaDoVeiculo = Console.ReadLine();
            veiculos.Add(placaDoVeiculo);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            //Implementado
            string removerPlacaDoVeiculo = Console.ReadLine();

            //Implementado
            string placa = removerPlacaDoVeiculo;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                //Implementado
                int horas = 0;
                decimal valorDaConta = 0; 

                //Implementado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal horasEstacionado = Convert.ToDecimal(Console.ReadLine());

                //Implementado
                valorDaConta = Convert.ToDecimal(precoInicial + precoPorHora * horasEstacionado);
            
                
                //Implementado
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorDaConta}");
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
                //Implementado
                foreach (string placaDoVeiculo in veiculos)
                {
                    Console.WriteLine(placaDoVeiculo);
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
