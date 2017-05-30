using System.Runtime.CompilerServices;

namespace GHIElectronics.TinyCLR.Devices.Spi {
    /// <summary>
    /// Represents the information about a SPI bus.
    /// </summary>
    public sealed class SpiBusInfo {
        [MethodImpl(MethodImplOptions.InternalCall)]
        extern internal SpiBusInfo(string providerId, uint idx);

        /// <summary>
        /// Gets the number of chip select lines available on the bus.
        /// </summary>
        /// <value>Number of chip select lines.</value>
        public int ChipSelectLineCount { get; }
        /// <summary>
        /// Minimum clock cycle frequency of the bus.
        /// </summary>
        /// <value>The clock cycle in Hz.</value>
        public int MinClockFrequency { get; }
        /// <summary>
        /// Maximum clock cycle frequency of the bus.
        /// </summary>
        /// <value>The clock cycle in Hz.</value>
        public int MaxClockFrequency { get; }
        /// <summary>
        /// Gets the bit lengths that can be used on the bus for transmitting data.
        /// </summary>
        /// <value>The supported data lengths.</value>
        public int[] SupportedDataBitLengths { get; }
    }
}
