using System.IO.Pipes;

namespace Pipe_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        

       

       
        private async Task PipeClient( string pipeName,ListBox list)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            using (NamedPipeClientStream _client = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut))
            {
                // Bağlantıyı aç
                await _client.ConnectAsync();
                // Veri Al
                using (StreamReader reader = new StreamReader(_client))
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        list.Items.Add(line);
                    }
                    if (header_panel.Enabled == true)
                    {
                        header_panel.Enabled = false;
                        body_panel.Enabled=true; 
                    }
                    reader.Close();
                }

                await _client.DisposeAsync();
            }
           
        }
        private async Task PipeServer( string pipeName,string sendMessage)
        {
            using (NamedPipeServerStream _server = new NamedPipeServerStream(pipeName, PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous))
            {

                try
                {
                    await Task.Factory.FromAsync(_server.BeginWaitForConnection, _server.EndWaitForConnection, null);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                using (StreamWriter _writer = new StreamWriter(_server))
                {
                    _writer.AutoFlush = true;
                    _writer.WriteLine("[" + DateTime.Now + "] " + sendMessage);
                    _writer.Close();
                }

                await _server.DisposeAsync();
                message1_txt.Clear();
                message1_txt.Focus();
            }
            await PipeClient(pipeName2_txt.Text,listPipe1_listbox);

        }
        private async void request1_btn_Click(object sender, EventArgs e)
        {
           await PipeClient(pipeName2_txt.Text, listPipe1_listbox);
            //await PipeClient(_client2,pipeName1_txt.Text, listPipe2_listbox);
        }

        private async void send1_btn_Click(object sender, EventArgs e)
        {
            if(pipeName1_txt.Text.Length > 0 && pipeName2_txt.Text.Length > 0)
            {
                await PipeServer(pipeName1_txt.Text, message1_txt.Text);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            body_panel.Enabled= false;
        }
    }
}