# altwalker-dotnet-demo

A simple .NET demo using AltWalker. AltWalker is an open source Model-Based Testing framework.

## Setup

Install the python dependencies:

```
$ pip install -r requirements.txt
```

Build the dotnet project and all of its dependencies.

```
$ dotnet build tests
```

## Running the tests

Check and analyze models for syntax issues:

```
$ altwalker check -m models/default.json "random(vertex_coverage(100))"
```

Verify and analyze the test code for issues (like missing methods or classes):

```
$ altwalker verify tests -m models/default.json --language dotnet
```

Run the tests:

```
$ altwalker online tests -m models/default.json "random(vertex_coverage(100))" --language dotnet
```

Generate a sequence of steps:

```
$ altwalker offline -m models/default.json "random(vertex_coverage(100))" -f steps/steps.json
```

Run the sequence of steps generated with the `offline` command:

```
$ altwalker walk tests steps/steps.json --language dotnet
```
