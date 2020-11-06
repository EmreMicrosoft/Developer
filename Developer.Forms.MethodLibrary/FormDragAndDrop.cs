using System.Drawing;
using System.Windows.Forms;

namespace Developer.Forms.MethodLibrary
{
    public partial class FormDragAndDrop : Form
    {
        public FormDragAndDrop()
        {
            InitializeComponent();
        }

        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void FormDragAndDrop_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }
        private void FormDragAndDrop_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }
        private void FormDragAndDrop_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}