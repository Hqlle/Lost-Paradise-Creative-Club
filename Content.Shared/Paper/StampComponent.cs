using Robust.Shared.Serialization;
using Robust.Shared.Audio;

namespace Content.Shared.Paper;

/// <summary>
///     Set of required information to draw a stamp in UIs, where
///     representing the state of the stamp at the point in time
///     when it was applied to a paper. These fields mirror the
///     equivalent in the component.
/// </summary>
[DataDefinition, Serializable, NetSerializable]
public partial struct StampDisplayInfo
{
    StampDisplayInfo(string s)
    {
        StampedName = s;
    }

    [DataField("stampedName")]
    public string StampedName;

    [DataField("stampedColor")]
    public Color StampedColor;

    [DataField("stampedBorderless")]
    public bool StampedBorderless;

    [DataField("blockWriting")]
    public bool BlockWriting = true;
};

[RegisterComponent]
public sealed partial class StampComponent : Component
{
    /// <summary>
    ///     The loc string name that will be stamped to the piece of paper on examine.
    /// </summary>
    [DataField("stampedName")]
    public string StampedName { get; set; } = "stamp-component-stamped-name-default";

    /// <summary>
    ///     Tne sprite state of the stamp to display on the paper from paper Sprite path.
    /// </summary>
    [DataField("stampState")]
    public string StampState { get; set; } = "paper_stamp-generic";

    /// <summary>
    /// The color of the ink used by the stamp in UIs
    /// </summary>
    [DataField("stampedColor")]
    public Color StampedColor = Color.FromHex("#BB3232"); // StyleNano.DangerousRedFore

    /// <summary>
    /// Whether to block writing after the paper being stamped
    /// </summary>
    [DataField("blockWriting")]
    public bool BlockWriting = true;

    /// The sound when stamp stamped
    /// </summary>
    [DataField("sound")]
    public SoundSpecifier? Sound = null;

    /// <summary>
    /// Frontier - The stamp using the person name on it
    /// </summary>
    [DataField("stampedPersonal")]
    public bool StampedPersonal = false;

    [DataField("stampedBorderless")]
    public bool StampedBorderless = false;

    [ViewVariables]
    public EntityUid? StampedIdUser = null;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("nameSetUser")]
    public bool NameSetUser { get; set; }
}
