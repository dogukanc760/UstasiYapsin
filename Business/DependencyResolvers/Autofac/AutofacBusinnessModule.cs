using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinnessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            #region SystemLoglari
            builder.RegisterType<EfSysLogDal>().As<ISysLogDal>();
            builder.RegisterType<SysLogManager>().As<ISysLog>();
            #endregion

            #region UserIdentity
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();
            #endregion

            #region Auth Middleware
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            #endregion
        }
    }
}
