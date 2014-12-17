using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    public class MatrixEntity
    {
        private int _rows;
        private int _cols;
        int[,] _matrix;

        public int[,] Matrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }

        public int Rows
        {
            get { return _rows; }
            set { _rows = value; }
        }

        public int Cols
        {
            get { return _cols; }
            set { _cols = value; }
        }


    }
}
