using System;
using System.Drawing;
using System.Windows.Forms;

public class ComboSinBordes : ComboBox
{
    private const int WM_PAINT = 0xF;
    private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
    Color borderColor = Color.Blue;

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == WM_PAINT)
        {
            using (var g = Graphics.FromHwnd(Handle))
            {
                using (var pen = new Pen(borderColor))
                {
                    g.DrawRectangle(pen, 0, 0, Width - buttonWidth, Height - 1);
                }
            }
        }
    }
}
