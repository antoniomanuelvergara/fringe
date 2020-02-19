using AutoMapper;
using avergara.Fringe.Application.Interface;
using avergara.Fringe.Application.Main;
using avergara.Fringe.Domain.Core;
using avergara.Fringe.Domain.Interface;
using avergara.Fringe.Infrastructure.Data;
using avergara.Fringe.Infrastructure.Interface;
using avergara.Fringe.Infrastructure.Repository;
using avergara.Fringe.Transversal.Common;
using avergara.Fringe.Transversal.Mapper;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace avergara.Fringe.Presentation.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });


            // named mapping with "Mapper name"
            container.RegisterInstance<IMapper>(config.CreateMapper());

            container.RegisterType<IConnectionFactory, ConnectionFactory>();

            container.RegisterType<IFringeRepository, FringeRepository>();
            container.RegisterType<ICategoryFringeRepository, CategoryFringeRepository>();
            container.RegisterType<ITypeFringeRepository, TypeFringeRepository>();
            container.RegisterType<ICommentRepository, CommentRepository>();
            container.RegisterType<ITypeCommentRepository, TypeCommentRepository>();      
            container.RegisterType<IMediaRepository, MediaRepository>();
            container.RegisterType<ITypeMediaRepository, TypeMediaRepository>();


            container.RegisterType<IFringeDomain, FringeDomain>();
            container.RegisterType<ICategoryFringeDomain, CategoryFringeDomain>();
            container.RegisterType<ITypeFringeDomain, TypeFringeDomain>();
            container.RegisterType<ICommentDomain, CommentDomain>();
            container.RegisterType<ITypeCommentDomain, TypeCommentDomain>();
            container.RegisterType<IMediaDomain, MediaDomain>();
            container.RegisterType<ITypeMediaDomain, TypeMediaDomain>();


            container.RegisterType<IFringeApplication, FringeApplication>();
            container.RegisterType<ICategoryFringeApplication, CategoryFringeApplication>();
            container.RegisterType<ITypeFringeApplication, TypeFringeApplication>();
            container.RegisterType<ICommentApplication, CommentApplication>();
            container.RegisterType<ITypeCommentApplication, TypeCommentApplication>();
            container.RegisterType<IMediaApplication, MediaApplication>();
            container.RegisterType<ITypeMediaApplication, TypeMediaApplication>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}