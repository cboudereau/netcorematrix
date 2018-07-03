# dotnet core compatibility sandbox : 

**If you think there is something wrong or incomplete, please submit a PR.**

## Usefull links

[msbuild TargetFramework](https://docs.microsoft.com/en-us/dotnet/standard/frameworks)

[framework compatibility](https://docs.microsoft.com/en-us/dotnet/core/porting/third-party-deps)

## Compatibility matrix

| TF/Compat      | net20 | net35 | net461 | net472 | netstandard1.6 | netcoreapp1.1 | netcoreapp2.0 | netstandard2.0 |
|----------------|-------|-------|--------|--------|----------------|---------------|---------------|----------------|
| net20          | X     |       |        |        |                |               |               |                |
| net35          | X     | X     |        |        |                |               |               |                |
| net461         | X     | X     | X      |        | app            |               |               |                |
| net472         | X     | X     | X      | X      | app            |               |               | app            |
| netstandard1.6 |       |       |        |        | X              |               |               |                |
| netcoreapp1.1  |       |       | X      | X      | X              | X             |               |                |
| netcoreapp2.0  | X     | X     | X      | X      | X              | X             | X             | X              |
| netstandard2.0 | X     | X     | X      | X      | X              |               |               | X              |
***app*** : means console app for example.
