<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ESE_PROJECT.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Bootstrap/js/bootstrap.min.js"></script>
    <script src="Bootstrap/popper.min.js"></script>
    <style>
        body {
            background: #222D32;
            font-family: 'Roboto', sans-serif;
        }

        .login-box {
            margin-top: 75px;
            height: auto;
            background: #1A2226;
            border-radius:28px;
            text-align: center;
            box-shadow: 0 3px 6px rgba(0, 0, 0, 0.16), 0 3px 6px rgba(0, 0, 0, 0.23);
        }

        .login-key {
            height: 100px;
            font-size: 80px;
            line-height: 100px;
            background: -webkit-linear-gradient(#27EF9F, #0DB8DE);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
        }

        .login-title {
            margin-top: 15px;
            text-align: center;
            font-size: 30px;
            letter-spacing: 2px;
            margin-top: 15px;
            font-weight: bold;
            color: #ECF0F5;
        }

        .login-form {
            margin-top: 25px;
            text-align: left;
        }

        input[type=text] {
            background-color: #1A2226;
            border: none;
            border-bottom: 2px solid #0DB8DE;
            border-top: 0px;
            border-radius: 0px;
            font-weight: bold;
            outline: 0;
            margin-bottom: 20px;
            padding-left: 0px;
            color: #ECF0F5;
        }

        input[type=password] {
            background-color: #1A2226;
            border: none;
            border-bottom: 2px solid #0DB8DE;
            border-top: 0px;
            border-radius: 0px;
            font-weight: bold;
            outline: 0;
            padding-left: 0px;
            margin-bottom: 20px;
            color: #ECF0F5;
        }

        .form-group {
            margin-bottom: 40px;
            outline: 0px;
        }

        .form-control:focus {
            border-color: inherit;
            -webkit-box-shadow: none;
            box-shadow: none;
            border-bottom: 2px solid #0DB8DE;
            outline: 0;
            background-color: #1A2226;
            color: #ECF0F5;
        }

        input:focus {
            outline: none;
            box-shadow: 0 0 0;
        }

        .form-control-label{
            color: white;
        }

        #Image1{
            border-radius: 115px;
            height:170px;
            width:170px;
            margin-top:35px;
        }

       #Button1{
           border-color:#0DB8DE;
           border-radius:8px;
           background-color:#1A2226;
       }

       #Button1:hover{
           background-color:#0DB8DE;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container">
        <div class="row">
            <div class="col-lg-3 col-md-2"></div>
            <div class="col-lg-6 col-md-8 login-box">
                <div class="col-lg-12 login-key">
                    <i class="fa fa-key" aria-hidden="true"></i>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/admin_login.jpg" />
                    <br />
                </div>
                <div class="col-lg-12 login-title">
                    <br />
                    <br />
                    <br />
                    Admin Login
                </div>

                <div class="col-lg-12 login-form">
                    <div class="col-lg-12 login-form">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" ForeColor="White" Text=" "></asp:Label>
                        <br />
                        </div>
                            <div class="form-group">
                                <label class="form-control-label">USERNAME</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username can't be empty" ControlToValidate="uname" ForeColor="White"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="uname" runat="server" class="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label class="form-control-label">PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password can't be empty" ControlToValidate="pass"></asp:RequiredFieldValidator>
                                </label>
                                &nbsp;<asp:TextBox ID="pass" runat="server" class="form-control"></asp:TextBox>
                            </div>

                            <div class="col-lg-12 loginbttm">
                                <div class="col-lg-6 login-btm login-text">
                                    
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="LOGIN" ForeColor="White" />
                                </div>
                                <div class="col-lg-6 login-btm login-button">
                                </div>
                                
                            </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-2"></div>
            </form>
            </div>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
