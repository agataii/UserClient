using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using UserCommon;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        private List<User> _users;

        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            string usersJson = await ApiUtility.GetApiResponseAsync("users");

            if (usersJson == null)
            {
                MessageBox.Show("Не удалось подключиться к серверу");

                return;
            }

            _users = JsonConvert.DeserializeObject<List<User>>(usersJson);

            _listView.Items.Clear();

            foreach (User user in _users)
            {
                ListViewItem viewItem = new ListViewItem();

                viewItem.Text = user.Id.ToString();
                viewItem.SubItems.Add(user.Name.ToString());
                viewItem.SubItems.Add(user.Email.ToString());
                viewItem.SubItems.Add(user.Birthday.ToString());

                _listView.Items.Add(viewItem);
            }
        }

        private async void PostButton_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                User user = new User()
                {
                    Name = _inputName.Text,
                    Email = _inputEmail.Text,
                    Password = _inputPassword.Text,
                    Birthday = dateTimePicker1.Value
                };

                string userJson = JsonConvert.SerializeObject(user);

                HttpContent content = new StringContent(userJson, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(ApiUtility.URL + "user/create", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(responseContent);
                }
                else
                {
                    MessageBox.Show("Не удалось подключиться к серверу");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}