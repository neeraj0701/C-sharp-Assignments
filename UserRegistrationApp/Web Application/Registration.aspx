<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Application_Layer.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <style>
        #container {
            width: 100vw;
            height: 100vh;
            background-color: #8BC6EC;
            background-image: linear-gradient(135deg, #8BC6EC 0%, #9599E2 100%);
            display: flex;
            align-items: center;
            justify-content: center;
        }

        * {
            margin: 0px;
            padding: 0px;
            box-sizing: border-box;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .card {
            width: 400px;
            height: 650px;
            background-color: white;
            display: flex;
            align-items: center;
            flex-direction: column;
            border-radius: 15px;
        }

        h2 {
            margin: 10px;
            text-align: center;
        }

        #form1 {
            display: flex;
            flex-direction: column;
            justify-content: space-evenly;
            gap: 10px;
        }

        .form {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .label, .input {
            width: 320px;
            height: 25px;
        }

        .labels {
            height: 30px;
            font-size: large;
            font-weight: bold;
        }

        .inputs {
            width: 320px;
            height: 30px;
            border-radius: 2px;
            border: 1px black solid;
        }

        .button {
            margin-top: 40px;
        }

        .submit {
            cursor: pointer;
            width: 320px;
            height: 40px;
            font-size: x-large;
            font-weight: bold;
            border: 2px solid black;
            border-radius: 7px;
        }

            .submit:hover {
                background-color: forestgreen;
            }

        .loginNow {
            cursor: pointer;
            width: 100px;
            height: 30px;
            font-size: large;
            font-weight: bold;
            color: black;
        }

            .loginNow:hover {
                color: red;
            }

        .account {
            display: flex;
            flex-direction: column;
            align-items: end;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <div id="container">
        <div class="card">
            <h2>Registration</h2>
            <form id="form1" runat="server">
                <div class="form">
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label1" CssClass="labels" runat="server">UserName :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="username" MaxLength="15" MinLength="7" runat="server" class="inputs" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label2" CssClass="labels" runat="server">Name :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="name" runat="server" class="inputs" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label3" CssClass="labels" runat="server">Email :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="mail" TextMode="Email" class="inputs" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label4" CssClass="labels" runat="server">Mobile :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="mobile" TextMode="Phone" class="inputs" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label5" CssClass="labels" runat="server">Password :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="password" TextMode="Password" class="inputs" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label6" CssClass="labels" runat="server">Confirm Password :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="confirmPassword" TextMode="Password" class="inputs" required="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="button">
                    <asp:Button runat="server" CssClass="submit" Text="Submit" OnClick="Registration_Click" />
                </div>
                <div class="account">
                    <p>Already have an account</p>
                    <div class="login">
                        <asp:HyperLink Text="Login" Font-Underline="false" CssClass="loginNow" NavigateUrl="~/Login.aspx" runat="server"></asp:HyperLink>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
