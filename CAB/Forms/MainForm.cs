using CAB.Interfaces;
using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using SocketClient = SocketIOClient.SocketIO;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace CAB.Forms
{
    public partial class MainForm : Form
    {
        private SocketClient socket = Config.Socket;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            socket.OnConnected += (Sender, E) =>
            {
                Invoke(new Action(() =>
                {
                    Enabled = true;
                }));
            };

            socket.OnDisconnected += (Sender, E) =>
            {
                MessageBox.Show("Потерянно соединение с сервером!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            };

            try
            {
                await socket.ConnectAsync();
            }
            catch
            {
                MessageBox.Show("Не удалось подключится к сереверу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GetLastVisit();

            socket.On("NewVisit", (response) =>
            {
                Visit visit = response.GetValue<Visit>();

                LastAddressLabel.Text = visit.Ip;
                LastBrowserLabel.Text = visit.Browser;
                LastDateLabel.Text = visit.Date;
            });
        }

        private async void GetLastVisit()
        {
            HttpResponseMessage resMessage;
            try
            {
                resMessage = await Config.HttpClient.GetAsync("/api/v1/visits/last");
            }
            catch
            {
                MessageBox.Show("Не удалось подключится к сереру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();

                return;
            }

            string content = await resMessage.Content.ReadAsStringAsync();
            HttpResponse<Visit> httpResponse = JsonConvert.DeserializeObject<HttpResponse<Visit>>(content);

            if (httpResponse.status == 404) return;

            LastAddressLabel.Text = httpResponse.content.Ip;
            LastBrowserLabel.Text = httpResponse.content.Browser;
            LastDateLabel.Text = httpResponse.content.Date;
        }

        private async void FindForYear_Click(object sender, EventArgs e)
        {
            string year = YearTextBox.Text;

            if (string.IsNullOrWhiteSpace(year) || year.Length < 4)
            {
                MessageBox.Show("Укажите корректный год!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool isInt = int.TryParse(year, out int result);

            if (!isInt)
            {
                MessageBox.Show("Вы указали некорректный год!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            HttpResponseMessage response = await Config.HttpClient.GetAsync($"/api/v1/visits/year/{year}");

            string content = await response.Content.ReadAsStringAsync();

            HttpResponse<int> info = JsonConvert.DeserializeObject<HttpResponse<int>>(content);

            MessageBox.Show($"Кол-во посещений за {year} год: {info.content}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void YearTextBox_Enter(object sender, EventArgs e)
        {
            if (YearTextBox.Text != "YYYY") return;

            YearTextBox.Text = "";
        }

        private async void FindForTime_Click(object sender, EventArgs e)
        {
            string timeStart = TimeStartBox.Text;
            string timeEnd = TimeEndBox.Text;

            if (string.IsNullOrWhiteSpace(timeStart) || string.IsNullOrWhiteSpace(timeEnd))
            {
                MessageBox.Show("Вы указали некоректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Times times = new Times
            {
                startTime = timeStart,
                endTime = timeEnd
            };

            string json = JsonConvert.SerializeObject(times);
            StringContent payload = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Config.HttpClient.PostAsync("/api/v1/visits/time", payload);

            string content = await response.Content.ReadAsStringAsync();

            HttpResponse<List<Visit>> info = JsonConvert.DeserializeObject<HttpResponse<List<Visit>>>(content);

            if (info.status == 404)
            {
                MessageBox.Show("Я не смог найти посещения за данный промежуток времени!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (info.status == 400)
            {
                MessageBox.Show("Вы неправильно указали значения времени", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            VisitsList form = new VisitsList(info.content);

            form.ShowDialog();
        }

        private void TimeStartBox_Enter(object sender, EventArgs e)
        {
            if (TimeStartBox.Text != "00:00") return;

            TimeStartBox.Text = "";
        }

        private void TimeEndBox_Enter(object sender, EventArgs e)
        {
            if (TimeEndBox.Text != "23:59") return;

            TimeEndBox.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await Config.HttpClient.GetAsync("/api/v1/visits/all");

            string content = await response.Content.ReadAsStringAsync();
            HttpResponse<List<Visit>> info = JsonConvert.DeserializeObject<HttpResponse<List<Visit>>>(content);

            if (info.status == 404)
            {
                MessageBox.Show("Похоже что еще никто не посещал сайт", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            VisitsList form = new VisitsList(info.content);

            form.ShowDialog();
        }

        private async void SaveVisitsFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Визиты.txt");

            HttpResponseMessage response = await Config.HttpClient.GetAsync("/api/v1/visits/all");

            string content = await response.Content.ReadAsStringAsync();
            HttpResponse<List<Visit>> info = JsonConvert.DeserializeObject<HttpResponse<List<Visit>>>(content);

            if (info.status == 404)
            {
                MessageBox.Show("Похоже что еще никто не посещал сайт", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string fileContent = "Все визиты:\n";

            foreach (Visit visit in info.content)
            {
                fileContent += $"IP Адрес: {visit.Ip}\nБраузер: {visit.Browser}\nДень визита: {visit.Date}\n\n";
            }

            File.WriteAllText(filePath, fileContent);

            MessageBox.Show($"Файл сохранён по пути: {filePath}!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void FindForDate_Click(object sender, EventArgs e)
        {
            string date = DateTextBox.Text;

            if (string.IsNullOrWhiteSpace(date))
            {
                MessageBox.Show("Укажите дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            HttpResponseMessage respose = await Config.HttpClient.GetAsync($"/api/v1/visits/date/{date}");

            string content = await respose.Content.ReadAsStringAsync();
            HttpResponse<Visit> info = JsonConvert.DeserializeObject<HttpResponse<Visit>>(content);

            if (info.status == 400)
            {
                MessageBox.Show("Вы указали некорректную дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (info.status == 404)
            {
                MessageBox.Show("Я не смог найти последнее посещение за эту дату!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show($"Последнее посещение за {date}\n\nIP Адрес: {info.content.Ip}\nБраузер: {info.content.Browser}\nДата и время: {info.content.Date}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DateTextBox_Enter(object sender, EventArgs e)
        {
            if (DateTextBox.Text != "24-02-2024") return;

            DateTextBox.Text = "";
        }
    }
}
