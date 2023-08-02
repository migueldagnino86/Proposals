using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestForecast.Utils.Consts;

namespace TestForecastUI
{
    public partial class frmTestForecast : Form
    {
        private string urlForecastQas;
        private string urlForecastPrd;

        public frmTestForecast()
        {
            InitializeComponent();


            cmbAmbientePlanit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAmbienteForecast.DropDownStyle = ComboBoxStyle.DropDownList;

            urlForecastQas = string.Empty;
            urlForecastPrd = string.Empty;

        }

        private void frmTestForecast_Load(object sender, EventArgs e)
        {
            urlForecastQas = GetStringFromAppSetting("urlForecastQas");
            urlForecastPrd = GetStringFromAppSetting("urlForecastPrd");

            txtUrl.ReadOnly = true;
            txtUrl.Text = urlForecastPrd;

        }

        private string GetStringFromAppSetting(string key)
        {
            object? objKey;
            string? valueKey = string.Empty;

            objKey = ConfigurationManager.AppSettings[key];
            valueKey = objKey != null ? objKey.ToString() : string.Empty;

            return valueKey ?? string.Empty;

        }

        private void cmbAmbienteForecast_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ambForecast = (string)cmbAmbienteForecast.SelectedItem;

            switch (ambForecast)
            {
                case Consts.ambienteQas:
                    txtUrl.Text = urlForecastQas;
                    break;

                case Consts.ambientePrd:
                    txtUrl.Text = urlForecastPrd;
                    break;

                default:
                    txtUrl.Text = string.Empty;
                    break;
            }
        }


    }
}
