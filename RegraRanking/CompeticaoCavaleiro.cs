using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraRanking
{
    public class CompeticaoCavaleiro
    {
        // Atributos
        public string Cavaleiro { get; set; }
        public string Cavalo { get; set; }
        public int ClassificacaoCategoria { get; set; }
        public int Classificacao { get; set; }
        public int CategoriaCavaleiro { get; set; }
        public double PontuacaoOriginal { get; set; }
        public double Pontuacao { get; set; }


        // Construtor
        public CompeticaoCavaleiro(string cavaleiro, string cavalo, int classificacaoCategoria, int classificacao, int categoriaCavaleiro, double pontuacaoOriginal,double pontuacao)
        {
            Cavaleiro = cavaleiro;
            Cavalo = cavalo;
            ClassificacaoCategoria = classificacaoCategoria;
            Classificacao = classificacao;
            CategoriaCavaleiro = categoriaCavaleiro;
            PontuacaoOriginal = pontuacaoOriginal;
            Pontuacao = pontuacao;
        }
    }
}
