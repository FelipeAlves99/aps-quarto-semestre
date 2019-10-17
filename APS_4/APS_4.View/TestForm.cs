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

        private OrderingAlgorithms _ordering = null;
        private OrderingEntity _entity = new OrderingEntity();
        private string _path = @"..\..\..\Array.txt";

        private void BtnEfetuar_Click(object sender, EventArgs e)
        {
            var radioButton = gbOrdering.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
            _entity.NumberList = new int[10000];

            if (radioButton != null)
            {
                switch (radioButton.Name)
                {
                    case "rbBubble":
                        break;

                    case "rbInsertion":
                        break;

                    case "rbMerge":
                        _ordering = new OrderingAlgorithms();
                        MergeSort();
                        break;

                    case "rbQuick":
                        break;

                    case "rbSelection":
                        _ordering = new OrderingAlgorithms();
                        SelectionSort();
                        break;

                    case "rbShell":
                        break;
                }
            }
        }

        private void MergeSort()
        {
            BuildArray();
            int inicio = 0, fim = _entity.NumberList.Length - 1;

            var tempo = System.Diagnostics.Stopwatch.StartNew();
            _entity.Moves = _ordering.MergeSort(_entity.NumberList, inicio, fim);
            tempo.Stop();

            _entity.Time = tempo.ElapsedMilliseconds;
            ShowInfo();
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
            lblMoves.Text = _entity.Moves.ToString();
            lblTime.Text = _entity.Time.ToString() + " ms";
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
                var randomNumber = random.Next(1000);
                _entity.NumberList[i] = randomNumber;
            }
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            Process.Start(_path);
        }
    }
}
