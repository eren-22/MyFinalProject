using Autofac;
using Business.Abstract;
using Business.Concrete;
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
        protected override void Load(ContainerBuilder builder) // öreneğin IIS'de yayınlayıp uygulamayı ayağa kaldırdığımızda çaışacak.
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            // SingleInstance -> Bir sınıfın yalnızca bir kez oluşturulmasını ve bu örneğin tüm uygulama süresince yeniden kullanılmasını sağlar.

            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
