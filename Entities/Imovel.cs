using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Mentoria_GFT_POO.Entities
{
    public class Imovel
    {

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public int Metragem { get; set; }

        public byte QtdQuartos { get; set; }

        public double ValorImovel { get; set; }

        public Imovel(string cidade, string endereco, int metragem, byte qtdQuartos, double valorImovel)
        {
            this.Cidade = cidade;
            this.Endereco = endereco;
            this.Metragem = metragem;
            this.QtdQuartos = qtdQuartos;
            this.ValorImovel = double.Parse(valorImovel.ToString("F2", CultureInfo.InvariantCulture));

        }

        public virtual double taxaCorretor()
        {
            return ValorImovel * 1.1;
        }


        public override string ToString()
        {
            return "-------<Casa>------" + "\n"
            + "Cidade: " + Cidade + "\n"
            + "Endereço: " + Endereco + "\n"
            + "Metragem: " + Metragem + "\n"
            + "Quantidade de Quartos: " + QtdQuartos + "\n"
            + "Valor do Imóvel: " + ValorImovel.ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "Valor com a Taxa: " + taxaCorretor().ToString("F2", CultureInfo.InvariantCulture);

        }



    }
}
