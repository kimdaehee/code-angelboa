using System;
using System.Drawing;
using System.Windows.Forms;
using Client.MirGraphics;

namespace Client.MirControls
{
    public enum MirMessageBoxButtons1 { OK, OKCancel, YesNo, YesNoCancel, Cancel }

    public sealed class MirMessageBox1 : MirImageControl
    {
        public MirLabel Label;
        public MirButton OKButton, CancelButton, NoButton, YesButton;
        public MirMessageBoxButtons1 Buttons;


        public MirMessageBox1(string message, MirMessageBoxButtons1 b = MirMessageBoxButtons1.OK)
        {
            DrawImage = true;
            ForeColour = Color.White;
            Buttons = b;
            Modal = true;
            Movable = false;

            Index = 990;
            Library = Libraries.Prguse;

            Location = new Point((Settings.ScreenWidth - Size.Width) / 2, (Settings.ScreenHeight - Size.Height) / 2);


            Label = new MirLabel
            {
                AutoSize = false,
               // DrawFormat = StringFormatFlags.FitBlackBox,
                Location = new Point(35-20, 35-16),
                Size = new Size(390, 110),
                Parent = this,
                Text = message
            };

            
            switch (Buttons)
            {
                case MirMessageBoxButtons1.OK:
                    OKButton = new MirButton
                    {
                        HoverIndex = 201,
                        Index = 200,
                        Library = Libraries.Title,
                        Location = new Point(340, 157),
                        Parent = this,
                        PressedIndex = 202,
                    };
                    OKButton.Click += (o, e) => Dispose();
                    break;
                case MirMessageBoxButtons1.OKCancel:
                    OKButton = new MirButton
                    {
                        HoverIndex = 201,
                        Index = 200,
                        Library = Libraries.Title,
                        Location = new Point(250, 157),
                        Parent = this,
                        PressedIndex = 202,
                    };
                    OKButton.Click += (o, e) => Dispose();
                    CancelButton = new MirButton
                    {
                        HoverIndex = 204,
                        Index = 203,
                        Library = Libraries.Title,
                        Location = new Point(340, 157),
                        Parent = this,
                        PressedIndex = 205,
                    };
                    CancelButton.Click += (o, e) => Dispose();
                    break;
                case MirMessageBoxButtons1.YesNo: // 116
                    YesButton = new MirButton
                    {
                        HoverIndex = 117,
                        Index = 116,
                        Library = Libraries.Title,
                        Location = new Point(250 - 30 - 50-15, 157 - 50 - 15+4),
                        Parent = this,
                        PressedIndex = 118,
                    };
                    YesButton.Click += (o, e) => Dispose();
                    NoButton = new MirButton
                    {
                        HoverIndex = 184,
                        Index = 183,
                        Library = Libraries.Title,
                        Location = new Point(340 - 30-50-25-10, 157 - 50-15+4),
                        Parent = this,
                        PressedIndex = 185,
                    };
                    NoButton.Click += (o, e) => Dispose();
                    break;
                case MirMessageBoxButtons1.YesNoCancel:
                    YesButton = new MirButton
                    {
                        HoverIndex = 207,
                        Index = 206,
                        Library = Libraries.Title,
                        Location = new Point(160, 157),
                        Parent = this,
                        PressedIndex = 208,
                    };
                    YesButton.Click += (o, e) => Dispose();
                    NoButton = new MirButton
                    {
                        HoverIndex = 211,
                        Index = 210,
                        Library = Libraries.Title,
                        Location = new Point(250, 157),
                        Parent = this,
                        PressedIndex = 212,
                    };
                    NoButton.Click += (o, e) => Dispose();
                    CancelButton = new MirButton
                    {
                        HoverIndex = 204,
                        Index = 203,
                        Library = Libraries.Title,
                        Location = new Point(340, 157),
                        Parent = this,
                        PressedIndex = 205,
                    };
                    CancelButton.Click += (o, e) => Dispose();
                    break;
                case MirMessageBoxButtons1.Cancel:
                    CancelButton = new MirButton
                    {
                        HoverIndex = 204,
                        Index = 203,
                        Library = Libraries.Title,
                        Location = new Point(340, 157),
                        Parent = this,
                        PressedIndex = 205,
                    };
                    CancelButton.Click += (o, e) => Dispose();
                    break;
            }
        }

        public void Show()
        {
            if (Parent != null) return;

            Parent = MirScene.ActiveScene;

            Highlight();

            for (int i = 0; i < Program.Form.Controls.Count; i++)
            {
                TextBox T = Program.Form.Controls[i] as TextBox;
                if (T != null && T.Tag != null && T.Tag != null)
                    ((MirTextBox)T.Tag).DialogChanged();
            }
        }


        public override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            e.Handled = true;
        }
        public override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            e.Handled = true;
        }
        public override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Escape)
            {
                switch (Buttons)
                {
                    case MirMessageBoxButtons1.OK:
                        if (OKButton != null && !OKButton.IsDisposed) OKButton.InvokeMouseClick(null);
                        break;
                    case MirMessageBoxButtons1.OKCancel:
                    case MirMessageBoxButtons1.YesNoCancel:
                        if (CancelButton != null && !CancelButton.IsDisposed) CancelButton.InvokeMouseClick(null);
                        break;
                    case MirMessageBoxButtons1.YesNo:
                        if (NoButton != null && !NoButton.IsDisposed) NoButton.InvokeMouseClick(null);
                        break;
                }
            }

            else if (e.KeyChar == (char)Keys.Enter)
            {
                switch (Buttons)
                {
                    case MirMessageBoxButtons1.OK:
                    case MirMessageBoxButtons1.OKCancel:
                        if (OKButton != null && !OKButton.IsDisposed) OKButton.InvokeMouseClick(null);
                        break;
                    case MirMessageBoxButtons1.YesNoCancel:
                    case MirMessageBoxButtons1.YesNo:
                        if (YesButton != null && !YesButton.IsDisposed) YesButton.InvokeMouseClick(null);
                        break;

                }
            }
            e.Handled = true;
        }


        public static void Show(string message, bool close = false)
        {
            MirMessageBox box = new MirMessageBox(message);

            if (close) box.OKButton.Click += (o, e) => Program.Form.Close();

            box.Show();
        }

        #region Disposable

        protected override void Dispose(bool disposing)
        {

            base.Dispose(disposing);

            if (!disposing) return;

            Label = null;
            OKButton = null;
            CancelButton = null;
            NoButton = null;
            YesButton = null;
            Buttons = 0;

            for (int i = 0; i < Program.Form.Controls.Count; i++)
            {
                TextBox T = (TextBox) Program.Form.Controls[i];
                if (T != null && T.Tag != null)
                    ((MirTextBox) T.Tag).DialogChanged();
            }
        }

        #endregion
    }
}
