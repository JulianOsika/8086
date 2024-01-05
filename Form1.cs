using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Mikroprocesor8086
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int aX = 0;
        private int bX = 0;
        private int cX = 0;
        private int dX = 0;

        private void XCHG(TextBox box1, TextBox box2)
        {
            string s1 = box1.Text;
            string s2 = box2.Text;
            box1.Text = s2;
            box2.Text = s1;

            SetRegister(box1, s2);
            SetRegister(box2, s1);
        }


        private void UstawDlugosc(TextBox box)
        {
            string zera = "";
            string dane = box.Text;

            if (box.TextLength < 4)
            {
                for (int i = 0; i < 4 - box.TextLength; i++) zera = zera + "0";
                box.Text = zera + dane;
            }
        }

        private void SetRegister(TextBox box, string stringHex)
        {
            if (box == textBox_AX) { aX = int.Parse(stringHex, NumberStyles.HexNumber); }
            else if (box == textBox_BX) { bX = int.Parse(stringHex, NumberStyles.HexNumber); }
            else if (box == textBox_CX) { cX = int.Parse(stringHex, NumberStyles.HexNumber); }
            else if (box == textBox_DX) { dX = int.Parse(stringHex, NumberStyles.HexNumber); }
        }

        // sprawdza czy podano liczbe w hex i przypisuje wartosc w dec do prywatnych double
        private void CheckNumbers(TextBox box)
        {
            bool check = int.TryParse(box.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out _);
            if (check != true)
            {
                MessageBox.Show("Podaj liczbę w hex!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Text = "";
            }
            else SetRegister(box, box.Text);
        }

        private void button_MOV_Click(object sender, EventArgs e)
        {
            if (comboBox_docelowy.SelectedItem.ToString() == "AX")
            {
                if (comboBox_zrodlowy.SelectedItem.ToString() == "AX") { }
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "BX") textBox_AX.Text = textBox_BX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "CX") textBox_AX.Text = textBox_CX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "DX") textBox_AX.Text = textBox_DX.Text;
            }
            else if (comboBox_docelowy.SelectedItem.ToString() == "BX")
            {
                if (comboBox_zrodlowy.SelectedItem.ToString() == "BX") { }
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "AX") textBox_BX.Text = textBox_AX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "CX") textBox_BX.Text = textBox_CX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "DX") textBox_BX.Text = textBox_DX.Text;
            }
            else if (comboBox_docelowy.SelectedItem.ToString() == "CX")
            {
                if (comboBox_zrodlowy.SelectedItem.ToString() == "CX") { }
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "AX") textBox_CX.Text = textBox_AX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "BX") textBox_CX.Text = textBox_BX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "DX") textBox_CX.Text = textBox_DX.Text;
            }
            else if (comboBox_docelowy.SelectedItem.ToString() == "DX")
            {
                if (comboBox_zrodlowy.SelectedItem.ToString() == "DX") { }
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "AX") textBox_DX.Text = textBox_AX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "BX") textBox_DX.Text = textBox_BX.Text;
                else if (comboBox_zrodlowy.SelectedItem.ToString() == "CX") textBox_DX.Text = textBox_CX.Text;
            }
        }

        private void textBox_AX_Leave(object sender, EventArgs e)
        {
            UstawDlugosc(textBox_AX);
            CheckNumbers(textBox_AX);
        }

        private void textBox_BX_Leave(object sender, EventArgs e)
        {
            UstawDlugosc(textBox_BX);
            CheckNumbers(textBox_BX);
        }

        private void textBox_CX_Leave(object sender, EventArgs e)
        {
            UstawDlugosc(textBox_CX);
            CheckNumbers(textBox_CX);
        }

        private void textBox_DX_Leave(object sender, EventArgs e)
        {
            UstawDlugosc(textBox_DX);
            CheckNumbers(textBox_DX);
        }

        private void buttonXCHG_Click(object sender, EventArgs e)
        {
            if(comboBoxXCHG1.SelectedItem.ToString() == "AX")
            {
                if (comboBoxXCHG2.SelectedItem.ToString() == "BX") XCHG(textBox_AX, textBox_BX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "CX") XCHG(textBox_AX, textBox_CX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "DX") XCHG(textBox_AX, textBox_DX);
            }
            else if (comboBoxXCHG1.SelectedItem.ToString() == "BX")
            {
                if (comboBoxXCHG2.SelectedItem.ToString() == "AX") XCHG(textBox_BX, textBox_AX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "CX") XCHG(textBox_BX, textBox_CX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "DX") XCHG(textBox_BX, textBox_DX);
            }
            else if (comboBoxXCHG1.SelectedItem.ToString() == "CX")
            {
                if (comboBoxXCHG2.SelectedItem.ToString() == "AX") XCHG(textBox_CX, textBox_AX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "BX") XCHG(textBox_CX, textBox_BX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "DX") XCHG(textBox_CX, textBox_DX);
            }
            else if (comboBoxXCHG1.SelectedItem.ToString() == "DX")
            {
                if (comboBoxXCHG2.SelectedItem.ToString() == "AX") XCHG(textBox_DX, textBox_AX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "BX") XCHG(textBox_DX, textBox_BX);
                if (comboBoxXCHG2.SelectedItem.ToString() == "CX") XCHG(textBox_DX, textBox_CX);
            }
        }
    }
}
