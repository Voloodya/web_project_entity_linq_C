using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    public class ALLInformationOnPostService
    {
        public static List<ALLInformationOnPost> GetALLInformationOnPostEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<ALLInformationOnPost> query = context.ALLInformationOnPosts; //Формирование запроса к БД 
                                                                                    //(никаких даннных в БД ещё не идет
                                                                                    //и ни каких данныч мы оттуда ещё не получили)
            List<ALLInformationOnPost> listALLInformationOnPost = query.ToList();//Формирование SQL-запроса, получение данных
            return listALLInformationOnPost;
        }
    }
}