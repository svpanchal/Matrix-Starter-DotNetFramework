namespace Matrix_Starter_DotNetFramework.Models
{
    public class ResponseMessage
    {
        public string Message { get; set; } = "Default Message";

        public ValidMessageType MessageType { get; set; } = ValidMessageType.Info;
    }
}