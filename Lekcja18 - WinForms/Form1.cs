namespace Lekcja18___WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(InputA.Text);
            double b = double.Parse(InputB.Text);
            double c = double.Parse(InputC.Text);

            triangleA.Text = $"a = {a}";
            triangleB.Text = $"b = {b}";
            triangleC.Text = $"c = {c}";

            if (a + b > c && a + c > b && b + c > a)
            {
                double obwod = a + b + c;
                double p = obwod / 2;
                double pole = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);

                Ob.Text = $"Ob = {obwod}";
                P.Text = $"P = {pole}";
            }
            else
            {
                MessageBox.Show("Podane boki nie tworz¹ trójk¹ta", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}