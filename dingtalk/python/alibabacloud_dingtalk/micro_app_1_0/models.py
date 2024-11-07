# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddAppRolesToMemberHeaders(TeaModel):
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


class AddAppRolesToMemberRequestRoleList(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        scope_version: int = None,
    ):
        # This parameter is required.
        self.role_id = role_id
        # This parameter is required.
        self.scope_version = scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        return self


class AddAppRolesToMemberRequest(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        op_user_id: str = None,
        role_list: List[AddAppRolesToMemberRequestRoleList] = None,
    ):
        # This parameter is required.
        self.member_id = member_id
        # This parameter is required.
        self.member_type = member_type
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.role_list = role_list

    def validate(self):
        if self.role_list:
            for k in self.role_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        result['roleList'] = []
        if self.role_list is not None:
            for k in self.role_list:
                result['roleList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        self.role_list = []
        if m.get('roleList') is not None:
            for k in m.get('roleList'):
                temp_model = AddAppRolesToMemberRequestRoleList()
                self.role_list.append(temp_model.from_map(k))
        return self


class AddAppRolesToMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
        role_id: int = None,
        sub_error_code: str = None,
        sub_error_msg: str = None,
        success: bool = None,
    ):
        self.latest_scope_version = latest_scope_version
        self.role_id = role_id
        self.sub_error_code = sub_error_code
        self.sub_error_msg = sub_error_msg
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.sub_error_code is not None:
            result['subErrorCode'] = self.sub_error_code
        if self.sub_error_msg is not None:
            result['subErrorMsg'] = self.sub_error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('subErrorCode') is not None:
            self.sub_error_code = m.get('subErrorCode')
        if m.get('subErrorMsg') is not None:
            self.sub_error_msg = m.get('subErrorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddAppRolesToMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: List[AddAppRolesToMemberResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = AddAppRolesToMemberResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class AddAppRolesToMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddAppRolesToMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddAppRolesToMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddAppToWorkBenchGroupHeaders(TeaModel):
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


class AddAppToWorkBenchGroupRequest(TeaModel):
    def __init__(
        self,
        component_id: str = None,
        ecological_corp_id: str = None,
        op_union_id: str = None,
    ):
        # This parameter is required.
        self.component_id = component_id
        self.ecological_corp_id = ecological_corp_id
        self.op_union_id = op_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_id is not None:
            result['componentId'] = self.component_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        return self


class AddAppToWorkBenchGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class AddAppToWorkBenchGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddAppToWorkBenchGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddAppToWorkBenchGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddMemberToAppRoleHeaders(TeaModel):
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


class AddMemberToAppRoleRequest(TeaModel):
    def __init__(
        self,
        dept_id_list: List[int] = None,
        op_user_id: str = None,
        scope_version: int = None,
        user_id_list: List[str] = None,
    ):
        self.dept_id_list = dept_id_list
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.scope_version = scope_version
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class AddMemberToAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class AddMemberToAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddMemberToAppRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddMemberToAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AnheiPResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class AnheiPResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AnheiPResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AnheiPResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AnheiTest888ResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AnheiTest888Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AnheiTest888ResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AnheiTest888ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AnheiTestBResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AnheiTestBResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AnheiTestBResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AnheiTestBResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AnheiTestNineResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AnheiTestNineResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AnheiTestNineResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AnheiTestNineResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppStatusManagerTestRequest(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AppStatusManagerTestResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AppStatusManagerTestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppStatusManagerTestResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AppStatusManagerTestResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AyunTestResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AyunTestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AyunTestResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AyunTestResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AyunTestOnlineResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class AyunTestOnlineResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AyunTestOnlineResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AyunTestOnlineResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateApaasAppHeaders(TeaModel):
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


class CreateApaasAppRequest(TeaModel):
    def __init__(
        self,
        app_desc: str = None,
        app_icon: str = None,
        app_name: str = None,
        biz_app_id: str = None,
        homepage_edit_link: str = None,
        homepage_link: str = None,
        is_short_cut: int = None,
        omp_link: str = None,
        op_user_id: str = None,
        pc_homepage_edit_link: str = None,
        pc_homepage_link: str = None,
        template_key: str = None,
    ):
        # This parameter is required.
        self.app_desc = app_desc
        # This parameter is required.
        self.app_icon = app_icon
        # This parameter is required.
        self.app_name = app_name
        # This parameter is required.
        self.biz_app_id = biz_app_id
        self.homepage_edit_link = homepage_edit_link
        # This parameter is required.
        self.homepage_link = homepage_link
        self.is_short_cut = is_short_cut
        self.omp_link = omp_link
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.pc_homepage_edit_link = pc_homepage_edit_link
        # This parameter is required.
        self.pc_homepage_link = pc_homepage_link
        self.template_key = template_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_desc is not None:
            result['appDesc'] = self.app_desc
        if self.app_icon is not None:
            result['appIcon'] = self.app_icon
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        if self.homepage_edit_link is not None:
            result['homepageEditLink'] = self.homepage_edit_link
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.is_short_cut is not None:
            result['isShortCut'] = self.is_short_cut
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.pc_homepage_edit_link is not None:
            result['pcHomepageEditLink'] = self.pc_homepage_edit_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.template_key is not None:
            result['templateKey'] = self.template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appDesc') is not None:
            self.app_desc = m.get('appDesc')
        if m.get('appIcon') is not None:
            self.app_icon = m.get('appIcon')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        if m.get('homepageEditLink') is not None:
            self.homepage_edit_link = m.get('homepageEditLink')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('isShortCut') is not None:
            self.is_short_cut = m.get('isShortCut')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('pcHomepageEditLink') is not None:
            self.pc_homepage_edit_link = m.get('pcHomepageEditLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('templateKey') is not None:
            self.template_key = m.get('templateKey')
        return self


class CreateApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_app_id: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class CreateApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateApaasAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateInnerAppHeaders(TeaModel):
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


class CreateInnerAppRequest(TeaModel):
    def __init__(
        self,
        desc: str = None,
        develop_type: int = None,
        homepage_link: str = None,
        icon: str = None,
        ip_white_list: List[str] = None,
        name: str = None,
        omp_link: str = None,
        op_union_id: str = None,
        pc_homepage_link: str = None,
        scope_type: str = None,
    ):
        # This parameter is required.
        self.desc = desc
        self.develop_type = develop_type
        self.homepage_link = homepage_link
        self.icon = icon
        self.ip_white_list = ip_white_list
        # This parameter is required.
        self.name = name
        self.omp_link = omp_link
        # This parameter is required.
        self.op_union_id = op_union_id
        self.pc_homepage_link = pc_homepage_link
        self.scope_type = scope_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.develop_type is not None:
            result['developType'] = self.develop_type
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('developType') is not None:
            self.develop_type = m.get('developType')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        return self


class CreateInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_key: str = None,
        app_secret: str = None,
    ):
        self.agent_id = agent_id
        self.app_key = app_key
        self.app_secret = app_secret

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.app_secret is not None:
            result['appSecret'] = self.app_secret
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('appSecret') is not None:
            self.app_secret = m.get('appSecret')
        return self


class CreateInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateInnerAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAppRoleHeaders(TeaModel):
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


class DeleteAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeleteAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAppRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteInnerAppHeaders(TeaModel):
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


class DeleteInnerAppRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
    ):
        # This parameter is required.
        self.op_union_id = op_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        return self


class DeleteInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteInnerAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetApaasAppHeaders(TeaModel):
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


class GetApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_app_id: str = None,
        publish_status: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.biz_app_id = biz_app_id
        # This parameter is required.
        self.publish_status = publish_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        if self.publish_status is not None:
            result['publishStatus'] = self.publish_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        if m.get('publishStatus') is not None:
            self.publish_status = m.get('publishStatus')
        return self


class GetApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetApaasAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAppResourceUseInfoHeaders(TeaModel):
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


class GetAppResourceUseInfoRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
        end_time: str = None,
        period_type: str = None,
        start_time: str = None,
    ):
        self.benefit_code = benefit_code
        self.end_time = end_time
        self.period_type = period_type
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.period_type is not None:
            result['periodType'] = self.period_type
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('periodType') is not None:
            self.period_type = m.get('periodType')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetAppResourceUseInfoResponseBody(TeaModel):
    def __init__(
        self,
        period: str = None,
        used_num: int = None,
        quota_num: int = None,
    ):
        self.period = period
        self.used_num = used_num
        self.quota_num = quota_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.period is not None:
            result['period'] = self.period
        if self.used_num is not None:
            result['usedNum'] = self.used_num
        if self.quota_num is not None:
            result['quotaNum'] = self.quota_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('usedNum') is not None:
            self.used_num = m.get('usedNum')
        if m.get('quotaNum') is not None:
            self.quota_num = m.get('quotaNum')
        return self


class GetAppResourceUseInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: List[GetAppResourceUseInfoResponseBody] = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = GetAppResourceUseInfoResponseBody()
                self.body.append(temp_model.from_map(k))
        return self


class GetAppRoleScopeByRoleIdHeaders(TeaModel):
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


class GetAppRoleScopeByRoleIdResponseBody(TeaModel):
    def __init__(
        self,
        can_manage_role: bool = None,
        dept_id_list: List[int] = None,
        role_id: int = None,
        role_name: str = None,
        scope_type: str = None,
        scope_version: str = None,
        user_id_list: List[str] = None,
    ):
        self.can_manage_role = can_manage_role
        self.dept_id_list = dept_id_list
        self.role_id = role_id
        self.role_name = role_name
        self.scope_type = scope_type
        self.scope_version = scope_version
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GetAppRoleScopeByRoleIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAppRoleScopeByRoleIdResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetAppRoleScopeByRoleIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInnerAppHeaders(TeaModel):
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


class GetInnerAppRequest(TeaModel):
    def __init__(
        self,
        ecological_corp_id: str = None,
        op_union_id: str = None,
    ):
        self.ecological_corp_id = ecological_corp_id
        self.op_union_id = op_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        return self


class GetInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_key: str = None,
        app_secret: str = None,
        desc: str = None,
        homepage_link: str = None,
        icon: str = None,
        ip_white_list: List[str] = None,
        name: str = None,
        omp_link: str = None,
        pc_homepage_link: str = None,
    ):
        self.agent_id = agent_id
        self.app_key = app_key
        # This parameter is required.
        self.app_secret = app_secret
        self.desc = desc
        self.homepage_link = homepage_link
        self.icon = icon
        self.ip_white_list = ip_white_list
        self.name = name
        self.omp_link = omp_link
        self.pc_homepage_link = pc_homepage_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.app_secret is not None:
            result['appSecret'] = self.app_secret
        if self.desc is not None:
            result['desc'] = self.desc
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('appSecret') is not None:
            self.app_secret = m.get('appSecret')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        return self


class GetInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInnerAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMicroAppScopeHeaders(TeaModel):
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


class GetMicroAppScopeResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        only_admin_visible: bool = None,
        role_ids: List[int] = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.dept_ids = dept_ids
        # This parameter is required.
        self.only_admin_visible = only_admin_visible
        # This parameter is required.
        self.role_ids = role_ids
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.only_admin_visible is not None:
            result['onlyAdminVisible'] = self.only_admin_visible
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('onlyAdminVisible') is not None:
            self.only_admin_visible = m.get('onlyAdminVisible')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetMicroAppScopeResponseBody(TeaModel):
    def __init__(
        self,
        result: GetMicroAppScopeResponseBodyResult = None,
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
            temp_model = GetMicroAppScopeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetMicroAppScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMicroAppScopeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetMicroAppScopeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMicroAppUserAccessHeaders(TeaModel):
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


class GetMicroAppUserAccessResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetMicroAppUserAccessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMicroAppUserAccessResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetMicroAppUserAccessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserAppDevAccessHeaders(TeaModel):
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


class GetUserAppDevAccessResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetUserAppDevAccessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserAppDevAccessResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetUserAppDevAccessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAllAppHeaders(TeaModel):
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


class ListAllAppResponseBodyAppList(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
        app_status: int = None,
        desc: str = None,
        develop_type: int = None,
        homepage_link: str = None,
        icon: str = None,
        name: str = None,
        omp_link: str = None,
        pc_homepage_link: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.app_status = app_status
        self.desc = desc
        # This parameter is required.
        self.develop_type = develop_type
        self.homepage_link = homepage_link
        self.icon = icon
        self.name = name
        self.omp_link = omp_link
        self.pc_homepage_link = pc_homepage_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.desc is not None:
            result['desc'] = self.desc
        if self.develop_type is not None:
            result['developType'] = self.develop_type
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('developType') is not None:
            self.develop_type = m.get('developType')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        return self


class ListAllAppResponseBody(TeaModel):
    def __init__(
        self,
        app_list: List[ListAllAppResponseBodyAppList] = None,
    ):
        self.app_list = app_list

    def validate(self):
        if self.app_list:
            for k in self.app_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appList'] = []
        if self.app_list is not None:
            for k in self.app_list:
                result['appList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_list = []
        if m.get('appList') is not None:
            for k in m.get('appList'):
                temp_model = ListAllAppResponseBodyAppList()
                self.app_list.append(temp_model.from_map(k))
        return self


class ListAllAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAllAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAllAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAllInnerAppsHeaders(TeaModel):
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


class ListAllInnerAppsResponseBodyAppList(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
        app_status: int = None,
        desc: str = None,
        develop_type: int = None,
        homepage_link: str = None,
        icon: str = None,
        name: str = None,
        omp_link: str = None,
        pc_homepage_link: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.app_status = app_status
        self.desc = desc
        # This parameter is required.
        self.develop_type = develop_type
        self.homepage_link = homepage_link
        self.icon = icon
        self.name = name
        self.omp_link = omp_link
        self.pc_homepage_link = pc_homepage_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.desc is not None:
            result['desc'] = self.desc
        if self.develop_type is not None:
            result['developType'] = self.develop_type
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('developType') is not None:
            self.develop_type = m.get('developType')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        return self


class ListAllInnerAppsResponseBody(TeaModel):
    def __init__(
        self,
        app_list: List[ListAllInnerAppsResponseBodyAppList] = None,
    ):
        self.app_list = app_list

    def validate(self):
        if self.app_list:
            for k in self.app_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appList'] = []
        if self.app_list is not None:
            for k in self.app_list:
                result['appList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_list = []
        if m.get('appList') is not None:
            for k in m.get('appList'):
                temp_model = ListAllInnerAppsResponseBodyAppList()
                self.app_list.append(temp_model.from_map(k))
        return self


class ListAllInnerAppsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAllInnerAppsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAllInnerAppsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAppRoleScopesHeaders(TeaModel):
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


class ListAppRoleScopesRequest(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        size: int = None,
    ):
        self.next_token = next_token
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class ListAppRoleScopesResponseBodyDataList(TeaModel):
    def __init__(
        self,
        can_manage_role: bool = None,
        dept_id_list: List[int] = None,
        role_id: int = None,
        role_name: str = None,
        scope_type: str = None,
        scope_version: int = None,
        user_id_list: List[str] = None,
    ):
        self.can_manage_role = can_manage_role
        self.dept_id_list = dept_id_list
        self.role_id = role_id
        self.role_name = role_name
        self.scope_type = scope_type
        self.scope_version = scope_version
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class ListAppRoleScopesResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[ListAppRoleScopesResponseBodyDataList] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data_list = data_list
        self.has_more = has_more
        self.next_token = next_token

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = ListAppRoleScopesResponseBodyDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListAppRoleScopesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAppRoleScopesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAppRoleScopesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListInnerAppHeaders(TeaModel):
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


class ListInnerAppRequest(TeaModel):
    def __init__(
        self,
        ecological_corp_id: str = None,
    ):
        self.ecological_corp_id = ecological_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        return self


class ListInnerAppResponseBodyAppList(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        desc: str = None,
        homepage_link: str = None,
        icon: str = None,
        name: str = None,
        omp_link: str = None,
        pc_homepage_link: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        self.desc = desc
        self.homepage_link = homepage_link
        self.icon = icon
        self.name = name
        self.omp_link = omp_link
        self.pc_homepage_link = pc_homepage_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.desc is not None:
            result['desc'] = self.desc
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        return self


class ListInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        app_list: List[ListInnerAppResponseBodyAppList] = None,
    ):
        self.app_list = app_list

    def validate(self):
        if self.app_list:
            for k in self.app_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appList'] = []
        if self.app_list is not None:
            for k in self.app_list:
                result['appList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_list = []
        if m.get('appList') is not None:
            for k in m.get('appList'):
                temp_model = ListInnerAppResponseBodyAppList()
                self.app_list.append(temp_model.from_map(k))
        return self


class ListInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListInnerAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListInnerAppVersionHeaders(TeaModel):
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


class ListInnerAppVersionResponseBodyAppVersionList(TeaModel):
    def __init__(
        self,
        app_version: str = None,
        app_version_id: int = None,
        app_version_type: int = None,
        create_time: str = None,
        entrance_link: str = None,
        mini_app_id: str = None,
        mini_app_on_pc: bool = None,
        modify_time: str = None,
    ):
        # This parameter is required.
        self.app_version = app_version
        # This parameter is required.
        self.app_version_id = app_version_id
        # This parameter is required.
        self.app_version_type = app_version_type
        # This parameter is required.
        self.create_time = create_time
        self.entrance_link = entrance_link
        # This parameter is required.
        self.mini_app_id = mini_app_id
        self.mini_app_on_pc = mini_app_on_pc
        # This parameter is required.
        self.modify_time = modify_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version is not None:
            result['appVersion'] = self.app_version
        if self.app_version_id is not None:
            result['appVersionId'] = self.app_version_id
        if self.app_version_type is not None:
            result['appVersionType'] = self.app_version_type
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.entrance_link is not None:
            result['entranceLink'] = self.entrance_link
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.mini_app_on_pc is not None:
            result['miniAppOnPc'] = self.mini_app_on_pc
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersion') is not None:
            self.app_version = m.get('appVersion')
        if m.get('appVersionId') is not None:
            self.app_version_id = m.get('appVersionId')
        if m.get('appVersionType') is not None:
            self.app_version_type = m.get('appVersionType')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('entranceLink') is not None:
            self.entrance_link = m.get('entranceLink')
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('miniAppOnPc') is not None:
            self.mini_app_on_pc = m.get('miniAppOnPc')
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        return self


class ListInnerAppVersionResponseBody(TeaModel):
    def __init__(
        self,
        app_version_list: List[ListInnerAppVersionResponseBodyAppVersionList] = None,
    ):
        self.app_version_list = app_version_list

    def validate(self):
        if self.app_version_list:
            for k in self.app_version_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appVersionList'] = []
        if self.app_version_list is not None:
            for k in self.app_version_list:
                result['appVersionList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_version_list = []
        if m.get('appVersionList') is not None:
            for k in m.get('appVersionList'):
                temp_model = ListInnerAppVersionResponseBodyAppVersionList()
                self.app_version_list.append(temp_model.from_map(k))
        return self


class ListInnerAppVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListInnerAppVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListInnerAppVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRoleInfoByUserHeaders(TeaModel):
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


class ListRoleInfoByUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        can_manage_role: bool = None,
        role_id: int = None,
        role_name: str = None,
    ):
        self.can_manage_role = can_manage_role
        self.role_id = role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class ListRoleInfoByUserResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListRoleInfoByUserResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListRoleInfoByUserResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListRoleInfoByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListRoleInfoByUserResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListRoleInfoByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListUserVilebleAppHeaders(TeaModel):
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


class ListUserVilebleAppResponseBodyAppList(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
        app_status: int = None,
        desc: str = None,
        develop_type: int = None,
        homepage_link: str = None,
        icon: str = None,
        name: str = None,
        omp_link: str = None,
        pc_homepage_link: str = None,
        unified_app_id: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.app_status = app_status
        self.desc = desc
        # This parameter is required.
        self.develop_type = develop_type
        self.homepage_link = homepage_link
        self.icon = icon
        self.name = name
        self.omp_link = omp_link
        self.pc_homepage_link = pc_homepage_link
        self.unified_app_id = unified_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.desc is not None:
            result['desc'] = self.desc
        if self.develop_type is not None:
            result['developType'] = self.develop_type
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.unified_app_id is not None:
            result['unifiedAppId'] = self.unified_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('developType') is not None:
            self.develop_type = m.get('developType')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('unifiedAppId') is not None:
            self.unified_app_id = m.get('unifiedAppId')
        return self


class ListUserVilebleAppResponseBody(TeaModel):
    def __init__(
        self,
        app_list: List[ListUserVilebleAppResponseBodyAppList] = None,
    ):
        self.app_list = app_list

    def validate(self):
        if self.app_list:
            for k in self.app_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appList'] = []
        if self.app_list is not None:
            for k in self.app_list:
                result['appList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_list = []
        if m.get('appList') is not None:
            for k in m.get('appList'):
                temp_model = ListUserVilebleAppResponseBodyAppList()
                self.app_list.append(temp_model.from_map(k))
        return self


class ListUserVilebleAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListUserVilebleAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListUserVilebleAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageInnerAppHistoryVersionHeaders(TeaModel):
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


class PageInnerAppHistoryVersionRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class PageInnerAppHistoryVersionResponseBodyMiniAppVersionList(TeaModel):
    def __init__(
        self,
        app_version: str = None,
        app_version_id: int = None,
        app_version_type: int = None,
        create_time: str = None,
        mini_app_id: str = None,
        mini_app_on_pc: bool = None,
        modify_time: str = None,
    ):
        # This parameter is required.
        self.app_version = app_version
        # This parameter is required.
        self.app_version_id = app_version_id
        # This parameter is required.
        self.app_version_type = app_version_type
        # This parameter is required.
        self.create_time = create_time
        self.mini_app_id = mini_app_id
        # This parameter is required.
        self.mini_app_on_pc = mini_app_on_pc
        # This parameter is required.
        self.modify_time = modify_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version is not None:
            result['appVersion'] = self.app_version
        if self.app_version_id is not None:
            result['appVersionId'] = self.app_version_id
        if self.app_version_type is not None:
            result['appVersionType'] = self.app_version_type
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.mini_app_on_pc is not None:
            result['miniAppOnPc'] = self.mini_app_on_pc
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersion') is not None:
            self.app_version = m.get('appVersion')
        if m.get('appVersionId') is not None:
            self.app_version_id = m.get('appVersionId')
        if m.get('appVersionType') is not None:
            self.app_version_type = m.get('appVersionType')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('miniAppOnPc') is not None:
            self.mini_app_on_pc = m.get('miniAppOnPc')
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        return self


class PageInnerAppHistoryVersionResponseBody(TeaModel):
    def __init__(
        self,
        mini_app_version_list: List[PageInnerAppHistoryVersionResponseBodyMiniAppVersionList] = None,
        total_count: int = None,
    ):
        self.mini_app_version_list = mini_app_version_list
        self.total_count = total_count

    def validate(self):
        if self.mini_app_version_list:
            for k in self.mini_app_version_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['miniAppVersionList'] = []
        if self.mini_app_version_list is not None:
            for k in self.mini_app_version_list:
                result['miniAppVersionList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.mini_app_version_list = []
        if m.get('miniAppVersionList') is not None:
            for k in m.get('miniAppVersionList'):
                temp_model = PageInnerAppHistoryVersionResponseBodyMiniAppVersionList()
                self.mini_app_version_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PageInnerAppHistoryVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PageInnerAppHistoryVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = PageInnerAppHistoryVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PublishInnerAppVersionHeaders(TeaModel):
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


class PublishInnerAppVersionRequest(TeaModel):
    def __init__(
        self,
        app_version_id: int = None,
        mini_app_on_pc: bool = None,
        op_union_id: str = None,
        publish_type: str = None,
    ):
        # This parameter is required.
        self.app_version_id = app_version_id
        self.mini_app_on_pc = mini_app_on_pc
        # This parameter is required.
        self.op_union_id = op_union_id
        self.publish_type = publish_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version_id is not None:
            result['appVersionId'] = self.app_version_id
        if self.mini_app_on_pc is not None:
            result['miniAppOnPc'] = self.mini_app_on_pc
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.publish_type is not None:
            result['publishType'] = self.publish_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersionId') is not None:
            self.app_version_id = m.get('appVersionId')
        if m.get('miniAppOnPc') is not None:
            self.mini_app_on_pc = m.get('miniAppOnPc')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('publishType') is not None:
            self.publish_type = m.get('publishType')
        return self


class PublishInnerAppVersionResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class PublishInnerAppVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PublishInnerAppVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = PublishInnerAppVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RebuildRoleScopeForAppRoleHeaders(TeaModel):
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


class RebuildRoleScopeForAppRoleRequest(TeaModel):
    def __init__(
        self,
        dept_id_list: List[int] = None,
        op_user_id: str = None,
        scope_type: str = None,
        scope_version: int = None,
        user_id_list: List[str] = None,
    ):
        self.dept_id_list = dept_id_list
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.scope_type = scope_type
        # This parameter is required.
        self.scope_version = scope_version
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class RebuildRoleScopeForAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class RebuildRoleScopeForAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RebuildRoleScopeForAppRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RebuildRoleScopeForAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterCustomAppRoleHeaders(TeaModel):
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


class RegisterCustomAppRoleRequest(TeaModel):
    def __init__(
        self,
        can_manage_role: bool = None,
        op_user_id: str = None,
        role_name: str = None,
    ):
        self.can_manage_role = can_manage_role
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class RegisterCustomAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        scope_version: int = None,
    ):
        self.role_id = role_id
        self.scope_version = scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        return self


class RegisterCustomAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RegisterCustomAppRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RegisterCustomAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveApaasAppHeaders(TeaModel):
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


class RemoveApaasAppRequest(TeaModel):
    def __init__(
        self,
        biz_app_id: str = None,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.biz_app_id = biz_app_id
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class RemoveApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class RemoveApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveApaasAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RemoveApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveMemberForAppRoleHeaders(TeaModel):
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


class RemoveMemberForAppRoleRequest(TeaModel):
    def __init__(
        self,
        dept_id_list: List[int] = None,
        op_user_id: str = None,
        scope_version: int = None,
        user_id_list: List[str] = None,
    ):
        self.dept_id_list = dept_id_list
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.scope_version = scope_version
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class RemoveMemberForAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class RemoveMemberForAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveMemberForAppRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RemoveMemberForAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RollbackInnerAppVersionHeaders(TeaModel):
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


class RollbackInnerAppVersionRequest(TeaModel):
    def __init__(
        self,
        app_version_id: int = None,
        op_union_id: str = None,
    ):
        # This parameter is required.
        self.app_version_id = app_version_id
        # This parameter is required.
        self.op_union_id = op_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version_id is not None:
            result['appVersionId'] = self.app_version_id
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersionId') is not None:
            self.app_version_id = m.get('appVersionId')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        return self


class RollbackInnerAppVersionResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class RollbackInnerAppVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RollbackInnerAppVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RollbackInnerAppVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetMicroAppScopeHeaders(TeaModel):
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


class SetMicroAppScopeRequest(TeaModel):
    def __init__(
        self,
        add_dept_ids: List[int] = None,
        add_role_ids: List[int] = None,
        add_user_ids: List[str] = None,
        del_dept_ids: List[int] = None,
        del_role_ids: List[int] = None,
        del_user_ids: List[str] = None,
        only_admin_visible: bool = None,
    ):
        self.add_dept_ids = add_dept_ids
        self.add_role_ids = add_role_ids
        self.add_user_ids = add_user_ids
        self.del_dept_ids = del_dept_ids
        self.del_role_ids = del_role_ids
        self.del_user_ids = del_user_ids
        self.only_admin_visible = only_admin_visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.add_dept_ids is not None:
            result['addDeptIds'] = self.add_dept_ids
        if self.add_role_ids is not None:
            result['addRoleIds'] = self.add_role_ids
        if self.add_user_ids is not None:
            result['addUserIds'] = self.add_user_ids
        if self.del_dept_ids is not None:
            result['delDeptIds'] = self.del_dept_ids
        if self.del_role_ids is not None:
            result['delRoleIds'] = self.del_role_ids
        if self.del_user_ids is not None:
            result['delUserIds'] = self.del_user_ids
        if self.only_admin_visible is not None:
            result['onlyAdminVisible'] = self.only_admin_visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('addDeptIds') is not None:
            self.add_dept_ids = m.get('addDeptIds')
        if m.get('addRoleIds') is not None:
            self.add_role_ids = m.get('addRoleIds')
        if m.get('addUserIds') is not None:
            self.add_user_ids = m.get('addUserIds')
        if m.get('delDeptIds') is not None:
            self.del_dept_ids = m.get('delDeptIds')
        if m.get('delRoleIds') is not None:
            self.del_role_ids = m.get('delRoleIds')
        if m.get('delUserIds') is not None:
            self.del_user_ids = m.get('delUserIds')
        if m.get('onlyAdminVisible') is not None:
            self.only_admin_visible = m.get('onlyAdminVisible')
        return self


class SetMicroAppScopeResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class SetMicroAppScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetMicroAppScopeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = SetMicroAppScopeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateApaasAppHeaders(TeaModel):
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


class UpdateApaasAppRequest(TeaModel):
    def __init__(
        self,
        app_icon: str = None,
        app_name: str = None,
        app_status: int = None,
        biz_app_id: str = None,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.app_icon = app_icon
        # This parameter is required.
        self.app_name = app_name
        self.app_status = app_status
        # This parameter is required.
        self.biz_app_id = biz_app_id
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_icon is not None:
            result['appIcon'] = self.app_icon
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appIcon') is not None:
            self.app_icon = m.get('appIcon')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_app_id: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class UpdateApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateApaasAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UpdateApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateAppRoleInfoHeaders(TeaModel):
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


class UpdateAppRoleInfoRequest(TeaModel):
    def __init__(
        self,
        can_manage_role: bool = None,
        new_role_name: str = None,
        op_user_id: str = None,
    ):
        self.can_manage_role = can_manage_role
        self.new_role_name = new_role_name
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        if self.new_role_name is not None:
            result['newRoleName'] = self.new_role_name
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        if m.get('newRoleName') is not None:
            self.new_role_name = m.get('newRoleName')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateAppRoleInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateAppRoleInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateAppRoleInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UpdateAppRoleInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInnerAppHeaders(TeaModel):
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


class UpdateInnerAppRequest(TeaModel):
    def __init__(
        self,
        desc: str = None,
        homepage_link: str = None,
        icon: str = None,
        ip_white_list: List[str] = None,
        name: str = None,
        omp_link: str = None,
        op_union_id: str = None,
        pc_homepage_link: str = None,
    ):
        self.desc = desc
        self.homepage_link = homepage_link
        self.icon = icon
        self.ip_white_list = ip_white_list
        self.name = name
        self.omp_link = omp_link
        # This parameter is required.
        self.op_union_id = op_union_id
        self.pc_homepage_link = pc_homepage_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.icon is not None:
            result['icon'] = self.icon
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        if self.name is not None:
            result['name'] = self.name
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        return self


class UpdateInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInnerAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UpdateInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


