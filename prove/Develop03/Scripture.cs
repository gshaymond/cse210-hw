using System;
using System.Linq;

public class Scripture
{
    private static Referance r = new Referance();
    private static Text t = new Text();
    private static Index i = new Index();
    
    private string _referance = r.RandReferance(i._index);
    private string _text = t.RandText(i._index);

    public string Display(){
        string script = ($"{_referance} - {_text}");

        return script;
    }
    public void SplitText(){
        Text text = new Text();
        string[] words = _text.Split(' ',',');
        int i = 0;
        Console.Write($"{_referance} - ");
        foreach (string word in words)
        {
            i++;
            if ((i % 2) == 0)
            {
                Console.Write($"{word} ");
            }
            else
            {
                GetWordLength(word);
            }
        } 
    }
    private void GetWordLength(string word)
    {
        int hiddenWord = word.Length;
        int h = 1;
        do
        {
            Console.Write("_");
            h++;
        }while(h < (hiddenWord + 1));
        Console.Write(" ");
    }
}