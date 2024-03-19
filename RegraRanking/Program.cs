using RegraRanking;
using System.Runtime.CompilerServices;

// Criando uma lista para armazenar os competidores:
List<CompeticaoCavaleiro> competidores = new List<CompeticaoCavaleiro>();

// Adicionando os competidores manualmente, sem usar loops:
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_1", "Cavalo_1", 1, 1, 1, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_2", "Cavalo_2", 2, 2, 2, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_3", "Cavalo_3", 3, 3, 3, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_4", "Cavalo_4", 4, 4, 4, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_5", "Cavalo_5", 5, 5, 5, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_6", "Cavalo_6", 6, 6, 6, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_7", "Cavalo_7", 7, 7, 7, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_8", "Cavalo_8", 8, 8, 8, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_9", "Cavalo_9", 9, 9, 9, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_10", "Cavalo_10", 10, 10, 10, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_11", "Cavalo_11", 11, 11, 11, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_12", "Cavalo_12", 12, 12, 12, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_13", "Cavalo_13", 13, 13, 13, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_14", "Cavalo_14", 14, 14, 14, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_15", "Cavalo_15", 15, 15, 15, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_16", "Cavalo_16", 16, 16, 16, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_17", "Cavalo_17", 17, 17, 17, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_18", "Cavalo_18", 18, 18, 18, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_19", "Cavalo_19", 19, 19, 19, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_20", "Cavalo_20", 19, 20, 20, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_21", "Cavalo_21", 19, 21, 21, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_22", "Cavalo_22", 22, 22, 22, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_23", "Cavalo_23", 23, 23, 23, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_24", "Cavalo_24", 24, 24, 24, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_25", "Cavalo_25", 25, 25, 25, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_26", "Cavalo_26", 26, 26, 26, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_27", "Cavalo_27", 27, 27, 27, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_28", "Cavalo_28", 28, 28, 28, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_29", "Cavalo_29", 28, 29, 29, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_30", "Cavalo_30", 30, 30, 30, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_31", "Cavalo_31", 31, 31, 31, 0, 0));
competidores.Add(new CompeticaoCavaleiro("Cavaleiro_32", "Cavalo_32", 32, 32, 32, 0, 0));

// Calcula a média das pontuações para cada classificação empatada:
var lista = competidores
                        .GroupBy(x => x.ClassificacaoCategoria)
                        .Select(x => new { Qtd = x.Count(), Itens = x.ToList(), Media = (double)(x.Sum(x => x.PontuacaoOriginal) / x.Count()) })
                        .Where(y => y.Qtd > 1);

// Valor do peso da pontuação:
int valor = 1;

// Defini pontuação para resultados:
foreach (var item in competidores)
{
    if (item.ClassificacaoCategoria == 1)
    {
        item.PontuacaoOriginal = (competidores.Count + valor);
        item.Pontuacao = (competidores.Count + valor);
    }
    else
    {
        item.PontuacaoOriginal = (competidores.Count - valor);
        item.Pontuacao = (competidores.Count - valor);
        valor++;
    }
}

//Desempata e preenche valor da média:
foreach (var item in competidores)
{
    if (lista.Any(y => y.Itens.Any(z => z.ClassificacaoCategoria == item.ClassificacaoCategoria)))
    {
        var empatado = lista.FirstOrDefault(y => y.Itens.Any(z => z.ClassificacaoCategoria == item.ClassificacaoCategoria));
        item.Pontuacao = empatado.Media;
    }
}

Console.WriteLine("Teste");