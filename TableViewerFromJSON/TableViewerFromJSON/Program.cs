using TableViewerComponent;
using TableViewerFromJSON;

var tableViewer = new TableViewer();

tableViewer.LoadDataForTable(new JsonToTableDataParser().ParseData());
tableViewer.ShowTable();