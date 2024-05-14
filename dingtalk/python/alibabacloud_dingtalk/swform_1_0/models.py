# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetFormInstanceHeaders(TeaModel):
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


class GetFormInstanceRequest(TeaModel):
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


class GetFormInstanceResponseBodyResultForms(TeaModel):
    def __init__(
        self,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.key = key
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetFormInstanceResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        creator: str = None,
        form_code: str = None,
        forms: List[GetFormInstanceResponseBodyResultForms] = None,
        modify_time: str = None,
        title: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.creator = creator
        self.form_code = form_code
        self.forms = forms
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.modify_time = modify_time
        self.title = title

    def validate(self):
        if self.forms:
            for k in self.forms:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        result['forms'] = []
        if self.forms is not None:
            for k in self.forms:
                result['forms'].append(k.to_map() if k else None)
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        self.forms = []
        if m.get('forms') is not None:
            for k in m.get('forms'):
                temp_model = GetFormInstanceResponseBodyResultForms()
                self.forms.append(temp_model.from_map(k))
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: GetFormInstanceResponseBodyResult = None,
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
            temp_model = GetFormInstanceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormInstanceResponseBody = None,
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
            temp_model = GetFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFormInstancesHeaders(TeaModel):
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


class ListFormInstancesRequest(TeaModel):
    def __init__(
        self,
        action_date: str = None,
        biz_type: int = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.action_date = action_date
        self.biz_type = biz_type
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_date is not None:
            result['actionDate'] = self.action_date
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionDate') is not None:
            self.action_date = m.get('actionDate')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFormInstancesResponseBodyResultListForms(TeaModel):
    def __init__(
        self,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.key = key
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListFormInstancesResponseBodyResultList(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        form_code: str = None,
        form_instance_id: str = None,
        forms: List[ListFormInstancesResponseBodyResultListForms] = None,
        modify_time: str = None,
        student_class_id: str = None,
        student_class_name: str = None,
        student_name: str = None,
        student_user_id: str = None,
        submitter_user_id: str = None,
        submitter_user_name: str = None,
        title: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.form_code = form_code
        self.form_instance_id = form_instance_id
        self.forms = forms
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.modify_time = modify_time
        self.student_class_id = student_class_id
        self.student_class_name = student_class_name
        self.student_name = student_name
        self.student_user_id = student_user_id
        self.submitter_user_id = submitter_user_id
        self.submitter_user_name = submitter_user_name
        self.title = title

    def validate(self):
        if self.forms:
            for k in self.forms:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        result['forms'] = []
        if self.forms is not None:
            for k in self.forms:
                result['forms'].append(k.to_map() if k else None)
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        if self.student_class_id is not None:
            result['studentClassId'] = self.student_class_id
        if self.student_class_name is not None:
            result['studentClassName'] = self.student_class_name
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.student_user_id is not None:
            result['studentUserId'] = self.student_user_id
        if self.submitter_user_id is not None:
            result['submitterUserId'] = self.submitter_user_id
        if self.submitter_user_name is not None:
            result['submitterUserName'] = self.submitter_user_name
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        self.forms = []
        if m.get('forms') is not None:
            for k in m.get('forms'):
                temp_model = ListFormInstancesResponseBodyResultListForms()
                self.forms.append(temp_model.from_map(k))
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        if m.get('studentClassId') is not None:
            self.student_class_id = m.get('studentClassId')
        if m.get('studentClassName') is not None:
            self.student_class_name = m.get('studentClassName')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('studentUserId') is not None:
            self.student_user_id = m.get('studentUserId')
        if m.get('submitterUserId') is not None:
            self.submitter_user_id = m.get('submitterUserId')
        if m.get('submitterUserName') is not None:
            self.submitter_user_name = m.get('submitterUserName')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ListFormInstancesResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListFormInstancesResponseBodyResultList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListFormInstancesResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFormInstancesResponseBody(TeaModel):
    def __init__(
        self,
        result: ListFormInstancesResponseBodyResult = None,
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
            temp_model = ListFormInstancesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListFormInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListFormInstancesResponseBody = None,
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
            temp_model = ListFormInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFormSchemasByCreatorHeaders(TeaModel):
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


class ListFormSchemasByCreatorRequest(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        creator: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.biz_type = biz_type
        self.creator = creator
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.creator is not None:
            result['creator'] = self.creator
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFormSchemasByCreatorResponseBodyResultListSetting(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        create_time: str = None,
        end_time: str = None,
        form_type: int = None,
        loop_days: List[int] = None,
        loop_time: str = None,
        stop: bool = None,
    ):
        self.biz_type = biz_type
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_time = end_time
        self.form_type = form_type
        self.loop_days = loop_days
        self.loop_time = loop_time
        self.stop = stop

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.form_type is not None:
            result['formType'] = self.form_type
        if self.loop_days is not None:
            result['loopDays'] = self.loop_days
        if self.loop_time is not None:
            result['loopTime'] = self.loop_time
        if self.stop is not None:
            result['stop'] = self.stop
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('formType') is not None:
            self.form_type = m.get('formType')
        if m.get('loopDays') is not None:
            self.loop_days = m.get('loopDays')
        if m.get('loopTime') is not None:
            self.loop_time = m.get('loopTime')
        if m.get('stop') is not None:
            self.stop = m.get('stop')
        return self


class ListFormSchemasByCreatorResponseBodyResultList(TeaModel):
    def __init__(
        self,
        creator: str = None,
        form_code: str = None,
        memo: str = None,
        name: str = None,
        setting: ListFormSchemasByCreatorResponseBodyResultListSetting = None,
    ):
        self.creator = creator
        self.form_code = form_code
        self.memo = memo
        self.name = name
        self.setting = setting

    def validate(self):
        if self.setting:
            self.setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.memo is not None:
            result['memo'] = self.memo
        if self.name is not None:
            result['name'] = self.name
        if self.setting is not None:
            result['setting'] = self.setting.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('setting') is not None:
            temp_model = ListFormSchemasByCreatorResponseBodyResultListSetting()
            self.setting = temp_model.from_map(m['setting'])
        return self


class ListFormSchemasByCreatorResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListFormSchemasByCreatorResponseBodyResultList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListFormSchemasByCreatorResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFormSchemasByCreatorResponseBody(TeaModel):
    def __init__(
        self,
        result: ListFormSchemasByCreatorResponseBodyResult = None,
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
            temp_model = ListFormSchemasByCreatorResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListFormSchemasByCreatorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListFormSchemasByCreatorResponseBody = None,
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
            temp_model = ListFormSchemasByCreatorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


