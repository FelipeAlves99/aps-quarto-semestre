using APS_4.Model.Entities;
using APS_4.Model.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_4.View.Forms
{
    public partial class frmCompareOrderings : Form
    {
        private OrderingEntity _orderingEntity;
        private OrderingAlgorithms _ordering = new OrderingAlgorithms();

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

        public frmCompareOrderings(OrderingEntity entity)
        {
            InitializeComponent();
            _orderingEntity = entity;
        }

        private void FrmCompareOrderings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmConfiguration configuration = new frmConfiguration();
            configuration.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dependendo da quantidade de itens a serem ordenados, esse processo poderá demorar a ser efetuado",
                "Efetuar ordenação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                BubbleSort();
                InsertionSort();
                SelectionSort();
                ShellSort();
                MergeSort();
                QuickSort();
            }
        }

        #region QuickSort methods

        private void QuickSort()
        {
            int start = 0, end = _orderingEntity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            _orderingEntity.Moves = _ordering.QuickSort(_orderingEntity.NumberList, start, end);
            time.Stop();

            _orderingEntity.Time = time.ElapsedMilliseconds;
            AlterLabelsInfo(lblQuickMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblQuickTime, "text", _orderingEntity.Time.ToString() + " ms");
        }

        #endregion
        private void MergeSort()
        {
            int start = 0, end = _orderingEntity.NumberList.Length - 1;

            var time = Stopwatch.StartNew();
            _orderingEntity.Moves = _ordering.MergeSort(_orderingEntity.NumberList, start, end);
            time.Stop();

            _orderingEntity.Time = time.ElapsedMilliseconds;
            AlterLabelsInfo(lblMergeMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblMergeTime, "text", _orderingEntity.Time.ToString() + " ms");
        }

        private void ShellSort()
        {
            _ordering.ShellSort(_orderingEntity);
            AlterLabelsInfo(lblShellMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblShellTime, "text", _orderingEntity.Time.ToString() + " ms");
        }

        private void SelectionSort()
        {
            _ordering.SelectionSort(_orderingEntity);
            AlterLabelsInfo(lblSelectionMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblSelectionTime, "text", _orderingEntity.Time.ToString() + " ms");
        }

        private void InsertionSort()
        {
            _ordering.InsertionSort(_orderingEntity);
            AlterLabelsInfo(lblInsertionMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblInsertionTime, "text", _orderingEntity.Time.ToString() + " ms");
        }

        private void BubbleSort()
        {
            _ordering.BubbleSort(_orderingEntity);
            AlterLabelsInfo(lblBubbleMoves, "text", _orderingEntity.Moves.ToString());
            AlterLabelsInfo(lblBubbleTime, "text", _orderingEntity.Time.ToString() + " ms");
        }
    }
}
