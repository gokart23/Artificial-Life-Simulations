using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeTrial
{
    public partial class Form1 : Form
    {
        HiveEnvironment env = null;
        BeeHive hive = null;
        
        public Form1()
        {
            InitializeComponent();
            this.createPanel.Visible = false;
            this.hivePanel.Visible = false;

            this.Size = new Size(428, 79);
            this.Invalidate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void beesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = beesList.SelectedIndex;
            Bee temp = hive.getBee(i);
            this.beeNumber.Text = temp.Number.ToString();
            this.beeState.Text = temp.state.ToString();
            this.beeAppetite.Text = temp.Appetite.ToString();
            this.beePosition.Text = temp.position.X + ", " + temp.position.Y;
        }
        
        private void createBeehive_Click(object sender, EventArgs e)
        {
            env = new HiveEnvironment();
            
            this.createPanel.Visible = true;
            this.Size = new Size(428, 149);
            this.clumpsList.Items.Clear();

            for (int i = 0; i < env.numClumps; i++)
            {
                Rectangle temp = env.clump(i);
                clumpsList.Items.Add("Clump#" + i + "\t" + temp.X + ", " + temp.Y + "\tWidth: " + temp.Width + "\tHeight: " + temp.Height);
            }
           // this.Invalidate();
        }

        private void createBees_Click(object sender, EventArgs e)
        {
            if(numberBees.Text == "")
            {
                MessageBox.Show("Enter valid input");
            }
            else
            {
                hive = new BeeHive(Int32.Parse(numberBees.Text), 80 * Int32.Parse(numberBees.Text), new Point(0, 0), this.env, this);
                updateBeeList();
                this.hivePanel.Visible = true;
                this.Size = new Size(428, 595);
                //this.Invalidate();
                hive.go();
                timer1.Enabled = true;
            }
        }

        public void updateBeeList()
        {
            this.hiveHoney.Text = hive.Honey.ToString();
            this.hiveTime.Text = hive.hiveHours / 24 + "d " + hive.hiveHours % 24 + "h (" + hive.hiveHours + "hours)";
            this.isDay.Text = hive.isDay ? "Day" : "Night";
            beesList.Items.Clear();

            for (int i = 0; i < Int32.Parse(numberBees.Text); i++)
            {
                Bee temp = hive.getBee(i);
                beesList.Items.Add("Bee#" + i + ":\tState: " + temp.state + "\tPosition: " + temp.position.X + ", " + temp.position.Y);
            }
            //beesList.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hive.go();
            updateBeeList();
        }

        private void hivePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
