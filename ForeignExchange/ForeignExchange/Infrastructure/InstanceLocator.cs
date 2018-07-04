
namespace ForeignExchange.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        public MainViewModel main { get; set; }
        public InstanceLocator()
        {
            main = new MainViewModel();
        }

    }
}
