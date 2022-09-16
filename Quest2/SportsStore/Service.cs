using System.Security.Cryptography.X509Certificates;

namespace SportsStore
{
    public class Service : IService
    {
        private readonly IHorizontalBar _horizontalBar;

        public Service(IHorizontalBar horizontalBar)
        {
            _horizontalBar = horizontalBar;
        }

        public void Print()
        {
            var bars = _horizontalBar.GetHorizontalBars();

            foreach (var bar in bars)
            {
                Console.WriteLine(bar.ToString());
            }
        }
    }
}
