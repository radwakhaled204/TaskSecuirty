

class Program 
{
     static void Main(string[] args)
    {
       
        String Characters,PlainText;
        using (StreamReader sr = new StreamReader(@"C:\Users\dell\Desktop\UNIVERSITY 3TH\Information System Secuirty\pro\TaskSecuirty\TaskSecuirty\Used Data\Alphabet.txt"))
        {
             Characters = sr.ReadLine();
        }
        using (StreamReader sr = new StreamReader(@"C:\Users\dell\Desktop\UNIVERSITY 3TH\Information System Secuirty\pro\TaskSecuirty\TaskSecuirty\Used Data\Message.txt"))
        {
           PlainText = sr.ReadLine();
            PlainText = PlainText.ToLower();
        }
        
        String CipherText="" ;

        for (int i = 0;i < PlainText.Length;i++)
        {
            if (PlainText[i] == ' ')
                CipherText+=' ';
            else
            {
                int CharcterPosition = Characters.IndexOf(PlainText[i]);
                CipherText += Characters[(CharcterPosition + 3) % Characters.Length];
            }
        }
        File.WriteAllText(@"C:\Users\dell\Desktop\UNIVERSITY 3TH\Information System Secuirty\pro\TaskSecuirty\TaskSecuirty\Used Data\Output.txt", "Substitution Technique: "+CipherText+"\n");

        String SecondCipher = CipherText;
        String FinalCipher=SecondCipher.Replace(" ","");
        String UpCharacters="", DownCharacters="";
        int x = 0;
        while  (x<FinalCipher.Length)
        {
            if (x == 0)
                UpCharacters += FinalCipher[x];
            else if (x%2 == 0)
                UpCharacters+= FinalCipher[x];
            else
                DownCharacters+= FinalCipher[x];
            x++;
        }

        CipherText=UpCharacters+DownCharacters;
        File.AppendAllText(@"C:\Users\dell\Desktop\UNIVERSITY 3TH\Information System Secuirty\pro\TaskSecuirty\TaskSecuirty\Used Data\Output.txt", "Transposition technique: "+CipherText);
        Console.WriteLine("Applied succesfully");
    }
}