// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Digitalpost.ConsoleSample.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DigitalPostProviderConfigurationModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DigitalPostProviderConfigurationModel class.
        /// </summary>
        public DigitalPostProviderConfigurationModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DigitalPostProviderConfigurationModel class.
        /// </summary>
        public DigitalPostProviderConfigurationModel(System.Guid? id = default(System.Guid?), System.Guid? subscriptionId = default(System.Guid?), string name = default(string), int? systemId = default(int?), string callbackUrl = default(string), string certificateFileName = default(string), string environment = default(string), string provider = default(string))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            SystemId = systemId;
            CallbackUrl = callbackUrl;
            CertificateFileName = certificateFileName;
            Environment = environment;
            Provider = provider;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemId")]
        public int? SystemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificateFileName")]
        public string CertificateFileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public string Environment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

    }
}