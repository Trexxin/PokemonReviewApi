using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewId);
        ICollection<Review> GetReviewsByReviewer(int reviewId);
        bool ReviewerExists();
    }
}
