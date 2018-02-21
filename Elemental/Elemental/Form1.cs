using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }

        public Button btn = new Button();
        public Label inventoryLabel = new Label();

        public System.Windows.Forms.Label start()
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(inventoryLabel);
            label.Top = 20;
            label.Left = 15;
            label.Text = "Daddy";
            Console.WriteLine("Made Button");
            return inventoryLabel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start();
        }
    }
}
