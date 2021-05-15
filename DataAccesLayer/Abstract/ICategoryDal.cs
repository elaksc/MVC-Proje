using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal: IRepository<Category>
    {
        //Crud operasyonlarını metod olarak tanımlıcaz
        //List<Category> List();
        //void Insert(Category p);
        //void Update(Category p);
        //void Delete(Category p);

        //Yukarıdakileri kullanmaya gerek yok artık IRepository interface ini buraya uygulamamız yeterli
    }
}
