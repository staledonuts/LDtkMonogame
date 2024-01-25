namespace LDtk;

#nullable disable
#pragma warning disable CS8618, CS1591, CS8632, IDE1006

// LDtk 1.5.3

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using Microsoft.Xna.Framework;

public partial class LDtkFile
{
    [JsonPropertyName("bgColor")]
    public Color BgColor { get; set; }

    [JsonPropertyName("defs")]
    public Definitions Defs { get; set; }

    [JsonPropertyName("externalLevels")]
    public bool ExternalLevels { get; set; }

    [JsonPropertyName("iid")]
    public Guid Iid { get; set; }

    [JsonPropertyName("jsonVersion")]
    public string JsonVersion { get; set; }

    [JsonPropertyName("levels")]
    public LDtkLevel[] Levels { get; set; }

    [JsonPropertyName("toc")]
    public LDtkTableOfContentEntry[] Toc { get; set; }

    [JsonPropertyName("worldGridHeight")]
    public int? WorldGridHeight { get; set; }

    [JsonPropertyName("worldGridWidth")]
    public int? WorldGridWidth { get; set; }

    [JsonPropertyName("worldLayout")]
    public WorldLayout? WorldLayout { get; set; }

    [JsonPropertyName("worlds")]
    public LDtkWorld[] Worlds { get; set; }
}

public partial class AutoLayerRuleGroup
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("biomeRequirementMode")]
    public int BiomeRequirementMode { get; set; }

    [JsonPropertyName("color")]
    public Color? Color { get; set; }

    [JsonPropertyName("icon")]
    public TilesetRectangle? Icon { get; set; }

    [JsonPropertyName("isOptional")]
    public bool IsOptional { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("requiredBiomeValues")]
    public string[] RequiredBiomeValues { get; set; }

    [JsonPropertyName("rules")]
    public object[] Rules { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }

    [JsonPropertyName("usesWizard")]
    public bool UsesWizard { get; set; }
}

public partial class AutoRuleDef
{
}

public partial class CustomCommand
{
    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("when")]
    public When? When { get; set; }
}

public partial class Definitions
{
    [JsonPropertyName("entities")]
    public EntityDefinition[] Entities { get; set; }

    [JsonPropertyName("enums")]
    public EnumDefinition[] Enums { get; set; }

    [JsonPropertyName("externalEnums")]
    public EnumDefinition[] ExternalEnums { get; set; }

    [JsonPropertyName("layers")]
    public LayerDefinition[] Layers { get; set; }

    [JsonPropertyName("levelFields")]
    public FieldDefinition[] LevelFields { get; set; }

    [JsonPropertyName("tilesets")]
    public TilesetDefinition[] Tilesets { get; set; }
}

public partial class EntityDefinition
{
    [JsonPropertyName("color")]
    public Color Color { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("nineSliceBorders")]
    public int[] NineSliceBorders { get; set; }

    [JsonPropertyName("pivotX")]
    public float PivotX { get; set; }

    [JsonPropertyName("pivotY")]
    public float PivotY { get; set; }

    [JsonPropertyName("tileRect")]
    public TilesetRectangle? TileRect { get; set; }

    [JsonPropertyName("tileRenderMode")]
    public TileRenderMode? TileRenderMode { get; set; }

    [JsonPropertyName("tilesetId")]
    public int? TilesetId { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }

    [JsonPropertyName("uiTileRect")]
    public TilesetRectangle? UiTileRect { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
}

public partial class EntityInstance
{
    [JsonPropertyName("defUid")]
    public int DefUid { get; set; }

    [JsonPropertyName("fieldInstances")]
    public FieldInstance[] FieldInstances { get; set; }

    [JsonPropertyName("__grid")]
    public Point _Grid { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("__identifier")]
    public string _Identifier { get; set; }

    [JsonPropertyName("iid")]
    public Guid Iid { get; set; }

    [JsonPropertyName("__pivot")]
    public Vector2 _Pivot { get; set; }

    [JsonPropertyName("px")]
    public Point Px { get; set; }

    [JsonPropertyName("__smartColor")]
    public Color _SmartColor { get; set; }

    [JsonPropertyName("__tags")]
    public string[] _Tags { get; set; }

    [JsonPropertyName("__tile")]
    public TilesetRectangle? _Tile { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("__worldX")]
    public int? _WorldX { get; set; }

    [JsonPropertyName("__worldY")]
    public int? _WorldY { get; set; }
}

public partial class EntityReference
{
    [JsonPropertyName("entityIid")]
    public Guid EntityIid { get; set; }

    [JsonPropertyName("layerIid")]
    public Guid LayerIid { get; set; }

    [JsonPropertyName("levelIid")]
    public Guid LevelIid { get; set; }

    [JsonPropertyName("worldIid")]
    public Guid WorldIid { get; set; }
}

public partial class EnumDefinition
{
    [JsonPropertyName("externalRelPath")]
    public string? ExternalRelPath { get; set; }

    [JsonPropertyName("iconTilesetUid")]
    public int? IconTilesetUid { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("tags")]
    public string[] Tags { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }

    [JsonPropertyName("values")]
    public EnumValueDefinition[] Values { get; set; }
}

public partial class EnumValueDefinition
{
    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("tileRect")]
    public TilesetRectangle? TileRect { get; set; }
}

public partial class EnumTagValue
{
    [JsonPropertyName("enumValueId")]
    public string EnumValueId { get; set; }

    [JsonPropertyName("tileIds")]
    public int[] TileIds { get; set; }
}

public partial class FieldDefinition
{
}

public partial class FieldInstance
{
    [JsonPropertyName("defUid")]
    public int DefUid { get; set; }

    [JsonPropertyName("__identifier")]
    public string _Identifier { get; set; }

    [JsonPropertyName("__tile")]
    public TilesetRectangle? _Tile { get; set; }

    [JsonPropertyName("__type")]
    public string _Type { get; set; }

    [JsonPropertyName("__value")]
    public object _Value { get; set; }
}

public partial class GridPoint
{
    [JsonPropertyName("cx")]
    public int Cx { get; set; }

    [JsonPropertyName("cy")]
    public int Cy { get; set; }
}

public partial class IntGridValueDefinition
{
    [JsonPropertyName("color")]
    public Color? Color { get; set; }

    [JsonPropertyName("groupUid")]
    public int GroupUid { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("tile")]
    public TilesetRectangle? Tile { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public partial class IntGridValueGroupDefinition
{
    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }
}

public partial class IntGridValueInstance
{
    [JsonPropertyName("coordId")]
    public int CoordId { get; set; }

    [JsonPropertyName("v")]
    public int V { get; set; }
}

public partial class LayerDefinition
{
    [JsonPropertyName("autoSourceLayerDefUid")]
    public int? AutoSourceLayerDefUid { get; set; }

    [JsonPropertyName("displayOpacity")]
    public float DisplayOpacity { get; set; }

    [JsonPropertyName("gridSize")]
    public int GridSize { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("intGridValues")]
    public IntGridValueDefinition[] IntGridValues { get; set; }

    [JsonPropertyName("intGridValuesGroups")]
    public IntGridValueGroupDefinition[] IntGridValuesGroups { get; set; }

    [JsonPropertyName("parallaxFactorX")]
    public float ParallaxFactorX { get; set; }

    [JsonPropertyName("parallaxFactorY")]
    public float ParallaxFactorY { get; set; }

    [JsonPropertyName("parallaxScaling")]
    public bool ParallaxScaling { get; set; }

    [JsonPropertyName("pxOffsetX")]
    public int PxOffsetX { get; set; }

    [JsonPropertyName("pxOffsetY")]
    public int PxOffsetY { get; set; }

    [JsonPropertyName("tilesetDefUid")]
    public int? TilesetDefUid { get; set; }

    [JsonPropertyName("__type")]
    public LayerType _Type { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }
}

public partial class LayerInstance
{
    [JsonPropertyName("autoLayerTiles")]
    public TileInstance[] AutoLayerTiles { get; set; }

    [JsonPropertyName("__cHei")]
    public int _CHei { get; set; }

    [JsonPropertyName("__cWid")]
    public int _CWid { get; set; }

    [JsonPropertyName("entityInstances")]
    public EntityInstance[] EntityInstances { get; set; }

    [JsonPropertyName("__gridSize")]
    public int _GridSize { get; set; }

    [JsonPropertyName("gridTiles")]
    public TileInstance[] GridTiles { get; set; }

    [JsonPropertyName("__identifier")]
    public string _Identifier { get; set; }

    [JsonPropertyName("iid")]
    public Guid Iid { get; set; }

    [JsonPropertyName("intGridCsv")]
    public int[] IntGridCsv { get; set; }

    [JsonPropertyName("layerDefUid")]
    public int LayerDefUid { get; set; }

    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("__opacity")]
    public float _Opacity { get; set; }

    [JsonPropertyName("overrideTilesetUid")]
    public int? OverrideTilesetUid { get; set; }

    [JsonPropertyName("pxOffsetX")]
    public int PxOffsetX { get; set; }

    [JsonPropertyName("pxOffsetY")]
    public int PxOffsetY { get; set; }

    [JsonPropertyName("__pxTotalOffsetX")]
    public int _PxTotalOffsetX { get; set; }

    [JsonPropertyName("__pxTotalOffsetY")]
    public int _PxTotalOffsetY { get; set; }

    [JsonPropertyName("__tilesetDefUid")]
    public int? _TilesetDefUid { get; set; }

    [JsonPropertyName("__tilesetRelPath")]
    public string? _TilesetRelPath { get; set; }

    [JsonPropertyName("__type")]
    public LayerType _Type { get; set; }

    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
}

public partial class LDtkLevel
{
    [JsonPropertyName("__bgColor")]
    public Color _BgColor { get; set; }

    [JsonPropertyName("__bgPos")]
    public LevelBackgroundPosition? _BgPos { get; set; }

    [JsonPropertyName("bgRelPath")]
    public string? BgRelPath { get; set; }

    [JsonPropertyName("externalRelPath")]
    public string? ExternalRelPath { get; set; }

    [JsonPropertyName("fieldInstances")]
    public FieldInstance[] FieldInstances { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("iid")]
    public Guid Iid { get; set; }

    [JsonPropertyName("layerInstances")]
    public LayerInstance[]? LayerInstances { get; set; }

    [JsonPropertyName("__neighbours")]
    public NeighbourLevel[] _Neighbours { get; set; }

    [JsonPropertyName("pxHei")]
    public int PxHei { get; set; }

    [JsonPropertyName("pxWid")]
    public int PxWid { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }

    [JsonPropertyName("worldDepth")]
    public int WorldDepth { get; set; }

    [JsonPropertyName("worldX")]
    public int WorldX { get; set; }

    [JsonPropertyName("worldY")]
    public int WorldY { get; set; }
}

public partial class LevelBackgroundPosition
{
    [JsonPropertyName("cropRect")]
    public float[] CropRect { get; set; }

    [JsonPropertyName("scale")]
    public Vector2 Scale { get; set; }

    [JsonPropertyName("topLeftPx")]
    public Point TopLeftPx { get; set; }
}

public partial class NeighbourLevel
{
    [JsonPropertyName("dir")]
    public string Dir { get; set; }

    [JsonPropertyName("levelIid")]
    public Guid LevelIid { get; set; }
}

public partial class LDtkTableOfContentEntry
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("instancesData")]
    public TocInstanceData[] InstancesData { get; set; }
}

public partial class TileInstance
{
    [JsonPropertyName("a")]
    public float A { get; set; }

    [JsonPropertyName("f")]
    public int F { get; set; }

    [JsonPropertyName("px")]
    public Point Px { get; set; }

    [JsonPropertyName("src")]
    public Point Src { get; set; }

    [JsonPropertyName("t")]
    public int T { get; set; }
}

public partial class TileCustomMetadata
{
    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("tileId")]
    public int TileId { get; set; }
}

public partial class TilesetDefinition
{
    [JsonPropertyName("__cHei")]
    public int _CHei { get; set; }

    [JsonPropertyName("customData")]
    public TileCustomMetadata[] CustomData { get; set; }

    [JsonPropertyName("__cWid")]
    public int _CWid { get; set; }

    [JsonPropertyName("embedAtlas")]
    public EmbedAtlas? EmbedAtlas { get; set; }

    [JsonPropertyName("enumTags")]
    public EnumTagValue[] EnumTags { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("padding")]
    public int Padding { get; set; }

    [JsonPropertyName("pxHei")]
    public int PxHei { get; set; }

    [JsonPropertyName("pxWid")]
    public int PxWid { get; set; }

    [JsonPropertyName("relPath")]
    public string? RelPath { get; set; }

    [JsonPropertyName("spacing")]
    public int Spacing { get; set; }

    [JsonPropertyName("tags")]
    public string[] Tags { get; set; }

    [JsonPropertyName("tagsSourceEnumUid")]
    public int? TagsSourceEnumUid { get; set; }

    [JsonPropertyName("tileGridSize")]
    public int TileGridSize { get; set; }

    [JsonPropertyName("uid")]
    public int Uid { get; set; }
}

public partial class TilesetRectangle
{
    [JsonPropertyName("h")]
    public int H { get; set; }

    [JsonPropertyName("tilesetUid")]
    public int TilesetUid { get; set; }

    [JsonPropertyName("w")]
    public int W { get; set; }

    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}

public partial class TocInstanceData
{
    [JsonPropertyName("fields")]
    public object Fields { get; set; }

    [JsonPropertyName("heiPx")]
    public int HeiPx { get; set; }

    [JsonPropertyName("iids")]
    public EntityReference Iids { get; set; }

    [JsonPropertyName("widPx")]
    public int WidPx { get; set; }

    [JsonPropertyName("worldX")]
    public int WorldX { get; set; }

    [JsonPropertyName("worldY")]
    public int WorldY { get; set; }
}

public partial class LDtkWorld
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("iid")]
    public Guid Iid { get; set; }

    [JsonPropertyName("levels")]
    public LDtkLevel[] Levels { get; set; }

    [JsonPropertyName("worldGridHeight")]
    public int WorldGridHeight { get; set; }

    [JsonPropertyName("worldGridWidth")]
    public int WorldGridWidth { get; set; }

    [JsonPropertyName("worldLayout")]
    public WorldLayout? WorldLayout { get; set; }
}

public enum EmbedAtlas { LdtkIcons, }

public enum TileRenderMode { Cover, FitInside, Repeat, Stretch, FullSizeCropped, FullSizeUncropped, NineSlice, }

public enum When { Manual, AfterLoad, BeforeSave, AfterSave, }

public enum WorldLayout { Free, GridVania, LinearHorizontal, LinearVertical, }

#pragma warning restore
#nullable restore
