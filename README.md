# A skeleton project for Specflow and Selenium

Project contains initial setup for Selenium + Specflow + C# and two test cases:

	1. `CheckBrowser` to ensure the browser starts.
    2. `FinishMe` to go to http://example.com', click link 'More' and check few elements.

Used POM pattern, smart waits, support for selectors containing variables for better flexibility. Steps could be reused.

## Assumptions
1. Elements on the pages take time before they are loaded into the DOM and/or become visible.
2. Text “Root Zone Management” could be in other locations than required. Selector is defined based on current state.
3. This is not production solution, some parts has been kept simple intentionaly. 

## To run
1. Download [geckodriver](https://github.com/mozilla/geckodriver/releases) 
2. Ensure the executable is in your system's path.
3. Ensure BrowserExecutableLocation contains path to FireFox localiton if not default.
4. Build the solution.
5. In Visual Studio Test Explorer select and run test.
