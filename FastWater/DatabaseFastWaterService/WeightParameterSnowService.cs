using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    public class WeightParameterSnowService
    {
        public static List<WeightParameterSnow> GetWeightParameterSnowEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<WeightParameterSnow> query = context.WeightParameterSnows; //Формирование запроса к БД 
                                                                                    //(никаких даннных в БД ещё не идет
                                                                                    //и ни каких данныч мы оттуда ещё не получили)
            List<WeightParameterSnow> listWeightParameterSnow = query.ToList();//Формирование SQL-запроса, получение данных
            return listWeightParameterSnow;
        }

        public static void AddWeightParameterSnow(int id_WeightParameterSnow, int id_Post, int countInputs,
            int countLayer, int numberLayer, int countNeuron, decimal? longitudeDayStart,
            decimal? longitudeDayFinish, decimal? weightLongitudeDay, decimal? weightSnow,
            decimal? weightRain, decimal? weightSnowRain, decimal? weightAirHumidity,
            decimal? weightLevelSnow, decimal? weightChangeLevelSnowBefore, decimal? weightHardnessSnow,
            decimal? weightTemperatureDay, decimal? weightTemperatureNight, decimal? weightSolarActivity,
            decimal? weightLevelFreezingGround)
        {
            var context = new FastWaterContext();
            Post post = context.Posts.FirstOrDefault(y => y.Id_Post == id_Post);
            WeightParameterSnow weightParameterSnow = new WeightParameterSnow
            {
            Id_WeightParameterSnow = id_WeightParameterSnow,
            Id_Post = id_Post,
            Post = post,
            CountInputs = countInputs,
            CountLayer = countLayer,
            NumberLayer = numberLayer,
            CountNeuron = countNeuron,
            LongitudeDayStart = longitudeDayStart,
            LongitudeDayFinish = longitudeDayFinish,
            WeightLongitudeDay = weightLongitudeDay,
            WeightSnow = weightSnow,
            WeightRain = weightRain,
            WeightSnowRain = weightSnowRain,
            WeightAirHumidity = weightAirHumidity,
            WeightLevelSnow = weightLevelSnow,
            WeightChangeLevelSnowBefore = weightChangeLevelSnowBefore,
            WeightHardnessSnow = weightHardnessSnow,
            WeightTemperatureDay = weightTemperatureDay,
            WeightTemperatureNight = weightTemperatureNight,
            WeightSolarActivity = weightSolarActivity,
            WeightLevelFreezingGround = weightLevelFreezingGround,
            
        };
            context.WeightParameterSnows.Add(weightParameterSnow);
            context.SaveChanges();
        }
    }
}