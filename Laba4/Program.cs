namespace Lab4
{
    class Program
    {
        static void Main()
        {
            TableScheme tableScheme = TableScheme.ReadFile("Scheme\\Book.json");
            Table table = ReadTable.TableRead(tableScheme, "Book.csv");

            try
            {
                foreach (Column key in table.Rows[0].Data.Keys)
                {
                    Console.WriteLine(key.Name + " ");
                }
                foreach (Row row in table.Rows)
                    Console.WriteLine(string.Join(" ", row.Data.Values));
            }

            catch (ArgumentException ex)
            {
                Console.Clear();
                Console.Write("Ошибка:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}