using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API___Database.Models;
using API___Database.Models.Dto;
using API___Database.Models.Dto.Result;
using API___Database.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API___Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public GenreController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<GenreDto> GetGenres()
        {
            return _context.Genres.Select(x => new GenreDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        [HttpPost("AddGenre")]
        public ResultDto Add([FromBody]AddGenreDto dto)
        {
            try
            {
                Genre genre = new Genre()
                {
                    Name = dto.Name
                };
                _context.Genres.Add(genre);
                _context.SaveChangesAsync();
                return new ResultDto
                {
                    IsSuccessful = true,
                    Message = "Successfully created"
                };
            }
            catch (Exception ex)
            {
                return new ResultDto
                { 
                    IsSuccessful = false,
                    Message = "Something goes wrong!"
                };
            }
        }


    }
}