using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Domain.Core
{
    public class MediaDomain : DomainBase<Media>, IMediaDomain
    {
        protected readonly IMediaRepository _mediaRepository;


        public MediaDomain(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;

                DapperRepositoryBase = _mediaRepository as IDapperRepositoryBase;

         }

    }


    

}
