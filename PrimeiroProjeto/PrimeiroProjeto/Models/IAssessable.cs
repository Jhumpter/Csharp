namespace PrimeiroProjeto.Models;
// An interface is like a contract for a class. It starts with a "I" as the first letter, and the contract conditions are defined below
internal interface IAssessable
{
    void AddRating(Reviews rating);
    double Average { get; }
}