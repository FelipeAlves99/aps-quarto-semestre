using System;
using System.Windows.Forms;

namespace APS_4.View.Forms
{
    public partial class frmUserInput : Form
    {
        public frmUserInput(int arraySize)
        {
            InitializeComponent();
            _arraySize = arraySize;
            _mainArray = new int[_arraySize];
            PrepareForm(_arraySize, 0);
        }

        private int _arraySize;
        private int[] _mainArray;
        private int _arrayCount = 0;

        private void PrepareForm(int length, int position)
            => lblArrayCount.Text = $"{position + 1} / {length}";

        public int[] GetArray()
            => _mainArray;

        private void BtnAddValue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserInput.Text, out int value))
            {                
                EnableReset(true);
                _mainArray[_arrayCount] = value;
                PrepareForm(_mainArray.Length, _arrayCount);
                _arrayCount++;
            }
            else
                MessageBox.Show("Por favor, insira um valor numérico.", "Entrada incorreta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            CanClose();
        }

        private void CanClose()
        {
            if (_arrayCount == _arraySize)
                this.Close();
        }

        private void EnableReset(bool v)
            => btnReset.Enabled = v;

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Realmente deseja reinicar (zerar dados) o array?", "Zerar entrada dos dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _mainArray = new int[_arraySize];
                EnableReset(false);
                PrepareForm(_mainArray.Length, 0);
                txtUserInput.Text = "";
            }
        }

        private void BtnAutoFill_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show($"Deseja que os {_arraySize - _arrayCount} últimos números sejam preenchidos automaticamente?", "Preenchimento automático", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FillArray();
                this.Close();
            }
        }

        private void FillArray()
        {
            Random randomNumber = new Random();

            for (int i = _arrayCount + 1; i < _mainArray.Length; i++)
                _mainArray[i] = randomNumber.Next(0, 1000000);
        }
    }
}
