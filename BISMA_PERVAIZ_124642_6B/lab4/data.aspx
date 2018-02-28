<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="lab4.data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 388px;
            height: 255px;
        }
        .style4
        {
            width: 304px;
        }
        .style6
        {
            width: 36px;
        }
        .style10
        {
            width: 70px;
        }
        .style14
        {
            width: 291px;
            height: 55px;
        }
        .style15
        {
            width: 75px;
        }
        .style16
        {
            width: 210px;
        }
    </style>

</head>


<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" 
                    RepeatDirection="Horizontal" >
                    <ItemTemplate>
                        <table class="style2">
                           
                            <tr>
                                <td style="color: #FFFF66" class="style10">
                                    &nbsp;</td>
                                <td class="style4" >
                                    <table class="style14">
                                        <tr>
                                            <td class="style16">
                                                User ID :
                                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                                            </td>                                    
                                        </tr>
                                        <tr>
                                            <td class="style16">
                                                Name :
                                                <asp:Label ID="lblname" runat="server" Text='<%#Eval("names") %>'></asp:Label>
                                            </td>                                    
                                        </tr>
                                        <tr>
                                            <td class="style16">
                                                Gender&nbsp; :
                                                <asp:Label ID="lblprice" runat="server" Text='<%#Eval("gender") %>'></asp:Label>
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="style16">
                                                Age :
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("age") %>'></asp:Label>
                                            </td>                                    
                                        </tr>
                                         <tr>
                                            <td class="style16">
                                                CNIC :
                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("cnic") %>'></asp:Label>
                                            </td>                                    
                                        </tr>
                                         <tr>
                                            <td class="style16">
                                                Address :
                                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("address") %>'></asp:Label>
                                            </td>                                    
                                        </tr>
                                    </table>
                                    <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
                                </td>
                                <td class="style6" style="color: #FFFF66">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <HeaderTemplate>
                <asp:Label id="lblHeader" runat="server" Font-Names="Tahoma" ><h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Users Data</h1></asp:Label>
                     </HeaderTemplate>
   
            <FooterTemplate>
                <hr />
            </FooterTemplate>
   
            
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
