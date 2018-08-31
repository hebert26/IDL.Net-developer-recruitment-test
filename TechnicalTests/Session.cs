using System.Threading;

namespace TechnicalTests
{
    public class Session : ISession
    {
        private int _count;

        public int Count
        {
            get => _count;
            set => Interlocked.Increment(ref _count);
        }

        public string Key { get; set; }
    }
}