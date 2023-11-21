# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class UserMapValue(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
        dept_id: str = None,
    ):
        self.user_id = user_id
        self.name = name
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


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


class GetSendAndReceiveReportListHeaders(TeaModel):
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


class GetSendAndReceiveReportListRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: int = None,
        operation_user_id: str = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.max_results = max_results
        self.next_token = next_token
        self.operation_user_id = operation_user_id
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operation_user_id is not None:
            result['operationUserId'] = self.operation_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operationUserId') is not None:
            self.operation_user_id = m.get('operationUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetSendAndReceiveReportListResponseBodyDataList(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        creator_id: str = None,
        creator_name: str = None,
        modified_time: int = None,
        report_id: str = None,
        template_name: str = None,
    ):
        self.create_time = create_time
        self.creator_id = creator_id
        self.creator_name = creator_name
        self.modified_time = modified_time
        self.report_id = report_id
        self.template_name = template_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.report_id is not None:
            result['reportId'] = self.report_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('reportId') is not None:
            self.report_id = m.get('reportId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        return self


class GetSendAndReceiveReportListResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[GetSendAndReceiveReportListResponseBodyDataList] = None,
        has_more: bool = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.data_list = data_list
        self.has_more = has_more
        self.max_results = max_results
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = GetSendAndReceiveReportListResponseBodyDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetSendAndReceiveReportListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSendAndReceiveReportListResponseBody = None,
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
            temp_model = GetSendAndReceiveReportListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSubmitStatisticsHeaders(TeaModel):
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


class GetSubmitStatisticsRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        operation_user_id: str = None,
        remind_id: int = None,
        start_time: int = None,
        template_id: str = None,
    ):
        self.end_time = end_time
        self.operation_user_id = operation_user_id
        self.remind_id = remind_id
        self.start_time = start_time
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.operation_user_id is not None:
            result['operationUserId'] = self.operation_user_id
        if self.remind_id is not None:
            result['remindId'] = self.remind_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('operationUserId') is not None:
            self.operation_user_id = m.get('operationUserId')
        if m.get('remindId') is not None:
            self.remind_id = m.get('remindId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class GetSubmitStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        should_remind_times: int = None,
        template_name: str = None,
        user_dept_map: Dict[str, str] = None,
        user_id_count_map: Dict[str, int] = None,
        user_id_status_map: Dict[str, dict] = None,
        user_ids: List[str] = None,
        user_map: Dict[str, UserMapValue] = None,
    ):
        self.should_remind_times = should_remind_times
        self.template_name = template_name
        self.user_dept_map = user_dept_map
        self.user_id_count_map = user_id_count_map
        self.user_id_status_map = user_id_status_map
        self.user_ids = user_ids
        self.user_map = user_map

    def validate(self):
        if self.user_map:
            for v in self.user_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.should_remind_times is not None:
            result['shouldRemindTimes'] = self.should_remind_times
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.user_dept_map is not None:
            result['userDeptMap'] = self.user_dept_map
        if self.user_id_count_map is not None:
            result['userIdCountMap'] = self.user_id_count_map
        if self.user_id_status_map is not None:
            result['userIdStatusMap'] = self.user_id_status_map
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        result['userMap'] = {}
        if self.user_map is not None:
            for k, v in self.user_map.items():
                result['userMap'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shouldRemindTimes') is not None:
            self.should_remind_times = m.get('shouldRemindTimes')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('userDeptMap') is not None:
            self.user_dept_map = m.get('userDeptMap')
        if m.get('userIdCountMap') is not None:
            self.user_id_count_map = m.get('userIdCountMap')
        if m.get('userIdStatusMap') is not None:
            self.user_id_status_map = m.get('userIdStatusMap')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        self.user_map = {}
        if m.get('userMap') is not None:
            for k, v in m.get('userMap').items():
                temp_model = UserMapValue()
                self.user_map[k] = temp_model.from_map(v)
        return self


class GetSubmitStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSubmitStatisticsResponseBody = None,
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
            temp_model = GetSubmitStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


