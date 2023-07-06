using System;
class Program {
  static void Main() {
    /* 
    Pensamentos/raciocinio antes e durante implementação do código:
    1. Para essa etapa, precisa pegar as strings na posição reversa, e colocá-las sem que a palavra fosse alterada(Ex: "amazing" -> "gnizama").
    Solução: por meio de colocar as palavras presentes em um array, revertendo as palavras e adicionando a uma string nova .
    
    2. Daria pra checar num loop for se i = j em que j percorre toda a string, remove o caractere quando ocorre essa igualdade, descartado. 
    Solução: um loop foreach percorre a string e verifica se não há a letra, ou se não é uma letra(como pontuação e espaço) e adiciona à nova string
    
    3. Colocar os caracteres da string em um array, escrever uma string nova com essas linhas. Descartado.
    Solução: percorrer toda a string e verificar se a substring é um palíndromo ou não, com um bool pra desverificar caso não seja.
    
    4. Usar o .ToUpper para tornar a letra maiúscula. Percorrer o código e se houver um espaço vazio e após este, uma letra, transformar em letra maiúscula. Para o começo da frase, usar a posição [0] pra transformar.
    Solução: primeiro, tornar a primeira letra em maiúscula, e usando um sistema parecido, ir verificando se a letra é minúscula, e se tem "?, !, ." e um espaço antes dela. 
    Pra quando tentar verificar uma posição que não existe, o sistema pega a exceção por meio do try{} catch(Exception){}
    
    5. Similar ao 3, colocar os caracteres da string em um array, e verificar se uma string nova com os itens do array é igual à string original e se for, então true.
    Solução: Colocar num chaArray, reverter esse array, e então adicionar a uma nova string. Para verificar se é verdadeiro ou não, usar o .Equals com o detalhe pra que "Racecar" ainda equivalha a "racecaR".
    */
    Console.WriteLine("Digite o método que deseja executar.");
    Console.WriteLine("1. Reverte / 2. Remover duplicados / 3. Substring palíndromo / 4. Corrigir frases / 5. Verificar se é palíndromo");
    string option = Console.ReadLine();
    if(string.IsNullOrEmpty(option) ){
      Console.WriteLine("Por favor reinicie o programa e insira um valor");
    }  
    switch (option) {
      case "1":
        Console.WriteLine("===== 1. REVERTER AS ORDENS DAS PALAVRAS, MANTENDO A ORDEM. =====");
        Revert();
        break;
      case "2":
        Console.WriteLine("===== 2. REMOVER CARACTERES DUPLICADOS NA STRING. =====");
        RemoveDupe();
        break;
      case "3":
        Console.WriteLine("===== 3. ECONTRAR A SUBSTRING MAIS LONGA QUE É UM PALÍNDROMO. =====");
        StrPalin();
        break;
      case "4":
        Console.WriteLine("===== 4. TRANSFORMAR TODAS AS LETRAS DA FRASE EM LETRAS MAIÚSCULAS. =====");
        UpperCase();
        break;
      case "5":
        Console.WriteLine("===== 5. VERIFICAR SE A STRING É UM ANAGRAMA DE UM PALÍNDROMO. =====");
        AnagPalin();
        break;
      default:
        Console.WriteLine("Essa não é uma opção.");
        break;
    }
  }

  static void Revert() {
    string linha = "Hello World! OpenAI is amazing.";
    Console.WriteLine("String original: " + linha);
    string[] palavrasArray = linha.Split(' ');
    Array.Reverse(palavrasArray);
    string linhaRev = string.Join(" ", palavrasArray);
    Console.WriteLine("String com ordem reversa: " + linhaRev);
  }

  static void RemoveDupe() {
    string duped = "Hello World!";
    Console.WriteLine("String original: " + duped);
    string novaString = "";
    foreach (char letter in duped){
      if(!novaString.Contains(letter) || !Char.IsLetter(letter)){
        novaString += letter;
      }
    }
    Console.WriteLine("String com as letras duplicadas removidas: " + novaString);
  }

  static void StrPalin(){
    string palhao = "babad";
    Console.WriteLine("String original: " + palhao);
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
    Console.WriteLine("String com palíndromo mais longo: " + palinha);
  }
  static void UpperCase() {
    string min = "hello world! how are you? i'm fine, thank you.";
    Console.WriteLine("String original:" + min);
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
    string minUp = new(pasArray);
    Console.WriteLine("String corrigida: " + minUp);
  }
  static void AnagPalin() {
    string ap = "racecar";
    Console.WriteLine("String original: " + ap);
    char[] chasArray = ap.ToCharArray();
    Array.Reverse(chasArray);
    string apRev = new(chasArray);
    Console.WriteLine("É um palíndromo? " + ap.Equals(apRev, StringComparison.OrdinalIgnoreCase));
  }
}