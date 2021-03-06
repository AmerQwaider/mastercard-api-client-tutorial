/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Acme.App.MastercardApi.Client.Client.OpenAPIDateConverter;

namespace Acme.App.MastercardApi.Client.Model
{
    /// <summary>
    /// FundingAccountInfo
    /// </summary>
    [DataContract]
    public partial class FundingAccountInfo :  IEquatable<FundingAccountInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingAccountInfo" /> class.
        /// </summary>
        /// <param name="panUniqueReference"> __(CONDITIONAL)__ &lt;br&gt;  For repeat digitizations, the unique reference allocated to the Primary Account Number. When supplied, the tokenUniqueReferenceForPanInfo, accountNumber, expiryMonth and expiryYear must be omitted from CardInfoData. Only allowed if tokenUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ .</param>
        /// <param name="tokenUniqueReference"> __(CONDITIONAL)__&lt;br&gt;  A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime.  For repeat digitizations, the unique reference allocated to the token will be used to retrieve the financial account information. When supplied, the account information is omitted from FundingAccountData. Only allowed if panUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ .</param>
        /// <param name="pushAccountReceipt">__(CONDITIONAL)__&lt;br&gt; The push account receipt is supplied by the Issuer to the Merchant during a push provisioning operation. The pushAccountReceipt is then submitted by the merchant in the tokenize request and will be used by MDES to retrieve the associated funding account information. Only allowed if panUniqueReference and tokenUniqueReference are not present and encrypted data does not contain the funding account information. Refer to the &lt;a href&#x3D;\&quot;https://developer.mastercard.com/page/push-provisioning-merchant\&quot;&gt;Push Provisioning Use Case Guide &lt;/a&gt;  for more information about pushAccountReceipt.  __Max Length:64__ .</param>
        /// <param name="encryptedPayload">encryptedPayload.</param>
        public FundingAccountInfo(string panUniqueReference = default(string), string tokenUniqueReference = default(string), string pushAccountReceipt = default(string), FundingAccountInfoEncryptedPayload encryptedPayload = default(FundingAccountInfoEncryptedPayload))
        {
            this.PanUniqueReference = panUniqueReference;
            this.TokenUniqueReference = tokenUniqueReference;
            this.PushAccountReceipt = pushAccountReceipt;
            this.EncryptedPayload = encryptedPayload;
        }
        
        /// <summary>
        ///  __(CONDITIONAL)__ &lt;br&gt;  For repeat digitizations, the unique reference allocated to the Primary Account Number. When supplied, the tokenUniqueReferenceForPanInfo, accountNumber, expiryMonth and expiryYear must be omitted from CardInfoData. Only allowed if tokenUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ 
        /// </summary>
        /// <value> __(CONDITIONAL)__ &lt;br&gt;  For repeat digitizations, the unique reference allocated to the Primary Account Number. When supplied, the tokenUniqueReferenceForPanInfo, accountNumber, expiryMonth and expiryYear must be omitted from CardInfoData. Only allowed if tokenUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ </value>
        [DataMember(Name="panUniqueReference", EmitDefaultValue=false)]
        public string PanUniqueReference { get; set; }

        /// <summary>
        ///  __(CONDITIONAL)__&lt;br&gt;  A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime.  For repeat digitizations, the unique reference allocated to the token will be used to retrieve the financial account information. When supplied, the account information is omitted from FundingAccountData. Only allowed if panUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ 
        /// </summary>
        /// <value> __(CONDITIONAL)__&lt;br&gt;  A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime.  For repeat digitizations, the unique reference allocated to the token will be used to retrieve the financial account information. When supplied, the account information is omitted from FundingAccountData. Only allowed if panUniqueReference and pushAccountReceipt are not present and encrypted data does not contain the account information. &lt;br&gt; __Max Length:64__ </value>
        [DataMember(Name="tokenUniqueReference", EmitDefaultValue=false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// __(CONDITIONAL)__&lt;br&gt; The push account receipt is supplied by the Issuer to the Merchant during a push provisioning operation. The pushAccountReceipt is then submitted by the merchant in the tokenize request and will be used by MDES to retrieve the associated funding account information. Only allowed if panUniqueReference and tokenUniqueReference are not present and encrypted data does not contain the funding account information. Refer to the &lt;a href&#x3D;\&quot;https://developer.mastercard.com/page/push-provisioning-merchant\&quot;&gt;Push Provisioning Use Case Guide &lt;/a&gt;  for more information about pushAccountReceipt.  __Max Length:64__ 
        /// </summary>
        /// <value>__(CONDITIONAL)__&lt;br&gt; The push account receipt is supplied by the Issuer to the Merchant during a push provisioning operation. The pushAccountReceipt is then submitted by the merchant in the tokenize request and will be used by MDES to retrieve the associated funding account information. Only allowed if panUniqueReference and tokenUniqueReference are not present and encrypted data does not contain the funding account information. Refer to the &lt;a href&#x3D;\&quot;https://developer.mastercard.com/page/push-provisioning-merchant\&quot;&gt;Push Provisioning Use Case Guide &lt;/a&gt;  for more information about pushAccountReceipt.  __Max Length:64__ </value>
        [DataMember(Name="pushAccountReceipt", EmitDefaultValue=false)]
        public string PushAccountReceipt { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedPayload
        /// </summary>
        [DataMember(Name="encryptedPayload", EmitDefaultValue=false)]
        public FundingAccountInfoEncryptedPayload EncryptedPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingAccountInfo {\n");
            sb.Append("  PanUniqueReference: ").Append(PanUniqueReference).Append("\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  PushAccountReceipt: ").Append(PushAccountReceipt).Append("\n");
            sb.Append("  EncryptedPayload: ").Append(EncryptedPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FundingAccountInfo);
        }

        /// <summary>
        /// Returns true if FundingAccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingAccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingAccountInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PanUniqueReference == input.PanUniqueReference ||
                    (this.PanUniqueReference != null &&
                    this.PanUniqueReference.Equals(input.PanUniqueReference))
                ) && 
                (
                    this.TokenUniqueReference == input.TokenUniqueReference ||
                    (this.TokenUniqueReference != null &&
                    this.TokenUniqueReference.Equals(input.TokenUniqueReference))
                ) && 
                (
                    this.PushAccountReceipt == input.PushAccountReceipt ||
                    (this.PushAccountReceipt != null &&
                    this.PushAccountReceipt.Equals(input.PushAccountReceipt))
                ) && 
                (
                    this.EncryptedPayload == input.EncryptedPayload ||
                    (this.EncryptedPayload != null &&
                    this.EncryptedPayload.Equals(input.EncryptedPayload))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PanUniqueReference != null)
                    hashCode = hashCode * 59 + this.PanUniqueReference.GetHashCode();
                if (this.TokenUniqueReference != null)
                    hashCode = hashCode * 59 + this.TokenUniqueReference.GetHashCode();
                if (this.PushAccountReceipt != null)
                    hashCode = hashCode * 59 + this.PushAccountReceipt.GetHashCode();
                if (this.EncryptedPayload != null)
                    hashCode = hashCode * 59 + this.EncryptedPayload.GetHashCode();
                return hashCode;
            }
        }
    }

}
