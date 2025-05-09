using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADER.Personalizados
{
    internal class RoundedButton:Button
    {
        public int BorderRadius { get; set; } = 30;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            // Usa gráficos para borde redondeado
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = this.ClientRectangle;
            int radius = BorderRadius;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
            // Opcional: dibujar el borde si quieres definir color y grosor
            using (Pen pen = new Pen(Color.Black, 1))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawPath(pen, path);
            }
        }
    }
}
