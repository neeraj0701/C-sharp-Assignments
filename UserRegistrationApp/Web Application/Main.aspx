<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Application_Layer.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
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
            height: 120px;
            background-color: white;
            display: flex;
            align-items: center;
            flex-direction: column;
            border-radius: 15px;
        }

        h2 {
            text-align: center;
            margin: 10px;
        }

        .button {
            margin-top: 10px;
        }

        .submit {
            cursor: pointer;
            width: 150px;
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
            <h2>Welcome to Main Page</h2>
            <form id="form1" runat="server">
                <div class="button">
                    <asp:Button OnClick="Logout_Click" CssClass="submit" runat="server" Text="Logout" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
