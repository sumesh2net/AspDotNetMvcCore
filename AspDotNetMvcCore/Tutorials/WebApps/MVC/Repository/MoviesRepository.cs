using Microsoft.EntityFrameworkCore;
using MVC.Interface;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MVCMovieContext _context;

        public MovieRepository(MVCMovieContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> Get()
        {
            return await _context.Movie.ToListAsync();
        }

        public async Task<Movie> GetById(int id)
        {
            return await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<int> Add(Movie movie)
        {
            _context.Add(movie);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(Movie movie)
        {
            _context.Update(movie);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Remove(Movie movie)
        {
            _context.Remove(movie);
            return await _context.SaveChangesAsync();
        }

        public async Task<Movie> FindById(int id)
        {
            return await _context.Movie.FindAsync(id);
        }

        public bool IsExist(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
