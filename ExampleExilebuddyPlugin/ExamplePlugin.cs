using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using Loki.Bot;
using Loki.Common;

namespace ExampleExilebuddyPlugin
{
    public class ExamplePlugin : IPlugin
    {
        public UserControl Control => throw new NotImplementedException();

        public JsonSettings Settings => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Author => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Version => throw new NotImplementedException();

        public void Deinitialize()
        {
            throw new NotImplementedException();
        }

        public void Disable()
        {
            throw new NotImplementedException();
        }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public Task<LogicResult> Logic(Logic logic)
        {
            throw new NotImplementedException();
        }

        public MessageResult Message(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
