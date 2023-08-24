using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQuery
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}
