using System.Globalization;

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

var startedEventSyncDateInputSplitted = startedEventSyncDateInput!.Split('-').ToList();
var startedEventSyncTimeInputSplitted = startedEventSyncTimeInput!.Split('-').ToList();
var startedDateTime = new DateTime(int.Parse(startedEventSyncDateInputSplitted.Last()), 
    int.Parse(startedEventSyncDateInputSplitted.ElementAt(1)), int.Parse(startedEventSyncDateInputSplitted.First()), 
    int.Parse(startedEventSyncTimeInputSplitted.First()), int.Parse(startedEventSyncTimeInputSplitted.Last()), 0);
    
var currentEventSyncDateInputSplitted = currentEventSyncDateInput!.Split('-').ToList();
var currentEventSyncTimeInputSplitted = currentEventSyncTimeInput!.Split('-').ToList();
var snapshotDateTime = new DateTime(int.Parse(currentEventSyncDateInputSplitted.Last()), 
    int.Parse(currentEventSyncDateInputSplitted.ElementAt(1)), int.Parse(currentEventSyncDateInputSplitted.First()), 
    int.Parse(currentEventSyncTimeInputSplitted.First()), int.Parse(currentEventSyncTimeInputSplitted.Last()), 0);

var timeRun = snapshotDateTime.Subtract(startedDateTime);

var velocityPerHour = int.Parse(currentEventCount!) / timeRun.TotalHours;
Console.WriteLine($"Current velocity is {velocityPerHour} events / hour");

var eventAmountUntilFinished = int.Parse(totalEventCount!) - int.Parse(currentEventCount!);

var hoursNeededToFinish =  eventAmountUntilFinished / velocityPerHour;

var hours = (int)hoursNeededToFinish;
var minutes = hoursNeededToFinish - hours;
var minutesCalculated = minutes * 60;

Console.WriteLine($"Time needed to finish is: {hours} hours and {minutesCalculated} minutes");

var estimatedFinish = snapshotDateTime.AddHours(hours).AddMinutes(minutesCalculated);

Console.WriteLine($"Estimate time to finish is: {estimatedFinish.ToString(CultureInfo.CurrentCulture)}");
Console.ReadLine();