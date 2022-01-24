namespace TableViewerComponent
{
    public class TableModel
    {
        public IReadOnlyCollection<string>? Headers { get; set; }
        public IReadOnlyCollection<IReadOnlyCollection<string>>? Rows { get; set; }
    }
}
