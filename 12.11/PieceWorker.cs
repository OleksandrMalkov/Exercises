using System;

public class PieceWorker : Employee                     
{
    private decimal wage;
    private int pieces;

    public PieceWorker(string first, string last, string ssn, decimal wagePerPiece, int numberOfPieces) : base(first, last, ssn)
    {
        Wage = wagePerPiece;
        Pieces = numberOfPieces;
    }

    public decimal Wage
    {
        get
        {
            return wage;
        }
        set
        {
            if (value >= 0)
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage per pieces", value, "Wage per pieces must be >= 0");
        }
    }

    public int Pieces
    {
        get
        {
            return pieces;
        }
        set
        {
            if (value >= 0)
                pieces = value;
            else
                throw new ArgumentOutOfRangeException("Pieces", value, "Number of pieces must be >= 0");
        }
    }
    public override decimal Earnings()
    {
        return Wage * Pieces;
    }
    public override string ToString()
    {
        return string.Format("Wage per piece employee: {0} \nwage per pieces: {1:C} pieces: {2}", base.ToString(), Wage, Pieces);
    }
}
