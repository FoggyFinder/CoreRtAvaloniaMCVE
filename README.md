Sample project for [#399](https://github.com/dotnet/runtimelab/issues/399) issue that works just fine with [old version](https://github.com/dotnet/corert) of CoreRt but crashes with a [new one](https://github.com/dotnet/runtimelab/tree/feature/NativeAOT).

Make sure `libSkiaSharp.dll` is placed near an executable. Otherwise it won't run.

To use previous version replace

```xml
<PackageReference Include="Microsoft.DotNet.ILCompiler" Version="6.0.0-*" />
```

with

```xml
<PackageReference Include="Microsoft.DotNet.ILCompiler" Version="1.0.0-alpha-*" />
```

