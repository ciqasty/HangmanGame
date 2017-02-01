using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public char character;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeBox()
        {
            textBox1.Clear();
            for (int i=0;i<StringManipulation.word.Length;i++)
            {
                textBox1.Text += '*';
                
            }
            StringManipulation.stringBuilder = textBox1.Text.ToCharArray();
        }
        public void UpdateBox(List<int> charPos, char c)
        {
            textBox1.Text = StringManipulation.BuildString(charPos, c);
        }
        #region Events



        private void buttonA_Click(object sender, EventArgs e)
        {  
            character = Char.ToLower(System.Convert.ToChar(buttonA.Text));
            List<int> charPos = StringManipulation.CheckString(character,StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            StringManipulation.NewWord();
            InitializeBox();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonB.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonC.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonD.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonE.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonF.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonG.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonH.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonI.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonJ.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonK.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonL.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonM.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonN.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonO.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonP.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonQ.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonR.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonS.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonT.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonU.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonV.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonW.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonX.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonY.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            character = Char.ToLower(System.Convert.ToChar(buttonZ.Text));
            List<int> charPos = StringManipulation.CheckString(character, StringManipulation.wordAsChars);
            UpdateBox(charPos, character);
        }
        #endregion
    }
}
