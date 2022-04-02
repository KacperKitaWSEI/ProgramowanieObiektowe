using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Logger
{
    class SocketLogger: ILogger
    {
        protected ClientSocket clientSocket;

        public SocketLogger()
        {

        }

        public SocketLogger(string host, int port)
        {

        }

        ~SocketLogger() { }

        public void Dispose()
        {
            //TODO: Dodać dispose
        }

        public void Log(params string[] messages)
        {
            string host = "google.com";
            int port = 80;

            using (ClientSocket clientSocket = new ClientSocket(host, port))
            {
                // request:

                foreach (var a in messages) {
                    string requestText = a;
                    byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);

                    clientSocket.Send(requestBytes);
                }
                

                // response:

                byte[] responseBuffer = new byte[1024];
                int responseSize = clientSocket.Receive(responseBuffer);

                string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize); // received message

                // ...

                // cleaning:

                clientSocket.Close();
            }
        }
    }
}
