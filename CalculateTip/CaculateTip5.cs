using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateTip
{
    public partial class Tips : Form
    {
        int Scount = 1;
        int Tcount = 15;
        double results = 0;
        double tpResults = 0;
        double spltResults = 0;
        public Tips()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void tipup_Click(object sender, EventArgs e)
        {
            Tcount++;
            tpbox.Text = Tcount.ToString();
        }

        private void tipdwn_Click(object sender, EventArgs e)
        {
            if (Tcount > 0)
            {

                tpbox.Text = Tcount.ToString();
                Tcount--;
            }
            else
            {
                tpbox.Text = "0";
            }
        }

        private void spltup_Click(object sender, EventArgs e)
        {
            Scount++;
            spltbox.Text = Scount.ToString();
        }

        private void spltdwn_Click(object sender, EventArgs e)
        {
            if (Scount > 0)
            {
                spltbox.Text = Scount.ToString();
                Scount--;
            }
            else
            {
                spltbox.Text = "0";
            }
        }

        private void calcu_Click(object sender, EventArgs e)
        {
            tpResults = double.Parse(tpbox.Text);
            results = double.Parse(result.Text);
            spltResults = double.Parse(spltbox.Text);

           results = results * tpResults / 100 / spltResults;
           results = Math.Round(results, 2);
           result.Text = Convert.ToString(results);
           
        }
    }
}
