using System;
public class HttpRequest
{
    public string Method {get; set;}
    public string RequestTarget {get; set;}
    public string Version {get; set;}
    public string Host {get; set;}

    public HttpRequest(string httpText)
    {
        string[] lines = httpText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        string firstLine = lines[0];
        string[] parts = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        this.Method = parts[0];
        this.RequestTarget = parts[1];
        this.Version = parts[2];

        string search = "Host:";

        foreach (string host in lines)
        {
            if (host.StartsWith(search, StringComparison.OrdinalIgnoreCase))
            {
                string[] onlyHost = host.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (onlyHost.Length > 1)
                {
                    this.Host = onlyHost[1];
                }
            }
        }
    }
}