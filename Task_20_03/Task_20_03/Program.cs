using System;
public class Order
{
    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    public int OrderId { get; set; }
    public OrderStatus CurrentStatus { get; private set; }

    public Order(int orderId)
    {
        OrderId = orderId;
        CurrentStatus = OrderStatus.New; // Изначально заказ новый
    }
    public bool ChangeStatus(OrderStatus newStatus)
    {
        if (CurrentStatus == OrderStatus.Delivered || CurrentStatus == OrderStatus.Cancelled)
        {
            Console.WriteLine("Нельзя изменить статус доставленного или отмененного заказа.");
            return false; // Нельзя изменить статус
        }

        if (newStatus < CurrentStatus)
        {
            Console.WriteLine("Нельзя перевести заказ в предыдущий статус.");
            return false;
        }


        CurrentStatus = newStatus;
        Console.WriteLine($"Заказ {OrderId} переведён в статус: {CurrentStatus}");
        return true; // Статус успешно изменен
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Order myOrder = new Order(123); // Создаём новый заказ с ID 123

        Console.WriteLine($"Начальный статус заказа {myOrder.OrderId}: {myOrder.CurrentStatus}");

        myOrder.ChangeStatus(Order.OrderStatus.Processing);
        myOrder.ChangeStatus(Order.OrderStatus.Shipped);
        myOrder.ChangeStatus(Order.OrderStatus.Delivered); // Заказ доставлен

        // Попытка изменить статус доставленного заказа:
        myOrder.ChangeStatus(Order.OrderStatus.Cancelled);  // Выведет сообщение о невозможности изменения

        myOrder = new Order(456);
        Console.WriteLine($"Начальный статус заказа {myOrder.OrderId}: {myOrder.CurrentStatus}");
        myOrder.ChangeStatus(Order.OrderStatus.Shipped);
        myOrder.ChangeStatus(Order.OrderStatus.Cancelled);
        myOrder.ChangeStatus(Order.OrderStatus.Delivered);
    }
}
