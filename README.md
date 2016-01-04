# IDL.Net-developer-recruitment-test
Invitation Digital Limited Senior .NET Developer recruitment tests

1.
    1. In the `TechnicalTests` project there is a simple bubble sort class called `Sorter`. Have a look at this class and fix any problems with it.
    2. Write unit tests to prove that the `Sorter` class works properly.

2.
    1. In the same project create a class called Stack. Write a custom `Stack` class that does not implement the .NET `System.Collections.Generic.Stack` class. Document any assumptions you make. Your class must have the following methods:
    - `Peek` - returns the top element leaving it in place.
    - `Pop` - Returns and removes the top element.
    - `Push` - Puts a new element on to the top of the stack.
    - `Clear` - Clears the stack of all elements.
    2. Write unit tests to prove that all methods in the `Stack` class perform as expected.

3.
    1. There is a web project 'MVCTests' and an API project 'MCVTestsApi' in the solution that are configured to run on http://localhost:49832/ and http://localhost:49869/ respectively.
    2. In the `MVCTests` project create a route to `/invitationdigital/tests/{index}` that takes an optional integer parameter `index`. 
    3. Create a view that renders the results of an HTTP GET request to the API project (http://localhost:49869/api/values/{index}) with and without the `index` parameter.
 
4.
    1. There is a test in the UnitTests project that is called RaceConditionTests, it is currently broken. Please make changes to the TechicalTests project so that the test passes but do not edit the test in any way. The test is to simulate multiple threads loading, updating and saving sessions. Ideally the solution should not block requests for separate sessions, if any locking is required then it should be on a per-session basis.

Please email <hr@vouchercloud.com> with your email address and we will grant you access to a Google Drive folder that you can upload you completed solution to. Please include the `.git` folder with your completed solution so that we have access to any commits you have made.
