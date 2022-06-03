using FMM_Application.App.Resources.Values.Colors;
using FMM_Application.App.Resources.Views;
using FMM_Application.App.UIs.Permissions.EmployeesData;
using FMM_Application.App.UIs.Permissions.ApplicantsData;
using FMM_Application.App.UIs.Permissions.InsuranceData;
using FMM_Application.App.UIs.Permissions.SalariesData;
using FMM_Application.App.UIs.Permissions.RequestsAndSuggestionsData;
using FontAwesome.Sharp;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static FMM_Application.App.Resources.Views.NavigationDrawer;
using FMM_Application.App.UIs.Permissions.ExcuseRequestsData;

namespace FMM_Application
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;

            Panel p = new Panel();
            p.AutoScroll = true;
            p.BackColor = MyColor.primary_back_color;
            p.Dock = DockStyle.Fill;
            p.Location = new Point(0, 0);
            p.TabIndex = 1;

            NavigationDrawer nav = new NavigationDrawer(
                new NavigationDrawerLogo("اسم الشركة", IconChar.Adn),
                new List<NavigationDrawerItem>
                {
                    /*new NavigationDrawerItem("بيانات الموظفين", IconChar.Home, new EmployeesDataForm()),
                    new NavigationDrawerItem("بيانات التأمين", IconChar.Home, new InsuranceDataForm()),
                    new NavigationDrawerItem("بيانات المتقدمين", IconChar.Home, new ApplicantsDataForm()),
                    new NavigationDrawerItem("بيانات المرتبات و الأجور", IconChar.Home, new SalariesDataForm()),
                    new NavigationDrawerItem("بيانات طلبات الإعذار", IconChar.Home, new ExcuseRequestsDataForm()),
                    new NavigationDrawerItem("بيانات الطلبات و الاقتراحات", IconChar.Home, new RequestsAndSuggestionsDataForm())*/


                    new NavigationDrawerItem(title: "UI Title 1", icon: IconChar.HollyBerry, childForm: /*Your UI*/ new EmployeesDataForm()),
                    new NavigationDrawerItem(title: "UI Title 2", icon: IconChar.Home, childForm: /*Your UI*/ new InsuranceDataForm())


                },
                new NavigationDrawerAccount("معلومات الحساب", IconChar.PersonBooth),
                p
                );


            p.Margin = new Padding(50, 4, 3, 4);

            AppBar appBar = new AppBar("إدارة المصنع");
            appBar.ControlBox = true;


            mainPanel.Controls.Add(p);
            mainPanel.Controls.Add(nav.build());
            mainPanel.Controls.Add(appBar);
            mainPanel.Controls.Add(new BottomBar("..."));

            this.AutoScaleDimensions = new SizeF(7F, 16F);
          
            this.ClientSize = new Size(1920, 1040);
            Controls.Add(mainPanel);
            Dock = DockStyle.Fill;
         
            // 
            // Form1
            // 
            this.Font = new Font("Tahoma", 10F);
            this.Margin = new Padding(3, 4, 3, 4);
            this.MinimumSize = new Size(1000, 800);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
        }

        #endregion
    }
}

