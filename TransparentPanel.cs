using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, 0, 0, 0))) // Semi-transparent black
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
