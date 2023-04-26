# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetTranscribeBriefHeaders(TeaModel):
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


class GetTranscribeBriefResponseBodyData(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
    ):
        self.biz_type = biz_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        return self


class GetTranscribeBriefResponseBody(TeaModel):
    def __init__(
        self,
        data: GetTranscribeBriefResponseBodyData = None,
        status_code: int = None,
        success: bool = None,
    ):
        self.data = data
        self.status_code = status_code
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetTranscribeBriefResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetTranscribeBriefResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTranscribeBriefResponseBody = None,
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
            temp_model = GetTranscribeBriefResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemovePermissionHeaders(TeaModel):
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


class RemovePermissionRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: int = None,
        member_type: str = None,
        policy_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.policy_type = policy_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.policy_type is not None:
            result['policyType'] = self.policy_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('policyType') is not None:
            self.policy_type = m.get('policyType')
        return self


class RemovePermissionRequest(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        members: List[RemovePermissionRequestMembers] = None,
        task_creator: int = None,
        task_id: int = None,
    ):
        self.biz_type = biz_type
        self.members = members
        self.task_creator = task_creator
        self.task_id = task_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.task_creator is not None:
            result['taskCreator'] = self.task_creator
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = RemovePermissionRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('taskCreator') is not None:
            self.task_creator = m.get('taskCreator')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class RemovePermissionResponseBodyData(TeaModel):
    def __init__(
        self,
        fail_name_list: List[str] = None,
    ):
        self.fail_name_list = fail_name_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_name_list is not None:
            result['failNameList'] = self.fail_name_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failNameList') is not None:
            self.fail_name_list = m.get('failNameList')
        return self


class RemovePermissionResponseBody(TeaModel):
    def __init__(
        self,
        data: RemovePermissionResponseBodyData = None,
        status_code: int = None,
        success: bool = None,
    ):
        self.data = data
        self.status_code = status_code
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = RemovePermissionResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RemovePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemovePermissionResponseBody = None,
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
            temp_model = RemovePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePermissionForUsersHeaders(TeaModel):
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


class UpdatePermissionForUsersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: int = None,
        member_type: str = None,
        policy_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.policy_type = policy_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.policy_type is not None:
            result['policyType'] = self.policy_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('policyType') is not None:
            self.policy_type = m.get('policyType')
        return self


class UpdatePermissionForUsersRequest(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        members: List[UpdatePermissionForUsersRequestMembers] = None,
        task_creator: int = None,
        operator_uid: int = None,
    ):
        self.biz_type = biz_type
        self.members = members
        self.task_creator = task_creator
        self.operator_uid = operator_uid

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.task_creator is not None:
            result['taskCreator'] = self.task_creator
        if self.operator_uid is not None:
            result['operatorUid'] = self.operator_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = UpdatePermissionForUsersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('taskCreator') is not None:
            self.task_creator = m.get('taskCreator')
        if m.get('operatorUid') is not None:
            self.operator_uid = m.get('operatorUid')
        return self


class UpdatePermissionForUsersResponseBody(TeaModel):
    def __init__(
        self,
        is_success: bool = None,
    ):
        self.is_success = is_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_success is not None:
            result['isSuccess'] = self.is_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccess') is not None:
            self.is_success = m.get('isSuccess')
        return self


class UpdatePermissionForUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdatePermissionForUsersResponseBody = None,
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
            temp_model = UpdatePermissionForUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


