using System;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel;


namespace DivU
{
    public partial class MainForm : Form
    {
        #region Feilds
        private const double d = 0.05;
        private NumberFormatInfo nfi;

        private readonly double[] E24 = new double[24]
        {
            1.0, 1.1, 1.2, 1.3, 1.5, 1.6, 1.8,
            2.0, 2.2, 2.4, 2.7,
            3.0, 3.3, 3.6, 3.9,
            4.3, 4.7,
            5.1, 5.6,
            6.2, 6.8,
            7.5,
            8.2,
            9.1
        };
        #endregion

        #region Ctors
        public MainForm()
        {
            InitializeComponent();

            nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
        }
        #endregion

        #region Utils
        private string PrefixFormat(double value, char dimension = '\0')
        {
            int prefix = 4;

            while (value < 1.0)
            {
                value *= 1000.0;
                prefix--;
            }

            while (value >= 1000.0)
            {
                value /= 1000.0;
                prefix++;
            }
            
            string result = value < 10.0 ? $"{value:f1}" : $"{value:f0}";
            if (prefix != 4)
            {
                result += "pnμm kMGTP".Substring(prefix, 1);
            }
            if (dimension != '\0')
            {
                result += dimension;
            }
            return result;
        }
        #endregion

        #region Handlers
        private void ValueKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox self = sender as TextBox;

            if (e.KeyChar == '.')
            {
                if (self.Text.IndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (char.IsDigit(e.KeyChar))
            {
                if (self.Text == "0")
                {
                    self.Text           = e.KeyChar.ToString();
                    self.SelectionStart = 1;
                    e.Handled           = true;
                }
            }
            else
            {
                e.Handled = e.KeyChar != '\b';
            }
        }

        private void ValueTextChanged(object sender, EventArgs e)
        {
            TextBox self = sender as TextBox;

            if (String.IsNullOrEmpty(self.Text))
            {
                self.Text           = "0";
                self.SelectionStart = 1;
            }
            else if (self.Text[0] == '.')
            {
                self.Text           = "0" + self.Text;
                self.SelectionStart = 1;
            }
        }

        private void CalculateClick(object sender, EventArgs e)
        {
            if (Uin.Checked)
            {
                double r2 = Convert.ToDouble(R2Value.Text, nfi);
                double r1 = r2 + Convert.ToDouble(R1Value.Text, nfi);

                if (r2 > 0)
                {
                    double u = Convert.ToDouble(UoutValue.Text, nfi);
                    UinValue.Text = (u * r1 / r2).ToString("F4", nfi);
                }
                else
                {
                    MessageBox.Show("R2 should be > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Uout.Checked)
            {
                double r2 = Convert.ToDouble(R2Value.Text, nfi);
                double r1 = r2 + Convert.ToDouble(R1Value.Text, nfi);

                if (r1 > 0)
                {
                    double u = Convert.ToDouble(UinValue.Text, nfi);
                    UoutValue.Text = (u * r2 / r1).ToString("F4", nfi);
                }
                else
                {
                    MessageBox.Show("R1 should be > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (R1.Checked)
            {
                double uo = Convert.ToDouble(UoutValue.Text, nfi);
                double du = Convert.ToDouble(UinValue.Text, nfi) - uo;

                if (du < 0)
                {
                    MessageBox.Show("Uin should be > Uout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (uo > 0)
                    {
                        double r2 = Convert.ToDouble(R2Value.Text, nfi);
                        R1Value.Text = (r2 * du / uo).ToString("F4", nfi);
                    }
                    else
                    {
                        MessageBox.Show("Uout should be > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (R2.Checked)
            {
                double uo = Convert.ToDouble(UoutValue.Text, nfi);
                double du = Convert.ToDouble(UinValue.Text, nfi) - uo;

                if (du > 0)
                {
                    double r1 = Convert.ToDouble(R1Value.Text, nfi);
                    R2Value.Text = (uo * r1 / du).ToString("F4", nfi);
                }
                else
                {
                    MessageBox.Show("Uout should be < Uin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void R1FStartSelectedIndexChanged(object sender, EventArgs e)
        {
            R1ValueBegin.Items.Clear();

            int factor = R1FactorBegin.SelectedIndex;

            for (int i = 0; i < 24; i++)
            {
                R1ValueBegin.Items.Add(PrefixFormat(E24[i] * Math.Pow(10.0, factor), 'Ω'));
            }

            R1ValueBegin.SelectedIndex = 0;
        }

        private void R1FStopSelectedIndexChanged(object sender, EventArgs e)
        {
            R1ValueEnd.Items.Clear();

            int factor = R1FactorEnd.SelectedIndex;

            for (int i = 0; i < 24; i++)
            {
                R1ValueEnd.Items.Add(PrefixFormat(E24[i] * Math.Pow(10.0, factor), 'Ω'));
            }

            R1ValueEnd.SelectedIndex = 23;
        }

        private void R2FStartSelectedIndexChanged(object sender, EventArgs e)
        {
            R2ValueBegin.Items.Clear();

            int factor = R2FactorBegin.SelectedIndex;

            for (int i = 0; i < 24; i++)
            {
                R2ValueBegin.Items.Add(PrefixFormat(E24[i] * Math.Pow(10.0, factor), 'Ω'));
            }

            R2ValueBegin.SelectedIndex = 0;
        }

        private void R2FStopSelectedIndexChanged(object sender, EventArgs e)
        {
            R2ValueEnd.Items.Clear();

            int factor = R2FactorEnd.SelectedIndex;

            for (int i = 0; i < 24; i++)
            {
                R2ValueEnd.Items.Add(PrefixFormat(E24[i] * Math.Pow(10.0, factor), 'Ω'));
            }

            R2ValueEnd.SelectedIndex = 23;
        }

        private void FindClick(object sender, EventArgs e)
        {
            if (R1FactorBegin.SelectedIndex == -1)
            {
                R1FactorBegin.SelectedIndex = 0;
            }

            if (R1FactorEnd.SelectedIndex == -1)
            {
                R1FactorEnd.SelectedIndex = 6;
            }

            if (R1ValueBegin.SelectedIndex == -1)
            {
                R1ValueBegin.SelectedIndex = 0;
            }

            if (R1ValueEnd.SelectedIndex == -1)
            {
                R1ValueEnd.SelectedIndex = 23;
            }

            if (R2FactorBegin.SelectedIndex == -1)
            {
                R2FactorBegin.SelectedIndex = 0;
            }

            if (R2FactorEnd.SelectedIndex == -1)
            {
                R2FactorEnd.SelectedIndex = 6;
            }

            if (R2ValueBegin.SelectedIndex == -1)
            {
                R2ValueBegin.SelectedIndex = 0;
            }

            if (R2ValueEnd.SelectedIndex == -1)
            {
                R2ValueEnd.SelectedIndex = 23;
            }
            
            int R1FactorStart = R1FactorBegin.SelectedIndex;
            int R1FactorStop  = R1FactorEnd.SelectedIndex + 1;
            int R1ValueStart  = R1ValueBegin.SelectedIndex;
            int R1ValueStop   = R1ValueEnd.SelectedIndex + 1;

            int R2FactorStart = R2FactorBegin.SelectedIndex;
            int R2FactorStop  = R2FactorEnd.SelectedIndex + 1;
            int R2ValueStart  = R2ValueBegin.SelectedIndex;
            int R2ValueStop   = R2ValueEnd.SelectedIndex + 1;

            double U = Convert.ToDouble(UinValue.Text, nfi);
            double u = Convert.ToDouble(UoutValue.Text, nfi);

            Solutions.Rows.Clear();

            if (Uout.Checked)
            {
                Solutions.Columns[4].HeaderText = "ΔUout";
                Solutions.Columns[5].HeaderText = "δUout";
            }
            else
            {
                Solutions.Columns[4].HeaderText = "ΔUin";
                Solutions.Columns[5].HeaderText = "δUin";
            }

            for (int rf1 = R1FactorStart; rf1 < R1FactorStop; rf1++)
            {
                for (int rv1 = R1ValueStart; rv1 < R1ValueStop; rv1++)
                {
                    for (int rf2 = R2FactorStart; rf2 < R2FactorStop; rf2++)
                    {
                        for (int rv2 = R2ValueStart; rv2 < R2ValueStop; rv2++)
                        {
                            double R = E24[rv1] * Math.Pow(10.0, rf1);
                            double r = E24[rv2] * Math.Pow(10.0, rf2);

                            if (Uout.Checked)
                            {
                                double v  = r * U / (R + r);
                                double Du = Math.Sqrt(2) * U * r * R * d / ((R + r) * (R + r));
                                double du = Du / u;
                                double dv = (v - u) / u;

                                if (Math.Abs(dv) < 0.05)
                                {
                                    Solutions.Rows.Add
                                    (
                                        PrefixFormat(R, 'Ω'),
                                        PrefixFormat(r, 'Ω'),
                                        U.ToString("f3") + "V",
                                        v.ToString("f3") + "V",
                                        Du.ToString("f3") + "V",
                                        dv.ToString("P"),
                                        PrefixFormat(U / (R + r), 'A'),
                                        PrefixFormat(U / R, 'A')
                                    );
                                }
                            }
                            else
                            {
                                double V  = (R + r) / r * u;
                                double DU = Math.Sqrt(2) * u * d * R / r;
                                double dU = DU / U;
                                double dV = (V - U) / U;

                                if (Math.Abs(dV) < 0.05)
                                {
                                    Solutions.Rows.Add
                                    (
                                        PrefixFormat(R, 'Ω'),
                                        PrefixFormat(r, 'Ω'),
                                        V.ToString("f3") + "V",
                                        u.ToString("f3") + "V",
                                        DU.ToString("f3") + "V",
                                        dV.ToString("P"),
                                        PrefixFormat(U / (R + r), 'A'),
                                        PrefixFormat(U / R, 'A')
                                    );
                                }
                            }
                        }
                    }
                }
            }

            Solutions.Sort(Solutions.Columns[5], ListSortDirection.Ascending);
        }
        #endregion
    }
}