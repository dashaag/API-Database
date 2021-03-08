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
    public class FilmsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FilmsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<FilmDto> GetFilms()
        {
            return _context.Films.Select(x => new FilmDto
            {
                Id = x.Id,
                Name = x.Name,
                Year = x.Year,
                GenreName = x.Genre.Name,
                GenreId = x.GenreId
            }).ToList();
        }

        [HttpPost("AddFilm")]
        public ResultDto Add([FromBody] AddFilmDto dto)
        {
            try
            {
                Film film = new Film()
                {
                    Name = dto.Name,
                    Year = dto.Year,
                    GenreId = _context.Genres.FirstOrDefault(x=>x.Name == dto.GenreName).Id
                };
                _context.Films.Add(film);
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