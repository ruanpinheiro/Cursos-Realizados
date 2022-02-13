using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_1___Enumeracao_e_Composicao.Entities.Enums;
using System.Globalization;


namespace Exercicio_1___Enumeracao_e_Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();      
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;           
            Client = client;          
        }

        public void AddItem (OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveItem (OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in OrderItem)
            {
                 sum += item.SubTotal();
               
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + DateTime.Now.ToString());         
            sb.AppendLine("Order status: " + OrderStatus.ToString());          
            sb.AppendLine("Client: " + Client.Name + Client.Birth.ToString("(dd/MM/yyyy)") + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));  

            return sb.ToString(); 
        }
    }
}
