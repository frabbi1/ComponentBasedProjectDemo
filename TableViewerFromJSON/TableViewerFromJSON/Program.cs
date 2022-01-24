using TableViewerComponent;
using TableViewerFromJSON;

var tableViewer = new TableViewer(new JsonToTableDataParser().ParseData());
tableViewer.ShowTable();