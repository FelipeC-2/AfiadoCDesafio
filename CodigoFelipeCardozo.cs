using System;
class Program {
  static void Main() {
    Console.WriteLine("Começo");
    /* 
    Pensamentos/raciocinio antes e durante implementação do código:
    1. Para essa etapa, precisa pegar as strings na posição reversa, e colocá-las sem que a palavra fosse alterada(Ex: "amazing" -> "gnizama"), solucionado por meio de colocar as palavras presentes em um array,
    revertendo a ordem e adicionando a uma string nova 
    
    2. Daria pra checar num loop for se i = j em que j percorre toda a string, remove o caractere quando ocorre essa igualdade
    
    3. Colocar os caracteres da string em um array, escrever uma string nova com essas linhas
    
    4. Usar o .ToUpper para tornar a letra maiúscula. Percorrer o código e se houver um espaço vazio e após este, uma letra, transformar em letra maiúscula. Para o começo da frase, usar a posição [0] pra transformar
    
    5. Similar ao 3, colocar os caracteres da string em um array, e verificar se uma string nova com os itens do array é igual à string original e se for, então true.
    */
    Revert();
    RemoveDupe();
  }

  static void Revert() {
    string linha = Console.ReadLine();
    string[] palavrasArray = linha.Split(' ');
    Array.Reverse(palavrasArray);
    string linhaRev = string.Join(" ", palavrasArray);
    Console.WriteLine(linhaRev);
  }

  static void RemoveDupe() {
    string duped = "Hello world, it's me";
    string novaString = "";
    foreach (char letter in duped){
      if(novaString.IndexOf(letter) == -1 || !Char.IsLetter(letter)){
        novaString += letter;
      }
    }
    Console.WriteLine(novaString);
  }

  static void StrPalin() {
    string palinha = "babad";

  }

  static void UpperCase() {
    string min = "tudo está minúsculo. ah, pera. já alterou? ufa";
    string minUp = string.Empty
    char[] pasArray = min;
    if(char.IsLower(pasArray[0])){
      pasArray[0] = char.ToUpper(char.pasArray[0]);
    }
    minUp = new string(pasArray);
  }
  static void AnagPalin() {
    string ap = "racecar";
    char[] chasArray = ap.ToCharArray();
    Array.Reverse(chasArray);
    string apRev = new string(chasArray);
    Console.WriteLine(string.Equals(ap, apRev));
  }
}