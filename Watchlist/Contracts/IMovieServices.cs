using System.Threading.Tasks;
using Watchlist.Data.Models;
using Watchlist.Models;

namespace Watchlist.Contracts
{
    public interface IMovieServices
    {
        Task<IEnumerable<MovieViewModel>> GetAllAsync();

        Task<IEnumerable<Genre>> GetAllGenresAsync();

        Task AddMovieAsync(AddMovieViewModel model);

        Task AddMovieToCollectionAsync(int movieId, string userId);

        Task<IEnumerable<MovieViewModel>> GetWatchedAsync(string userId);

        Task RemoveMovieFromCollectionAsync(int movieId, string userId);
    }
}
