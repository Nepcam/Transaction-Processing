using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaction_Processing
{
    // Cameron Nepe - Student ID: 1262199

    public partial class Form1 : Form
    {
        //SET variables
        string weaponName = "";
        string weaponType = "";
        int damageValue = 0;
        double attackSpeed = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateDPS(int damageValue, double attackSpeed) //DPS == Damage per second
        {
            //DPS is calculated by taking the damage value(int) and dividing it by the attack speed(double).
        }
    }
}
