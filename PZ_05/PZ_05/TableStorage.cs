using System.Collections.Generic;

namespace TableBookingSystem
{
    public static class TableStorage
    {
        private static List<Table> tables = new()
        {
            new Table { Id = 1, IsBooked = false },
            new Table { Id = 2, IsBooked = false },
            new Table { Id = 3, IsBooked = true, BookingTime = "18:00" }
        };

        public static List<Table> GetTables() => tables;

        public static void AddTable(Table table) => tables.Add(table);

        public static void RemoveTable(int id) => tables.RemoveAll(t => t.Id == id);
    }
}