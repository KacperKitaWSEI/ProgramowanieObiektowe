using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab3.Logger
{
    public abstract class WritterLogger: ILogger
    {
        TextWriter writer;

        public void Dispose()
        {
        }

        public abstract void Log(params string[] messages);

    }
}
