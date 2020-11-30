# coding: utf-8

"""
    Handelsregister bevragen

    D.m.v. deze toepassing worden meerdere, korte bevragingen op het Handelsregister beschikbaar gesteld.  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class HalPaginationLinksPrevious(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'href': 'str',
        'templated': 'bool',
        'title': 'str'
    }

    attribute_map = {
        'href': 'href',
        'templated': 'templated',
        'title': 'title'
    }

    def __init__(self, href=None, templated=None, title=None, local_vars_configuration=None):  # noqa: E501
        """HalPaginationLinksPrevious - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._href = None
        self._templated = None
        self._title = None
        self.discriminator = None

        if href is not None:
            self.href = href
        if templated is not None:
            self.templated = templated
        if title is not None:
            self.title = title

    @property
    def href(self):
        """Gets the href of this HalPaginationLinksPrevious.  # noqa: E501


        :return: The href of this HalPaginationLinksPrevious.  # noqa: E501
        :rtype: str
        """
        return self._href

    @href.setter
    def href(self, href):
        """Sets the href of this HalPaginationLinksPrevious.


        :param href: The href of this HalPaginationLinksPrevious.  # noqa: E501
        :type: str
        """

        self._href = href

    @property
    def templated(self):
        """Gets the templated of this HalPaginationLinksPrevious.  # noqa: E501


        :return: The templated of this HalPaginationLinksPrevious.  # noqa: E501
        :rtype: bool
        """
        return self._templated

    @templated.setter
    def templated(self, templated):
        """Sets the templated of this HalPaginationLinksPrevious.


        :param templated: The templated of this HalPaginationLinksPrevious.  # noqa: E501
        :type: bool
        """

        self._templated = templated

    @property
    def title(self):
        """Gets the title of this HalPaginationLinksPrevious.  # noqa: E501


        :return: The title of this HalPaginationLinksPrevious.  # noqa: E501
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title):
        """Sets the title of this HalPaginationLinksPrevious.


        :param title: The title of this HalPaginationLinksPrevious.  # noqa: E501
        :type: str
        """

        self._title = title

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
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

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, HalPaginationLinksPrevious):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, HalPaginationLinksPrevious):
            return True

        return self.to_dict() != other.to_dict()
