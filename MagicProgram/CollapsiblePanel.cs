using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MagicProgram
{
    [Designer(typeof(CollapsiblePanelDesigner)), DefaultEvent("CollapsedChanged")]
    public partial class CollapsiblePanel : UserControl
    {
        # region declarations
        # region Collapse Direction
        public enum CollapseDirection
        {
            None,
            Up,
            Right,
            Down,
            Left,
            All
        };

        [Browsable(true), DefaultValue("All"), Description("Direction panel collapses. 0-none, 1-up, 2-right, 3-down, 4-left, 5-all")]
        [ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
        private CollapseDirection _direction = CollapseDirection.All;
        public CollapseDirection Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
                callCollapseDirectionChanged();
                setPadding();
            }
        }

        public event Action CollapseDirectionChanged;
        protected void callCollapseDirectionChanged()
        {
            Action handler = CollapseDirectionChanged;
            DisplayButtons();
            if (handler != null)
            {
                handler();
            }
        }
        # endregion

        # region Collapsed
        [DefaultValue(false)]
        private bool _collapsed = false;
        public bool Collapsed
        {
            get { return _collapsed; }
            set
            {
                _collapsed = value;
                callCollapsedChanged();
                panel1.BringToFront();
            }
        }

        public event Action CollapsedChanged;
        protected void callCollapsedChanged()
        {
            Action handler = CollapsedChanged;
            CollapseChange();
            if (handler != null)
            {
                handler();
            }
        }
        # endregion

        # region original size
        private Size originalSize = new Size();
        private Size smallSize = new Size();
        public Size sizeDiff
        {
            get
            {
                Size result = new Size();

                result.Width = originalSize.Width - smallSize.Width;
                result.Height = originalSize.Height - smallSize.Height;

                return result;
            }
        }
        # endregion

        # region HoverEdges
        [DefaultValue(true)]
        private bool _hoverEdges = true;
        public bool HoverEdges
        {
            get { return _hoverEdges; }
            set { _hoverEdges = value; }
        }
        # endregion

        # region set working area
        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel WorkingArea
        {
            get { return panel1; }
        }
        # endregion
        # endregion

        public CollapsiblePanel()
        {
            InitializeComponent();
            originalSize = Size;
            buttonUp.BringToFront();
            buttonRight.BringToFront();
            buttonDown.BringToFront();
            buttonLeft.BringToFront();
        }

        private void DisplayButtons()
        {
            switch (_direction)
            {
                case CollapseDirection.None:
                    buttonDown.Visible = false;
                    buttonUp.Visible = false;
                    buttonRight.Visible = false;
                    buttonLeft.Visible = false;
                    break;

                case CollapseDirection.Up:
                    buttonDown.Visible = false;
                    buttonUp.Visible = true;
                    buttonRight.Visible = false;
                    buttonLeft.Visible = false;
                    break;

                case CollapseDirection.Right:
                    buttonDown.Visible = false;
                    buttonUp.Visible = false;
                    buttonRight.Visible = true;
                    buttonLeft.Visible = false;
                    break;

                case CollapseDirection.Down:
                    buttonDown.Visible = true;
                    buttonUp.Visible = false;
                    buttonRight.Visible = false;
                    buttonLeft.Visible = false;
                    break;

                case CollapseDirection.Left:
                    buttonDown.Visible = false;
                    buttonUp.Visible = false;
                    buttonRight.Visible = false;
                    buttonLeft.Visible = true;
                    break;

                case CollapseDirection.All:
                    buttonDown.Visible = true;
                    buttonUp.Visible = true;
                    buttonRight.Visible = true;
                    buttonLeft.Visible = true;
                    break;
            }
            panel1.Show();
        }

        private void setPadding()
        {
            if (Collapsed || (HoverEdges && !Collapsed))
            {
                panel1.Padding = new Padding(0);
            }
            else
            {
                switch (_direction)
                {
                    case CollapseDirection.None:
                        panel1.Padding = new Padding(0);
                        break;

                    case CollapseDirection.Up:
                        panel1.Padding = new Padding(0, 23, 0, 0);
                        break;

                    case CollapseDirection.Right:
                        panel1.Padding = new Padding(0, 0, 23, 0);
                        break;

                    case CollapseDirection.Down:
                        panel1.Padding = new Padding(0, 0, 0, 23);
                        break;

                    case CollapseDirection.Left:
                        panel1.Padding = new Padding(23, 0, 0, 0);
                        break;

                    case CollapseDirection.All:
                        panel1.Padding = new Padding(23);
                        break;
                }
            }
        }

        private void buttonCollapse(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;
        }

        private void CollapseChange()
        {
            Size s = MinimumSize;
            foreach (Control c in Controls)
            {
                if (c.Name != "buttonDown" && c.Name != "buttonLeft" && c.Name != "buttonRight" && c.Name != "buttonUp")
                {
                    c.Visible = !Collapsed;
                }
                if (c.Visible)
                {
                    string n = c.Name;
                    if (c.Width > s.Width) { s.Width = c.Width; }
                    if (c.Height > s.Height) { s.Height = c.Height; }
                }
            }
            if (!Collapsed) //Expanding
            {
                //Debug.WriteLine("{0} is expanding.", Name);
                Size = originalSize;
                //this.Dock = style;
            }
            else //Collapsing
            {
                //Debug.WriteLine("{0} is collapsing.", Name);
                Size = s;
                //style = this.Dock;
                //this.Dock = DockStyle.None;
            }

            DisplayButtons();
        }

        private void CollapsiblePanel_Resize(object sender, EventArgs e)
        {
            if (!Collapsed)
            {
                originalSize = Size;
            }
            else
            {
                smallSize = Size;
            }
        }

        private void CollapsiblePanel_Leave(object sender, EventArgs e)
        {
            //doesn't get called.
            if (Collapsed)
            {
                DisplayButtons();
                return;
            }

            bool contained = false;

            # region
            switch (_direction)
            {
                case CollapseDirection.All:
                    if (checkContained(buttonUp)
                        || checkContained(buttonDown)
                        || checkContained(buttonRight)
                        || checkContained(buttonLeft))
                    {
                        DisplayButtons();
                        contained = true;
                    }
                    break;

                case CollapseDirection.Up:
                    if (checkContained(buttonUp))
                    {
                        buttonUp.Show();
                        contained = true;
                    }
                    break;

                case CollapseDirection.Right:
                    if (checkContained(buttonRight))
                    {
                        buttonRight.Show();
                        contained = true;
                    }
                    break;

                case CollapseDirection.Down:
                    if (checkContained(buttonDown))
                    {
                        buttonDown.Show();
                        contained = true;
                    }
                    break;

                case CollapseDirection.Left:
                    if (checkContained(buttonLeft))
                    {
                        buttonLeft.Show();
                        contained = true;
                    }
                    break;
            }
            # endregion

            if (!contained)
            {
                buttonLeft.Visible = false;
                buttonUp.Visible = false;
                buttonRight.Visible = false;
                buttonDown.Visible = false;
            }
        }

        private bool checkContained(Control c)
        {
            bool result = false;
            Point pos = PointToScreen(c.Location);
            Rectangle rect = new Rectangle(pos, c.Size);

            result = rect.Contains(MousePosition);

            return result;
        }

        private void Child_Leave(object sender, EventArgs e)
        {
            //CollapsiblePanel_Leave(this, e);
        }

        private void CollapsiblePanel_Enter(object sender, EventArgs e)
        {
            //DisplayButtons();
        }

        private void CollapsiblePanel_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine(Name);
            //Debug.Indent();
            //if (HoverEdges)
            //{
            //    foreach (Control c in panel1.Controls)
            //    {
            //        //Debug.WriteLine(c.Name);
            //        //Debug.Indent();
            //        foreach (Control cc in c.Controls)
            //        {
            //            //Debug.WriteLine(cc.Name);
            //        }
            //        //Debug.Unindent();
            //    }
            //}
            //Debug.Unindent();
        }
    }

    public class CollapsiblePanelDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            if (this.Control is CollapsiblePanel)
            {
                CollapsiblePanel cp = this.Control as CollapsiblePanel;
                this.EnableDesignMode(cp.WorkingArea, "Working Area");
            }
        }
    }
}
