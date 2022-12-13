using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Models;
using MovieManagement.Infrastructure.Abstractions.Repositories;
using MovieManagement.Infrastructure.DbModels;
using MovieManagement.Infrastructure.Repositories;

namespace MovieManagement.API.Controllers
{
    public class ActorController : AppControllerBase
    {
        private readonly IActorRepository _actorRepository;

        public ActorController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        [HttpGet]
        public async Task<List<ActorDbModel>> GetAllActors()
        {
            var result = await _actorRepository.GetAll().ToListAsync();
            return result;   
        }

        [HttpGet]
        public async Task<ActorDbModel> GetActorById(Guid id)
        {
            var result = await _actorRepository.GetByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<Actor> CreateActor(Actor actor)
        {
            var actorDbModel = new ActorDbModel
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                LastName = actor.LastName,
            };

            var added = await _actorRepository.AddAsync(actorDbModel);

            var result = new Actor
            {
                Id = added.Id,
                FirstName = added.FirstName,
                LastName = added.LastName,
            };
            return result;
        }

        [HttpDelete]
        public async Task<ActorDbModel> DeleteActor(Guid id)
        {
            var result = await _actorRepository.GetByIdAsync(id);
            await _actorRepository.DeleteAsync(id);
            return result;
        }
    }
}
