using System;
using System.Collections.Generic;
using System.Text;

namespace OrderStatus
{
    internal class Order
    {
        public required string SecondName { get; init; }
        public OrderStatus Status { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public required string Email { get; set; }

    }
}
