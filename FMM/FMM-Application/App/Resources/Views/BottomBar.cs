using FMM_Application.App.Resources.Values.Colors;
using System.Drawing;
using System.Windows.Forms;

namespace FMM_Application.App.Resources.Views
{
    public class BottomBar: Panel
    {

        public BottomBar(string title)
        {
            BackColor = MyColor.secondary_color;

            Controls.Add(buildTitle(title));

            Dock = DockStyle.Bottom;
            Padding = new Padding(0, 0, 24, 0);

            Size = new Size(250, 40);
            RightToLeft = RightToLeft.Yes;
        }

        private Label buildTitle(string title)
        {
            Label titleLabel = new Label();

            titleLabel.Dock = DockStyle.Fill;

            titleLabel.FlatStyle = FlatStyle.Flat;
            titleLabel.ForeColor = Color.Silver;
            titleLabel.Font = new Font(this.Font, FontStyle.Bold);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Size = new Size(250, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = title;
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;

            return titleLabel;
        }

    }
}
