namespace ProductApi.Service
{
    public class ResponseItem<T>  : Response
    {
        public T Result { get; set; }
    }
}
