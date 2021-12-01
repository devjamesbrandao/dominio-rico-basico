using Shared.ValueObjects;

namespace Dominio.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }
        public string Address { get; private set; }
    }
}