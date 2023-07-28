# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class ActivateDeviceHeaders(TeaModel):
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


class ActivateDeviceRequest(TeaModel):
    def __init__(
        self,
        license_key: str = None,
        model: str = None,
        name: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.license_key = license_key
        self.model = model
        self.name = name
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.license_key is not None:
            result['licenseKey'] = self.license_key
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('licenseKey') is not None:
            self.license_key = m.get('licenseKey')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ActivateDeviceResponseBody(TeaModel):
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


class ActivateDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ActivateDeviceResponseBody = None,
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
            temp_model = ActivateDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddDeviceHeaders(TeaModel):
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


class AddDeviceRequest(TeaModel):
    def __init__(
        self,
        merchant_id: str = None,
        model: str = None,
        name: str = None,
        scene: int = None,
        sn: str = None,
        status: int = None,
        type: int = None,
    ):
        self.merchant_id = merchant_id
        self.model = model
        self.name = name
        self.scene = scene
        self.sn = sn
        self.status = status
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.scene is not None:
            result['scene'] = self.scene
        if self.sn is not None:
            result['sn'] = self.sn
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class AddDeviceResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: int = None,
        merchant_id: str = None,
        sn: str = None,
        status: int = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.merchant_id = merchant_id
        self.sn = sn
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.sn is not None:
            result['sn'] = self.sn
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class AddDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddDeviceResponseBody = None,
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
            temp_model = AddDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddSchoolConfigHeaders(TeaModel):
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


class AddSchoolConfigRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        operator_name: str = None,
        temperature_up_limit: int = None,
    ):
        self.operator_id = operator_id
        self.operator_name = operator_name
        self.temperature_up_limit = temperature_up_limit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.temperature_up_limit is not None:
            result['temperatureUpLimit'] = self.temperature_up_limit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('temperatureUpLimit') is not None:
            self.temperature_up_limit = m.get('temperatureUpLimit')
        return self


class AddSchoolConfigResponseBody(TeaModel):
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


class AddSchoolConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddSchoolConfigResponseBody = None,
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
            temp_model = AddSchoolConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AssignClassHeaders(TeaModel):
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


class AssignClassRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        is_finish: bool = None,
        operator: str = None,
        student_id: int = None,
        task_id: int = None,
    ):
        self.class_id = class_id
        self.is_finish = is_finish
        self.operator = operator
        self.student_id = student_id
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.is_finish is not None:
            result['isFinish'] = self.is_finish
        if self.operator is not None:
            result['operator'] = self.operator
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('isFinish') is not None:
            self.is_finish = m.get('isFinish')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class AssignClassResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AssignClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AssignClassResponseBody = None,
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
            temp_model = AssignClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchCreateHeaders(TeaModel):
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


class BatchCreateRequestDataCardRuleItemParamList(TeaModel):
    def __init__(
        self,
        card_rule_attr: str = None,
        card_task_code: str = None,
        daily_dubbing: int = None,
        relation_id: str = None,
        relation_title: str = None,
        relation_url: str = None,
    ):
        self.card_rule_attr = card_rule_attr
        self.card_task_code = card_task_code
        self.daily_dubbing = daily_dubbing
        self.relation_id = relation_id
        self.relation_title = relation_title
        self.relation_url = relation_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_rule_attr is not None:
            result['cardRuleAttr'] = self.card_rule_attr
        if self.card_task_code is not None:
            result['cardTaskCode'] = self.card_task_code
        if self.daily_dubbing is not None:
            result['dailyDubbing'] = self.daily_dubbing
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.relation_title is not None:
            result['relationTitle'] = self.relation_title
        if self.relation_url is not None:
            result['relationUrl'] = self.relation_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardRuleAttr') is not None:
            self.card_rule_attr = m.get('cardRuleAttr')
        if m.get('cardTaskCode') is not None:
            self.card_task_code = m.get('cardTaskCode')
        if m.get('dailyDubbing') is not None:
            self.daily_dubbing = m.get('dailyDubbing')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('relationTitle') is not None:
            self.relation_title = m.get('relationTitle')
        if m.get('relationUrl') is not None:
            self.relation_url = m.get('relationUrl')
        return self


class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents(TeaModel):
    def __init__(
        self,
        name: str = None,
        staff_id: str = None,
    ):
        self.name = name
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class BatchCreateRequestDataOrgClassStudentGroupListClassList(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        class_name: str = None,
        students: List[BatchCreateRequestDataOrgClassStudentGroupListClassListStudents] = None,
    ):
        self.class_id = class_id
        self.class_name = class_name
        self.students = students

    def validate(self):
        if self.students:
            for k in self.students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_name is not None:
            result['className'] = self.class_name
        result['students'] = []
        if self.students is not None:
            for k in self.students:
                result['students'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('className') is not None:
            self.class_name = m.get('className')
        self.students = []
        if m.get('students') is not None:
            for k in m.get('students'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupListClassListStudents()
                self.students.append(temp_model.from_map(k))
        return self


class BatchCreateRequestDataOrgClassStudentGroupList(TeaModel):
    def __init__(
        self,
        class_list: List[BatchCreateRequestDataOrgClassStudentGroupListClassList] = None,
        corp_id: str = None,
    ):
        self.class_list = class_list
        self.corp_id = corp_id

    def validate(self):
        if self.class_list:
            for k in self.class_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['classList'] = []
        if self.class_list is not None:
            for k in self.class_list:
                result['classList'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.class_list = []
        if m.get('classList') is not None:
            for k in m.get('classList'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupListClassList()
                self.class_list.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class BatchCreateRequestData(TeaModel):
    def __init__(
        self,
        can_reissue_card: bool = None,
        card_cycle: int = None,
        card_frequency: List[int] = None,
        card_rule_item_param_list: List[BatchCreateRequestDataCardRuleItemParamList] = None,
        class_ids: List[str] = None,
        class_names: List[str] = None,
        content: str = None,
        effect_date: int = None,
        medias: str = None,
        need_metering: str = None,
        org_class_student_group_list: List[BatchCreateRequestDataOrgClassStudentGroupList] = None,
        remind_hour: int = None,
        remind_minute: int = None,
        target_role: str = None,
        template_id: int = None,
        title: str = None,
        unit_of_measurement: str = None,
    ):
        self.can_reissue_card = can_reissue_card
        self.card_cycle = card_cycle
        self.card_frequency = card_frequency
        self.card_rule_item_param_list = card_rule_item_param_list
        self.class_ids = class_ids
        self.class_names = class_names
        self.content = content
        self.effect_date = effect_date
        self.medias = medias
        self.need_metering = need_metering
        self.org_class_student_group_list = org_class_student_group_list
        self.remind_hour = remind_hour
        self.remind_minute = remind_minute
        self.target_role = target_role
        self.template_id = template_id
        self.title = title
        self.unit_of_measurement = unit_of_measurement

    def validate(self):
        if self.card_rule_item_param_list:
            for k in self.card_rule_item_param_list:
                if k:
                    k.validate()
        if self.org_class_student_group_list:
            for k in self.org_class_student_group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_reissue_card is not None:
            result['canReissueCard'] = self.can_reissue_card
        if self.card_cycle is not None:
            result['cardCycle'] = self.card_cycle
        if self.card_frequency is not None:
            result['cardFrequency'] = self.card_frequency
        result['cardRuleItemParamList'] = []
        if self.card_rule_item_param_list is not None:
            for k in self.card_rule_item_param_list:
                result['cardRuleItemParamList'].append(k.to_map() if k else None)
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.class_names is not None:
            result['classNames'] = self.class_names
        if self.content is not None:
            result['content'] = self.content
        if self.effect_date is not None:
            result['effectDate'] = self.effect_date
        if self.medias is not None:
            result['medias'] = self.medias
        if self.need_metering is not None:
            result['needMetering'] = self.need_metering
        result['orgClassStudentGroupList'] = []
        if self.org_class_student_group_list is not None:
            for k in self.org_class_student_group_list:
                result['orgClassStudentGroupList'].append(k.to_map() if k else None)
        if self.remind_hour is not None:
            result['remindHour'] = self.remind_hour
        if self.remind_minute is not None:
            result['remindMinute'] = self.remind_minute
        if self.target_role is not None:
            result['targetRole'] = self.target_role
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        if self.unit_of_measurement is not None:
            result['unitOfMeasurement'] = self.unit_of_measurement
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canReissueCard') is not None:
            self.can_reissue_card = m.get('canReissueCard')
        if m.get('cardCycle') is not None:
            self.card_cycle = m.get('cardCycle')
        if m.get('cardFrequency') is not None:
            self.card_frequency = m.get('cardFrequency')
        self.card_rule_item_param_list = []
        if m.get('cardRuleItemParamList') is not None:
            for k in m.get('cardRuleItemParamList'):
                temp_model = BatchCreateRequestDataCardRuleItemParamList()
                self.card_rule_item_param_list.append(temp_model.from_map(k))
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('classNames') is not None:
            self.class_names = m.get('classNames')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('effectDate') is not None:
            self.effect_date = m.get('effectDate')
        if m.get('medias') is not None:
            self.medias = m.get('medias')
        if m.get('needMetering') is not None:
            self.need_metering = m.get('needMetering')
        self.org_class_student_group_list = []
        if m.get('orgClassStudentGroupList') is not None:
            for k in m.get('orgClassStudentGroupList'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupList()
                self.org_class_student_group_list.append(temp_model.from_map(k))
        if m.get('remindHour') is not None:
            self.remind_hour = m.get('remindHour')
        if m.get('remindMinute') is not None:
            self.remind_minute = m.get('remindMinute')
        if m.get('targetRole') is not None:
            self.target_role = m.get('targetRole')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unitOfMeasurement') is not None:
            self.unit_of_measurement = m.get('unitOfMeasurement')
        return self


class BatchCreateRequest(TeaModel):
    def __init__(
        self,
        card_biz_code: str = None,
        data: BatchCreateRequestData = None,
        identifier: str = None,
        js_version: int = None,
        source_type: str = None,
        userid: str = None,
    ):
        self.card_biz_code = card_biz_code
        self.data = data
        self.identifier = identifier
        self.js_version = js_version
        self.source_type = source_type
        self.userid = userid

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_biz_code is not None:
            result['cardBizCode'] = self.card_biz_code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.identifier is not None:
            result['identifier'] = self.identifier
        if self.js_version is not None:
            result['jsVersion'] = self.js_version
        if self.source_type is not None:
            result['sourceType'] = self.source_type
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardBizCode') is not None:
            self.card_biz_code = m.get('cardBizCode')
        if m.get('data') is not None:
            temp_model = BatchCreateRequestData()
            self.data = temp_model.from_map(m['data'])
        if m.get('identifier') is not None:
            self.identifier = m.get('identifier')
        if m.get('jsVersion') is not None:
            self.js_version = m.get('jsVersion')
        if m.get('sourceType') is not None:
            self.source_type = m.get('sourceType')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        return self


class BatchCreateResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id_card_id_map: Dict[str, str] = None,
    ):
        self.corp_id_card_id_map = corp_id_card_id_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id_card_id_map is not None:
            result['corpIdCardIdMap'] = self.corp_id_card_id_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIdCardIdMap') is not None:
            self.corp_id_card_id_map = m.get('corpIdCardIdMap')
        return self


class BatchCreateResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchCreateResponseBodyResult = None,
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
            temp_model = BatchCreateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BatchCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchCreateResponseBody = None,
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
            temp_model = BatchCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchOrgCreateHWHeaders(TeaModel):
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


class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        name: str = None,
        staff_id: str = None,
    ):
        self.avatar = avatar
        self.name = name
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class BatchOrgCreateHWRequestOpenSelectItemListClassList(TeaModel):
    def __init__(
        self,
        all: bool = None,
        class_id: str = None,
        class_name: str = None,
        students: List[BatchOrgCreateHWRequestOpenSelectItemListClassListStudents] = None,
    ):
        self.all = all
        self.class_id = class_id
        self.class_name = class_name
        self.students = students

    def validate(self):
        if self.students:
            for k in self.students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all is not None:
            result['all'] = self.all
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_name is not None:
            result['className'] = self.class_name
        result['students'] = []
        if self.students is not None:
            for k in self.students:
                result['students'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('all') is not None:
            self.all = m.get('all')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('className') is not None:
            self.class_name = m.get('className')
        self.students = []
        if m.get('students') is not None:
            for k in m.get('students'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemListClassListStudents()
                self.students.append(temp_model.from_map(k))
        return self


class BatchOrgCreateHWRequestOpenSelectItemList(TeaModel):
    def __init__(
        self,
        class_list: List[BatchOrgCreateHWRequestOpenSelectItemListClassList] = None,
        corp_id: str = None,
        selected_classes_desc: str = None,
    ):
        self.class_list = class_list
        self.corp_id = corp_id
        self.selected_classes_desc = selected_classes_desc

    def validate(self):
        if self.class_list:
            for k in self.class_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['classList'] = []
        if self.class_list is not None:
            for k in self.class_list:
                result['classList'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.selected_classes_desc is not None:
            result['selectedClassesDesc'] = self.selected_classes_desc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.class_list = []
        if m.get('classList') is not None:
            for k in m.get('classList'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemListClassList()
                self.class_list.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('selectedClassesDesc') is not None:
            self.selected_classes_desc = m.get('selectedClassesDesc')
        return self


class BatchOrgCreateHWRequest(TeaModel):
    def __init__(
        self,
        attributes: str = None,
        biz_code: str = None,
        course_name: str = None,
        hw_content: str = None,
        hw_deadline: int = None,
        hw_deadline_open: str = None,
        hw_media: str = None,
        hw_photo: str = None,
        hw_title: str = None,
        hw_type: str = None,
        hw_video: str = None,
        identifier: str = None,
        open_select_item_list: List[BatchOrgCreateHWRequestOpenSelectItemList] = None,
        scheduled_release: str = None,
        scheduled_time: str = None,
        status: str = None,
        target_role: str = None,
        teacher_name: str = None,
        teacher_user_id: str = None,
    ):
        self.attributes = attributes
        self.biz_code = biz_code
        self.course_name = course_name
        self.hw_content = hw_content
        self.hw_deadline = hw_deadline
        self.hw_deadline_open = hw_deadline_open
        self.hw_media = hw_media
        self.hw_photo = hw_photo
        self.hw_title = hw_title
        self.hw_type = hw_type
        self.hw_video = hw_video
        self.identifier = identifier
        self.open_select_item_list = open_select_item_list
        self.scheduled_release = scheduled_release
        self.scheduled_time = scheduled_time
        self.status = status
        self.target_role = target_role
        self.teacher_name = teacher_name
        self.teacher_user_id = teacher_user_id

    def validate(self):
        if self.open_select_item_list:
            for k in self.open_select_item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.hw_content is not None:
            result['hwContent'] = self.hw_content
        if self.hw_deadline is not None:
            result['hwDeadline'] = self.hw_deadline
        if self.hw_deadline_open is not None:
            result['hwDeadlineOpen'] = self.hw_deadline_open
        if self.hw_media is not None:
            result['hwMedia'] = self.hw_media
        if self.hw_photo is not None:
            result['hwPhoto'] = self.hw_photo
        if self.hw_title is not None:
            result['hwTitle'] = self.hw_title
        if self.hw_type is not None:
            result['hwType'] = self.hw_type
        if self.hw_video is not None:
            result['hwVideo'] = self.hw_video
        if self.identifier is not None:
            result['identifier'] = self.identifier
        result['openSelectItemList'] = []
        if self.open_select_item_list is not None:
            for k in self.open_select_item_list:
                result['openSelectItemList'].append(k.to_map() if k else None)
        if self.scheduled_release is not None:
            result['scheduledRelease'] = self.scheduled_release
        if self.scheduled_time is not None:
            result['scheduledTime'] = self.scheduled_time
        if self.status is not None:
            result['status'] = self.status
        if self.target_role is not None:
            result['targetRole'] = self.target_role
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('hwContent') is not None:
            self.hw_content = m.get('hwContent')
        if m.get('hwDeadline') is not None:
            self.hw_deadline = m.get('hwDeadline')
        if m.get('hwDeadlineOpen') is not None:
            self.hw_deadline_open = m.get('hwDeadlineOpen')
        if m.get('hwMedia') is not None:
            self.hw_media = m.get('hwMedia')
        if m.get('hwPhoto') is not None:
            self.hw_photo = m.get('hwPhoto')
        if m.get('hwTitle') is not None:
            self.hw_title = m.get('hwTitle')
        if m.get('hwType') is not None:
            self.hw_type = m.get('hwType')
        if m.get('hwVideo') is not None:
            self.hw_video = m.get('hwVideo')
        if m.get('identifier') is not None:
            self.identifier = m.get('identifier')
        self.open_select_item_list = []
        if m.get('openSelectItemList') is not None:
            for k in m.get('openSelectItemList'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemList()
                self.open_select_item_list.append(temp_model.from_map(k))
        if m.get('scheduledRelease') is not None:
            self.scheduled_release = m.get('scheduledRelease')
        if m.get('scheduledTime') is not None:
            self.scheduled_time = m.get('scheduledTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('targetRole') is not None:
            self.target_role = m.get('targetRole')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        return self


class BatchOrgCreateHWResponseBodyResultPublishList(TeaModel):
    def __init__(
        self,
        corpid: str = None,
        hwid: int = None,
    ):
        self.corpid = corpid
        self.hwid = hwid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corpid is not None:
            result['corpid'] = self.corpid
        if self.hwid is not None:
            result['hwid'] = self.hwid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpid') is not None:
            self.corpid = m.get('corpid')
        if m.get('hwid') is not None:
            self.hwid = m.get('hwid')
        return self


class BatchOrgCreateHWResponseBodyResult(TeaModel):
    def __init__(
        self,
        publish_list: List[BatchOrgCreateHWResponseBodyResultPublishList] = None,
    ):
        self.publish_list = publish_list

    def validate(self):
        if self.publish_list:
            for k in self.publish_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['publishList'] = []
        if self.publish_list is not None:
            for k in self.publish_list:
                result['publishList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.publish_list = []
        if m.get('publishList') is not None:
            for k in m.get('publishList'):
                temp_model = BatchOrgCreateHWResponseBodyResultPublishList()
                self.publish_list.append(temp_model.from_map(k))
        return self


class BatchOrgCreateHWResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchOrgCreateHWResponseBodyResult = None,
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
            temp_model = BatchOrgCreateHWResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BatchOrgCreateHWResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchOrgCreateHWResponseBody = None,
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
            temp_model = BatchOrgCreateHWResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelOrderHeaders(TeaModel):
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


class CancelOrderRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        order_no: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        self.face_id = face_id
        self.order_no = order_no
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CancelOrderResponseBody(TeaModel):
    def __init__(
        self,
        need_retry: bool = None,
        trade_action: str = None,
    ):
        self.need_retry = need_retry
        self.trade_action = trade_action

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.need_retry is not None:
            result['needRetry'] = self.need_retry
        if self.trade_action is not None:
            result['tradeAction'] = self.trade_action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('needRetry') is not None:
            self.need_retry = m.get('needRetry')
        if m.get('tradeAction') is not None:
            self.trade_action = m.get('tradeAction')
        return self


class CancelOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelOrderResponseBody = None,
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
            temp_model = CancelOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelSnsOrderHeaders(TeaModel):
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


class CancelSnsOrderRequest(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        order_no: str = None,
        signature: str = None,
        timestamp: int = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.signature = signature
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class CancelSnsOrderResponseBody(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
        pay_status: int = None,
        refund_status: int = None,
        total_amount: int = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no
        self.pay_status = pay_status
        self.refund_status = refund_status
        self.total_amount = total_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.pay_status is not None:
            result['payStatus'] = self.pay_status
        if self.refund_status is not None:
            result['refundStatus'] = self.refund_status
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('payStatus') is not None:
            self.pay_status = m.get('payStatus')
        if m.get('refundStatus') is not None:
            self.refund_status = m.get('refundStatus')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        return self


class CancelSnsOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelSnsOrderResponseBody = None,
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
            temp_model = CancelSnsOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelUserOrderHeaders(TeaModel):
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


class CancelUserOrderRequest(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        order_no: str = None,
        signature: str = None,
        timestamp: int = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.signature = signature
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class CancelUserOrderResponseBody(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
        pay_status: int = None,
        refund_status: int = None,
        total_amount: int = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no
        self.pay_status = pay_status
        self.refund_status = refund_status
        self.total_amount = total_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.pay_status is not None:
            result['payStatus'] = self.pay_status
        if self.refund_status is not None:
            result['refundStatus'] = self.refund_status
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('payStatus') is not None:
            self.pay_status = m.get('payStatus')
        if m.get('refundStatus') is not None:
            self.refund_status = m.get('refundStatus')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        return self


class CancelUserOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelUserOrderResponseBody = None,
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
            temp_model = CancelUserOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckRestrictionHeaders(TeaModel):
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


class CheckRestrictionRequest(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        face_id: str = None,
        scene: int = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.actual_amount = actual_amount
        self.face_id = face_id
        self.scene = scene
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.scene is not None:
            result['scene'] = self.scene
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CheckRestrictionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CheckRestrictionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckRestrictionResponseBody = None,
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
            temp_model = CheckRestrictionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConsumePointHeaders(TeaModel):
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


class ConsumePointRequest(TeaModel):
    def __init__(
        self,
        amount: int = None,
        biz_id: str = None,
        description: str = None,
        product_code: str = None,
    ):
        self.amount = amount
        self.biz_id = biz_id
        self.description = description
        self.product_code = product_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.description is not None:
            result['description'] = self.description
        if self.product_code is not None:
            result['productCode'] = self.product_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        return self


class ConsumePointResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConsumePointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConsumePointResponseBody = None,
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
            temp_model = ConsumePointResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CourseSchedulingComplimentNoticeHeaders(TeaModel):
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


class CourseSchedulingComplimentNoticeRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
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


class CourseSchedulingComplimentNoticeResponseBody(TeaModel):
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


class CourseSchedulingComplimentNoticeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CourseSchedulingComplimentNoticeResponseBody = None,
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
            temp_model = CourseSchedulingComplimentNoticeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAppOrderHeaders(TeaModel):
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


class CreateAppOrderRequestDetailList(TeaModel):
    def __init__(
        self,
        goods_id: str = None,
        goods_name: str = None,
        goods_price: int = None,
        goods_quantity: int = None,
    ):
        self.goods_id = goods_id
        self.goods_name = goods_name
        self.goods_price = goods_price
        self.goods_quantity = goods_quantity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_id is not None:
            result['goodsId'] = self.goods_id
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.goods_price is not None:
            result['goodsPrice'] = self.goods_price
        if self.goods_quantity is not None:
            result['goodsQuantity'] = self.goods_quantity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsId') is not None:
            self.goods_id = m.get('goodsId')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('goodsPrice') is not None:
            self.goods_price = m.get('goodsPrice')
        if m.get('goodsQuantity') is not None:
            self.goods_quantity = m.get('goodsQuantity')
        return self


class CreateAppOrderRequest(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        biz_code: int = None,
        detail_list: List[CreateAppOrderRequestDetailList] = None,
        label_amount: int = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        outer_user_id: str = None,
        signature: str = None,
        subject: str = None,
        timestamp: int = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.biz_code = biz_code
        self.detail_list = detail_list
        self.label_amount = label_amount
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.outer_user_id = outer_user_id
        self.signature = signature
        self.subject = subject
        self.timestamp = timestamp

    def validate(self):
        if self.detail_list:
            for k in self.detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        result['detailList'] = []
        if self.detail_list is not None:
            for k in self.detail_list:
                result['detailList'].append(k.to_map() if k else None)
        if self.label_amount is not None:
            result['labelAmount'] = self.label_amount
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.outer_user_id is not None:
            result['outerUserId'] = self.outer_user_id
        if self.signature is not None:
            result['signature'] = self.signature
        if self.subject is not None:
            result['subject'] = self.subject
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        self.detail_list = []
        if m.get('detailList') is not None:
            for k in m.get('detailList'):
                temp_model = CreateAppOrderRequestDetailList()
                self.detail_list.append(temp_model.from_map(k))
        if m.get('labelAmount') is not None:
            self.label_amount = m.get('labelAmount')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('outerUserId') is not None:
            self.outer_user_id = m.get('outerUserId')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class CreateAppOrderResponseBody(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        body: str = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.body = body
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.body is not None:
            result['body'] = self.body
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class CreateAppOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAppOrderResponseBody = None,
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
            temp_model = CreateAppOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomClassHeaders(TeaModel):
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


class CreateCustomClassRequestCustomClass(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateCustomClassRequest(TeaModel):
    def __init__(
        self,
        custom_class: CreateCustomClassRequestCustomClass = None,
        operator: str = None,
        super_id: int = None,
    ):
        self.custom_class = custom_class
        self.operator = operator
        self.super_id = super_id

    def validate(self):
        if self.custom_class:
            self.custom_class.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_class is not None:
            result['customClass'] = self.custom_class.to_map()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customClass') is not None:
            temp_model = CreateCustomClassRequestCustomClass()
            self.custom_class = temp_model.from_map(m['customClass'])
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class CreateCustomClassResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CreateCustomClassResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateCustomClassResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateCustomClassResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateCustomClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateCustomClassResponseBody = None,
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
            temp_model = CreateCustomClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomDeptHeaders(TeaModel):
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


class CreateCustomDeptRequestCustomDept(TeaModel):
    def __init__(
        self,
        name: str = None,
        type: str = None,
    ):
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateCustomDeptRequest(TeaModel):
    def __init__(
        self,
        custom_dept: CreateCustomDeptRequestCustomDept = None,
        operator: str = None,
        super_id: int = None,
    ):
        self.custom_dept = custom_dept
        self.operator = operator
        self.super_id = super_id

    def validate(self):
        if self.custom_dept:
            self.custom_dept.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_dept is not None:
            result['customDept'] = self.custom_dept.to_map()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customDept') is not None:
            temp_model = CreateCustomDeptRequestCustomDept()
            self.custom_dept = temp_model.from_map(m['customDept'])
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class CreateCustomDeptResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CreateCustomDeptResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateCustomDeptResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateCustomDeptResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateCustomDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateCustomDeptResponseBody = None,
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
            temp_model = CreateCustomDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEduAssetSpaceHeaders(TeaModel):
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


class CreateEduAssetSpaceRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        space_desc: str = None,
        space_icon: str = None,
        space_name: str = None,
        user_id: str = None,
    ):
        self.biz_code = biz_code
        self.space_desc = space_desc
        self.space_icon = space_icon
        self.space_name = space_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.space_desc is not None:
            result['spaceDesc'] = self.space_desc
        if self.space_icon is not None:
            result['spaceIcon'] = self.space_icon
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('spaceDesc') is not None:
            self.space_desc = m.get('spaceDesc')
        if m.get('spaceIcon') is not None:
            self.space_icon = m.get('spaceIcon')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateEduAssetSpaceResponseBody(TeaModel):
    def __init__(
        self,
        create_time_millis: int = None,
        modify_time_millis: int = None,
        permission_mode: str = None,
        quota: int = None,
        space_id: str = None,
        space_name: str = None,
        space_type: str = None,
        used_quota: int = None,
    ):
        self.create_time_millis = create_time_millis
        self.modify_time_millis = modify_time_millis
        self.permission_mode = permission_mode
        self.quota = quota
        self.space_id = space_id
        self.space_name = space_name
        self.space_type = space_type
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_millis is not None:
            result['createTimeMillis'] = self.create_time_millis
        if self.modify_time_millis is not None:
            result['modifyTimeMillis'] = self.modify_time_millis
        if self.permission_mode is not None:
            result['permissionMode'] = self.permission_mode
        if self.quota is not None:
            result['quota'] = self.quota
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeMillis') is not None:
            self.create_time_millis = m.get('createTimeMillis')
        if m.get('modifyTimeMillis') is not None:
            self.modify_time_millis = m.get('modifyTimeMillis')
        if m.get('permissionMode') is not None:
            self.permission_mode = m.get('permissionMode')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class CreateEduAssetSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateEduAssetSpaceResponseBody = None,
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
            temp_model = CreateEduAssetSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateFulfilRecordHeaders(TeaModel):
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


class CreateFulfilRecordRequest(TeaModel):
    def __init__(
        self,
        biz_time: int = None,
        ext_info: str = None,
        face_id: str = None,
        scene: int = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.biz_time = biz_time
        self.ext_info = ext_info
        self.face_id = face_id
        self.scene = scene
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_time is not None:
            result['bizTime'] = self.biz_time
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.scene is not None:
            result['scene'] = self.scene
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTime') is not None:
            self.biz_time = m.get('bizTime')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateFulfilRecordResponseBody(TeaModel):
    def __init__(
        self,
        success_info: str = None,
    ):
        self.success_info = success_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success_info is not None:
            result['successInfo'] = self.success_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('successInfo') is not None:
            self.success_info = m.get('successInfo')
        return self


class CreateFulfilRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateFulfilRecordResponseBody = None,
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
            temp_model = CreateFulfilRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateInviteUrlHeaders(TeaModel):
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


class CreateInviteUrlRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        target_corp_id: str = None,
        target_operator: str = None,
    ):
        self.auth_code = auth_code
        self.target_corp_id = target_corp_id
        self.target_operator = target_operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.target_operator is not None:
            result['targetOperator'] = self.target_operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('targetOperator') is not None:
            self.target_operator = m.get('targetOperator')
        return self


class CreateInviteUrlResponseBodyResult(TeaModel):
    def __init__(
        self,
        invite_url: str = None,
    ):
        self.invite_url = invite_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_url is not None:
            result['inviteUrl'] = self.invite_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteUrl') is not None:
            self.invite_url = m.get('inviteUrl')
        return self


class CreateInviteUrlResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateInviteUrlResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateInviteUrlResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateInviteUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateInviteUrlResponseBody = None,
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
            temp_model = CreateInviteUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateItemHeaders(TeaModel):
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


class CreateItemRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        effect_type: int = None,
        end_time: int = None,
        merchant_id: str = None,
        name: str = None,
        opt_user: str = None,
        period_type: int = None,
        price: int = None,
        scene: int = None,
        start_time: int = None,
        status: int = None,
        type: int = None,
    ):
        self.description = description
        self.effect_type = effect_type
        self.end_time = end_time
        self.merchant_id = merchant_id
        self.name = name
        self.opt_user = opt_user
        self.period_type = period_type
        self.price = price
        self.scene = scene
        self.start_time = start_time
        self.status = status
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.effect_type is not None:
            result['effectType'] = self.effect_type
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.name is not None:
            result['name'] = self.name
        if self.opt_user is not None:
            result['optUser'] = self.opt_user
        if self.period_type is not None:
            result['periodType'] = self.period_type
        if self.price is not None:
            result['price'] = self.price
        if self.scene is not None:
            result['scene'] = self.scene
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('effectType') is not None:
            self.effect_type = m.get('effectType')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('optUser') is not None:
            self.opt_user = m.get('optUser')
        if m.get('periodType') is not None:
            self.period_type = m.get('periodType')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateItemResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: int = None,
        merchant_id: str = None,
        status: int = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.merchant_id = merchant_id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateItemResponseBody = None,
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
            temp_model = CreateItemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateOrderHeaders(TeaModel):
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


class CreateOrderRequestDetailList(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        item_amount: int = None,
        item_name: str = None,
        scene: int = None,
    ):
        self.actual_amount = actual_amount
        self.item_amount = item_amount
        self.item_name = item_name
        self.scene = scene

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.item_amount is not None:
            result['itemAmount'] = self.item_amount
        if self.item_name is not None:
            result['itemName'] = self.item_name
        if self.scene is not None:
            result['scene'] = self.scene
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('itemAmount') is not None:
            self.item_amount = m.get('itemAmount')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        return self


class CreateOrderRequest(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        create_time: int = None,
        detail_list: List[CreateOrderRequestDetailList] = None,
        face_id: str = None,
        ftoken: str = None,
        signature: str = None,
        sn: str = None,
        terminal_params: str = None,
        timestamp: int = None,
        total_amount: int = None,
        user_id: str = None,
        version: str = None,
    ):
        self.actual_amount = actual_amount
        self.create_time = create_time
        self.detail_list = detail_list
        self.face_id = face_id
        self.ftoken = ftoken
        self.signature = signature
        self.sn = sn
        self.terminal_params = terminal_params
        self.timestamp = timestamp
        self.total_amount = total_amount
        self.user_id = user_id
        self.version = version

    def validate(self):
        if self.detail_list:
            for k in self.detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.create_time is not None:
            result['createTime'] = self.create_time
        result['detailList'] = []
        if self.detail_list is not None:
            for k in self.detail_list:
                result['detailList'].append(k.to_map() if k else None)
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.ftoken is not None:
            result['ftoken'] = self.ftoken
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.terminal_params is not None:
            result['terminalParams'] = self.terminal_params
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        self.detail_list = []
        if m.get('detailList') is not None:
            for k in m.get('detailList'):
                temp_model = CreateOrderRequestDetailList()
                self.detail_list.append(temp_model.from_map(k))
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('ftoken') is not None:
            self.ftoken = m.get('ftoken')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('terminalParams') is not None:
            self.terminal_params = m.get('terminalParams')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CreateOrderResponseBody(TeaModel):
    def __init__(
        self,
        order_no: str = None,
    ):
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class CreateOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateOrderResponseBody = None,
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
            temp_model = CreateOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateOrderFlowHeaders(TeaModel):
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


class CreateOrderFlowRequestDetailList(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        item_amount: int = None,
        item_id: int = None,
        item_name: str = None,
        scene: int = None,
    ):
        self.actual_amount = actual_amount
        self.item_amount = item_amount
        self.item_id = item_id
        self.item_name = item_name
        self.scene = scene

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.item_amount is not None:
            result['itemAmount'] = self.item_amount
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.item_name is not None:
            result['itemName'] = self.item_name
        if self.scene is not None:
            result['scene'] = self.scene
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('itemAmount') is not None:
            self.item_amount = m.get('itemAmount')
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        return self


class CreateOrderFlowRequest(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_uid: str = None,
        create_time: int = None,
        detail_list: List[CreateOrderFlowRequestDetailList] = None,
        face_id: str = None,
        guardian_user_id: str = None,
        merchant_id: str = None,
        order_no: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        total_amount: int = None,
        user_id: str = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_uid = alipay_uid
        self.create_time = create_time
        self.detail_list = detail_list
        self.face_id = face_id
        self.guardian_user_id = guardian_user_id
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.total_amount = total_amount
        self.user_id = user_id

    def validate(self):
        if self.detail_list:
            for k in self.detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_uid is not None:
            result['alipayUid'] = self.alipay_uid
        if self.create_time is not None:
            result['createTime'] = self.create_time
        result['detailList'] = []
        if self.detail_list is not None:
            for k in self.detail_list:
                result['detailList'].append(k.to_map() if k else None)
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.guardian_user_id is not None:
            result['guardianUserId'] = self.guardian_user_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayUid') is not None:
            self.alipay_uid = m.get('alipayUid')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        self.detail_list = []
        if m.get('detailList') is not None:
            for k in m.get('detailList'):
                temp_model = CreateOrderFlowRequestDetailList()
                self.detail_list.append(temp_model.from_map(k))
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('guardianUserId') is not None:
            self.guardian_user_id = m.get('guardianUserId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateOrderFlowResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateOrderFlowResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateOrderFlowResponseBody = None,
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
            temp_model = CreateOrderFlowResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreatePhysicalClassroomHeaders(TeaModel):
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


class CreatePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        classroom_building: str = None,
        classroom_campus: str = None,
        classroom_floor: str = None,
        classroom_name: str = None,
        classroom_number: str = None,
        direct_broadcast: str = None,
        ext: str = None,
        op_user_id: str = None,
    ):
        self.classroom_building = classroom_building
        self.classroom_campus = classroom_campus
        self.classroom_floor = classroom_floor
        self.classroom_name = classroom_name
        self.classroom_number = classroom_number
        self.direct_broadcast = direct_broadcast
        self.ext = ext
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        if self.ext is not None:
            result['ext'] = self.ext
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreatePhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
    ):
        self.classroom_id = classroom_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class CreatePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreatePhysicalClassroomResponseBody = None,
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
            temp_model = CreatePhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRefundFlowHeaders(TeaModel):
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


class CreateRefundFlowRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        operator_id: str = None,
        operator_name: str = None,
        order_no: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        self.face_id = face_id
        self.operator_id = operator_id
        self.operator_name = operator_name
        self.order_no = order_no
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateRefundFlowResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateRefundFlowResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRefundFlowResponseBody = None,
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
            temp_model = CreateRefundFlowResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRemoteClassCourseHeaders(TeaModel):
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


class CreateRemoteClassCourseRequestAttendParticipants(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        participant_id: str = None,
    ):
        self.corp_id = corp_id
        self.participant_id = participant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        return self


class CreateRemoteClassCourseRequestTeachingParticipant(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        participant_id: str = None,
    ):
        self.corp_id = corp_id
        self.participant_id = participant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        return self


class CreateRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        attend_participants: List[CreateRemoteClassCourseRequestAttendParticipants] = None,
        auth_code: str = None,
        course_name: str = None,
        end_time: int = None,
        start_time: int = None,
        teaching_participant: CreateRemoteClassCourseRequestTeachingParticipant = None,
    ):
        self.attend_participants = attend_participants
        self.auth_code = auth_code
        self.course_name = course_name
        self.end_time = end_time
        self.start_time = start_time
        self.teaching_participant = teaching_participant

    def validate(self):
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()
        if self.teaching_participant:
            self.teaching_participant.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = CreateRemoteClassCourseRequestAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teachingParticipant') is not None:
            temp_model = CreateRemoteClassCourseRequestTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        return self


class CreateRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        course_code: str = None,
    ):
        self.course_code = course_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        return self


class CreateRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateRemoteClassCourseResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateRemoteClassCourseResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRemoteClassCourseResponseBody = None,
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
            temp_model = CreateRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSectionConfigHeaders(TeaModel):
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


class CreateSectionConfigRequestSectionConfigsSectionEndDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class CreateSectionConfigRequestSectionConfigsSectionModels(TeaModel):
    def __init__(
        self,
        section_end_time: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime = None,
        section_index: int = None,
        section_name: str = None,
        section_start_time: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime = None,
        section_type: str = None,
    ):
        self.section_end_time = section_end_time
        self.section_index = section_index
        self.section_name = section_name
        self.section_start_time = section_start_time
        self.section_type = section_type

    def validate(self):
        if self.section_end_time:
            self.section_end_time.validate()
        if self.section_start_time:
            self.section_start_time.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_end_time is not None:
            result['sectionEndTime'] = self.section_end_time.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_start_time is not None:
            result['sectionStartTime'] = self.section_start_time.to_map()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionEndTime') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime()
            self.section_end_time = temp_model.from_map(m['sectionEndTime'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionStartTime') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime()
            self.section_start_time = temp_model.from_map(m['sectionStartTime'])
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        return self


class CreateSectionConfigRequestSectionConfigsSectionStartDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateSectionConfigRequestSectionConfigsSemesterEndDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateSectionConfigRequestSectionConfigsSemesterStartDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateSectionConfigRequestSectionConfigs(TeaModel):
    def __init__(
        self,
        schedule_name: str = None,
        school_year: str = None,
        section_end_date: CreateSectionConfigRequestSectionConfigsSectionEndDate = None,
        section_models: List[CreateSectionConfigRequestSectionConfigsSectionModels] = None,
        section_start_date: CreateSectionConfigRequestSectionConfigsSectionStartDate = None,
        semester: int = None,
        semester_end_date: CreateSectionConfigRequestSectionConfigsSemesterEndDate = None,
        semester_start_date: CreateSectionConfigRequestSectionConfigsSemesterStartDate = None,
    ):
        self.schedule_name = schedule_name
        self.school_year = school_year
        self.section_end_date = section_end_date
        self.section_models = section_models
        self.section_start_date = section_start_date
        self.semester = semester
        self.semester_end_date = semester_end_date
        self.semester_start_date = semester_start_date

    def validate(self):
        if self.section_end_date:
            self.section_end_date.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.section_start_date:
            self.section_start_date.validate()
        if self.semester_end_date:
            self.semester_end_date.validate()
        if self.semester_start_date:
            self.semester_start_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.schedule_name is not None:
            result['scheduleName'] = self.schedule_name
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.section_end_date is not None:
            result['sectionEndDate'] = self.section_end_date.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.section_start_date is not None:
            result['sectionStartDate'] = self.section_start_date.to_map()
        if self.semester is not None:
            result['semester'] = self.semester
        if self.semester_end_date is not None:
            result['semesterEndDate'] = self.semester_end_date.to_map()
        if self.semester_start_date is not None:
            result['semesterStartDate'] = self.semester_start_date.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scheduleName') is not None:
            self.schedule_name = m.get('scheduleName')
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('sectionEndDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionEndDate()
            self.section_end_date = temp_model.from_map(m['sectionEndDate'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = CreateSectionConfigRequestSectionConfigsSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('sectionStartDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionStartDate()
            self.section_start_date = temp_model.from_map(m['sectionStartDate'])
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('semesterEndDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSemesterEndDate()
            self.semester_end_date = temp_model.from_map(m['semesterEndDate'])
        if m.get('semesterStartDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSemesterStartDate()
            self.semester_start_date = temp_model.from_map(m['semesterStartDate'])
        return self


class CreateSectionConfigRequest(TeaModel):
    def __init__(
        self,
        ext: str = None,
        section_configs: List[CreateSectionConfigRequestSectionConfigs] = None,
        op_user_id: str = None,
    ):
        self.ext = ext
        self.section_configs = section_configs
        self.op_user_id = op_user_id

    def validate(self):
        if self.section_configs:
            for k in self.section_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext is not None:
            result['ext'] = self.ext
        result['sectionConfigs'] = []
        if self.section_configs is not None:
            for k in self.section_configs:
                result['sectionConfigs'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        self.section_configs = []
        if m.get('sectionConfigs') is not None:
            for k in m.get('sectionConfigs'):
                temp_model = CreateSectionConfigRequestSectionConfigs()
                self.section_configs.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreateSectionConfigResponseBody(TeaModel):
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


class CreateSectionConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSectionConfigResponseBody = None,
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
            temp_model = CreateSectionConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSnsAppOrderHeaders(TeaModel):
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


class CreateSnsAppOrderRequestDetailList(TeaModel):
    def __init__(
        self,
        goods_id: str = None,
        goods_name: str = None,
        goods_price: int = None,
        goods_quantity: int = None,
    ):
        self.goods_id = goods_id
        self.goods_name = goods_name
        self.goods_price = goods_price
        self.goods_quantity = goods_quantity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_id is not None:
            result['goodsId'] = self.goods_id
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.goods_price is not None:
            result['goodsPrice'] = self.goods_price
        if self.goods_quantity is not None:
            result['goodsQuantity'] = self.goods_quantity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsId') is not None:
            self.goods_id = m.get('goodsId')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('goodsPrice') is not None:
            self.goods_price = m.get('goodsPrice')
        if m.get('goodsQuantity') is not None:
            self.goods_quantity = m.get('goodsQuantity')
        return self


class CreateSnsAppOrderRequest(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        biz_code: int = None,
        detail_list: List[CreateSnsAppOrderRequestDetailList] = None,
        label_amount: int = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        signature: str = None,
        subject: str = None,
        timestamp: int = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.biz_code = biz_code
        self.detail_list = detail_list
        self.label_amount = label_amount
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.signature = signature
        self.subject = subject
        self.timestamp = timestamp

    def validate(self):
        if self.detail_list:
            for k in self.detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        result['detailList'] = []
        if self.detail_list is not None:
            for k in self.detail_list:
                result['detailList'].append(k.to_map() if k else None)
        if self.label_amount is not None:
            result['labelAmount'] = self.label_amount
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.subject is not None:
            result['subject'] = self.subject
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        self.detail_list = []
        if m.get('detailList') is not None:
            for k in m.get('detailList'):
                temp_model = CreateSnsAppOrderRequestDetailList()
                self.detail_list.append(temp_model.from_map(k))
        if m.get('labelAmount') is not None:
            self.label_amount = m.get('labelAmount')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class CreateSnsAppOrderResponseBody(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        body: str = None,
        merchant_id: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.body = body
        self.merchant_id = merchant_id
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.body is not None:
            result['body'] = self.body
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class CreateSnsAppOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSnsAppOrderResponseBody = None,
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
            temp_model = CreateSnsAppOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateStsTokenHeaders(TeaModel):
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


class CreateStsTokenRequest(TeaModel):
    def __init__(
        self,
        device_sn: str = None,
        sts_type: str = None,
    ):
        self.device_sn = device_sn
        self.sts_type = sts_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        if self.sts_type is not None:
            result['stsType'] = self.sts_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        if m.get('stsType') is not None:
            self.sts_type = m.get('stsType')
        return self


class CreateStsTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        expiration: str = None,
        ext_info: str = None,
        security_token: str = None,
        status: str = None,
    ):
        self.access_key_id = access_key_id
        self.access_key_secret = access_key_secret
        self.expiration = expiration
        self.ext_info = ext_info
        self.security_token = security_token
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.expiration is not None:
            result['expiration'] = self.expiration
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.security_token is not None:
            result['securityToken'] = self.security_token
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('expiration') is not None:
            self.expiration = m.get('expiration')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('securityToken') is not None:
            self.security_token = m.get('securityToken')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateStsTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateStsTokenResponseBody = None,
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
            temp_model = CreateStsTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTokenHeaders(TeaModel):
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


class CreateTokenRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
        type: str = None,
    ):
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        expiration: str = None,
        ext_info: str = None,
        security_token: str = None,
        status: str = None,
    ):
        self.access_key_id = access_key_id
        self.access_key_secret = access_key_secret
        self.expiration = expiration
        self.ext_info = ext_info
        self.security_token = security_token
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.expiration is not None:
            result['expiration'] = self.expiration
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.security_token is not None:
            result['securityToken'] = self.security_token
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('expiration') is not None:
            self.expiration = m.get('expiration')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('securityToken') is not None:
            self.security_token = m.get('securityToken')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTokenResponseBody = None,
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
            temp_model = CreateTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUniversityCourseGroupHeaders(TeaModel):
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


class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class CreateUniversityCourseGroupRequestCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        class_period_type: int = None,
        classroom_id: int = None,
        course_type: int = None,
        courser_group_item_end_date: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate = None,
        courser_group_item_start_date: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate = None,
        day_of_week: int = None,
        section_index: List[int] = None,
    ):
        self.class_period_type = class_period_type
        self.classroom_id = classroom_id
        self.course_type = course_type
        self.courser_group_item_end_date = courser_group_item_end_date
        self.courser_group_item_start_date = courser_group_item_start_date
        self.day_of_week = day_of_week
        self.section_index = section_index

    def validate(self):
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        return self


class CreateUniversityCourseGroupRequestTeacherInfos(TeaModel):
    def __init__(
        self,
        participant_role: str = None,
        user_id: str = None,
    ):
        self.participant_role = participant_role
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_role is not None:
            result['participantRole'] = self.participant_role
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantRole') is not None:
            self.participant_role = m.get('participantRole')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_introduce: str = None,
        course_group_name: str = None,
        courser_group_item_models: List[CreateUniversityCourseGroupRequestCourserGroupItemModels] = None,
        ext: str = None,
        isv_course_group_code: str = None,
        period_code: str = None,
        school_year: str = None,
        semester: int = None,
        subject_name: str = None,
        teacher_infos: List[CreateUniversityCourseGroupRequestTeacherInfos] = None,
        op_user_id: str = None,
    ):
        self.course_group_introduce = course_group_introduce
        self.course_group_name = course_group_name
        self.courser_group_item_models = courser_group_item_models
        self.ext = ext
        self.isv_course_group_code = isv_course_group_code
        self.period_code = period_code
        self.school_year = school_year
        self.semester = semester
        self.subject_name = subject_name
        self.teacher_infos = teacher_infos
        self.op_user_id = op_user_id

    def validate(self):
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()
        if self.teacher_infos:
            for k in self.teacher_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_course_group_code is not None:
            result['isvCourseGroupCode'] = self.isv_course_group_code
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.semester is not None:
            result['semester'] = self.semester
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        result['teacherInfos'] = []
        if self.teacher_infos is not None:
            for k in self.teacher_infos:
                result['teacherInfos'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCourseGroupCode') is not None:
            self.isv_course_group_code = m.get('isvCourseGroupCode')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        self.teacher_infos = []
        if m.get('teacherInfos') is not None:
            for k in m.get('teacherInfos'):
                temp_model = CreateUniversityCourseGroupRequestTeacherInfos()
                self.teacher_infos.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreateUniversityCourseGroupResponseBodyCourseGroupInfo(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
    ):
        self.course_group_code = course_group_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        return self


class CreateUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        course_group_info: CreateUniversityCourseGroupResponseBodyCourseGroupInfo = None,
    ):
        self.course_group_info = course_group_info

    def validate(self):
        if self.course_group_info:
            self.course_group_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_info is not None:
            result['courseGroupInfo'] = self.course_group_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupInfo') is not None:
            temp_model = CreateUniversityCourseGroupResponseBodyCourseGroupInfo()
            self.course_group_info = temp_model.from_map(m['courseGroupInfo'])
        return self


class CreateUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUniversityCourseGroupResponseBody = None,
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
            temp_model = CreateUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUniversityStudentHeaders(TeaModel):
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


class CreateUniversityStudentRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        gender: str = None,
        identity_number: str = None,
        mobile: str = None,
        name: str = None,
        student_number: str = None,
        op_user_id: str = None,
    ):
        self.class_id = class_id
        self.gender = gender
        self.identity_number = identity_number
        self.mobile = mobile
        self.name = name
        self.student_number = student_number
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identity_number is not None:
            result['identityNumber'] = self.identity_number
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identityNumber') is not None:
            self.identity_number = m.get('identityNumber')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreateUniversityStudentResponseBody(TeaModel):
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


class CreateUniversityStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUniversityStudentResponseBody = None,
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
            temp_model = CreateUniversityStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUniversityTeacherHeaders(TeaModel):
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


class CreateUniversityTeacherRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        op_user_id: str = None,
        role: str = None,
        teacher_user_id: str = None,
    ):
        self.class_id = class_id
        self.op_user_id = op_user_id
        self.role = role
        self.teacher_user_id = teacher_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.role is not None:
            result['role'] = self.role
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        return self


class CreateUniversityTeacherResponseBody(TeaModel):
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


class CreateUniversityTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUniversityTeacherResponseBody = None,
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
            temp_model = CreateUniversityTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeactivateDeviceHeaders(TeaModel):
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


class DeactivateDeviceRequest(TeaModel):
    def __init__(
        self,
        model: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.model = model
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.model is not None:
            result['model'] = self.model
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DeactivateDeviceResponseBody(TeaModel):
    def __init__(
        self,
        activate_times: int = None,
    ):
        self.activate_times = activate_times

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activate_times is not None:
            result['activateTimes'] = self.activate_times
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activateTimes') is not None:
            self.activate_times = m.get('activateTimes')
        return self


class DeactivateDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeactivateDeviceResponseBody = None,
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
            temp_model = DeactivateDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeductPointHeaders(TeaModel):
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


class DeductPointRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        deduct_desc: str = None,
        deduct_detail_url: str = None,
        deduct_num: int = None,
        point_type: str = None,
    ):
        self.biz_id = biz_id
        self.deduct_desc = deduct_desc
        self.deduct_detail_url = deduct_detail_url
        self.deduct_num = deduct_num
        self.point_type = point_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.deduct_desc is not None:
            result['deductDesc'] = self.deduct_desc
        if self.deduct_detail_url is not None:
            result['deductDetailUrl'] = self.deduct_detail_url
        if self.deduct_num is not None:
            result['deductNum'] = self.deduct_num
        if self.point_type is not None:
            result['pointType'] = self.point_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('deductDesc') is not None:
            self.deduct_desc = m.get('deductDesc')
        if m.get('deductDetailUrl') is not None:
            self.deduct_detail_url = m.get('deductDetailUrl')
        if m.get('deductNum') is not None:
            self.deduct_num = m.get('deductNum')
        if m.get('pointType') is not None:
            self.point_type = m.get('pointType')
        return self


class DeductPointResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeductPointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeductPointResponseBody = None,
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
            temp_model = DeductPointResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDeptHeaders(TeaModel):
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


class DeleteDeptRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteDeptResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDeptResponseBody = None,
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
            temp_model = DeleteDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDeviceHeaders(TeaModel):
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


class DeleteDeviceRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
    ):
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class DeleteDeviceResponseBody(TeaModel):
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


class DeleteDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDeviceResponseBody = None,
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
            temp_model = DeleteDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDeviceOrgHeaders(TeaModel):
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


class DeleteDeviceOrgRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        device_code: str = None,
    ):
        self.auth_code = auth_code
        self.device_code = device_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        return self


class DeleteDeviceOrgResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteDeviceOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDeviceOrgResponseBody = None,
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
            temp_model = DeleteDeviceOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteGuardianHeaders(TeaModel):
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


class DeleteGuardianRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        stu_id: str = None,
    ):
        self.operator = operator
        self.stu_id = stu_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.stu_id is not None:
            result['stuId'] = self.stu_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('stuId') is not None:
            self.stu_id = m.get('stuId')
        return self


class DeleteGuardianResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteGuardianResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteGuardianResponseBody = None,
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
            temp_model = DeleteGuardianResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteOrgRelationHeaders(TeaModel):
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


class DeleteOrgRelationRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        target_corp_id: str = None,
    ):
        self.auth_code = auth_code
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class DeleteOrgRelationResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteOrgRelationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteOrgRelationResponseBody = None,
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
            temp_model = DeleteOrgRelationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeletePhysicalClassroomHeaders(TeaModel):
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


class DeletePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
        op_user_id: str = None,
    ):
        self.classroom_id = classroom_id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeletePhysicalClassroomResponseBody(TeaModel):
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


class DeletePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeletePhysicalClassroomResponseBody = None,
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
            temp_model = DeletePhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRemoteClassCourseHeaders(TeaModel):
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


class DeleteRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
    ):
        self.auth_code = auth_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class DeleteRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRemoteClassCourseResponseBody = None,
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
            temp_model = DeleteRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteStudentHeaders(TeaModel):
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


class DeleteStudentRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteStudentResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteStudentResponseBody = None,
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
            temp_model = DeleteStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTeacherHeaders(TeaModel):
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


class DeleteTeacherRequest(TeaModel):
    def __init__(
        self,
        adviser: int = None,
        operator: str = None,
    ):
        self.adviser = adviser
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.adviser is not None:
            result['adviser'] = self.adviser
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('adviser') is not None:
            self.adviser = m.get('adviser')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteTeacherResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTeacherResponseBody = None,
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
            temp_model = DeleteTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteUniversityCourseGroupHeaders(TeaModel):
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


class DeleteUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        op_user_id: str = None,
    ):
        self.course_group_code = course_group_code
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeleteUniversityCourseGroupResponseBody(TeaModel):
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


class DeleteUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteUniversityCourseGroupResponseBody = None,
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
            temp_model = DeleteUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteUniversityStudentHeaders(TeaModel):
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


class DeleteUniversityStudentRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        op_user_id: str = None,
        student_user_id: str = None,
    ):
        self.class_id = class_id
        self.op_user_id = op_user_id
        self.student_user_id = student_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.student_user_id is not None:
            result['studentUserId'] = self.student_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('studentUserId') is not None:
            self.student_user_id = m.get('studentUserId')
        return self


class DeleteUniversityStudentResponseBody(TeaModel):
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


class DeleteUniversityStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteUniversityStudentResponseBody = None,
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
            temp_model = DeleteUniversityStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteUniversityTeacherHeaders(TeaModel):
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


class DeleteUniversityTeacherRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        op_user_id: str = None,
        role: str = None,
        teacher_user_id: str = None,
    ):
        self.class_id = class_id
        self.op_user_id = op_user_id
        self.role = role
        self.teacher_user_id = teacher_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.role is not None:
            result['role'] = self.role
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        return self


class DeleteUniversityTeacherResponseBody(TeaModel):
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


class DeleteUniversityTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteUniversityTeacherResponseBody = None,
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
            temp_model = DeleteUniversityTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceHeartbeatHeaders(TeaModel):
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


class DeviceHeartbeatRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
    ):
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class DeviceHeartbeatResponseBody(TeaModel):
    def __init__(
        self,
        command: int = None,
    ):
        self.command = command

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.command is not None:
            result['command'] = self.command
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('command') is not None:
            self.command = m.get('command')
        return self


class DeviceHeartbeatResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceHeartbeatResponseBody = None,
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
            temp_model = DeviceHeartbeatResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EduTeacherListHeaders(TeaModel):
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


class EduTeacherListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
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


class EduTeacherListResponseBodyResultTeacherDetails(TeaModel):
    def __init__(
        self,
        name: str = None,
        role: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.role = role
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.role is not None:
            result['role'] = self.role
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class EduTeacherListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        teacher_details: List[EduTeacherListResponseBodyResultTeacherDetails] = None,
    ):
        self.has_more = has_more
        self.teacher_details = teacher_details

    def validate(self):
        if self.teacher_details:
            for k in self.teacher_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['teacherDetails'] = []
        if self.teacher_details is not None:
            for k in self.teacher_details:
                result['teacherDetails'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.teacher_details = []
        if m.get('teacherDetails') is not None:
            for k in m.get('teacherDetails'):
                temp_model = EduTeacherListResponseBodyResultTeacherDetails()
                self.teacher_details.append(temp_model.from_map(k))
        return self


class EduTeacherListResponseBody(TeaModel):
    def __init__(
        self,
        result: EduTeacherListResponseBodyResult = None,
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
            temp_model = EduTeacherListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class EduTeacherListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EduTeacherListResponseBody = None,
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
            temp_model = EduTeacherListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EndCourseHeaders(TeaModel):
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


class EndCourseRequestLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_input_url: str = None,
        live_output_flv_url: str = None,
        live_output_hls_url: str = None,
        live_type: int = None,
        replay_url: str = None,
    ):
        self.live_input_url = live_input_url
        self.live_output_flv_url = live_output_flv_url
        self.live_output_hls_url = live_output_hls_url
        self.live_type = live_type
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.live_output_flv_url is not None:
            result['liveOutputFlvUrl'] = self.live_output_flv_url
        if self.live_output_hls_url is not None:
            result['liveOutputHlsUrl'] = self.live_output_hls_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('liveOutputFlvUrl') is not None:
            self.live_output_flv_url = m.get('liveOutputFlvUrl')
        if m.get('liveOutputHlsUrl') is not None:
            self.live_output_hls_url = m.get('liveOutputHlsUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class EndCourseRequest(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        ext: str = None,
        isv_code: str = None,
        live_play_info_list: List[EndCourseRequestLivePlayInfoList] = None,
        op_user_id: str = None,
    ):
        self.course_code = course_code
        self.ext = ext
        self.isv_code = isv_code
        self.live_play_info_list = live_play_info_list
        self.op_user_id = op_user_id

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = EndCourseRequestLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class EndCourseResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        success: bool = None,
    ):
        self.course_code = course_code
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EndCourseResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: EndCourseResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = EndCourseResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class EndCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EndCourseResponseBody = None,
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
            temp_model = EndCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBindChildInfoHeaders(TeaModel):
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


class GetBindChildInfoRequest(TeaModel):
    def __init__(
        self,
        school_corp_id: str = None,
        student_user_id: str = None,
        union_id: str = None,
    ):
        self.school_corp_id = school_corp_id
        self.student_user_id = student_user_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.school_corp_id is not None:
            result['schoolCorpId'] = self.school_corp_id
        if self.student_user_id is not None:
            result['studentUserId'] = self.student_user_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('schoolCorpId') is not None:
            self.school_corp_id = m.get('schoolCorpId')
        if m.get('studentUserId') is not None:
            self.student_user_id = m.get('studentUserId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetBindChildInfoResponseBody(TeaModel):
    def __init__(
        self,
        child_user_id: str = None,
        current_user_id: str = None,
        family_corp_id: str = None,
    ):
        self.child_user_id = child_user_id
        self.current_user_id = current_user_id
        self.family_corp_id = family_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_user_id is not None:
            result['childUserId'] = self.child_user_id
        if self.current_user_id is not None:
            result['currentUserId'] = self.current_user_id
        if self.family_corp_id is not None:
            result['familyCorpId'] = self.family_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childUserId') is not None:
            self.child_user_id = m.get('childUserId')
        if m.get('currentUserId') is not None:
            self.current_user_id = m.get('currentUserId')
        if m.get('familyCorpId') is not None:
            self.family_corp_id = m.get('familyCorpId')
        return self


class GetBindChildInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBindChildInfoResponseBody = None,
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
            temp_model = GetBindChildInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDefaultChildHeaders(TeaModel):
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


class GetDefaultChildResponseBodyBindStudents(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        corp_id: str = None,
        period: str = None,
        staff_id: str = None,
    ):
        self.class_id = class_id
        self.corp_id = corp_id
        self.period = period
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.period is not None:
            result['period'] = self.period
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class GetDefaultChildResponseBody(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        bind_students: List[GetDefaultChildResponseBodyBindStudents] = None,
        grade: int = None,
        name: str = None,
        nick: str = None,
        period: str = None,
        union_id: str = None,
    ):
        self.avatar = avatar
        self.bind_students = bind_students
        self.grade = grade
        self.name = name
        self.nick = nick
        self.period = period
        self.union_id = union_id

    def validate(self):
        if self.bind_students:
            for k in self.bind_students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        result['bindStudents'] = []
        if self.bind_students is not None:
            for k in self.bind_students:
                result['bindStudents'].append(k.to_map() if k else None)
        if self.grade is not None:
            result['grade'] = self.grade
        if self.name is not None:
            result['name'] = self.name
        if self.nick is not None:
            result['nick'] = self.nick
        if self.period is not None:
            result['period'] = self.period
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        self.bind_students = []
        if m.get('bindStudents') is not None:
            for k in m.get('bindStudents'):
                temp_model = GetDefaultChildResponseBodyBindStudents()
                self.bind_students.append(temp_model.from_map(k))
        if m.get('grade') is not None:
            self.grade = m.get('grade')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetDefaultChildResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDefaultChildResponseBody = None,
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
            temp_model = GetDefaultChildResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEduUserIdentityHeaders(TeaModel):
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


class GetEduUserIdentityRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetEduUserIdentityResponseBodyData(TeaModel):
    def __init__(
        self,
        match_guardian_rule: bool = None,
        match_teacher_rule: bool = None,
        union_id: str = None,
    ):
        self.match_guardian_rule = match_guardian_rule
        self.match_teacher_rule = match_teacher_rule
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.match_guardian_rule is not None:
            result['matchGuardianRule'] = self.match_guardian_rule
        if self.match_teacher_rule is not None:
            result['matchTeacherRule'] = self.match_teacher_rule
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('matchGuardianRule') is not None:
            self.match_guardian_rule = m.get('matchGuardianRule')
        if m.get('matchTeacherRule') is not None:
            self.match_teacher_rule = m.get('matchTeacherRule')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetEduUserIdentityResponseBody(TeaModel):
    def __init__(
        self,
        data: GetEduUserIdentityResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetEduUserIdentityResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetEduUserIdentityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEduUserIdentityResponseBody = None,
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
            temp_model = GetEduUserIdentityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOpenCourseDetailHeaders(TeaModel):
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


class GetOpenCourseDetailResponseBodyPushModel(TeaModel):
    def __init__(
        self,
        push_org_name_list: List[str] = None,
        push_role_name_list: List[str] = None,
    ):
        self.push_org_name_list = push_org_name_list
        self.push_role_name_list = push_role_name_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.push_org_name_list is not None:
            result['pushOrgNameList'] = self.push_org_name_list
        if self.push_role_name_list is not None:
            result['pushRoleNameList'] = self.push_role_name_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pushOrgNameList') is not None:
            self.push_org_name_list = m.get('pushOrgNameList')
        if m.get('pushRoleNameList') is not None:
            self.push_role_name_list = m.get('pushRoleNameList')
        return self


class GetOpenCourseDetailResponseBody(TeaModel):
    def __init__(
        self,
        course_id: str = None,
        course_type: int = None,
        cover_url: str = None,
        introduction: str = None,
        push_model: GetOpenCourseDetailResponseBodyPushModel = None,
        start_time: int = None,
        teacher_id: str = None,
        teacher_name: str = None,
        title: str = None,
    ):
        self.course_id = course_id
        self.course_type = course_type
        self.cover_url = cover_url
        self.introduction = introduction
        self.push_model = push_model
        self.start_time = start_time
        self.teacher_id = teacher_id
        self.teacher_name = teacher_name
        self.title = title

    def validate(self):
        if self.push_model:
            self.push_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_id is not None:
            result['courseId'] = self.course_id
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.push_model is not None:
            result['pushModel'] = self.push_model.to_map()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.teacher_id is not None:
            result['teacherId'] = self.teacher_id
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseId') is not None:
            self.course_id = m.get('courseId')
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('pushModel') is not None:
            temp_model = GetOpenCourseDetailResponseBodyPushModel()
            self.push_model = temp_model.from_map(m['pushModel'])
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teacherId') is not None:
            self.teacher_id = m.get('teacherId')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetOpenCourseDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOpenCourseDetailResponseBody = None,
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
            temp_model = GetOpenCourseDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOpenCoursesHeaders(TeaModel):
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


class GetOpenCoursesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
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


class GetOpenCoursesResponseBodyCourseList(TeaModel):
    def __init__(
        self,
        course_id: str = None,
        cover_url: str = None,
        feed_type: int = None,
        jump_url: str = None,
        start_time: int = None,
        teacher_id: str = None,
        teacher_name: str = None,
        title: str = None,
    ):
        self.course_id = course_id
        self.cover_url = cover_url
        self.feed_type = feed_type
        self.jump_url = jump_url
        self.start_time = start_time
        self.teacher_id = teacher_id
        self.teacher_name = teacher_name
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_id is not None:
            result['courseId'] = self.course_id
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.jump_url is not None:
            result['jumpUrl'] = self.jump_url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.teacher_id is not None:
            result['teacherId'] = self.teacher_id
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseId') is not None:
            self.course_id = m.get('courseId')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('jumpUrl') is not None:
            self.jump_url = m.get('jumpUrl')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teacherId') is not None:
            self.teacher_id = m.get('teacherId')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetOpenCoursesResponseBody(TeaModel):
    def __init__(
        self,
        course_list: List[GetOpenCoursesResponseBodyCourseList] = None,
        total_count: int = None,
    ):
        self.course_list = course_list
        self.total_count = total_count

    def validate(self):
        if self.course_list:
            for k in self.course_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['courseList'] = []
        if self.course_list is not None:
            for k in self.course_list:
                result['courseList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.course_list = []
        if m.get('courseList') is not None:
            for k in m.get('courseList'):
                temp_model = GetOpenCoursesResponseBodyCourseList()
                self.course_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetOpenCoursesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOpenCoursesResponseBody = None,
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
            temp_model = GetOpenCoursesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPointActionRecordHeaders(TeaModel):
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


class GetPointActionRecordRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        point_type: str = None,
    ):
        self.biz_id = biz_id
        self.point_type = point_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.point_type is not None:
            result['pointType'] = self.point_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('pointType') is not None:
            self.point_type = m.get('pointType')
        return self


class GetPointActionRecordResponseBodyResult(TeaModel):
    def __init__(
        self,
        action_time: str = None,
        quantity: int = None,
        status: str = None,
    ):
        self.action_time = action_time
        self.quantity = quantity
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_time is not None:
            result['actionTime'] = self.action_time
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionTime') is not None:
            self.action_time = m.get('actionTime')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetPointActionRecordResponseBody(TeaModel):
    def __init__(
        self,
        result: GetPointActionRecordResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetPointActionRecordResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetPointActionRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPointActionRecordResponseBody = None,
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
            temp_model = GetPointActionRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPointInfoHeaders(TeaModel):
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


class GetPointInfoRequest(TeaModel):
    def __init__(
        self,
        point_type: str = None,
    ):
        self.point_type = point_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.point_type is not None:
            result['pointType'] = self.point_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pointType') is not None:
            self.point_type = m.get('pointType')
        return self


class GetPointInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        available_quota: int = None,
        end_time: str = None,
        start_time: str = None,
    ):
        self.available_quota = available_quota
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.available_quota is not None:
            result['availableQuota'] = self.available_quota
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('availableQuota') is not None:
            self.available_quota = m.get('availableQuota')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetPointInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetPointInfoResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetPointInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetPointInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPointInfoResponseBody = None,
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
            temp_model = GetPointInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRemoteClassCourseHeaders(TeaModel):
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


class GetRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class GetRemoteClassCourseResponseBodyResultAttendParticipants(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        org_name: str = None,
        participant_id: str = None,
        participant_name: str = None,
    ):
        self.corp_id = corp_id
        self.org_name = org_name
        self.participant_id = participant_id
        self.participant_name = participant_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        return self


class GetRemoteClassCourseResponseBodyResultRecordInfos(TeaModel):
    def __init__(
        self,
        start_time: str = None,
        stop_time: str = None,
        url: str = None,
    ):
        self.start_time = start_time
        self.stop_time = stop_time
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.stop_time is not None:
            result['stopTime'] = self.stop_time
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('stopTime') is not None:
            self.stop_time = m.get('stopTime')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetRemoteClassCourseResponseBodyResultTeachingParticipant(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        org_name: str = None,
        participant_id: str = None,
        participant_name: str = None,
    ):
        self.corp_id = corp_id
        self.org_name = org_name
        self.participant_id = participant_id
        self.participant_name = participant_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        return self


class GetRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        attend_participants: List[GetRemoteClassCourseResponseBodyResultAttendParticipants] = None,
        can_edit: bool = None,
        course_code: str = None,
        course_name: str = None,
        end_time: int = None,
        live_url: str = None,
        record_infos: List[GetRemoteClassCourseResponseBodyResultRecordInfos] = None,
        room_status: int = None,
        start_time: int = None,
        status: int = None,
        teaching_participant: GetRemoteClassCourseResponseBodyResultTeachingParticipant = None,
    ):
        self.attend_participants = attend_participants
        self.can_edit = can_edit
        self.course_code = course_code
        self.course_name = course_name
        self.end_time = end_time
        self.live_url = live_url
        self.record_infos = record_infos
        self.room_status = room_status
        self.start_time = start_time
        self.status = status
        self.teaching_participant = teaching_participant

    def validate(self):
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()
        if self.record_infos:
            for k in self.record_infos:
                if k:
                    k.validate()
        if self.teaching_participant:
            self.teaching_participant.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.can_edit is not None:
            result['canEdit'] = self.can_edit
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.live_url is not None:
            result['liveUrl'] = self.live_url
        result['recordInfos'] = []
        if self.record_infos is not None:
            for k in self.record_infos:
                result['recordInfos'].append(k.to_map() if k else None)
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = GetRemoteClassCourseResponseBodyResultAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('canEdit') is not None:
            self.can_edit = m.get('canEdit')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('liveUrl') is not None:
            self.live_url = m.get('liveUrl')
        self.record_infos = []
        if m.get('recordInfos') is not None:
            for k in m.get('recordInfos'):
                temp_model = GetRemoteClassCourseResponseBodyResultRecordInfos()
                self.record_infos.append(temp_model.from_map(k))
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('teachingParticipant') is not None:
            temp_model = GetRemoteClassCourseResponseBodyResultTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        return self


class GetRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        result: GetRemoteClassCourseResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetRemoteClassCourseResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRemoteClassCourseResponseBody = None,
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
            temp_model = GetRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShareRoleMembersHeaders(TeaModel):
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


class GetShareRoleMembersResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        member_user_id_list_in_trunk_org: List[str] = None,
    ):
        self.corp_id = corp_id
        self.member_user_id_list_in_trunk_org = member_user_id_list_in_trunk_org

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.member_user_id_list_in_trunk_org is not None:
            result['memberUserIdListInTrunkOrg'] = self.member_user_id_list_in_trunk_org
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('memberUserIdListInTrunkOrg') is not None:
            self.member_user_id_list_in_trunk_org = m.get('memberUserIdListInTrunkOrg')
        return self


class GetShareRoleMembersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetShareRoleMembersResponseBodyResult] = None,
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
                temp_model = GetShareRoleMembersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetShareRoleMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetShareRoleMembersResponseBody = None,
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
            temp_model = GetShareRoleMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShareRolesHeaders(TeaModel):
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


class GetShareRolesResponseBodyResult(TeaModel):
    def __init__(
        self,
        share_role_code: str = None,
        share_role_name: str = None,
    ):
        self.share_role_code = share_role_code
        self.share_role_name = share_role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.share_role_code is not None:
            result['shareRoleCode'] = self.share_role_code
        if self.share_role_name is not None:
            result['shareRoleName'] = self.share_role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shareRoleCode') is not None:
            self.share_role_code = m.get('shareRoleCode')
        if m.get('shareRoleName') is not None:
            self.share_role_name = m.get('shareRoleName')
        return self


class GetShareRolesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetShareRolesResponseBodyResult] = None,
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
                temp_model = GetShareRolesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetShareRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetShareRolesResponseBody = None,
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
            temp_model = GetShareRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTaskListHeaders(TeaModel):
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


class GetTaskListRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        page_number: int = None,
        page_size: int = None,
        task_year: int = None,
    ):
        self.operator = operator
        self.page_number = page_number
        self.page_size = page_size
        self.task_year = task_year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.task_year is not None:
            result['taskYear'] = self.task_year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('taskYear') is not None:
            self.task_year = m.get('taskYear')
        return self


class GetTaskListResponseBodyTaskList(TeaModel):
    def __init__(
        self,
        name: str = None,
        task_id: int = None,
        task_year: int = None,
    ):
        self.name = name
        self.task_id = task_id
        self.task_year = task_year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_year is not None:
            result['taskYear'] = self.task_year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskYear') is not None:
            self.task_year = m.get('taskYear')
        return self


class GetTaskListResponseBody(TeaModel):
    def __init__(
        self,
        count: int = None,
        task_list: List[GetTaskListResponseBodyTaskList] = None,
    ):
        self.count = count
        self.task_list = task_list

    def validate(self):
        if self.task_list:
            for k in self.task_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        result['taskList'] = []
        if self.task_list is not None:
            for k in self.task_list:
                result['taskList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        self.task_list = []
        if m.get('taskList') is not None:
            for k in m.get('taskList'):
                temp_model = GetTaskListResponseBodyTaskList()
                self.task_list.append(temp_model.from_map(k))
        return self


class GetTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskListResponseBody = None,
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
            temp_model = GetTaskListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTaskStudentListHeaders(TeaModel):
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


class GetTaskStudentListRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        page_number: int = None,
        page_size: int = None,
        task_id: int = None,
    ):
        self.operator = operator
        self.page_number = page_number
        self.page_size = page_size
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetTaskStudentListResponseBodyStudentList(TeaModel):
    def __init__(
        self,
        name: str = None,
        sexuality: str = None,
        student_id: int = None,
    ):
        self.name = name
        self.sexuality = sexuality
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.sexuality is not None:
            result['sexuality'] = self.sexuality
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sexuality') is not None:
            self.sexuality = m.get('sexuality')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class GetTaskStudentListResponseBody(TeaModel):
    def __init__(
        self,
        count: int = None,
        student_list: List[GetTaskStudentListResponseBodyStudentList] = None,
        task_id: int = None,
    ):
        self.count = count
        self.student_list = student_list
        self.task_id = task_id

    def validate(self):
        if self.student_list:
            for k in self.student_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        result['studentList'] = []
        if self.student_list is not None:
            for k in self.student_list:
                result['studentList'].append(k.to_map() if k else None)
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        self.student_list = []
        if m.get('studentList') is not None:
            for k in m.get('studentList'):
                temp_model = GetTaskStudentListResponseBodyStudentList()
                self.student_list.append(temp_model.from_map(k))
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetTaskStudentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskStudentListResponseBody = None,
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
            temp_model = GetTaskStudentListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitCoursesOfClassHeaders(TeaModel):
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


class InitCoursesOfClassRequestCoursesDateModel(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class InitCoursesOfClassRequestCoursesSectionModel(TeaModel):
    def __init__(
        self,
        section_index: int = None,
        section_name: str = None,
    ):
        self.section_index = section_index
        self.section_name = section_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class InitCoursesOfClassRequestCourses(TeaModel):
    def __init__(
        self,
        course_name: str = None,
        creator_name: str = None,
        date_model: InitCoursesOfClassRequestCoursesDateModel = None,
        location: str = None,
        section_model: InitCoursesOfClassRequestCoursesSectionModel = None,
        teacher_staff_ids: List[str] = None,
    ):
        self.course_name = course_name
        self.creator_name = creator_name
        self.date_model = date_model
        self.location = location
        self.section_model = section_model
        self.teacher_staff_ids = teacher_staff_ids

    def validate(self):
        if self.date_model:
            self.date_model.validate()
        if self.section_model:
            self.section_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.date_model is not None:
            result['dateModel'] = self.date_model.to_map()
        if self.location is not None:
            result['location'] = self.location
        if self.section_model is not None:
            result['sectionModel'] = self.section_model.to_map()
        if self.teacher_staff_ids is not None:
            result['teacherStaffIds'] = self.teacher_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('dateModel') is not None:
            temp_model = InitCoursesOfClassRequestCoursesDateModel()
            self.date_model = temp_model.from_map(m['dateModel'])
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('sectionModel') is not None:
            temp_model = InitCoursesOfClassRequestCoursesSectionModel()
            self.section_model = temp_model.from_map(m['sectionModel'])
        if m.get('teacherStaffIds') is not None:
            self.teacher_staff_ids = m.get('teacherStaffIds')
        return self


class InitCoursesOfClassRequestSectionConfigEnd(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModels(TeaModel):
    def __init__(
        self,
        end: InitCoursesOfClassRequestSectionConfigSectionModelsEnd = None,
        section_index: int = None,
        section_type: str = None,
        start: InitCoursesOfClassRequestSectionConfigSectionModelsStart = None,
    ):
        self.end = end
        self.section_index = section_index
        self.section_type = section_type
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        return self


class InitCoursesOfClassRequestSectionConfigStart(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class InitCoursesOfClassRequestSectionConfig(TeaModel):
    def __init__(
        self,
        end: InitCoursesOfClassRequestSectionConfigEnd = None,
        section_models: List[InitCoursesOfClassRequestSectionConfigSectionModels] = None,
        start: InitCoursesOfClassRequestSectionConfigStart = None,
    ):
        self.end = end
        self.section_models = section_models
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigEnd()
            self.end = temp_model.from_map(m['end'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = InitCoursesOfClassRequestSectionConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigStart()
            self.start = temp_model.from_map(m['start'])
        return self


class InitCoursesOfClassRequest(TeaModel):
    def __init__(
        self,
        courses: List[InitCoursesOfClassRequestCourses] = None,
        section_config: InitCoursesOfClassRequestSectionConfig = None,
        op_user_id: str = None,
    ):
        self.courses = courses
        self.section_config = section_config
        self.op_user_id = op_user_id

    def validate(self):
        if self.courses:
            for k in self.courses:
                if k:
                    k.validate()
        if self.section_config:
            self.section_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['courses'] = []
        if self.courses is not None:
            for k in self.courses:
                result['courses'].append(k.to_map() if k else None)
        if self.section_config is not None:
            result['sectionConfig'] = self.section_config.to_map()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.courses = []
        if m.get('courses') is not None:
            for k in m.get('courses'):
                temp_model = InitCoursesOfClassRequestCourses()
                self.courses.append(temp_model.from_map(k))
        if m.get('sectionConfig') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfig()
            self.section_config = temp_model.from_map(m['sectionConfig'])
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class InitCoursesOfClassResponseBody(TeaModel):
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


class InitCoursesOfClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InitCoursesOfClassResponseBody = None,
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
            temp_model = InitCoursesOfClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitDeviceHeaders(TeaModel):
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


class InitDeviceRequest(TeaModel):
    def __init__(
        self,
        encrypt_pub_key: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        version: str = None,
    ):
        self.encrypt_pub_key = encrypt_pub_key
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.encrypt_pub_key is not None:
            result['encryptPubKey'] = self.encrypt_pub_key
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('encryptPubKey') is not None:
            self.encrypt_pub_key = m.get('encryptPubKey')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class InitDeviceResponseBody(TeaModel):
    def __init__(
        self,
        success_info: str = None,
    ):
        self.success_info = success_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success_info is not None:
            result['successInfo'] = self.success_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('successInfo') is not None:
            self.success_info = m.get('successInfo')
        return self


class InitDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InitDeviceResponseBody = None,
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
            temp_model = InitDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitVPaasDeviceHeaders(TeaModel):
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


class InitVPaasDeviceRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
        timestamp: int = None,
        type: str = None,
    ):
        self.sn = sn
        self.timestamp = timestamp
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class InitVPaasDeviceResponseBody(TeaModel):
    def __init__(
        self,
        pspk: str = None,
    ):
        self.pspk = pspk

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pspk is not None:
            result['pspk'] = self.pspk
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pspk') is not None:
            self.pspk = m.get('pspk')
        return self


class InitVPaasDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InitVPaasDeviceResponseBody = None,
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
            temp_model = InitVPaasDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertSectionConfigHeaders(TeaModel):
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


class InsertSectionConfigRequestEnd(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class InsertSectionConfigRequestSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class InsertSectionConfigRequestSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class InsertSectionConfigRequestSectionModels(TeaModel):
    def __init__(
        self,
        end: InsertSectionConfigRequestSectionModelsEnd = None,
        section_index: int = None,
        section_name: str = None,
        section_type: str = None,
        start: InsertSectionConfigRequestSectionModelsStart = None,
    ):
        self.end = end
        self.section_index = section_index
        self.section_name = section_name
        self.section_type = section_type
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = InsertSectionConfigRequestSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = InsertSectionConfigRequestSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        return self


class InsertSectionConfigRequestStart(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class InsertSectionConfigRequest(TeaModel):
    def __init__(
        self,
        end: InsertSectionConfigRequestEnd = None,
        schedule_name: str = None,
        section_models: List[InsertSectionConfigRequestSectionModels] = None,
        start: InsertSectionConfigRequestStart = None,
        op_user_id: str = None,
    ):
        self.end = end
        self.schedule_name = schedule_name
        self.section_models = section_models
        self.start = start
        self.op_user_id = op_user_id

    def validate(self):
        if self.end:
            self.end.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.schedule_name is not None:
            result['scheduleName'] = self.schedule_name
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = InsertSectionConfigRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('scheduleName') is not None:
            self.schedule_name = m.get('scheduleName')
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = InsertSectionConfigRequestSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = InsertSectionConfigRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class InsertSectionConfigResponseBody(TeaModel):
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


class InsertSectionConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertSectionConfigResponseBody = None,
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
            temp_model = InsertSectionConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListOrderHeaders(TeaModel):
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


class ListOrderRequest(TeaModel):
    def __init__(
        self,
        create_time_end: int = None,
        create_time_start: int = None,
        merchant_id: str = None,
        order_no: str = None,
        page_number: int = None,
        page_size: int = None,
        scene: int = None,
        status: int = None,
        trade_no: str = None,
        user_id: str = None,
    ):
        self.create_time_end = create_time_end
        self.create_time_start = create_time_start
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.page_number = page_number
        self.page_size = page_size
        self.scene = scene
        self.status = status
        self.trade_no = trade_no
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_end is not None:
            result['createTimeEnd'] = self.create_time_end
        if self.create_time_start is not None:
            result['createTimeStart'] = self.create_time_start
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.scene is not None:
            result['scene'] = self.scene
        if self.status is not None:
            result['status'] = self.status
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeEnd') is not None:
            self.create_time_end = m.get('createTimeEnd')
        if m.get('createTimeStart') is not None:
            self.create_time_start = m.get('createTimeStart')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListOrderResponseBodyList(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        buyer_id: str = None,
        corp_id: str = None,
        create_time: int = None,
        end_time: int = None,
        order_no: str = None,
        pay_time: int = None,
        refund_no: str = None,
        scene: int = None,
        start_time: int = None,
        status: int = None,
        trade_no: str = None,
        user_id: str = None,
    ):
        self.actual_amount = actual_amount
        self.buyer_id = buyer_id
        self.corp_id = corp_id
        self.create_time = create_time
        self.end_time = end_time
        self.order_no = order_no
        self.pay_time = pay_time
        self.refund_no = refund_no
        self.scene = scene
        self.start_time = start_time
        self.status = status
        self.trade_no = trade_no
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.buyer_id is not None:
            result['buyerId'] = self.buyer_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.pay_time is not None:
            result['payTime'] = self.pay_time
        if self.refund_no is not None:
            result['refundNo'] = self.refund_no
        if self.scene is not None:
            result['scene'] = self.scene
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('buyerId') is not None:
            self.buyer_id = m.get('buyerId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('payTime') is not None:
            self.pay_time = m.get('payTime')
        if m.get('refundNo') is not None:
            self.refund_no = m.get('refundNo')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListOrderResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListOrderResponseBodyList] = None,
        total: int = None,
    ):
        self.list = list
        self.total = total

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListOrderResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class ListOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListOrderResponseBody = None,
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
            temp_model = ListOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MoveStudentHeaders(TeaModel):
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


class MoveStudentRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        origin_class_id: int = None,
        target_class_id: int = None,
        user_id: str = None,
    ):
        self.operator = operator
        self.origin_class_id = origin_class_id
        self.target_class_id = target_class_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.origin_class_id is not None:
            result['originClassId'] = self.origin_class_id
        if self.target_class_id is not None:
            result['targetClassId'] = self.target_class_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('originClassId') is not None:
            self.origin_class_id = m.get('originClassId')
        if m.get('targetClassId') is not None:
            self.target_class_id = m.get('targetClassId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class MoveStudentResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MoveStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MoveStudentResponseBody = None,
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
            temp_model = MoveStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageQueryDevicesHeaders(TeaModel):
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


class PageQueryDevicesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        type: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PageQueryDevicesResponseBodyList(TeaModel):
    def __init__(
        self,
        gmt_expiry: int = None,
        model: str = None,
        name: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.gmt_expiry = gmt_expiry
        self.model = model
        self.name = name
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_expiry is not None:
            result['gmtExpiry'] = self.gmt_expiry
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtExpiry') is not None:
            self.gmt_expiry = m.get('gmtExpiry')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PageQueryDevicesResponseBody(TeaModel):
    def __init__(
        self,
        list: List[PageQueryDevicesResponseBodyList] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        self.list = list
        self.next_token = next_token
        self.total_count = total_count

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PageQueryDevicesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PageQueryDevicesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PageQueryDevicesResponseBody = None,
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
            temp_model = PageQueryDevicesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PayOrderHeaders(TeaModel):
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


class PayOrderRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        order_no: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        user_id: str = None,
        version: str = None,
    ):
        self.face_id = face_id
        self.order_no = order_no
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.user_id = user_id
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class PayOrderResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PayOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PayOrderResponseBody = None,
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
            temp_model = PayOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PollingConfirmStatusHeaders(TeaModel):
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


class PollingConfirmStatusRequest(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        ext: str = None,
        isv_code: str = None,
        op_user_id: str = None,
    ):
        self.course_code = course_code
        self.ext = ext
        self.isv_code = isv_code
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_input_url: str = None,
        live_output_url: str = None,
        live_type: int = None,
        replay_url: str = None,
    ):
        self.live_input_url = live_input_url
        self.live_output_url = live_output_url
        self.live_type = live_type
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.live_output_url is not None:
            result['liveOutputUrl'] = self.live_output_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('liveOutputUrl') is not None:
            self.live_output_url = m.get('liveOutputUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse(TeaModel):
    def __init__(
        self,
        confirm_status: bool = None,
        course_code: str = None,
        live_play_info_list: List[PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList] = None,
    ):
        self.confirm_status = confirm_status
        self.course_code = course_code
        self.live_play_info_list = live_play_info_list

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.confirm_status is not None:
            result['confirmStatus'] = self.confirm_status
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confirmStatus') is not None:
            self.confirm_status = m.get('confirmStatus')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        return self


class PollingConfirmStatusResponseBody(TeaModel):
    def __init__(
        self,
        university_polling_course_status_response: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse = None,
    ):
        self.university_polling_course_status_response = university_polling_course_status_response

    def validate(self):
        if self.university_polling_course_status_response:
            self.university_polling_course_status_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_polling_course_status_response is not None:
            result['universityPollingCourseStatusResponse'] = self.university_polling_course_status_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityPollingCourseStatusResponse') is not None:
            temp_model = PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse()
            self.university_polling_course_status_response = temp_model.from_map(m['universityPollingCourseStatusResponse'])
        return self


class PollingConfirmStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PollingConfirmStatusResponseBody = None,
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
            temp_model = PollingConfirmStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreDialHeaders(TeaModel):
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


class PreDialRequest(TeaModel):
    def __init__(
        self,
        caller_user_id: str = None,
        receiver_user_id: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.caller_user_id = caller_user_id
        self.receiver_user_id = receiver_user_id
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.caller_user_id is not None:
            result['callerUserId'] = self.caller_user_id
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callerUserId') is not None:
            self.caller_user_id = m.get('callerUserId')
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PreDialResponseBody(TeaModel):
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


class PreDialResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreDialResponseBody = None,
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
            temp_model = PreDialResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ProvidePointHeaders(TeaModel):
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


class ProvidePointRequest(TeaModel):
    def __init__(
        self,
        action_code: str = None,
        biz_id: str = None,
        point_type: str = None,
    ):
        self.action_code = action_code
        self.biz_id = biz_id
        self.point_type = point_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_code is not None:
            result['actionCode'] = self.action_code
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.point_type is not None:
            result['pointType'] = self.point_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionCode') is not None:
            self.action_code = m.get('actionCode')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('pointType') is not None:
            self.point_type = m.get('pointType')
        return self


class ProvidePointResponseBodyResult(TeaModel):
    def __init__(
        self,
        available_quota: int = None,
        provide_num: int = None,
        provide_success: bool = None,
    ):
        self.available_quota = available_quota
        self.provide_num = provide_num
        self.provide_success = provide_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.available_quota is not None:
            result['availableQuota'] = self.available_quota
        if self.provide_num is not None:
            result['provideNum'] = self.provide_num
        if self.provide_success is not None:
            result['provideSuccess'] = self.provide_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('availableQuota') is not None:
            self.available_quota = m.get('availableQuota')
        if m.get('provideNum') is not None:
            self.provide_num = m.get('provideNum')
        if m.get('provideSuccess') is not None:
            self.provide_success = m.get('provideSuccess')
        return self


class ProvidePointResponseBody(TeaModel):
    def __init__(
        self,
        result: ProvidePointResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = ProvidePointResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ProvidePointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ProvidePointResponseBody = None,
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
            temp_model = ProvidePointResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllSubjectsFromClassScheduleHeaders(TeaModel):
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


class QueryAllSubjectsFromClassScheduleRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
        period_code: str = None,
    ):
        self.class_ids = class_ids
        self.op_user_id = op_user_id
        self.period_code = period_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        return self


class QueryAllSubjectsFromClassScheduleShrinkRequest(TeaModel):
    def __init__(
        self,
        class_ids_shrink: str = None,
        op_user_id: str = None,
        period_code: str = None,
    ):
        self.class_ids_shrink = class_ids_shrink
        self.op_user_id = op_user_id
        self.period_code = period_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids_shrink is not None:
            result['classIds'] = self.class_ids_shrink
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids_shrink = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList(TeaModel):
    def __init__(
        self,
        avator: str = None,
        name: str = None,
        uid: int = None,
        user_id: str = None,
    ):
        self.avator = avator
        self.name = name
        self.uid = uid
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avator is not None:
            result['avator'] = self.avator
        if self.name is not None:
            result['name'] = self.name
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avator') is not None:
            self.avator = m.get('avator')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResultExt(TeaModel):
    def __init__(
        self,
        background_color: str = None,
        class_id: int = None,
        font_color: str = None,
        teacher_list: List[QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList] = None,
    ):
        self.background_color = background_color
        self.class_id = class_id
        self.font_color = font_color
        self.teacher_list = teacher_list

    def validate(self):
        if self.teacher_list:
            for k in self.teacher_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_color is not None:
            result['backgroundColor'] = self.background_color
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.font_color is not None:
            result['fontColor'] = self.font_color
        result['teacherList'] = []
        if self.teacher_list is not None:
            for k in self.teacher_list:
                result['teacherList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundColor') is not None:
            self.background_color = m.get('backgroundColor')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('fontColor') is not None:
            self.font_color = m.get('fontColor')
        self.teacher_list = []
        if m.get('teacherList') is not None:
            for k in m.get('teacherList'):
                temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList()
                self.teacher_list.append(temp_model.from_map(k))
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResult(TeaModel):
    def __init__(
        self,
        creator_org_id: int = None,
        ext: QueryAllSubjectsFromClassScheduleResponseBodyResultExt = None,
        period_code: str = None,
        subject_code: str = None,
        subject_name: str = None,
    ):
        self.creator_org_id = creator_org_id
        self.ext = ext
        self.period_code = period_code
        self.subject_code = subject_code
        self.subject_name = subject_name

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_org_id is not None:
            result['creatorOrgId'] = self.creator_org_id
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorOrgId') is not None:
            self.creator_org_id = m.get('creatorOrgId')
        if m.get('ext') is not None:
            temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResultExt()
            self.ext = temp_model.from_map(m['ext'])
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        return self


class QueryAllSubjectsFromClassScheduleResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryAllSubjectsFromClassScheduleResponseBodyResult] = None,
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
                temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryAllSubjectsFromClassScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAllSubjectsFromClassScheduleResponseBody = None,
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
            temp_model = QueryAllSubjectsFromClassScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleHeaders(TeaModel):
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


class QueryClassScheduleRequest(TeaModel):
    def __init__(
        self,
        section_index_list: List[int] = None,
        subscriber_ids: List[str] = None,
        end_time: int = None,
        op_user_id: str = None,
        start_time: int = None,
        subscriber_type: str = None,
    ):
        self.section_index_list = section_index_list
        self.subscriber_ids = subscriber_ids
        self.end_time = end_time
        self.op_user_id = op_user_id
        self.start_time = start_time
        self.subscriber_type = subscriber_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_index_list is not None:
            result['sectionIndexList'] = self.section_index_list
        if self.subscriber_ids is not None:
            result['subscriberIds'] = self.subscriber_ids
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subscriber_type is not None:
            result['subscriberType'] = self.subscriber_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionIndexList') is not None:
            self.section_index_list = m.get('sectionIndexList')
        if m.get('subscriberIds') is not None:
            self.subscriber_ids = m.get('subscriberIds')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subscriberType') is not None:
            self.subscriber_type = m.get('subscriberType')
        return self


class QueryClassScheduleResponseBodyConfigEnd(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryClassScheduleResponseBodyConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleResponseBodyConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleResponseBodyConfigSectionModels(TeaModel):
    def __init__(
        self,
        end: QueryClassScheduleResponseBodyConfigSectionModelsEnd = None,
        section_index: int = None,
        section_name: str = None,
        section_type: str = None,
        start: QueryClassScheduleResponseBodyConfigSectionModelsStart = None,
    ):
        self.end = end
        self.section_index = section_index
        self.section_name = section_name
        self.section_type = section_type
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        return self


class QueryClassScheduleResponseBodyConfigStart(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryClassScheduleResponseBodyConfig(TeaModel):
    def __init__(
        self,
        end: QueryClassScheduleResponseBodyConfigEnd = None,
        section_models: List[QueryClassScheduleResponseBodyConfigSectionModels] = None,
        start: QueryClassScheduleResponseBodyConfigStart = None,
    ):
        self.end = end
        self.section_models = section_models
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigEnd()
            self.end = temp_model.from_map(m['end'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = QueryClassScheduleResponseBodyConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigStart()
            self.start = temp_model.from_map(m['start'])
        return self


class QueryClassScheduleResponseBodyCourseDTOSClassrooms(TeaModel):
    def __init__(
        self,
        interact_info: str = None,
        target_id: str = None,
    ):
        self.interact_info = interact_info
        self.target_id = target_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.interact_info is not None:
            result['interactInfo'] = self.interact_info
        if self.target_id is not None:
            result['targetId'] = self.target_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('interactInfo') is not None:
            self.interact_info = m.get('interactInfo')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        return self


class QueryClassScheduleResponseBodyCourseDTOSEduUserModels(TeaModel):
    def __init__(
        self,
        name: str = None,
        uid: int = None,
        user_id: str = None,
    ):
        self.name = name
        self.uid = uid
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryClassScheduleResponseBodyCourseDTOS(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        classrooms: List[QueryClassScheduleResponseBodyCourseDTOSClassrooms] = None,
        code: str = None,
        course_group_code: str = None,
        cover_url: str = None,
        creator_corp_id: str = None,
        creator_user_id: str = None,
        creator_user_name: str = None,
        edu_user_models: List[QueryClassScheduleResponseBodyCourseDTOSEduUserModels] = None,
        end_time: int = None,
        ext_info: str = None,
        introduce: str = None,
        name: str = None,
        section_index: int = None,
        section_name: str = None,
        start_time: int = None,
        status: int = None,
        subject_code: str = None,
        teacher_corp_id: str = None,
        teacher_user_id: str = None,
        teacher_user_name: str = None,
    ):
        self.class_id = class_id
        self.classrooms = classrooms
        self.code = code
        self.course_group_code = course_group_code
        self.cover_url = cover_url
        self.creator_corp_id = creator_corp_id
        self.creator_user_id = creator_user_id
        self.creator_user_name = creator_user_name
        self.edu_user_models = edu_user_models
        self.end_time = end_time
        self.ext_info = ext_info
        self.introduce = introduce
        self.name = name
        self.section_index = section_index
        self.section_name = section_name
        self.start_time = start_time
        self.status = status
        self.subject_code = subject_code
        self.teacher_corp_id = teacher_corp_id
        self.teacher_user_id = teacher_user_id
        self.teacher_user_name = teacher_user_name

    def validate(self):
        if self.classrooms:
            for k in self.classrooms:
                if k:
                    k.validate()
        if self.edu_user_models:
            for k in self.edu_user_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        result['classrooms'] = []
        if self.classrooms is not None:
            for k in self.classrooms:
                result['classrooms'].append(k.to_map() if k else None)
        if self.code is not None:
            result['code'] = self.code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.creator_corp_id is not None:
            result['creatorCorpId'] = self.creator_corp_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_user_name is not None:
            result['creatorUserName'] = self.creator_user_name
        result['eduUserModels'] = []
        if self.edu_user_models is not None:
            for k in self.edu_user_models:
                result['eduUserModels'].append(k.to_map() if k else None)
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.introduce is not None:
            result['introduce'] = self.introduce
        if self.name is not None:
            result['name'] = self.name
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.teacher_corp_id is not None:
            result['teacherCorpId'] = self.teacher_corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.teacher_user_name is not None:
            result['teacherUserName'] = self.teacher_user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        self.classrooms = []
        if m.get('classrooms') is not None:
            for k in m.get('classrooms'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOSClassrooms()
                self.classrooms.append(temp_model.from_map(k))
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('creatorCorpId') is not None:
            self.creator_corp_id = m.get('creatorCorpId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorUserName') is not None:
            self.creator_user_name = m.get('creatorUserName')
        self.edu_user_models = []
        if m.get('eduUserModels') is not None:
            for k in m.get('eduUserModels'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOSEduUserModels()
                self.edu_user_models.append(temp_model.from_map(k))
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('introduce') is not None:
            self.introduce = m.get('introduce')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('teacherCorpId') is not None:
            self.teacher_corp_id = m.get('teacherCorpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('teacherUserName') is not None:
            self.teacher_user_name = m.get('teacherUserName')
        return self


class QueryClassScheduleResponseBody(TeaModel):
    def __init__(
        self,
        config: QueryClassScheduleResponseBodyConfig = None,
        course_dtos: List[QueryClassScheduleResponseBodyCourseDTOS] = None,
    ):
        self.config = config
        self.course_dtos = course_dtos

    def validate(self):
        if self.config:
            self.config.validate()
        if self.course_dtos:
            for k in self.course_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config is not None:
            result['config'] = self.config.to_map()
        result['courseDTOS'] = []
        if self.course_dtos is not None:
            for k in self.course_dtos:
                result['courseDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('config') is not None:
            temp_model = QueryClassScheduleResponseBodyConfig()
            self.config = temp_model.from_map(m['config'])
        self.course_dtos = []
        if m.get('courseDTOS') is not None:
            for k in m.get('courseDTOS'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOS()
                self.course_dtos.append(temp_model.from_map(k))
        return self


class QueryClassScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryClassScheduleResponseBody = None,
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
            temp_model = QueryClassScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleByTimeSchoolHeaders(TeaModel):
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


class QueryClassScheduleByTimeSchoolRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        op_user_id: str = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.op_user_id = op_user_id
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms(TeaModel):
    def __init__(
        self,
        interact_info: str = None,
        target_id: str = None,
    ):
        self.interact_info = interact_info
        self.target_id = target_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.interact_info is not None:
            result['interactInfo'] = self.interact_info
        if self.target_id is not None:
            result['targetId'] = self.target_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('interactInfo') is not None:
            self.interact_info = m.get('interactInfo')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels(TeaModel):
    def __init__(
        self,
        name: str = None,
        uid: int = None,
        user_id: str = None,
    ):
        self.name = name
        self.uid = uid
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_key: str = None,
        class_id: int = None,
        classrooms: List[QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms] = None,
        code: str = None,
        course_group_code: str = None,
        cover_url: str = None,
        creator_corp_id: str = None,
        creator_user_id: str = None,
        creator_user_name: str = None,
        edu_user_models: List[QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels] = None,
        end_time: int = None,
        ext_info: str = None,
        introduce: str = None,
        name: str = None,
        section_index: int = None,
        section_name: str = None,
        start_time: int = None,
        status: int = None,
        subject_code: str = None,
        teacher_corp_id: str = None,
        teacher_user_id: str = None,
        teacher_user_name: str = None,
    ):
        self.biz_key = biz_key
        self.class_id = class_id
        self.classrooms = classrooms
        self.code = code
        self.course_group_code = course_group_code
        self.cover_url = cover_url
        self.creator_corp_id = creator_corp_id
        self.creator_user_id = creator_user_id
        self.creator_user_name = creator_user_name
        self.edu_user_models = edu_user_models
        self.end_time = end_time
        self.ext_info = ext_info
        self.introduce = introduce
        self.name = name
        self.section_index = section_index
        self.section_name = section_name
        self.start_time = start_time
        self.status = status
        self.subject_code = subject_code
        self.teacher_corp_id = teacher_corp_id
        self.teacher_user_id = teacher_user_id
        self.teacher_user_name = teacher_user_name

    def validate(self):
        if self.classrooms:
            for k in self.classrooms:
                if k:
                    k.validate()
        if self.edu_user_models:
            for k in self.edu_user_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_key is not None:
            result['bizKey'] = self.biz_key
        if self.class_id is not None:
            result['classId'] = self.class_id
        result['classrooms'] = []
        if self.classrooms is not None:
            for k in self.classrooms:
                result['classrooms'].append(k.to_map() if k else None)
        if self.code is not None:
            result['code'] = self.code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.creator_corp_id is not None:
            result['creatorCorpId'] = self.creator_corp_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_user_name is not None:
            result['creatorUserName'] = self.creator_user_name
        result['eduUserModels'] = []
        if self.edu_user_models is not None:
            for k in self.edu_user_models:
                result['eduUserModels'].append(k.to_map() if k else None)
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.introduce is not None:
            result['introduce'] = self.introduce
        if self.name is not None:
            result['name'] = self.name
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.teacher_corp_id is not None:
            result['teacherCorpId'] = self.teacher_corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.teacher_user_name is not None:
            result['teacherUserName'] = self.teacher_user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizKey') is not None:
            self.biz_key = m.get('bizKey')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        self.classrooms = []
        if m.get('classrooms') is not None:
            for k in m.get('classrooms'):
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms()
                self.classrooms.append(temp_model.from_map(k))
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('creatorCorpId') is not None:
            self.creator_corp_id = m.get('creatorCorpId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorUserName') is not None:
            self.creator_user_name = m.get('creatorUserName')
        self.edu_user_models = []
        if m.get('eduUserModels') is not None:
            for k in m.get('eduUserModels'):
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels()
                self.edu_user_models.append(temp_model.from_map(k))
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('introduce') is not None:
            self.introduce = m.get('introduce')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('teacherCorpId') is not None:
            self.teacher_corp_id = m.get('teacherCorpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('teacherUserName') is not None:
            self.teacher_user_name = m.get('teacherUserName')
        return self


class QueryClassScheduleByTimeSchoolResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryClassScheduleByTimeSchoolResponseBodyResult] = None,
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
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryClassScheduleByTimeSchoolResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryClassScheduleByTimeSchoolResponseBody = None,
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
            temp_model = QueryClassScheduleByTimeSchoolResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleConfigHeaders(TeaModel):
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


class QueryClassScheduleConfigRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
    ):
        self.class_ids = class_ids
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryClassScheduleConfigShrinkRequest(TeaModel):
    def __init__(
        self,
        class_ids_shrink: str = None,
        op_user_id: str = None,
    ):
        self.class_ids_shrink = class_ids_shrink
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids_shrink is not None:
            result['classIds'] = self.class_ids_shrink
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids_shrink = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryClassScheduleConfigResponseBodyResultEnd(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModels(TeaModel):
    def __init__(
        self,
        end: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd = None,
        section_index: int = None,
        section_name: str = None,
        section_type: str = None,
        start: QueryClassScheduleConfigResponseBodyResultSectionModelsStart = None,
    ):
        self.end = end
        self.section_index = section_index
        self.section_name = section_name
        self.section_type = section_type
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        return self


class QueryClassScheduleConfigResponseBodyResultStart(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryClassScheduleConfigResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        end: QueryClassScheduleConfigResponseBodyResultEnd = None,
        section_models: List[QueryClassScheduleConfigResponseBodyResultSectionModels] = None,
        start: QueryClassScheduleConfigResponseBodyResultStart = None,
    ):
        self.class_id = class_id
        self.end = end
        self.section_models = section_models
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.end is not None:
            result['end'] = self.end.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('end') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultEnd()
            self.end = temp_model.from_map(m['end'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = QueryClassScheduleConfigResponseBodyResultSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultStart()
            self.start = temp_model.from_map(m['start'])
        return self


class QueryClassScheduleConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryClassScheduleConfigResponseBodyResult] = None,
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
                temp_model = QueryClassScheduleConfigResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryClassScheduleConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryClassScheduleConfigResponseBody = None,
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
            temp_model = QueryClassScheduleConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceHeaders(TeaModel):
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


class QueryDeviceRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
    ):
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class QueryDeviceResponseBody(TeaModel):
    def __init__(
        self,
        gmt_expiry: int = None,
        model: str = None,
        name: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.gmt_expiry = gmt_expiry
        self.model = model
        self.name = name
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_expiry is not None:
            result['gmtExpiry'] = self.gmt_expiry
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtExpiry') is not None:
            self.gmt_expiry = m.get('gmtExpiry')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceResponseBody = None,
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
            temp_model = QueryDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceListByCorpIdHeaders(TeaModel):
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


class QueryDeviceListByCorpIdRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.operator = operator
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryDeviceListByCorpIdResponseBodyResultList(TeaModel):
    def __init__(
        self,
        app_status: int = None,
        device_code: str = None,
        device_name: str = None,
    ):
        self.app_status = app_status
        self.device_code = device_code
        self.device_name = device_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        return self


class QueryDeviceListByCorpIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryDeviceListByCorpIdResponseBodyResultList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryDeviceListByCorpIdResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryDeviceListByCorpIdResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryDeviceListByCorpIdResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryDeviceListByCorpIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryDeviceListByCorpIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceListByCorpIdResponseBody = None,
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
            temp_model = QueryDeviceListByCorpIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEduAssetSpacesHeaders(TeaModel):
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


class QueryEduAssetSpacesRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.biz_code = biz_code
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryEduAssetSpacesResponseBodySpaces(TeaModel):
    def __init__(
        self,
        create_time_millis: int = None,
        modify_time_millis: int = None,
        permission_mode: str = None,
        quota: int = None,
        space_id: str = None,
        space_name: str = None,
        space_type: str = None,
        used_quota: int = None,
    ):
        self.create_time_millis = create_time_millis
        self.modify_time_millis = modify_time_millis
        self.permission_mode = permission_mode
        self.quota = quota
        self.space_id = space_id
        self.space_name = space_name
        self.space_type = space_type
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_millis is not None:
            result['createTimeMillis'] = self.create_time_millis
        if self.modify_time_millis is not None:
            result['modifyTimeMillis'] = self.modify_time_millis
        if self.permission_mode is not None:
            result['permissionMode'] = self.permission_mode
        if self.quota is not None:
            result['quota'] = self.quota
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeMillis') is not None:
            self.create_time_millis = m.get('createTimeMillis')
        if m.get('modifyTimeMillis') is not None:
            self.modify_time_millis = m.get('modifyTimeMillis')
        if m.get('permissionMode') is not None:
            self.permission_mode = m.get('permissionMode')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class QueryEduAssetSpacesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        spaces: List[QueryEduAssetSpacesResponseBodySpaces] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.spaces = spaces

    def validate(self):
        if self.spaces:
            for k in self.spaces:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['spaces'] = []
        if self.spaces is not None:
            for k in self.spaces:
                result['spaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.spaces = []
        if m.get('spaces') is not None:
            for k in m.get('spaces'):
                temp_model = QueryEduAssetSpacesResponseBodySpaces()
                self.spaces.append(temp_model.from_map(k))
        return self


class QueryEduAssetSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryEduAssetSpacesResponseBody = None,
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
            temp_model = QueryEduAssetSpacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupIdHeaders(TeaModel):
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


class QueryGroupIdRequest(TeaModel):
    def __init__(
        self,
        sn: str = None,
    ):
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class QueryGroupIdResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        group_id: str = None,
        merchant_id: str = None,
        merchant_name: str = None,
        name: str = None,
        pid: str = None,
    ):
        self.corp_id = corp_id
        self.group_id = group_id
        self.merchant_id = merchant_id
        self.merchant_name = merchant_name
        self.name = name
        self.pid = pid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_name is not None:
            result['merchantName'] = self.merchant_name
        if self.name is not None:
            result['name'] = self.name
        if self.pid is not None:
            result['pid'] = self.pid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantName') is not None:
            self.merchant_name = m.get('merchantName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pid') is not None:
            self.pid = m.get('pid')
        return self


class QueryGroupIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupIdResponseBody = None,
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
            temp_model = QueryGroupIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrderHeaders(TeaModel):
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


class QueryOrderRequest(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        order_no: str = None,
        signature: str = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.signature = signature

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class QueryOrderResponseBody(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        close_time: str = None,
        close_timestamp: int = None,
        create_time: str = None,
        create_timestamp: int = None,
        label_amount: int = None,
        merchant_id: str = None,
        merchant_merge_order_no: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
        order_type: str = None,
        outer_user_id: str = None,
        pay_logon_id: str = None,
        pay_status: int = None,
        pay_time: str = None,
        pay_timestamp: int = None,
        pay_type: str = None,
        refund_amount: int = None,
        refund_status: int = None,
        refund_time: str = None,
        refund_timestamp: int = None,
        subject: str = None,
        trade_no: str = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.close_time = close_time
        self.close_timestamp = close_timestamp
        self.create_time = create_time
        self.create_timestamp = create_timestamp
        self.label_amount = label_amount
        self.merchant_id = merchant_id
        self.merchant_merge_order_no = merchant_merge_order_no
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no
        self.order_type = order_type
        self.outer_user_id = outer_user_id
        self.pay_logon_id = pay_logon_id
        self.pay_status = pay_status
        self.pay_time = pay_time
        self.pay_timestamp = pay_timestamp
        self.pay_type = pay_type
        self.refund_amount = refund_amount
        self.refund_status = refund_status
        self.refund_time = refund_time
        self.refund_timestamp = refund_timestamp
        self.subject = subject
        self.trade_no = trade_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.close_time is not None:
            result['closeTime'] = self.close_time
        if self.close_timestamp is not None:
            result['closeTimestamp'] = self.close_timestamp
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.label_amount is not None:
            result['labelAmount'] = self.label_amount
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_merge_order_no is not None:
            result['merchantMergeOrderNo'] = self.merchant_merge_order_no
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_type is not None:
            result['orderType'] = self.order_type
        if self.outer_user_id is not None:
            result['outerUserId'] = self.outer_user_id
        if self.pay_logon_id is not None:
            result['payLogonId'] = self.pay_logon_id
        if self.pay_status is not None:
            result['payStatus'] = self.pay_status
        if self.pay_time is not None:
            result['payTime'] = self.pay_time
        if self.pay_timestamp is not None:
            result['payTimestamp'] = self.pay_timestamp
        if self.pay_type is not None:
            result['payType'] = self.pay_type
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.refund_status is not None:
            result['refundStatus'] = self.refund_status
        if self.refund_time is not None:
            result['refundTime'] = self.refund_time
        if self.refund_timestamp is not None:
            result['refundTimestamp'] = self.refund_timestamp
        if self.subject is not None:
            result['subject'] = self.subject
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('closeTime') is not None:
            self.close_time = m.get('closeTime')
        if m.get('closeTimestamp') is not None:
            self.close_timestamp = m.get('closeTimestamp')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('labelAmount') is not None:
            self.label_amount = m.get('labelAmount')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantMergeOrderNo') is not None:
            self.merchant_merge_order_no = m.get('merchantMergeOrderNo')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        if m.get('outerUserId') is not None:
            self.outer_user_id = m.get('outerUserId')
        if m.get('payLogonId') is not None:
            self.pay_logon_id = m.get('payLogonId')
        if m.get('payStatus') is not None:
            self.pay_status = m.get('payStatus')
        if m.get('payTime') is not None:
            self.pay_time = m.get('payTime')
        if m.get('payTimestamp') is not None:
            self.pay_timestamp = m.get('payTimestamp')
        if m.get('payType') is not None:
            self.pay_type = m.get('payType')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('refundStatus') is not None:
            self.refund_status = m.get('refundStatus')
        if m.get('refundTime') is not None:
            self.refund_time = m.get('refundTime')
        if m.get('refundTimestamp') is not None:
            self.refund_timestamp = m.get('refundTimestamp')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        return self


class QueryOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrderResponseBody = None,
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
            temp_model = QueryOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgRelationListHeaders(TeaModel):
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


class QueryOrgRelationListRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class QueryOrgRelationListResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_count: int = None,
        name: str = None,
    ):
        self.corp_id = corp_id
        self.device_count = device_count
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_count is not None:
            result['deviceCount'] = self.device_count
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceCount') is not None:
            self.device_count = m.get('deviceCount')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryOrgRelationListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryOrgRelationListResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryOrgRelationListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOrgRelationListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgRelationListResponseBody = None,
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
            temp_model = QueryOrgRelationListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgSecretKeyHeaders(TeaModel):
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


class QueryOrgSecretKeyRequest(TeaModel):
    def __init__(
        self,
        isv_code: str = None,
        op_user_id: str = None,
    ):
        self.isv_code = isv_code
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo(TeaModel):
    def __init__(
        self,
        secret_key: str = None,
    ):
        self.secret_key = secret_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        return self


class QueryOrgSecretKeyResponseBody(TeaModel):
    def __init__(
        self,
        university_secret_key_info: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo = None,
    ):
        self.university_secret_key_info = university_secret_key_info

    def validate(self):
        if self.university_secret_key_info:
            self.university_secret_key_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_secret_key_info is not None:
            result['universitySecretKeyInfo'] = self.university_secret_key_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universitySecretKeyInfo') is not None:
            temp_model = QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo()
            self.university_secret_key_info = temp_model.from_map(m['universitySecretKeyInfo'])
        return self


class QueryOrgSecretKeyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgSecretKeyResponseBody = None,
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
            temp_model = QueryOrgSecretKeyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgTypeHeaders(TeaModel):
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


class QueryOrgTypeResponseBody(TeaModel):
    def __init__(
        self,
        org_type: int = None,
    ):
        self.org_type = org_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.org_type is not None:
            result['orgType'] = self.org_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orgType') is not None:
            self.org_type = m.get('orgType')
        return self


class QueryOrgTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgTypeResponseBody = None,
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
            temp_model = QueryOrgTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPayResultHeaders(TeaModel):
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


class QueryPayResultRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        order_no: str = None,
        signature: str = None,
        sn: str = None,
        timestamp: int = None,
        user_id: str = None,
        version: str = None,
    ):
        self.face_id = face_id
        self.order_no = order_no
        self.signature = signature
        self.sn = sn
        self.timestamp = timestamp
        self.user_id = user_id
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        if self.sn is not None:
            result['sn'] = self.sn
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class QueryPayResultResponseBody(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryPayResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPayResultResponseBody = None,
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
            temp_model = QueryPayResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPhysicalClassroomHeaders(TeaModel):
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


class QueryPhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
        op_user_id: str = None,
    ):
        self.classroom_id = classroom_id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryPhysicalClassroomResponseBodyResult(TeaModel):
    def __init__(
        self,
        classroom_building: str = None,
        classroom_campus: str = None,
        classroom_floor: str = None,
        classroom_id: int = None,
        classroom_name: str = None,
        classroom_number: str = None,
        direct_broadcast: str = None,
    ):
        self.classroom_building = classroom_building
        self.classroom_campus = classroom_campus
        self.classroom_floor = classroom_floor
        self.classroom_id = classroom_id
        self.classroom_name = classroom_name
        self.classroom_number = classroom_number
        self.direct_broadcast = direct_broadcast

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        return self


class QueryPhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryPhysicalClassroomResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryPhysicalClassroomResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryPhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPhysicalClassroomResponseBody = None,
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
            temp_model = QueryPhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPurchaseInfoHeaders(TeaModel):
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


class QueryPurchaseInfoRequest(TeaModel):
    def __init__(
        self,
        merchant_id: str = None,
        scene: int = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.merchant_id = merchant_id
        self.scene = scene
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.scene is not None:
            result['scene'] = self.scene
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPurchaseInfoResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        merchant_id: str = None,
        name: str = None,
        scene: int = None,
        status: int = None,
        user_id: str = None,
    ):
        self.corp_id = corp_id
        self.merchant_id = merchant_id
        self.name = name
        self.scene = scene
        self.status = status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.name is not None:
            result['name'] = self.name
        if self.scene is not None:
            result['scene'] = self.scene
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPurchaseInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPurchaseInfoResponseBody = None,
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
            temp_model = QueryPurchaseInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRemoteClassCourseHeaders(TeaModel):
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


class QueryRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        operator: str = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.operator = operator
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.operator is not None:
            result['operator'] = self.operator
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class QueryRemoteClassCourseResponseBodyResultAttendParticipants(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        org_name: str = None,
        participant_id: str = None,
        participant_name: str = None,
    ):
        self.corp_id = corp_id
        self.org_name = org_name
        self.participant_id = participant_id
        self.participant_name = participant_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        return self


class QueryRemoteClassCourseResponseBodyResultTeachingParticipant(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        org_name: str = None,
        participant_id: str = None,
        participant_name: str = None,
    ):
        self.corp_id = corp_id
        self.org_name = org_name
        self.participant_id = participant_id
        self.participant_name = participant_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        return self


class QueryRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        attend_participants: List[QueryRemoteClassCourseResponseBodyResultAttendParticipants] = None,
        can_edit: bool = None,
        course_code: str = None,
        course_name: str = None,
        course_ways: List[str] = None,
        end_time: int = None,
        start_time: int = None,
        status: int = None,
        teaching_participant: QueryRemoteClassCourseResponseBodyResultTeachingParticipant = None,
    ):
        self.attend_participants = attend_participants
        self.can_edit = can_edit
        self.course_code = course_code
        self.course_name = course_name
        self.course_ways = course_ways
        self.end_time = end_time
        self.start_time = start_time
        self.status = status
        self.teaching_participant = teaching_participant

    def validate(self):
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()
        if self.teaching_participant:
            self.teaching_participant.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.can_edit is not None:
            result['canEdit'] = self.can_edit
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.course_ways is not None:
            result['courseWays'] = self.course_ways
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = QueryRemoteClassCourseResponseBodyResultAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('canEdit') is not None:
            self.can_edit = m.get('canEdit')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('courseWays') is not None:
            self.course_ways = m.get('courseWays')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('teachingParticipant') is not None:
            temp_model = QueryRemoteClassCourseResponseBodyResultTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        return self


class QueryRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryRemoteClassCourseResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryRemoteClassCourseResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRemoteClassCourseResponseBody = None,
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
            temp_model = QueryRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySchoolUserFaceHeaders(TeaModel):
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


class QuerySchoolUserFaceRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        sn: str = None,
        type: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.sn = sn
        self.type = type

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
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QuerySchoolUserFaceResponseBodyUserFaceList(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        name: str = None,
        status: int = None,
        user_id: str = None,
    ):
        self.face_id = face_id
        self.name = name
        self.status = status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySchoolUserFaceResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        has_more: bool = None,
        user_face_list: List[QuerySchoolUserFaceResponseBodyUserFaceList] = None,
    ):
        self.corp_id = corp_id
        self.has_more = has_more
        self.user_face_list = user_face_list

    def validate(self):
        if self.user_face_list:
            for k in self.user_face_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['userFaceList'] = []
        if self.user_face_list is not None:
            for k in self.user_face_list:
                result['userFaceList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.user_face_list = []
        if m.get('userFaceList') is not None:
            for k in m.get('userFaceList'):
                temp_model = QuerySchoolUserFaceResponseBodyUserFaceList()
                self.user_face_list.append(temp_model.from_map(k))
        return self


class QuerySchoolUserFaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySchoolUserFaceResponseBody = None,
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
            temp_model = QuerySchoolUserFaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySnsOrderHeaders(TeaModel):
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


class QuerySnsOrderRequest(TeaModel):
    def __init__(
        self,
        alipay_app_id: str = None,
        merchant_id: str = None,
        order_no: str = None,
        signature: str = None,
    ):
        self.alipay_app_id = alipay_app_id
        self.merchant_id = merchant_id
        self.order_no = order_no
        self.signature = signature

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class QuerySnsOrderResponseBody(TeaModel):
    def __init__(
        self,
        actual_amount: int = None,
        alipay_app_id: str = None,
        close_time: str = None,
        close_timestamp: int = None,
        create_time: str = None,
        create_timestamp: int = None,
        label_amount: int = None,
        merchant_id: str = None,
        merchant_merge_order_no: str = None,
        merchant_order_no: str = None,
        order_no: str = None,
        order_type: str = None,
        outer_user_id: str = None,
        pay_logon_id: str = None,
        pay_status: int = None,
        pay_time: str = None,
        pay_timestamp: int = None,
        pay_type: str = None,
        refund_amount: int = None,
        refund_status: int = None,
        refund_time: str = None,
        refund_timestamp: int = None,
        subject: str = None,
        trade_no: str = None,
    ):
        self.actual_amount = actual_amount
        self.alipay_app_id = alipay_app_id
        self.close_time = close_time
        self.close_timestamp = close_timestamp
        self.create_time = create_time
        self.create_timestamp = create_timestamp
        self.label_amount = label_amount
        self.merchant_id = merchant_id
        self.merchant_merge_order_no = merchant_merge_order_no
        self.merchant_order_no = merchant_order_no
        self.order_no = order_no
        self.order_type = order_type
        self.outer_user_id = outer_user_id
        self.pay_logon_id = pay_logon_id
        self.pay_status = pay_status
        self.pay_time = pay_time
        self.pay_timestamp = pay_timestamp
        self.pay_type = pay_type
        self.refund_amount = refund_amount
        self.refund_status = refund_status
        self.refund_time = refund_time
        self.refund_timestamp = refund_timestamp
        self.subject = subject
        self.trade_no = trade_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_amount is not None:
            result['actualAmount'] = self.actual_amount
        if self.alipay_app_id is not None:
            result['alipayAppId'] = self.alipay_app_id
        if self.close_time is not None:
            result['closeTime'] = self.close_time
        if self.close_timestamp is not None:
            result['closeTimestamp'] = self.close_timestamp
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.label_amount is not None:
            result['labelAmount'] = self.label_amount
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.merchant_merge_order_no is not None:
            result['merchantMergeOrderNo'] = self.merchant_merge_order_no
        if self.merchant_order_no is not None:
            result['merchantOrderNo'] = self.merchant_order_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_type is not None:
            result['orderType'] = self.order_type
        if self.outer_user_id is not None:
            result['outerUserId'] = self.outer_user_id
        if self.pay_logon_id is not None:
            result['payLogonId'] = self.pay_logon_id
        if self.pay_status is not None:
            result['payStatus'] = self.pay_status
        if self.pay_time is not None:
            result['payTime'] = self.pay_time
        if self.pay_timestamp is not None:
            result['payTimestamp'] = self.pay_timestamp
        if self.pay_type is not None:
            result['payType'] = self.pay_type
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.refund_status is not None:
            result['refundStatus'] = self.refund_status
        if self.refund_time is not None:
            result['refundTime'] = self.refund_time
        if self.refund_timestamp is not None:
            result['refundTimestamp'] = self.refund_timestamp
        if self.subject is not None:
            result['subject'] = self.subject
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualAmount') is not None:
            self.actual_amount = m.get('actualAmount')
        if m.get('alipayAppId') is not None:
            self.alipay_app_id = m.get('alipayAppId')
        if m.get('closeTime') is not None:
            self.close_time = m.get('closeTime')
        if m.get('closeTimestamp') is not None:
            self.close_timestamp = m.get('closeTimestamp')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('labelAmount') is not None:
            self.label_amount = m.get('labelAmount')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('merchantMergeOrderNo') is not None:
            self.merchant_merge_order_no = m.get('merchantMergeOrderNo')
        if m.get('merchantOrderNo') is not None:
            self.merchant_order_no = m.get('merchantOrderNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        if m.get('outerUserId') is not None:
            self.outer_user_id = m.get('outerUserId')
        if m.get('payLogonId') is not None:
            self.pay_logon_id = m.get('payLogonId')
        if m.get('payStatus') is not None:
            self.pay_status = m.get('payStatus')
        if m.get('payTime') is not None:
            self.pay_time = m.get('payTime')
        if m.get('payTimestamp') is not None:
            self.pay_timestamp = m.get('payTimestamp')
        if m.get('payType') is not None:
            self.pay_type = m.get('payType')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('refundStatus') is not None:
            self.refund_status = m.get('refundStatus')
        if m.get('refundTime') is not None:
            self.refund_time = m.get('refundTime')
        if m.get('refundTimestamp') is not None:
            self.refund_timestamp = m.get('refundTimestamp')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        return self


class QuerySnsOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySnsOrderResponseBody = None,
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
            temp_model = QuerySnsOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryStatisticsDataHeaders(TeaModel):
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


class QueryStatisticsDataRequest(TeaModel):
    def __init__(
        self,
        section_index_list: List[int] = None,
        teacher_user_ids: List[str] = None,
        end_time: int = None,
        op_user_id: str = None,
        start_time: int = None,
    ):
        self.section_index_list = section_index_list
        self.teacher_user_ids = teacher_user_ids
        self.end_time = end_time
        self.op_user_id = op_user_id
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_index_list is not None:
            result['sectionIndexList'] = self.section_index_list
        if self.teacher_user_ids is not None:
            result['teacherUserIds'] = self.teacher_user_ids
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionIndexList') is not None:
            self.section_index_list = m.get('sectionIndexList')
        if m.get('teacherUserIds') is not None:
            self.teacher_user_ids = m.get('teacherUserIds')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class QueryStatisticsDataResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        course_count: int = None,
        course_hours: float = None,
        subject_code: str = None,
        subject_name: int = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.class_id = class_id
        self.course_count = course_count
        self.course_hours = course_hours
        self.subject_code = subject_code
        self.subject_name = subject_name
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.course_count is not None:
            result['courseCount'] = self.course_count
        if self.course_hours is not None:
            result['courseHours'] = self.course_hours
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('courseCount') is not None:
            self.course_count = m.get('courseCount')
        if m.get('courseHours') is not None:
            self.course_hours = m.get('courseHours')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryStatisticsDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryStatisticsDataResponseBodyResult] = None,
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
                temp_model = QueryStatisticsDataResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryStatisticsDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryStatisticsDataResponseBody = None,
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
            temp_model = QueryStatisticsDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySubjectTeachersHeaders(TeaModel):
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


class QuerySubjectTeachersRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
        subject_code: str = None,
    ):
        self.class_ids = class_ids
        self.op_user_id = op_user_id
        self.subject_code = subject_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        return self


class QuerySubjectTeachersResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        corp_id: str = None,
        period_code: str = None,
        subject_code: str = None,
        subject_name: str = None,
        teacher_name: str = None,
        teacher_user_id: str = None,
    ):
        self.class_id = class_id
        self.corp_id = corp_id
        self.period_code = period_code
        self.subject_code = subject_code
        self.subject_name = subject_name
        self.teacher_name = teacher_name
        self.teacher_user_id = teacher_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        return self


class QuerySubjectTeachersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QuerySubjectTeachersResponseBodyResult] = None,
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
                temp_model = QuerySubjectTeachersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QuerySubjectTeachersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySubjectTeachersResponseBody = None,
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
            temp_model = QuerySubjectTeachersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTeachSubjectsHeaders(TeaModel):
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


class QueryTeachSubjectsRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
    ):
        self.class_ids = class_ids
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryTeachSubjectsResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        corp_id: str = None,
        period_code: str = None,
        subject_code: str = None,
        subject_name: str = None,
        teacher_name: str = None,
        teacher_user_id: str = None,
    ):
        self.class_id = class_id
        self.corp_id = corp_id
        self.period_code = period_code
        self.subject_code = subject_code
        self.subject_name = subject_name
        self.teacher_name = teacher_name
        self.teacher_user_id = teacher_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        return self


class QueryTeachSubjectsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryTeachSubjectsResponseBodyResult] = None,
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
                temp_model = QueryTeachSubjectsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryTeachSubjectsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTeachSubjectsResponseBody = None,
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
            temp_model = QueryTeachSubjectsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUniversityCourseGroupHeaders(TeaModel):
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


class QueryUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        op_user_id: str = None,
    ):
        self.course_group_code = course_group_code
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        class_period_type: int = None,
        classroom_id: int = None,
        course_type: int = None,
        courser_group_item_end_date: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate = None,
        courser_group_item_start_date: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate = None,
        day_of_week: int = None,
        section_index: List[int] = None,
    ):
        self.class_period_type = class_period_type
        self.classroom_id = classroom_id
        self.course_type = course_type
        self.courser_group_item_end_date = courser_group_item_end_date
        self.courser_group_item_start_date = courser_group_item_start_date
        self.day_of_week = day_of_week
        self.section_index = section_index

    def validate(self):
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        course_group_introduce: str = None,
        course_group_name: str = None,
        courser_group_item_models: List[QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels] = None,
        isv_course_group_code: str = None,
        period_code: str = None,
        school_year: str = None,
        semester: int = None,
        subject_name: str = None,
    ):
        self.course_group_code = course_group_code
        self.course_group_introduce = course_group_introduce
        self.course_group_name = course_group_name
        self.courser_group_item_models = courser_group_item_models
        self.isv_course_group_code = isv_course_group_code
        self.period_code = period_code
        self.school_year = school_year
        self.semester = semester
        self.subject_name = subject_name

    def validate(self):
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        if self.isv_course_group_code is not None:
            result['isvCourseGroupCode'] = self.isv_course_group_code
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.semester is not None:
            result['semester'] = self.semester
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        if m.get('isvCourseGroupCode') is not None:
            self.isv_course_group_code = m.get('isvCourseGroupCode')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        return self


class QueryUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        university_course_group_info: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo = None,
    ):
        self.university_course_group_info = university_course_group_info

    def validate(self):
        if self.university_course_group_info:
            self.university_course_group_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_group_info is not None:
            result['universityCourseGroupInfo'] = self.university_course_group_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseGroupInfo') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo()
            self.university_course_group_info = temp_model.from_map(m['universityCourseGroupInfo'])
        return self


class QueryUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUniversityCourseGroupResponseBody = None,
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
            temp_model = QueryUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserFaceHeaders(TeaModel):
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


class QueryUserFaceRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        sn: str = None,
    ):
        self.face_id = face_id
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class QueryUserFaceResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        face_id: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.corp_id = corp_id
        self.face_id = face_id
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserFaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserFaceResponseBody = None,
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
            temp_model = QueryUserFaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserPayInfoHeaders(TeaModel):
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


class QueryUserPayInfoRequest(TeaModel):
    def __init__(
        self,
        face_id: str = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.face_id = face_id
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.face_id is not None:
            result['faceId'] = self.face_id
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('faceId') is not None:
            self.face_id = m.get('faceId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserPayInfoResponseBody(TeaModel):
    def __init__(
        self,
        sign_no: str = None,
    ):
        self.sign_no = sign_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sign_no is not None:
            result['signNo'] = self.sign_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('signNo') is not None:
            self.sign_no = m.get('signNo')
        return self


class QueryUserPayInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserPayInfoResponseBody = None,
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
            temp_model = QueryUserPayInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveDeviceHeaders(TeaModel):
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


class RemoveDeviceRequest(TeaModel):
    def __init__(
        self,
        merchant_id: str = None,
        sn: str = None,
    ):
        self.merchant_id = merchant_id
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class RemoveDeviceResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RemoveDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveDeviceResponseBody = None,
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
            temp_model = RemoveDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReportDeviceLogHeaders(TeaModel):
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


class ReportDeviceLogRequest(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        sn: str = None,
        type: str = None,
    ):
        self.media_id = media_id
        self.sn = sn
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.sn is not None:
            result['sn'] = self.sn
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ReportDeviceLogResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ReportDeviceLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReportDeviceLogResponseBody = None,
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
            temp_model = ReportDeviceLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReportDeviceUseLogHeaders(TeaModel):
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


class ReportDeviceUseLogRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        order_no: str = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.action = action
        self.order_no = order_no
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ReportDeviceUseLogResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ReportDeviceUseLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReportDeviceUseLogResponseBody = None,
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
            temp_model = ReportDeviceUseLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RollbackDeductPointHeaders(TeaModel):
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


class RollbackDeductPointRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        point_type: str = None,
    ):
        self.biz_id = biz_id
        self.point_type = point_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.point_type is not None:
            result['pointType'] = self.point_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('pointType') is not None:
            self.point_type = m.get('pointType')
        return self


class RollbackDeductPointResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RollbackDeductPointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RollbackDeductPointResponseBody = None,
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
            temp_model = RollbackDeductPointResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchTeachersHeaders(TeaModel):
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


class SearchTeachersRequest(TeaModel):
    def __init__(
        self,
        name_keyword: str = None,
    ):
        self.name_keyword = name_keyword

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_keyword is not None:
            result['nameKeyword'] = self.name_keyword
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameKeyword') is not None:
            self.name_keyword = m.get('nameKeyword')
        return self


class SearchTeachersResponseBodyUsers(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        dept_name: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.class_id = class_id
        self.dept_name = dept_name
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchTeachersResponseBody(TeaModel):
    def __init__(
        self,
        users: List[SearchTeachersResponseBodyUsers] = None,
    ):
        self.users = users

    def validate(self):
        if self.users:
            for k in self.users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['users'] = []
        if self.users is not None:
            for k in self.users:
                result['users'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.users = []
        if m.get('users') is not None:
            for k in m.get('users'):
                temp_model = SearchTeachersResponseBodyUsers()
                self.users.append(temp_model.from_map(k))
        return self


class SearchTeachersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchTeachersResponseBody = None,
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
            temp_model = SearchTeachersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMessageHeaders(TeaModel):
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


class SendMessageRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        from_user_id: str = None,
        sn: str = None,
        to_user_id_list: List[str] = None,
        type: int = None,
    ):
        self.biz_id = biz_id
        self.from_user_id = from_user_id
        self.sn = sn
        self.to_user_id_list = to_user_id_list
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.from_user_id is not None:
            result['fromUserId'] = self.from_user_id
        if self.sn is not None:
            result['sn'] = self.sn
        if self.to_user_id_list is not None:
            result['toUserIdList'] = self.to_user_id_list
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('fromUserId') is not None:
            self.from_user_id = m.get('fromUserId')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('toUserIdList') is not None:
            self.to_user_id_list = m.get('toUserIdList')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SendMessageResponseBody(TeaModel):
    def __init__(
        self,
        success_info: str = None,
    ):
        self.success_info = success_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success_info is not None:
            result['successInfo'] = self.success_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('successInfo') is not None:
            self.success_info = m.get('successInfo')
        return self


class SendMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendMessageResponseBody = None,
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
            temp_model = SendMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartCourseHeaders(TeaModel):
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


class StartCourseRequestLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_input_url: str = None,
        live_output_flv_url: str = None,
        live_output_hls_url: str = None,
        live_type: int = None,
        replay_url: str = None,
    ):
        self.live_input_url = live_input_url
        self.live_output_flv_url = live_output_flv_url
        self.live_output_hls_url = live_output_hls_url
        self.live_type = live_type
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.live_output_flv_url is not None:
            result['liveOutputFlvUrl'] = self.live_output_flv_url
        if self.live_output_hls_url is not None:
            result['liveOutputHlsUrl'] = self.live_output_hls_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('liveOutputFlvUrl') is not None:
            self.live_output_flv_url = m.get('liveOutputFlvUrl')
        if m.get('liveOutputHlsUrl') is not None:
            self.live_output_hls_url = m.get('liveOutputHlsUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class StartCourseRequest(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        ext: str = None,
        isv_code: str = None,
        live_play_info_list: List[StartCourseRequestLivePlayInfoList] = None,
        op_user_id: str = None,
    ):
        self.course_code = course_code
        self.ext = ext
        self.isv_code = isv_code
        self.live_play_info_list = live_play_info_list
        self.op_user_id = op_user_id

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = StartCourseRequestLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class StartCourseResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        success: bool = None,
    ):
        self.course_code = course_code
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class StartCourseResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: StartCourseResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = StartCourseResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class StartCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartCourseResponseBody = None,
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
            temp_model = StartCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartCoursePrepareHeaders(TeaModel):
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


class StartCoursePrepareRequest(TeaModel):
    def __init__(
        self,
        course_date: str = None,
        course_group_code: str = None,
        device_id: str = None,
        ext: str = None,
        isv_code: str = None,
        live_cover_image: str = None,
        section_index: List[int] = None,
        op_user_id: str = None,
    ):
        self.course_date = course_date
        self.course_group_code = course_group_code
        self.device_id = device_id
        self.ext = ext
        self.isv_code = isv_code
        self.live_cover_image = live_cover_image
        self.section_index = section_index
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_date is not None:
            result['courseDate'] = self.course_date
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.live_cover_image is not None:
            result['liveCoverImage'] = self.live_cover_image
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseDate') is not None:
            self.course_date = m.get('courseDate')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('liveCoverImage') is not None:
            self.live_cover_image = m.get('liveCoverImage')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class StartCoursePrepareResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        success: bool = None,
    ):
        self.course_code = course_code
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class StartCoursePrepareResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: StartCoursePrepareResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = StartCoursePrepareResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class StartCoursePrepareResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartCoursePrepareResponseBody = None,
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
            temp_model = StartCoursePrepareResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubscribeUniversityCourseGroupHeaders(TeaModel):
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


class SubscribeUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        student_user_ids: List[str] = None,
        op_user_id: str = None,
    ):
        self.course_group_code = course_group_code
        self.student_user_ids = student_user_ids
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.student_user_ids is not None:
            result['studentUserIds'] = self.student_user_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('studentUserIds') is not None:
            self.student_user_ids = m.get('studentUserIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class SubscribeUniversityCourseGroupResponseBody(TeaModel):
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


class SubscribeUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SubscribeUniversityCourseGroupResponseBody = None,
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
            temp_model = SubscribeUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsubscribeUniversityCourseGroupHeaders(TeaModel):
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


class UnsubscribeUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        student_user_ids: List[str] = None,
        op_user_id: str = None,
    ):
        self.course_group_code = course_group_code
        self.student_user_ids = student_user_ids
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.student_user_ids is not None:
            result['studentUserIds'] = self.student_user_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('studentUserIds') is not None:
            self.student_user_ids = m.get('studentUserIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UnsubscribeUniversityCourseGroupResponseBody(TeaModel):
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


class UnsubscribeUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnsubscribeUniversityCourseGroupResponseBody = None,
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
            temp_model = UnsubscribeUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCoursesOfClassHeaders(TeaModel):
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


class UpdateCoursesOfClassRequestCoursesDateModel(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class UpdateCoursesOfClassRequestCoursesSectionModel(TeaModel):
    def __init__(
        self,
        section_index: int = None,
        section_name: str = None,
        section_type: str = None,
    ):
        self.section_index = section_index
        self.section_name = section_name
        self.section_type = section_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        return self


class UpdateCoursesOfClassRequestCourses(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        course_group_code: str = None,
        course_name: str = None,
        creator_name: str = None,
        date_model: UpdateCoursesOfClassRequestCoursesDateModel = None,
        delete_tag: bool = None,
        location: str = None,
        section_model: UpdateCoursesOfClassRequestCoursesSectionModel = None,
        teacher_staff_ids: List[str] = None,
    ):
        self.course_code = course_code
        self.course_group_code = course_group_code
        self.course_name = course_name
        self.creator_name = creator_name
        self.date_model = date_model
        self.delete_tag = delete_tag
        self.location = location
        self.section_model = section_model
        self.teacher_staff_ids = teacher_staff_ids

    def validate(self):
        if self.date_model:
            self.date_model.validate()
        if self.section_model:
            self.section_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.date_model is not None:
            result['dateModel'] = self.date_model.to_map()
        if self.delete_tag is not None:
            result['deleteTag'] = self.delete_tag
        if self.location is not None:
            result['location'] = self.location
        if self.section_model is not None:
            result['sectionModel'] = self.section_model.to_map()
        if self.teacher_staff_ids is not None:
            result['teacherStaffIds'] = self.teacher_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('dateModel') is not None:
            temp_model = UpdateCoursesOfClassRequestCoursesDateModel()
            self.date_model = temp_model.from_map(m['dateModel'])
        if m.get('deleteTag') is not None:
            self.delete_tag = m.get('deleteTag')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('sectionModel') is not None:
            temp_model = UpdateCoursesOfClassRequestCoursesSectionModel()
            self.section_model = temp_model.from_map(m['sectionModel'])
        if m.get('teacherStaffIds') is not None:
            self.teacher_staff_ids = m.get('teacherStaffIds')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        self.hour = hour
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModels(TeaModel):
    def __init__(
        self,
        end: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd = None,
        section_index: int = None,
        section_type: str = None,
        start: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart = None,
    ):
        self.end = end
        self.section_index = section_index
        self.section_type = section_type
        self.start = start

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        return self


class UpdateCoursesOfClassRequestSectionConfig(TeaModel):
    def __init__(
        self,
        section_models: List[UpdateCoursesOfClassRequestSectionConfigSectionModels] = None,
    ):
        self.section_models = section_models

    def validate(self):
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        return self


class UpdateCoursesOfClassRequest(TeaModel):
    def __init__(
        self,
        courses: List[UpdateCoursesOfClassRequestCourses] = None,
        section_config: UpdateCoursesOfClassRequestSectionConfig = None,
        op_user_id: str = None,
    ):
        self.courses = courses
        self.section_config = section_config
        self.op_user_id = op_user_id

    def validate(self):
        if self.courses:
            for k in self.courses:
                if k:
                    k.validate()
        if self.section_config:
            self.section_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['courses'] = []
        if self.courses is not None:
            for k in self.courses:
                result['courses'].append(k.to_map() if k else None)
        if self.section_config is not None:
            result['sectionConfig'] = self.section_config.to_map()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.courses = []
        if m.get('courses') is not None:
            for k in m.get('courses'):
                temp_model = UpdateCoursesOfClassRequestCourses()
                self.courses.append(temp_model.from_map(k))
        if m.get('sectionConfig') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfig()
            self.section_config = temp_model.from_map(m['sectionConfig'])
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateCoursesOfClassResponseBody(TeaModel):
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


class UpdateCoursesOfClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateCoursesOfClassResponseBody = None,
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
            temp_model = UpdateCoursesOfClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePhysicalClassroomHeaders(TeaModel):
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


class UpdatePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        classroom_building: str = None,
        classroom_campus: str = None,
        classroom_floor: str = None,
        classroom_id: int = None,
        classroom_name: str = None,
        classroom_number: str = None,
        direct_broadcast: str = None,
        ext: str = None,
        op_user_id: str = None,
    ):
        self.classroom_building = classroom_building
        self.classroom_campus = classroom_campus
        self.classroom_floor = classroom_floor
        self.classroom_id = classroom_id
        self.classroom_name = classroom_name
        self.classroom_number = classroom_number
        self.direct_broadcast = direct_broadcast
        self.ext = ext
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        if self.ext is not None:
            result['ext'] = self.ext
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdatePhysicalClassroomResponseBody(TeaModel):
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


class UpdatePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdatePhysicalClassroomResponseBody = None,
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
            temp_model = UpdatePhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRemoteClassCourseHeaders(TeaModel):
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


class UpdateRemoteClassCourseRequestAttendParticipants(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        participant_id: str = None,
    ):
        self.corp_id = corp_id
        self.participant_id = participant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        return self


class UpdateRemoteClassCourseRequestTeachingParticipant(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        participant_id: str = None,
    ):
        self.corp_id = corp_id
        self.participant_id = participant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        return self


class UpdateRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        attend_participants: List[UpdateRemoteClassCourseRequestAttendParticipants] = None,
        auth_code: str = None,
        course_code: str = None,
        course_name: str = None,
        end_time: int = None,
        start_time: int = None,
        teaching_participant: UpdateRemoteClassCourseRequestTeachingParticipant = None,
    ):
        self.attend_participants = attend_participants
        self.auth_code = auth_code
        self.course_code = course_code
        self.course_name = course_name
        self.end_time = end_time
        self.start_time = start_time
        self.teaching_participant = teaching_participant

    def validate(self):
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()
        if self.teaching_participant:
            self.teaching_participant.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = UpdateRemoteClassCourseRequestAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teachingParticipant') is not None:
            temp_model = UpdateRemoteClassCourseRequestTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        return self


class UpdateRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRemoteClassCourseResponseBody = None,
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
            temp_model = UpdateRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRemoteClassDeviceHeaders(TeaModel):
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


class UpdateRemoteClassDeviceRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        device_code: str = None,
        device_name: str = None,
    ):
        self.auth_code = auth_code
        self.device_code = device_code
        self.device_name = device_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        return self


class UpdateRemoteClassDeviceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateRemoteClassDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRemoteClassDeviceResponseBody = None,
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
            temp_model = UpdateRemoteClassDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUniversityCourseGroupHeaders(TeaModel):
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


class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        month: int = None,
        year: int = None,
    ):
        self.day_of_month = day_of_month
        self.month = month
        self.year = year

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        return self


class UpdateUniversityCourseGroupRequestCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        class_period_type: int = None,
        classroom_id: int = None,
        course_type: int = None,
        courser_group_item_end_date: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate = None,
        courser_group_item_start_date: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate = None,
        day_of_week: int = None,
        section_index: List[int] = None,
    ):
        self.class_period_type = class_period_type
        self.classroom_id = classroom_id
        self.course_type = course_type
        self.courser_group_item_end_date = courser_group_item_end_date
        self.courser_group_item_start_date = courser_group_item_start_date
        self.day_of_week = day_of_week
        self.section_index = section_index

    def validate(self):
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        return self


class UpdateUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        course_group_introduce: str = None,
        course_group_name: str = None,
        courser_group_item_models: List[UpdateUniversityCourseGroupRequestCourserGroupItemModels] = None,
        ext: str = None,
        op_user_id: str = None,
    ):
        self.course_group_code = course_group_code
        self.course_group_introduce = course_group_introduce
        self.course_group_name = course_group_name
        self.courser_group_item_models = courser_group_item_models
        self.ext = ext
        self.op_user_id = op_user_id

    def validate(self):
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        if self.ext is not None:
            result['ext'] = self.ext
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateUniversityCourseGroupResponseBody(TeaModel):
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


class UpdateUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateUniversityCourseGroupResponseBody = None,
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
            temp_model = UpdateUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class VPaasProxyHeaders(TeaModel):
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


class VPaasProxyRequest(TeaModel):
    def __init__(
        self,
        action_code: str = None,
        params: str = None,
        public_key: str = None,
    ):
        self.action_code = action_code
        self.params = params
        self.public_key = public_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_code is not None:
            result['actionCode'] = self.action_code
        if self.params is not None:
            result['params'] = self.params
        if self.public_key is not None:
            result['publicKey'] = self.public_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionCode') is not None:
            self.action_code = m.get('actionCode')
        if m.get('params') is not None:
            self.params = m.get('params')
        if m.get('publicKey') is not None:
            self.public_key = m.get('publicKey')
        return self


class VPaasProxyResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        ticket: str = None,
    ):
        self.result = result
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class VPaasProxyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: VPaasProxyResponseBody = None,
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
            temp_model = VPaasProxyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateUserRoleHeaders(TeaModel):
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


class ValidateUserRoleRequest(TeaModel):
    def __init__(
        self,
        time_threshold: int = None,
        union_id: str = None,
    ):
        self.time_threshold = time_threshold
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.time_threshold is not None:
            result['timeThreshold'] = self.time_threshold
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timeThreshold') is not None:
            self.time_threshold = m.get('timeThreshold')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ValidateUserRoleResponseBody(TeaModel):
    def __init__(
        self,
        match_parent_identity: bool = None,
        match_teacher_identity: bool = None,
    ):
        self.match_parent_identity = match_parent_identity
        self.match_teacher_identity = match_teacher_identity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.match_parent_identity is not None:
            result['matchParentIdentity'] = self.match_parent_identity
        if self.match_teacher_identity is not None:
            result['matchTeacherIdentity'] = self.match_teacher_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('matchParentIdentity') is not None:
            self.match_parent_identity = m.get('matchParentIdentity')
        if m.get('matchTeacherIdentity') is not None:
            self.match_teacher_identity = m.get('matchTeacherIdentity')
        return self


class ValidateUserRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateUserRoleResponseBody = None,
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
            temp_model = ValidateUserRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


