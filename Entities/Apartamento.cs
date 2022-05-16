using System;
using System.Globalization;


namespace Mentoria_GFT_POO.Entities
{
    public class Apartamento : Imovel
    {
        public Apartamento(string cidade, string endereco, int metragem, byte qtdQuartos, double valorImovel, byte andar, string numeroApartamento, string torre) : base(cidade, endereco, metragem, qtdQuartos, valorImovel)
        {
            this.Andar = andar;
            this.NumeroApartamento = numeroApartamento;
            this.Torre = torre;
        }

        public byte Andar { get; set; }
        public string NumeroApartamento { get; set; }
        public string Torre { get; set; }

        public override double taxaCorretor()
        {
            return ValorImovel * 1.2;
        }


        public override string ToString()
        {
            return "-------<Apartamento>------" + "\n"
            + "Cidade: " + Cidade + "\n"
            + "Endereço: " + Endereco + "\n"
            + "Metragem: " + Metragem + "\n"
            + "Quantidade de Quartos: " + QtdQuartos + "\n"
            + "Andar: " + Andar + "\n"
            + "Numero do Apartamento: " + NumeroApartamento + "\n"
            + "Torre: " + Torre + "\n"
            + "Valor do Imóvel: " + ValorImovel.ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "Valor com a Taxa: " + taxaCorretor().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}