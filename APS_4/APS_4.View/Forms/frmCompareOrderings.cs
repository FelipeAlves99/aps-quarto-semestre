using APS_4.Model.Entities;
using APS_4.Model.Module;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_4.View.Forms
{
    public partial class frmCompareOrderings : Form
    {
        private OrderingAlgorithms _ordering = new OrderingAlgorithms();
        private int[] _notOrdered;
        private readonly string _path = @"Array.txt";

        public frmCompareOrderings(OrderingEntity entity)
        {
            InitializeComponent();

            _notOrdered = new int[entity.NumberList.Length];
            entity.NumberList.CopyTo(_notOrdered, 0);
        }

        private void FrmCompareOrderings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmConfiguration configuration = new frmConfiguration();
            configuration.Visible = true;
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        private void AlterLabelsInfo(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(AlterLabelsInfo);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                        p.SetValue(oControl, propValue, null);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnInit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dependendo da quantidade de itens a serem ordenados, esse processo poderá demorar a ser efetuado",
                "Efetuar ordenação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var mergeTask = Task.Run(() => MergeSort());
                var quickTask = Task.Run(() => QuickSort());
                var bubbleTask = Task.Run(() => BubbleSort());
                var insertinoTask = Task.Run(() => InsertionSort());
                var selectionTask = Task.Run(() => SelectionSort());
                var shellTask = Task.Run(() => ShellSort());

                await Task.WhenAll(mergeTask, quickTask, bubbleTask, insertinoTask, selectionTask, shellTask);
                CompareResult();
                btnViewArray.Enabled = true;
            }
        }

        private void CompareResult()
        {
            List<BoxInfo> boxInfos = new List<BoxInfo>();

            boxInfos.Add(new BoxInfo(lblBubbleMoves.Text, lblBubbleTime.Text, lblBubbleMoves, lblBubbleTime));
            boxInfos.Add(new BoxInfo(lblShellMoves.Text, lblShellTime.Text, lblShellMoves, lblShellTime));
            boxInfos.Add(new BoxInfo(lblSelectionMoves.Text, lblSelectionTime.Text, lblSelectionMoves, lblSelectionTime));
            boxInfos.Add(new BoxInfo(lblInsertionMoves.Text, lblInsertionTime.Text, lblInsertionMoves, lblInsertionTime));
            boxInfos.Add(new BoxInfo(lblQuickMoves.Text, lblQuickTime.Text, lblQuickMoves, lblQuickTime));
            boxInfos.Add(new BoxInfo(lblMergeMoves.Text, lblMergeTime.Text, lblMergeMoves, lblMergeTime));

            var bestMoves = boxInfos.OrderBy(x => x.Moves).First();
            var bestTime = boxInfos.OrderBy(x => x.Time).First();

            ChangeForeColor(bestMoves.MoveName);
            ChangeForeColor(bestTime.TimeName);
        }

        private void ChangeForeColor(Control oControl)
            => oControl.ForeColor = System.Drawing.Color.ForestGreen;

        private void BuildOrderedFile(int[] numberList)
        {
            if (File.Exists(_path))
                File.Delete(_path);

            using (StreamWriter writer = new StreamWriter(_path))
                for (int i = 0; i < numberList.Length; i++)
                    writer.WriteLine(numberList[i].ToString());
        }

        private void BtnViewArray_Click(object sender, EventArgs e)
            => Process.Start(_path);


        #region Ordering methods

        private async void QuickSort()
        {
            var entity = new OrderingEntity();
            entity.NumberList = new int[_notOrdered.Length];
            _notOrdered.CopyTo(entity.NumberList, 0);


            int start = 0, end = entity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            await Task.Run(() => entity.Moves = _ordering.QuickSort(entity.NumberList, start, end));
            time.Stop();

            entity.Time = time.ElapsedMilliseconds;
            AlterLabelsInfo(lblQuickMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblQuickTime, "text", entity.Time.ToString() + " ms");
            BuildOrderedFile(entity.NumberList);
        }

        private async void MergeSort()
        {
            var entity = new OrderingEntity();
            entity.NumberList = new int[_notOrdered.Length];
            _notOrdered.CopyTo(entity.NumberList, 0);

            int start = 0, end = entity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            await Task.Run(() => entity.Moves = _ordering.MergeSort(entity.NumberList, start, end));
            time.Stop();

            entity.Time = time.ElapsedMilliseconds;
            AlterLabelsInfo(lblMergeMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblMergeTime, "text", entity.Time.ToString() + " ms");
        }

        private async void ShellSort()
        {
            var entity = _ordering.ShellSort(_notOrdered);
            AlterLabelsInfo(lblShellMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblShellTime, "text", entity.Time.ToString() + " ms");
        }

        private async void SelectionSort()
        {
            var entity = _ordering.SelectionSort(_notOrdered);
            AlterLabelsInfo(lblSelectionMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblSelectionTime, "text", entity.Time.ToString() + " ms");
        }

        private async void InsertionSort()
        {
            var entity = _ordering.InsertionSort(_notOrdered);
            AlterLabelsInfo(lblInsertionMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblInsertionTime, "text", entity.Time.ToString() + " ms");
        }

        private async void BubbleSort()
        {
            var entity = _ordering.BubbleSort(_notOrdered);
            AlterLabelsInfo(lblBubbleMoves, "text", entity.Moves.ToString());
            AlterLabelsInfo(lblBubbleTime, "text", entity.Time.ToString() + " ms");
        }

        #endregion


    }

    class BoxInfo
    {
        public BoxInfo(string moves, string time, Control moveName, Control timeName)
        {
            time = Regex.Match(time, @"\d+").Value;
            Moves = Convert.ToInt64(moves);
            Time = Convert.ToInt64(time);
            MoveName = moveName;
            TimeName = timeName;
        }

        public long Moves { get; private set; }
        public long Time { get; private set; }
        public Control MoveName { get; private set; }
        public Control TimeName { get; private set; }
    }

}


