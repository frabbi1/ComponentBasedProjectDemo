﻿using TableViewerComponent;
using TableViewerFromCSV;

var tableViewer = new TableViewer(new DataParser().ParseData());
tableViewer.ShowTable();