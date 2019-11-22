<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="FastWater.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 1575px;
            height: 1962px;
            margin-top: 0px;
            margin-right: 30px;
        }
        .auto-style7 {
            width: 99%;
            height: 200px;
            margin-top: 16px;
        }
        .auto-style8 {
            width: 1138px;
            height: 173px;
        }
        .auto-style9 {
            width: 34px;
            height: 173px;
        }
        .auto-style10 {
            height: 173px;
            width: 482px;
        }
        .auto-style11 {
            height: 67px;
            width: 1558px;
            margin-top: 28px;
        }
        .auto-style12 {
            width: 1560px;
            height: 58px;
            margin-top: 31px;
        }
        .auto-style13 {
            width: 758px;
            height: 6px;
        }
        .auto-style14 {
            width: 16px;
            height: 6px;
        }
        .auto-style15 {
            height: 138px;
            width: 1560px;
            margin-top: 16px;
        }
        .auto-style16 {
            height: 39px;
        }
        .auto-style17 {
            width: 100%;
            margin-top: 25px;
            height: 376px;
        }
        .auto-style18 {
            margin-top: 19px;
        }
        .auto-style25 {
            width: 1546px;
        }
    .imgStyle {
    width: 99%;
    height: 249px;
    border: 2px solid #000;
    background: url('Image/RiverAndForestUp.jpg') 100% 100% no-repeat;
    background-size: cover;
   }
    .imgStyle2 {
    height: 170px;
    width: 99%;
    border: 2px solid #000;
    background: url('Image/RiverAndForestDown.jpg') 100% 100% no-repeat;
    background-size: cover;
   }
           .auto-style27 {
            height: 41px;
        }
           .auto-style29 {
            width: 409px;
            margin-left: 1136px;
            margin-right: 49px;
            margin-top: 97px;
            height: 154px;
        }
        .auto-style30 {
            margin-left: 0px;
            margin-top: 8px;
        }
        .auto-style31 {
            width: 758px;
            height: 341px;
        }
        .auto-style32 {
            width: 16px;
            height: 341px;
        }
        .auto-style33 {
            height: 341px;
        }
        .auto-style34 {
            height: 6px;
        }
        .auto-style35 {
            height: 428px;
            width: 1563px;
            margin-top: 23px;
        }
        </style>
</head>

<body style="height: 1984px; width: 1579px; margin-top: 12px; margin-right: 34px;">
    <form id="formMainPage" runat="server" class="auto-style4">
        <div class="imgStyle">
            <h4 style="text-align:right" class="auto-style29">
            <asp:Login ID="Login1" runat="server" CssClass="auto-style30" ForeColor="White" Width="401px">
                <LayoutTemplate>
                    <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0" style="width:382px;">
                                    <tr>
                                        <td align="center" colspan="2">Выполнить вход</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Имя пользователя:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server" Width="177px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="Поле &quot;Имя пользователя&quot; является обязательным." ToolTip="Поле &quot;Имя пользователя&quot; является обязательным." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Пароль:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="176px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Поле &quot;Пароль&quot; является обязательным." ToolTip="Поле &quot;Пароль&quot; является обязательным." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" runat="server" Text="Запомнить учетные данные." />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" OnClick="LoginButton_Click" Text="Выполнить вход" ValidationGroup="Login1" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>
            </h4>
        </div>
        <div class="auto-style11">
            
           <h2 style="text-align:center">
               <asp:ScriptManager ID="ScriptManager1" runat="server">
               </asp:ScriptManager>
               Данные за текущий и предшесвующие периоды</h2>
        <hr />
    </div>
              <table class="auto-style7">
            <tr>
                <td class="auto-style8">
                    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" Height="300px" Width="1015px">
            <asp:GridView ID="GridView1" runat="server" Width="1028px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Id_GeographicalKoordinates">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/Image/Hand.jpg" ShowSelectButton="True" />
                    <asp:BoundField DataField="NameLocality" HeaderText="Населённый пункт" />
<%--                    <asp:BoundField DataField="Id_GeographicalKoordinates" HeaderText="Id_GeographicalKoordinates" Visible="True"/>--%>
                    <asp:BoundField DataField="KoordinateText" HeaderText="Координаты" />
                    <asp:BoundField DataField="DateAndTimes" HeaderText="Дата и время"/>
                    <asp:BoundField DataField="LevelSnow" HeaderText="Уровень снежного покрова" DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="LevelWater" HeaderText="Уровень воды" DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="WarningFlood" HeaderText="Превышение критич. уровня" />
                </Columns>
            </asp:GridView>
            </asp:Panel>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:Panel ID="Panel2" runat="server" ScrollBars="Both" Height="300px" Width="527px">
                    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="353px" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" DataKeyNames="Koordinate">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    <Columns>
                        <asp:CommandField ButtonType="Image" SelectImageUrl="~/Image/Hand.jpg" ShowSelectButton="True" />
                    <asp:BoundField DataField="NameLocality" HeaderText="Населённый пункт" />
                    <asp:BoundField DataField="Koordinate" HeaderText="Координаты" />
                    <asp:BoundField DataField="DateAndTimes" HeaderText="Дата"/>
                    <asp:BoundField DataField="ChangeLevelSnowInHour" HeaderText="Измен-е уровня снега в ср-м за ч." DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="ChangeLevelWaterInHour" HeaderText="Измен-е уровня воды в ср-м за ч." DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="WarningFlood" HeaderText="Превышение критич. уровня" Visible="false" />
                    </Columns>
                    </asp:GridView>
                    </asp:Panel>
                </td>
            </tr>
        </table>
            
      
        <div class="auto-style15">
            <h2 style="text-align:center" class="auto-style27">Поиск</h2>
            <h5 style="text-align:left" class="auto-style18">
                <asp:Label ID="Label1" runat="server" Text="Населенный пункт"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Координаты"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Период: с"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label3" runat="server" Text="по"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Уровень воды"></asp:Label>
            </h5>

            <h2 style="text-align:left" class="auto-style16">
                <asp:DropDownList ID="DropListNameLocal1" runat="server" Height="26px" Width="236px">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBoxKoords1" runat="server" Width="214px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropListDateFirst1" runat="server" Height="26px" Width="236px">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropListDateSecond1" runat="server" Height="26px" Width="236px">
                    <asp:ListItem></asp:ListItem>
                    
                </asp:DropDownList>
            &nbsp; <asp:DropDownList ID="DropListLevel1" runat="server" Height="26px" Width="236px">
                <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Превышен</asp:ListItem>
                    <asp:ListItem>Не превышен</asp:ListItem>
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonSearch1" runat="server" OnClick="ButtonSearch1_Click" Text="Найти" />
&nbsp;&nbsp;
                
                <asp:Button ID="ButtonAll1" runat="server" OnClick="ButtonAll1_Click" Text="Отобразить всё" />
                
            </h2>
        </div>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
                 <div id="map" class="auto-style35">
            </div>
             </ContentTemplate>
            </asp:UpdatePanel>
                
        <div class="auto-style12">
            <h2 style="text-align:center">Прогнозные данные</h2>
        </div>
            <table class="auto-style17">
                <tr>
                    <td class="auto-style31">
                      <asp:Panel ID="Panel3" runat="server" ScrollBars="Both" Height="300px">
                        <asp:GridView ID="GridView3" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="false">
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                            <Columns>
                    <asp:BoundField DataField="NameLocality" HeaderText="Населённый пункт" />
                    <asp:BoundField DataField="KoordinateText" HeaderText="Координаты" />
                    <asp:BoundField DataField="Date_" HeaderText="Дата"  DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="Time_" HeaderText="Время"  DataFormatString="{0:T}"/>
                    <asp:BoundField DataField="ChangeLevelSnow" HeaderText="Измен-е уровня снега в ср-м за ч." DataFormatString="{0:G}"/>
                    <asp:BoundField DataField="LevelSnow" HeaderText="Прогнозный уровень снега" DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="WarningFlood" HeaderText="Превышение критич. уровня" Visible="false"/>
                    </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    </td>
                    <td class="auto-style32"></td>
                    <td class="auto-style33">
                        <asp:Panel ID="Panel4" runat="server" ScrollBars="Both" Height="300px">
                        <asp:GridView ID="GridView4" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="false" Width="775px">
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                    <Columns>
                    <asp:BoundField DataField="NameLocality" HeaderText="Населённый пункт" />
                    <asp:BoundField DataField="KoordinateText" HeaderText="Координаты" />
                    <asp:BoundField DataField="Date_" HeaderText="Дата"  DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="Time_" HeaderText="Время"  DataFormatString="{0:T}"/>
                    <asp:BoundField DataField="ChangeLevelWater" HeaderText="Измен-е уровня воды в ср-м за ч." DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="LevelWater" HeaderText="Прогнозный уровень воды" DataFormatString="{0:F3}"/>
                    <asp:BoundField DataField="WarningFlood" HeaderText="Превышение критич. уровня"/>
                    </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style34"></td>
                </tr>
            </table>
        <div class="imgStyle2">
        <h2 style="text-align:center">Поиск</h2>
            <h5 style="text-align:left" class="auto-style18">
                <asp:Label ID="Label6" runat="server" Text="Населенный пункт" ForeColor="White"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Координаты" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="Период: с (число, месяц.год)" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="по (число, месяц,год)" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Уровень воды" ForeColor="White"></asp:Label>
            </h5>
            <h2 class="auto-style25">

                <asp:DropDownList ID="DropListNameLocal2" runat="server" Height="22px" Width="179px">
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxKoords2" runat="server" Width="188px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropListDateFirstDay" runat="server" Height="22px" Width="56px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropListDateFirstMonth" runat="server" Height="22px" Width="53px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropListDateFirstYear" runat="server" Height="22px" Width="70px">
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropListDateSecondDay" runat="server" Height="22px" Width="45px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropListDateSecondMonth" runat="server" Height="22px" Width="41px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;<asp:DropDownList ID="DropListDateSecondYear" runat="server" Height="22px" Width="71px">
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropListLevel2" runat="server" Height="22px" Width="197px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Превышен</asp:ListItem>
                    <asp:ListItem>Не превышен</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonSearch2" runat="server" Text="Найти" Width="66px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonAll2" runat="server" Text="Отобразить всё" Width="132px" />

            </h2>
        </div>

    </form>
    </body>
</html>
<script src="http://maps.google.com/maps/api/js?sensor=false" type="text/javascript">   
</script>

<script type="text/javascript">
    var map = new google.maps.Map(document.getElementById('map'), { 
     zoom: 15, 
     center: new google.maps.LatLng(51.754207,55.106578), 
     mapTypeId: google.maps.MapTypeId.ROADMAP 
    });
</script>

<%--<script type="text/javascript">
      var latitude = "51.754207";
      var longitude= "55.106578";
      if(latitude!=null) UpdateGoogleMap(latitude, longitude);
</script>--%>

<script type="text/javascript"> 
    function UpdateGoogleMap(latitude, longitude) {
        
        var map = new google.maps.Map(document.getElementById('map'), { 
        zoom: 15, 
        center: new google.maps.LatLng(latitude,longitude), 
        mapTypeId: google.maps.MapTypeId.ROADMAP 
        });

        var marker = new google.maps.Marker({ 
        position: map.getCenter(), 
        map: map, 
        title: 'Это здесь' 
        });


    } 
</script> 

<script type="text/javascript"> UpdateGoogleMap('<%= latitude %>', '<%= longitude %>')</script>
