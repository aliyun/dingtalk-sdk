# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class SyncDataHeaders(TeaModel):
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


class SyncDataRequest(TeaModel):
    def __init__(
        self,
        project_id: str = None,
        schema_id: str = None,
        data_id: str = None,
        content: str = None,
        etl_time: str = None,
    ):
        self.project_id = project_id
        self.schema_id = schema_id
        self.data_id = data_id
        self.content = content
        self.etl_time = etl_time

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.schema_id is not None:
            result['schemaId'] = self.schema_id
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.content is not None:
            result['content'] = self.content
        if self.etl_time is not None:
            result['etlTime'] = self.etl_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('schemaId') is not None:
            self.schema_id = m.get('schemaId')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('etlTime') is not None:
            self.etl_time = m.get('etlTime')
        return self


class SyncDataResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SyncDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncDataResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = SyncDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


