using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    interface IMatrixDef
    {
        int[,] EnterMatrix(int rows, int cols, string msg);
        void AddMatrix(int rows, int cols, int[,] aMatrix, int[,] bMatrix);
    }
}
