using CNAPP.Service.Enum;

namespace CNAPP.Service.Concrete
{
    public class ServiceResponse
    {
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public bool Success { get; set; } = true;
        public ResponseType ResponseType { get; set; } = ResponseType.success;
    }
}
