namespace SeutdSdBlazor.Client.Data;

public class BridgeStyle
{
    public string StyleName { get; set; }
    public string ImgUrl { get; set; }

    public BridgeStyle(string typeName, string imgUrl)
    {
        StyleName = typeName;
        ImgUrl = imgUrl;
    }
}
