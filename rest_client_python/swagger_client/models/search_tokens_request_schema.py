# coding: utf-8

"""
    MDES for Merchants

    The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.    # noqa: E501

    OpenAPI spec version: 1.2.7
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from swagger_client.models.card_info import CardInfo  # noqa: F401,E501


class SearchTokensRequestSchema(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'request_id': 'str',
        'response_host': 'str',
        'card_info': 'CardInfo',
        'token_requestor_id': 'str'
    }

    attribute_map = {
        'request_id': 'requestId',
        'response_host': 'responseHost',
        'card_info': 'cardInfo',
        'token_requestor_id': 'tokenRequestorId'
    }

    def __init__(self, request_id=None, response_host=None, card_info=None, token_requestor_id=None):  # noqa: E501
        """SearchTokensRequestSchema - a model defined in Swagger"""  # noqa: E501

        self._request_id = None
        self._response_host = None
        self._card_info = None
        self._token_requestor_id = None
        self.discriminator = None

        self.request_id = request_id
        if response_host is not None:
            self.response_host = response_host
        if card_info is not None:
            self.card_info = card_info
        if token_requestor_id is not None:
            self.token_requestor_id = token_requestor_id

    @property
    def request_id(self):
        """Gets the request_id of this SearchTokensRequestSchema.  # noqa: E501

        Unique identifier for the request.   # noqa: E501

        :return: The request_id of this SearchTokensRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._request_id

    @request_id.setter
    def request_id(self, request_id):
        """Sets the request_id of this SearchTokensRequestSchema.

        Unique identifier for the request.   # noqa: E501

        :param request_id: The request_id of this SearchTokensRequestSchema.  # noqa: E501
        :type: str
        """
        if request_id is None:
            raise ValueError("Invalid value for `request_id`, must not be `None`")  # noqa: E501

        self._request_id = request_id

    @property
    def response_host(self):
        """Gets the response_host of this SearchTokensRequestSchema.  # noqa: E501

        The host that originated the request. Future calls in the same conversation may be routed to this host.   # noqa: E501

        :return: The response_host of this SearchTokensRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._response_host

    @response_host.setter
    def response_host(self, response_host):
        """Sets the response_host of this SearchTokensRequestSchema.

        The host that originated the request. Future calls in the same conversation may be routed to this host.   # noqa: E501

        :param response_host: The response_host of this SearchTokensRequestSchema.  # noqa: E501
        :type: str
        """

        self._response_host = response_host

    @property
    def card_info(self):
        """Gets the card_info of this SearchTokensRequestSchema.  # noqa: E501


        :return: The card_info of this SearchTokensRequestSchema.  # noqa: E501
        :rtype: CardInfo
        """
        return self._card_info

    @card_info.setter
    def card_info(self, card_info):
        """Sets the card_info of this SearchTokensRequestSchema.


        :param card_info: The card_info of this SearchTokensRequestSchema.  # noqa: E501
        :type: CardInfo
        """

        self._card_info = card_info

    @property
    def token_requestor_id(self):
        """Gets the token_requestor_id of this SearchTokensRequestSchema.  # noqa: E501

        Identifies the Token Requestor. Only tokens associated with the token requestor will be returned. Length - 11.    # noqa: E501

        :return: The token_requestor_id of this SearchTokensRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._token_requestor_id

    @token_requestor_id.setter
    def token_requestor_id(self, token_requestor_id):
        """Sets the token_requestor_id of this SearchTokensRequestSchema.

        Identifies the Token Requestor. Only tokens associated with the token requestor will be returned. Length - 11.    # noqa: E501

        :param token_requestor_id: The token_requestor_id of this SearchTokensRequestSchema.  # noqa: E501
        :type: str
        """

        self._token_requestor_id = token_requestor_id

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(SearchTokensRequestSchema, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, SearchTokensRequestSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other