namespace UKSF.Launcher.FastRsync.Delta {
    public struct DataRange {
        public DataRange(long startOffset, long length) {
            StartOffset = startOffset;
            Length = length;
        }

        public long StartOffset;
        public long Length;
    }
}
