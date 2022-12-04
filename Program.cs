Console.WriteLine("started successfully");

Console.WriteLine("Please insert date (dd-mm-yyyy) when you started the event sync");
var startedEventSyncDateInput = Console.ReadLine();

Console.WriteLine("Please insert the time (hh-mm)<24hrs> when you started the event sync");
var startedEventSyncTimeInput = Console.ReadLine();

Console.WriteLine("Please insert the overall event amount that needs to be synced");
var totalEventCount = Console.ReadLine();

Console.WriteLine("Please insert the current event version your syncer is at");
var currentEventCount = Console.ReadLine();

Console.WriteLine("Please insert date (dd-mm-yyyy)  of the event snapshot");
var currentEventSyncDateInput = Console.ReadLine();

Console.WriteLine("Please insert the time (hh-mm)<24hrs> of the event snapshot");
var currentEventSyncTimeInput = Console.ReadLine();