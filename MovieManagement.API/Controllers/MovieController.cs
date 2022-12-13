using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Models;
using MovieManagement.Infrastructure.Abstractions.Repositories;
using MovieManagement.Infrastructure.DbModels;

namespace MovieManagement.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<List<MovieDbModel>> GetAllMovies()
        {
            var result = await _movieRepository.GetAll().ToListAsync();
            return result;
        }

        [HttpGet]
        public async Task<MovieDbModel> GetMovieById(Guid id)
        {
            var result = await _movieRepository.GetByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<Movie> CreateMovie(Movie movie)
        {
            var movieDbModel = new MovieDbModel()
            {
                Id = movie.Id,
                Name = movie.Name,
                MovieTypeId = movie.MovieTypeId,
            };

            var added = await _movieRepository.AddAsync(movieDbModel);

            var result = new Movie
            {
                Id = added.Id,
                Name = added.Name,
                MovieTypeId = added.MovieTypeId,
            };

            return result;
        }

        [HttpDelete]
        public async Task<MovieDbModel> DeleteMovie(Guid id)
        {
            var result = await _movieRepository.GetByIdAsync(id);
            await _movieRepository.DeleteAsync(id);
            return result;
        }
     }
}
