namespace PotterShoppingCart.Tests.Models
{
    public class Potter
    {
        private int _Version;
        private const int _Price = 100;
        public Potter(int version)
        {
            _Version = version;
        }

        public int Version { get { return _Version; }}
        public int Price { get { return _Price; }}
    }
}