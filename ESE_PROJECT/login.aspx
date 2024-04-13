<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ESE_PROJECT.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+Mono:wght@200&display=swap" rel="stylesheet"/>

    <style>
        #Image1{
            border-radius: 184px;
            height: 157px;
            width: 175px;
        }

        #Button1{
                border: 3px solid black;
                padding: 8px;
                border-radius: 10px;
}              
        }

        #Label{
            font-family: 'Noto Sans Mono', monospace;
        }

        #form1 {
            height: 524px;
            width: 450px;
            border-radius: 50px;
            background-color: white;
        }

        .txtbox{
            padding: 3px;
        }

        #Button2{
                border: 3px solid transparent;
                padding: 6px;
                border-radius: 10px;
}              
        
    </style>

    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body >  
    
    <center>
        <div>

        
    <form id="form1" runat="server">
    
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Administrator login?" />
        <br />
    
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/user_login.jpg" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Username" class="txtbox"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Username can't be empty"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" type="password" class="txtbox"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password can't be empty"></asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="transparent" ForeColor="black" style="border:3px solid black" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;<br />
        
        <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        First time user?&nbsp;
        <a href="register.aspx">Sign in</a>

        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </form>
            </div>
    </center>
</body>
</html>
