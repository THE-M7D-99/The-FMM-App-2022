using FMM_Application.App.Resources.Values.Colors;
using FMM_Application.App.Resources.Values.Fonts;
using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace FMM_Application.App.Resources.Views
{
    public class AppBar: Panel
    {
        //init var...
        private Panel controlBox = null;
        private bool _controlBox;

        public bool ControlBox
        {
            get
            {
                return _controlBox;
            }
            set
            {
                if (value)
                {
                    controlBox.Visible = true;
                }
                else
                {
                    controlBox.Visible = false;
                }

                _controlBox = value;
            }
        }

        public AppBar(string title)
        {
            BackColor = MyColor.secondary_color;
            
            buildControlBox();

            Controls.Add(buildTitle(title));

            Dock = DockStyle.Top;
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);

            Size = new Size(250, 40);
            RightToLeft = RightToLeft.Yes;
        }

        private Label buildTitle(string title)
        {
            Label titleLabel = new Label();

            titleLabel.Dock = DockStyle.Fill;

            titleLabel.FlatStyle = FlatStyle.Flat;
            titleLabel.ForeColor = Color.Silver;
            titleLabel.Font = MyFont.small;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Padding = new Padding(0, 0, 24, 0);
            titleLabel.Size = new Size(250, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = title;
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;

            return titleLabel;
        }


        private void buildControlBox()
        {            
            controlBox = new Panel();

            controlBox.Dock = DockStyle.Left;
            controlBox.Padding = new Padding(24, 0, 0, 0);

            IconButton ibtnClose = new IconButton();

            ibtnClose.Dock = DockStyle.Left;

            ibtnClose.FlatAppearance.BorderSize = 0;
            ibtnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            ibtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));


            ibtnClose.FlatStyle = FlatStyle.Flat;
            ibtnClose.ForeColor = Color.Silver;
            ibtnClose.Font = new Font(this.Font, FontStyle.Bold);
            ibtnClose.Location = new Point(0, 0);

            ibtnClose.Size = new Size(40, 40);
            ibtnClose.TabIndex = 0;

            ibtnClose.IconChar = IconChar.Xbox;
            ibtnClose.IconColor = Color.Silver;
            ibtnClose.IconSize = 30;
            ibtnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnClose.UseVisualStyleBackColor = true;

            ibtnClose.Click += (s, e) =>
            {
                ((MainForm)Application.OpenForms["Form1"]).Close();
            };


            controlBox.Controls.Add(ibtnClose);

            Controls.Add(controlBox);
        }


        private Panel buildIconsPanel()
        {
            Panel iconsPanel = new Panel();

            iconsPanel.Dock = DockStyle.Right;
            iconsPanel.Padding = new Padding(0, 0, 20, 0);

            IconButton ibtnClose = new IconButton();

            ibtnClose.Dock = DockStyle.Right;

            ibtnClose.FlatAppearance.BorderSize = 0;
            ibtnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            ibtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));


            ibtnClose.FlatStyle = FlatStyle.Flat;
            ibtnClose.ForeColor = Color.Silver;
            ibtnClose.Font = new Font(this.Font, FontStyle.Bold);
            ibtnClose.Location = new Point(0, 0);

            ibtnClose.Size = new Size(40, 40);
            ibtnClose.TabIndex = 0;

            ibtnClose.IconChar = IconChar.Xbox;
            ibtnClose.IconColor = Color.Silver;
            ibtnClose.IconSize = 30;
            ibtnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnClose.UseVisualStyleBackColor = true;

            iconsPanel.Controls.Add(ibtnClose);

            return iconsPanel;
        }

    }
}
