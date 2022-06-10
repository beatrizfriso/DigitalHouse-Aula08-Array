// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
string[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    return string.Join("; ", listaDeFilmes);
}

// 1.1. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    return listaDeFilmes.Length;
}

// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    return listaDeFilmes[indiceDoFilme];
}

// 1.4. Adiciona um novo filme a lista pelo seu nome.
string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    return listaDeFilmes.Append(nomeDoFilme).ToArray();
}

// 1.5. Atualiza um filme a partir do seu índice na lista.
string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNome)
{
    listaDeFilmes[indiceDoFilme] = novoNome;
    return listaDeFilmes;
}

// 1.6. Listar todos os filmes com seu índice/posição na lista.
string listarTodosOsFilmesComSeuIndiceNaLista()
{
    string lista = string.Empty;

    for (var index = 0; index < listaDeFilmes.Length; index++)
    {
        lista += index + " - " + listaDeFilmes[index] + Environment.NewLine; 
    }

    return lista;
}

// 2. Resultado esperado em sua solução.
Console.WriteLine("------ Resultados da Atividade ------");

// Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");

// Retorna o número 7.
Console.WriteLine($"2. Retorna a quantidade de filmes da lista", quantidadeTotalDeFilmes());

// Se o índice for 0, retorna Clube dos Cinco;
Console.WriteLine("3. Buscar um filme pelo indice", buscarNomeDoFilmePeloIndice(0));

// Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("4. Adiciona um filme pelo nome", adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"));

// Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("5. Atualizar um filme pelo seu índice", atualizarUmFilmePeloSeuIndice(3, "Rocky III"));

// Retorna 
// 0 - Clube dos Cinco 
// 1 - A Hora do Pesadelo 
// 2 - Karatê Kid
// 3 - Rocky III
// 4 - Conan, o Bárbaro
// 5 - Highlander
// 6 - Sexta-feira 13th
Console.WriteLine("6. Listar todos os filmes com seu indice/posicao na lista.", listarTodosOsFilmesComSeuIndiceNaLista());


