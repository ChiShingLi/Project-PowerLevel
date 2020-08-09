# Sprint Retrospective Summary

## Prime Directive of Retrospectives

Regardless of what we discover, we understand and truly believe that everyone did the best job they could, given what they knew at the time, their skill and abilities, the resources available, and the situation at hand.

## Safety Check

5 across the board.

## What We Learned

We learned that we need to effectively manage time at the beginning of inception and sprints to get a solid foundation for our architecture and design. We also learned the importance of scheduling time for testing and making sure that we perform thorough tests. We learned how to work as a team and how to fully utilize the resources at our disposal. We also learned the importance of communication and that we need to communicate more through discord so that we can be up to date with everything that each developer is doing. We also learned the importance of gaging how much work we can do and is feasible for our time constraints and current team dynamic. We also learned the importance of writing good user stories with accurate descriptions so we can understand what it is we are actually trying to build.

## What Still is not Going Right

We need to properly set up Dev Ops so that the burn-down chart actually works and displays in our sprints. We also had a problem with the gitignore not working but that has since been resolved.

## What can the Team do Better in the Next Sprint

We can have Dev Ops set up properly and remember to actually track our progress on the site. 

## Action Plan

* Fully set up sprints on Dev Ops before hand

* Update task boards daily

* Update team members over the weekend as to our progress

## Items out side of the Meeting

Nothing to bring up.

# Processes and Guidelines for Contributing to Power Level

Welcome to the guidelines page that everyone loves. If you are going to be contributing code to the project, make sure you follow these guidelines. Please. Nick is a stickler for consistency and we don't want to mess with his flow.

## Versions, Processes, and Workflow

We are using the following tools and versions for this project:

* Visual Studio 2017 Community v 15.9.6
* Entity Framework v TBA
* JQuery v TBA
* Newtonsoft v TBA
* Bootstrap v 3.7

We are using D.A.D. mixed with scrum sprints and planning meetings. We are using the git branching workflow for our control structure. We branch off of Development with a feature branch to complete a user story and then issue a pull request to merge that feature branch into Development. Please merge your Development into your feature branch before issuing the request so we can minimize merge conflicts.
Feature branches are of the form: sprint-feature-DeveloperName

We recommend that you match our software and version numbers. Remember! Consistency matters.
Also, when a new message goes out that one of the main branches has been updated, master and Development, please update your repositories so that we can be as consistent as possible.

## Guidelines for Databases

* Table name is Pluralized i.e. Topics
* Primary Key Constraints are of the form: PK_dbo.[TableName]
* Foreign Keys Constraints are of the form: FK_[TableItIsIn]_[TableItReferences]
* Primary Key Columns are of the form: [TableNameId] i.e. TopicsId
* Tables referenced by foreign keys must be first in the up script
* Foreign Key Constraints must be the first things dropped in the down script
* Remove your connection string before submitting a pull request

## Guidelines for Code in General

* Follow standard language conventions
* COMMENT YOUR CODE!!!!! (Very important)
* Use XML comments for all public methods
* All code should be in C#, Razor, Javascript, or HTML for MVC 5 .NET Framework

We ask that you follow these guidelines so that we can have a smooth process and be as synchronized as possible. Remember! Consistency is key and we don’t want to mess with Nick.
