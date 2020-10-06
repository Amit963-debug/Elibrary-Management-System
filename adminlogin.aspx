<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="ELibraryManagement.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <Center>
                                   <img width="150px" src="imgs/adminuser.png" />
                                </Center>
                               </div>
                              </div>
                        <div class="row">
                            <div class="col">
                                <Center>
                               <h3>Admin Login</h3>
                                </Center>
                                  </div>
                               </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                                  </div>
                               </div>
                        <div class="row">
                            <div class="col">
                                
                                <div class="form-group">
                                    
                                    
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder=" Email ID"></asp:TextBox>
                                </div>
                                
                                <div class="form-group">
                                    
                                    
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button Class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

                                </div>
                                
                            </div>
                        </div>

                           </div>


            </div>
                <a href="Homepage.aspx"><<  Back to Home</a><br><br>
                 

        </div>


    </div>
</asp:Content>
