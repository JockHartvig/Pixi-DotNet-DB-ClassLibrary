#Contributing to Pixi-DotNet-DB-ClassLibrary

Welcome! We would love to have you contribute bug fixes or new functionality to Prism. 

The best starting point is to enter an Issue here. We can then have a brief discussion on what you want to do and where it fits with our milestones and goals for the library. As long as it sounds like something we would want to add to Prism, we will give you a thumbs up and ask for a pull request.

When you submit a pull request, there are a few things we would like you to comply with:
•New functionality must have accompanying unit tests with "good" code coverage if it is logic code that can be unit tested (i.e. not view stuff touching UI or platform APIs)
•Changes to existing functionality needs to be checked that it does not break any existing unit tests. If it does, then fixes to the unit test may be appropriate, but only if those changes maintain the original intent of the test.
•Some basic coding standard guidelines to start with: ◦no leading "this."
◦single type per file
◦interface-based design to preserve testability and extensibility
◦due consideration for inheritance (i.e. consider carefully whether something should be protected or virtual)
◦member variables have leading underscore and are _camelCased
◦local variables are camelCased with no prefix
◦Types, properties, methods, events are PascalCased


Contribution License Agreement

???????
