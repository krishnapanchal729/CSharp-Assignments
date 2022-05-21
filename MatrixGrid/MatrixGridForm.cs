using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixGrid
{
    public partial class MatrixGridForm : Form
    {
        public int m_width;       // Width of the grid cell
        public int m_Height;      // The height of the cell
        public int m_NoOfRows;    // The Number of Rows
        public int m_NoOfCols;    // The Number of Columns

        public int m_XOffset;     //Offset from which drawing start
        public int m_YOffset;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 3;
        public const int DEFAULT_NO_COLS = 3;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;

        public MatrixGridForm()
        {
            Initialize();
            InitializeComponent();
        }

        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid();
        }

        public void Initialize()
        {
            //Put all the default values
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;

        }

        private void DrawGrid()
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen LayoutPen = new Pen(Color.Purple);
            LayoutPen.Width = 3;

            //boardLayout.DrawLine(layoutPen, 0, 0, 100, 0);
            int X = DEFAULT_X_OFFSET;
            int Y = DEFAULT_Y_OFFSET;

            //Drawing Rows
            for(int i = 0; i <= m_NoOfRows; i++)
            {
                boardLayout.DrawLine(LayoutPen, X, Y, X + this.m_width * this.m_NoOfCols, Y);
                Y = Y + m_Height;
            }

            //Drawing Cols
            X = DEFAULT_X_OFFSET;
            Y = DEFAULT_Y_OFFSET;
            for(int j = 0; j <= m_NoOfCols; j++)
            {
                boardLayout.DrawLine(LayoutPen, X, Y, X, Y + this.m_Height * this.m_NoOfRows);
                X = X + this.m_width;
            }

        }

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH / 2;
            m_Height = DEFAULT_HEIGHT / 2;
            this.Refresh();
        }

        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            this.Refresh(); //Call OnPaint
        }

        private void toolStripMenuItem150_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH * 2;
            m_Height = DEFAULT_HEIGHT * 2;
            this.Refresh(); //Call OnPaint
        } 

        private void toolStripMenuItem200_Click(object sender, EventArgs e)
        {
            m_width = DEFAULT_WIDTH * 3;
            m_Height = DEFAULT_HEIGHT * 3;
            this.Refresh(); //Call OnPaint
        }
    }
}
