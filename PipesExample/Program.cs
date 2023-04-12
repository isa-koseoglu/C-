using System.IO.Pipes;

// İlk named pipe oluştur
var server = new NamedPipeServerStream("testpipe1");

// İkinci named pipe oluştur
var client = new NamedPipeClientStream(".", "testpipe1", PipeDirection.InOut);

// İlk named pipe'a bağlan
server.WaitForConnection();

// İkinci named pipe'ı aç
client.Connect();

// Pipe'lar arasında veri gönder
var writer = new StreamWriter(client);
writer.WriteLine("Hello from client!");
writer.Flush();

var reader = new StreamReader(server);
string line = reader.ReadLine();
Console.WriteLine(line);

// Pipe'ları kapat
server.Close();
client.Close();
