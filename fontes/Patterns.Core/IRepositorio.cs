using System.Collections.Generic;
using System.Linq;

namespace Patterns.Core
{
    public interface IRepositorio<TEntidade>
    {
        TEntidade Inclui(TEntidade entidade);
        TEntidade ComId(long id);

        void Exclui(TEntidade entidade);
        void Exclui(long id);

        IEnumerable<TEntidade> Lista();
        IQueryable<TEntidade> QueryableLista();

        long Total { get; }
    }
}
