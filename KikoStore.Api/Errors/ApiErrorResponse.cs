using System;

namespace KikoStore.Api.Errors;

public class ApiErrorResponse(int statusCode, string message, string details)
{
    public int statusCode { get; set; }= statusCode;
    public string Message { get; set; }= message;
    public  string Details { get; set; }= details;
}
