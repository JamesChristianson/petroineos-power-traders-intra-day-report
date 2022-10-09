# petroineos-power-traders-intra-day-report
Petroineos Power Traders Development Challenge

## Features
- Windows service using .Net 6.0 and an implementation IHostedSetvice 
- Unit testing using NUnit and NSubstitute
- Logging using serilog (logs configured to write to file and console)
- Interface driven design for testable, maintainable code
- Wait & Retry (with exponential back off) and timeout policies implemented using Polly 

## Getting Started
- This app can be installed as a Windows service in the normal way
- For testing this app may be run using the console

### Configuration 
- LogsPath: location of log file
- ReportsPath: location of reports
- Interval: interval of reporting in seconds
- RetryAttempts: 

## Coding Notes
Testing would be more extensive in a real application
