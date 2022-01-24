using TableViewerComponent;

namespace TableViewerTest
{
    public class DataParser : ITableData
    {
        public TableModel ParseData()
        {
            var row1 = new List<string>() {"a1", "b1", "c1"};
            var row2 = new List<string>() { "a2", "b2", "c2" };
            var row3 = new List<string>() { "a3", "b3", "c3" };

            return new TableModel()
            {
                Headers = new List<string>() {"H1", "H2", "H3"},
                Rows = new List<IReadOnlyCollection<string>>() {row1, row2, row3}
            };
        }
    }
}
