﻿namespace Rebus.DataBus
{
    /// <summary>
    /// Contains keys of standard metadata which is always available on data stored with the data bus
    /// </summary>
    public static class MetadataKeys
    {
        /// <summary>
        /// Metadata key of the length in bytes of the stored data
        /// </summary>
        public const string Length = "Rbs2DataBusLength";

        /// <summary>
        /// Metadata key of the ISO8601-encoded time of when the data was stored
        /// </summary>
        public const string SaveTime = "Rbs2DataBusSaveTime";
    }
}