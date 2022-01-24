using TableViewerComponent;

namespace TableViewerFromCSV
{
    public class DataParser : ITableData
    {
        public TableModel ParseData()
        {
            try
            {
                var data = System.IO.File.ReadAllLines(@"..\..\..\Files\students.csv");

                var headers = data.First().Split(',');

                var rows = new List<IReadOnlyCollection<string>>();
                for (var idx = 0; idx < data.Length; idx++)
                {
                    if (idx == 0) continue;
                    var row = data[idx].Split(',');
                    rows.Add(row.ToList());
                }

                return new TableModel()
                {
                    Headers = headers.ToList(),
                    Rows = rows
                };
            }
            catch (Exception e)
            {
                Console.WriteLine("No Data Found");
                throw;
            }

        }
    }
}
