namespace EstacionamentoDio.Models
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
            Console.Write("\nDigite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }   

        public void RemoverVeiculo()
        {
            Console.Write("\nDigite a placa do veículo para remover: ");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                string quantidades;
                decimal valorTotal = 0;
                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
                quantidades = Console.ReadLine(); //O ReadLine retorna uma string então se for usar o numero digitado para operações, é necessário
                                                  //converter para inteiro e armazenar essa converção em uma variável.

                horas = Convert.ToInt32(quantidades);

                valorTotal = precoInicial + precoPorHora * horas; //Ele vai multiplicar  o preço por horas pelas horas que o veiculo ficou estacionado, e depois vai somar com o preço inicial.

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("\nOs veículos estacionados são:");
                for(int c = 0; c < veiculos.Count; c++)
                {
                    Console.WriteLine($"\n{c+1}- {veiculos[c]}"); //Se não tiver o [c] depois de veiculos ele da erro.
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
