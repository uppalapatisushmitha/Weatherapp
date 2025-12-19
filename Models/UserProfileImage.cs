using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class UserProfileImage
{
    [BsonId]
    public ObjectId Id { get; set; }

    public string UserId { get; set; } = "";

    public byte[] ImageBytes { get; set; } = Array.Empty<byte>();

    public string ContentType { get; set; } = "";
}
