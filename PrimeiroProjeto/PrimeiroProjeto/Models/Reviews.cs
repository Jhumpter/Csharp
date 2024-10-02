namespace PrimeiroProjeto.Models;

internal class Reviews
{
    public Reviews(int rating)
    {
        if (rating < 0) rating = 0;
        if (rating > 10) rating = 10;
        Rating = rating;
    }
    public int Rating { get; }

    //'static' means it's not necessary to instantiate the class with "new" to use the method, allows to use Reviews.Parse(), for instance.
    public static Reviews Parse(string review)
    {
        int rating = int.Parse(review);
        return new Reviews(rating);
    }
}