# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetRelationUkSettingHeaders(TeaModel):
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


class GetRelationUkSettingRequest(TeaModel):
    def __init__(
        self,
        relation_type: str = None,
    ):
        self.relation_type = relation_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.relation_type is not None:
            result['relationType'] = self.relation_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('relationType') is not None:
            self.relation_type = m.get('relationType')
        return self


class GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        field_id: str = None,
    ):
        self.biz_alias = biz_alias
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class GetRelationUkSettingResponseBodyResultFormUkSettings(TeaModel):
    def __init__(
        self,
        field_list: List[GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList] = None,
    ):
        self.field_list = field_list

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList()
                self.field_list.append(temp_model.from_map(k))
        return self


class GetRelationUkSettingResponseBodyResult(TeaModel):
    def __init__(
        self,
        form_uk_settings: List[GetRelationUkSettingResponseBodyResultFormUkSettings] = None,
        header_field_ids: List[str] = None,
    ):
        self.form_uk_settings = form_uk_settings
        self.header_field_ids = header_field_ids

    def validate(self):
        if self.form_uk_settings:
            for k in self.form_uk_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['formUkSettings'] = []
        if self.form_uk_settings is not None:
            for k in self.form_uk_settings:
                result['formUkSettings'].append(k.to_map() if k else None)
        if self.header_field_ids is not None:
            result['headerFieldIds'] = self.header_field_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.form_uk_settings = []
        if m.get('formUkSettings') is not None:
            for k in m.get('formUkSettings'):
                temp_model = GetRelationUkSettingResponseBodyResultFormUkSettings()
                self.form_uk_settings.append(temp_model.from_map(k))
        if m.get('headerFieldIds') is not None:
            self.header_field_ids = m.get('headerFieldIds')
        return self


class GetRelationUkSettingResponseBody(TeaModel):
    def __init__(
        self,
        result: GetRelationUkSettingResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetRelationUkSettingResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetRelationUkSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRelationUkSettingResponseBody = None,
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
            temp_model = GetRelationUkSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


