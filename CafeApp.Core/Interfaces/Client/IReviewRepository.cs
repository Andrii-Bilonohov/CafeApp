using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IReviewRepository
    {
        Task<Review> AddReview(Review review, CancellationToken cancellationToken);
        Task<Review> ViewReview(Review review, CancellationToken cancelToken);
    }
}
