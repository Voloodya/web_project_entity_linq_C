using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    public class PostService
    {
        public static List<Post> GetPostEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<Post> query = context.Posts; //Формирование запроса к БД 
                                                                                        //(никаких даннных в БД ещё не идет
                                                                                        //и ни каких данныч мы оттуда ещё не получили)
            List<Post> listPost = query.ToList();//Формирование SQL-запроса, получение данных
            return listPost;
        }

        public static void AddPostToDataBase(string namePost, decimal distanceSensors, int IdKoords,string nameBasin,
            string nameGround, string nameLocality, string description)
        {

            using (var dbContext = new FastWaterContext())
            {
                GeographicalKoordinate koordinate = GeographyKordinatesService.GetGeographicalKoordinatesEf().FirstOrDefault(y => y.Id_GeographicalKoordinates == IdKoords);
                Basin basin = dbContext.Basins.FirstOrDefault(y => y.NameBasin.Equals(nameBasin));
                Ground ground = dbContext.Grounds.FirstOrDefault(y => y.TypeGround.Equals(nameGround));
                Locality locality = dbContext.Localities.FirstOrDefault(y => y.NameLocality.Equals(nameLocality));

                int idKoords = dbContext.GeographicalKoordinates.FirstOrDefault(x => x.Id_GeographicalKoordinates == IdKoords).Id_GeographicalKoordinates;
                int idbasin = dbContext.Basins.FirstOrDefault(y => y.NameBasin.Equals(nameBasin)).Id_Basin;
                int idGround = dbContext.Grounds.FirstOrDefault(y => y.TypeGround.Equals(nameGround)).Id_Ground;
                int idlocal = dbContext.Localities.FirstOrDefault(y => y.NameLocality.Equals(nameLocality)).Id_Locality;

                Post post = new Post()
                {
                    NamePost = namePost,
                    DistanceBeetwenSensors = distanceSensors,
                   // GeographicalKoordinate = koordinate,
                    Id_GeographicalKoordinates=idKoords,
                   // Basin = basin,
                    Id_Basin=idbasin,
                   // Ground = ground,
                    Id_Ground= idGround,
                   // Locality = locality,
                    Id_Locality=idlocal,
                    description = description
                };
                dbContext.Posts.Add(post);
                dbContext.SaveChanges();
            }
        }

        public static void UpdatePost(int idUpdate, string namePost, decimal distanceSensors, int IdKoords, string nameBasin,
            string nameGround, string nameLocality, string description)
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            GeographicalKoordinate koordinate = GeographyKordinatesService.GetGeographicalKoordinatesEf().FirstOrDefault(y => y.Id_GeographicalKoordinates == IdKoords);
            Basin basin = context.Basins.FirstOrDefault(y => y.NameBasin.Equals(nameBasin));
            Ground ground = context.Grounds.FirstOrDefault(y => y.TypeGround.Equals(nameGround));
            Locality locality = context.Localities.FirstOrDefault(y => y.NameLocality.Equals(nameLocality));

            IQueryable<Post> query = context.Posts;
            var updateObject = query.FirstOrDefault(x => x.Id_Post == idUpdate);
            updateObject.NamePost = namePost;
            updateObject.DistanceBeetwenSensors = distanceSensors;
            updateObject.GeographicalKoordinate = koordinate;
            updateObject.Basin = basin;
            updateObject.Ground = ground;
            updateObject.Locality = locality;
            updateObject.description = description;
            context.Entry(updateObject).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public static void RemovePostEf(int idRemove)
        {
            var context = new FastWaterContext();
            IQueryable<Post> query = context.Posts;
            var removeObject = query.Where(x => x.Id_Post == idRemove).FirstOrDefault();
            if (removeObject != null)
            {
                context.Posts.Remove(removeObject);
                context.SaveChanges();
            }
        }
    }
}