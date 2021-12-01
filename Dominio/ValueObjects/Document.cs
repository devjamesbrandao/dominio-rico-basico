using Dominio.Enums;
using Shared.ValueObjects;

namespace Dominio.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }

    }
}