using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarsier.UI {
    public class MessageListBox : ResizableListBox {
        private Color _titleColor = Color.DarkGray;
        [DefaultValue(typeof(Color), "DarkGray")]
        [Description("Header text color"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color HeaderColor {
            get { return _titleColor; }
            set { _titleColor = value; Invalidate(); }
        }

        private Color _dateColor = Color.LightGray;
        [DefaultValue(typeof(Color), "LightGray")]
        [Description("Details text color found in upper right side of an item"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color DateDetailsColor {
            get { return _dateColor; }
            set { _dateColor = value; Invalidate(); }
        }

        private Color _selectedColor = SystemColors.Highlight;
        [DefaultValue(typeof(Color), "Highlight")]
        [Description("Back color if item is selected"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color SelectedBackColor {
            get { return _selectedColor; }
            set { _selectedColor = value; Invalidate(); }
        }
        private Color _selectedTextColor = SystemColors.HighlightText;
        [DefaultValue(typeof(Color), "HighlightText")]
        [Description("Text color if item is selected"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color SelectedTextColor {
            get { return _selectedTextColor; }
            set { _selectedTextColor = value; Invalidate(); }
        }

        private Font m_HeadingFont = new Font("Calibri", 10F, FontStyle.Bold);
        [Description("Header text Font"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Font HeaderFont {
            get { return m_HeadingFont; }
            set { m_HeadingFont = value; Invalidate(); }
        }
      
        private Font m_DateFont = new Font("Calibri", 10F, FontStyle.Bold);
        [Description("Date details text Font"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Font DateFont {
            get { return m_DateFont; }
            set { m_DateFont = value; Invalidate(); }
        }

        private Color _separatorColor = Color.WhiteSmoke;
        [Description("Line separator color"), Category("Item Apperance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color SeparatorColor {
            get { return _separatorColor; }
            set { _separatorColor = value; Invalidate(); }
        }
       
        private const int m_MainTextOffset = 30;
        private ImageList IconList;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MessageListBox() {
            InitializeComponent();
            this.m_HeadingFont = new Font(this.Font, FontStyle.Bold);
            this.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MeasureItemHandler);
        }


        /// <summary>
        /// Windows-Init.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageListBox));
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "information-balloon.png");
            this.IconList.Images.SetKeyName(1, "exclamation.png");
            this.IconList.Images.SetKeyName(2, "exclamation-red.png");
            this.IconList.Images.SetKeyName(3, "tick-button.png");
            this.IconList.Images.SetKeyName(4, "inbox-upload.png");
            this.IconList.Images.SetKeyName(5, "blue-folder-broken.png");
            this.IconList.Images.SetKeyName(6, "briefcase.png");
            this.IconList.Images.SetKeyName(7, "folder--arrow.png");
            this.IconList.Images.SetKeyName(8, "blue-folder-open-document.png");
            this.IconList.Images.SetKeyName(9, "application-red.png");
            this.IconList.Images.SetKeyName(10, "flag-green.png");
            this.IconList.Images.SetKeyName(11, "lock-ssl.png");
            this.IconList.Images.SetKeyName(12, "preferences-desktop-accessibility.png");
            this.ResumeLayout(false);

        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null)
                    components.Dispose();
            }

            m_HeadingFont.Dispose();

            base.Dispose(disposing);
        }

        #region overrides
        protected override void OnDrawItem(DrawItemEventArgs e) {
            e.DrawBackground();
            e.DrawFocusRectangle();
            ParseMessageEventArgs item;
            Rectangle bounds = e.Bounds;
            Color TextColor = this.ForeColor; // System.Drawing.SystemColors.ControlText; //default text Color
            Brush titleBrush = new SolidBrush(_titleColor);
            Brush dateDetailsBrush = new SolidBrush(_dateColor);

            item = (ParseMessageEventArgs)Items[e.Index];

            // Get string measured sized from Date Details
            SizeF rightDetailsSize = new SizeF();
            rightDetailsSize = e.Graphics.MeasureString(item.DateDetails, m_DateFont);

            //draw selected item background
            if(e.State == DrawItemState.Selected) {
                using(Brush b = new SolidBrush(_selectedColor)) {
                    // Fill background;
                    e.Graphics.FillRectangle(b, e.Bounds);
                }
                TextColor = _selectedTextColor;
            } else {
                using(Brush b = new SolidBrush(this.BackColor)) {
                    // Fill background;
                    e.Graphics.FillRectangle(b, e.Bounds);
                }
            }

            //Pen separatorLine = new Pen(Color.Yellow, 5);
            //e.Graphics.DrawLine(separatorLine, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);
            // draw some item separator
            Pen separatorLine = new Pen(_separatorColor);
            e.Graphics.DrawLine(separatorLine, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);


            //draw image
            if(item.MessageType != ParseMessageType.None) {
                IconList.Draw(e.Graphics, bounds.Left + 1, bounds.Top + 2, (int)item.MessageType);
            }

            using(SolidBrush TextBrush = new SolidBrush(TextColor)) {
                //draw Headline
                e.Graphics.DrawString(
                    item.LineHeader,
                    m_HeadingFont,
                    titleBrush,
                    bounds.Left + IconList.ImageSize.Width + 5,
                    bounds.Top + IconList.ImageSize.Height - m_HeadingFont.Height);

                // let us try out new added date details item
                e.Graphics.DrawString(
                    item.DateDetails,
                    m_DateFont,
                    dateDetailsBrush,
                        (bounds.Width) - (rightDetailsSize.Width + 5), //add allowance of 5
                    bounds.Top + IconList.ImageSize.Height - m_HeadingFont.Height);

                //draw main text
                int LinesFilled = 0,
                    CharsFitted = 0,
                    top;

                // Draw layout, 2 times the offset (left & right)
                Size oneLine = new Size(this.Width - m_MainTextOffset * 2, this.Font.Height);

                StringBuilder sbTextToDraw = new StringBuilder(item.MessageText);
                string strLineToDraw;
                int index1 = 0,
                    index2, index2New;
                top = bounds.Top + IconList.ImageSize.Height + 2;

                while(sbTextToDraw.Length > 0) {
                    // Break string into more lines when an end-of-line character is found
                    if((index2 = sbTextToDraw.ToString().IndexOf('\n')) > 0) {
                        strLineToDraw = sbTextToDraw.ToString(index1, index2 - index1);
                        index2New = index2 + 1;
                    } else {
                        index2 = sbTextToDraw.Length;
                        index2New = index2;
                        strLineToDraw = sbTextToDraw.ToString();
                    }

                    e.Graphics.MeasureString(
                        strLineToDraw,
                        this.Font,
                        oneLine,
                        StringFormat.GenericDefault,
                        out CharsFitted,
                        out LinesFilled);

                    // There's no knowledge about words, so just don't split words up if possible
                    if(CharsFitted < index2) {
                        int index = strLineToDraw.LastIndexOf(' ', CharsFitted - 1, CharsFitted);
                        if(index != -1)
                            index2New = index + 1;
                        else
                            index2New = CharsFitted;
                        strLineToDraw = sbTextToDraw.ToString(index1, index2New - index1);
                    }

                    // Draw the text
                    e.Graphics.DrawString(
                        strLineToDraw,
                        this.Font,
                        TextBrush,
                        bounds.Left + m_MainTextOffset,
                        top);

                    // Adjust top
                    top += this.Font.Height;

                    // Next line
                    sbTextToDraw = sbTextToDraw.Remove(index1, index2New);
                }

                sbTextToDraw = null;
                strLineToDraw = null;
            }
        }


        private void MeasureItemHandler(object sender, MeasureItemEventArgs e) {
            int MainTextHeight;
            ParseMessageEventArgs item;
            item = (ParseMessageEventArgs)Items[e.Index];
            int LinesFilled, CharsFitted;

            // Draw layout, 2 times the offset (left & right)
            Size sz = new Size(this.Width - m_MainTextOffset * 2, this.Font.Height);

            StringBuilder sbTextToDraw = new StringBuilder(item.MessageText);
            string strLineToDraw;
            int index1 = 0,
                index2,
                index2New,
                lines = 0;

            while(sbTextToDraw.Length > 0) {
                // Break string into more lines when an end-of-line character is found
                if((index2 = sbTextToDraw.ToString().IndexOf('\n')) > 0) {
                    strLineToDraw = sbTextToDraw.ToString(index1, index2 - index1);
                    index2New = index2 + 1;
                } else {
                    index2 = sbTextToDraw.Length;
                    index2New = index2;
                    strLineToDraw = sbTextToDraw.ToString();
                }

                e.Graphics.MeasureString(
                    strLineToDraw,
                    this.Font,
                    sz,
                    StringFormat.GenericDefault,
                    out CharsFitted,
                    out LinesFilled);

                // There's no knowledge about words, so just don't split words up if possible
                if(CharsFitted < index2) {
                    int index = strLineToDraw.LastIndexOf(' ', CharsFitted - 1, CharsFitted);
                    if(index != -1)
                        index2New = index + 1;
                    else
                        index2New = CharsFitted;
                }

                lines += LinesFilled;
                sbTextToDraw = sbTextToDraw.Remove(index1, index2New);
            }

            sbTextToDraw = null;
            strLineToDraw = null;

            MainTextHeight = lines * this.Font.Height;

            e.ItemHeight = IconList.ImageSize.Height + MainTextHeight + 4;
            e.ItemWidth = sz.Width;
        }
        #endregion
    }
}
