using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
       Console.Write("You wanna cipher Or decipher ");
        string option=Console.ReadLine();
        option=option.ToLower();
        switch(option){
          case "cipher":
           cipher(alphabet);
          break;
          case "decipher":
          decipher(alphabet);
          break;
          default:
          Console.Write("Sorry, Wrong choice try Again");
          break;
        }
   
  }
    static void cipher(char[] alphabet){
          Console.Write("give a password string to chiper Within 10 char ");
      string cha1=Console.ReadLine();
      char[] passsep=cha1.ToCharArray();
      char[] stri=new char[10];
      for(int i=0;i<passsep.Length;i++){

        int index=Array.IndexOf(alphabet,passsep[i]);
        
          if(index+3>alphabet.Length){
            stri[i]=alphabet[2];
          }else{
            stri[i]=alphabet[index+3];
          }
          
          }
        
      
      string cip=String.Join("",stri);
      Console.Write(cip);
     }
    

         static void decipher(char[] alphabet)
        {
            Console.Write("Enter a string to decipher: ");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            char[] resultArray = new char[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.IsLetter(inputArray[i]))
                {
                    int index = Array.IndexOf(alphabet, char.ToLower(inputArray[i]));
                    int newIndex = (index - 3 + alphabet.Length) % alphabet.Length;
                    resultArray[i] = alphabet[newIndex];

                    
                    if (char.IsUpper(inputArray[i]))
                    {
                        resultArray[i] = char.ToUpper(resultArray[i]);
                    }
                }
                else
                {
                    resultArray[i] = inputArray[i];
                }
            }

            string decipheredString = new string(resultArray);
            Console.WriteLine("Deciphered string: " + decipheredString);
        }
    }
}
