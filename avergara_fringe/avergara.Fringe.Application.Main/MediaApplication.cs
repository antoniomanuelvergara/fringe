using AutoMapper;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Domain.Entity.entities;
using avergara.Fringe.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.Main
{
    public class MediaApplication: ApplicationBase<MediaDto, Media>, IMediaApplication
    {
        protected IMediaDomain _mediaDomain;

        public MediaApplication(IMediaDomain mediaDomain, IMapper mapper)
        {
           _mediaDomain = mediaDomain;
           _mapper = mapper;

               DomainBase = _mediaDomain as IDomainBase<Media>;

         }

    }



   
}
