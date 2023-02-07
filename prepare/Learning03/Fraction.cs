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

    public int GetTopNum() {
        return _top;
    }
    public void SetTopNum(int top) {
        _top = top;
    }

    public int GetBottomNum() {
        return _bottom;
    }
    public void SetBottomNum(int bottom) {
        _bottom = bottom;
    }

    public string GetFractionValue() {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue() {
       return (double)_top / (double)_bottom;
    }
}

