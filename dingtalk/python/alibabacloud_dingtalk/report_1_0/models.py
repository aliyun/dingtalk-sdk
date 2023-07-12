# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateTemplatesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateTemplatesRequestFieldsDataValueOpenInfo(TeaModel):
    def __init__(
        self,
        attribute: Dict[str, str] = None,
        open_id: str = None,
    ):
        self.attribute = attribute
        self.open_id = open_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attribute is not None:
            result['attribute'] = self.attribute
        if self.open_id is not None:
            result['openId'] = self.open_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attribute') is not None:
            self.attribute = m.get('attribute')
        if m.get('openId') is not None:
            self.open_id = m.get('openId')
        return self


class CreateTemplatesRequestFieldsDataValue(TeaModel):
    def __init__(
        self,
        open_info: CreateTemplatesRequestFieldsDataValueOpenInfo = None,
        options: List[str] = None,
        placeholder: str = None,
    ):
        self.open_info = open_info
        self.options = options
        self.placeholder = placeholder

    def validate(self):
        if self.open_info:
            self.open_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_info is not None:
            result['openInfo'] = self.open_info.to_map()
        if self.options is not None:
            result['options'] = self.options
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openInfo') is not None:
            temp_model = CreateTemplatesRequestFieldsDataValueOpenInfo()
            self.open_info = temp_model.from_map(m['openInfo'])
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        return self


class CreateTemplatesRequestFields(TeaModel):
    def __init__(
        self,
        data_type: int = None,
        data_value: CreateTemplatesRequestFieldsDataValue = None,
        field_name: str = None,
        need: bool = None,
        order: int = None,
        sort: int = None,
    ):
        self.data_type = data_type
        self.data_value = data_value
        self.field_name = field_name
        self.need = need
        self.order = order
        self.sort = sort

    def validate(self):
        if self.data_value:
            self.data_value.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.data_value is not None:
            result['dataValue'] = self.data_value.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.need is not None:
            result['need'] = self.need
        if self.order is not None:
            result['order'] = self.order
        if self.sort is not None:
            result['sort'] = self.sort
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('dataValue') is not None:
            temp_model = CreateTemplatesRequestFieldsDataValue()
            self.data_value = temp_model.from_map(m['dataValue'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('need') is not None:
            self.need = m.get('need')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('sort') is not None:
            self.sort = m.get('sort')
        return self


class CreateTemplatesRequest(TeaModel):
    def __init__(
        self,
        allow_add_receivers: bool = None,
        allow_edit: bool = None,
        allow_get_location: bool = None,
        auth_dept_ids: List[str] = None,
        auth_user_ids: List[str] = None,
        creator: str = None,
        default_received_cids: List[str] = None,
        default_received_master_levels: List[str] = None,
        default_receivers: List[str] = None,
        fields: List[CreateTemplatesRequestFields] = None,
        logo: str = None,
        max_word_count: int = None,
        min_word_count: int = None,
        name: str = None,
        template_managers: List[str] = None,
    ):
        self.allow_add_receivers = allow_add_receivers
        self.allow_edit = allow_edit
        self.allow_get_location = allow_get_location
        self.auth_dept_ids = auth_dept_ids
        self.auth_user_ids = auth_user_ids
        self.creator = creator
        self.default_received_cids = default_received_cids
        self.default_received_master_levels = default_received_master_levels
        self.default_receivers = default_receivers
        self.fields = fields
        self.logo = logo
        self.max_word_count = max_word_count
        self.min_word_count = min_word_count
        self.name = name
        self.template_managers = template_managers

    def validate(self):
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_add_receivers is not None:
            result['allowAddReceivers'] = self.allow_add_receivers
        if self.allow_edit is not None:
            result['allowEdit'] = self.allow_edit
        if self.allow_get_location is not None:
            result['allowGetLocation'] = self.allow_get_location
        if self.auth_dept_ids is not None:
            result['authDeptIds'] = self.auth_dept_ids
        if self.auth_user_ids is not None:
            result['authUserIds'] = self.auth_user_ids
        if self.creator is not None:
            result['creator'] = self.creator
        if self.default_received_cids is not None:
            result['defaultReceivedCids'] = self.default_received_cids
        if self.default_received_master_levels is not None:
            result['defaultReceivedMasterLevels'] = self.default_received_master_levels
        if self.default_receivers is not None:
            result['defaultReceivers'] = self.default_receivers
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.logo is not None:
            result['logo'] = self.logo
        if self.max_word_count is not None:
            result['maxWordCount'] = self.max_word_count
        if self.min_word_count is not None:
            result['minWordCount'] = self.min_word_count
        if self.name is not None:
            result['name'] = self.name
        if self.template_managers is not None:
            result['templateManagers'] = self.template_managers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowAddReceivers') is not None:
            self.allow_add_receivers = m.get('allowAddReceivers')
        if m.get('allowEdit') is not None:
            self.allow_edit = m.get('allowEdit')
        if m.get('allowGetLocation') is not None:
            self.allow_get_location = m.get('allowGetLocation')
        if m.get('authDeptIds') is not None:
            self.auth_dept_ids = m.get('authDeptIds')
        if m.get('authUserIds') is not None:
            self.auth_user_ids = m.get('authUserIds')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('defaultReceivedCids') is not None:
            self.default_received_cids = m.get('defaultReceivedCids')
        if m.get('defaultReceivedMasterLevels') is not None:
            self.default_received_master_levels = m.get('defaultReceivedMasterLevels')
        if m.get('defaultReceivers') is not None:
            self.default_receivers = m.get('defaultReceivers')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = CreateTemplatesRequestFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('logo') is not None:
            self.logo = m.get('logo')
        if m.get('maxWordCount') is not None:
            self.max_word_count = m.get('maxWordCount')
        if m.get('minWordCount') is not None:
            self.min_word_count = m.get('minWordCount')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('templateManagers') is not None:
            self.template_managers = m.get('templateManagers')
        return self


class CreateTemplatesResponseBody(TeaModel):
    def __init__(
        self,
        template_id: str = None,
    ):
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class CreateTemplatesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTemplatesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateTemplatesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


