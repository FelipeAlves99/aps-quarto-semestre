using APS_4.Model.Entities;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APS_4.View.Forms
{
    public partial class frmConfiguration : Form
    {
        private const string create = "Criar";
        private const string fill = "Preencher";
        private const string select = "Selecionar";
        private const string clear = "Limpar";
        private const string close = "Fechar";
        private const string compare = "Comparar";

        private OrderingEntity _entity = new OrderingEntity();

        public frmConfiguration()
        {
            InitializeComponent();
        }

        #region External File option configurations

        private void RbExternalFile_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationExternalFileOption();
        }

        private void ConfigurationExternalFileOption()
        {
            if (rbExternalFile.Checked)
                nudQuantity.Enabled = false;

            else
                nudQuantity.Enabled = true;

            btnStart.Text = select;
        }

        #endregion

        #region Manual option configurations

        private void RbManual_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManualOption();
            nudQuantity.Maximum = 100;
        }

        private void ConfigurationManualOption()
        {
            btnStart.Text = fill;
            DisableLabels();
            ChangeToExit();
            nudQuantity.Value = 0;
        }

        #endregion

        #region Automatic option configuration

        private void RbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationAutomaticOption();
            nudQuantity.Maximum = 1000000;
        }

        private void ConfigurationAutomaticOption()
        {
            btnStart.Text = create;
            DisableLabels();
            ChangeToExit();
            nudQuantity.Value = 0;
        }

        #endregion

        #region Start button actions

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            switch (btnStart.Text)
            {
                case create:
                    if (nudQuantity.Value <= 0)
                    {
                        MessageBox.Show("Por favor, informe a quantidade de itens.", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    FillArray((int)nudQuantity.Value);
                    btnStart.Text = compare;

                    break;

                case fill:
                    if (nudQuantity.Value <= 0)
                    {
                        MessageBox.Show("Por favor, informe a quantidade de itens.", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    nudQuantity.Maximum = 100;
                    frmUserInput userInput = new frmUserInput((int)nudQuantity.Value);
                    userInput.ShowDialog();
                    _entity.NumberList = userInput.GetArray();
                    btnStart.Text = compare;
                    break;

                case select:
                    using (OpenFileDialog openFile = new OpenFileDialog())
                    {
                        openFile.InitialDirectory = "c:\\";
                        openFile.Filter = "Arquivo de texto (*.txt)|*.txt";
                        openFile.FilterIndex = 1;
                        openFile.RestoreDirectory = true;

                        if (openFile.ShowDialog() == DialogResult.OK)
                        {
                            filePath = openFile.FileName;

                            var fileStream = openFile.OpenFile();
                            _entity.NumberList = new int[File.ReadLines(filePath).Count()];

                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                if (BuildArrayExternalFile(reader.ReadToEnd()))
                                {
                                    EnableLabels();
                                    lblFileName.Text = openFile.SafeFileName;
                                    btnStart.Text = compare;
                                    ChangeToClear();
                                }
                            }
                        }
                    }
                    break;

                case compare:
                    frmCompareOrderings compareOrderings = new frmCompareOrderings(_entity);
                    this.Visible = false;
                    compareOrderings.Show();
                    break;
            }
        }

        private bool BuildArrayExternalFile(string fileContent)
        {
            using (StringReader reader = new StringReader(fileContent))
            {
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(" ", "");
                    line = line.Trim();
                    if (int.TryParse(line, out int number))
                        _entity.NumberList[i] = number;
                    else
                    {
                        lblFileName.Text = "Uma das linhas do arquivo não eram do tipo numérico ou estavam em branco.";
                        lblFileName.Visible = true;
                        return false;
                    }

                    i++;
                }

                return true;
            }
        }

        #endregion

        private void EnableLabels()
        {
            lblFile.Visible = true;
            lblFileName.Visible = true;
        }

        private void DisableLabels()
        {
            lblFile.Visible = false;
            lblFileName.Visible = false;
        }

        #region Clear button actions

        private void BtnClean_Click(object sender, EventArgs e)
        {
            switch (btnClean.Text)
            {
                case clear:
                    rbAutomatic.Checked = true;
                    nudQuantity.Value = 0;
                    break;

                case close:
                    Application.Exit();
                    break;
            }
        }

        private void ChangeToClear()
            => btnClean.Text = clear;

        private void ChangeToExit()
            => btnClean.Text = close;

        #endregion

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuantity.Value <= 0)
                ChangeToExit();
            else
                ChangeToClear();
        }

        private void FillArray(int value)
        {
            Random randomNumber = new Random();
            _entity.NumberList = new int[value];

            for (int i = 0; i < _entity.NumberList.Length; i++)
            {
                _entity.NumberList[i] = randomNumber.Next(0, 10000000);
            }
        }
    }
}
