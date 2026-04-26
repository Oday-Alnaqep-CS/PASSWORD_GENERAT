using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public static class CinematicUI
{
    // ÇÓÊíÑÇÏ ãßÊÈÇÊ ÇáäÙÇã áÚãá ÇáÍæÇÝ ÇáÏÇÆÑíÉ æÇáÊÍÑíß
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    public static void ApplyCinematicStyle(Form form)
    {
        // 1. ÅÚÏÇÏÇÊ ÇáÝæÑã ÇáÃÓÇÓíÉ
        form.FormBorderStyle = FormBorderStyle.None;
        form.BackColor = Color.FromArgb(15, 25, 35);
        form.Opacity = 0.95;

        // ÊØÈíÞ ÇáÍæÇÝ ÇáÏÇÆÑíÉ ááÝæÑã
        form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 30, 30));

        // 2. ÊØÈíÞ ÇáÊäÓíÞ Úáì ÌãíÚ ÇáÃÏæÇÊ
        ProcessAllControls(form.Controls, form);
    }

    private static void ProcessAllControls(Control.ControlCollection controls, Form form)
    {
        foreach (Control ctrl in controls)
        {
            // ááÏÎæá ÏÇÎá ÇáÍÇæíÇÊ ãËá ÇáÜ GroupBox æÊäÓíÞ ãÇ ÈÏÇÎáåÇ
            if (ctrl.HasChildren) ProcessAllControls(ctrl.Controls, form);

            // ÊäÓíÞ ÇáÃÒÑÇÑ
            if (ctrl is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.Cursor = Cursors.Hand;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                if (btn.Text.ToLower().Contains("generate"))
                {
                    btn.ForeColor = Color.Cyan;
                    btn.FlatAppearance.BorderColor = Color.Cyan;
                }
                else if (btn.Text.ToLower().Contains("reset"))
                {
                    btn.ForeColor = Color.Crimson;
                    btn.FlatAppearance.BorderColor = Color.Crimson;
                }
                else
                {
                    btn.ForeColor = Color.White; // ÌÚá áæä ÇáÎØ ÃÈíÖ
                    btn.FlatAppearance.BorderColor = Color.DimGray;
                }
            }

            // ÊäÓíÞ ÇáäÕæÕ (Labels) - ÌÚá Çáßá ÃÈíÖ
            if (ctrl is Label lbl)
            {
                lbl.ForeColor = Color.White;
                if (lbl.Tag?.ToString() == "Header")
                {
                    lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                }
            }

            // ÊäÓíÞ ÇáÜ CheckBox - ÌÚá Çáßá ÃÈíÖ
            if (ctrl is CheckBox chk)
            {
                chk.ForeColor = Color.White;
                chk.Cursor = Cursors.Hand;
            }

            // ÊäÓíÞ ÕäÇÏíÞ ÇáäÕæÕ
            if (ctrl is TextBox || ctrl is RichTextBox)
            {
                ctrl.BackColor = Color.FromArgb(30, 40, 50);
           //     ctrl.BorderStyle = BorderStyle.None;
                ctrl.ForeColor = Color.White;
                ctrl.Font = new Font("Consolas", 14);
            }

            // ÊäÓíÞ ÇáÜ GroupBox
            if (ctrl is GroupBox gb)
            {
                gb.ForeColor = Color.Cyan;
                gb.Paint += (s, e) => {
                    e.Graphics.Clear(form.BackColor);
                    using (Pen pen = new Pen(Color.FromArgb(50, 255, 255, 255), 1))
                    {
                        DrawRoundedRectangle(e.Graphics, pen, 0, 10, gb.Width - 1, gb.Height - 11, 10);
                    }
                    e.Graphics.DrawString(gb.Text, gb.Font, Brushes.Cyan, 10, 0);
                };
            }
        }
    }

    private static void DrawRoundedRectangle(Graphics graphics, Pen pen, int x, int y, int width, int height, int cornerRadius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(x, y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(x + width - cornerRadius * 2, y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(x + width - cornerRadius * 2, y + height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(x, y + height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseAllFigures();
            graphics.DrawPath(pen, path);
        }
    }
}