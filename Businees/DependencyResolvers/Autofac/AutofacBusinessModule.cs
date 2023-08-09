using Autofac;
using Autofac.Extras.DynamicProxy;
using Businees.Abstract;
using Businees.Concrete;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContentManager>().As<IContentService>().SingleInstance();
            builder.RegisterType<EfContentDal>().As<IContentDal>().SingleInstance();

            builder.RegisterType<HeadingManager>().As<IHeadingService>().SingleInstance();
            builder.RegisterType<EfHeadingDal>().As<IHeadingDal>().SingleInstance();

            builder.RegisterType<PageAboutManager>().As<IPageAboutService>().SingleInstance();
            builder.RegisterType<EfPageAboutDal>().As<IPageAboutDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
