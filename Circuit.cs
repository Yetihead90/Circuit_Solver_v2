using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuit_Solver_v2
{
    internal class Circuit
    {
        private int yCount0 = 0;
        private int yCount1 = 0;
        public Circuit(int[,] names, Form1 f, string tagName, int FormWidth, int buttonY, Size buttonSize, Size subMenuSize) {
            f.Width = FormWidth;
            for (int i = 0; i < names.GetLength(1); i++)
            {
                string sValueName = GetEnumValueText(names, i);
                string sMetricName = GetEnumMetricText(names, i);
                f.SetTextBoxesCircuits(yCount0, yCount1, i, names, tagName, sValueName);
                f.SetLabelValuesCircuits(yCount0, yCount1, i, names, tagName, sValueName);
                f.SetLabelMetricsCircuits(yCount0, yCount1, i, names, tagName, sMetricName);
                yCount0 += (names[2, i] == 0) ? 1 : 0;
                yCount1 += (names[2, i] == 1) ? 1 : 0;
            }
            f.SetButtonsCircuits(buttonSize, tagName, buttonY, subMenuSize);
        }
        private string GetEnumValueText(int[,] names, int i)
        {
            return Enum.GetName(typeof(ValueName), names[0, i]);
        }
        private string GetEnumMetricText(int[,] names, int i)
        {
            return Enum.GetName(typeof(MetricName), names[1, i]);
        }
        public enum ValueName
        {
            RT,
            R1,
            R2,
            R3,
            R4,
            IT,
            IR1,
            IR2,
            IR3,
            IR4,
            VS,
            VR1,
            VR2,
            VR3,
            VR4,
            PT,
            PR1,
            PR2,
            PR3,
            PR4
        }

        private enum MetricName 
        { 
            V,
            A,
            mA,
            Ω,
            W,
            mW
        }

    }
}
