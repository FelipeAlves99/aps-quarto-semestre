using APS_4.Model.Entities;
using APS_4.Model.Module;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            _entity.NumberList = new int[10];

            if (radioButton != null)
            {
                _ordering = new OrderingAlgorithms();
                switch (radioButton.Name)
                {
                    case "rbBubble":                        
                        BubbleSort();
                        break;

                    case "rbInsertion":                        
                        InsertionSort();
                        break;

                    case "rbMerge":                       
                        MergeSort();
                        break;

                    case "rbQuick":
                        QuickSort();
                        break;

                    case "rbSelection":
                        SelectionSort();
                        break;

                    case "rbShell":
                        ShellSort();
                        break;
                }
            }
        }

        private void QuickSort()
        {
            BuildArray();
            int start = 0, end = _entity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            _entity.Moves = _ordering.QuickSort(_entity.NumberList, start, end);
            time.Stop();

            _entity.Time = time.ElapsedMilliseconds;
            ShowInfo();
        }

        private void ShellSort()
        {
            BuildArray();
            _entity = _ordering.ShellSort(_entity);
            ShowInfo();
        }

        private void InsertionSort()
        {
            BuildArray();
            _entity = _ordering.InsertionSort(_entity);
            ShowInfo();
        }

        private void BubbleSort()
        {
            BuildArray();
            _entity = _ordering.BubbleSort(_entity);
            ShowInfo();
        }

        private void MergeSort()
        {
            BuildArray();
            int start = 0, end = _entity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            _entity.Moves = _ordering.MergeSort(_entity.NumberList, start, end);
            time.Stop();

            _entity.Time = time.ElapsedMilliseconds;
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
