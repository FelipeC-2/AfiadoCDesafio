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
    Console.WriteLine("===== 1. REVERTER AS ORDENS DAS PALAVRAS, MANTENDO A ORDEM. =====");
    Revert();
    Console.WriteLine("===== 2. REMOVER CARACTERES DUPLICADOS NA STRING. =====");
    RemoveDupe();
    Console.WriteLine("===== 3. ECONTRAR A SUBSTRING MAIS LONGA QUE É UM PALÍNDROMO. =====");
    StrPalin();
    Console.WriteLine("===== 4. TRANSFORMAR TODAS AS LETRAS DA FRASE EM LETRAS MAIÚSCULAS. =====");
    UpperCase();
    Console.WriteLine("===== 5. VERIFICAR SE A STRING É UM ANAGRAMA DE UM PALÍNDROMO. =====");
    AnagPalin();
  }

  static void Revert() {
    string linha = "Hello World! OpenAI is amazing";
    string[] palavrasArray = linha.Split(' ');
    Array.Reverse(palavrasArray);
    string linhaRev = string.Join(" ", palavrasArray);
    Console.WriteLine(linhaRev);
  }

  static void RemoveDupe() {
    string duped = "Hello World!";
    string novaString = "";
    foreach (char letter in duped){
      if(novaString.IndexOf(letter) == -1 || !Char.IsLetter(letter)){
        novaString += letter;
      }
    }
    Console.WriteLine(novaString);
  }

  static void StrPalin(){
    string palhao = "babad";
    string palinha = "";
    for (int i = 0; i < palhao.Length; i++){
      for (int j = palhao.Length - 1; j >= i; j--){
        string pequena = palhao.Substring(i, j - i + 1);
        bool ispalin = true;
        for (int k = 0; k < pequena.Length / 2; k++){
          if (pequena[k] != pequena[pequena.Length - 1 - k]){
            ispalin = false;
            break;
            }
          }
          if (ispalin && pequena.Length > palinha.Length){
            palinha = pequena;
          }
      }
    }
    Console.WriteLine(palinha);
  }
  static void UpperCase() {
    string min = "hello. how are you? i'm fine, thank you.";
    string minUp = string.Empty;
    char[] pasArray = min.ToCharArray();
    if(char.IsLower(pasArray[0])){
      pasArray[0] = char.ToUpper(pasArray[0]);
    }
    for(int i = 1; i < pasArray.Length; i++){
      int j = i - 1;
      int k = i - 2;
      try{
        if(char.IsLower(pasArray[i]) && pasArray[j] == ' ' && pasArray[k] == '?' || pasArray[k] == '.' || pasArray[k] == '!'){
        pasArray[i] = char.ToUpper(pasArray[i]);
      }
      }
      catch (Exception){

      }
    }
    minUp = new string(pasArray);
    Console.WriteLine(minUp);
  }
  static void AnagPalin() {
    string ap = "racecar";
    char[] chasArray = ap.ToCharArray();
    Array.Reverse(chasArray);
    string apRev = new string(chasArray);
    Console.WriteLine(ap.Equals(apRev, StringComparison.OrdinalIgnoreCase));

  }
}