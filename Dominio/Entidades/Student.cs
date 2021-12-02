using System.Collections.Generic;
using System.Linq;
using Dominio.ValueObjects;
using Shared.Entidades;

namespace Dominio.Entidades
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Student(Name name, Document document, Email email, Address address) 
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;
            this.Address = address;
               
        }
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;

            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            if (hasSubscriptionActive == false && subscription.Payments.Count > 0)
                _subscriptions.Add(subscription);
            
        }
    }
}