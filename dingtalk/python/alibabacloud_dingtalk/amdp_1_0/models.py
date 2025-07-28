# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AmdpEmpRoleDataPushHeaders(TeaModel):
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


class AmdpEmpRoleDataPushRequestParam(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        is_delete: str = None,
        role_code: str = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
        self.is_delete = is_delete
        self.role_code = role_code
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.is_delete is not None:
            result['isDelete'] = self.is_delete
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('isDelete') is not None:
            self.is_delete = m.get('isDelete')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AmdpEmpRoleDataPushRequest(TeaModel):
    def __init__(
        self,
        param: List[AmdpEmpRoleDataPushRequestParam] = None,
    ):
        self.param = param

    def validate(self):
        if self.param:
            for k in self.param:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['param'] = []
        if self.param is not None:
            for k in self.param:
                result['param'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.param = []
        if m.get('param') is not None:
            for k in m.get('param'):
                temp_model = AmdpEmpRoleDataPushRequestParam()
                self.param.append(temp_model.from_map(k))
        return self


class AmdpEmpRoleDataPushResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        status: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AmdpEmpRoleDataPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AmdpEmpRoleDataPushResponseBody = None,
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
            temp_model = AmdpEmpRoleDataPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AmdpEmployeeDataPushHeaders(TeaModel):
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


class AmdpEmployeeDataPushRequestParam(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        is_delete: str = None,
        name: str = None,
        union_id: str = None,
        user_id: str = None,
        work_no: str = None,
    ):
        self.avatar = avatar
        self.is_delete = is_delete
        self.name = name
        self.union_id = union_id
        self.user_id = user_id
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.is_delete is not None:
            result['isDelete'] = self.is_delete
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('isDelete') is not None:
            self.is_delete = m.get('isDelete')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class AmdpEmployeeDataPushRequest(TeaModel):
    def __init__(
        self,
        param: List[AmdpEmployeeDataPushRequestParam] = None,
    ):
        self.param = param

    def validate(self):
        if self.param:
            for k in self.param:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['param'] = []
        if self.param is not None:
            for k in self.param:
                result['param'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.param = []
        if m.get('param') is not None:
            for k in m.get('param'):
                temp_model = AmdpEmployeeDataPushRequestParam()
                self.param.append(temp_model.from_map(k))
        return self


class AmdpEmployeeDataPushResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        status: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AmdpEmployeeDataPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AmdpEmployeeDataPushResponseBody = None,
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
            temp_model = AmdpEmployeeDataPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AmdpJobPositionDataPushHeaders(TeaModel):
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


class AmdpJobPositionDataPushRequestParam(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_leader: str = None,
        is_delete: str = None,
        leader_dept_id: str = None,
        order_number: str = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
        self.dept_leader = dept_leader
        self.is_delete = is_delete
        self.leader_dept_id = leader_dept_id
        self.order_number = order_number
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_leader is not None:
            result['deptLeader'] = self.dept_leader
        if self.is_delete is not None:
            result['isDelete'] = self.is_delete
        if self.leader_dept_id is not None:
            result['leaderDeptId'] = self.leader_dept_id
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptLeader') is not None:
            self.dept_leader = m.get('deptLeader')
        if m.get('isDelete') is not None:
            self.is_delete = m.get('isDelete')
        if m.get('leaderDeptId') is not None:
            self.leader_dept_id = m.get('leaderDeptId')
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AmdpJobPositionDataPushRequest(TeaModel):
    def __init__(
        self,
        param: List[AmdpJobPositionDataPushRequestParam] = None,
    ):
        self.param = param

    def validate(self):
        if self.param:
            for k in self.param:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['param'] = []
        if self.param is not None:
            for k in self.param:
                result['param'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.param = []
        if m.get('param') is not None:
            for k in m.get('param'):
                temp_model = AmdpJobPositionDataPushRequestParam()
                self.param.append(temp_model.from_map(k))
        return self


class AmdpJobPositionDataPushResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        status: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AmdpJobPositionDataPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AmdpJobPositionDataPushResponseBody = None,
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
            temp_model = AmdpJobPositionDataPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AmdpOrganizationDataPushHeaders(TeaModel):
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


class AmdpOrganizationDataPushRequestParam(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_manager_id_list: List[str] = None,
        ding_talk_dept_id: str = None,
        ding_talk_parent_id: str = None,
        is_delete: str = None,
        name: str = None,
        parent_id: str = None,
    ):
        self.dept_id = dept_id
        self.dept_manager_id_list = dept_manager_id_list
        self.ding_talk_dept_id = ding_talk_dept_id
        self.ding_talk_parent_id = ding_talk_parent_id
        self.is_delete = is_delete
        self.name = name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_manager_id_list is not None:
            result['deptManagerIdList'] = self.dept_manager_id_list
        if self.ding_talk_dept_id is not None:
            result['dingTalkDeptId'] = self.ding_talk_dept_id
        if self.ding_talk_parent_id is not None:
            result['dingTalkParentId'] = self.ding_talk_parent_id
        if self.is_delete is not None:
            result['isDelete'] = self.is_delete
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptManagerIdList') is not None:
            self.dept_manager_id_list = m.get('deptManagerIdList')
        if m.get('dingTalkDeptId') is not None:
            self.ding_talk_dept_id = m.get('dingTalkDeptId')
        if m.get('dingTalkParentId') is not None:
            self.ding_talk_parent_id = m.get('dingTalkParentId')
        if m.get('isDelete') is not None:
            self.is_delete = m.get('isDelete')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class AmdpOrganizationDataPushRequest(TeaModel):
    def __init__(
        self,
        param: List[AmdpOrganizationDataPushRequestParam] = None,
    ):
        self.param = param

    def validate(self):
        if self.param:
            for k in self.param:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['param'] = []
        if self.param is not None:
            for k in self.param:
                result['param'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.param = []
        if m.get('param') is not None:
            for k in m.get('param'):
                temp_model = AmdpOrganizationDataPushRequestParam()
                self.param.append(temp_model.from_map(k))
        return self


class AmdpOrganizationDataPushResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        status: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AmdpOrganizationDataPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AmdpOrganizationDataPushResponseBody = None,
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
            temp_model = AmdpOrganizationDataPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


