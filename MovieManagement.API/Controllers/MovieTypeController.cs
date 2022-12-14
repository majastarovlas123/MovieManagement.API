using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Models;
using MovieManagement.Infrastructure.Abstractions.Repositories;
using MovieManagement.Infrastructure.DbModels;

namespace MovieManagement.API.Controllers
{
    public class MovieTypeController : AppControllerBase
    {
        private readonly IMovieTypeRepository _movieTypeRepository;

        public MovieTypeController(IMovieTypeRepository movieTypeRepository)
        {
            _movieTypeRepository = movieTypeRepository;
        }

        [HttpGet]
        public async Task<List<MovieType>> GetAllMovieTypes()
        {
            var movieTypeDbModels = await _movieTypeRepository.GetAll().ToListAsync();

            var movieTypes = new List<MovieType>();

            foreach (var movieTypeDbModel in movieTypeDbModels)
            {
                movieTypes.Add(new MovieType
                {
                    Id = movieTypeDbModel.Id,
                    Name = movieTypeDbModel.Name
                });
            }

            return movieTypes;
        }

        [HttpGet]
        public async Task<MovieTypeDbModel> GetMovieTypeById(Guid id)
        {
            var result = await _movieTypeRepository.GetByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<MovieType> CreateMovieType(MovieType movieType)
        {
            var movieTypeDbModel = new MovieTypeDbModel
            {
                Id = movieType.Id,
                Name = movieType.Name,
            };

            var added = await _movieTypeRepository.AddAsync(movieTypeDbModel);

            var result = new MovieType
            {
                Id = added.Id,
                Name = added.Name,
            };

            return result;
        }

        [HttpDelete]
        public async Task<MovieTypeDbModel> DeleteMovieType(Guid id)
        {
            var result = await _movieTypeRepository.GetByIdAsync(id);
            await _movieTypeRepository.DeleteAsync(id);
            return result;
        }
    }
}
