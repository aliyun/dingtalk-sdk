# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetJobAuthHeaders(TeaModel):
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


class GetJobAuthRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GetJobAuthResponseBodyJobOwners(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
    ):
        # 员工标识
        self.user_id = user_id
        # 员工姓名
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetJobAuthResponseBody(TeaModel):
    def __init__(
        self,
        job_id: str = None,
        job_owners: List[GetJobAuthResponseBodyJobOwners] = None,
    ):
        # 职位ID
        self.job_id = job_id
        # 职位负责人
        self.job_owners = job_owners

    def validate(self):
        if self.job_owners:
            for k in self.job_owners:
                if k:
                    k.validate()

    def to_map(self):
        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        result['jobOwners'] = []
        if self.job_owners is not None:
            for k in self.job_owners:
                result['jobOwners'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        self.job_owners = []
        if m.get('jobOwners') is not None:
            for k in m.get('jobOwners'):
                temp_model = GetJobAuthResponseBodyJobOwners()
                self.job_owners.append(temp_model.from_map(k))
        return self


class GetJobAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetJobAuthResponseBody = None,
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
            temp_model = GetJobAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


