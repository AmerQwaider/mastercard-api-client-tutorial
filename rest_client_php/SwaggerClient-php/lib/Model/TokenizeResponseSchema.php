<?php
/**
 * TokenizeResponseSchema
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.
 *
 * OpenAPI spec version: 1.2.7
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 2.4.0-SNAPSHOT
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * TokenizeResponseSchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TokenizeResponseSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'TokenizeResponseSchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'response_host' => 'string',
        'response_id' => 'string',
        'decision' => 'string',
        'authentication_methods' => '\Swagger\Client\Model\AuthenticationMethods[]',
        'token_unique_reference' => 'string',
        'pan_unique_reference' => 'string',
        'product_config' => '\Swagger\Client\Model\ProductConfig',
        'token_info' => '\Swagger\Client\Model\TokenInfo',
        'token_detail' => '\Swagger\Client\Model\TokenDetailTokenizeResponse',
        'error_code' => 'string',
        'error_description' => 'string',
        'errors' => '\Swagger\Client\Model\Error'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'response_host' => null,
        'response_id' => null,
        'decision' => null,
        'authentication_methods' => null,
        'token_unique_reference' => null,
        'pan_unique_reference' => null,
        'product_config' => null,
        'token_info' => null,
        'token_detail' => null,
        'error_code' => null,
        'error_description' => null,
        'errors' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'response_host' => 'responseHost',
        'response_id' => 'responseId',
        'decision' => 'decision',
        'authentication_methods' => 'authenticationMethods',
        'token_unique_reference' => 'tokenUniqueReference',
        'pan_unique_reference' => 'panUniqueReference',
        'product_config' => 'productConfig',
        'token_info' => 'tokenInfo',
        'token_detail' => 'tokenDetail',
        'error_code' => 'errorCode',
        'error_description' => 'errorDescription',
        'errors' => 'errors'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'response_host' => 'setResponseHost',
        'response_id' => 'setResponseId',
        'decision' => 'setDecision',
        'authentication_methods' => 'setAuthenticationMethods',
        'token_unique_reference' => 'setTokenUniqueReference',
        'pan_unique_reference' => 'setPanUniqueReference',
        'product_config' => 'setProductConfig',
        'token_info' => 'setTokenInfo',
        'token_detail' => 'setTokenDetail',
        'error_code' => 'setErrorCode',
        'error_description' => 'setErrorDescription',
        'errors' => 'setErrors'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'response_host' => 'getResponseHost',
        'response_id' => 'getResponseId',
        'decision' => 'getDecision',
        'authentication_methods' => 'getAuthenticationMethods',
        'token_unique_reference' => 'getTokenUniqueReference',
        'pan_unique_reference' => 'getPanUniqueReference',
        'product_config' => 'getProductConfig',
        'token_info' => 'getTokenInfo',
        'token_detail' => 'getTokenDetail',
        'error_code' => 'getErrorCode',
        'error_description' => 'getErrorDescription',
        'errors' => 'getErrors'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['response_host'] = isset($data['response_host']) ? $data['response_host'] : null;
        $this->container['response_id'] = isset($data['response_id']) ? $data['response_id'] : null;
        $this->container['decision'] = isset($data['decision']) ? $data['decision'] : null;
        $this->container['authentication_methods'] = isset($data['authentication_methods']) ? $data['authentication_methods'] : null;
        $this->container['token_unique_reference'] = isset($data['token_unique_reference']) ? $data['token_unique_reference'] : null;
        $this->container['pan_unique_reference'] = isset($data['pan_unique_reference']) ? $data['pan_unique_reference'] : null;
        $this->container['product_config'] = isset($data['product_config']) ? $data['product_config'] : null;
        $this->container['token_info'] = isset($data['token_info']) ? $data['token_info'] : null;
        $this->container['token_detail'] = isset($data['token_detail']) ? $data['token_detail'] : null;
        $this->container['error_code'] = isset($data['error_code']) ? $data['error_code'] : null;
        $this->container['error_description'] = isset($data['error_description']) ? $data['error_description'] : null;
        $this->container['errors'] = isset($data['errors']) ? $data['errors'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets response_host
     *
     * @return string
     */
    public function getResponseHost()
    {
        return $this->container['response_host'];
    }

    /**
     * Sets response_host
     *
     * @param string $response_host The MasterCard host that originated the request. Future calls in the same conversation may be routed to this host.
     *
     * @return $this
     */
    public function setResponseHost($response_host)
    {
        $this->container['response_host'] = $response_host;

        return $this;
    }

    /**
     * Gets response_id
     *
     * @return string
     */
    public function getResponseId()
    {
        return $this->container['response_id'];
    }

    /**
     * Sets response_id
     *
     * @param string $response_id Unique identifier for the response.
     *
     * @return $this
     */
    public function setResponseId($response_id)
    {
        $this->container['response_id'] = $response_id;

        return $this;
    }

    /**
     * Gets decision
     *
     * @return string
     */
    public function getDecision()
    {
        return $this->container['decision'];
    }

    /**
     * Sets decision
     *
     * @param string $decision The tokenization decision for this digitization request. Must be either APPROVED (Digitization request was approved), DECLINED (Digitization request was declined) OR REQUIRE_ADDITIONAL_AUTHENTICATION Digitization request was approved but optionally requires additional authentication. One or more Authentication methods may be provided).
     *
     * @return $this
     */
    public function setDecision($decision)
    {
        $this->container['decision'] = $decision;

        return $this;
    }

    /**
     * Gets authentication_methods
     *
     * @return \Swagger\Client\Model\AuthenticationMethods[]
     */
    public function getAuthenticationMethods()
    {
        return $this->container['authentication_methods'];
    }

    /**
     * Sets authentication_methods
     *
     * @param \Swagger\Client\Model\AuthenticationMethods[] $authentication_methods authentication_methods
     *
     * @return $this
     */
    public function setAuthenticationMethods($authentication_methods)
    {
        $this->container['authentication_methods'] = $authentication_methods;

        return $this;
    }

    /**
     * Gets token_unique_reference
     *
     * @return string
     */
    public function getTokenUniqueReference()
    {
        return $this->container['token_unique_reference'];
    }

    /**
     * Sets token_unique_reference
     *
     * @param string $token_unique_reference The unique reference allocated to the new Token. Serves as a unique identifier for all subsequent queries or management functions relating to this Token. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.    __Max Length:64__
     *
     * @return $this
     */
    public function setTokenUniqueReference($token_unique_reference)
    {
        $this->container['token_unique_reference'] = $token_unique_reference;

        return $this;
    }

    /**
     * Gets pan_unique_reference
     *
     * @return string
     */
    public function getPanUniqueReference()
    {
        return $this->container['pan_unique_reference'];
    }

    /**
     * Sets pan_unique_reference
     *
     * @param string $pan_unique_reference The unique reference allocated to the Account Primary Account Number. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.  __Max Length:64__
     *
     * @return $this
     */
    public function setPanUniqueReference($pan_unique_reference)
    {
        $this->container['pan_unique_reference'] = $pan_unique_reference;

        return $this;
    }

    /**
     * Gets product_config
     *
     * @return \Swagger\Client\Model\ProductConfig
     */
    public function getProductConfig()
    {
        return $this->container['product_config'];
    }

    /**
     * Sets product_config
     *
     * @param \Swagger\Client\Model\ProductConfig $product_config product_config
     *
     * @return $this
     */
    public function setProductConfig($product_config)
    {
        $this->container['product_config'] = $product_config;

        return $this;
    }

    /**
     * Gets token_info
     *
     * @return \Swagger\Client\Model\TokenInfo
     */
    public function getTokenInfo()
    {
        return $this->container['token_info'];
    }

    /**
     * Sets token_info
     *
     * @param \Swagger\Client\Model\TokenInfo $token_info token_info
     *
     * @return $this
     */
    public function setTokenInfo($token_info)
    {
        $this->container['token_info'] = $token_info;

        return $this;
    }

    /**
     * Gets token_detail
     *
     * @return \Swagger\Client\Model\TokenDetailTokenizeResponse
     */
    public function getTokenDetail()
    {
        return $this->container['token_detail'];
    }

    /**
     * Sets token_detail
     *
     * @param \Swagger\Client\Model\TokenDetailTokenizeResponse $token_detail token_detail
     *
     * @return $this
     */
    public function setTokenDetail($token_detail)
    {
        $this->container['token_detail'] = $token_detail;

        return $this;
    }

    /**
     * Gets error_code
     *
     * @return string
     */
    public function getErrorCode()
    {
        return $this->container['error_code'];
    }

    /**
     * Sets error_code
     *
     * @param string $error_code __CONDITIONAL__<br> Returned in the event of and error and contains the reason the operation failed. Only use if errors object is not present.<br> __Max Length: 32__
     *
     * @return $this
     */
    public function setErrorCode($error_code)
    {
        $this->container['error_code'] = $error_code;

        return $this;
    }

    /**
     * Gets error_description
     *
     * @return string
     */
    public function getErrorDescription()
    {
        return $this->container['error_description'];
    }

    /**
     * Sets error_description
     *
     * @param string $error_description __CONDITIONAL__<br> Returned in the event of and error and contains a description of why the operation failed. Only use if errors object is not present.<br> __Max Length: 32__
     *
     * @return $this
     */
    public function setErrorDescription($error_description)
    {
        $this->container['error_description'] = $error_description;

        return $this;
    }

    /**
     * Gets errors
     *
     * @return \Swagger\Client\Model\Error
     */
    public function getErrors()
    {
        return $this->container['errors'];
    }

    /**
     * Sets errors
     *
     * @param \Swagger\Client\Model\Error $errors errors
     *
     * @return $this
     */
    public function setErrors($errors)
    {
        $this->container['errors'] = $errors;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}

