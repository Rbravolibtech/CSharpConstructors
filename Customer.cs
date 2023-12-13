using System.Collections.Generic;

namespace CSharpConstructors
{ 
public class Customer
{
    public int Id;
    public string Name;
        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            
            this.Name = name;
        }
        

	}
}

