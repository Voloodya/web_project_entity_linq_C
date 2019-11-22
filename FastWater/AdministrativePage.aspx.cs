using FastWater.DatabaseFastWaterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastWater
{
    public partial class AdministrativePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var dbContext = new EntityFastWater.FastWaterContext())
                {
                    GridViewKoords.DataSource = DatabaseFastWaterService.GeographyKordinatesService.GetGeographicalKoordinatesEf()
                    .Select(x => new {x.Id_GeographicalKoordinates,x.SRID,x.Koordinate,x.KoordinateText,x.HeighSeaLevel, x.TypeKoordinates,x.RadiusAction,x.description});
                    GridViewKoords.DataBind();
                    //GridViewFlood.DataSource = DatabaseFastWaterService.ALLInformationOnPostService.GetALLInformationOnPostEf().
                    //    Select(x => new { x.Id_Post, x.NameLocality, x.Koordinate, x.DateAndTimes, x.LongitudeDay, x.});
                    GridViewPost.DataSource = DatabaseFastWaterService.PostService.GetPostEf().
                        Select(x => new
                        {
                            x.Id_Post,
                            x.NamePost,
                            x.Id_GeographicalKoordinates,
                            x.Basin.NameBasin,
                            x.Ground.TypeGround,
                            x.Locality.NameLocality,
                            x.DistanceBeetwenSensors,
                            x.description
                        });
                    GridViewPost.DataBind();

                    DropListIdKoordinat.DataSource= DatabaseFastWaterService.GeographyKordinatesService.GetGeographicalKoordinatesEf()
                    .Select(x => x.Id_GeographicalKoordinates);
                    DropListIdKoordinat.DataBind();

                    DropListBasin.DataSource = dbContext.Basins.Select(x => x.NameBasin).ToList();
                    DropListBasin.DataBind();

                    DropListGround.DataSource = dbContext.Grounds.Select(x => x.TypeGround).ToList();
                    DropListGround.DataBind();

                    DropListLocal.DataSource = dbContext.Localities.Select(x => x.NameLocality).ToList();
                    DropListLocal.DataBind();
                }
            }
        }

        protected void GridViewKoords_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow str = GridViewKoords.SelectedRow;
            TextBoxIdKoords.Text = str.Cells[1].Text;
            TextBoxSRID.Text = str.Cells[2].Text;
            TextBoxHeightSea.Text = str.Cells[5].Text;
            TextBoxRadiusKoords.Text = str.Cells[7].Text;
            TextBoxDescriptionKoords.Text = str.Cells[8].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropListTypeKoords.SelectedValue.Equals("LINESTRING"))
            {
                GeographyKordinatesService.AddGeographyKoordToDataBase(Convert.ToInt32(TextBoxSRID.Text),
                    Convert.ToInt32(TextBoxRadiusKoords.Text), Convert.ToInt32(TextBoxHeightSea.Text),
                    TextBoxDescriptionKoords.Text, DropListTypeKoords.SelectedValue, Convert.ToDouble(TextBoxKoords1.Text),
                    Convert.ToDouble(TextBoxKoords2.Text), Convert.ToDouble(TextBoxKoords3.Text), Convert.ToDouble(TextBoxKoords4.Text));
            }
            else if (DropListTypeKoords.SelectedValue.Equals("POINT"))
            {
                GeographyKordinatesService.AddGeographyKoordToDataBase(Convert.ToInt32(TextBoxSRID.Text),
                    Convert.ToInt32(TextBoxRadiusKoords.Text), Convert.ToInt32(TextBoxHeightSea.Text),
                    TextBoxDescriptionKoords.Text, DropListTypeKoords.SelectedValue, Convert.ToDouble(TextBoxKoords1.Text),
                    Convert.ToDouble(TextBoxKoords2.Text));
            }
            using (var dbContext = new EntityFastWater.FastWaterContext())
            {
                GridViewKoords.DataSource = DatabaseFastWaterService.GeographyKordinatesService.GetGeographicalKoordinatesEf()
                .Select(x => new { x.Id_GeographicalKoordinates, x.SRID, x.Koordinate, x.KoordinateText, x.HeighSeaLevel, x.TypeKoordinates, x.RadiusAction, x.description });
                GridViewKoords.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropListTypeKoords.SelectedValue.Equals("LINESTRING"))
            {
                GeographyKordinatesService.UpdateGeographyKoord(Convert.ToInt32(TextBoxIdKoords.Text), Convert.ToInt32(TextBoxSRID.Text),
                    Convert.ToInt32(TextBoxRadiusKoords.Text), Convert.ToInt32(TextBoxHeightSea.Text),
                    TextBoxDescriptionKoords.Text, DropListTypeKoords.SelectedValue, Convert.ToDouble(TextBoxKoords1.Text),
                    Convert.ToDouble(TextBoxKoords2.Text), Convert.ToDouble(TextBoxKoords3.Text), Convert.ToDouble(TextBoxKoords4.Text));
            }
            else if (DropListTypeKoords.SelectedValue.Equals("POINT"))
            {
                GeographyKordinatesService.UpdateGeographyKoord(Convert.ToInt32(TextBoxIdKoords.Text), Convert.ToInt32(TextBoxSRID.Text),
                    Convert.ToInt32(TextBoxRadiusKoords.Text), Convert.ToInt32(TextBoxHeightSea.Text),
                    TextBoxDescriptionKoords.Text, DropListTypeKoords.SelectedValue, Convert.ToDouble(TextBoxKoords1.Text),
                    Convert.ToDouble(TextBoxKoords2.Text));
            }
            using (var dbContext = new EntityFastWater.FastWaterContext())
            {
                GridViewKoords.DataSource = DatabaseFastWaterService.GeographyKordinatesService.GetGeographicalKoordinatesEf()
                .Select(x => new { x.Id_GeographicalKoordinates, x.SRID, x.Koordinate, x.KoordinateText, x.HeighSeaLevel, x.TypeKoordinates, x.RadiusAction, x.description });
                GridViewKoords.DataBind();
            }
        }

        protected void GridViewPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow str = GridViewPost.SelectedRow;
            TextBoxIdPost.Text = str.Cells[1].Text;
            TextBoxNamePost.Text = str.Cells[2].Text;
            TextBoxSensors.Text = str.Cells[7].Text;
            TextBoxDescription.Text = str.Cells[8].Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PostService.AddPostToDataBase(TextBoxNamePost.Text,Convert.ToDecimal(TextBoxSensors.Text),
                Convert.ToInt32(DropListIdKoordinat.SelectedValue), DropListBasin.SelectedValue,
                DropListGround.SelectedValue, DropListLocal.SelectedValue, TextBoxDescription.Text);
            GridViewPost.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GeographyKordinatesService.RemoveGeographicalKoordinatesEf(Convert.ToInt32(TextBoxIdKoords.Text));
            GridViewPost.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            PostService.RemovePostEf(Convert.ToInt32(TextBoxIdPost.Text));
            GridViewKoords.DataBind();
        }
    }
}