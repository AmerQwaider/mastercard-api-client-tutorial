/*
 * MDES for Merchants
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * OpenAPI spec version: 1.2.7
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.client.model.CardInfo;
import io.swagger.client.model.DecisioningData;
import java.io.IOException;

/**
 * TokenizeRequestSchema
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2019-05-29T13:19:04.981+01:00")
public class TokenizeRequestSchema {
  @SerializedName("responseHost")
  private String responseHost = null;

  @SerializedName("requestId")
  private String requestId = null;

  @SerializedName("tokenType")
  private String tokenType = null;

  @SerializedName("tokenRequestorId")
  private String tokenRequestorId = null;

  @SerializedName("taskId")
  private String taskId = null;

  @SerializedName("cardInfo")
  private CardInfo cardInfo = null;

  @SerializedName("consumerLanguage")
  private String consumerLanguage = null;

  @SerializedName("tokenizationAuthenticationValue")
  private String tokenizationAuthenticationValue = null;

  @SerializedName("decisioningData")
  private DecisioningData decisioningData = null;

  public TokenizeRequestSchema responseHost(String responseHost) {
    this.responseHost = responseHost;
    return this;
  }

   /**
   * \&quot;The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\&quot; 
   * @return responseHost
  **/
  @ApiModelProperty(example = "site1.your-server.com", value = "\"The host that originated the request. Future calls in the same conversation may be routed to this host. Must be provided as: host[:port][/contextRoot] Where port and contextRoot are optional. If contextRoot is not provided, the default (per the URL Scheme) is assumed and must be used.\" ")
  public String getResponseHost() {
    return responseHost;
  }

  public void setResponseHost(String responseHost) {
    this.responseHost = responseHost;
  }

  public TokenizeRequestSchema requestId(String requestId) {
    this.requestId = requestId;
    return this;
  }

   /**
   * Unique identifier for the request. 
   * @return requestId
  **/
  @ApiModelProperty(example = "123456", value = "Unique identifier for the request. ")
  public String getRequestId() {
    return requestId;
  }

  public void setRequestId(String requestId) {
    this.requestId = requestId;
  }

  public TokenizeRequestSchema tokenType(String tokenType) {
    this.tokenType = tokenType;
    return this;
  }

   /**
   * The type of Token requested. Must be CLOUD       __Max Length:32__    
   * @return tokenType
  **/
  @ApiModelProperty(example = "CLOUD", required = true, value = "The type of Token requested. Must be CLOUD       __Max Length:32__    ")
  public String getTokenType() {
    return tokenType;
  }

  public void setTokenType(String tokenType) {
    this.tokenType = tokenType;
  }

  public TokenizeRequestSchema tokenRequestorId(String tokenRequestorId) {
    this.tokenRequestorId = tokenRequestorId;
    return this;
  }

   /**
   * Identifies the Token Requestor       __Max Length:11__  
   * @return tokenRequestorId
  **/
  @ApiModelProperty(example = "98765432101", required = true, value = "Identifies the Token Requestor       __Max Length:11__  ")
  public String getTokenRequestorId() {
    return tokenRequestorId;
  }

  public void setTokenRequestorId(String tokenRequestorId) {
    this.tokenRequestorId = tokenRequestorId;
  }

  public TokenizeRequestSchema taskId(String taskId) {
    this.taskId = taskId;
    return this;
  }

   /**
   * Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task.      __Max Length:64__ 
   * @return taskId
  **/
  @ApiModelProperty(example = "123456", required = true, value = "Identifier for this task as assigned by the Token Requestor, unique across a given Token Requestor Identifier. May be used in the Get Task Status API to query the status of this task.      __Max Length:64__ ")
  public String getTaskId() {
    return taskId;
  }

  public void setTaskId(String taskId) {
    this.taskId = taskId;
  }

  public TokenizeRequestSchema cardInfo(CardInfo cardInfo) {
    this.cardInfo = cardInfo;
    return this;
  }

   /**
   * Get cardInfo
   * @return cardInfo
  **/
  @ApiModelProperty(required = true, value = "")
  public CardInfo getCardInfo() {
    return cardInfo;
  }

  public void setCardInfo(CardInfo cardInfo) {
    this.cardInfo = cardInfo;
  }

  public TokenizeRequestSchema consumerLanguage(String consumerLanguage) {
    this.consumerLanguage = consumerLanguage;
    return this;
  }

   /**
   * Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code.    __Max Length:2__ 
   * @return consumerLanguage
  **/
  @ApiModelProperty(example = "en", value = "Language preference selected by the consumer. Formatted as an ISO- 639-1 two-letter language code.    __Max Length:2__ ")
  public String getConsumerLanguage() {
    return consumerLanguage;
  }

  public void setConsumerLanguage(String consumerLanguage) {
    this.consumerLanguage = consumerLanguage;
  }

  public TokenizeRequestSchema tokenizationAuthenticationValue(String tokenizationAuthenticationValue) {
    this.tokenizationAuthenticationValue = tokenizationAuthenticationValue;
    return this;
  }

   /**
   * The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request.      __Max Length:2048__ 
   * @return tokenizationAuthenticationValue
  **/
  @ApiModelProperty(example = "RHVtbXkgYmFzZSA2NCBkYXRhIC0gdGhpcyBpcyBub3QgYSByZWFsIFRBViBleGFtcGxl", value = "The Tokenization Authentication Value (TAV) as cryptographically signed by the Issuer to authorize this digitization request.      __Max Length:2048__ ")
  public String getTokenizationAuthenticationValue() {
    return tokenizationAuthenticationValue;
  }

  public void setTokenizationAuthenticationValue(String tokenizationAuthenticationValue) {
    this.tokenizationAuthenticationValue = tokenizationAuthenticationValue;
  }

  public TokenizeRequestSchema decisioningData(DecisioningData decisioningData) {
    this.decisioningData = decisioningData;
    return this;
  }

   /**
   * Get decisioningData
   * @return decisioningData
  **/
  @ApiModelProperty(value = "")
  public DecisioningData getDecisioningData() {
    return decisioningData;
  }

  public void setDecisioningData(DecisioningData decisioningData) {
    this.decisioningData = decisioningData;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TokenizeRequestSchema tokenizeRequestSchema = (TokenizeRequestSchema) o;
    return Objects.equals(this.responseHost, tokenizeRequestSchema.responseHost) &&
        Objects.equals(this.requestId, tokenizeRequestSchema.requestId) &&
        Objects.equals(this.tokenType, tokenizeRequestSchema.tokenType) &&
        Objects.equals(this.tokenRequestorId, tokenizeRequestSchema.tokenRequestorId) &&
        Objects.equals(this.taskId, tokenizeRequestSchema.taskId) &&
        Objects.equals(this.cardInfo, tokenizeRequestSchema.cardInfo) &&
        Objects.equals(this.consumerLanguage, tokenizeRequestSchema.consumerLanguage) &&
        Objects.equals(this.tokenizationAuthenticationValue, tokenizeRequestSchema.tokenizationAuthenticationValue) &&
        Objects.equals(this.decisioningData, tokenizeRequestSchema.decisioningData);
  }

  @Override
  public int hashCode() {
    return Objects.hash(responseHost, requestId, tokenType, tokenRequestorId, taskId, cardInfo, consumerLanguage, tokenizationAuthenticationValue, decisioningData);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TokenizeRequestSchema {\n");
    
    sb.append("    responseHost: ").append(toIndentedString(responseHost)).append("\n");
    sb.append("    requestId: ").append(toIndentedString(requestId)).append("\n");
    sb.append("    tokenType: ").append(toIndentedString(tokenType)).append("\n");
    sb.append("    tokenRequestorId: ").append(toIndentedString(tokenRequestorId)).append("\n");
    sb.append("    taskId: ").append(toIndentedString(taskId)).append("\n");
    sb.append("    cardInfo: ").append(toIndentedString(cardInfo)).append("\n");
    sb.append("    consumerLanguage: ").append(toIndentedString(consumerLanguage)).append("\n");
    sb.append("    tokenizationAuthenticationValue: ").append(toIndentedString(tokenizationAuthenticationValue)).append("\n");
    sb.append("    decisioningData: ").append(toIndentedString(decisioningData)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
