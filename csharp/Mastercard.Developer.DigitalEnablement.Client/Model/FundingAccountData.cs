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
    /// FundingAccountData
    /// </summary>
    [DataContract]
    public partial class FundingAccountData :  IEquatable<FundingAccountData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingAccountData" /> class.
        /// </summary>
        /// <param name="cardAccountData">cardAccountData.</param>
        /// <param name="accountHolderData">accountHolderData.</param>
        /// <param name="source">(__Required as minimum for Tokenization__)  The source of the account. Must be one of   * ACCOUNT_ON_FILE   * ACCOUNT_ADDED_MANUALLY   * ACCOUNT_ADDED_VIA_APPLICATION  __Max Length:32__ .</param>
        public FundingAccountData(CardAccountDataInbound cardAccountData = default(CardAccountDataInbound), AccountHolderData accountHolderData = default(AccountHolderData), string source = default(string))
        {
            this.CardAccountData = cardAccountData;
            this.AccountHolderData = accountHolderData;
            this.Source = source;
        }
        
        /// <summary>
        /// Gets or Sets CardAccountData
        /// </summary>
        [DataMember(Name="cardAccountData", EmitDefaultValue=false)]
        public CardAccountDataInbound CardAccountData { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolderData
        /// </summary>
        [DataMember(Name="accountHolderData", EmitDefaultValue=false)]
        public AccountHolderData AccountHolderData { get; set; }

        /// <summary>
        /// (__Required as minimum for Tokenization__)  The source of the account. Must be one of   * ACCOUNT_ON_FILE   * ACCOUNT_ADDED_MANUALLY   * ACCOUNT_ADDED_VIA_APPLICATION  __Max Length:32__ 
        /// </summary>
        /// <value>(__Required as minimum for Tokenization__)  The source of the account. Must be one of   * ACCOUNT_ON_FILE   * ACCOUNT_ADDED_MANUALLY   * ACCOUNT_ADDED_VIA_APPLICATION  __Max Length:32__ </value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingAccountData {\n");
            sb.Append("  CardAccountData: ").Append(CardAccountData).Append("\n");
            sb.Append("  AccountHolderData: ").Append(AccountHolderData).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as FundingAccountData);
        }

        /// <summary>
        /// Returns true if FundingAccountData instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingAccountData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingAccountData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardAccountData == input.CardAccountData ||
                    (this.CardAccountData != null &&
                    this.CardAccountData.Equals(input.CardAccountData))
                ) && 
                (
                    this.AccountHolderData == input.AccountHolderData ||
                    (this.AccountHolderData != null &&
                    this.AccountHolderData.Equals(input.AccountHolderData))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.CardAccountData != null)
                    hashCode = hashCode * 59 + this.CardAccountData.GetHashCode();
                if (this.AccountHolderData != null)
                    hashCode = hashCode * 59 + this.AccountHolderData.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }

}
