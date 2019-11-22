using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    public class FloodService
    {
        public static List<Flood> GetFloodEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<Flood> query = context.Floods; //Формирование запроса к БД 
                                                      //(никаких даннных в БД ещё не идет
                                                      //и ни каких данныч мы оттуда ещё не получили)
            List<Flood> listFloods = query.ToList();//Формирование SQL-запроса, получение данных
            return listFloods;
        }

        public static List<FloodJoin> GetFloodСonnectionEF()
        {
            var context = new FastWaterContext();
            var transaction = from flood in context.Floods
                              join posts in context.Posts on flood.Id_Post equals posts.Id_Post into floodPost
                              from postJoined in floodPost.DefaultIfEmpty()
                              join postKoords in context.GeographicalKoordinates on postJoined.Id_GeographicalKoordinates
                              equals postKoords.Id_GeographicalKoordinates into floodPostKoord
                              from postKoordsJoined in floodPostKoord.DefaultIfEmpty()
                              join posts in context.SolarActivities on flood.Id_SolarActivity equals posts.Id_SolarActivity
                              into floodSolar
                              from solarJoined in floodSolar.DefaultIfEmpty()
                              select new FloodJoin
                              {
                                  Id_flood = flood.Id_Flood,
                                  NamePost = postJoined.NamePost,
                                  Koords = postKoordsJoined.KoordinateText,
                                  Date = flood.DateAndTimes,
                                  LongitudeDay = flood.LongitudeDay,
                                  Snow = flood.Snow,
                                  Rain = flood.Rain,
                                  SnowRain = flood.SnowRain,
                                  AirHumidity = flood.AirHumidity,
                                  LevelSnow = flood.LevelSnow,
                                  HardnessSnow = flood.HardnessSnow,
                                  TemperatureDay = flood.TemperatureDay,
                                  TemperatureNight = flood.TemperatureNight,
                                  Id_SolarActivity = solarJoined.LevelSolar,
                                  LevelFreezingGround = flood.LevelFreezingGround,
                                  TemperatureWater = flood.TemperatureWater,
                                  LevelWater = flood.LevelWater,
                                  WarningFlood = flood.WarningFlood,
                              };
            List<FloodJoin> floodPlus = transaction.ToList();
            return floodPlus;
        }
    }
}