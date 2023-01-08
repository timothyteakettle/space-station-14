namespace Content.Server.Tray
{
    /// <summary>
    /// Simple sound emitter that emits sound on ThrowEvent
    /// </summary>
    [RegisterComponent]
    public sealed class TrayComponent : Component
    {
        /// <summary>
        /// Maximum (total) size of all items stored via the component.
        /// Further items cannot be added if the threshold is reached or adding the item would cause it to exceed the threshold
        /// </summary>
        [DataField("maximumTotalSize")]
        [ViewVariables(VVAccess.ReadWrite)]
        public int MaximumTotalSize = 20;

        /// <summary>
        /// Maximum size any single item stored via the component can be.
        /// </summary>
        [DataField("maximumIndividualSize")]
        [ViewVariables(VVAccess.ReadWrite)]
        public int MaximumIndividualSize = 6;

        /// <summary>
        /// Entities stored by the component
        /// </summary>
        [DataField("storedEntities")]
        [ViewVariables(VVAccess.ReadOnly)]
        public List<EntityUid> StoredEntities = new List<EntityUid>();

    }
}
