using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum NSOrderedCollectionDifferenceCalculationOptions : ulong
{
	OmitInsertedObjects = 1uL,
	OmitRemovedObjects = 2uL,
	InferMoves = 4uL
}