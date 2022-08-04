using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpcLabs.EasyOpc.UA;


namespace test_qopc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo info = CultureInfo.CurrentCulture;
            lblCulture.Text = info.ToString();
            numericInterval.Value = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ömer Faruk Akyapak ..
        }

        public async void VeriAlma()
        {
            //read ile veri alma ve yazma
            // task ile read için ayrı bir thread oluşturup kasmayı engelleme
            UAAttributeData data = await Task.Run(() =>
            {
                return easyUAClient1.Read(lblServer.Text, lblNode.Text);
            });

            txtCurData.Text = data.DisplayValue();
            txtCurStat.Text = data.StatusCode.ToString();
            txtCurServer.Text = data.ServerTimestamp.ToLocalTime().ToString();
            txtCurSource.Text = data.SourceTimestamp.ToLocalTime().ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Verial butonu ile veri alma 

            UAAttributeData data = easyUAClient1.Read(lblServer.Text, lblNode.Text);
            txtOnData.Text = data.DisplayValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset

            txtCurData.Clear();
            txtCurStat.Clear();
            txtCurServer.Clear();
            txtSubServer.Clear();
            txtSubStat.Clear();
            txtSubData.Clear();
            txtCurSource.Clear();
            txtSubSource.Clear();
            txtOnData.Clear();
        }

        private int _handle/* = 0*/;            //subscribe ı unsubscribe yapmak için 
        private void Form1_Shown(object sender, EventArgs e)
        {
            //form açıldığında
        }
        private void WriteSubscribeData(UAAttributeData data)
        {
            //subscribe ile okunan anlık veriyi yazar

            txtSubData.Text = data.DisplayValue();
            txtSubStat.Text = data.StatusCode.ToString();
            txtSubServer.Text = data.ServerTimestamp.ToLocalTime().ToString();
            txtSubSource.Text = data.SourceTimestamp.ToLocalTime().ToString();
        }
        private void easyUAClient1_DataChangeNotification(object sender, OpcLabs.EasyOpc.UA.OperationModel.EasyUADataChangeNotificationEventArgs e)
        {
            //belirtilen intervalde değişen veriyi çeker

            WriteSubscribeData(e.AttributeData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //her tickte veri çeker

            VeriAlma();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //başlat

            _handle = easyUAClient1.SubscribeDataChange(lblServer.Text, lblNode.Text, (int)numericInterval.Value);
            timer1.Interval = (int)numericInterval.Value;
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //durdur

            if (_handle != 0)
            {
                easyUAClient1.UnsubscribeMonitoredItem(_handle);
                _handle = 0;
            }
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //form kapanırken kasmasın diye

            easyUAClient1.UnsubscribeAllMonitoredItems();
        }
    }
}
