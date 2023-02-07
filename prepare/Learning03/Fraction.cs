using System;

public class Fraction {
    private int _top = 0;
    private int _bottom = 0;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNum) {
        _top = wholeNum;
        _bottom = 1;
    }

    public Fraction(int nominator, int denominator) {
        _top = nominator;
        _bottom = denominator;
    }
}