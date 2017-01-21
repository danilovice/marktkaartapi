using System.Collections.Generic;
using Marktkaart.Models;

namespace Marktkaart.Interfaces
{
    public interface IMarktkaartRepository
    {
        void Add(Markt item);
        IEnumerable<Markt> GetAll();
        Markt Find(string guid);
        void Remove(string guid);
        void Update(Markt item);
    }
}