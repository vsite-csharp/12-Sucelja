using Vsite.CSharp.Sučelja;

namespace MojDogađaj
{
    internal class Invoke
    {
        private Implementacija implementacija;
        private EventArgs empty;

        public Invoke(Implementacija implementacija, EventArgs empty)
        {
            this.implementacija = implementacija;
            this.empty = empty;
        }
    }
}