using ObserverPattern;

var subject = new OrderSubject();

// Register observers
subject.Attach(new NotificationService());
subject.Attach(new AnalyticsService());
subject.Attach(new AutoScaleService());

// Simulation
for (int i = 0; i < 101; i++)
{
    subject.AddOrder();
    Thread.Sleep(20);
}