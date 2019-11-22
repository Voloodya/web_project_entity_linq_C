using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Globalization;
using System.Linq;
using System.Web;

namespace FastWater.DatabaseFastWaterService
{
    class GeographyKordinatesService
    {
        public static List<GeographicalKoordinate> GetGeographicalKoordinatesEf()
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            IQueryable<GeographicalKoordinate> query = context.GeographicalKoordinates; //Формирование запроса к БД 
                                                                                        //(никаких даннных в БД ещё не идет
                                                                                        //и ни каких данныч мы оттуда ещё не получили)
            List<GeographicalKoordinate> listKoordinates = query.ToList();//Формирование SQL-запроса, получение данных
            return listKoordinates;
        }

        public static DbGeography CreatePoint(double latitude, double longitude)
        {
            var text = string.Format(CultureInfo.InvariantCulture.NumberFormat,
                                     "POINT({0} {1})", longitude, latitude);
            // 4326 is most common coordinate system used by GPS/Maps
            return DbGeography.PointFromText(text, 4326);
        }
        public static DbGeography CreatePoligon(params double[] latitude_longitude)
        {
            var text = string.Format(CultureInfo.InvariantCulture.NumberFormat,
                                     "POLYGON(({0} {1} {2},{3} {4} {5},{6} {7} {8},{9} {10} {11}))",
            latitude_longitude[0], " ", latitude_longitude[1], latitude_longitude[2], " ", latitude_longitude[3],
            latitude_longitude[4], " ", latitude_longitude[5], latitude_longitude[6], " ", latitude_longitude[7]);
            // 4326 is most common coordinate system used by GPS/Maps
            return DbGeography.PolygonFromText(text, 4326);
        }
        public static DbGeography CreateLineString(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            var text = string.Format(CultureInfo.InvariantCulture.NumberFormat,
                                     "LINESTRING({0} {1} {2}, {3} {4} {5})", longitude1, " ", latitude1, longitude2, " ", latitude2);
            // 4326 is most common coordinate system used by GPS/Maps
            return DbGeography.LineFromText(text, 4326);
        }

        public static void AddGeographyKoordToDataBase(int srid, int radiusAction, decimal heighSeaLevel, string description, string typeKoordinates, params double[] latitude_longitude)
        {
            var context = new FastWaterContext();

            //var location = new GeographicalKoordinate()
            //{
            //    // Create a point using native DbGeography Factory method
            //    Koordinate = DbGeography.PointFromText(
            //                string.Format("POINT({0} {1})", -121.527200, 45.712113)
            //                , 4326),
            //};
            //context.GeographicalKoordinates.Add(location);

            DbGeography geographyKoords = null;
            switch (typeKoordinates)
            {
                case "POINT": geographyKoords = CreatePoint(latitude_longitude[0], latitude_longitude[1]); break;
                case "LINESTRING": geographyKoords = CreateLineString(latitude_longitude[0], latitude_longitude[1], latitude_longitude[2], latitude_longitude[3]); break;
                case "POLYGON": geographyKoords = CreatePoligon(latitude_longitude); break;
                    // case  MessageBox.Show("Не верный тип координат");
            }
            GeographicalKoordinate geographicalKoordinate = new GeographicalKoordinate()
            {
                Koordinate = geographyKoords,
                SRID = srid,
                RadiusAction = radiusAction,
                HeighSeaLevel = heighSeaLevel,
                description = description,
                TypeKoordinates = typeKoordinates
            };
            context.GeographicalKoordinates.Add(geographicalKoordinate);
            context.SaveChanges();
        }
        public static void UpdateGeographyKoord(int idUpdate, int srid, int radiusAction, decimal heighSeaLevel, string description, string typeKoordinates, params double[] latitude_longitude)
        {
            var context = new FastWaterContext(); //Объект класса для получения доступа к сущностям
            DbGeography geographyKoords = null;
            switch (typeKoordinates)
            {
                case "POINT": geographyKoords = CreatePoint(latitude_longitude[0], latitude_longitude[1]); break;
                case "LINESTRING": geographyKoords = CreateLineString(latitude_longitude[0], latitude_longitude[1], latitude_longitude[2], latitude_longitude[3]); break;
                case "POLYGON": geographyKoords = CreatePoligon(latitude_longitude); break;
                    // case  MessageBox.Show("Не верный тип координат");
            }
            IQueryable<GeographicalKoordinate> query = context.GeographicalKoordinates;
            var updateObject = query.FirstOrDefault(x => x.Id_GeographicalKoordinates == idUpdate);
            updateObject.Koordinate = geographyKoords;
            updateObject.SRID = srid;
            updateObject.RadiusAction = radiusAction;
            updateObject.HeighSeaLevel = heighSeaLevel;
            updateObject.description = description;
            updateObject.TypeKoordinates = typeKoordinates;
            context.Entry(updateObject).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public static void RemoveGeographicalKoordinatesEf(int idRemove)
        {
            var context = new FastWaterContext();
            IQueryable<GeographicalKoordinate> query = context.GeographicalKoordinates;
            var removeObject = query.Where(x => x.Id_GeographicalKoordinates == idRemove).FirstOrDefault();
            if (removeObject != null)
            {
                context.GeographicalKoordinates.Remove(removeObject);
                context.SaveChanges();
            }
        }

    }
}
