using System;

public class Index
{
   private static Referance referance = new Referance();
    public int _index = Randomizer();

    static int Randomizer() {
        var index = new Random();
        return index.Next(referance.GetListLength());
    }
}