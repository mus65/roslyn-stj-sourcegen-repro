Run the following to repro and the bad execution time:

```
git clean -qxffd && dotnet build -v diag | grep -B 4 -A 2 CSharpRemoveUnnecessaryImportsDiagnosticAnalyzer
```
