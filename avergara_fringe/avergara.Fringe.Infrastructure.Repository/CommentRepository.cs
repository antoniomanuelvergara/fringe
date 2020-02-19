using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Transversal.Common;
using System.Data;

namespace avergara.Fringe.Infrastructure.Repository
{
    public class CommentRepository : DapperRepositoryBase, ICommentRepository
    {
        public CommentRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public IEnumerable<Comment> SelectAll<Comment>(int Id)
        {

            var sql = string.Format("SELECT * FROM [{0}] WHERE FringeId={1}", typeof(Comment).Name,Id);
            return GetItems<Comment>(CommandType.Text, sql, null);
        }

        public void DeleteCommentFringe<T>(int FringeId)
        {
            var sql = string.Format("DELETE FROM [{0}] WHERE FringeId={1}", typeof(T).Name, FringeId);
            Execute(CommandType.Text, sql, null);
            //return GetItems<T>(CommandType.Text, sql, null).FirstOrDefault();

        }


    }


}









