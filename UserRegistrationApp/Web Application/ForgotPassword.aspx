<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Application_Layer.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
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
            width: 300px;
            height: 385px;
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
            width: 250px;
            height: 25px;
        }

        .labels {
            height: 30px;
            font-size: large;
            font-weight: bold;
        }

        .inputs {
            width: 250px;
            height: 30px;
            border-radius: 2px;
            border: 1px black solid;
        }

        .button {
            margin-top: 40px;
        }

        .submit {
            cursor: pointer;
            width: 250px;
            height: 40px;
            font-size: x-large;
            font-weight: bold;
            border: 2px solid black;
            border-radius: 7px;
        }

            .submit:hover {
                background-color: forestgreen;
            }
    </style>
</head>
<body>
    <div id="container">
        <div class="card">
            <h2>Forgot Password</h2>
            <form id="form1" runat="server">
                <div class="form">
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label1" CssClass="labels" runat="server">UserName :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="username" runat="server" class="inputs" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label2" CssClass="labels" runat="server">Password :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="password" TextMode="Password" class="inputs" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="box">
                        <div class="label">
                            <asp:Label ID="label3" CssClass="labels" runat="server">Confirm Password :</asp:Label>
                        </div>
                        <div class="input">
                            <asp:TextBox ID="confirmPassword" TextMode="Password" class="inputs" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="button">
                    <asp:Button runat="server" CssClass="submit" Text="Submit" OnClick="ForgotPassword_Click" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>

