using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Seri portları kullanabilmek için gerekli olan kütüphane
// Firebase kullanabilmek için gerekli olan kütüphaneler
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ReadDataESP32
{
    public partial class Form1 : Form
    {
        private string data;

        public Form1()
        {
            InitializeComponent();
        }

        int sum = 0, avg = 0;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "2qjyooICApKrMLz6TAdulUzbFmqnJBvhKJ1iMMKG", // Settings / Project Settings / Service Accounts / Database Secrets
            BasePath = "https://esp32-34420-default-rtdb.firebaseio.com/" // Firebase projemizin yolu burasıdır.
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client!=null)
            {
                MessageBox.Show("Firebase ile bağlantı kuruldu.");
            }

            txtPort.ReadOnly = true; // TextBox yalnızca veri okumakla görevlidir.
            string[] ports = SerialPort.GetPortNames(); // Seri Portları diziye ekleyen koddur.
            foreach (string port in ports)
            {
                cmbPort.Items.Add(port); // Seri portları ComboBox' a ekler.
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); // DataReceived Eventı oluşturur.
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                data = serialPort1.ReadLine(); // Veriyi alır.
                this.Invoke(new EventHandler(displayData_event));
            }
            else
            {
                serialPort1.Close(); // Eğer Seri port açıksa kapatır.
            }
            
        }
        
        private void displayData_event(object sender, EventArgs e)
        {
            txtPort.Text += DateTime.Now.ToString() + "        " + data + "\n"; // Gelen veriyi textBox içine güncel zaman ile ekler.
            lbData.Items.Add(data);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbPort.Text; // ComboBox1'de seçili nesneyi port ismine atar.
                serialPort1.BaudRate = 115200; // BaudRate 115200 olarak ayarlar.
                serialPort1.Open(); // Seri portu açar.
                btnStop.Enabled = true; // Durdurma butonunu aktif hale getirir.
                btnStart.Enabled = false; // Başlatma butonunu pasif hale getirr.
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    // Hata mesajı gösterir.
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); // Eğer Seri port açıksa kapatır.
            }
            btnStop.Enabled = false; // Durdurma butonunu pasif hale getir.
            btnStart.Enabled = true; // Başlatma butonunu aktif hale getir.
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); // Eğer Seri port açıksa kapatır.
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPort.ResetText(); // TextBox' u sıfırlar.
            avg = 0;
            sum = 0;
            lblRSSI.Text = avg.ToString(); // Toplam ve Ortalama değişkenlerini sıfırlar ve ilgili Label' a 0 olan değeri gönderir.
        }

        private async void btnFirebase_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                rssi = lblRSSI.Text
            };

            if (cmbBeaconList.SelectedIndex==0) //Beacon1 seçili ise
            {
                for (int i = 0; i < lbData.Items.Count; i++)
                {
                    SetResponse response = await client.SetTaskAsync("Beacon1/" +i+ "/" +lbData.Items[i], data);
                    Data result = response.ResultAs<Data>();
                }
                SetResponse response2 = await client.SetTaskAsync("Beacon1/Ortalama/" + lblRSSI.Text, data);
                Data result2 = response2.ResultAs<Data>();
                MessageBox.Show("RSSI verisi Firebase' e gönderildi.");
            }
            else if (cmbBeaconList.SelectedIndex==1) //Beacon2 seçili ise
            {
                for (int i = 0; i < lbData.Items.Count; i++)
                {
                    SetResponse response = await client.SetTaskAsync("Beacon2/" + i + "/" + lbData.Items[i], data);
                    Data result = response.ResultAs<Data>();
                }
                SetResponse response2 = await client.SetTaskAsync("Beacon2/Ortalama/" + lblRSSI.Text, data);
                Data result2 = response2.ResultAs<Data>();
                MessageBox.Show("RSSI verisi Firebase' e gönderildi.");
            }
            else //Beacon3 seçili ise
            {
                for (int i = 0; i < lbData.Items.Count; i++)
                {
                    SetResponse response = await client.SetTaskAsync("Beacon3/" + i + "/" + lbData.Items[i], data);
                    Data result = response.ResultAs<Data>();
                }
                SetResponse response2 = await client.SetTaskAsync("Beacon3/Ortalama/" + lblRSSI.Text, data);
                Data result2 = response2.ResultAs<Data>();
                MessageBox.Show("RSSI verisi Firebase' e gönderildi.");
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        /* Serial Port ekranında bulunan RSSI değerlerinin ortalamasını alır ve ileride Firebase' e gönderilecek ortalama RSSI değerini elde eder.
         * Bu RSSI değerini de Label' a yazdırır.
        */
        {
            for (int i = 0; i < lbData.Items.Count; i++)
            {
                sum = sum + Convert.ToInt16(lbData.Items[i]);
            }
            avg = sum / lbData.Items.Count;
            lblRSSI.Text = avg.ToString();
        }
    }
}
