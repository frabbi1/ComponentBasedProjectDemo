using TableViewerComponent;
using TableViewerTest;

var tableViewer = new TableViewer();

tableViewer.LoadDataForTable(new DataParser().ParseData());
tableViewer.ShowTable();
