using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;

namespace CafeApp.Core.Interfaces.Client
{
    public interface IReviewService
    {
        Task<Review> AddReview(ReviewDto reviewDto, CancellationToken cancellationToken);
        Task<Review> ViewReview(ReviewDto reviewDto, CancellationToken cancelToken);
    }
}
