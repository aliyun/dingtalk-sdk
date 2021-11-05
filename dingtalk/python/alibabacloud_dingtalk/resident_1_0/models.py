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


class AddPointHeaders(TeaModel):
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


class AddPointRequest(TeaModel):
    def __init__(
        self,
        is_circle: bool = None,
        uuid: str = None,
        user_id: str = None,
        rule_code: str = None,
        rule_name: str = None,
        action_time: int = None,
        score: int = None,
    ):
        # 是否查询全员圈积分
        self.is_circle = is_circle
        # 加积分的唯一幂等标志
        self.uuid = uuid
        # 成员id
        self.user_id = user_id
        # 规则代码（可空）,如果不为空的话，score值使用ruleCode对应的score增加分数
        self.rule_code = rule_code
        # 规则名字
        self.rule_name = rule_name
        # 增加积分的时间戳毫秒数，如果为空使用系统当前毫秒数
        self.action_time = action_time
        # 本次增加积分：正数表示增加/负数表示扣减
        self.score = score

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_circle is not None:
            result['isCircle'] = self.is_circle
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.rule_name is not None:
            result['ruleName'] = self.rule_name
        if self.action_time is not None:
            result['actionTime'] = self.action_time
        if self.score is not None:
            result['score'] = self.score
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isCircle') is not None:
            self.is_circle = m.get('isCircle')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('ruleName') is not None:
            self.rule_name = m.get('ruleName')
        if m.get('actionTime') is not None:
            self.action_time = m.get('actionTime')
        if m.get('score') is not None:
            self.score = m.get('score')
        return self


class AddPointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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


class PagePointHistoryHeaders(TeaModel):
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


class PagePointHistoryRequest(TeaModel):
    def __init__(
        self,
        is_circle: bool = None,
        user_id: str = None,
        next_token: int = None,
        max_results: int = None,
        start_time: int = None,
        end_time: int = None,
    ):
        # 是否查询全员圈积分
        self.is_circle = is_circle
        # 用户userid，可空，不传表示查询组织内所有用户的流水数据
        self.user_id = user_id
        # 用来标记当前开始读取的位置
        self.next_token = next_token
        # 本次读取的最大数据记录数量，最大20
        self.max_results = max_results
        # 起始时间Unix时间戳，可空
        self.start_time = start_time
        # 结束时间Unix时间戳（不包含），可空
        self.end_time = end_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_circle is not None:
            result['isCircle'] = self.is_circle
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isCircle') is not None:
            self.is_circle = m.get('isCircle')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class PagePointHistoryResponseBodyPointRecordList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        score: int = None,
        create_at: int = None,
        uuid: str = None,
        rule_code: str = None,
        rule_name: str = None,
    ):
        # 组织id
        self.corp_id = corp_id
        # 成员id
        self.user_id = user_id
        # 增加或减少的分数（增加为正数，减少为负数）
        self.score = score
        # 创建时间（精确到毫秒数）
        self.create_at = create_at
        # 幂等键
        self.uuid = uuid
        # 对应的行为代码（可空）
        self.rule_code = rule_code
        # 对应的行为名字
        self.rule_name = rule_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.score is not None:
            result['score'] = self.score
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.rule_name is not None:
            result['ruleName'] = self.rule_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('ruleName') is not None:
            self.rule_name = m.get('ruleName')
        return self


class PagePointHistoryResponseBody(TeaModel):
    def __init__(
        self,
        point_record_list: List[PagePointHistoryResponseBodyPointRecordList] = None,
        has_more: bool = None,
        next_token: int = None,
        total_count: int = None,
    ):
        # 查询所得积分流水集合
        self.point_record_list = point_record_list
        # 是否有下一页
        self.has_more = has_more
        # 下一个游标值
        self.next_token = next_token
        # 总数，如果为-1则不计算总数
        self.total_count = total_count

    def validate(self):
        if self.point_record_list:
            for k in self.point_record_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['pointRecordList'] = []
        if self.point_record_list is not None:
            for k in self.point_record_list:
                result['pointRecordList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.point_record_list = []
        if m.get('pointRecordList') is not None:
            for k in m.get('pointRecordList'):
                temp_model = PagePointHistoryResponseBodyPointRecordList()
                self.point_record_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PagePointHistoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PagePointHistoryResponseBody = None,
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
            temp_model = PagePointHistoryResponseBody()
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


class ListPointRulesHeaders(TeaModel):
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


class ListPointRulesRequest(TeaModel):
    def __init__(
        self,
        is_circle: bool = None,
    ):
        # 是否查询全员圈积分
        self.is_circle = is_circle

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_circle is not None:
            result['isCircle'] = self.is_circle
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isCircle') is not None:
            self.is_circle = m.get('isCircle')
        return self


class ListPointRulesResponseBodyPointRuleList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        score: int = None,
        day_limit_times: int = None,
        status: int = None,
        rule_code: str = None,
        rule_name: str = None,
        extension: str = None,
        group_id: int = None,
        order_id: int = None,
    ):
        # 组织id
        self.corp_id = corp_id
        # 增加或减少的分数（增加为正数，减少为负数）
        self.score = score
        # 单日计次上限，0表示无上限
        self.day_limit_times = day_limit_times
        # 生效状态 0：不生效，1：生效
        self.status = status
        # 对应的行为代码（可空）
        self.rule_code = rule_code
        # 对应的行为名字
        self.rule_name = rule_name
        # 扩展字段
        self.extension = extension
        # 分组ID, 默认写入为0
        self.group_id = group_id
        # 排序ID
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.score is not None:
            result['score'] = self.score
        if self.day_limit_times is not None:
            result['dayLimitTimes'] = self.day_limit_times
        if self.status is not None:
            result['status'] = self.status
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.rule_name is not None:
            result['ruleName'] = self.rule_name
        if self.extension is not None:
            result['extension'] = self.extension
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('dayLimitTimes') is not None:
            self.day_limit_times = m.get('dayLimitTimes')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('ruleName') is not None:
            self.rule_name = m.get('ruleName')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class ListPointRulesResponseBody(TeaModel):
    def __init__(
        self,
        point_rule_list: List[ListPointRulesResponseBodyPointRuleList] = None,
    ):
        # 查询所得积分规则集合
        self.point_rule_list = point_rule_list

    def validate(self):
        if self.point_rule_list:
            for k in self.point_rule_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['pointRuleList'] = []
        if self.point_rule_list is not None:
            for k in self.point_rule_list:
                result['pointRuleList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.point_rule_list = []
        if m.get('pointRuleList') is not None:
            for k in m.get('pointRuleList'):
                temp_model = ListPointRulesResponseBodyPointRuleList()
                self.point_rule_list.append(temp_model.from_map(k))
        return self


class ListPointRulesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListPointRulesResponseBody = None,
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
            temp_model = ListPointRulesResponseBody()
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


