// ******************************************************************************************************************
//  Open File Dialogue - simple spike for an open file dialogue (GUI)
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//

using System;
using System.IO;
using System.Windows.Forms;

namespace Open_File_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spike \nOpen File Dialogue (GUI) \nJames LoForti");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create Stream
            Stream myStream = null;

            //Initialize OpenFileDialog object
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "text files (*.txt)|*txt"
            };

            //Confirm dialog created successfully
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If file was selected
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    //Create StreamReader and read in the selected file
                    StreamReader data = new StreamReader(myStream);
                    textBox.Text = data.ReadLine( );
                }
            } // end if
        } // end method OpenToolStripMenuItem_Click()
    } // end class Form1
} // end namespace Open_File_Dialog
