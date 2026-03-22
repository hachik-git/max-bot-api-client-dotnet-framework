using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;

public sealed class ContactPayload : AttachmentPayload
{
    public override string Type => "contact";

    /// <summary>
    /// Имя контакта
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// ID контакта, если он зарегистирован в MAX
    /// </summary>
    [JsonProperty("contact_id")]
    public long? ContactId { get; set; }

    /// <summary>
    /// Полная информация о контакте в формате VCF
    /// </summary>
    [JsonProperty("vcf_info")]
    public string VcfInfo { get; set; }

    /// <summary>
    /// Телефон контакта в формате VCF
    /// </summary>
    [JsonProperty("vcf_phone")]
    public string VcfPhone { get; set; }
}