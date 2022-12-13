using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Models;
using MovieManagement.Infrastructure.Abstractions.Repositories;
using MovieManagement.Infrastructure.DbModels;

namespace MovieManagement.API.Controllers
{
    public class RoleController : AppControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public async Task<List<Role>> GetAllRoles()
        {
            var roleDbModels = await _roleRepository.GetAllWithIncludes().ToListAsync();

            var roles = new List<Role>();

            foreach (var roleDbModel in roleDbModels)
            {
                roles.Add(new Role
                {
                    Id = roleDbModel.Id,
                    ActorFirstName = roleDbModel.Actor.FirstName,
                    ActorLastName = roleDbModel.Actor.LastName,
                    MovieName = roleDbModel.Movie.Name,
                });
            }

            return roles;
        }
    }
}
