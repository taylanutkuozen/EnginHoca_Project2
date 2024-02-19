using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()//override Load diyoruz.
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();//Biri IProductService isterse ProductManager döndür.
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();//InSingletonScope bu type class'lar oluştuktan sonra bir tane daha oluşmasın amacı ile kullanılır..
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}