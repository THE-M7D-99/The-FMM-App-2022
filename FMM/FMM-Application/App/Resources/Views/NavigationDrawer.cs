using FMM_Application.App.Resources.Values.Colors;
using FMM_Application.App.Resources.Values.Fonts;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FMM_Application.App.Resources.Views
{
    public class NavigationDrawer: Panel
    {
        public class NavigationDrawerItem
        {
            public string title;
            public IconChar icon;
            public Form childForm;

            public NavigationDrawerItem(
                string title,
                IconChar icon,
                Form childForm
                )
            {
                this.title = title;
                this.icon = icon;
                this.childForm = childForm;
            }

        }

        public class NavigationDrawerLogo
        {
            public string title;
            public IconChar logoIcon;

            public NavigationDrawerLogo(
                string title,
                IconChar logoIcon
                )
            {
                this.title = title;
                this.logoIcon = logoIcon;
            }
        }

        public class NavigationDrawerAccount
        {
            public string title;
            public IconChar accountIcon;

            public NavigationDrawerAccount(
                string title,
                IconChar accountIcon
                )
            {
                this.title = title;
                this.accountIcon = accountIcon;
            }
        }


        public NavigationDrawer()
        {
            BackColor = MyColor.primary_color;

            buildCenter(null, null);
            buildTop(null);
            buildBottom(null);

            Dock = DockStyle.Left;
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Size = new Size(250, 561);
            TabIndex = 1;
        }

        public NavigationDrawer(
            NavigationDrawerLogo logo,
            List<NavigationDrawerItem> items,
            NavigationDrawerAccount account,
            Panel childPanel
            )
        {
            BackColor = MyColor.primary_color;

            Controls.Add(buildCenter(items, childPanel));
            Controls.Add(buildTop(logo));
            Controls.Add(buildBottom(account));

            Dock = DockStyle.Right;
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Size = new Size(250, 561);
            TabIndex = 1;
        }

        public Panel build()
        {
            return this;
        }


        private Panel buildTop(NavigationDrawerLogo logo)
        {
            Panel topPanel = new Panel();

            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = MyColor.primary_color;


            IconButton ibtnLogo = new IconButton();

            ibtnLogo.Dock = DockStyle.Fill;
            ibtnLogo.FlatAppearance.BorderSize = 0;

            ibtnLogo.FlatStyle = FlatStyle.Flat;
            ibtnLogo.ForeColor = Color.Silver;
            ibtnLogo.Font = MyFont.medium;
            ibtnLogo.Location = new Point(0, 0);
            ibtnLogo.Padding = new Padding(24, 0, 24, 0);
            ibtnLogo.TabIndex = 0;
            ibtnLogo.TextAlign = ContentAlignment.MiddleLeft;
            ibtnLogo.ImageAlign = ContentAlignment.MiddleLeft;

            if (logo != null)
            {
                ibtnLogo.Text = logo.title;
                ibtnLogo.IconChar = logo.logoIcon;
            }

            ibtnLogo.IconColor = Color.Silver;
            ibtnLogo.IconSize = 40;
            ibtnLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnLogo.UseVisualStyleBackColor = true;

            topPanel.RightToLeft = RightToLeft.Yes;
            topPanel.Controls.Add(ibtnLogo);

            return topPanel;
        }


        private Panel buildBottom(NavigationDrawerAccount account)
        {
            Panel bottomPanel = new Panel();

            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.BackColor = MyColor.primary_color;

            bottomPanel.Size = new Size(250, 100);
            bottomPanel.TabIndex = 0;

            IconButton ibtnAccount = new IconButton();

            ibtnAccount.Dock = DockStyle.Fill;
            ibtnAccount.FlatAppearance.BorderSize = 0;
            ibtnAccount.FlatStyle = FlatStyle.Flat;
            ibtnAccount.ForeColor = Color.Silver;
            ibtnAccount.Font = MyFont.medium;
            ibtnAccount.Location = new Point(0, 0);
            ibtnAccount.Padding = new Padding(24, 0, 24, 0);
            ibtnAccount.TextAlign = ContentAlignment.MiddleLeft;
            ibtnAccount.ImageAlign = ContentAlignment.MiddleLeft;

            if (account != null)
            {
                ibtnAccount.Text = account.title;
                ibtnAccount.IconChar = account.accountIcon;
            }

            ibtnAccount.TextAlign = ContentAlignment.MiddleLeft;
            ibtnAccount.IconColor = Color.Silver;
            ibtnAccount.IconSize = 35;
            ibtnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnAccount.UseVisualStyleBackColor = true;

            bottomPanel.RightToLeft = RightToLeft.Yes;
            bottomPanel.Controls.Add(ibtnAccount);

            return bottomPanel;
        }



        private Panel buildCenter(List<NavigationDrawerItem> items, Panel childPanel)
        {
            Panel centerPanel = new Panel();

            centerPanel.AutoScroll = true;
          
            centerPanel.BackColor = MyColor.secondary_color;

            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 140);
            centerPanel.Name = "panel1";
            centerPanel.Size = new Size(250, 165);
            centerPanel.TabIndex = 3;
            centerPanel.RightToLeft = RightToLeft.Yes;


            if (items != null)
            {
                items.ForEach(item =>
                {
                    if (childPanel != null)
                    {
                        centerPanel.Controls.Add(new Item(item, childPanel));
                    }
                });
            }

            return centerPanel;
        }


        private class Item : IconButton
        {
            public Item(
                NavigationDrawerItem navigationDrawerItem,
                Panel childPanel
                )
            {
                Dock = DockStyle.Top;
                FlatAppearance.BorderSize = 0;

                FlatAppearance.MouseDownBackColor = MyColor.primary_color;
                FlatAppearance.MouseOverBackColor = MyColor.secondary_back_color;

                FlatStyle = FlatStyle.Flat;
                ForeColor = Color.Silver;
                Font = MyFont.small;
                Location = new Point(0, 0);
                Padding = new Padding(12, 0, 0, 0);
                Size = new Size(250, 56);
                TabIndex = 0;
                Text = navigationDrawerItem.title;
                TextAlign = ContentAlignment.MiddleLeft;
                ImageAlign = ContentAlignment.MiddleLeft;
                IconChar = navigationDrawerItem.icon;
                IconColor = Color.Silver;
                IconSize = 35;
                TextImageRelation = TextImageRelation.ImageBeforeText;
                RightToLeft = RightToLeft.Yes;
                UseVisualStyleBackColor = true;

                Click += (s, e) => {
                    try
                    {
                        navigationDrawerItem.childForm.TopLevel = false;
                        navigationDrawerItem.childForm.FormBorderStyle = FormBorderStyle.None;
                        navigationDrawerItem.childForm.Dock = DockStyle.Fill;

                        childPanel.Controls.Add(navigationDrawerItem.childForm);
                        childPanel.Tag = navigationDrawerItem.childForm;
                        navigationDrawerItem.childForm.BringToFront();
                        navigationDrawerItem.childForm.Show();
                    }
                    catch (Exception ex)
                    {
                        Text = ex.Message.ToString();
                    }
                };
            }

        }

    }
}
