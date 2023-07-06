# AfiadoCDesafio
Etapa do Desafio de Código do processo seletivo da PwC. Desenvolvido em C#

Pensamentos/raciocinio antes, durante e após a implementação do código(presente como um comentário no código, também):
    
    1. Para essa etapa, precisa pegar as strings na posição reversa, e colocá-las sem que a palavra fosse alterada(Ex: "amazing" -> "gnizama").
    Solução: por meio de colocar as palavras presentes em um array, revertendo as palavras e adicionando a uma string nova.
    
    2. Daria pra checar num loop for se i = j em que j percorre toda a string, remove o caractere quando ocorre essa igualdade, descartado. 
    Solução: um loop foreach percorre a string e verifica se não há a letra, ou se não é uma letra(como pontuação e espaço) e adiciona à nova string
    
    3. Colocar os caracteres da string em um array, escrever uma string nova com essas linhas. Descartado.
    Solução: percorrer toda a string e verificar se a substring é um palíndromo ou não, com um bool pra desverificar caso não seja.
    
    4. Usar o .ToUpper para tornar a letra maiúscula. Percorrer o código e se houver um espaço vazio e após este, uma letra, transformar em letra maiúscula. Para o começo da frase, usar a posição [0] pra transformar.
    Solução: primeiro, tornar a primeira letra em maiúscula, e usando um sistema parecido, ir verificando se a letra é minúscula, e se tem "?, !, ." e um espaço antes dela. 
    Pra quando tentar verificar uma posição que não existe, o sistema pega a exceção por meio do try{} catch(Exception){}
    
    5. Similar ao 3, colocar os caracteres da string em um array, e verificar se uma string nova com os itens do array é igual à string original e se for, então true.
    Solução: Colocar num chaArray, reverter esse array, e então adicionar a uma nova string. Para verificar se é verdadeiro ou não, usar o .Equals com o detalhe pra que "Racecar" ainda equivalha a "racecaR".
