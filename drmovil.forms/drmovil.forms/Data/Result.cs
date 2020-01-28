namespace drmovil.forms.Data
{
    public class Result<T>
    {
        public string Error { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Value { get; set; }
    }
}
