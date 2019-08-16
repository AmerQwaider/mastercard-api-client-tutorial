/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.9
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
using OpenAPIDateConverter = Mastercard.Developer.DigitalEnablement.Client.Client.OpenAPIDateConverter;

namespace Mastercard.Developer.DigitalEnablement.Client.Model
{
    /// <summary>
    /// TokenDetailDataTCCOnly
    /// </summary>
    [DataContract]
    public partial class TokenDetailDataTCCOnly :  IEquatable<TokenDetailDataTCCOnly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDetailDataTCCOnly" /> class.
        /// </summary>
        /// <param name="accountHolderData">accountHolderData.</param>
        /// <param name="paymentAccountReference">The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response. &lt;br&gt;    __Max Length: 29__ .</param>
        /// <param name="cardAccountData">cardAccountData.</param>
        public TokenDetailDataTCCOnly(AccountHolderDataOutbound accountHolderData = default(AccountHolderDataOutbound), string paymentAccountReference = default(string), CardAccountDataOutbound cardAccountData = default(CardAccountDataOutbound))
        {
            this.AccountHolderData = accountHolderData;
            this.PaymentAccountReference = paymentAccountReference;
            this.CardAccountData = cardAccountData;
        }
        
        /// <summary>
        /// Gets or Sets AccountHolderData
        /// </summary>
        [DataMember(Name="accountHolderData", EmitDefaultValue=false)]
        public AccountHolderDataOutbound AccountHolderData { get; set; }

        /// <summary>
        /// The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response. &lt;br&gt;    __Max Length: 29__ 
        /// </summary>
        /// <value>The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response. &lt;br&gt;    __Max Length: 29__ </value>
        [DataMember(Name="paymentAccountReference", EmitDefaultValue=false)]
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// Gets or Sets CardAccountData
        /// </summary>
        [DataMember(Name="cardAccountData", EmitDefaultValue=false)]
        public CardAccountDataOutbound CardAccountData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenDetailDataTCCOnly {\n");
            sb.Append("  AccountHolderData: ").Append(AccountHolderData).Append("\n");
            sb.Append("  PaymentAccountReference: ").Append(PaymentAccountReference).Append("\n");
            sb.Append("  CardAccountData: ").Append(CardAccountData).Append("\n");
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
            return this.Equals(input as TokenDetailDataTCCOnly);
        }

        /// <summary>
        /// Returns true if TokenDetailDataTCCOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenDetailDataTCCOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenDetailDataTCCOnly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountHolderData == input.AccountHolderData ||
                    (this.AccountHolderData != null &&
                    this.AccountHolderData.Equals(input.AccountHolderData))
                ) && 
                (
                    this.PaymentAccountReference == input.PaymentAccountReference ||
                    (this.PaymentAccountReference != null &&
                    this.PaymentAccountReference.Equals(input.PaymentAccountReference))
                ) && 
                (
                    this.CardAccountData == input.CardAccountData ||
                    (this.CardAccountData != null &&
                    this.CardAccountData.Equals(input.CardAccountData))
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
                if (this.AccountHolderData != null)
                    hashCode = hashCode * 59 + this.AccountHolderData.GetHashCode();
                if (this.PaymentAccountReference != null)
                    hashCode = hashCode * 59 + this.PaymentAccountReference.GetHashCode();
                if (this.CardAccountData != null)
                    hashCode = hashCode * 59 + this.CardAccountData.GetHashCode();
                return hashCode;
            }
        }
    }

}
