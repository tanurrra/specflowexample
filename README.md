# A skeleton project for Specflow and Selenium

1. Download [geckodriver](https://github.com/mozilla/geckodriver/releases) 
1. Ensure the executable is in your system's path.
1. Build the solution.
1. Run testcase `CheckBrowser` to ensure the browser starts.
5. Look at testcase `FinishMe` and create the necessary binding code.


## Assumptions
1. Elements on the pages take time before they are loaded into the DOM and/or become visible.
2. Text “Root Zone Management” in other locations than required. Selector is defined based on provided screenshot.
3. This is not production solution, some parts has been kept simple intentionaly. 

## To run
1. Please make sure BrowserExecutableLocation contains path to FireFox localiton if not default.
2. Build the solution in Visual Studio.
3. In Test Explorer select and run test.
