using CupcakesSln.Data;
using CupcakesSln.Models;
using System.Collections.Generic;
using System.Linq;

namespace CupcakesSln.Repositories
{
    public interface ICupcakeRepository
    {

        IEnumerable<Cupcake> GetCupcakes();
        Cupcake GetCupcakeById(int id);
        void CreateCupcake(Cupcake cupcake);
        void DeleteCupcake(int id);
        void Savechanges();
        IQueryable<Bakery> PopulateBakeriesDropDownList();


    }
}