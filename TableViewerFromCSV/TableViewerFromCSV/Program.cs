using TableViewerComponent;
using TableViewerFromCSV;

var tableViewer = new TableViewer();

tableViewer.LoadDataForTable(new DataParser().ParseData());
tableViewer.ShowTable();
