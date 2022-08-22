namespace SimpleGenericCache
{
    internal record CachedValue<T> //(T Value, DateTime DateTime, int Timeout)
    {
        public T? Value { get; set; }
        public DateTime CreationTime { get; set; }
        public int  Timeout { get; set; }
    }
}
