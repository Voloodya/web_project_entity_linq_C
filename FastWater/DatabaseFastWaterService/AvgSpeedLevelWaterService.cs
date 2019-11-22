using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    public class AvgSpeedLevelWaterService
    {
        public static List<AVGSpeedLevelWater> GetAvgSpeedLevelWaterEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<AVGSpeedLevelWater> query = context.AVGSpeedLevelWaters; //Формирование запроса к БД 
                                                                                //(никаких даннных в БД ещё не идет
                                                                                //и ни каких данныч мы оттуда ещё не получили)
            List<AVGSpeedLevelWater> listSpeedLevelWater = query.ToList();//Формирование SQL-запроса, получение данных
            return listSpeedLevelWater;
        }
    }
}