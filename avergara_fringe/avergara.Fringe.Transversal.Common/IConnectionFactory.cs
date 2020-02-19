using System.Data;

namespace avergara.Fringe.Transversal.Common
{
     public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
