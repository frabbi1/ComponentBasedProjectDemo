using Newtonsoft.Json;
using TableViewerComponent;

namespace TableViewerFromJSON
{
    public class JsonToTableDataParser : ITableData
    {
        public TableModel ParseData()
        {
            try
            {
                var data = JsonConvert.DeserializeObject<JsonObject>(File.ReadAllText(@"..\..\..\Files\data.json"));

                var headers = data?.Headers;

                var list = data?.Data;
                var rows = new List<IReadOnlyCollection<string>>();

                foreach (var el in list)
                {
                    var row = new List<string>();
                    foreach (var key in headers)
                    {
                        row.Add(el[key]);
                    }
                    rows.Add(row);
                }

                return new TableModel()
                {
                    Headers = headers,
                    Rows = rows
                };
            }
            catch (Exception e)
            {
                Console.WriteLine("Data Not Found");
                throw;
            }
        }
    }

    public class JsonObject
    {
        public IReadOnlyCollection<string>? Headers { get; set; }
        public List<Dictionary<string, string>>? Data { get; set; }
    }
}
