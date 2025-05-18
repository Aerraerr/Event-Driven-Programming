using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public class ValentinesAnimation : Form
{
    private Timer timer;
    private float t = 0;

    public ValentinesAnimation()
    {
        this.Text = "Happy Valentine's Day";
        this.Size = new Size(600, 400);
        this.DoubleBuffered = true;
        this.BackColor = Color.Pink;

        timer = new Timer();
        timer.Interval = 50;
        timer.Tick += (s, e) => { t += 0.1f; this.Invalidate(); };
        timer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        Pen pen = new Pen(Color.Red, 3);
        DrawHeart(g, pen, 200 + (float)(10 * Math.Sin(t)), 150, 40);
        DrawHeart(g, pen, 300 + (float)(10 * Math.Cos(t)), 150, 40);

        Font font = new Font("Arial", 20, FontStyle.Bold);
        g.DrawString("Happy Valentine's Day", font, Brushes.Red, 180, 250);
    }

    private void DrawHeart(Graphics g, Pen pen, float x, float y, float size)
    {
        PointF[] heartPoints = new PointF[100];
        for (int i = 0; i < 100; i++)
        {
            float angle = i * (float)(Math.PI * 2 / 100);
            float px = (float)(16 * Math.Pow(Math.Sin(angle), 3)) * size / 16 + x;
            float py = (float)(-(13 * Math.Cos(angle) - 5 * Math.Cos(2 * angle) - 2 * Math.Cos(3 * angle) - Math.Cos(4 * angle))) * size / 16 + y;
            heartPoints[i] = new PointF(px, py);
        }
        g.DrawCurve(pen, heartPoints);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new ValentinesAnimation());
    }
}
