using APS_4.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_4.View.Forms
{
    public partial class frmConfiguration : Form
    {
        private const string start = "Iniciar";
        private const string fill = "Preencher";
        private const string select = "Selecionar";
        private const string clear = "Limpar";
        private const string close = "Fechar";

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
                txtQuantity.Enabled = false;

            else
                txtQuantity.Enabled = true;

            btnStart.Text = select;
        }

        #endregion

        #region Manual option configurations

        private void RbManual_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationManualOption();
        }

        private void ConfigurationManualOption()
        {
            btnStart.Text = fill;
            DisableLabels();
            ChangeToExit();
            txtQuantity.Text = "";
        }

        #endregion

        #region Automatic option configuration

        private void RbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            ConfigurationAutomaticOption();
        }

        private void ConfigurationAutomaticOption()
        {
            btnStart.Text = start;
            DisableLabels();
            ChangeToExit();
            txtQuantity.Text = "";
        }

        #endregion

        #region Start button actions

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            switch (btnStart.Text)
            {
                case start:
                    break;

                case fill:
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
                                    btnStart.Text = start;
                                    ChangeToClear();
                                }
                            }
                        }
                    }
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

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                ChangeToExit();
            else
                ChangeToClear();
        }
    }
}
