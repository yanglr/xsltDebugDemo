# xsltDebugDemo
xslt transformation demo project (.NET core).

### Notes

This functionality is only available in **Visual Studio Professional/Enterprise version**. 

For .NET Framework, the code to get basePath should be

```cs
string basePath = Path.GetDirectoryName(@"../../");
```


For .NET Core (.NET 5, 6, 7 etc.), the code to get basePath should be

```cs
string basePath = Path.GetDirectoryName(@"../../..");
```

