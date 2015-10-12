namespace Contega.Interfaces
{
    public interface IRandomGenerator
    {
        void Reset();

        int Next();

        int Peek();
    }
}