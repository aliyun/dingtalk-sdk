# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class UpdateResideceGroupHeaders(TeaModel):
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


class UpdateResideceGroupRequest(TeaModel):
    def __init__(
        self,
        manager_user_id: str = None,
        department_name: str = None,
        department_id: int = None,
    ):
        # 组长userid
        self.manager_user_id = manager_user_id
        # 组名字
        self.department_name = department_name
        # 组id
        self.department_id = department_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        return self


class UpdateResideceGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否更新成功
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


class UpdateResideceGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateResideceGroupResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateResideceGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteResidentDepartmentHeaders(TeaModel):
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


class DeleteResidentDepartmentRequest(TeaModel):
    def __init__(
        self,
        department_id: int = None,
    ):
        # 组/户id
        self.department_id = department_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        return self


class DeleteResidentDepartmentResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否删除成功
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


class DeleteResidentDepartmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteResidentDepartmentResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = DeleteResidentDepartmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddResidentUsersHeaders(TeaModel):
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


class AddResidentUsersRequestExtField(TeaModel):
    def __init__(
        self,
        item_value: str = None,
        item_name: str = None,
    ):
        # 扩展字段值
        self.item_value = item_value
        # 扩展字段名字
        self.item_name = item_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_value is not None:
            result['itemValue'] = self.item_value
        if self.item_name is not None:
            result['itemName'] = self.item_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemValue') is not None:
            self.item_value = m.get('itemValue')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        return self


class AddResidentUsersRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        is_leaseholder: bool = None,
        user_name: str = None,
        mobile: str = None,
        department_id: int = None,
        ext_field: List[AddResidentUsersRequestExtField] = None,
        relate_type: str = None,
    ):
        # 家庭住址
        self.address = address
        # 是否是租客
        self.is_leaseholder = is_leaseholder
        # 居民名字
        self.user_name = user_name
        # 手机号码
        self.mobile = mobile
        # 户/租户部门id
        self.department_id = department_id
        # 扩展字段（包括身份证/性别/民族）
        self.ext_field = ext_field
        # 与户主的关系
        self.relate_type = relate_type

    def validate(self):
        if self.ext_field:
            for k in self.ext_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.is_leaseholder is not None:
            result['isLeaseholder'] = self.is_leaseholder
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        result['extField'] = []
        if self.ext_field is not None:
            for k in self.ext_field:
                result['extField'].append(k.to_map() if k else None)
        if self.relate_type is not None:
            result['relateType'] = self.relate_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('isLeaseholder') is not None:
            self.is_leaseholder = m.get('isLeaseholder')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        self.ext_field = []
        if m.get('extField') is not None:
            for k in m.get('extField'):
                temp_model = AddResidentUsersRequestExtField()
                self.ext_field.append(temp_model.from_map(k))
        if m.get('relateType') is not None:
            self.relate_type = m.get('relateType')
        return self


class AddResidentUsersResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 创建成功的userId
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


class AddResidentUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddResidentUsersResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = AddResidentUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddResidentDepartmentHeaders(TeaModel):
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


class AddResidentDepartmentRequest(TeaModel):
    def __init__(
        self,
        is_residence_group: bool = None,
        department_name: str = None,
        parent_department_id: int = None,
    ):
        # 是否为组
        self.is_residence_group = is_residence_group
        # 部门名字
        self.department_name = department_name
        # 父部门id
        self.parent_department_id = parent_department_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_residence_group is not None:
            result['isResidenceGroup'] = self.is_residence_group
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.parent_department_id is not None:
            result['parentDepartmentId'] = self.parent_department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isResidenceGroup') is not None:
            self.is_residence_group = m.get('isResidenceGroup')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('parentDepartmentId') is not None:
            self.parent_department_id = m.get('parentDepartmentId')
        return self


class AddResidentDepartmentResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
    ):
        # 创建成功的deptId
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


class AddResidentDepartmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddResidentDepartmentResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = AddResidentDepartmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveResidentUserHeaders(TeaModel):
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


class RemoveResidentUserRequest(TeaModel):
    def __init__(
        self,
        department_id: int = None,
        user_id: str = None,
    ):
        # 户/租户部门id
        self.department_id = department_id
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class RemoveResidentUserResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否移除成功
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


class RemoveResidentUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveResidentUserResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = RemoveResidentUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateResidenceHeaders(TeaModel):
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


class UpdateResidenceRequest(TeaModel):
    def __init__(
        self,
        manager_user_id: str = None,
        department_name: str = None,
        department_id: int = None,
        grid: str = None,
        home_tel: str = None,
        destitute: bool = None,
        parent_department_id: int = None,
    ):
        # 家庭管理员用户id
        self.manager_user_id = manager_user_id
        # 户名字
        self.department_name = department_name
        # 组id
        self.department_id = department_id
        # 所属网格
        self.grid = grid
        # 家庭电话
        self.home_tel = home_tel
        # 是否是贫困户
        self.destitute = destitute
        # 组id
        self.parent_department_id = parent_department_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.grid is not None:
            result['grid'] = self.grid
        if self.home_tel is not None:
            result['homeTel'] = self.home_tel
        if self.destitute is not None:
            result['destitute'] = self.destitute
        if self.parent_department_id is not None:
            result['parentDepartmentId'] = self.parent_department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('grid') is not None:
            self.grid = m.get('grid')
        if m.get('homeTel') is not None:
            self.home_tel = m.get('homeTel')
        if m.get('destitute') is not None:
            self.destitute = m.get('destitute')
        if m.get('parentDepartmentId') is not None:
            self.parent_department_id = m.get('parentDepartmentId')
        return self


class UpdateResidenceResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否更新成功
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


class UpdateResidenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateResidenceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateResidenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateResidentUserHeaders(TeaModel):
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


class UpdateResidentUserRequestExtField(TeaModel):
    def __init__(
        self,
        item_value: str = None,
        item_name: str = None,
    ):
        # 扩展字段值
        self.item_value = item_value
        # 扩展字段名字
        self.item_name = item_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_value is not None:
            result['itemValue'] = self.item_value
        if self.item_name is not None:
            result['itemName'] = self.item_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemValue') is not None:
            self.item_value = m.get('itemValue')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        return self


class UpdateResidentUserRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        is_retain_old_dept: bool = None,
        user_name: str = None,
        mobile: str = None,
        department_id: int = None,
        ext_field: List[UpdateResidentUserRequestExtField] = None,
        relate_type: str = None,
        user_id: str = None,
        old_department_id: int = None,
    ):
        # 家庭住址
        self.address = address
        # 是否保留原部门
        self.is_retain_old_dept = is_retain_old_dept
        # 居民名字
        self.user_name = user_name
        # 手机号码
        self.mobile = mobile
        # 所在新的户/租户部门id
        self.department_id = department_id
        # 扩展字段（包括身份证/性别/民族）
        self.ext_field = ext_field
        # 与户主的关系
        self.relate_type = relate_type
        # 人员userId
        self.user_id = user_id
        # 原所在部门id
        self.old_department_id = old_department_id

    def validate(self):
        if self.ext_field:
            for k in self.ext_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.is_retain_old_dept is not None:
            result['isRetainOldDept'] = self.is_retain_old_dept
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        result['extField'] = []
        if self.ext_field is not None:
            for k in self.ext_field:
                result['extField'].append(k.to_map() if k else None)
        if self.relate_type is not None:
            result['relateType'] = self.relate_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.old_department_id is not None:
            result['oldDepartmentId'] = self.old_department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('isRetainOldDept') is not None:
            self.is_retain_old_dept = m.get('isRetainOldDept')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        self.ext_field = []
        if m.get('extField') is not None:
            for k in m.get('extField'):
                temp_model = UpdateResidentUserRequestExtField()
                self.ext_field.append(temp_model.from_map(k))
        if m.get('relateType') is not None:
            self.relate_type = m.get('relateType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('oldDepartmentId') is not None:
            self.old_department_id = m.get('oldDepartmentId')
        return self


class UpdateResidentUserResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否更新成功
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


class UpdateResidentUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateResidentUserResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateResidentUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


