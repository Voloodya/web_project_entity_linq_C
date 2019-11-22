using FastWater.EntityFastWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastWater
{
    public partial class MainPage : System.Web.UI.Page
    {
        public string latitude = "51.754207";
        public string longitude = "55.106578";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //GeographyKordinatesService.AddGeographyKoordToDataBase(4326, 10, 5, "Светлый", "POINT", -76.345, -75.355);
            //GeographyKordinatesService.AddGeographyKoordToDataBase(4326, 10, 5, "Лужа", "POLYGON",10.245,10.246,13.245,13.246,12.246,11.900, 10.245, 10.246);
            //GeographyKordinatesService.RemoveGeographicalKoordinatesEf(12);
            //GeographyKordinatesService.UpdateGeographyKoord(12, 4326, 10, 5, "Озеро", "POLYGON", 11.245, 10.246, 13.245, 13.246, 12.246, 11.900, 11.245, 10.246);

            DateTime newDateTime = new DateTime(2018, 01, 02);
            //FloodService.UpdateFlood(6,6,newDateTime, 5, 0, 0.001m, 0.0002m, 4.4m, 10, -5, 1, 1, 3, 4, 0, 0.6m);
            //FloodService.RemoveFloodEf(6);
            if (!IsPostBack)
            {
                // Validate initially to force asterisks
                // to appear before the first roundtrip.
                using (var dbContext = new EntityFastWater.FastWaterContext())
                {
                    var objectPost = dbContext.Floods.Select(x => new
                    {
                        x.Post.Locality.NameLocality,
                        x.Post.GeographicalKoordinate.Id_GeographicalKoordinates,
                        x.Post.GeographicalKoordinate.KoordinateText,
                        x.DateAndTimes,
                        x.LevelSnow,
                        x.LevelWater,
                        x.WarningFlood
                    }).OrderBy(x => x.DateAndTimes).ToList();
                    GridView1.DataSource = objectPost;
                    GridView1.DataBind();

                    GridView2.DataSource = dbContext.ALLInformationOnPosts.Select(x => new
                    {
                        x.NameLocality,
                        x.Koordinate,
                        x.DateAndTimes,
                        x.ChangeLevelSnowInHour,
                        x.ChangeLevelWaterInHour,
                        x.WarningFlood
                    }).OrderBy(x => x.DateAndTimes).ToList();
                    GridView2.DataBind();

                    GridView3.DataSource = dbContext.PredictionLevelSnows.Select(x => new
                    {
                        x.Post.Locality.NameLocality,
                        x.Post.GeographicalKoordinate.KoordinateText,
                        x.Date_,
                        x.Time_,
                        x.ChangeLevelSnow,
                        x.LevelSnow,
                        x.WarningFlood
                    }).OrderBy(x => x.Date_).OrderBy(x => x.Time_).ToList();
                    GridView3.DataBind();
                    GridView4.DataSource = dbContext.PredictionLevelWaters.Select(x => new
                    {
                        x.Post.Locality.NameLocality,
                        x.Post.GeographicalKoordinate.KoordinateText,
                        x.Date_,
                        x.Time_,
                        x.ChangeLevelWater,
                        x.LevelWater,
                        x.WarningFlood
                    }).OrderBy(x => x.Date_).OrderBy(x => x.Time_).ToList();
                    GridView4.DataBind();
                }
                using (var dbContext = new EntityFastWater.FastWaterContext())
                {
                    List<string> locallitiesList = dbContext.Localities.Select(x => x.NameLocality).ToList();
                    locallitiesList.Add("");
                    DropListNameLocal1.DataSource = locallitiesList.OrderBy(x => x).Distinct();
                    DropListNameLocal1.DataBind();
                    var objectDate = dbContext.Floods.Select(x => new { x.DateAndTimes }).ToList();
                    DropListDateFirst1.DataSource = objectDate.Select(x => x.DateAndTimes.Date).OrderBy(x => x.Date).Distinct();
                    DropListDateFirst1.DataBind();
                    DropListDateSecond1.DataSource = objectDate.Select(x => x.DateAndTimes.Date).OrderByDescending(x => x.Date).Distinct();
                    DropListDateSecond1.DataBind();
                    DropListNameLocal2.DataSource = locallitiesList.OrderBy(x => x).Distinct();
                    DropListNameLocal2.DataBind();

                }
            }
        }
        protected void ButtonSearch1_Click (object sender, EventArgs e)
        {
            int level = DropListLevel1.SelectedValue.Equals("Превышен") == true ? 1 : 0;
            string koords = TextBoxKoords1.Text.Equals("") == true ? "." : TextBoxKoords1.Text;
            DateTime firstrDate = new DateTime(Int32.Parse(DropListDateFirst1.SelectedValue.Substring(6, 4)),
            Int32.Parse(DropListDateFirst1.SelectedValue.Substring(3, 2)), Int32.Parse(DropListDateFirst1.SelectedValue.Substring(0, 2)));
            DateTime secondDate = new DateTime(Int32.Parse(DropListDateSecond1.Text.Substring(6, 4)),
            Int32.Parse(DropListDateSecond1.Text.Substring(3, 2)), Int32.Parse(DropListDateSecond1.Text.Substring(0, 2)), 23, 59, 59);
            
                using (var dbContext = new EntityFastWater.FastWaterContext())
                {
                    var objectPost = dbContext.Floods.Select(x => new
                    {
                        x.Post.Locality.NameLocality,
                        x.Post.GeographicalKoordinate.Id_GeographicalKoordinates,
                        x.Post.GeographicalKoordinate.KoordinateText,
                        x.DateAndTimes,
                        x.LevelSnow,
                        x.LevelWater,
                        x.WarningFlood
                    }).ToList();
                var allInform = dbContext.ALLInformationOnPosts.Select(x => new
                {
                    x.NameLocality,
                    x.Koordinate,
                    x.DateAndTimes,
                    x.ChangeLevelSnowInHour,
                    x.ChangeLevelWaterInHour,
                    x.WarningFlood,
                }).ToList();

                if (!DropListNameLocal1.SelectedValue.Equals("") && !DropListLevel1.SelectedValue.Equals(""))
                {
                    GridView1.DataSource = objectPost.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.NameLocality.Equals(DropListNameLocal1.SelectedValue)).Where(x => x.KoordinateText.Contains(koords))
                    .Where(x => x.WarningFlood == level)
                .OrderBy(x => x.DateAndTimes);
                    GridView1.DataBind();

                    GridView2.DataSource = allInform.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.NameLocality.Equals(DropListNameLocal1.SelectedValue)).Where(x => x.Koordinate.AsText().Contains(koords))
                    .Where(x => x.WarningFlood == level)
                .OrderBy(x => x.DateAndTimes);
                    GridView2.DataBind();
                }
                else if(DropListNameLocal1.SelectedValue.Equals("") && !DropListLevel1.SelectedValue.Equals(""))
                {
                    GridView1.DataSource = objectPost.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.KoordinateText.Contains(koords))
                    .Where(x => x.WarningFlood == level)
                .OrderBy(x => x.DateAndTimes);
                    GridView1.DataBind();

                    GridView2.DataSource = allInform.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.Koordinate.AsText().Contains(koords))
                    .Where(x => x.WarningFlood == level)
                .OrderBy(x => x.DateAndTimes);
                    GridView2.DataBind();
                }
                else if(!DropListNameLocal1.SelectedValue.Equals("") && DropListLevel1.SelectedValue.Equals(""))
                {
                    GridView1.DataSource = objectPost.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.NameLocality.Equals(DropListNameLocal1.SelectedValue)).Where(x => x.KoordinateText.Contains(koords))
                .OrderBy(x => x.DateAndTimes);
                    GridView1.DataBind();

                    GridView2.DataSource = allInform.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.NameLocality.Equals(DropListNameLocal1.SelectedValue)).Where(x => x.Koordinate.AsText().Contains(koords))
                .OrderBy(x => x.DateAndTimes);
                    GridView2.DataBind();
                }
                else if (DropListNameLocal1.SelectedValue.Equals("") && DropListLevel1.SelectedValue.Equals(""))
                {
                    GridView1.DataSource = objectPost.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.KoordinateText.Contains(koords)).OrderBy(x => x.DateAndTimes);
                    GridView1.DataBind();

                    GridView2.DataSource = allInform.Where(x => x.DateAndTimes >= firstrDate).Where(x => x.DateAndTimes <= secondDate)
                    .Where(x => x.Koordinate.AsText().Contains(koords)).OrderBy(x => x.DateAndTimes);
                    GridView2.DataBind();
                }
            }


        }

        protected void ButtonAll1_Click(object sender, EventArgs e)
        {
            using (var dbContext = new EntityFastWater.FastWaterContext())
            {
                var objectPost = dbContext.Floods.Select(x => new
                {
                    x.Post.Locality.NameLocality,
                    x.Post.GeographicalKoordinate.Id_GeographicalKoordinates,
                    x.Post.GeographicalKoordinate.KoordinateText,
                    x.DateAndTimes,
                    x.LevelSnow,
                    x.LevelWater,
                    x.WarningFlood
                }).OrderBy(x => x.DateAndTimes).ToList();
                GridView1.DataSource = objectPost;
                GridView1.DataBind();

                GridView2.DataSource = dbContext.ALLInformationOnPosts.Select(x => new
                {
                    x.NameLocality,
                    x.Koordinate,
                    x.DateAndTimes,
                    x.ChangeLevelSnowInHour,
                    x.ChangeLevelWaterInHour,
                    x.WarningFlood
                }).OrderBy(x => x.DateAndTimes).ToList();
                GridView2.DataBind();
            }

          }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var userContext = new EntityFastWater.FastWaterContext();
            EntityFastWater.User user;
            user = userContext.Users.ToList().
                Where(x => x.Login.Equals(Login1.UserName)).Where(x => x.Password.Equals(Login1.Password)).FirstOrDefault();
            if (user != null) Response.Redirect("/AdministrativePage.aspx");
            else Login1.FailureText = "Ошибка авторизации!";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbContext = new EntityFastWater.FastWaterContext();
            int idKoords =Convert.ToInt32(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
            latitude = dbContext.GeographicalKoordinates.First(x => x.Id_GeographicalKoordinates == idKoords)
             .Koordinate.Latitude.ToString().Replace(',','.');
            longitude = dbContext.GeographicalKoordinates.First(x => x.Id_GeographicalKoordinates == idKoords)
             .Koordinate.Longitude.ToString().Replace(',', '.');

            // Define the name and type of the client scripts on the page.
            String csname = "UpdateGoogleMap";
            Type cstype = this.GetType();

            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = Page.ClientScript;

            StringBuilder csTextFunction = new StringBuilder();
            csTextFunction.Append("<script type=text/javascript> UpdateGoogleMap('latitude', 'longitude') </");
            csTextFunction.Append("script>");

            //cs.RegisterStartupScript(cstype, csname, csTextFunction.ToString());
            cs.RegisterStartupScript(cstype, csname, $"UpdateGoogleMap('{latitude}', '{longitude}')", true);
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbContext = new EntityFastWater.FastWaterContext();
            String koords =GridView2.DataKeys[GridView2.SelectedIndex].Value.ToString();
            int index_start = koords.IndexOf('(');
            String substr=koords.Substring(index_start + 1,koords.Length-index_start-2);
            int index_space = substr.IndexOf(' ');
            longitude = substr.Substring(0, index_space);
            String substr2 = substr.Substring(index_space+1);
            int index_space2 = substr2.IndexOf(' ') != (-1) ? substr2.IndexOf(' ') : substr2.Length;
            latitude = substr2.Substring(0, index_space2);

            // Define the name and type of the client scripts on the page.
            String csname = "UpdateGoogleMap";
            Type cstype = this.GetType();

            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = Page.ClientScript;

            StringBuilder csTextFunction = new StringBuilder();
            csTextFunction.Append("<script type=text/javascript> UpdateGoogleMap('latitude', 'longitude') </");
            csTextFunction.Append("script>");

            //cs.RegisterStartupScript(cstype, csname, csTextFunction.ToString());
            cs.RegisterStartupScript(cstype, csname, $"UpdateGoogleMap('{latitude}', '{longitude}')", true);
        }
    }
}