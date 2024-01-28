using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Explorer
{
    public partial class Form1 : Form
    {
        //A global variable
        Root deserializedClass = new Root();
        public Form1()
        {
            InitializeComponent();
        }

        private void importFileButton_Click(object sender, EventArgs e)
        {
            // Load the list of creatures from a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Open and read file
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    //This just outputs the file to the textbox for debugging purposes
                    richTextBox1.Text = reader.ReadToEnd();

                    //Get the JSON data and deserialize it into useful classes
                    deserializedClass = JsonConvert.DeserializeObject<Root>(richTextBox1.Text);

                    //Get the registers from the register list and display them
                    //Create and a initialize a newRegisters data sctructure
                    //Has all the registers and sets them to 0
                    List<NewRegister> newRegisters = new List<NewRegister>();
                    foreach (Register register in deserializedClass.info.registers)
                    {
                        NewRegister tempRegister = new NewRegister();
                        tempRegister.name = register.name;
                        tempRegister.value = 0;
                        newRegisters.Add(tempRegister);
                    }
                    registerViewerDisplay.DataSource = newRegisters;

                    //Display all the instructions/functions
                    //First go through Instructions list
                    List<string> functions = new List<string>();
                    foreach (Instruction instruction in deserializedClass.instructions)
                    {
                        //Get name of each instruction and add to function list
                        functions.Add(instruction.insn);
                        
                    }
                    //Set the function view box
                    functionViewBox.DataSource = functions.ToArray();
                    functionViewBox.SelectedIndex = 0;

                    //Initialize the memory view box
                    List<string> memoryCells = new List<string>();
                    foreach(List<int> memory in deserializedClass.info.memory)
                    {
                        string tempString = "";
                        //Turn each array of ints into a string
                        foreach(int dataPoint in memory)
                        {
                            tempString += dataPoint.ToString("X");
                        }
                        //Add the string (memory cell) to the array
                        memoryCells.Add(tempString);
                    }
                    memoryViewBox.DataSource = memoryCells.ToArray();

                }
            }
        }

        private void functionViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            functionViewBox.SelectedIndex++;
            //foreach()
            label1.Text = deserializedClass.instructions[functionViewBox.SelectedIndex].events[0].ToString();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            functionViewBox.SelectedIndex--;
        }

        private void registerViewerDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
