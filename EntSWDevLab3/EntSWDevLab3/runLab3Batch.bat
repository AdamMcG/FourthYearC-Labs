csc /target:library IHasVolume.cs
csc /reference:IHasVolume.dll /target:library Sphere.cs
csc /reference:IHasVolume.dll /reference:Sphere.dll program.cs
program