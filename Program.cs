// Get the starting event details

Console.Write("Enter the starting event ID: ");
var startEventId = int.Parse(Console.ReadLine());

Console.Write("Enter the starting timestamp (yyyy-MM-dd HH:mm:ss): ");
var startTimestamp = DateTime.Parse(Console.ReadLine());

// Get the current event details
Console.Write("Enter the current event ID: ");
var currentEventId = int.Parse(Console.ReadLine());

Console.Write("Enter the current timestamp (yyyy-MM-dd HH:mm:ss): ");
var currentTimestamp = DateTime.Parse(Console.ReadLine());

// Get the target event ID
Console.Write("Enter the target event ID: ");
var targetEventId = int.Parse(Console.ReadLine());

// Calculate the progress made
var eventsProcessed = currentEventId - startEventId;
var timeElapsed = currentTimestamp - startTimestamp;

// Estimate time per event
var timePerEvent = timeElapsed.TotalSeconds / eventsProcessed;

// Calculate events synced per hour
var eventsPerHour = eventsProcessed / timeElapsed.TotalHours;

// Calculate remaining events
var eventsRemaining = targetEventId - currentEventId;

// Estimate time remaining
var secondsRemaining = eventsRemaining * timePerEvent;
var timeRemaining = TimeSpan.FromSeconds(secondsRemaining);

// Calculate the estimated completion time
var estimatedCompletionTime = currentTimestamp.Add(timeRemaining);

// Output the results
Console.WriteLine("\nSync Progress:");
Console.WriteLine($"Events Processed: {eventsProcessed}");
Console.WriteLine($"Time Elapsed: {timeElapsed}");
Console.WriteLine($"Estimated Time Per Event: {timePerEvent:F2} seconds");
Console.WriteLine($"Events Synced Per Hour: {eventsPerHour:F2}");

Console.WriteLine("\nEstimated Completion:");
Console.WriteLine($"Events Remaining: {eventsRemaining}");
Console.WriteLine($"Time Remaining: {timeRemaining}");
Console.WriteLine($"Estimated Completion Time: {estimatedCompletionTime}");
