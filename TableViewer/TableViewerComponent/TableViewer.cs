namespace TableViewerComponent
{
    public class TableViewer
    {
        private int tableWidth = 70;
        private TableModel? _table;
        public TableViewer()
        {
        }

        public void LoadDataForTable(TableModel tableModel)
        {
            _table = tableModel;
        }

        // The codes inside this method are inspired from "https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c"

        public void ShowTable()
        {
            if (_table == null)
            {
                Console.WriteLine("No data found!");
                return;
            }

            Console.Clear();
            PrintLine();

            PrintRow(_table.Headers);
            PrintLine();

            foreach (var columns in _table.Rows)
            {
                PrintRow(columns);
            }
            PrintLine();

            Console.ReadLine();
        }

        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private void PrintRow(IReadOnlyCollection<string> columns)
        {
            int width = (tableWidth - columns.Count) / columns.Count;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}