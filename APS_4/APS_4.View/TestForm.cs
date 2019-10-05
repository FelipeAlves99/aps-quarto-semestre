using APS_4.Model.Entities;
using APS_4.Model.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_4.View
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private OrderingAlgorithms _ordering = new OrderingAlgorithms();
        private OrderingEntity _entity = new OrderingEntity();
        private string _path = @"..\..\..\Array.txt";

        private void BtnEfetuar_Click(object sender, EventArgs e)
        {
            var radioButton = gbOrdering.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
            _entity.NumberList = new int[20000];

            if (radioButton != null)
            {
                switch (radioButton.Name)
                {
                    case "rbBubble":
                        break;

                    case "rbInsertion":
                        break;

                    case "rbMerge":
                        break;

                    case "rbQuick":
                        break;

                    case "rbSelection":
                        SelectionSort();
                        break;

                    case "rbShell":
                        break;
                }
            }
        }

        private void SelectionSort()
        {
            BuildArray();
            _entity = _ordering.SelectionSort(_entity);
            ShowInfo();
        }

        private void ShowInfo()
        {
            BuildOrderedFile(_entity.NumberList);
            lblMoves.Text = _entity.Moves.ToString() + " ms";
            lblTime.Text = _entity.Time.ToString();
        }

        private void BuildOrderedFile(int[] numberList)
        {            
            if (File.Exists(_path))
                File.Delete(_path);

            using (StreamWriter writer = new StreamWriter(_path))
                for (int i = 0; i < numberList.Length; i++)
                    writer.WriteLine(numberList[i].ToString());
        }

        private void BuildArray()
        {
            Random random = new Random();

            for (int i = 0; i < _entity.NumberList.Length; i++)
            {
                var randomNumber = random.Next();
                _entity.NumberList[i] = randomNumber;
            }
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            Process.Start(_path);
        }
    }
}
