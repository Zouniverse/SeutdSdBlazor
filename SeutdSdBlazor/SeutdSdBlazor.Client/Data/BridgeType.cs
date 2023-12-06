namespace SeutdSdBlazor.Client.Data;

public class BridgeType
{
    public string TypeName { get; set; }
    public string ImgUrl { get; set; }

    public BridgeType(string typeName, string imgUrl)
    {
        TypeName = typeName;
        ImgUrl = imgUrl;
    }
    
	//public static string GetBridgeTypeUrl(string bridgeType) => $"images/bridgeType/{bridgeType}.png";

}
