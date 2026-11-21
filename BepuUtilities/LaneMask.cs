using System.Numerics;
using System.Runtime.CompilerServices;

namespace BepuUtilities
{
    /// <summary>
    /// A lane mask made fit for integer comparison.
    /// </summary>
    public static class LaneMask
    {
        /// <summary>
        /// The same bits, reinterpreted through floats and back. Mono's LLVM AOT (WebAssembly) keeps a float comparison's mask typed as
        /// floats through bitwise operations, and asserts when such a mask meets an integer comparison; the round trip makes it integers.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> AsInt(Vector<int> mask) => Vector.AsVectorInt32(Vector.AsVectorSingle(mask));
    }
}
