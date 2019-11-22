<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrativePage.aspx.cs" Inherits="FastWater.AdministrativePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .imgStyle {
    width: 1701px;
    height: 249px;
    border: 2px solid #000;
    background: url('Image/RiverAndForestUp2.jpg') 90% 90% no-repeat;
    background-size: cover;
   }
        .auto-style3 {
            height: 357px;
            width: 1567px;
        }
        .auto-style4 {
            height: 49px;
            width: 1569px;
        }
        .auto-style5 {
            height: 159px;
            width: 1568px;
        }
        .auto-style6 {
            width: 1568px;
            height: 249px;
            border: 2px solid #000;
            background: url('Image/RiverAndForestUp2.jpg') 90% 90% no-repeat;
            background-size: cover;
        }
        .auto-style7 {
            height: 193px;
            width: 1567px;
        }
        .auto-style8 {
            height: 146px;
        }
        .auto-style9 {
            height: 53px;
        }
        .auto-style10 {
            height: 139px;
        }
        .auto-style11 {
            height: 154px;
        }
        .auto-style12 {
            margin-left: 520px;
        }
    </style>
</head>
<body body style="height: 1701px; width: 1621px;">
    <form id="formAdministrativePage" runat="server">
        <div class="auto-style6">
        </div>
        <div class="auto-style4">
        </div>
        <div class="auto-style3">
            <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Height="300px" Width="1564px">
            <asp:GridView ID="GridViewKoords" runat="server" AutoGenerateColumns="False" AllowCustomPaging="True" OnSelectedIndexChanged="GridViewKoords_SelectedIndexChanged" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                <Columns>
                    <asp:CommandField ButtonType="Image" CancelImageUrl="~/Image/Hand.jpg" SelectImageUrl="~/Image/Hand.jpg" ShowSelectButton="True" />
                <asp:BoundField DataField="Id_GeographicalKoordinates" HeaderText="Id"/>
                    <asp:BoundField DataField="SRID" HeaderText="SRID"/>
                    <asp:BoundField DataField="Koordinate" HeaderText="Koordinate"/>
                    <asp:BoundField DataField="KoordinateText" HeaderText="KoordinateText"/>
                    <asp:BoundField DataField="HeighSeaLevel" HeaderText="HeighSeaLevel"/>
                    <asp:BoundField DataField="TypeKoordinates" HeaderText="TypeKoordinates"/>
                    <asp:BoundField DataField="RadiusAction" HeaderText="RadiusAction"/>
                    <asp:BoundField DataField="description" HeaderText="Description"/>
                    </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" BorderColor="#99CCFF" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
            </asp:Panel>
        </div>
        <div class="auto-style5">
            <h3 style="text-align:center">Данные для добавления/корректировки</h3>
            <h4>
                <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBoxIdKoords" runat="server" Width="19px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="SRID:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBoxSRID" runat="server" Width="60px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Тип координат:"></asp:Label>
&nbsp;&nbsp;
                <asp:DropDownList ID="DropListTypeKoords" runat="server" Height="16px" Width="84px">
                    <asp:ListItem>POINT</asp:ListItem>
                    <asp:ListItem>LINESTRING</asp:ListItem>
                    <asp:ListItem>POLYGON</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Координаты:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBoxKoords1" runat="server" Width="74px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxKoords2" runat="server" Width="67px"></asp:TextBox>
&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxKoords3" runat="server" Width="68px"></asp:TextBox>
&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxKoords4" runat="server" Width="84px"></asp:TextBox>
&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Высота над ур-м моря:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBoxHeightSea" runat="server" Width="38px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Радиус:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBoxRadiusKoords" runat="server" Width="45px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Описание:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxDescriptionKoords" runat="server" Width="116px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h4>
            <h4>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Изменить" Width="90px" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Удалить" />
            </h4>
            <h4>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;</h4>
        </div>      
        <div class="auto-style7">
            <asp:Panel ID="Panel2" runat="server" ScrollBars="Both" Height="146px" Width="1564px">
            <asp:GridView ID="GridViewPost" runat="server" AutoGenerateColumns="False" AllowCustomPaging="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Height="184px" OnSelectedIndexChanged="GridViewPost_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Image" CancelImageUrl="~/Image/Hand.jpg" SelectImageUrl="~/Image/Hand.jpg" ShowSelectButton="True" />
                <asp:BoundField DataField="Id_Post" HeaderText="Id"/>
                    <asp:BoundField DataField="NamePost" HeaderText="NamePost"/>
                    <asp:BoundField DataField="Id_GeographicalKoordinates" HeaderText="Id_GeographicalKoordinates"/>
                    <asp:BoundField DataField="NameBasin" HeaderText="Id_Basin"/>
                    <asp:BoundField DataField="TypeGround" HeaderText="Id_Ground"/>
                    <asp:BoundField DataField="NameLocality" HeaderText="Id_Locality"/>
                    <asp:BoundField DataField="DistanceBeetwenSensors" HeaderText="DistanceBeetwenSensors"/>
                    <asp:BoundField DataField="description" HeaderText="Description"/>
                    </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
            </asp:Panel>
        </div>
        <div class="auto-style8">
        <h3 style="text-align:center">Данные для добавления/корректировки</h3>
        <h4 class="auto-style9"> 
                <asp:Label ID="Label8" runat="server" Text="Id:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxIdPost" runat="server" Width="19px"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Имя поста:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxNamePost" runat="server" Width="147px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="ID координат:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropListIdKoordinat" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Text="Водоём:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropListBasin" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" Text="Грунт:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropListGround" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label13" runat="server" Text="Населённый пункт:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropListLocal" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" Text="Расст-ие м/у сенсорами:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxSensors" runat="server" Width="43px"></asp:TextBox>
&nbsp;
                <asp:Label ID="Label15" runat="server" Text="Опис-ие:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDescription" runat="server" Width="125px"></asp:TextBox>
            </h4>
            <h3>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Добавить" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button4" runat="server" Text="Изменить" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" Text="Удалить" OnClick="Button5_Click" />
&nbsp;

            </h3>
        </div>
        <div class="auto-style10">
<%--<asp:Panel ID="Panel3" runat="server" ScrollBars="Both" Height="146px" Width="1564px">
            <asp:GridView ID="GridViewFlood" runat="server" AutoGenerateColumns="False" AllowCustomPaging="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Height="184px" OnSelectedIndexChanged="GridViewPost_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Image" CancelImageUrl="~/Image/Hand.jpg" SelectImageUrl="~/Image/Hand.jpg" ShowSelectButton="True" />
                <asp:BoundField DataField="Id_Post" HeaderText="Id"/>
                    <asp:BoundField DataField="NamePost" HeaderText="NamePost"/>
                    <asp:BoundField DataField="Id_GeographicalKoordinates" HeaderText="Id_GeographicalKoordinates"/>
                    <asp:BoundField DataField="NameBasin" HeaderText="Id_Basin"/>
                    <asp:BoundField DataField="TypeGround" HeaderText="Id_Ground"/>
                    <asp:BoundField DataField="NameLocality" HeaderText="Id_Locality"/>
                    <asp:BoundField DataField="DistanceBeetwenSensors" HeaderText="DistanceBeetwenSensors"/>
                    <asp:BoundField DataField="description" HeaderText="Description"/>
                    </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
            </asp:Panel>--%>

        </div>
        <div class="auto-style11">
        </div>
        <h2 class="auto-style12">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="96px" ImageUrl="~/Image/On_Main_Page2.png" PostBackUrl="~/MainPage.aspx" Width="418px" />
            </h2>
    </form>
</body>
</html>
