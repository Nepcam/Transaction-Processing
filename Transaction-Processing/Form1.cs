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
using System.IO;

namespace Transaction_Processing
{
    // Cameron Nepe - Student ID: 1262199

    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateDPS(int damageValue, double attackSpeed) //DPS == Damage per second
        {
            //DPS is calculated by taking the damage value(int) and dividing it by the attack speed(double).
            double dps;
            dps = damageValue / attackSpeed;
            return dps;
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            StreamWriter writer;
            //SET variables
            List<string> weaponName = new List<string>();
            List<string> weaponType = new List<string>();
            List<int> damageValue = new List<int>();
            List<double> attackSpeed = new List<double>();
            List<double> dps = new List<double>();

            try
            {
                const string FILTER = "Text Files|*.txt|All Files|*.*";
                openFileDialog1.Filter = FILTER;
                //GET the name of the file to read from
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //GET the name of the file to write information to
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //Open the files
                        reader = File.OpenText(openFileDialog1.FileName);
                        writer = File.CreateText(saveFileDialog1.FileName);
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            weaponName.Add(line);
                            line = reader.ReadLine();
                            weaponType.Add(line);
                            line = reader.ReadLine();
                            damageValue.Add(int.Parse(line));
                            line = reader.ReadLine();
                            attackSpeed.Add(double.Parse(line));
                            dps.Add(CalculateDPS(damageValue[damageValue.Count() - 1], attackSpeed[attackSpeed.Count() - 1]));
                        }
                        Console.WriteLine("weaponName".PadLeft(20) + "weaponType".PadLeft(20) + "damageValue".PadLeft(13) + "attackSpeed".PadLeft(20) + "dps".PadLeft(20));
                        writer.WriteLine("weaponName".PadLeft(20) + "weaponType".PadLeft(20) + "damageValue".PadLeft(13) + "attackSpeed".PadLeft(20) + "dps".PadLeft(20));
                        for (int i = 0; i < weaponName.Count; i++)
                        {
                            string output = weaponName[i].PadLeft(20) + weaponType[i].PadLeft(20) + damageValue[i].ToString().PadLeft(13) + attackSpeed[i].ToString().PadLeft(20) + dps[i].ToString("n3").PadLeft(20);
                            Console.WriteLine(output);
                            writer.WriteLine(output);
                        }
                        reader.Close();
                        writer.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
