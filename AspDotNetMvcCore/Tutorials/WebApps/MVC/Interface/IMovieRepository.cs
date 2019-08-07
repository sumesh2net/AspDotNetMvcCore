using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Interface
{
    public interface IMovieRepository : IRepository
    {
        Task<List<Movie>> Get();
        Task<Movie> GetById(int id);
        Task<int> Add(Movie movie);
        Task<int> Update(Movie movie);
        Task<int> Remove(Movie movie);
        Task<Movie> FindById(int id);
        bool IsExist(int id);
    }
}
