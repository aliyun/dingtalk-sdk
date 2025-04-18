# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AppLoginCodeGenHeaders(TeaModel):
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


class AppLoginCodeGenRequest(TeaModel):
    def __init__(
        self,
        app_key: str = None,
        sign_timestamp_str: str = None,
        signature: str = None,
        full_url: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_key = app_key
        # This parameter is required.
        self.sign_timestamp_str = sign_timestamp_str
        # This parameter is required.
        self.signature = signature
        # This parameter is required.
        self.full_url = full_url
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.sign_timestamp_str is not None:
            result['signTimestampStr'] = self.sign_timestamp_str
        if self.signature is not None:
            result['signature'] = self.signature
        if self.full_url is not None:
            result['fullUrl'] = self.full_url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('signTimestampStr') is not None:
            self.sign_timestamp_str = m.get('signTimestampStr')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('fullUrl') is not None:
            self.full_url = m.get('fullUrl')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AppLoginCodeGenResponseBody(TeaModel):
    def __init__(
        self,
        login_code: str = None,
    ):
        self.login_code = login_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.login_code is not None:
            result['loginCode'] = self.login_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('loginCode') is not None:
            self.login_code = m.get('loginCode')
        return self


class AppLoginCodeGenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppLoginCodeGenResponseBody = None,
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
            temp_model = AppLoginCodeGenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchGetFormDataByIdListHeaders(TeaModel):
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


class BatchGetFormDataByIdListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_instance_id_list: List[str] = None,
        form_uuid: str = None,
        need_form_instance_value: bool = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_instance_id_list = form_instance_id_list
        # This parameter is required.
        self.form_uuid = form_uuid
        self.need_form_instance_value = need_form_instance_value
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_instance_id_list is not None:
            result['formInstanceIdList'] = self.form_instance_id_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.need_form_instance_value is not None:
            result['needFormInstanceValue'] = self.need_form_instance_value
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formInstanceIdList') is not None:
            self.form_instance_id_list = m.get('formInstanceIdList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('needFormInstanceValue') is not None:
            self.need_form_instance_value = m.get('needFormInstanceValue')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchGetFormDataByIdListResponseBodyResultModifyUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class BatchGetFormDataByIdListResponseBodyResultModifyUser(TeaModel):
    def __init__(
        self,
        name: BatchGetFormDataByIdListResponseBodyResultModifyUserName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = BatchGetFormDataByIdListResponseBodyResultModifyUserName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchGetFormDataByIdListResponseBodyResultOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class BatchGetFormDataByIdListResponseBodyResultOriginator(TeaModel):
    def __init__(
        self,
        name: BatchGetFormDataByIdListResponseBodyResultOriginatorName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = BatchGetFormDataByIdListResponseBodyResultOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchGetFormDataByIdListResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        form_data: Dict[str, Any] = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        id: int = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        modify_user: BatchGetFormDataByIdListResponseBodyResultModifyUser = None,
        originator: BatchGetFormDataByIdListResponseBodyResultOriginator = None,
        sequence: str = None,
        serial_number: str = None,
        title: str = None,
        version: int = None,
    ):
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.form_data = form_data
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.id = id
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.modify_user = modify_user
        self.originator = originator
        self.sequence = sequence
        self.serial_number = serial_number
        self.title = title
        self.version = version

    def validate(self):
        if self.modify_user:
            self.modify_user.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.id is not None:
            result['id'] = self.id
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyUser') is not None:
            temp_model = BatchGetFormDataByIdListResponseBodyResultModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('originator') is not None:
            temp_model = BatchGetFormDataByIdListResponseBodyResultOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class BatchGetFormDataByIdListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[BatchGetFormDataByIdListResponseBodyResult] = None,
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
                temp_model = BatchGetFormDataByIdListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class BatchGetFormDataByIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchGetFormDataByIdListResponseBody = None,
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
            temp_model = BatchGetFormDataByIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchRemovalByFormInstanceIdListHeaders(TeaModel):
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


class BatchRemovalByFormInstanceIdListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        asynchronous_execution: bool = None,
        execute_expression: bool = None,
        form_instance_id_list: List[str] = None,
        form_uuid: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.asynchronous_execution = asynchronous_execution
        self.execute_expression = execute_expression
        # This parameter is required.
        self.form_instance_id_list = form_instance_id_list
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.asynchronous_execution is not None:
            result['asynchronousExecution'] = self.asynchronous_execution
        if self.execute_expression is not None:
            result['executeExpression'] = self.execute_expression
        if self.form_instance_id_list is not None:
            result['formInstanceIdList'] = self.form_instance_id_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('asynchronousExecution') is not None:
            self.asynchronous_execution = m.get('asynchronousExecution')
        if m.get('executeExpression') is not None:
            self.execute_expression = m.get('executeExpression')
        if m.get('formInstanceIdList') is not None:
            self.form_instance_id_list = m.get('formInstanceIdList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchRemovalByFormInstanceIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class BatchSaveFormDataHeaders(TeaModel):
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


class BatchSaveFormDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        asynchronous_execution: bool = None,
        form_data_json_list: List[str] = None,
        form_uuid: str = None,
        keep_running_after_exception: bool = None,
        no_execute_expression: bool = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.asynchronous_execution = asynchronous_execution
        # This parameter is required.
        self.form_data_json_list = form_data_json_list
        # This parameter is required.
        self.form_uuid = form_uuid
        self.keep_running_after_exception = keep_running_after_exception
        self.no_execute_expression = no_execute_expression
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.asynchronous_execution is not None:
            result['asynchronousExecution'] = self.asynchronous_execution
        if self.form_data_json_list is not None:
            result['formDataJsonList'] = self.form_data_json_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.keep_running_after_exception is not None:
            result['keepRunningAfterException'] = self.keep_running_after_exception
        if self.no_execute_expression is not None:
            result['noExecuteExpression'] = self.no_execute_expression
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('asynchronousExecution') is not None:
            self.asynchronous_execution = m.get('asynchronousExecution')
        if m.get('formDataJsonList') is not None:
            self.form_data_json_list = m.get('formDataJsonList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('keepRunningAfterException') is not None:
            self.keep_running_after_exception = m.get('keepRunningAfterException')
        if m.get('noExecuteExpression') is not None:
            self.no_execute_expression = m.get('noExecuteExpression')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchSaveFormDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class BatchSaveFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchSaveFormDataResponseBody = None,
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
            temp_model = BatchSaveFormDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchUpdateFormDataByInstanceIdHeaders(TeaModel):
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


class BatchUpdateFormDataByInstanceIdRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        asynchronous_execution: bool = None,
        form_instance_id_list: List[str] = None,
        form_uuid: str = None,
        ignore_empty: bool = None,
        no_execute_expression: bool = None,
        system_token: str = None,
        update_form_data_json: str = None,
        use_latest_form_schema_version: bool = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.asynchronous_execution = asynchronous_execution
        # This parameter is required.
        self.form_instance_id_list = form_instance_id_list
        # This parameter is required.
        self.form_uuid = form_uuid
        self.ignore_empty = ignore_empty
        self.no_execute_expression = no_execute_expression
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.update_form_data_json = update_form_data_json
        self.use_latest_form_schema_version = use_latest_form_schema_version
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.asynchronous_execution is not None:
            result['asynchronousExecution'] = self.asynchronous_execution
        if self.form_instance_id_list is not None:
            result['formInstanceIdList'] = self.form_instance_id_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.ignore_empty is not None:
            result['ignoreEmpty'] = self.ignore_empty
        if self.no_execute_expression is not None:
            result['noExecuteExpression'] = self.no_execute_expression
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        if self.use_latest_form_schema_version is not None:
            result['useLatestFormSchemaVersion'] = self.use_latest_form_schema_version
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('asynchronousExecution') is not None:
            self.asynchronous_execution = m.get('asynchronousExecution')
        if m.get('formInstanceIdList') is not None:
            self.form_instance_id_list = m.get('formInstanceIdList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('ignoreEmpty') is not None:
            self.ignore_empty = m.get('ignoreEmpty')
        if m.get('noExecuteExpression') is not None:
            self.no_execute_expression = m.get('noExecuteExpression')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        if m.get('useLatestFormSchemaVersion') is not None:
            self.use_latest_form_schema_version = m.get('useLatestFormSchemaVersion')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchUpdateFormDataByInstanceIdResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class BatchUpdateFormDataByInstanceIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchUpdateFormDataByInstanceIdResponseBody = None,
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
            temp_model = BatchUpdateFormDataByInstanceIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchUpdateFormDataByInstanceMapHeaders(TeaModel):
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


class BatchUpdateFormDataByInstanceMapRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        asynchronous_execution: bool = None,
        form_uuid: str = None,
        ignore_empty: bool = None,
        no_execute_expression: bool = None,
        system_token: str = None,
        update_form_data_json_map: Dict[str, Any] = None,
        use_latest_form_schema_version: bool = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.asynchronous_execution = asynchronous_execution
        # This parameter is required.
        self.form_uuid = form_uuid
        self.ignore_empty = ignore_empty
        self.no_execute_expression = no_execute_expression
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.update_form_data_json_map = update_form_data_json_map
        self.use_latest_form_schema_version = use_latest_form_schema_version
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.asynchronous_execution is not None:
            result['asynchronousExecution'] = self.asynchronous_execution
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.ignore_empty is not None:
            result['ignoreEmpty'] = self.ignore_empty
        if self.no_execute_expression is not None:
            result['noExecuteExpression'] = self.no_execute_expression
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.update_form_data_json_map is not None:
            result['updateFormDataJsonMap'] = self.update_form_data_json_map
        if self.use_latest_form_schema_version is not None:
            result['useLatestFormSchemaVersion'] = self.use_latest_form_schema_version
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('asynchronousExecution') is not None:
            self.asynchronous_execution = m.get('asynchronousExecution')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('ignoreEmpty') is not None:
            self.ignore_empty = m.get('ignoreEmpty')
        if m.get('noExecuteExpression') is not None:
            self.no_execute_expression = m.get('noExecuteExpression')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('updateFormDataJsonMap') is not None:
            self.update_form_data_json_map = m.get('updateFormDataJsonMap')
        if m.get('useLatestFormSchemaVersion') is not None:
            self.use_latest_form_schema_version = m.get('useLatestFormSchemaVersion')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchUpdateFormDataByInstanceMapResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class BatchUpdateFormDataByInstanceMapResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchUpdateFormDataByInstanceMapResponseBody = None,
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
            temp_model = BatchUpdateFormDataByInstanceMapResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BuyAuthorizationOrderHeaders(TeaModel):
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


class BuyAuthorizationOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        account_number: str = None,
        begin_time_gmt: int = None,
        caller_union_id: str = None,
        charge_type: str = None,
        commerce_type: str = None,
        commodity_type: str = None,
        end_time_gmt: int = None,
        instance_id: str = None,
        instance_name: str = None,
        produce_code: str = None,
    ):
        self.access_key = access_key
        self.account_number = account_number
        self.begin_time_gmt = begin_time_gmt
        self.caller_union_id = caller_union_id
        self.charge_type = charge_type
        self.commerce_type = commerce_type
        self.commodity_type = commodity_type
        self.end_time_gmt = end_time_gmt
        self.instance_id = instance_id
        self.instance_name = instance_name
        self.produce_code = produce_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.begin_time_gmt is not None:
            result['beginTimeGMT'] = self.begin_time_gmt
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.charge_type is not None:
            result['chargeType'] = self.charge_type
        if self.commerce_type is not None:
            result['commerceType'] = self.commerce_type
        if self.commodity_type is not None:
            result['commodityType'] = self.commodity_type
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_name is not None:
            result['instanceName'] = self.instance_name
        if self.produce_code is not None:
            result['produceCode'] = self.produce_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('beginTimeGMT') is not None:
            self.begin_time_gmt = m.get('beginTimeGMT')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('chargeType') is not None:
            self.charge_type = m.get('chargeType')
        if m.get('commerceType') is not None:
            self.commerce_type = m.get('commerceType')
        if m.get('commodityType') is not None:
            self.commodity_type = m.get('commodityType')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceName') is not None:
            self.instance_name = m.get('instanceName')
        if m.get('produceCode') is not None:
            self.produce_code = m.get('produceCode')
        return self


class BuyAuthorizationOrderResponseBody(TeaModel):
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


class BuyAuthorizationOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BuyAuthorizationOrderResponseBody = None,
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
            temp_model = BuyAuthorizationOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BuyFreshOrderHeaders(TeaModel):
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


class BuyFreshOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        account_number: str = None,
        begin_time_gmt: int = None,
        caller_union_id: str = None,
        charge_type: str = None,
        commerce_type: str = None,
        commodity_type: str = None,
        end_time_gmt: int = None,
        instance_id: str = None,
        instance_name: str = None,
        produce_code: str = None,
    ):
        self.access_key = access_key
        self.account_number = account_number
        self.begin_time_gmt = begin_time_gmt
        self.caller_union_id = caller_union_id
        self.charge_type = charge_type
        self.commerce_type = commerce_type
        self.commodity_type = commodity_type
        self.end_time_gmt = end_time_gmt
        self.instance_id = instance_id
        self.instance_name = instance_name
        self.produce_code = produce_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.begin_time_gmt is not None:
            result['beginTimeGMT'] = self.begin_time_gmt
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.charge_type is not None:
            result['chargeType'] = self.charge_type
        if self.commerce_type is not None:
            result['commerceType'] = self.commerce_type
        if self.commodity_type is not None:
            result['commodityType'] = self.commodity_type
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_name is not None:
            result['instanceName'] = self.instance_name
        if self.produce_code is not None:
            result['produceCode'] = self.produce_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('beginTimeGMT') is not None:
            self.begin_time_gmt = m.get('beginTimeGMT')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('chargeType') is not None:
            self.charge_type = m.get('chargeType')
        if m.get('commerceType') is not None:
            self.commerce_type = m.get('commerceType')
        if m.get('commodityType') is not None:
            self.commodity_type = m.get('commodityType')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceName') is not None:
            self.instance_name = m.get('instanceName')
        if m.get('produceCode') is not None:
            self.produce_code = m.get('produceCode')
        return self


class BuyFreshOrderResponseBody(TeaModel):
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


class BuyFreshOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BuyFreshOrderResponseBody = None,
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
            temp_model = BuyFreshOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckCloudAccountStatusHeaders(TeaModel):
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


class CheckCloudAccountStatusRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
    ):
        self.access_key = access_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        return self


class CheckCloudAccountStatusResponseBody(TeaModel):
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


class CheckCloudAccountStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckCloudAccountStatusResponseBody = None,
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
            temp_model = CheckCloudAccountStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateOrUpdateFormDataHeaders(TeaModel):
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


class CreateOrUpdateFormDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_data_json: str = None,
        form_uuid: str = None,
        no_execute_expression: bool = None,
        search_condition: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_data_json = form_data_json
        # This parameter is required.
        self.form_uuid = form_uuid
        self.no_execute_expression = no_execute_expression
        # This parameter is required.
        self.search_condition = search_condition
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.no_execute_expression is not None:
            result['noExecuteExpression'] = self.no_execute_expression
        if self.search_condition is not None:
            result['searchCondition'] = self.search_condition
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('noExecuteExpression') is not None:
            self.no_execute_expression = m.get('noExecuteExpression')
        if m.get('searchCondition') is not None:
            self.search_condition = m.get('searchCondition')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateOrUpdateFormDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class CreateOrUpdateFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateOrUpdateFormDataResponseBody = None,
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
            temp_model = CreateOrUpdateFormDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteFormDataHeaders(TeaModel):
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


class DeleteFormDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_instance_id: str = None,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteInstanceHeaders(TeaModel):
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


class DeleteInstanceRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteSequenceHeaders(TeaModel):
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


class DeleteSequenceRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        sequence: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.language = language
        self.sequence = sequence
        self.system_token = system_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteSequenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeployFunctionCallbackHeaders(TeaModel):
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


class DeployFunctionCallbackRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        custom_domain: str = None,
        deploy_stage: str = None,
        gate_way_app_key: str = None,
        gate_way_app_secret: str = None,
        gate_way_domain: str = None,
    ):
        self.app_id = app_id
        self.custom_domain = custom_domain
        self.deploy_stage = deploy_stage
        self.gate_way_app_key = gate_way_app_key
        self.gate_way_app_secret = gate_way_app_secret
        self.gate_way_domain = gate_way_domain

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.custom_domain is not None:
            result['customDomain'] = self.custom_domain
        if self.deploy_stage is not None:
            result['deployStage'] = self.deploy_stage
        if self.gate_way_app_key is not None:
            result['gateWayAppKey'] = self.gate_way_app_key
        if self.gate_way_app_secret is not None:
            result['gateWayAppSecret'] = self.gate_way_app_secret
        if self.gate_way_domain is not None:
            result['gateWayDomain'] = self.gate_way_domain
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('customDomain') is not None:
            self.custom_domain = m.get('customDomain')
        if m.get('deployStage') is not None:
            self.deploy_stage = m.get('deployStage')
        if m.get('gateWayAppKey') is not None:
            self.gate_way_app_key = m.get('gateWayAppKey')
        if m.get('gateWayAppSecret') is not None:
            self.gate_way_app_secret = m.get('gateWayAppSecret')
        if m.get('gateWayDomain') is not None:
            self.gate_way_domain = m.get('gateWayDomain')
        return self


class DeployFunctionCallbackResponseBody(TeaModel):
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


class DeployFunctionCallbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeployFunctionCallbackResponseBody = None,
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
            temp_model = DeployFunctionCallbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteBatchTaskHeaders(TeaModel):
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


class ExecuteBatchTaskRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        out_result: str = None,
        remark: str = None,
        system_token: str = None,
        task_information_list: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.out_result = out_result
        self.remark = remark
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.task_information_list = task_information_list
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.remark is not None:
            result['remark'] = self.remark
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.task_information_list is not None:
            result['taskInformationList'] = self.task_information_list
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('taskInformationList') is not None:
            self.task_information_list = m.get('taskInformationList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExecuteBatchTaskResponseBody(TeaModel):
    def __init__(
        self,
        fail_number: int = None,
        success_number: int = None,
        total: int = None,
    ):
        # This parameter is required.
        self.fail_number = fail_number
        # This parameter is required.
        self.success_number = success_number
        # This parameter is required.
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_number is not None:
            result['failNumber'] = self.fail_number
        if self.success_number is not None:
            result['successNumber'] = self.success_number
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failNumber') is not None:
            self.fail_number = m.get('failNumber')
        if m.get('successNumber') is not None:
            self.success_number = m.get('successNumber')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class ExecuteBatchTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteBatchTaskResponseBody = None,
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
            temp_model = ExecuteBatchTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteCustomApiHeaders(TeaModel):
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


class ExecuteCustomApiRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        data: str = None,
        language: str = None,
        service_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.data = data
        self.language = language
        # This parameter is required.
        self.service_id = service_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.data is not None:
            result['data'] = self.data
        if self.language is not None:
            result['language'] = self.language
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExecuteCustomApiResponseBody(TeaModel):
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


class ExecuteCustomApiResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteCustomApiResponseBody = None,
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
            temp_model = ExecuteCustomApiResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecutePlatformTaskHeaders(TeaModel):
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


class ExecutePlatformTaskRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_data_json: str = None,
        language: str = None,
        no_execute_expressions: str = None,
        out_result: str = None,
        process_instance_id: str = None,
        remark: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.form_data_json = form_data_json
        self.language = language
        self.no_execute_expressions = no_execute_expressions
        # This parameter is required.
        self.out_result = out_result
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.language is not None:
            result['language'] = self.language
        if self.no_execute_expressions is not None:
            result['noExecuteExpressions'] = self.no_execute_expressions
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('noExecuteExpressions') is not None:
            self.no_execute_expressions = m.get('noExecuteExpressions')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExecutePlatformTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class ExecuteTaskHeaders(TeaModel):
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


class ExecuteTaskRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        digital_sign_url: str = None,
        form_data_json: str = None,
        language: str = None,
        no_execute_expressions: str = None,
        out_result: str = None,
        process_instance_id: str = None,
        remark: str = None,
        system_token: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.digital_sign_url = digital_sign_url
        self.form_data_json = form_data_json
        self.language = language
        self.no_execute_expressions = no_execute_expressions
        # This parameter is required.
        self.out_result = out_result
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.task_id = task_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.digital_sign_url is not None:
            result['digitalSignUrl'] = self.digital_sign_url
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.language is not None:
            result['language'] = self.language
        if self.no_execute_expressions is not None:
            result['noExecuteExpressions'] = self.no_execute_expressions
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('digitalSignUrl') is not None:
            self.digital_sign_url = m.get('digitalSignUrl')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('noExecuteExpressions') is not None:
            self.no_execute_expressions = m.get('noExecuteExpressions')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExecuteTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class ExpireCommodityHeaders(TeaModel):
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


class ExpireCommodityRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class ExpireCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        self.message = message
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ExpireCommodityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExpireCommodityResponseBody = None,
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
            temp_model = ExpireCommodityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetActivationCodeByCallerUnionIdHeaders(TeaModel):
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


class GetActivationCodeByCallerUnionIdRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
    ):
        self.access_key = access_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        return self


class GetActivationCodeByCallerUnionIdResponseBody(TeaModel):
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


class GetActivationCodeByCallerUnionIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetActivationCodeByCallerUnionIdResponseBody = None,
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
            temp_model = GetActivationCodeByCallerUnionIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetActivityButtonListHeaders(TeaModel):
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


class GetActivityButtonListRequest(TeaModel):
    def __init__(
        self,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetActivityButtonListResponseBodyResult(TeaModel):
    def __init__(
        self,
        alias_in_chinese: str = None,
        alias_in_english: str = None,
    ):
        self.alias_in_chinese = alias_in_chinese
        self.alias_in_english = alias_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alias_in_chinese is not None:
            result['aliasInChinese'] = self.alias_in_chinese
        if self.alias_in_english is not None:
            result['aliasInEnglish'] = self.alias_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aliasInChinese') is not None:
            self.alias_in_chinese = m.get('aliasInChinese')
        if m.get('aliasInEnglish') is not None:
            self.alias_in_english = m.get('aliasInEnglish')
        return self


class GetActivityButtonListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetActivityButtonListResponseBodyResult] = None,
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
                temp_model = GetActivityButtonListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetActivityButtonListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetActivityButtonListResponseBody = None,
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
            temp_model = GetActivityButtonListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetActivityListHeaders(TeaModel):
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


class GetActivityListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_code: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.language = language
        self.process_code = process_code
        self.system_token = system_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetActivityListResponseBodyResult(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_name: str = None,
        activity_name_in_english: str = None,
    ):
        self.activity_id = activity_id
        self.activity_name = activity_name
        self.activity_name_in_english = activity_name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_name_in_english is not None:
            result['activityNameInEnglish'] = self.activity_name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityNameInEnglish') is not None:
            self.activity_name_in_english = m.get('activityNameInEnglish')
        return self


class GetActivityListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetActivityListResponseBodyResult] = None,
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
                temp_model = GetActivityListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetActivityListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetActivityListResponseBody = None,
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
            temp_model = GetActivityListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllAuthCubesHeaders(TeaModel):
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


class GetAllAuthCubesRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        keywords: str = None,
        page_number: int = None,
        page_size: int = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.corp_id = corp_id
        self.keywords = keywords
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.keywords is not None:
            result['keywords'] = self.keywords
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('keywords') is not None:
            self.keywords = m.get('keywords')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetAllAuthCubesResponseBodyResultCubeDataRanges(TeaModel):
    def __init__(
        self,
        classified_code: str = None,
        condition_key: str = None,
        condition_value: List[Any] = None,
        element_code: str = None,
        element_type: str = None,
        operator: str = None,
    ):
        self.classified_code = classified_code
        self.condition_key = condition_key
        self.condition_value = condition_value
        self.element_code = element_code
        self.element_type = element_type
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classified_code is not None:
            result['classifiedCode'] = self.classified_code
        if self.condition_key is not None:
            result['conditionKey'] = self.condition_key
        if self.condition_value is not None:
            result['conditionValue'] = self.condition_value
        if self.element_code is not None:
            result['elementCode'] = self.element_code
        if self.element_type is not None:
            result['elementType'] = self.element_type
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classifiedCode') is not None:
            self.classified_code = m.get('classifiedCode')
        if m.get('conditionKey') is not None:
            self.condition_key = m.get('conditionKey')
        if m.get('conditionValue') is not None:
            self.condition_value = m.get('conditionValue')
        if m.get('elementCode') is not None:
            self.element_code = m.get('elementCode')
        if m.get('elementType') is not None:
            self.element_type = m.get('elementType')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class GetAllAuthCubesResponseBodyResultUserInformation(TeaModel):
    def __init__(
        self,
        auth_provider: str = None,
        corp_id: str = None,
        department_name: str = None,
        name: str = None,
        nick_name: str = None,
        realm_id: int = None,
        referer_namespace_code: str = None,
        show_name: str = None,
        work_no: str = None,
    ):
        self.auth_provider = auth_provider
        self.corp_id = corp_id
        self.department_name = department_name
        self.name = name
        self.nick_name = nick_name
        self.realm_id = realm_id
        self.referer_namespace_code = referer_namespace_code
        self.show_name = show_name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_provider is not None:
            result['authProvider'] = self.auth_provider
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.realm_id is not None:
            result['realmId'] = self.realm_id
        if self.referer_namespace_code is not None:
            result['refererNamespaceCode'] = self.referer_namespace_code
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authProvider') is not None:
            self.auth_provider = m.get('authProvider')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('realmId') is not None:
            self.realm_id = m.get('realmId')
        if m.get('refererNamespaceCode') is not None:
            self.referer_namespace_code = m.get('refererNamespaceCode')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetAllAuthCubesResponseBodyResult(TeaModel):
    def __init__(
        self,
        apapplied_count: int = None,
        app_code: str = None,
        app_instance_code: str = None,
        app_store_code: str = None,
        auth_mode: str = None,
        authorization_type: int = None,
        business_process_code: str = None,
        categories_first: str = None,
        categories_second: str = None,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        cube_auth_type: str = None,
        cube_code: str = None,
        cube_data_range: str = None,
        cube_data_ranges: List[GetAllAuthCubesResponseBodyResultCubeDataRanges] = None,
        cube_source: str = None,
        data_cache_time_configuration: str = None,
        dataflow_code: str = None,
        description: str = None,
        domain_code: str = None,
        enable_cache: bool = None,
        id: int = None,
        is_need_application: str = None,
        is_trend: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        name: str = None,
        namespace_code: str = None,
        owner: str = None,
        shared_data_set: bool = None,
        tenant_corp_id: str = None,
        type: str = None,
        user_information: GetAllAuthCubesResponseBodyResultUserInformation = None,
    ):
        self.apapplied_count = apapplied_count
        self.app_code = app_code
        self.app_instance_code = app_instance_code
        self.app_store_code = app_store_code
        self.auth_mode = auth_mode
        self.authorization_type = authorization_type
        self.business_process_code = business_process_code
        self.categories_first = categories_first
        self.categories_second = categories_second
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.cube_auth_type = cube_auth_type
        self.cube_code = cube_code
        self.cube_data_range = cube_data_range
        self.cube_data_ranges = cube_data_ranges
        self.cube_source = cube_source
        self.data_cache_time_configuration = data_cache_time_configuration
        self.dataflow_code = dataflow_code
        self.description = description
        self.domain_code = domain_code
        self.enable_cache = enable_cache
        self.id = id
        self.is_need_application = is_need_application
        self.is_trend = is_trend
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.name = name
        self.namespace_code = namespace_code
        self.owner = owner
        self.shared_data_set = shared_data_set
        self.tenant_corp_id = tenant_corp_id
        self.type = type
        self.user_information = user_information

    def validate(self):
        if self.cube_data_ranges:
            for k in self.cube_data_ranges:
                if k:
                    k.validate()
        if self.user_information:
            self.user_information.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apapplied_count is not None:
            result['apappliedCount'] = self.apapplied_count
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.app_instance_code is not None:
            result['appInstanceCode'] = self.app_instance_code
        if self.app_store_code is not None:
            result['appStoreCode'] = self.app_store_code
        if self.auth_mode is not None:
            result['authMode'] = self.auth_mode
        if self.authorization_type is not None:
            result['authorizationType'] = self.authorization_type
        if self.business_process_code is not None:
            result['businessProcessCode'] = self.business_process_code
        if self.categories_first is not None:
            result['categoriesFirst'] = self.categories_first
        if self.categories_second is not None:
            result['categoriesSecond'] = self.categories_second
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.cube_auth_type is not None:
            result['cubeAuthType'] = self.cube_auth_type
        if self.cube_code is not None:
            result['cubeCode'] = self.cube_code
        if self.cube_data_range is not None:
            result['cubeDataRange'] = self.cube_data_range
        result['cubeDataRanges'] = []
        if self.cube_data_ranges is not None:
            for k in self.cube_data_ranges:
                result['cubeDataRanges'].append(k.to_map() if k else None)
        if self.cube_source is not None:
            result['cubeSource'] = self.cube_source
        if self.data_cache_time_configuration is not None:
            result['dataCacheTimeConfiguration'] = self.data_cache_time_configuration
        if self.dataflow_code is not None:
            result['dataflowCode'] = self.dataflow_code
        if self.description is not None:
            result['description'] = self.description
        if self.domain_code is not None:
            result['domainCode'] = self.domain_code
        if self.enable_cache is not None:
            result['enableCache'] = self.enable_cache
        if self.id is not None:
            result['id'] = self.id
        if self.is_need_application is not None:
            result['isNeedApplication'] = self.is_need_application
        if self.is_trend is not None:
            result['isTrend'] = self.is_trend
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.name is not None:
            result['name'] = self.name
        if self.namespace_code is not None:
            result['namespaceCode'] = self.namespace_code
        if self.owner is not None:
            result['owner'] = self.owner
        if self.shared_data_set is not None:
            result['sharedDataSet'] = self.shared_data_set
        if self.tenant_corp_id is not None:
            result['tenantCorpId'] = self.tenant_corp_id
        if self.type is not None:
            result['type'] = self.type
        if self.user_information is not None:
            result['userInformation'] = self.user_information.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apappliedCount') is not None:
            self.apapplied_count = m.get('apappliedCount')
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('appInstanceCode') is not None:
            self.app_instance_code = m.get('appInstanceCode')
        if m.get('appStoreCode') is not None:
            self.app_store_code = m.get('appStoreCode')
        if m.get('authMode') is not None:
            self.auth_mode = m.get('authMode')
        if m.get('authorizationType') is not None:
            self.authorization_type = m.get('authorizationType')
        if m.get('businessProcessCode') is not None:
            self.business_process_code = m.get('businessProcessCode')
        if m.get('categoriesFirst') is not None:
            self.categories_first = m.get('categoriesFirst')
        if m.get('categoriesSecond') is not None:
            self.categories_second = m.get('categoriesSecond')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('cubeAuthType') is not None:
            self.cube_auth_type = m.get('cubeAuthType')
        if m.get('cubeCode') is not None:
            self.cube_code = m.get('cubeCode')
        if m.get('cubeDataRange') is not None:
            self.cube_data_range = m.get('cubeDataRange')
        self.cube_data_ranges = []
        if m.get('cubeDataRanges') is not None:
            for k in m.get('cubeDataRanges'):
                temp_model = GetAllAuthCubesResponseBodyResultCubeDataRanges()
                self.cube_data_ranges.append(temp_model.from_map(k))
        if m.get('cubeSource') is not None:
            self.cube_source = m.get('cubeSource')
        if m.get('dataCacheTimeConfiguration') is not None:
            self.data_cache_time_configuration = m.get('dataCacheTimeConfiguration')
        if m.get('dataflowCode') is not None:
            self.dataflow_code = m.get('dataflowCode')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('domainCode') is not None:
            self.domain_code = m.get('domainCode')
        if m.get('enableCache') is not None:
            self.enable_cache = m.get('enableCache')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isNeedApplication') is not None:
            self.is_need_application = m.get('isNeedApplication')
        if m.get('isTrend') is not None:
            self.is_trend = m.get('isTrend')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('namespaceCode') is not None:
            self.namespace_code = m.get('namespaceCode')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        if m.get('sharedDataSet') is not None:
            self.shared_data_set = m.get('sharedDataSet')
        if m.get('tenantCorpId') is not None:
            self.tenant_corp_id = m.get('tenantCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userInformation') is not None:
            temp_model = GetAllAuthCubesResponseBodyResultUserInformation()
            self.user_information = temp_model.from_map(m['userInformation'])
        return self


class GetAllAuthCubesResponseBody(TeaModel):
    def __init__(
        self,
        count: int = None,
        result: List[GetAllAuthCubesResponseBodyResult] = None,
    ):
        # This parameter is required.
        self.count = count
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
        if self.count is not None:
            result['count'] = self.count
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetAllAuthCubesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetAllAuthCubesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllAuthCubesResponseBody = None,
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
            temp_model = GetAllAuthCubesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetApplicationAuthorizationServicePlatformResourceHeaders(TeaModel):
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


class GetApplicationAuthorizationServicePlatformResourceRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class GetApplicationAuthorizationServicePlatformResourceResponseBody(TeaModel):
    def __init__(
        self,
        account_total_amount: int = None,
        account_usage_amount: int = None,
        app_total_amount: int = None,
        attachment_total_amount: int = None,
        attachment_usage_amount: int = None,
        instance_id: str = None,
        instance_total_amount: int = None,
        instance_usage_amount: int = None,
        plugin_usage_amount: int = None,
    ):
        self.account_total_amount = account_total_amount
        self.account_usage_amount = account_usage_amount
        self.app_total_amount = app_total_amount
        self.attachment_total_amount = attachment_total_amount
        self.attachment_usage_amount = attachment_usage_amount
        self.instance_id = instance_id
        self.instance_total_amount = instance_total_amount
        self.instance_usage_amount = instance_usage_amount
        self.plugin_usage_amount = plugin_usage_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_total_amount is not None:
            result['accountTotalAmount'] = self.account_total_amount
        if self.account_usage_amount is not None:
            result['accountUsageAmount'] = self.account_usage_amount
        if self.app_total_amount is not None:
            result['appTotalAmount'] = self.app_total_amount
        if self.attachment_total_amount is not None:
            result['attachmentTotalAmount'] = self.attachment_total_amount
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_total_amount is not None:
            result['instanceTotalAmount'] = self.instance_total_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        if self.plugin_usage_amount is not None:
            result['pluginUsageAmount'] = self.plugin_usage_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountTotalAmount') is not None:
            self.account_total_amount = m.get('accountTotalAmount')
        if m.get('accountUsageAmount') is not None:
            self.account_usage_amount = m.get('accountUsageAmount')
        if m.get('appTotalAmount') is not None:
            self.app_total_amount = m.get('appTotalAmount')
        if m.get('attachmentTotalAmount') is not None:
            self.attachment_total_amount = m.get('attachmentTotalAmount')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceTotalAmount') is not None:
            self.instance_total_amount = m.get('instanceTotalAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        if m.get('pluginUsageAmount') is not None:
            self.plugin_usage_amount = m.get('pluginUsageAmount')
        return self


class GetApplicationAuthorizationServicePlatformResourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetApplicationAuthorizationServicePlatformResourceResponseBody = None,
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
            temp_model = GetApplicationAuthorizationServicePlatformResourceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAutoFlowLogDetailHeaders(TeaModel):
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


class GetAutoFlowLogDetailRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        env: str = None,
        page_number: int = None,
        page_size: int = None,
        proc_instance_id: str = None,
        token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.env = env
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.proc_instance_id = proc_instance_id
        # This parameter is required.
        self.token = token
        # This parameter is required.
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
        if self.env is not None:
            result['env'] = self.env
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.proc_instance_id is not None:
            result['procInstanceId'] = self.proc_instance_id
        if self.token is not None:
            result['token'] = self.token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('procInstanceId') is not None:
            self.proc_instance_id = m.get('procInstanceId')
        if m.get('token') is not None:
            self.token = m.get('token')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetAutoFlowLogDetailResponseBodyData(TeaModel):
    def __init__(
        self,
        activity_key: str = None,
        elapsed_time_gmt: int = None,
        finish_time_gmt: str = None,
        flag: str = None,
        input_params: Dict[str, Any] = None,
        name: str = None,
        others: str = None,
        output_params: Dict[str, Any] = None,
        status: str = None,
        uuid: str = None,
    ):
        self.activity_key = activity_key
        self.elapsed_time_gmt = elapsed_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.flag = flag
        self.input_params = input_params
        self.name = name
        self.others = others
        self.output_params = output_params
        self.status = status
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_key is not None:
            result['activityKey'] = self.activity_key
        if self.elapsed_time_gmt is not None:
            result['elapsedTimeGMT'] = self.elapsed_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.flag is not None:
            result['flag'] = self.flag
        if self.input_params is not None:
            result['inputParams'] = self.input_params
        if self.name is not None:
            result['name'] = self.name
        if self.others is not None:
            result['others'] = self.others
        if self.output_params is not None:
            result['outputParams'] = self.output_params
        if self.status is not None:
            result['status'] = self.status
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityKey') is not None:
            self.activity_key = m.get('activityKey')
        if m.get('elapsedTimeGMT') is not None:
            self.elapsed_time_gmt = m.get('elapsedTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('flag') is not None:
            self.flag = m.get('flag')
        if m.get('inputParams') is not None:
            self.input_params = m.get('inputParams')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('others') is not None:
            self.others = m.get('others')
        if m.get('outputParams') is not None:
            self.output_params = m.get('outputParams')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class GetAutoFlowLogDetailResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetAutoFlowLogDetailResponseBodyData] = None,
        has_more_data: bool = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.has_more_data = has_more_data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.has_more_data is not None:
            result['hasMoreData'] = self.has_more_data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetAutoFlowLogDetailResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMoreData') is not None:
            self.has_more_data = m.get('hasMoreData')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetAutoFlowLogDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAutoFlowLogDetailResponseBody = None,
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
            temp_model = GetAutoFlowLogDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCorpAccomplishmentTasksHeaders(TeaModel):
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


class GetCorpAccomplishmentTasksRequest(TeaModel):
    def __init__(
        self,
        app_types: str = None,
        create_from_time_gmt: int = None,
        create_to_time_gmt: int = None,
        env: str = None,
        keyword: str = None,
        language: str = None,
        page_number: int = None,
        page_size: int = None,
        process_codes: str = None,
        token: str = None,
    ):
        self.app_types = app_types
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.env = env
        self.keyword = keyword
        self.language = language
        self.page_number = page_number
        self.page_size = page_size
        self.process_codes = process_codes
        # This parameter is required.
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_types is not None:
            result['appTypes'] = self.app_types
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.env is not None:
            result['env'] = self.env
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.language is not None:
            result['language'] = self.language
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTypes') is not None:
            self.app_types = m.get('appTypes')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GetCorpAccomplishmentTasksResponseBodyData(TeaModel):
    def __init__(
        self,
        active_time_gmt: str = None,
        actual_actioner_id: str = None,
        app_type: str = None,
        create_time_gmt: str = None,
        finish_time_gmt: str = None,
        originator_email: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_name_in_english: str = None,
        originator_nick_name: str = None,
        originator_nick_name_in_english: str = None,
        originator_photo: str = None,
        out_result: str = None,
        out_result_name: str = None,
        process_instance_id: str = None,
        status: str = None,
        task_id: str = None,
        task_type: str = None,
        title: str = None,
        title_in_english: str = None,
    ):
        self.active_time_gmt = active_time_gmt
        self.actual_actioner_id = actual_actioner_id
        self.app_type = app_type
        self.create_time_gmt = create_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.originator_email = originator_email
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_name_in_english = originator_name_in_english
        self.originator_nick_name = originator_nick_name
        self.originator_nick_name_in_english = originator_nick_name_in_english
        self.originator_photo = originator_photo
        self.out_result = out_result
        self.out_result_name = out_result_name
        self.process_instance_id = process_instance_id
        self.status = status
        self.task_id = task_id
        self.task_type = task_type
        self.title = title
        self.title_in_english = title_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.actual_actioner_id is not None:
            result['actualActionerId'] = self.actual_actioner_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.originator_email is not None:
            result['originatorEmail'] = self.originator_email
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_name_in_english is not None:
            result['originatorNameInEnglish'] = self.originator_name_in_english
        if self.originator_nick_name is not None:
            result['originatorNickName'] = self.originator_nick_name
        if self.originator_nick_name_in_english is not None:
            result['originatorNickNameInEnglish'] = self.originator_nick_name_in_english
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.out_result_name is not None:
            result['outResultName'] = self.out_result_name
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title is not None:
            result['title'] = self.title
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('actualActionerId') is not None:
            self.actual_actioner_id = m.get('actualActionerId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('originatorEmail') is not None:
            self.originator_email = m.get('originatorEmail')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorNameInEnglish') is not None:
            self.originator_name_in_english = m.get('originatorNameInEnglish')
        if m.get('originatorNickName') is not None:
            self.originator_nick_name = m.get('originatorNickName')
        if m.get('originatorNickNameInEnglish') is not None:
            self.originator_nick_name_in_english = m.get('originatorNickNameInEnglish')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('outResultName') is not None:
            self.out_result_name = m.get('outResultName')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        return self


class GetCorpAccomplishmentTasksResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetCorpAccomplishmentTasksResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetCorpAccomplishmentTasksResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCorpAccomplishmentTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCorpAccomplishmentTasksResponseBody = None,
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
            temp_model = GetCorpAccomplishmentTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCorpLevelByAccountIdHeaders(TeaModel):
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


class GetCorpLevelByAccountIdRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
    ):
        self.account_id = account_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        return self


class GetCorpLevelByAccountIdResponseBody(TeaModel):
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


class GetCorpLevelByAccountIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCorpLevelByAccountIdResponseBody = None,
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
            temp_model = GetCorpLevelByAccountIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCorpTasksHeaders(TeaModel):
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


class GetCorpTasksRequest(TeaModel):
    def __init__(
        self,
        app_types: str = None,
        corp_id: str = None,
        create_from_time_gmt: int = None,
        create_to_time_gmt: int = None,
        env: str = None,
        keyword: str = None,
        language: str = None,
        page_number: int = None,
        page_size: int = None,
        process_codes: str = None,
        token: str = None,
        user_id: str = None,
    ):
        self.app_types = app_types
        # This parameter is required.
        self.corp_id = corp_id
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.env = env
        self.keyword = keyword
        self.language = language
        self.page_number = page_number
        self.page_size = page_size
        self.process_codes = process_codes
        # This parameter is required.
        self.token = token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_types is not None:
            result['appTypes'] = self.app_types
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.env is not None:
            result['env'] = self.env
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.language is not None:
            result['language'] = self.language
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        if self.token is not None:
            result['token'] = self.token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTypes') is not None:
            self.app_types = m.get('appTypes')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        if m.get('token') is not None:
            self.token = m.get('token')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetCorpTasksResponseBodyData(TeaModel):
    def __init__(
        self,
        active_time_gmt: str = None,
        actual_actioner_id: str = None,
        app_type: str = None,
        create_time_gmt: str = None,
        finish_time_gmt: str = None,
        originator_email: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_name_in_english: str = None,
        originator_nick_name: str = None,
        originator_nick_name_en: str = None,
        originator_photo: str = None,
        out_result: str = None,
        out_result_name: str = None,
        process_instance_id: str = None,
        status: str = None,
        task_id: str = None,
        task_type: str = None,
        title: str = None,
        title_in_english: str = None,
    ):
        self.active_time_gmt = active_time_gmt
        self.actual_actioner_id = actual_actioner_id
        self.app_type = app_type
        self.create_time_gmt = create_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.originator_email = originator_email
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_name_in_english = originator_name_in_english
        self.originator_nick_name = originator_nick_name
        self.originator_nick_name_en = originator_nick_name_en
        self.originator_photo = originator_photo
        self.out_result = out_result
        self.out_result_name = out_result_name
        self.process_instance_id = process_instance_id
        self.status = status
        self.task_id = task_id
        self.task_type = task_type
        self.title = title
        self.title_in_english = title_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.actual_actioner_id is not None:
            result['actualActionerId'] = self.actual_actioner_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.originator_email is not None:
            result['originatorEmail'] = self.originator_email
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_name_in_english is not None:
            result['originatorNameInEnglish'] = self.originator_name_in_english
        if self.originator_nick_name is not None:
            result['originatorNickName'] = self.originator_nick_name
        if self.originator_nick_name_en is not None:
            result['originatorNickNameEn'] = self.originator_nick_name_en
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.out_result_name is not None:
            result['outResultName'] = self.out_result_name
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title is not None:
            result['title'] = self.title
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('actualActionerId') is not None:
            self.actual_actioner_id = m.get('actualActionerId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('originatorEmail') is not None:
            self.originator_email = m.get('originatorEmail')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorNameInEnglish') is not None:
            self.originator_name_in_english = m.get('originatorNameInEnglish')
        if m.get('originatorNickName') is not None:
            self.originator_nick_name = m.get('originatorNickName')
        if m.get('originatorNickNameEn') is not None:
            self.originator_nick_name_en = m.get('originatorNickNameEn')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('outResultName') is not None:
            self.out_result_name = m.get('outResultName')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        return self


class GetCorpTasksResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetCorpTasksResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetCorpTasksResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCorpTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCorpTasksResponseBody = None,
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
            temp_model = GetCorpTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDbConfigHeaders(TeaModel):
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


class GetDbConfigRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetDbConfigResponseBody(TeaModel):
    def __init__(
        self,
        config: str = None,
        corp_id: str = None,
        create_time_gmt: str = None,
        creator: str = None,
        exclusive: str = None,
        id: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        type: str = None,
    ):
        self.config = config
        self.corp_id = corp_id
        self.create_time_gmt = create_time_gmt
        self.creator = creator
        self.exclusive = exclusive
        self.id = id
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config is not None:
            result['config'] = self.config
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator is not None:
            result['creator'] = self.creator
        if self.exclusive is not None:
            result['exclusive'] = self.exclusive
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('exclusive') is not None:
            self.exclusive = m.get('exclusive')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetDbConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDbConfigResponseBody = None,
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
            temp_model = GetDbConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFieldDefByUuidHeaders(TeaModel):
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


class GetFieldDefByUuidRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_uuid: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFieldDefByUuidResponseBodyResult(TeaModel):
    def __init__(
        self,
        behavior: str = None,
        children: str = None,
        component_name: str = None,
        field_id: str = None,
        label: Any = None,
        props: Any = None,
    ):
        self.behavior = behavior
        self.children = children
        self.component_name = component_name
        self.field_id = field_id
        self.label = label
        self.props = props

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.behavior is not None:
            result['behavior'] = self.behavior
        if self.children is not None:
            result['children'] = self.children
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.props is not None:
            result['props'] = self.props
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('behavior') is not None:
            self.behavior = m.get('behavior')
        if m.get('children') is not None:
            self.children = m.get('children')
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('props') is not None:
            self.props = m.get('props')
        return self


class GetFieldDefByUuidResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetFieldDefByUuidResponseBodyResult] = None,
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
                temp_model = GetFieldDefByUuidResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetFieldDefByUuidResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFieldDefByUuidResponseBody = None,
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
            temp_model = GetFieldDefByUuidResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFormComponentDefinitionListHeaders(TeaModel):
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


class GetFormComponentDefinitionListRequest(TeaModel):
    def __init__(
        self,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
        version: int = None,
    ):
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetFormComponentDefinitionListResponseBodyResult(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        field_id: str = None,
        label: str = None,
        parent_id: str = None,
    ):
        self.component_name = component_name
        self.field_id = field_id
        self.label = label
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class GetFormComponentDefinitionListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetFormComponentDefinitionListResponseBodyResult] = None,
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
                temp_model = GetFormComponentDefinitionListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetFormComponentDefinitionListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormComponentDefinitionListResponseBody = None,
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
            temp_model = GetFormComponentDefinitionListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFormDataByIDHeaders(TeaModel):
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


class GetFormDataByIDRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.language = language
        self.system_token = system_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFormDataByIDResponseBodyOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetFormDataByIDResponseBodyOriginator(TeaModel):
    def __init__(
        self,
        department_name: str = None,
        email: str = None,
        name: GetFormDataByIDResponseBodyOriginatorName = None,
        user_id: str = None,
    ):
        self.department_name = department_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetFormDataByIDResponseBodyOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFormDataByIDResponseBody(TeaModel):
    def __init__(
        self,
        form_data: Dict[str, Any] = None,
        form_inst_id: str = None,
        modified_time_gmt: str = None,
        originator: GetFormDataByIDResponseBodyOriginator = None,
    ):
        self.form_data = form_data
        self.form_inst_id = form_inst_id
        self.modified_time_gmt = modified_time_gmt
        self.originator = originator

    def validate(self):
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_inst_id is not None:
            result['formInstId'] = self.form_inst_id
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstId') is not None:
            self.form_inst_id = m.get('formInstId')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('originator') is not None:
            temp_model = GetFormDataByIDResponseBodyOriginator()
            self.originator = temp_model.from_map(m['originator'])
        return self


class GetFormDataByIDResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormDataByIDResponseBody = None,
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
            temp_model = GetFormDataByIDResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFormListInAppHeaders(TeaModel):
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


class GetFormListInAppRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_types: str = None,
        page_number: int = None,
        page_size: int = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.form_types = form_types
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_types is not None:
            result['formTypes'] = self.form_types
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formTypes') is not None:
            self.form_types = m.get('formTypes')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFormListInAppResponseBodyResultDataTitle(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['enUS'] = self.en_us
        if self.zh_cn is not None:
            result['zhCN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enUS') is not None:
            self.en_us = m.get('enUS')
        if m.get('zhCN') is not None:
            self.zh_cn = m.get('zhCN')
        return self


class GetFormListInAppResponseBodyResultData(TeaModel):
    def __init__(
        self,
        creator: str = None,
        form_type: str = None,
        form_uuid: str = None,
        gmt_create: str = None,
        title: GetFormListInAppResponseBodyResultDataTitle = None,
    ):
        self.creator = creator
        self.form_type = form_type
        self.form_uuid = form_uuid
        self.gmt_create = gmt_create
        self.title = title

    def validate(self):
        if self.title:
            self.title.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_type is not None:
            result['formType'] = self.form_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.title is not None:
            result['title'] = self.title.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formType') is not None:
            self.form_type = m.get('formType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('title') is not None:
            temp_model = GetFormListInAppResponseBodyResultDataTitle()
            self.title = temp_model.from_map(m['title'])
        return self


class GetFormListInAppResponseBodyResult(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        data: List[GetFormListInAppResponseBodyResultData] = None,
        total_count: int = None,
    ):
        self.current_page = current_page
        self.data = data
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetFormListInAppResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetFormListInAppResponseBody(TeaModel):
    def __init__(
        self,
        result: GetFormListInAppResponseBodyResult = None,
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
            temp_model = GetFormListInAppResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetFormListInAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormListInAppResponseBody = None,
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
            temp_model = GetFormListInAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInstanceByIdHeaders(TeaModel):
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


class GetInstanceByIdRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstanceByIdResponseBodyActionExecutorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstanceByIdResponseBodyActionExecutor(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: GetInstanceByIdResponseBodyActionExecutorName = None,
        user_id: str = None,
    ):
        self.dept_name = dept_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstanceByIdResponseBodyActionExecutorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstanceByIdResponseBodyOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstanceByIdResponseBodyOriginator(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: GetInstanceByIdResponseBodyOriginatorName = None,
        user_id: str = None,
    ):
        self.dept_name = dept_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstanceByIdResponseBodyOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstanceByIdResponseBody(TeaModel):
    def __init__(
        self,
        action_executor: List[GetInstanceByIdResponseBodyActionExecutor] = None,
        approved_result: str = None,
        create_time_gmt: str = None,
        data: Dict[str, Any] = None,
        form_uuid: str = None,
        instance_status: str = None,
        modified_time_gmt: str = None,
        originator: GetInstanceByIdResponseBodyOriginator = None,
        process_code: str = None,
        process_instance_id: str = None,
        title: str = None,
        version: int = None,
    ):
        self.action_executor = action_executor
        self.approved_result = approved_result
        self.create_time_gmt = create_time_gmt
        self.data = data
        self.form_uuid = form_uuid
        self.instance_status = instance_status
        self.modified_time_gmt = modified_time_gmt
        self.originator = originator
        self.process_code = process_code
        self.process_instance_id = process_instance_id
        self.title = title
        self.version = version

    def validate(self):
        if self.action_executor:
            for k in self.action_executor:
                if k:
                    k.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionExecutor'] = []
        if self.action_executor is not None:
            for k in self.action_executor:
                result['actionExecutor'].append(k.to_map() if k else None)
        if self.approved_result is not None:
            result['approvedResult'] = self.approved_result
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.data is not None:
            result['data'] = self.data
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_status is not None:
            result['instanceStatus'] = self.instance_status
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_executor = []
        if m.get('actionExecutor') is not None:
            for k in m.get('actionExecutor'):
                temp_model = GetInstanceByIdResponseBodyActionExecutor()
                self.action_executor.append(temp_model.from_map(k))
        if m.get('approvedResult') is not None:
            self.approved_result = m.get('approvedResult')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceStatus') is not None:
            self.instance_status = m.get('instanceStatus')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('originator') is not None:
            temp_model = GetInstanceByIdResponseBodyOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetInstanceByIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInstanceByIdResponseBody = None,
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
            temp_model = GetInstanceByIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInstanceIdListHeaders(TeaModel):
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


class GetInstanceIdListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        approved_result: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        instance_status: str = None,
        language: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        originator_id: str = None,
        search_field_json: str = None,
        system_token: str = None,
        task_id: str = None,
        user_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.approved_result = approved_result
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        # This parameter is required.
        self.form_uuid = form_uuid
        self.instance_status = instance_status
        self.language = language
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.originator_id = originator_id
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        self.task_id = task_id
        # This parameter is required.
        self.user_id = user_id
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.approved_result is not None:
            result['approvedResult'] = self.approved_result
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_status is not None:
            result['instanceStatus'] = self.instance_status
        if self.language is not None:
            result['language'] = self.language
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('approvedResult') is not None:
            self.approved_result = m.get('approvedResult')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceStatus') is not None:
            self.instance_status = m.get('instanceStatus')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetInstanceIdListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[str] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetInstanceIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInstanceIdListResponseBody = None,
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
            temp_model = GetInstanceIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInstancesHeaders(TeaModel):
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


class GetInstancesRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        approved_result: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        instance_status: str = None,
        language: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        order_config_json: str = None,
        originator_id: str = None,
        search_field_json: str = None,
        system_token: str = None,
        task_id: str = None,
        user_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.approved_result = approved_result
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        # This parameter is required.
        self.form_uuid = form_uuid
        self.instance_status = instance_status
        self.language = language
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.order_config_json = order_config_json
        self.originator_id = originator_id
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        self.task_id = task_id
        # This parameter is required.
        self.user_id = user_id
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.approved_result is not None:
            result['approvedResult'] = self.approved_result
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_status is not None:
            result['instanceStatus'] = self.instance_status
        if self.language is not None:
            result['language'] = self.language
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.order_config_json is not None:
            result['orderConfigJson'] = self.order_config_json
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('approvedResult') is not None:
            self.approved_result = m.get('approvedResult')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceStatus') is not None:
            self.instance_status = m.get('instanceStatus')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('orderConfigJson') is not None:
            self.order_config_json = m.get('orderConfigJson')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetInstancesResponseBodyDataActionExecutorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstancesResponseBodyDataActionExecutor(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: GetInstancesResponseBodyDataActionExecutorName = None,
        user_id: str = None,
    ):
        self.dept_name = dept_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstancesResponseBodyDataActionExecutorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstancesResponseBodyDataOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstancesResponseBodyDataOriginator(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: GetInstancesResponseBodyDataOriginatorName = None,
        user_id: str = None,
    ):
        self.dept_name = dept_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstancesResponseBodyDataOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstancesResponseBodyData(TeaModel):
    def __init__(
        self,
        action_executor: List[GetInstancesResponseBodyDataActionExecutor] = None,
        approved_result: str = None,
        create_time_gmt: str = None,
        data: Dict[str, Any] = None,
        form_uuid: str = None,
        instance_status: str = None,
        modified_time_gmt: str = None,
        originator: GetInstancesResponseBodyDataOriginator = None,
        process_code: str = None,
        process_instance_id: str = None,
        title: str = None,
        version: int = None,
    ):
        self.action_executor = action_executor
        self.approved_result = approved_result
        self.create_time_gmt = create_time_gmt
        self.data = data
        self.form_uuid = form_uuid
        self.instance_status = instance_status
        self.modified_time_gmt = modified_time_gmt
        self.originator = originator
        self.process_code = process_code
        self.process_instance_id = process_instance_id
        self.title = title
        self.version = version

    def validate(self):
        if self.action_executor:
            for k in self.action_executor:
                if k:
                    k.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionExecutor'] = []
        if self.action_executor is not None:
            for k in self.action_executor:
                result['actionExecutor'].append(k.to_map() if k else None)
        if self.approved_result is not None:
            result['approvedResult'] = self.approved_result
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.data is not None:
            result['data'] = self.data
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_status is not None:
            result['instanceStatus'] = self.instance_status
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_executor = []
        if m.get('actionExecutor') is not None:
            for k in m.get('actionExecutor'):
                temp_model = GetInstancesResponseBodyDataActionExecutor()
                self.action_executor.append(temp_model.from_map(k))
        if m.get('approvedResult') is not None:
            self.approved_result = m.get('approvedResult')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceStatus') is not None:
            self.instance_status = m.get('instanceStatus')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('originator') is not None:
            temp_model = GetInstancesResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetInstancesResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetInstancesResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetInstancesResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInstancesResponseBody = None,
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
            temp_model = GetInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInstancesByIdListHeaders(TeaModel):
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


class GetInstancesByIdListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_ids: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.process_instance_ids = process_instance_ids
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_ids is not None:
            result['processInstanceIds'] = self.process_instance_ids
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceIds') is not None:
            self.process_instance_ids = m.get('processInstanceIds')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstancesByIdListResponseBodyResultActionExecutorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstancesByIdListResponseBodyResultActionExecutor(TeaModel):
    def __init__(
        self,
        department_name: str = None,
        email: str = None,
        name: GetInstancesByIdListResponseBodyResultActionExecutorName = None,
        user_id: str = None,
    ):
        self.department_name = department_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstancesByIdListResponseBodyResultActionExecutorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstancesByIdListResponseBodyResultOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetInstancesByIdListResponseBodyResultOriginator(TeaModel):
    def __init__(
        self,
        department_name: str = None,
        email: str = None,
        name: GetInstancesByIdListResponseBodyResultOriginatorName = None,
        user_id: str = None,
    ):
        self.department_name = department_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = GetInstancesByIdListResponseBodyResultOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInstancesByIdListResponseBodyResult(TeaModel):
    def __init__(
        self,
        action_executor: List[GetInstancesByIdListResponseBodyResultActionExecutor] = None,
        approved_result: str = None,
        data: Dict[str, Any] = None,
        form_uuid: str = None,
        instance_status: str = None,
        originator: GetInstancesByIdListResponseBodyResultOriginator = None,
        process_code: str = None,
        process_instance_id: str = None,
        title: str = None,
    ):
        self.action_executor = action_executor
        self.approved_result = approved_result
        self.data = data
        self.form_uuid = form_uuid
        self.instance_status = instance_status
        self.originator = originator
        self.process_code = process_code
        self.process_instance_id = process_instance_id
        self.title = title

    def validate(self):
        if self.action_executor:
            for k in self.action_executor:
                if k:
                    k.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionExecutor'] = []
        if self.action_executor is not None:
            for k in self.action_executor:
                result['actionExecutor'].append(k.to_map() if k else None)
        if self.approved_result is not None:
            result['approvedResult'] = self.approved_result
        if self.data is not None:
            result['data'] = self.data
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_status is not None:
            result['instanceStatus'] = self.instance_status
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_executor = []
        if m.get('actionExecutor') is not None:
            for k in m.get('actionExecutor'):
                temp_model = GetInstancesByIdListResponseBodyResultActionExecutor()
                self.action_executor.append(temp_model.from_map(k))
        if m.get('approvedResult') is not None:
            self.approved_result = m.get('approvedResult')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceStatus') is not None:
            self.instance_status = m.get('instanceStatus')
        if m.get('originator') is not None:
            temp_model = GetInstancesByIdListResponseBodyResultOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetInstancesByIdListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetInstancesByIdListResponseBodyResult] = None,
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
                temp_model = GetInstancesByIdListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetInstancesByIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInstancesByIdListResponseBody = None,
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
            temp_model = GetInstancesByIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMeCorpSubmissionHeaders(TeaModel):
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


class GetMeCorpSubmissionRequest(TeaModel):
    def __init__(
        self,
        app_types: str = None,
        corp_id: str = None,
        create_from_time_gmt: int = None,
        create_to_time_gmt: int = None,
        env: str = None,
        keyword: str = None,
        language: str = None,
        page_number: int = None,
        page_size: int = None,
        process_codes: str = None,
        token: str = None,
    ):
        self.app_types = app_types
        # This parameter is required.
        self.corp_id = corp_id
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.env = env
        self.keyword = keyword
        self.language = language
        self.page_number = page_number
        self.page_size = page_size
        self.process_codes = process_codes
        # This parameter is required.
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_types is not None:
            result['appTypes'] = self.app_types
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.env is not None:
            result['env'] = self.env
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.language is not None:
            result['language'] = self.language
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTypes') is not None:
            self.app_types = m.get('appTypes')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GetMeCorpSubmissionResponseBodyDataActioner(TeaModel):
    def __init__(
        self,
        bu_name: str = None,
        email: str = None,
        employee_type: str = None,
        employee_type_information: str = None,
        human_resource_group_work_number: str = None,
        is_system_admin: bool = None,
        level: str = None,
        name: str = None,
        nick_name: str = None,
        order_number: str = None,
        personal_photo: str = None,
        personal_photo_url: str = None,
        pinyin_name_all: str = None,
        pinyin_nick_name: str = None,
        state: str = None,
        super_user_id: str = None,
        tb_wang: str = None,
        user_id: str = None,
    ):
        self.bu_name = bu_name
        self.email = email
        self.employee_type = employee_type
        self.employee_type_information = employee_type_information
        self.human_resource_group_work_number = human_resource_group_work_number
        self.is_system_admin = is_system_admin
        self.level = level
        self.name = name
        self.nick_name = nick_name
        self.order_number = order_number
        self.personal_photo = personal_photo
        self.personal_photo_url = personal_photo_url
        self.pinyin_name_all = pinyin_name_all
        self.pinyin_nick_name = pinyin_nick_name
        self.state = state
        self.super_user_id = super_user_id
        self.tb_wang = tb_wang
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bu_name is not None:
            result['buName'] = self.bu_name
        if self.email is not None:
            result['email'] = self.email
        if self.employee_type is not None:
            result['employeeType'] = self.employee_type
        if self.employee_type_information is not None:
            result['employeeTypeInformation'] = self.employee_type_information
        if self.human_resource_group_work_number is not None:
            result['humanResourceGroupWorkNumber'] = self.human_resource_group_work_number
        if self.is_system_admin is not None:
            result['isSystemAdmin'] = self.is_system_admin
        if self.level is not None:
            result['level'] = self.level
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.personal_photo is not None:
            result['personalPhoto'] = self.personal_photo
        if self.personal_photo_url is not None:
            result['personalPhotoUrl'] = self.personal_photo_url
        if self.pinyin_name_all is not None:
            result['pinyinNameAll'] = self.pinyin_name_all
        if self.pinyin_nick_name is not None:
            result['pinyinNickName'] = self.pinyin_nick_name
        if self.state is not None:
            result['state'] = self.state
        if self.super_user_id is not None:
            result['superUserId'] = self.super_user_id
        if self.tb_wang is not None:
            result['tbWang'] = self.tb_wang
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buName') is not None:
            self.bu_name = m.get('buName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('employeeType') is not None:
            self.employee_type = m.get('employeeType')
        if m.get('employeeTypeInformation') is not None:
            self.employee_type_information = m.get('employeeTypeInformation')
        if m.get('humanResourceGroupWorkNumber') is not None:
            self.human_resource_group_work_number = m.get('humanResourceGroupWorkNumber')
        if m.get('isSystemAdmin') is not None:
            self.is_system_admin = m.get('isSystemAdmin')
        if m.get('level') is not None:
            self.level = m.get('level')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('personalPhoto') is not None:
            self.personal_photo = m.get('personalPhoto')
        if m.get('personalPhotoUrl') is not None:
            self.personal_photo_url = m.get('personalPhotoUrl')
        if m.get('pinyinNameAll') is not None:
            self.pinyin_name_all = m.get('pinyinNameAll')
        if m.get('pinyinNickName') is not None:
            self.pinyin_nick_name = m.get('pinyinNickName')
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('superUserId') is not None:
            self.super_user_id = m.get('superUserId')
        if m.get('tbWang') is not None:
            self.tb_wang = m.get('tbWang')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_instance_status: str = None,
        activity_name: str = None,
        activity_name_en: str = None,
        id: int = None,
    ):
        self.activity_id = activity_id
        self.activity_instance_status = activity_instance_status
        self.activity_name = activity_name
        self.activity_name_en = activity_name_en
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_instance_status is not None:
            result['activityInstanceStatus'] = self.activity_instance_status
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_name_en is not None:
            result['activityNameEn'] = self.activity_name_en
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityInstanceStatus') is not None:
            self.activity_instance_status = m.get('activityInstanceStatus')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityNameEn') is not None:
            self.activity_name_en = m.get('activityNameEn')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetMeCorpSubmissionResponseBodyData(TeaModel):
    def __init__(
        self,
        actioner: List[GetMeCorpSubmissionResponseBodyDataActioner] = None,
        actioner_id: List[str] = None,
        actioner_name: List[str] = None,
        app_type: str = None,
        create_time_gmt: str = None,
        current_activity_instances: List[GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances] = None,
        data_map: Dict[str, Any] = None,
        data_type: str = None,
        finish_time_gmt: str = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        originator_avatar: str = None,
        originator_display_name: str = None,
        originator_id: str = None,
        process_approved_result: str = None,
        process_approved_result_text: str = None,
        process_code: str = None,
        process_id: int = None,
        process_instance_id: str = None,
        process_instance_status: str = None,
        process_instance_status_text: str = None,
        process_name: str = None,
        title: str = None,
        version: int = None,
    ):
        self.actioner = actioner
        self.actioner_id = actioner_id
        self.actioner_name = actioner_name
        self.app_type = app_type
        self.create_time_gmt = create_time_gmt
        self.current_activity_instances = current_activity_instances
        self.data_map = data_map
        self.data_type = data_type
        self.finish_time_gmt = finish_time_gmt
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.originator_avatar = originator_avatar
        self.originator_display_name = originator_display_name
        self.originator_id = originator_id
        self.process_approved_result = process_approved_result
        self.process_approved_result_text = process_approved_result_text
        self.process_code = process_code
        self.process_id = process_id
        self.process_instance_id = process_instance_id
        self.process_instance_status = process_instance_status
        self.process_instance_status_text = process_instance_status_text
        self.process_name = process_name
        self.title = title
        self.version = version

    def validate(self):
        if self.actioner:
            for k in self.actioner:
                if k:
                    k.validate()
        if self.current_activity_instances:
            for k in self.current_activity_instances:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actioner'] = []
        if self.actioner is not None:
            for k in self.actioner:
                result['actioner'].append(k.to_map() if k else None)
        if self.actioner_id is not None:
            result['actionerId'] = self.actioner_id
        if self.actioner_name is not None:
            result['actionerName'] = self.actioner_name
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        result['currentActivityInstances'] = []
        if self.current_activity_instances is not None:
            for k in self.current_activity_instances:
                result['currentActivityInstances'].append(k.to_map() if k else None)
        if self.data_map is not None:
            result['dataMap'] = self.data_map
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.originator_avatar is not None:
            result['originatorAvatar'] = self.originator_avatar
        if self.originator_display_name is not None:
            result['originatorDisplayName'] = self.originator_display_name
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.process_approved_result is not None:
            result['processApprovedResult'] = self.process_approved_result
        if self.process_approved_result_text is not None:
            result['processApprovedResultText'] = self.process_approved_result_text
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_instance_status is not None:
            result['processInstanceStatus'] = self.process_instance_status
        if self.process_instance_status_text is not None:
            result['processInstanceStatusText'] = self.process_instance_status_text
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actioner = []
        if m.get('actioner') is not None:
            for k in m.get('actioner'):
                temp_model = GetMeCorpSubmissionResponseBodyDataActioner()
                self.actioner.append(temp_model.from_map(k))
        if m.get('actionerId') is not None:
            self.actioner_id = m.get('actionerId')
        if m.get('actionerName') is not None:
            self.actioner_name = m.get('actionerName')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        self.current_activity_instances = []
        if m.get('currentActivityInstances') is not None:
            for k in m.get('currentActivityInstances'):
                temp_model = GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances()
                self.current_activity_instances.append(temp_model.from_map(k))
        if m.get('dataMap') is not None:
            self.data_map = m.get('dataMap')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('originatorAvatar') is not None:
            self.originator_avatar = m.get('originatorAvatar')
        if m.get('originatorDisplayName') is not None:
            self.originator_display_name = m.get('originatorDisplayName')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('processApprovedResult') is not None:
            self.process_approved_result = m.get('processApprovedResult')
        if m.get('processApprovedResultText') is not None:
            self.process_approved_result_text = m.get('processApprovedResultText')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processInstanceStatus') is not None:
            self.process_instance_status = m.get('processInstanceStatus')
        if m.get('processInstanceStatusText') is not None:
            self.process_instance_status_text = m.get('processInstanceStatusText')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetMeCorpSubmissionResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetMeCorpSubmissionResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetMeCorpSubmissionResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetMeCorpSubmissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMeCorpSubmissionResponseBody = None,
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
            temp_model = GetMeCorpSubmissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNotifyMeHeaders(TeaModel):
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


class GetNotifyMeRequest(TeaModel):
    def __init__(
        self,
        app_types: str = None,
        corp_id: str = None,
        create_from_time_gmt: int = None,
        create_to_time_gmt: int = None,
        env: str = None,
        instance_create_from_time_gmt: int = None,
        instance_create_to_time_gmt: int = None,
        keyword: str = None,
        language: str = None,
        page_number: int = None,
        page_size: int = None,
        process_codes: str = None,
        token: str = None,
    ):
        self.app_types = app_types
        # This parameter is required.
        self.corp_id = corp_id
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.env = env
        self.instance_create_from_time_gmt = instance_create_from_time_gmt
        self.instance_create_to_time_gmt = instance_create_to_time_gmt
        self.keyword = keyword
        self.language = language
        self.page_number = page_number
        self.page_size = page_size
        self.process_codes = process_codes
        # This parameter is required.
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_types is not None:
            result['appTypes'] = self.app_types
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.env is not None:
            result['env'] = self.env
        if self.instance_create_from_time_gmt is not None:
            result['instanceCreateFromTimeGMT'] = self.instance_create_from_time_gmt
        if self.instance_create_to_time_gmt is not None:
            result['instanceCreateToTimeGMT'] = self.instance_create_to_time_gmt
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.language is not None:
            result['language'] = self.language
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTypes') is not None:
            self.app_types = m.get('appTypes')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('instanceCreateFromTimeGMT') is not None:
            self.instance_create_from_time_gmt = m.get('instanceCreateFromTimeGMT')
        if m.get('instanceCreateToTimeGMT') is not None:
            self.instance_create_to_time_gmt = m.get('instanceCreateToTimeGMT')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GetNotifyMeResponseBodyData(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        app_type: str = None,
        corp_id: str = None,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        form_instance_id: str = None,
        inst_status: str = None,
        mobile_url: str = None,
        modified_time_gmt: str = None,
        process_code: str = None,
        title: str = None,
        title_in_english: str = None,
        url: str = None,
    ):
        self.activity_id = activity_id
        self.app_type = app_type
        self.corp_id = corp_id
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.form_instance_id = form_instance_id
        self.inst_status = inst_status
        self.mobile_url = mobile_url
        self.modified_time_gmt = modified_time_gmt
        self.process_code = process_code
        self.title = title
        self.title_in_english = title_in_english
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.inst_status is not None:
            result['instStatus'] = self.inst_status
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.title is not None:
            result['title'] = self.title
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('instStatus') is not None:
            self.inst_status = m.get('instStatus')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetNotifyMeResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetNotifyMeResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetNotifyMeResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetNotifyMeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNotifyMeResponseBody = None,
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
            temp_model = GetNotifyMeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOpenUrlHeaders(TeaModel):
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


class GetOpenUrlRequest(TeaModel):
    def __init__(
        self,
        file_url: str = None,
        language: str = None,
        system_token: str = None,
        timeout: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.file_url = file_url
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        self.timeout = timeout
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_url is not None:
            result['fileUrl'] = self.file_url
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.timeout is not None:
            result['timeout'] = self.timeout
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileUrl') is not None:
            self.file_url = m.get('fileUrl')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('timeout') is not None:
            self.timeout = m.get('timeout')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetOpenUrlResponseBody(TeaModel):
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


class GetOpenUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOpenUrlResponseBody = None,
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
            temp_model = GetOpenUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOperationRecordsHeaders(TeaModel):
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


class GetOperationRecordsRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList(TeaModel):
    def __init__(
        self,
        department_description: str = None,
        display_name: str = None,
        display_name_in_english: str = None,
        order_number: str = None,
        personal_photo: str = None,
        status: str = None,
        user_id: str = None,
        user_information: str = None,
    ):
        self.department_description = department_description
        self.display_name = display_name
        self.display_name_in_english = display_name_in_english
        self.order_number = order_number
        self.personal_photo = personal_photo
        self.status = status
        self.user_id = user_id
        self.user_information = user_information

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_description is not None:
            result['departmentDescription'] = self.department_description
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.display_name_in_english is not None:
            result['displayNameInEnglish'] = self.display_name_in_english
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.personal_photo is not None:
            result['personalPhoto'] = self.personal_photo
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_information is not None:
            result['userInformation'] = self.user_information
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentDescription') is not None:
            self.department_description = m.get('departmentDescription')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('displayNameInEnglish') is not None:
            self.display_name_in_english = m.get('displayNameInEnglish')
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('personalPhoto') is not None:
            self.personal_photo = m.get('personalPhoto')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userInformation') is not None:
            self.user_information = m.get('userInformation')
        return self


class GetOperationRecordsResponseBodyResultDomainList(TeaModel):
    def __init__(
        self,
        action: str = None,
        active_time_gmt: str = None,
        activity_id: str = None,
        digital_signature: str = None,
        files: str = None,
        format_action: str = None,
        operate_time_gmt: str = None,
        operate_type: str = None,
        operator: str = None,
        operator_agent_id_list: List[GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList] = None,
        operator_display_name: str = None,
        operator_name: str = None,
        operator_nick_name: str = None,
        operator_photo_url: str = None,
        operator_status: str = None,
        process_instance_id: str = None,
        remark: str = None,
        show_name: str = None,
        size: int = None,
        task_execute_type: str = None,
        task_hold_time_gmt: int = None,
        task_id: str = None,
        task_type: str = None,
        type: str = None,
    ):
        self.action = action
        self.active_time_gmt = active_time_gmt
        self.activity_id = activity_id
        self.digital_signature = digital_signature
        self.files = files
        self.format_action = format_action
        self.operate_time_gmt = operate_time_gmt
        self.operate_type = operate_type
        self.operator = operator
        self.operator_agent_id_list = operator_agent_id_list
        self.operator_display_name = operator_display_name
        self.operator_name = operator_name
        self.operator_nick_name = operator_nick_name
        self.operator_photo_url = operator_photo_url
        self.operator_status = operator_status
        self.process_instance_id = process_instance_id
        self.remark = remark
        self.show_name = show_name
        self.size = size
        self.task_execute_type = task_execute_type
        self.task_hold_time_gmt = task_hold_time_gmt
        self.task_id = task_id
        self.task_type = task_type
        self.type = type

    def validate(self):
        if self.operator_agent_id_list:
            for k in self.operator_agent_id_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.digital_signature is not None:
            result['digitalSignature'] = self.digital_signature
        if self.files is not None:
            result['files'] = self.files
        if self.format_action is not None:
            result['formatAction'] = self.format_action
        if self.operate_time_gmt is not None:
            result['operateTimeGMT'] = self.operate_time_gmt
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator is not None:
            result['operator'] = self.operator
        result['operatorAgentIdList'] = []
        if self.operator_agent_id_list is not None:
            for k in self.operator_agent_id_list:
                result['operatorAgentIdList'].append(k.to_map() if k else None)
        if self.operator_display_name is not None:
            result['operatorDisplayName'] = self.operator_display_name
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.operator_nick_name is not None:
            result['operatorNickName'] = self.operator_nick_name
        if self.operator_photo_url is not None:
            result['operatorPhotoUrl'] = self.operator_photo_url
        if self.operator_status is not None:
            result['operatorStatus'] = self.operator_status
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.size is not None:
            result['size'] = self.size
        if self.task_execute_type is not None:
            result['taskExecuteType'] = self.task_execute_type
        if self.task_hold_time_gmt is not None:
            result['taskHoldTimeGMT'] = self.task_hold_time_gmt
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('digitalSignature') is not None:
            self.digital_signature = m.get('digitalSignature')
        if m.get('files') is not None:
            self.files = m.get('files')
        if m.get('formatAction') is not None:
            self.format_action = m.get('formatAction')
        if m.get('operateTimeGMT') is not None:
            self.operate_time_gmt = m.get('operateTimeGMT')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        self.operator_agent_id_list = []
        if m.get('operatorAgentIdList') is not None:
            for k in m.get('operatorAgentIdList'):
                temp_model = GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList()
                self.operator_agent_id_list.append(temp_model.from_map(k))
        if m.get('operatorDisplayName') is not None:
            self.operator_display_name = m.get('operatorDisplayName')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('operatorNickName') is not None:
            self.operator_nick_name = m.get('operatorNickName')
        if m.get('operatorPhotoUrl') is not None:
            self.operator_photo_url = m.get('operatorPhotoUrl')
        if m.get('operatorStatus') is not None:
            self.operator_status = m.get('operatorStatus')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('taskExecuteType') is not None:
            self.task_execute_type = m.get('taskExecuteType')
        if m.get('taskHoldTimeGMT') is not None:
            self.task_hold_time_gmt = m.get('taskHoldTimeGMT')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetOperationRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        action: str = None,
        action_exit: str = None,
        active_time_gmt: str = None,
        activity_id: str = None,
        data_id: int = None,
        digital_sign: str = None,
        domain_list: List[GetOperationRecordsResponseBodyResultDomainList] = None,
        files: str = None,
        operate_time_gmt: str = None,
        operate_type: str = None,
        operator_display_name: str = None,
        operator_name: str = None,
        operator_nick_name: str = None,
        operator_photo_url: str = None,
        operator_status: str = None,
        operator_user_id: str = None,
        process_instance_id: str = None,
        remark: str = None,
        show_name: str = None,
        size: int = None,
        task_execute_type: str = None,
        task_hold_time_gmt: int = None,
        task_id: str = None,
        task_type: str = None,
        type: str = None,
    ):
        self.action = action
        self.action_exit = action_exit
        self.active_time_gmt = active_time_gmt
        self.activity_id = activity_id
        self.data_id = data_id
        self.digital_sign = digital_sign
        self.domain_list = domain_list
        self.files = files
        self.operate_time_gmt = operate_time_gmt
        self.operate_type = operate_type
        self.operator_display_name = operator_display_name
        self.operator_name = operator_name
        self.operator_nick_name = operator_nick_name
        self.operator_photo_url = operator_photo_url
        self.operator_status = operator_status
        self.operator_user_id = operator_user_id
        self.process_instance_id = process_instance_id
        self.remark = remark
        self.show_name = show_name
        self.size = size
        self.task_execute_type = task_execute_type
        self.task_hold_time_gmt = task_hold_time_gmt
        self.task_id = task_id
        self.task_type = task_type
        self.type = type

    def validate(self):
        if self.domain_list:
            for k in self.domain_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.action_exit is not None:
            result['actionExit'] = self.action_exit
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.digital_sign is not None:
            result['digitalSign'] = self.digital_sign
        result['domainList'] = []
        if self.domain_list is not None:
            for k in self.domain_list:
                result['domainList'].append(k.to_map() if k else None)
        if self.files is not None:
            result['files'] = self.files
        if self.operate_time_gmt is not None:
            result['operateTimeGMT'] = self.operate_time_gmt
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_display_name is not None:
            result['operatorDisplayName'] = self.operator_display_name
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.operator_nick_name is not None:
            result['operatorNickName'] = self.operator_nick_name
        if self.operator_photo_url is not None:
            result['operatorPhotoUrl'] = self.operator_photo_url
        if self.operator_status is not None:
            result['operatorStatus'] = self.operator_status
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.size is not None:
            result['size'] = self.size
        if self.task_execute_type is not None:
            result['taskExecuteType'] = self.task_execute_type
        if self.task_hold_time_gmt is not None:
            result['taskHoldTimeGMT'] = self.task_hold_time_gmt
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionExit') is not None:
            self.action_exit = m.get('actionExit')
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('digitalSign') is not None:
            self.digital_sign = m.get('digitalSign')
        self.domain_list = []
        if m.get('domainList') is not None:
            for k in m.get('domainList'):
                temp_model = GetOperationRecordsResponseBodyResultDomainList()
                self.domain_list.append(temp_model.from_map(k))
        if m.get('files') is not None:
            self.files = m.get('files')
        if m.get('operateTimeGMT') is not None:
            self.operate_time_gmt = m.get('operateTimeGMT')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorDisplayName') is not None:
            self.operator_display_name = m.get('operatorDisplayName')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('operatorNickName') is not None:
            self.operator_nick_name = m.get('operatorNickName')
        if m.get('operatorPhotoUrl') is not None:
            self.operator_photo_url = m.get('operatorPhotoUrl')
        if m.get('operatorStatus') is not None:
            self.operator_status = m.get('operatorStatus')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('taskExecuteType') is not None:
            self.task_execute_type = m.get('taskExecuteType')
        if m.get('taskHoldTimeGMT') is not None:
            self.task_hold_time_gmt = m.get('taskHoldTimeGMT')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetOperationRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetOperationRecordsResponseBodyResult] = None,
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
                temp_model = GetOperationRecordsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetOperationRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOperationRecordsResponseBody = None,
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
            temp_model = GetOperationRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPlatformResourceHeaders(TeaModel):
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


class GetPlatformResourceRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class GetPlatformResourceResponseBody(TeaModel):
    def __init__(
        self,
        account_total_amount: int = None,
        account_usage_amount: int = None,
        app_total_amount: int = None,
        attachment_total_amount: int = None,
        attachment_usage_amount: int = None,
        instance_total_amount: int = None,
        instance_usage_amount: int = None,
        plugin_usage_amount: int = None,
    ):
        self.account_total_amount = account_total_amount
        self.account_usage_amount = account_usage_amount
        self.app_total_amount = app_total_amount
        self.attachment_total_amount = attachment_total_amount
        self.attachment_usage_amount = attachment_usage_amount
        self.instance_total_amount = instance_total_amount
        self.instance_usage_amount = instance_usage_amount
        self.plugin_usage_amount = plugin_usage_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_total_amount is not None:
            result['accountTotalAmount'] = self.account_total_amount
        if self.account_usage_amount is not None:
            result['accountUsageAmount'] = self.account_usage_amount
        if self.app_total_amount is not None:
            result['appTotalAmount'] = self.app_total_amount
        if self.attachment_total_amount is not None:
            result['attachmentTotalAmount'] = self.attachment_total_amount
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        if self.instance_total_amount is not None:
            result['instanceTotalAmount'] = self.instance_total_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        if self.plugin_usage_amount is not None:
            result['pluginUsageAmount'] = self.plugin_usage_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountTotalAmount') is not None:
            self.account_total_amount = m.get('accountTotalAmount')
        if m.get('accountUsageAmount') is not None:
            self.account_usage_amount = m.get('accountUsageAmount')
        if m.get('appTotalAmount') is not None:
            self.app_total_amount = m.get('appTotalAmount')
        if m.get('attachmentTotalAmount') is not None:
            self.attachment_total_amount = m.get('attachmentTotalAmount')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        if m.get('instanceTotalAmount') is not None:
            self.instance_total_amount = m.get('instanceTotalAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        if m.get('pluginUsageAmount') is not None:
            self.plugin_usage_amount = m.get('pluginUsageAmount')
        return self


class GetPlatformResourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPlatformResourceResponseBody = None,
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
            temp_model = GetPlatformResourceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPrintAppInfoHeaders(TeaModel):
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


class GetPrintAppInfoRequest(TeaModel):
    def __init__(
        self,
        name_like: str = None,
        user_id: str = None,
    ):
        self.name_like = name_like
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_like is not None:
            result['nameLike'] = self.name_like
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameLike') is not None:
            self.name_like = m.get('nameLike')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetPrintAppInfoResponseBodyResultFormInfoList(TeaModel):
    def __init__(
        self,
        form_name: str = None,
        form_uuid: str = None,
    ):
        self.form_name = form_name
        self.form_uuid = form_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_name is not None:
            result['formName'] = self.form_name
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formName') is not None:
            self.form_name = m.get('formName')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        return self


class GetPrintAppInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        app_type: str = None,
        form_info_list: List[GetPrintAppInfoResponseBodyResultFormInfoList] = None,
        icon_url: str = None,
    ):
        self.app_name = app_name
        self.app_type = app_type
        self.form_info_list = form_info_list
        self.icon_url = icon_url

    def validate(self):
        if self.form_info_list:
            for k in self.form_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_type is not None:
            result['appType'] = self.app_type
        result['formInfoList'] = []
        if self.form_info_list is not None:
            for k in self.form_info_list:
                result['formInfoList'].append(k.to_map() if k else None)
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        self.form_info_list = []
        if m.get('formInfoList') is not None:
            for k in m.get('formInfoList'):
                temp_model = GetPrintAppInfoResponseBodyResultFormInfoList()
                self.form_info_list.append(temp_model.from_map(k))
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        return self


class GetPrintAppInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetPrintAppInfoResponseBodyResult] = None,
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
                temp_model = GetPrintAppInfoResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetPrintAppInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPrintAppInfoResponseBody = None,
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
            temp_model = GetPrintAppInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPrintDictionaryHeaders(TeaModel):
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


class GetPrintDictionaryRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_uuid: str = None,
        user_id: str = None,
        version: int = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.user_id = user_id
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetPrintDictionaryResponseBody(TeaModel):
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


class GetPrintDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPrintDictionaryResponseBody = None,
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
            temp_model = GetPrintDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessDefinitionHeaders(TeaModel):
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


class GetProcessDefinitionRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        group_id: str = None,
        language: str = None,
        name_space: str = None,
        order_number: str = None,
        system_token: str = None,
        system_type: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.corp_id = corp_id
        self.group_id = group_id
        self.language = language
        self.name_space = name_space
        self.order_number = order_number
        self.system_token = system_token
        self.system_type = system_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.language is not None:
            result['language'] = self.language
        if self.name_space is not None:
            result['nameSpace'] = self.name_space
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.system_type is not None:
            result['systemType'] = self.system_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('nameSpace') is not None:
            self.name_space = m.get('nameSpace')
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('systemType') is not None:
            self.system_type = m.get('systemType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        dept_name_in_english: str = None,
        dept_no: str = None,
        dept_path: str = None,
        human_source_group_order_number: str = None,
        human_source_group_work_no: str = None,
        id: int = None,
        master_work_no: str = None,
    ):
        self.dept_name = dept_name
        self.dept_name_in_english = dept_name_in_english
        self.dept_no = dept_no
        self.dept_path = dept_path
        self.human_source_group_order_number = human_source_group_order_number
        self.human_source_group_work_no = human_source_group_work_no
        self.id = id
        self.master_work_no = master_work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_name_in_english is not None:
            result['deptNameInEnglish'] = self.dept_name_in_english
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.dept_path is not None:
            result['deptPath'] = self.dept_path
        if self.human_source_group_order_number is not None:
            result['humanSourceGroupOrderNumber'] = self.human_source_group_order_number
        if self.human_source_group_work_no is not None:
            result['humanSourceGroupWorkNo'] = self.human_source_group_work_no
        if self.id is not None:
            result['id'] = self.id
        if self.master_work_no is not None:
            result['masterWorkNo'] = self.master_work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNameInEnglish') is not None:
            self.dept_name_in_english = m.get('deptNameInEnglish')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('deptPath') is not None:
            self.dept_path = m.get('deptPath')
        if m.get('humanSourceGroupOrderNumber') is not None:
            self.human_source_group_order_number = m.get('humanSourceGroupOrderNumber')
        if m.get('humanSourceGroupWorkNo') is not None:
            self.human_source_group_work_no = m.get('humanSourceGroupWorkNo')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('masterWorkNo') is not None:
            self.master_work_no = m.get('masterWorkNo')
        return self


class GetProcessDefinitionResponseBodyOriginator(TeaModel):
    def __init__(
        self,
        department_description: str = None,
        display_en_name: str = None,
        display_name: str = None,
        master_data_departments: List[GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments] = None,
        order_number: str = None,
        personal_photo: str = None,
        status: str = None,
        tb_wang: str = None,
        user_id: str = None,
        user_info: str = None,
    ):
        self.department_description = department_description
        self.display_en_name = display_en_name
        self.display_name = display_name
        self.master_data_departments = master_data_departments
        self.order_number = order_number
        self.personal_photo = personal_photo
        self.status = status
        self.tb_wang = tb_wang
        self.user_id = user_id
        self.user_info = user_info

    def validate(self):
        if self.master_data_departments:
            for k in self.master_data_departments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_description is not None:
            result['departmentDescription'] = self.department_description
        if self.display_en_name is not None:
            result['displayEnName'] = self.display_en_name
        if self.display_name is not None:
            result['displayName'] = self.display_name
        result['masterDataDepartments'] = []
        if self.master_data_departments is not None:
            for k in self.master_data_departments:
                result['masterDataDepartments'].append(k.to_map() if k else None)
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.personal_photo is not None:
            result['personalPhoto'] = self.personal_photo
        if self.status is not None:
            result['status'] = self.status
        if self.tb_wang is not None:
            result['tbWang'] = self.tb_wang
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_info is not None:
            result['userInfo'] = self.user_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentDescription') is not None:
            self.department_description = m.get('departmentDescription')
        if m.get('displayEnName') is not None:
            self.display_en_name = m.get('displayEnName')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        self.master_data_departments = []
        if m.get('masterDataDepartments') is not None:
            for k in m.get('masterDataDepartments'):
                temp_model = GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments()
                self.master_data_departments.append(temp_model.from_map(k))
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('personalPhoto') is not None:
            self.personal_photo = m.get('personalPhoto')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('tbWang') is not None:
            self.tb_wang = m.get('tbWang')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userInfo') is not None:
            self.user_info = m.get('userInfo')
        return self


class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        dept_name_in_english: str = None,
        dept_no: str = None,
        dept_path: str = None,
        human_source_group_order_number: str = None,
        human_source_group_work_no: str = None,
        id: int = None,
        master_work_no: str = None,
    ):
        self.dept_name = dept_name
        self.dept_name_in_english = dept_name_in_english
        self.dept_no = dept_no
        self.dept_path = dept_path
        self.human_source_group_order_number = human_source_group_order_number
        self.human_source_group_work_no = human_source_group_work_no
        self.id = id
        self.master_work_no = master_work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_name_in_english is not None:
            result['deptNameInEnglish'] = self.dept_name_in_english
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.dept_path is not None:
            result['deptPath'] = self.dept_path
        if self.human_source_group_order_number is not None:
            result['humanSourceGroupOrderNumber'] = self.human_source_group_order_number
        if self.human_source_group_work_no is not None:
            result['humanSourceGroupWorkNo'] = self.human_source_group_work_no
        if self.id is not None:
            result['id'] = self.id
        if self.master_work_no is not None:
            result['masterWorkNo'] = self.master_work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNameInEnglish') is not None:
            self.dept_name_in_english = m.get('deptNameInEnglish')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('deptPath') is not None:
            self.dept_path = m.get('deptPath')
        if m.get('humanSourceGroupOrderNumber') is not None:
            self.human_source_group_order_number = m.get('humanSourceGroupOrderNumber')
        if m.get('humanSourceGroupWorkNo') is not None:
            self.human_source_group_work_no = m.get('humanSourceGroupWorkNo')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('masterWorkNo') is not None:
            self.master_work_no = m.get('masterWorkNo')
        return self


class GetProcessDefinitionResponseBodyOwners(TeaModel):
    def __init__(
        self,
        department_description: str = None,
        display_en_name: str = None,
        display_name: str = None,
        master_data_departments: List[GetProcessDefinitionResponseBodyOwnersMasterDataDepartments] = None,
        order_number: str = None,
        personal_photo: str = None,
        status: str = None,
        tb_wang: str = None,
        user_id: str = None,
        user_info: str = None,
    ):
        self.department_description = department_description
        self.display_en_name = display_en_name
        self.display_name = display_name
        self.master_data_departments = master_data_departments
        self.order_number = order_number
        self.personal_photo = personal_photo
        self.status = status
        self.tb_wang = tb_wang
        self.user_id = user_id
        self.user_info = user_info

    def validate(self):
        if self.master_data_departments:
            for k in self.master_data_departments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_description is not None:
            result['departmentDescription'] = self.department_description
        if self.display_en_name is not None:
            result['displayEnName'] = self.display_en_name
        if self.display_name is not None:
            result['displayName'] = self.display_name
        result['masterDataDepartments'] = []
        if self.master_data_departments is not None:
            for k in self.master_data_departments:
                result['masterDataDepartments'].append(k.to_map() if k else None)
        if self.order_number is not None:
            result['orderNumber'] = self.order_number
        if self.personal_photo is not None:
            result['personalPhoto'] = self.personal_photo
        if self.status is not None:
            result['status'] = self.status
        if self.tb_wang is not None:
            result['tbWang'] = self.tb_wang
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_info is not None:
            result['userInfo'] = self.user_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentDescription') is not None:
            self.department_description = m.get('departmentDescription')
        if m.get('displayEnName') is not None:
            self.display_en_name = m.get('displayEnName')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        self.master_data_departments = []
        if m.get('masterDataDepartments') is not None:
            for k in m.get('masterDataDepartments'):
                temp_model = GetProcessDefinitionResponseBodyOwnersMasterDataDepartments()
                self.master_data_departments.append(temp_model.from_map(k))
        if m.get('orderNumber') is not None:
            self.order_number = m.get('orderNumber')
        if m.get('personalPhoto') is not None:
            self.personal_photo = m.get('personalPhoto')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('tbWang') is not None:
            self.tb_wang = m.get('tbWang')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userInfo') is not None:
            self.user_info = m.get('userInfo')
        return self


class GetProcessDefinitionResponseBodyTasksActivity(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_instance_status: str = None,
        activity_name: str = None,
        activity_name_in_english: str = None,
        id: int = None,
    ):
        self.activity_id = activity_id
        self.activity_instance_status = activity_instance_status
        self.activity_name = activity_name
        self.activity_name_in_english = activity_name_in_english
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_instance_status is not None:
            result['activityInstanceStatus'] = self.activity_instance_status
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_name_in_english is not None:
            result['activityNameInEnglish'] = self.activity_name_in_english
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityInstanceStatus') is not None:
            self.activity_instance_status = m.get('activityInstanceStatus')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityNameInEnglish') is not None:
            self.activity_name_in_english = m.get('activityNameInEnglish')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetProcessDefinitionResponseBodyTasks(TeaModel):
    def __init__(
        self,
        actioner_id: str = None,
        activity: GetProcessDefinitionResponseBodyTasksActivity = None,
        status: str = None,
        task_id: int = None,
    ):
        self.actioner_id = actioner_id
        self.activity = activity
        self.status = status
        self.task_id = task_id

    def validate(self):
        if self.activity:
            self.activity.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actioner_id is not None:
            result['actionerId'] = self.actioner_id
        if self.activity is not None:
            result['activity'] = self.activity.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionerId') is not None:
            self.actioner_id = m.get('actionerId')
        if m.get('activity') is not None:
            temp_model = GetProcessDefinitionResponseBodyTasksActivity()
            self.activity = temp_model.from_map(m['activity'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetProcessDefinitionResponseBody(TeaModel):
    def __init__(
        self,
        form_uuid: str = None,
        originator: GetProcessDefinitionResponseBodyOriginator = None,
        out_result: str = None,
        owners: List[GetProcessDefinitionResponseBodyOwners] = None,
        process_id: str = None,
        process_instance_id: str = None,
        status: str = None,
        tasks: List[GetProcessDefinitionResponseBodyTasks] = None,
        title: str = None,
        variables: Dict[str, Any] = None,
    ):
        self.form_uuid = form_uuid
        self.originator = originator
        self.out_result = out_result
        self.owners = owners
        self.process_id = process_id
        self.process_instance_id = process_instance_id
        self.status = status
        self.tasks = tasks
        self.title = title
        self.variables = variables

    def validate(self):
        if self.originator:
            self.originator.validate()
        if self.owners:
            for k in self.owners:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.out_result is not None:
            result['outResult'] = self.out_result
        result['owners'] = []
        if self.owners is not None:
            for k in self.owners:
                result['owners'].append(k.to_map() if k else None)
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.status is not None:
            result['status'] = self.status
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        if self.variables is not None:
            result['variables'] = self.variables
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('originator') is not None:
            temp_model = GetProcessDefinitionResponseBodyOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        self.owners = []
        if m.get('owners') is not None:
            for k in m.get('owners'):
                temp_model = GetProcessDefinitionResponseBodyOwners()
                self.owners.append(temp_model.from_map(k))
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = GetProcessDefinitionResponseBodyTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('variables') is not None:
            self.variables = m.get('variables')
        return self


class GetProcessDefinitionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessDefinitionResponseBody = None,
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
            temp_model = GetProcessDefinitionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessDesignHeaders(TeaModel):
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


class GetProcessDesignRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessDesignResponseBodyApprovalSummaryTitle(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        type: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.type = type
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.type is not None:
            result['type'] = self.type
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignResponseBodyApprovalSummary(TeaModel):
    def __init__(
        self,
        title: GetProcessDesignResponseBodyApprovalSummaryTitle = None,
    ):
        self.title = title

    def validate(self):
        if self.title:
            self.title.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            temp_model = GetProcessDesignResponseBodyApprovalSummaryTitle()
            self.title = temp_model.from_map(m['title'])
        return self


class GetProcessDesignResponseBodyFlowConfigSidInstDetail(TeaModel):
    def __init__(
        self,
        field_behavior: str = None,
        field_id: str = None,
    ):
        self.field_behavior = field_behavior
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_behavior is not None:
            result['fieldBehavior'] = self.field_behavior
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldBehavior') is not None:
            self.field_behavior = m.get('fieldBehavior')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class GetProcessDesignResponseBodyFlowConfig(TeaModel):
    def __init__(
        self,
        sid_inst_detail: List[GetProcessDesignResponseBodyFlowConfigSidInstDetail] = None,
    ):
        self.sid_inst_detail = sid_inst_detail

    def validate(self):
        if self.sid_inst_detail:
            for k in self.sid_inst_detail:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sid_instDetail'] = []
        if self.sid_inst_detail is not None:
            for k in self.sid_inst_detail:
                result['sid_instDetail'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.sid_inst_detail = []
        if m.get('sid_instDetail') is not None:
            for k in m.get('sid_instDetail'):
                temp_model = GetProcessDesignResponseBodyFlowConfigSidInstDetail()
                self.sid_inst_detail.append(temp_model.from_map(k))
        return self


class GetProcessDesignResponseBodyFormulaRulesName(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignResponseBodyFormulaRulesRule(TeaModel):
    def __init__(
        self,
        content: str = None,
        display_rule: str = None,
        source: str = None,
    ):
        self.content = content
        self.display_rule = display_rule
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.display_rule is not None:
            result['displayRule'] = self.display_rule
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('displayRule') is not None:
            self.display_rule = m.get('displayRule')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class GetProcessDesignResponseBodyFormulaRules(TeaModel):
    def __init__(
        self,
        activity_action: List[str] = None,
        activity_id: List[str] = None,
        block: str = None,
        message: str = None,
        name: GetProcessDesignResponseBodyFormulaRulesName = None,
        node_type: str = None,
        rule: GetProcessDesignResponseBodyFormulaRulesRule = None,
        rule_type: str = None,
        trigger_mode: str = None,
    ):
        self.activity_action = activity_action
        self.activity_id = activity_id
        self.block = block
        self.message = message
        self.name = name
        self.node_type = node_type
        self.rule = rule
        self.rule_type = rule_type
        self.trigger_mode = trigger_mode

    def validate(self):
        if self.name:
            self.name.validate()
        if self.rule:
            self.rule.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_action is not None:
            result['activityAction'] = self.activity_action
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.block is not None:
            result['block'] = self.block
        if self.message is not None:
            result['message'] = self.message
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.node_type is not None:
            result['nodeType'] = self.node_type
        if self.rule is not None:
            result['rule'] = self.rule.to_map()
        if self.rule_type is not None:
            result['ruleType'] = self.rule_type
        if self.trigger_mode is not None:
            result['triggerMode'] = self.trigger_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityAction') is not None:
            self.activity_action = m.get('activityAction')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('block') is not None:
            self.block = m.get('block')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('name') is not None:
            temp_model = GetProcessDesignResponseBodyFormulaRulesName()
            self.name = temp_model.from_map(m['name'])
        if m.get('nodeType') is not None:
            self.node_type = m.get('nodeType')
        if m.get('rule') is not None:
            temp_model = GetProcessDesignResponseBodyFormulaRulesRule()
            self.rule = temp_model.from_map(m['rule'])
        if m.get('ruleType') is not None:
            self.rule_type = m.get('ruleType')
        if m.get('triggerMode') is not None:
            self.trigger_mode = m.get('triggerMode')
        return self


class GetProcessDesignResponseBodyNodesName(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignResponseBodyNodes(TeaModel):
    def __init__(
        self,
        child_nodes: List[Dict[str, Any]] = None,
        description: str = None,
        name: GetProcessDesignResponseBodyNodesName = None,
        next_id: List[str] = None,
        node_id: str = None,
        prev_id: str = None,
        props: Dict[str, Any] = None,
        type: str = None,
    ):
        self.child_nodes = child_nodes
        self.description = description
        self.name = name
        self.next_id = next_id
        self.node_id = node_id
        self.prev_id = prev_id
        self.props = props
        self.type = type

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_nodes is not None:
            result['childNodes'] = self.child_nodes
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.next_id is not None:
            result['nextId'] = self.next_id
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.prev_id is not None:
            result['prevId'] = self.prev_id
        if self.props is not None:
            result['props'] = self.props
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childNodes') is not None:
            self.child_nodes = m.get('childNodes')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            temp_model = GetProcessDesignResponseBodyNodesName()
            self.name = temp_model.from_map(m['name'])
        if m.get('nextId') is not None:
            self.next_id = m.get('nextId')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('prevId') is not None:
            self.prev_id = m.get('prevId')
        if m.get('props') is not None:
            self.props = m.get('props')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetProcessDesignResponseBodyProps(TeaModel):
    def __init__(
        self,
        allow_collaboration: bool = None,
        allow_temporary_storage: bool = None,
        allow_withdraw: bool = None,
        binding_form: str = None,
        no_record_recall: bool = None,
        process_code: str = None,
        process_detail_url: str = None,
        process_init_url: str = None,
        process_mobile_detail_url: str = None,
        stop_association_rules_if_failed: bool = None,
    ):
        self.allow_collaboration = allow_collaboration
        self.allow_temporary_storage = allow_temporary_storage
        self.allow_withdraw = allow_withdraw
        self.binding_form = binding_form
        self.no_record_recall = no_record_recall
        self.process_code = process_code
        self.process_detail_url = process_detail_url
        self.process_init_url = process_init_url
        self.process_mobile_detail_url = process_mobile_detail_url
        self.stop_association_rules_if_failed = stop_association_rules_if_failed

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_collaboration is not None:
            result['allowCollaboration'] = self.allow_collaboration
        if self.allow_temporary_storage is not None:
            result['allowTemporaryStorage'] = self.allow_temporary_storage
        if self.allow_withdraw is not None:
            result['allowWithdraw'] = self.allow_withdraw
        if self.binding_form is not None:
            result['bindingForm'] = self.binding_form
        if self.no_record_recall is not None:
            result['noRecordRecall'] = self.no_record_recall
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_detail_url is not None:
            result['processDetailUrl'] = self.process_detail_url
        if self.process_init_url is not None:
            result['processInitUrl'] = self.process_init_url
        if self.process_mobile_detail_url is not None:
            result['processMobileDetailUrl'] = self.process_mobile_detail_url
        if self.stop_association_rules_if_failed is not None:
            result['stopAssociationRulesIfFailed'] = self.stop_association_rules_if_failed
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowCollaboration') is not None:
            self.allow_collaboration = m.get('allowCollaboration')
        if m.get('allowTemporaryStorage') is not None:
            self.allow_temporary_storage = m.get('allowTemporaryStorage')
        if m.get('allowWithdraw') is not None:
            self.allow_withdraw = m.get('allowWithdraw')
        if m.get('bindingForm') is not None:
            self.binding_form = m.get('bindingForm')
        if m.get('noRecordRecall') is not None:
            self.no_record_recall = m.get('noRecordRecall')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processDetailUrl') is not None:
            self.process_detail_url = m.get('processDetailUrl')
        if m.get('processInitUrl') is not None:
            self.process_init_url = m.get('processInitUrl')
        if m.get('processMobileDetailUrl') is not None:
            self.process_mobile_detail_url = m.get('processMobileDetailUrl')
        if m.get('stopAssociationRulesIfFailed') is not None:
            self.stop_association_rules_if_failed = m.get('stopAssociationRulesIfFailed')
        return self


class GetProcessDesignResponseBody(TeaModel):
    def __init__(
        self,
        approval_summary: List[GetProcessDesignResponseBodyApprovalSummary] = None,
        flow_config: GetProcessDesignResponseBodyFlowConfig = None,
        formula_rules: List[GetProcessDesignResponseBodyFormulaRules] = None,
        nodes: List[GetProcessDesignResponseBodyNodes] = None,
        props: GetProcessDesignResponseBodyProps = None,
    ):
        self.approval_summary = approval_summary
        self.flow_config = flow_config
        self.formula_rules = formula_rules
        self.nodes = nodes
        self.props = props

    def validate(self):
        if self.approval_summary:
            for k in self.approval_summary:
                if k:
                    k.validate()
        if self.flow_config:
            self.flow_config.validate()
        if self.formula_rules:
            for k in self.formula_rules:
                if k:
                    k.validate()
        if self.nodes:
            for k in self.nodes:
                if k:
                    k.validate()
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['approvalSummary'] = []
        if self.approval_summary is not None:
            for k in self.approval_summary:
                result['approvalSummary'].append(k.to_map() if k else None)
        if self.flow_config is not None:
            result['flowConfig'] = self.flow_config.to_map()
        result['formulaRules'] = []
        if self.formula_rules is not None:
            for k in self.formula_rules:
                result['formulaRules'].append(k.to_map() if k else None)
        result['nodes'] = []
        if self.nodes is not None:
            for k in self.nodes:
                result['nodes'].append(k.to_map() if k else None)
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.approval_summary = []
        if m.get('approvalSummary') is not None:
            for k in m.get('approvalSummary'):
                temp_model = GetProcessDesignResponseBodyApprovalSummary()
                self.approval_summary.append(temp_model.from_map(k))
        if m.get('flowConfig') is not None:
            temp_model = GetProcessDesignResponseBodyFlowConfig()
            self.flow_config = temp_model.from_map(m['flowConfig'])
        self.formula_rules = []
        if m.get('formulaRules') is not None:
            for k in m.get('formulaRules'):
                temp_model = GetProcessDesignResponseBodyFormulaRules()
                self.formula_rules.append(temp_model.from_map(k))
        self.nodes = []
        if m.get('nodes') is not None:
            for k in m.get('nodes'):
                temp_model = GetProcessDesignResponseBodyNodes()
                self.nodes.append(temp_model.from_map(k))
        if m.get('props') is not None:
            temp_model = GetProcessDesignResponseBodyProps()
            self.props = temp_model.from_map(m['props'])
        return self


class GetProcessDesignResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessDesignResponseBody = None,
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
            temp_model = GetProcessDesignResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessDesignByCodeHeaders(TeaModel):
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


class GetProcessDesignByCodeRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        process_code: str = None,
        process_id: int = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.process_code = process_code
        self.process_id = process_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProcessDesignByCodeResponseBodyApprovalSummaryTitle(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        type: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.type = type
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.type is not None:
            result['type'] = self.type
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignByCodeResponseBodyApprovalSummary(TeaModel):
    def __init__(
        self,
        title: GetProcessDesignByCodeResponseBodyApprovalSummaryTitle = None,
    ):
        self.title = title

    def validate(self):
        if self.title:
            self.title.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyApprovalSummaryTitle()
            self.title = temp_model.from_map(m['title'])
        return self


class GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail(TeaModel):
    def __init__(
        self,
        field_behavior: str = None,
        field_id: str = None,
    ):
        self.field_behavior = field_behavior
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_behavior is not None:
            result['fieldBehavior'] = self.field_behavior
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldBehavior') is not None:
            self.field_behavior = m.get('fieldBehavior')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class GetProcessDesignByCodeResponseBodyFlowConfig(TeaModel):
    def __init__(
        self,
        sid_inst_detail: List[GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail] = None,
    ):
        self.sid_inst_detail = sid_inst_detail

    def validate(self):
        if self.sid_inst_detail:
            for k in self.sid_inst_detail:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sid_instDetail'] = []
        if self.sid_inst_detail is not None:
            for k in self.sid_inst_detail:
                result['sid_instDetail'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.sid_inst_detail = []
        if m.get('sid_instDetail') is not None:
            for k in m.get('sid_instDetail'):
                temp_model = GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail()
                self.sid_inst_detail.append(temp_model.from_map(k))
        return self


class GetProcessDesignByCodeResponseBodyFormulaRulesName(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignByCodeResponseBodyFormulaRulesRule(TeaModel):
    def __init__(
        self,
        content: str = None,
        display_rule: str = None,
        source: str = None,
    ):
        self.content = content
        self.display_rule = display_rule
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.display_rule is not None:
            result['displayRule'] = self.display_rule
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('displayRule') is not None:
            self.display_rule = m.get('displayRule')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class GetProcessDesignByCodeResponseBodyFormulaRules(TeaModel):
    def __init__(
        self,
        activity_action: List[str] = None,
        activity_id: List[str] = None,
        block: str = None,
        message: str = None,
        name: GetProcessDesignByCodeResponseBodyFormulaRulesName = None,
        node_type: str = None,
        rule: GetProcessDesignByCodeResponseBodyFormulaRulesRule = None,
        rule_type: str = None,
        trigger_mode: str = None,
    ):
        self.activity_action = activity_action
        self.activity_id = activity_id
        self.block = block
        self.message = message
        self.name = name
        self.node_type = node_type
        self.rule = rule
        self.rule_type = rule_type
        self.trigger_mode = trigger_mode

    def validate(self):
        if self.name:
            self.name.validate()
        if self.rule:
            self.rule.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_action is not None:
            result['activityAction'] = self.activity_action
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.block is not None:
            result['block'] = self.block
        if self.message is not None:
            result['message'] = self.message
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.node_type is not None:
            result['nodeType'] = self.node_type
        if self.rule is not None:
            result['rule'] = self.rule.to_map()
        if self.rule_type is not None:
            result['ruleType'] = self.rule_type
        if self.trigger_mode is not None:
            result['triggerMode'] = self.trigger_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityAction') is not None:
            self.activity_action = m.get('activityAction')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('block') is not None:
            self.block = m.get('block')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('name') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyFormulaRulesName()
            self.name = temp_model.from_map(m['name'])
        if m.get('nodeType') is not None:
            self.node_type = m.get('nodeType')
        if m.get('rule') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyFormulaRulesRule()
            self.rule = temp_model.from_map(m['rule'])
        if m.get('ruleType') is not None:
            self.rule_type = m.get('ruleType')
        if m.get('triggerMode') is not None:
            self.trigger_mode = m.get('triggerMode')
        return self


class GetProcessDesignByCodeResponseBodyNodesName(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['en_US'] = self.en_us
        if self.zh_cn is not None:
            result['zh_CN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('en_US') is not None:
            self.en_us = m.get('en_US')
        if m.get('zh_CN') is not None:
            self.zh_cn = m.get('zh_CN')
        return self


class GetProcessDesignByCodeResponseBodyNodes(TeaModel):
    def __init__(
        self,
        child_nodes: List[Dict[str, Any]] = None,
        description: str = None,
        name: GetProcessDesignByCodeResponseBodyNodesName = None,
        next_id: List[str] = None,
        node_id: str = None,
        prev_id: str = None,
        props: Dict[str, Any] = None,
        type: str = None,
    ):
        self.child_nodes = child_nodes
        self.description = description
        self.name = name
        self.next_id = next_id
        self.node_id = node_id
        self.prev_id = prev_id
        self.props = props
        self.type = type

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_nodes is not None:
            result['childNodes'] = self.child_nodes
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.next_id is not None:
            result['nextId'] = self.next_id
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.prev_id is not None:
            result['prevId'] = self.prev_id
        if self.props is not None:
            result['props'] = self.props
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childNodes') is not None:
            self.child_nodes = m.get('childNodes')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyNodesName()
            self.name = temp_model.from_map(m['name'])
        if m.get('nextId') is not None:
            self.next_id = m.get('nextId')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('prevId') is not None:
            self.prev_id = m.get('prevId')
        if m.get('props') is not None:
            self.props = m.get('props')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetProcessDesignByCodeResponseBodyProps(TeaModel):
    def __init__(
        self,
        allow_collaboration: bool = None,
        allow_temporary_storage: bool = None,
        allow_withdraw: bool = None,
        binding_form: str = None,
        no_record_recall: bool = None,
        process_code: str = None,
        process_detail_url: str = None,
        process_init_url: str = None,
        process_mobile_detail_url: str = None,
        stop_association_rules_if_failed: bool = None,
    ):
        self.allow_collaboration = allow_collaboration
        self.allow_temporary_storage = allow_temporary_storage
        self.allow_withdraw = allow_withdraw
        self.binding_form = binding_form
        self.no_record_recall = no_record_recall
        self.process_code = process_code
        self.process_detail_url = process_detail_url
        self.process_init_url = process_init_url
        self.process_mobile_detail_url = process_mobile_detail_url
        self.stop_association_rules_if_failed = stop_association_rules_if_failed

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_collaboration is not None:
            result['allowCollaboration'] = self.allow_collaboration
        if self.allow_temporary_storage is not None:
            result['allowTemporaryStorage'] = self.allow_temporary_storage
        if self.allow_withdraw is not None:
            result['allowWithdraw'] = self.allow_withdraw
        if self.binding_form is not None:
            result['bindingForm'] = self.binding_form
        if self.no_record_recall is not None:
            result['noRecordRecall'] = self.no_record_recall
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_detail_url is not None:
            result['processDetailUrl'] = self.process_detail_url
        if self.process_init_url is not None:
            result['processInitUrl'] = self.process_init_url
        if self.process_mobile_detail_url is not None:
            result['processMobileDetailUrl'] = self.process_mobile_detail_url
        if self.stop_association_rules_if_failed is not None:
            result['stopAssociationRulesIfFailed'] = self.stop_association_rules_if_failed
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowCollaboration') is not None:
            self.allow_collaboration = m.get('allowCollaboration')
        if m.get('allowTemporaryStorage') is not None:
            self.allow_temporary_storage = m.get('allowTemporaryStorage')
        if m.get('allowWithdraw') is not None:
            self.allow_withdraw = m.get('allowWithdraw')
        if m.get('bindingForm') is not None:
            self.binding_form = m.get('bindingForm')
        if m.get('noRecordRecall') is not None:
            self.no_record_recall = m.get('noRecordRecall')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processDetailUrl') is not None:
            self.process_detail_url = m.get('processDetailUrl')
        if m.get('processInitUrl') is not None:
            self.process_init_url = m.get('processInitUrl')
        if m.get('processMobileDetailUrl') is not None:
            self.process_mobile_detail_url = m.get('processMobileDetailUrl')
        if m.get('stopAssociationRulesIfFailed') is not None:
            self.stop_association_rules_if_failed = m.get('stopAssociationRulesIfFailed')
        return self


class GetProcessDesignByCodeResponseBody(TeaModel):
    def __init__(
        self,
        approval_summary: List[GetProcessDesignByCodeResponseBodyApprovalSummary] = None,
        flow_config: GetProcessDesignByCodeResponseBodyFlowConfig = None,
        formula_rules: List[GetProcessDesignByCodeResponseBodyFormulaRules] = None,
        nodes: List[GetProcessDesignByCodeResponseBodyNodes] = None,
        props: GetProcessDesignByCodeResponseBodyProps = None,
    ):
        self.approval_summary = approval_summary
        self.flow_config = flow_config
        self.formula_rules = formula_rules
        self.nodes = nodes
        self.props = props

    def validate(self):
        if self.approval_summary:
            for k in self.approval_summary:
                if k:
                    k.validate()
        if self.flow_config:
            self.flow_config.validate()
        if self.formula_rules:
            for k in self.formula_rules:
                if k:
                    k.validate()
        if self.nodes:
            for k in self.nodes:
                if k:
                    k.validate()
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['approvalSummary'] = []
        if self.approval_summary is not None:
            for k in self.approval_summary:
                result['approvalSummary'].append(k.to_map() if k else None)
        if self.flow_config is not None:
            result['flowConfig'] = self.flow_config.to_map()
        result['formulaRules'] = []
        if self.formula_rules is not None:
            for k in self.formula_rules:
                result['formulaRules'].append(k.to_map() if k else None)
        result['nodes'] = []
        if self.nodes is not None:
            for k in self.nodes:
                result['nodes'].append(k.to_map() if k else None)
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.approval_summary = []
        if m.get('approvalSummary') is not None:
            for k in m.get('approvalSummary'):
                temp_model = GetProcessDesignByCodeResponseBodyApprovalSummary()
                self.approval_summary.append(temp_model.from_map(k))
        if m.get('flowConfig') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyFlowConfig()
            self.flow_config = temp_model.from_map(m['flowConfig'])
        self.formula_rules = []
        if m.get('formulaRules') is not None:
            for k in m.get('formulaRules'):
                temp_model = GetProcessDesignByCodeResponseBodyFormulaRules()
                self.formula_rules.append(temp_model.from_map(k))
        self.nodes = []
        if m.get('nodes') is not None:
            for k in m.get('nodes'):
                temp_model = GetProcessDesignByCodeResponseBodyNodes()
                self.nodes.append(temp_model.from_map(k))
        if m.get('props') is not None:
            temp_model = GetProcessDesignByCodeResponseBodyProps()
            self.props = temp_model.from_map(m['props'])
        return self


class GetProcessDesignByCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProcessDesignByCodeResponseBody = None,
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
            temp_model = GetProcessDesignByCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRunningTaskListHeaders(TeaModel):
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


class GetRunningTaskListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        process_instance_id_list: str = None,
        system_token: str = None,
        user_corp_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.process_instance_id_list = process_instance_id_list
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_corp_id = user_corp_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.process_instance_id_list is not None:
            result['processInstanceIdList'] = self.process_instance_id_list
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_corp_id is not None:
            result['userCorpId'] = self.user_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('processInstanceIdList') is not None:
            self.process_instance_id_list = m.get('processInstanceIdList')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userCorpId') is not None:
            self.user_corp_id = m.get('userCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRunningTaskListResponseBodyResult(TeaModel):
    def __init__(
        self,
        active_time_gmt: str = None,
        actual_action_executor_id: str = None,
        app_type: str = None,
        create_time_gmt: str = None,
        finish_time_gmt: str = None,
        originator_email: str = None,
        originator_id: str = None,
        originator_name: str = None,
        originator_name_in_english: str = None,
        originator_nick_name: str = None,
        originator_nick_name_in_english: str = None,
        originator_photo: str = None,
        out_result: str = None,
        out_result_name: str = None,
        process_instance_id: str = None,
        status: str = None,
        task_id: str = None,
        task_type: str = None,
        title: str = None,
        title_in_english: str = None,
    ):
        self.active_time_gmt = active_time_gmt
        self.actual_action_executor_id = actual_action_executor_id
        self.app_type = app_type
        self.create_time_gmt = create_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.originator_email = originator_email
        self.originator_id = originator_id
        self.originator_name = originator_name
        self.originator_name_in_english = originator_name_in_english
        self.originator_nick_name = originator_nick_name
        self.originator_nick_name_in_english = originator_nick_name_in_english
        self.originator_photo = originator_photo
        self.out_result = out_result
        self.out_result_name = out_result_name
        self.process_instance_id = process_instance_id
        self.status = status
        self.task_id = task_id
        self.task_type = task_type
        self.title = title
        self.title_in_english = title_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.actual_action_executor_id is not None:
            result['actualActionExecutorId'] = self.actual_action_executor_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.originator_email is not None:
            result['originatorEmail'] = self.originator_email
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.originator_name is not None:
            result['originatorName'] = self.originator_name
        if self.originator_name_in_english is not None:
            result['originatorNameInEnglish'] = self.originator_name_in_english
        if self.originator_nick_name is not None:
            result['originatorNickName'] = self.originator_nick_name
        if self.originator_nick_name_in_english is not None:
            result['originatorNickNameInEnglish'] = self.originator_nick_name_in_english
        if self.originator_photo is not None:
            result['originatorPhoto'] = self.originator_photo
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.out_result_name is not None:
            result['outResultName'] = self.out_result_name
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title is not None:
            result['title'] = self.title
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('actualActionExecutorId') is not None:
            self.actual_action_executor_id = m.get('actualActionExecutorId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('originatorEmail') is not None:
            self.originator_email = m.get('originatorEmail')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('originatorName') is not None:
            self.originator_name = m.get('originatorName')
        if m.get('originatorNameInEnglish') is not None:
            self.originator_name_in_english = m.get('originatorNameInEnglish')
        if m.get('originatorNickName') is not None:
            self.originator_nick_name = m.get('originatorNickName')
        if m.get('originatorNickNameInEnglish') is not None:
            self.originator_nick_name_in_english = m.get('originatorNickNameInEnglish')
        if m.get('originatorPhoto') is not None:
            self.originator_photo = m.get('originatorPhoto')
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('outResultName') is not None:
            self.out_result_name = m.get('outResultName')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        return self


class GetRunningTaskListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetRunningTaskListResponseBodyResult] = None,
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
                temp_model = GetRunningTaskListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetRunningTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRunningTaskListResponseBody = None,
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
            temp_model = GetRunningTaskListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRunningTasksHeaders(TeaModel):
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


class GetRunningTasksRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.language = language
        self.process_instance_id = process_instance_id
        self.system_token = system_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRunningTasksResponseBodyResult(TeaModel):
    def __init__(
        self,
        active_time_gmt: str = None,
        activity_id: str = None,
        actual_actioner_id: str = None,
        create_time_gmt: str = None,
        finish_time_gmt: str = None,
        originator_id: str = None,
        process_instance_id: str = None,
        status: str = None,
        task_id: str = None,
        task_type: str = None,
        title: str = None,
        title_in_english: str = None,
    ):
        self.active_time_gmt = active_time_gmt
        self.activity_id = activity_id
        self.actual_actioner_id = actual_actioner_id
        self.create_time_gmt = create_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.originator_id = originator_id
        self.process_instance_id = process_instance_id
        self.status = status
        self.task_id = task_id
        self.task_type = task_type
        self.title = title
        self.title_in_english = title_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.actual_actioner_id is not None:
            result['actualActionerId'] = self.actual_actioner_id
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title is not None:
            result['title'] = self.title
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('actualActionerId') is not None:
            self.actual_actioner_id = m.get('actualActionerId')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        return self


class GetRunningTasksResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetRunningTasksResponseBodyResult] = None,
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
                temp_model = GetRunningTasksResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetRunningTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRunningTasksResponseBody = None,
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
            temp_model = GetRunningTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSaleUserInfoByUserIdHeaders(TeaModel):
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


class GetSaleUserInfoByUserIdRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        namespace: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.namespace = namespace
        # This parameter is required.
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
        if self.namespace is not None:
            result['namespace'] = self.namespace
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('namespace') is not None:
            self.namespace = m.get('namespace')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetSaleUserInfoByUserIdResponseBodyCorpList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        corp_name: str = None,
        namespace: str = None,
    ):
        self.corp_id = corp_id
        self.corp_name = corp_name
        self.namespace = namespace

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        if self.namespace is not None:
            result['namespace'] = self.namespace
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        if m.get('namespace') is not None:
            self.namespace = m.get('namespace')
        return self


class GetSaleUserInfoByUserIdResponseBody(TeaModel):
    def __init__(
        self,
        account_id: int = None,
        corp_list: List[GetSaleUserInfoByUserIdResponseBodyCorpList] = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.account_id = account_id
        self.corp_list = corp_list
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        if self.corp_list:
            for k in self.corp_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        result['corpList'] = []
        if self.corp_list is not None:
            for k in self.corp_list:
                result['corpList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        self.corp_list = []
        if m.get('corpList') is not None:
            for k in m.get('corpList'):
                temp_model = GetSaleUserInfoByUserIdResponseBodyCorpList()
                self.corp_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class GetSaleUserInfoByUserIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSaleUserInfoByUserIdResponseBody = None,
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
            temp_model = GetSaleUserInfoByUserIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSimpleCubeModelListHeaders(TeaModel):
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


class GetSimpleCubeModelListRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        cube_code: str = None,
        cube_tenant_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.cube_code = cube_code
        # This parameter is required.
        self.cube_tenant_id = cube_tenant_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cube_code is not None:
            result['cubeCode'] = self.cube_code
        if self.cube_tenant_id is not None:
            result['cubeTenantId'] = self.cube_tenant_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cubeCode') is not None:
            self.cube_code = m.get('cubeCode')
        if m.get('cubeTenantId') is not None:
            self.cube_tenant_id = m.get('cubeTenantId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetSimpleCubeModelListResponseBodyResultChildren(TeaModel):
    def __init__(
        self,
        classified_code: str = None,
        cube_code: str = None,
        data_type: str = None,
        dimension_type: str = None,
        field_code: str = None,
        id: str = None,
        is_dimension: str = None,
        is_visible: str = None,
        measure_type: str = None,
        text: str = None,
        time_format: str = None,
        time_granularity_type: str = None,
    ):
        self.classified_code = classified_code
        self.cube_code = cube_code
        self.data_type = data_type
        self.dimension_type = dimension_type
        self.field_code = field_code
        self.id = id
        self.is_dimension = is_dimension
        self.is_visible = is_visible
        self.measure_type = measure_type
        self.text = text
        self.time_format = time_format
        self.time_granularity_type = time_granularity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classified_code is not None:
            result['classifiedCode'] = self.classified_code
        if self.cube_code is not None:
            result['cubeCode'] = self.cube_code
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.dimension_type is not None:
            result['dimensionType'] = self.dimension_type
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.id is not None:
            result['id'] = self.id
        if self.is_dimension is not None:
            result['isDimension'] = self.is_dimension
        if self.is_visible is not None:
            result['isVisible'] = self.is_visible
        if self.measure_type is not None:
            result['measureType'] = self.measure_type
        if self.text is not None:
            result['text'] = self.text
        if self.time_format is not None:
            result['timeFormat'] = self.time_format
        if self.time_granularity_type is not None:
            result['timeGranularityType'] = self.time_granularity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classifiedCode') is not None:
            self.classified_code = m.get('classifiedCode')
        if m.get('cubeCode') is not None:
            self.cube_code = m.get('cubeCode')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('dimensionType') is not None:
            self.dimension_type = m.get('dimensionType')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDimension') is not None:
            self.is_dimension = m.get('isDimension')
        if m.get('isVisible') is not None:
            self.is_visible = m.get('isVisible')
        if m.get('measureType') is not None:
            self.measure_type = m.get('measureType')
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('timeFormat') is not None:
            self.time_format = m.get('timeFormat')
        if m.get('timeGranularityType') is not None:
            self.time_granularity_type = m.get('timeGranularityType')
        return self


class GetSimpleCubeModelListResponseBodyResult(TeaModel):
    def __init__(
        self,
        children: List[GetSimpleCubeModelListResponseBodyResultChildren] = None,
        id: str = None,
        is_dimension: str = None,
        text: str = None,
    ):
        self.children = children
        self.id = id
        self.is_dimension = is_dimension
        self.text = text

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.id is not None:
            result['id'] = self.id
        if self.is_dimension is not None:
            result['isDimension'] = self.is_dimension
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = GetSimpleCubeModelListResponseBodyResultChildren()
                self.children.append(temp_model.from_map(k))
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDimension') is not None:
            self.is_dimension = m.get('isDimension')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class GetSimpleCubeModelListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSimpleCubeModelListResponseBodyResult] = None,
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
                temp_model = GetSimpleCubeModelListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSimpleCubeModelListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSimpleCubeModelListResponseBody = None,
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
            temp_model = GetSimpleCubeModelListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTaskCopiesHeaders(TeaModel):
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


class GetTaskCopiesRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: int = None,
        create_to_time_gmt: int = None,
        keyword: str = None,
        language: str = None,
        page_number: int = None,
        page_size: int = None,
        process_codes: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.keyword = keyword
        self.language = language
        self.page_number = page_number
        self.page_size = page_size
        self.process_codes = process_codes
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.language is not None:
            result['language'] = self.language
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_codes is not None:
            result['processCodes'] = self.process_codes
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCodes') is not None:
            self.process_codes = m.get('processCodes')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTaskCopiesResponseBodyDataCurrentActivityInstances(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        activity_instance_status: str = None,
        activity_name: str = None,
        activity_name_in_english: str = None,
        id: int = None,
    ):
        self.activity_id = activity_id
        self.activity_instance_status = activity_instance_status
        self.activity_name = activity_name
        self.activity_name_in_english = activity_name_in_english
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_instance_status is not None:
            result['activityInstanceStatus'] = self.activity_instance_status
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_name_in_english is not None:
            result['activityNameInEnglish'] = self.activity_name_in_english
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityInstanceStatus') is not None:
            self.activity_instance_status = m.get('activityInstanceStatus')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityNameInEnglish') is not None:
            self.activity_name_in_english = m.get('activityNameInEnglish')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetTaskCopiesResponseBodyData(TeaModel):
    def __init__(
        self,
        action_executor_id: List[str] = None,
        action_executor_name: List[str] = None,
        app_type: str = None,
        carbon_activity_id: str = None,
        create_time_gmt: str = None,
        current_activity_instances: List[GetTaskCopiesResponseBodyDataCurrentActivityInstances] = None,
        data_map: Dict[str, Any] = None,
        data_type: str = None,
        finish_time_gmt: str = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        originator_avatar: str = None,
        originator_display_name: str = None,
        originator_id: str = None,
        process_approved_result: str = None,
        process_approved_result_text: str = None,
        process_code: str = None,
        process_id: int = None,
        process_instance_id: str = None,
        process_instance_status: str = None,
        process_instance_status_text: str = None,
        process_name: str = None,
        serial_number: str = None,
        title: str = None,
        version: int = None,
    ):
        self.action_executor_id = action_executor_id
        self.action_executor_name = action_executor_name
        self.app_type = app_type
        self.carbon_activity_id = carbon_activity_id
        self.create_time_gmt = create_time_gmt
        self.current_activity_instances = current_activity_instances
        self.data_map = data_map
        self.data_type = data_type
        self.finish_time_gmt = finish_time_gmt
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.originator_avatar = originator_avatar
        self.originator_display_name = originator_display_name
        self.originator_id = originator_id
        self.process_approved_result = process_approved_result
        self.process_approved_result_text = process_approved_result_text
        self.process_code = process_code
        self.process_id = process_id
        self.process_instance_id = process_instance_id
        self.process_instance_status = process_instance_status
        self.process_instance_status_text = process_instance_status_text
        self.process_name = process_name
        self.serial_number = serial_number
        self.title = title
        self.version = version

    def validate(self):
        if self.current_activity_instances:
            for k in self.current_activity_instances:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_executor_id is not None:
            result['actionExecutorId'] = self.action_executor_id
        if self.action_executor_name is not None:
            result['actionExecutorName'] = self.action_executor_name
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.carbon_activity_id is not None:
            result['carbonActivityId'] = self.carbon_activity_id
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        result['currentActivityInstances'] = []
        if self.current_activity_instances is not None:
            for k in self.current_activity_instances:
                result['currentActivityInstances'].append(k.to_map() if k else None)
        if self.data_map is not None:
            result['dataMap'] = self.data_map
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.originator_avatar is not None:
            result['originatorAvatar'] = self.originator_avatar
        if self.originator_display_name is not None:
            result['originatorDisplayName'] = self.originator_display_name
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.process_approved_result is not None:
            result['processApprovedResult'] = self.process_approved_result
        if self.process_approved_result_text is not None:
            result['processApprovedResultText'] = self.process_approved_result_text
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_instance_status is not None:
            result['processInstanceStatus'] = self.process_instance_status
        if self.process_instance_status_text is not None:
            result['processInstanceStatusText'] = self.process_instance_status_text
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionExecutorId') is not None:
            self.action_executor_id = m.get('actionExecutorId')
        if m.get('actionExecutorName') is not None:
            self.action_executor_name = m.get('actionExecutorName')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('carbonActivityId') is not None:
            self.carbon_activity_id = m.get('carbonActivityId')
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        self.current_activity_instances = []
        if m.get('currentActivityInstances') is not None:
            for k in m.get('currentActivityInstances'):
                temp_model = GetTaskCopiesResponseBodyDataCurrentActivityInstances()
                self.current_activity_instances.append(temp_model.from_map(k))
        if m.get('dataMap') is not None:
            self.data_map = m.get('dataMap')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('originatorAvatar') is not None:
            self.originator_avatar = m.get('originatorAvatar')
        if m.get('originatorDisplayName') is not None:
            self.originator_display_name = m.get('originatorDisplayName')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('processApprovedResult') is not None:
            self.process_approved_result = m.get('processApprovedResult')
        if m.get('processApprovedResultText') is not None:
            self.process_approved_result_text = m.get('processApprovedResultText')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processInstanceStatus') is not None:
            self.process_instance_status = m.get('processInstanceStatus')
        if m.get('processInstanceStatusText') is not None:
            self.process_instance_status_text = m.get('processInstanceStatusText')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetTaskCopiesResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetTaskCopiesResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetTaskCopiesResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetTaskCopiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskCopiesResponseBody = None,
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
            temp_model = GetTaskCopiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListApplicationHeaders(TeaModel):
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


class ListApplicationRequest(TeaModel):
    def __init__(
        self,
        app_filter: str = None,
        app_name_search_keyword: str = None,
        corp_id: str = None,
        env: str = None,
        page_number: int = None,
        page_size: int = None,
        token: str = None,
        user_id: str = None,
    ):
        self.app_filter = app_filter
        self.app_name_search_keyword = app_name_search_keyword
        # This parameter is required.
        self.corp_id = corp_id
        self.env = env
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.token = token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_filter is not None:
            result['appFilter'] = self.app_filter
        if self.app_name_search_keyword is not None:
            result['appNameSearchKeyword'] = self.app_name_search_keyword
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.env is not None:
            result['env'] = self.env
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.token is not None:
            result['token'] = self.token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appFilter') is not None:
            self.app_filter = m.get('appFilter')
        if m.get('appNameSearchKeyword') is not None:
            self.app_name_search_keyword = m.get('appNameSearchKeyword')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('token') is not None:
            self.token = m.get('token')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListApplicationResponseBodyData(TeaModel):
    def __init__(
        self,
        app_config: str = None,
        app_type: str = None,
        application_status: str = None,
        corp_id: str = None,
        creator_user_id: str = None,
        description: str = None,
        icon: str = None,
        inexistence: str = None,
        name: str = None,
        release_to_ding_status: str = None,
        sub_corp_id: str = None,
        system_token: str = None,
    ):
        self.app_config = app_config
        self.app_type = app_type
        self.application_status = application_status
        self.corp_id = corp_id
        self.creator_user_id = creator_user_id
        self.description = description
        self.icon = icon
        self.inexistence = inexistence
        self.name = name
        self.release_to_ding_status = release_to_ding_status
        self.sub_corp_id = sub_corp_id
        self.system_token = system_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_config is not None:
            result['appConfig'] = self.app_config
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.application_status is not None:
            result['applicationStatus'] = self.application_status
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.inexistence is not None:
            result['inexistence'] = self.inexistence
        if self.name is not None:
            result['name'] = self.name
        if self.release_to_ding_status is not None:
            result['releaseToDingStatus'] = self.release_to_ding_status
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appConfig') is not None:
            self.app_config = m.get('appConfig')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('applicationStatus') is not None:
            self.application_status = m.get('applicationStatus')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('inexistence') is not None:
            self.inexistence = m.get('inexistence')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('releaseToDingStatus') is not None:
            self.release_to_ding_status = m.get('releaseToDingStatus')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        return self


class ListApplicationResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListApplicationResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListApplicationResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListApplicationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListApplicationResponseBody = None,
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
            temp_model = ListApplicationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListApplicationAuthorizationServiceApplicationInformationHeaders(TeaModel):
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


class ListApplicationAuthorizationServiceApplicationInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_union_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.access_key = access_key
        self.caller_union_id = caller_union_id
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins(TeaModel):
    def __init__(
        self,
        icon_url: str = None,
        plugin_name: str = None,
    ):
        self.icon_url = icon_url
        self.plugin_name = plugin_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.plugin_name is not None:
            result['pluginName'] = self.plugin_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('pluginName') is not None:
            self.plugin_name = m.get('pluginName')
        return self


class ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        app_type: str = None,
        attachment_usage_amount: int = None,
        instance_usage_amount: int = None,
        usage_plugins: List[ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins] = None,
    ):
        self.app_name = app_name
        self.app_type = app_type
        self.attachment_usage_amount = attachment_usage_amount
        self.instance_usage_amount = instance_usage_amount
        self.usage_plugins = usage_plugins

    def validate(self):
        if self.usage_plugins:
            for k in self.usage_plugins:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        result['usagePlugins'] = []
        if self.usage_plugins is not None:
            for k in self.usage_plugins:
                result['usagePlugins'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        self.usage_plugins = []
        if m.get('usagePlugins') is not None:
            for k in m.get('usagePlugins'):
                temp_model = ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformationUsagePlugins()
                self.usage_plugins.append(temp_model.from_map(k))
        return self


class ListApplicationAuthorizationServiceApplicationInformationResponseBody(TeaModel):
    def __init__(
        self,
        application_information: List[ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.application_information = application_information
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.application_information:
            for k in self.application_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['applicationInformation'] = []
        if self.application_information is not None:
            for k in self.application_information:
                result['applicationInformation'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.application_information = []
        if m.get('applicationInformation') is not None:
            for k in m.get('applicationInformation'):
                temp_model = ListApplicationAuthorizationServiceApplicationInformationResponseBodyApplicationInformation()
                self.application_information.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListApplicationAuthorizationServiceApplicationInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListApplicationAuthorizationServiceApplicationInformationResponseBody = None,
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
            temp_model = ListApplicationAuthorizationServiceApplicationInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListApplicationAuthorizationServiceConnectorInformationHeaders(TeaModel):
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


class ListApplicationAuthorizationServiceConnectorInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications(TeaModel):
    def __init__(
        self,
        app_name: str = None,
    ):
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation(TeaModel):
    def __init__(
        self,
        applications: List[ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications] = None,
        icon_url: str = None,
        plug_name: str = None,
        plug_pay_type: int = None,
        plug_status: int = None,
        plug_total_amount: int = None,
        plug_usage_amount: int = None,
        plug_uuid: str = None,
    ):
        self.applications = applications
        self.icon_url = icon_url
        self.plug_name = plug_name
        self.plug_pay_type = plug_pay_type
        self.plug_status = plug_status
        self.plug_total_amount = plug_total_amount
        self.plug_usage_amount = plug_usage_amount
        self.plug_uuid = plug_uuid

    def validate(self):
        if self.applications:
            for k in self.applications:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['applications'] = []
        if self.applications is not None:
            for k in self.applications:
                result['applications'].append(k.to_map() if k else None)
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.plug_name is not None:
            result['plugName'] = self.plug_name
        if self.plug_pay_type is not None:
            result['plugPayType'] = self.plug_pay_type
        if self.plug_status is not None:
            result['plugStatus'] = self.plug_status
        if self.plug_total_amount is not None:
            result['plugTotalAmount'] = self.plug_total_amount
        if self.plug_usage_amount is not None:
            result['plugUsageAmount'] = self.plug_usage_amount
        if self.plug_uuid is not None:
            result['plugUuid'] = self.plug_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.applications = []
        if m.get('applications') is not None:
            for k in m.get('applications'):
                temp_model = ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformationApplications()
                self.applications.append(temp_model.from_map(k))
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('plugName') is not None:
            self.plug_name = m.get('plugName')
        if m.get('plugPayType') is not None:
            self.plug_pay_type = m.get('plugPayType')
        if m.get('plugStatus') is not None:
            self.plug_status = m.get('plugStatus')
        if m.get('plugTotalAmount') is not None:
            self.plug_total_amount = m.get('plugTotalAmount')
        if m.get('plugUsageAmount') is not None:
            self.plug_usage_amount = m.get('plugUsageAmount')
        if m.get('plugUuid') is not None:
            self.plug_uuid = m.get('plugUuid')
        return self


class ListApplicationAuthorizationServiceConnectorInformationResponseBody(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        plug_information: List[ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation] = None,
        total_count: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.plug_information = plug_information
        self.total_count = total_count

    def validate(self):
        if self.plug_information:
            for k in self.plug_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['plugInformation'] = []
        if self.plug_information is not None:
            for k in self.plug_information:
                result['plugInformation'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.plug_information = []
        if m.get('plugInformation') is not None:
            for k in m.get('plugInformation'):
                temp_model = ListApplicationAuthorizationServiceConnectorInformationResponseBodyPlugInformation()
                self.plug_information.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListApplicationAuthorizationServiceConnectorInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListApplicationAuthorizationServiceConnectorInformationResponseBody = None,
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
            temp_model = ListApplicationAuthorizationServiceConnectorInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListApplicationInformationHeaders(TeaModel):
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


class ListApplicationInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListApplicationInformationResponseBodyApplicationInformationUsagePlugins(TeaModel):
    def __init__(
        self,
        icon_url: str = None,
        plugin_name: str = None,
    ):
        self.icon_url = icon_url
        self.plugin_name = plugin_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.plugin_name is not None:
            result['pluginName'] = self.plugin_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('pluginName') is not None:
            self.plugin_name = m.get('pluginName')
        return self


class ListApplicationInformationResponseBodyApplicationInformation(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        app_type: str = None,
        attachment_usage_amount: int = None,
        instance_usage_amount: int = None,
        usage_plugins: List[ListApplicationInformationResponseBodyApplicationInformationUsagePlugins] = None,
    ):
        self.app_name = app_name
        self.app_type = app_type
        self.attachment_usage_amount = attachment_usage_amount
        self.instance_usage_amount = instance_usage_amount
        self.usage_plugins = usage_plugins

    def validate(self):
        if self.usage_plugins:
            for k in self.usage_plugins:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        result['usagePlugins'] = []
        if self.usage_plugins is not None:
            for k in self.usage_plugins:
                result['usagePlugins'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        self.usage_plugins = []
        if m.get('usagePlugins') is not None:
            for k in m.get('usagePlugins'):
                temp_model = ListApplicationInformationResponseBodyApplicationInformationUsagePlugins()
                self.usage_plugins.append(temp_model.from_map(k))
        return self


class ListApplicationInformationResponseBody(TeaModel):
    def __init__(
        self,
        application_information: List[ListApplicationInformationResponseBodyApplicationInformation] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.application_information = application_information
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.application_information:
            for k in self.application_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['applicationInformation'] = []
        if self.application_information is not None:
            for k in self.application_information:
                result['applicationInformation'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.application_information = []
        if m.get('applicationInformation') is not None:
            for k in m.get('applicationInformation'):
                temp_model = ListApplicationInformationResponseBodyApplicationInformation()
                self.application_information.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListApplicationInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListApplicationInformationResponseBody = None,
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
            temp_model = ListApplicationInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCommodityHeaders(TeaModel):
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


class ListCommodityRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListCommodityResponseBodyCommodityVOList(TeaModel):
    def __init__(
        self,
        account_distribution_number: int = None,
        account_number: int = None,
        activation_code: str = None,
        buy_date_gmt: str = None,
        expire_date_gmt: str = None,
        instance_id: str = None,
        status: str = None,
        version: int = None,
    ):
        self.account_distribution_number = account_distribution_number
        self.account_number = account_number
        self.activation_code = activation_code
        self.buy_date_gmt = buy_date_gmt
        self.expire_date_gmt = expire_date_gmt
        self.instance_id = instance_id
        self.status = status
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_distribution_number is not None:
            result['accountDistributionNumber'] = self.account_distribution_number
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.activation_code is not None:
            result['activationCode'] = self.activation_code
        if self.buy_date_gmt is not None:
            result['buyDateGMT'] = self.buy_date_gmt
        if self.expire_date_gmt is not None:
            result['expireDateGMT'] = self.expire_date_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountDistributionNumber') is not None:
            self.account_distribution_number = m.get('accountDistributionNumber')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('activationCode') is not None:
            self.activation_code = m.get('activationCode')
        if m.get('buyDateGMT') is not None:
            self.buy_date_gmt = m.get('buyDateGMT')
        if m.get('expireDateGMT') is not None:
            self.expire_date_gmt = m.get('expireDateGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListCommodityResponseBody(TeaModel):
    def __init__(
        self,
        commodity_volist: List[ListCommodityResponseBodyCommodityVOList] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.commodity_volist = commodity_volist
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.commodity_volist:
            for k in self.commodity_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['commodityVOList'] = []
        if self.commodity_volist is not None:
            for k in self.commodity_volist:
                result['commodityVOList'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.commodity_volist = []
        if m.get('commodityVOList') is not None:
            for k in m.get('commodityVOList'):
                temp_model = ListCommodityResponseBodyCommodityVOList()
                self.commodity_volist.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListCommodityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListCommodityResponseBody = None,
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
            temp_model = ListCommodityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListConnectorInformationHeaders(TeaModel):
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


class ListConnectorInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListConnectorInformationResponseBodyPluginInfosApps(TeaModel):
    def __init__(
        self,
        app_name: str = None,
    ):
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class ListConnectorInformationResponseBodyPluginInfos(TeaModel):
    def __init__(
        self,
        apps: List[ListConnectorInformationResponseBodyPluginInfosApps] = None,
        icon_url: str = None,
        plugin_name: str = None,
        plugin_pay_type: int = None,
        plugin_status: int = None,
        plugin_total_amount: int = None,
        plugin_usage_amount: int = None,
        plugin_uuid: str = None,
    ):
        self.apps = apps
        self.icon_url = icon_url
        self.plugin_name = plugin_name
        self.plugin_pay_type = plugin_pay_type
        self.plugin_status = plugin_status
        self.plugin_total_amount = plugin_total_amount
        self.plugin_usage_amount = plugin_usage_amount
        self.plugin_uuid = plugin_uuid

    def validate(self):
        if self.apps:
            for k in self.apps:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['apps'] = []
        if self.apps is not None:
            for k in self.apps:
                result['apps'].append(k.to_map() if k else None)
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.plugin_name is not None:
            result['pluginName'] = self.plugin_name
        if self.plugin_pay_type is not None:
            result['pluginPayType'] = self.plugin_pay_type
        if self.plugin_status is not None:
            result['pluginStatus'] = self.plugin_status
        if self.plugin_total_amount is not None:
            result['pluginTotalAmount'] = self.plugin_total_amount
        if self.plugin_usage_amount is not None:
            result['pluginUsageAmount'] = self.plugin_usage_amount
        if self.plugin_uuid is not None:
            result['pluginUuid'] = self.plugin_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.apps = []
        if m.get('apps') is not None:
            for k in m.get('apps'):
                temp_model = ListConnectorInformationResponseBodyPluginInfosApps()
                self.apps.append(temp_model.from_map(k))
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('pluginName') is not None:
            self.plugin_name = m.get('pluginName')
        if m.get('pluginPayType') is not None:
            self.plugin_pay_type = m.get('pluginPayType')
        if m.get('pluginStatus') is not None:
            self.plugin_status = m.get('pluginStatus')
        if m.get('pluginTotalAmount') is not None:
            self.plugin_total_amount = m.get('pluginTotalAmount')
        if m.get('pluginUsageAmount') is not None:
            self.plugin_usage_amount = m.get('pluginUsageAmount')
        if m.get('pluginUuid') is not None:
            self.plugin_uuid = m.get('pluginUuid')
        return self


class ListConnectorInformationResponseBody(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        plugin_infos: List[ListConnectorInformationResponseBodyPluginInfos] = None,
        total_count: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.plugin_infos = plugin_infos
        self.total_count = total_count

    def validate(self):
        if self.plugin_infos:
            for k in self.plugin_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['pluginInfos'] = []
        if self.plugin_infos is not None:
            for k in self.plugin_infos:
                result['pluginInfos'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.plugin_infos = []
        if m.get('pluginInfos') is not None:
            for k in m.get('pluginInfos'):
                temp_model = ListConnectorInformationResponseBodyPluginInfos()
                self.plugin_infos.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListConnectorInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListConnectorInformationResponseBody = None,
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
            temp_model = ListConnectorInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFormRemarksHeaders(TeaModel):
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


class ListFormRemarksRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_instance_id_list: List[str] = None,
        form_uuid: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.form_instance_id_list = form_instance_id_list
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_instance_id_list is not None:
            result['formInstanceIdList'] = self.form_instance_id_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formInstanceIdList') is not None:
            self.form_instance_id_list = m.get('formInstanceIdList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListFormRemarksResponseBody(TeaModel):
    def __init__(
        self,
        form_remark_vo_map: Dict[str, Any] = None,
    ):
        self.form_remark_vo_map = form_remark_vo_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_remark_vo_map is not None:
            result['formRemarkVoMap'] = self.form_remark_vo_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formRemarkVoMap') is not None:
            self.form_remark_vo_map = m.get('formRemarkVoMap')
        return self


class ListFormRemarksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListFormRemarksResponseBody = None,
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
            temp_model = ListFormRemarksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListNavigationByFormTypeHeaders(TeaModel):
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


class ListNavigationByFormTypeRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_type: str = None,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_type = form_type
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_type is not None:
            result['formType'] = self.form_type
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formType') is not None:
            self.form_type = m.get('formType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListNavigationByFormTypeResponseBodyResultTitle(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListNavigationByFormTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        form_uuid: str = None,
        process_code: str = None,
        title: ListNavigationByFormTypeResponseBodyResultTitle = None,
    ):
        self.form_uuid = form_uuid
        self.process_code = process_code
        self.title = title

    def validate(self):
        if self.title:
            self.title.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.title is not None:
            result['title'] = self.title.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('title') is not None:
            temp_model = ListNavigationByFormTypeResponseBodyResultTitle()
            self.title = temp_model.from_map(m['title'])
        return self


class ListNavigationByFormTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListNavigationByFormTypeResponseBodyResult] = None,
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
                temp_model = ListNavigationByFormTypeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListNavigationByFormTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListNavigationByFormTypeResponseBody = None,
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
            temp_model = ListNavigationByFormTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListOperationLogsHeaders(TeaModel):
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


class ListOperationLogsRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_instance_id_list: List[str] = None,
        form_uuid: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.form_instance_id_list = form_instance_id_list
        # This parameter is required.
        self.form_uuid = form_uuid
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_instance_id_list is not None:
            result['formInstanceIdList'] = self.form_instance_id_list
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formInstanceIdList') is not None:
            self.form_instance_id_list = m.get('formInstanceIdList')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListOperationLogsResponseBody(TeaModel):
    def __init__(
        self,
        operation_log_map: Dict[str, Any] = None,
    ):
        # This parameter is required.
        self.operation_log_map = operation_log_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operation_log_map is not None:
            result['operationLogMap'] = self.operation_log_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operationLogMap') is not None:
            self.operation_log_map = m.get('operationLogMap')
        return self


class ListOperationLogsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListOperationLogsResponseBody = None,
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
            temp_model = ListOperationLogsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTableDataByFormInstanceIdTableIdHeaders(TeaModel):
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


class ListTableDataByFormInstanceIdTableIdRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_uuid: str = None,
        page_number: int = None,
        page_size: int = None,
        system_token: str = None,
        table_field_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_uuid = form_uuid
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.table_field_id = table_field_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.table_field_id is not None:
            result['tableFieldId'] = self.table_field_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('tableFieldId') is not None:
            self.table_field_id = m.get('tableFieldId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListTableDataByFormInstanceIdTableIdResponseBody(TeaModel):
    def __init__(
        self,
        data: List[Dict[str, Any]] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListTableDataByFormInstanceIdTableIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTableDataByFormInstanceIdTableIdResponseBody = None,
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
            temp_model = ListTableDataByFormInstanceIdTableIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LoginCodeGenHeaders(TeaModel):
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


class LoginCodeGenRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class LoginCodeGenResponseBody(TeaModel):
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


class LoginCodeGenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LoginCodeGenResponseBody = None,
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
            temp_model = LoginCodeGenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyAuthorizationResultHeaders(TeaModel):
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


class NotifyAuthorizationResultRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        account_number: str = None,
        begin_time_gmt: int = None,
        caller_uid: str = None,
        charge_type: str = None,
        commerce_type: str = None,
        commodity_type: str = None,
        end_time_gmt: int = None,
        instance_id: str = None,
        instance_name: str = None,
        produce_code: str = None,
    ):
        self.access_key = access_key
        self.account_number = account_number
        self.begin_time_gmt = begin_time_gmt
        self.caller_uid = caller_uid
        self.charge_type = charge_type
        self.commerce_type = commerce_type
        self.commodity_type = commodity_type
        self.end_time_gmt = end_time_gmt
        self.instance_id = instance_id
        self.instance_name = instance_name
        self.produce_code = produce_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.begin_time_gmt is not None:
            result['beginTimeGMT'] = self.begin_time_gmt
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.charge_type is not None:
            result['chargeType'] = self.charge_type
        if self.commerce_type is not None:
            result['commerceType'] = self.commerce_type
        if self.commodity_type is not None:
            result['commodityType'] = self.commodity_type
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_name is not None:
            result['instanceName'] = self.instance_name
        if self.produce_code is not None:
            result['produceCode'] = self.produce_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('beginTimeGMT') is not None:
            self.begin_time_gmt = m.get('beginTimeGMT')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('chargeType') is not None:
            self.charge_type = m.get('chargeType')
        if m.get('commerceType') is not None:
            self.commerce_type = m.get('commerceType')
        if m.get('commodityType') is not None:
            self.commodity_type = m.get('commodityType')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceName') is not None:
            self.instance_name = m.get('instanceName')
        if m.get('produceCode') is not None:
            self.produce_code = m.get('produceCode')
        return self


class NotifyAuthorizationResultResponseBody(TeaModel):
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


class NotifyAuthorizationResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyAuthorizationResultResponseBody = None,
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
            temp_model = NotifyAuthorizationResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageAutoFlowLogHeaders(TeaModel):
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


class PageAutoFlowLogRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        end_time_gmt: int = None,
        env: str = None,
        form_uuid: str = None,
        page_number: int = None,
        page_size: int = None,
        process_code: str = None,
        start_time_gmt: int = None,
        status: int = None,
        token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        # This parameter is required.
        self.corp_id = corp_id
        self.end_time_gmt = end_time_gmt
        self.env = env
        self.form_uuid = form_uuid
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.process_code = process_code
        self.start_time_gmt = start_time_gmt
        self.status = status
        # This parameter is required.
        self.token = token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        if self.env is not None:
            result['env'] = self.env
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.start_time_gmt is not None:
            result['startTimeGMT'] = self.start_time_gmt
        if self.status is not None:
            result['status'] = self.status
        if self.token is not None:
            result['token'] = self.token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('startTimeGMT') is not None:
            self.start_time_gmt = m.get('startTimeGMT')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('token') is not None:
            self.token = m.get('token')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PageAutoFlowLogResponseBodyData(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        elapsed_time_gmt: int = None,
        finish_time_gmt: str = None,
        flag: str = None,
        proc_instance_id: str = None,
        process_code: str = None,
        src_proc_instance_finish_time_gmt: str = None,
        src_proc_instance_id: str = None,
        status: int = None,
    ):
        self.app_type = app_type
        self.elapsed_time_gmt = elapsed_time_gmt
        self.finish_time_gmt = finish_time_gmt
        self.flag = flag
        self.proc_instance_id = proc_instance_id
        self.process_code = process_code
        self.src_proc_instance_finish_time_gmt = src_proc_instance_finish_time_gmt
        self.src_proc_instance_id = src_proc_instance_id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.elapsed_time_gmt is not None:
            result['elapsedTimeGMT'] = self.elapsed_time_gmt
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.flag is not None:
            result['flag'] = self.flag
        if self.proc_instance_id is not None:
            result['procInstanceId'] = self.proc_instance_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.src_proc_instance_finish_time_gmt is not None:
            result['srcProcInstanceFinishTimeGMT'] = self.src_proc_instance_finish_time_gmt
        if self.src_proc_instance_id is not None:
            result['srcProcInstanceId'] = self.src_proc_instance_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('elapsedTimeGMT') is not None:
            self.elapsed_time_gmt = m.get('elapsedTimeGMT')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('flag') is not None:
            self.flag = m.get('flag')
        if m.get('procInstanceId') is not None:
            self.proc_instance_id = m.get('procInstanceId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('srcProcInstanceFinishTimeGMT') is not None:
            self.src_proc_instance_finish_time_gmt = m.get('srcProcInstanceFinishTimeGMT')
        if m.get('srcProcInstanceId') is not None:
            self.src_proc_instance_id = m.get('srcProcInstanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PageAutoFlowLogResponseBody(TeaModel):
    def __init__(
        self,
        data: List[PageAutoFlowLogResponseBodyData] = None,
        has_more_data: bool = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.has_more_data = has_more_data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.has_more_data is not None:
            result['hasMoreData'] = self.has_more_data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = PageAutoFlowLogResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMoreData') is not None:
            self.has_more_data = m.get('hasMoreData')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PageAutoFlowLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PageAutoFlowLogResponseBody = None,
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
            temp_model = PageAutoFlowLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageFormBaseInfosHeaders(TeaModel):
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


class PageFormBaseInfosRequest(TeaModel):
    def __init__(
        self,
        app_key: str = None,
        form_type_list: List[str] = None,
        language: str = None,
        page_index: int = None,
        page_size: int = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_key = app_key
        self.form_type_list = form_type_list
        self.language = language
        # This parameter is required.
        self.page_index = page_index
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.form_type_list is not None:
            result['formTypeList'] = self.form_type_list
        if self.language is not None:
            result['language'] = self.language
        if self.page_index is not None:
            result['pageIndex'] = self.page_index
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('formTypeList') is not None:
            self.form_type_list = m.get('formTypeList')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('pageIndex') is not None:
            self.page_index = m.get('pageIndex')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PageFormBaseInfosResponseBodyResultDataTitle(TeaModel):
    def __init__(
        self,
        en_us: str = None,
        zh_cn: str = None,
    ):
        self.en_us = en_us
        self.zh_cn = zh_cn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.en_us is not None:
            result['enUS'] = self.en_us
        if self.zh_cn is not None:
            result['zhCN'] = self.zh_cn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enUS') is not None:
            self.en_us = m.get('enUS')
        if m.get('zhCN') is not None:
            self.zh_cn = m.get('zhCN')
        return self


class PageFormBaseInfosResponseBodyResultData(TeaModel):
    def __init__(
        self,
        creator: str = None,
        form_type: str = None,
        form_uuid: str = None,
        gmt_create: str = None,
        title: PageFormBaseInfosResponseBodyResultDataTitle = None,
    ):
        self.creator = creator
        self.form_type = form_type
        self.form_uuid = form_uuid
        self.gmt_create = gmt_create
        self.title = title

    def validate(self):
        if self.title:
            self.title.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.form_type is not None:
            result['formType'] = self.form_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.title is not None:
            result['title'] = self.title.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('formType') is not None:
            self.form_type = m.get('formType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('title') is not None:
            temp_model = PageFormBaseInfosResponseBodyResultDataTitle()
            self.title = temp_model.from_map(m['title'])
        return self


class PageFormBaseInfosResponseBodyResult(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        data: List[PageFormBaseInfosResponseBodyResultData] = None,
        total_count: int = None,
    ):
        self.current_page = current_page
        self.data = data
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = PageFormBaseInfosResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class PageFormBaseInfosResponseBody(TeaModel):
    def __init__(
        self,
        result: PageFormBaseInfosResponseBodyResult = None,
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
            temp_model = PageFormBaseInfosResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PageFormBaseInfosResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PageFormBaseInfosResponseBody = None,
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
            temp_model = PageFormBaseInfosResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreviewPublishedProcessHeaders(TeaModel):
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


class PreviewPublishedProcessRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        department_id: str = None,
        form_data_json: str = None,
        form_uuid: str = None,
        language: str = None,
        process_code: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.department_id = department_id
        # This parameter is required.
        self.form_data_json = form_data_json
        # This parameter is required.
        self.form_uuid = form_uuid
        self.language = language
        self.process_code = process_code
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PreviewPublishedProcessResponseBodyResult(TeaModel):
    def __init__(
        self,
        action: str = None,
        action_exit: str = None,
        active_time_gmt: str = None,
        activity_id: str = None,
        data_id: int = None,
        digital_sign: str = None,
        domains: List[Any] = None,
        files: str = None,
        operate_time_gmt: str = None,
        operate_type: str = None,
        operator_display_name: str = None,
        operator_name: str = None,
        operator_nick_name: str = None,
        operator_photo_url: str = None,
        operator_status: str = None,
        operator_user_id: str = None,
        process_instance_id: str = None,
        remark: str = None,
        show_name: str = None,
        size: int = None,
        task_execute_type: str = None,
        task_hold_time_gmt: int = None,
        task_id: str = None,
        task_type: str = None,
        type: str = None,
    ):
        self.action = action
        self.action_exit = action_exit
        self.active_time_gmt = active_time_gmt
        self.activity_id = activity_id
        self.data_id = data_id
        self.digital_sign = digital_sign
        self.domains = domains
        self.files = files
        self.operate_time_gmt = operate_time_gmt
        self.operate_type = operate_type
        self.operator_display_name = operator_display_name
        self.operator_name = operator_name
        self.operator_nick_name = operator_nick_name
        self.operator_photo_url = operator_photo_url
        self.operator_status = operator_status
        self.operator_user_id = operator_user_id
        self.process_instance_id = process_instance_id
        self.remark = remark
        self.show_name = show_name
        self.size = size
        self.task_execute_type = task_execute_type
        self.task_hold_time_gmt = task_hold_time_gmt
        self.task_id = task_id
        self.task_type = task_type
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.action_exit is not None:
            result['actionExit'] = self.action_exit
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.digital_sign is not None:
            result['digitalSign'] = self.digital_sign
        if self.domains is not None:
            result['domains'] = self.domains
        if self.files is not None:
            result['files'] = self.files
        if self.operate_time_gmt is not None:
            result['operateTimeGMT'] = self.operate_time_gmt
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_display_name is not None:
            result['operatorDisplayName'] = self.operator_display_name
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.operator_nick_name is not None:
            result['operatorNickName'] = self.operator_nick_name
        if self.operator_photo_url is not None:
            result['operatorPhotoUrl'] = self.operator_photo_url
        if self.operator_status is not None:
            result['operatorStatus'] = self.operator_status
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.size is not None:
            result['size'] = self.size
        if self.task_execute_type is not None:
            result['taskExecuteType'] = self.task_execute_type
        if self.task_hold_time_gmt is not None:
            result['taskHoldTimeGMT'] = self.task_hold_time_gmt
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionExit') is not None:
            self.action_exit = m.get('actionExit')
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('digitalSign') is not None:
            self.digital_sign = m.get('digitalSign')
        if m.get('domains') is not None:
            self.domains = m.get('domains')
        if m.get('files') is not None:
            self.files = m.get('files')
        if m.get('operateTimeGMT') is not None:
            self.operate_time_gmt = m.get('operateTimeGMT')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorDisplayName') is not None:
            self.operator_display_name = m.get('operatorDisplayName')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('operatorNickName') is not None:
            self.operator_nick_name = m.get('operatorNickName')
        if m.get('operatorPhotoUrl') is not None:
            self.operator_photo_url = m.get('operatorPhotoUrl')
        if m.get('operatorStatus') is not None:
            self.operator_status = m.get('operatorStatus')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('taskExecuteType') is not None:
            self.task_execute_type = m.get('taskExecuteType')
        if m.get('taskHoldTimeGMT') is not None:
            self.task_hold_time_gmt = m.get('taskHoldTimeGMT')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PreviewPublishedProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: List[PreviewPublishedProcessResponseBodyResult] = None,
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
                temp_model = PreviewPublishedProcessResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class PreviewPublishedProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreviewPublishedProcessResponseBody = None,
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
            temp_model = PreviewPublishedProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryServiceRecordHeaders(TeaModel):
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


class QueryServiceRecordRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_uuid: str = None,
        hook_type: str = None,
        hook_uuid: str = None,
        instance_id: str = None,
        invoke_after_date_gmt: str = None,
        invoke_before_date_gmt: str = None,
        invoke_status: str = None,
        page_number: int = None,
        page_size: int = None,
        request_url: str = None,
        source_uuid: str = None,
        success: bool = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_uuid = form_uuid
        self.hook_type = hook_type
        self.hook_uuid = hook_uuid
        # This parameter is required.
        self.instance_id = instance_id
        self.invoke_after_date_gmt = invoke_after_date_gmt
        self.invoke_before_date_gmt = invoke_before_date_gmt
        self.invoke_status = invoke_status
        self.page_number = page_number
        self.page_size = page_size
        self.request_url = request_url
        self.source_uuid = source_uuid
        self.success = success
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.hook_type is not None:
            result['hookType'] = self.hook_type
        if self.hook_uuid is not None:
            result['hookUuid'] = self.hook_uuid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.invoke_after_date_gmt is not None:
            result['invokeAfterDateGMT'] = self.invoke_after_date_gmt
        if self.invoke_before_date_gmt is not None:
            result['invokeBeforeDateGMT'] = self.invoke_before_date_gmt
        if self.invoke_status is not None:
            result['invokeStatus'] = self.invoke_status
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.request_url is not None:
            result['requestUrl'] = self.request_url
        if self.source_uuid is not None:
            result['sourceUuid'] = self.source_uuid
        if self.success is not None:
            result['success'] = self.success
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('hookType') is not None:
            self.hook_type = m.get('hookType')
        if m.get('hookUuid') is not None:
            self.hook_uuid = m.get('hookUuid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('invokeAfterDateGMT') is not None:
            self.invoke_after_date_gmt = m.get('invokeAfterDateGMT')
        if m.get('invokeBeforeDateGMT') is not None:
            self.invoke_before_date_gmt = m.get('invokeBeforeDateGMT')
        if m.get('invokeStatus') is not None:
            self.invoke_status = m.get('invokeStatus')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('requestUrl') is not None:
            self.request_url = m.get('requestUrl')
        if m.get('sourceUuid') is not None:
            self.source_uuid = m.get('sourceUuid')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryServiceRecordResponseBodyValues(TeaModel):
    def __init__(
        self,
        form_instance_id: str = None,
        form_uuid: str = None,
        hook_type: str = None,
        hook_uuid: str = None,
        invoke_parameter: str = None,
        invoke_result: str = None,
        invoke_status: str = None,
        invoke_success: str = None,
        invoke_url: str = None,
        service_content: str = None,
        service_name: str = None,
        service_parameter: str = None,
        source_uuid: str = None,
    ):
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.hook_type = hook_type
        self.hook_uuid = hook_uuid
        self.invoke_parameter = invoke_parameter
        self.invoke_result = invoke_result
        self.invoke_status = invoke_status
        self.invoke_success = invoke_success
        self.invoke_url = invoke_url
        self.service_content = service_content
        self.service_name = service_name
        self.service_parameter = service_parameter
        self.source_uuid = source_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.hook_type is not None:
            result['hookType'] = self.hook_type
        if self.hook_uuid is not None:
            result['hookUuid'] = self.hook_uuid
        if self.invoke_parameter is not None:
            result['invokeParameter'] = self.invoke_parameter
        if self.invoke_result is not None:
            result['invokeResult'] = self.invoke_result
        if self.invoke_status is not None:
            result['invokeStatus'] = self.invoke_status
        if self.invoke_success is not None:
            result['invokeSuccess'] = self.invoke_success
        if self.invoke_url is not None:
            result['invokeUrl'] = self.invoke_url
        if self.service_content is not None:
            result['serviceContent'] = self.service_content
        if self.service_name is not None:
            result['serviceName'] = self.service_name
        if self.service_parameter is not None:
            result['serviceParameter'] = self.service_parameter
        if self.source_uuid is not None:
            result['sourceUuid'] = self.source_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('hookType') is not None:
            self.hook_type = m.get('hookType')
        if m.get('hookUuid') is not None:
            self.hook_uuid = m.get('hookUuid')
        if m.get('invokeParameter') is not None:
            self.invoke_parameter = m.get('invokeParameter')
        if m.get('invokeResult') is not None:
            self.invoke_result = m.get('invokeResult')
        if m.get('invokeStatus') is not None:
            self.invoke_status = m.get('invokeStatus')
        if m.get('invokeSuccess') is not None:
            self.invoke_success = m.get('invokeSuccess')
        if m.get('invokeUrl') is not None:
            self.invoke_url = m.get('invokeUrl')
        if m.get('serviceContent') is not None:
            self.service_content = m.get('serviceContent')
        if m.get('serviceName') is not None:
            self.service_name = m.get('serviceName')
        if m.get('serviceParameter') is not None:
            self.service_parameter = m.get('serviceParameter')
        if m.get('sourceUuid') is not None:
            self.source_uuid = m.get('sourceUuid')
        return self


class QueryServiceRecordResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        values: List[QueryServiceRecordResponseBodyValues] = None,
    ):
        self.total_count = total_count
        self.values = values

    def validate(self):
        if self.values:
            for k in self.values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = QueryServiceRecordResponseBodyValues()
                self.values.append(temp_model.from_map(k))
        return self


class QueryServiceRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryServiceRecordResponseBody = None,
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
            temp_model = QueryServiceRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RedirectTaskHeaders(TeaModel):
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


class RedirectTaskRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        by_manager: str = None,
        language: str = None,
        now_action_executor_id: str = None,
        process_instance_id: str = None,
        remark: str = None,
        system_token: str = None,
        task_id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.by_manager = by_manager
        self.language = language
        # This parameter is required.
        self.now_action_executor_id = now_action_executor_id
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.task_id = task_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.by_manager is not None:
            result['byManager'] = self.by_manager
        if self.language is not None:
            result['language'] = self.language
        if self.now_action_executor_id is not None:
            result['nowActionExecutorId'] = self.now_action_executor_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('byManager') is not None:
            self.by_manager = m.get('byManager')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('nowActionExecutorId') is not None:
            self.now_action_executor_id = m.get('nowActionExecutorId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class RedirectTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class RefundCommodityHeaders(TeaModel):
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


class RefundCommodityRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class RefundCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        self.message = message
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RefundCommodityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RefundCommodityResponseBody = None,
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
            temp_model = RefundCommodityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterAccountsHeaders(TeaModel):
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


class RegisterAccountsRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        active_code: str = None,
        corp_id: str = None,
    ):
        self.access_key = access_key
        self.active_code = active_code
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.active_code is not None:
            result['activeCode'] = self.active_code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('activeCode') is not None:
            self.active_code = m.get('activeCode')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class RegisterAccountsResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class RegisterAccountsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RegisterAccountsResponseBody = None,
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
            temp_model = RegisterAccountsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReleaseCommodityHeaders(TeaModel):
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


class ReleaseCommodityRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class ReleaseCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        self.message = message
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ReleaseCommodityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReleaseCommodityResponseBody = None,
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
            temp_model = ReleaseCommodityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveTenantResourceHeaders(TeaModel):
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


class RemoveTenantResourceRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
    ):
        self.access_key = access_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        return self


class RemoveTenantResourceResponseBody(TeaModel):
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


class RemoveTenantResourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveTenantResourceResponseBody = None,
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
            temp_model = RemoveTenantResourceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RenderBatchCallbackHeaders(TeaModel):
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


class RenderBatchCallbackRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        corp_id: str = None,
        file_size: int = None,
        language: str = None,
        namespace: str = None,
        oss_url: str = None,
        sequence_id: str = None,
        source: str = None,
        status: str = None,
        system_token: str = None,
        time_zone: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.corp_id = corp_id
        self.file_size = file_size
        self.language = language
        self.namespace = namespace
        self.oss_url = oss_url
        self.sequence_id = sequence_id
        self.source = source
        self.status = status
        self.system_token = system_token
        self.time_zone = time_zone
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.language is not None:
            result['language'] = self.language
        if self.namespace is not None:
            result['namespace'] = self.namespace
        if self.oss_url is not None:
            result['ossUrl'] = self.oss_url
        if self.sequence_id is not None:
            result['sequenceId'] = self.sequence_id
        if self.source is not None:
            result['source'] = self.source
        if self.status is not None:
            result['status'] = self.status
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('namespace') is not None:
            self.namespace = m.get('namespace')
        if m.get('ossUrl') is not None:
            self.oss_url = m.get('ossUrl')
        if m.get('sequenceId') is not None:
            self.sequence_id = m.get('sequenceId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class RenderBatchCallbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class RenewApplicationAuthorizationServiceOrderHeaders(TeaModel):
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


class RenewApplicationAuthorizationServiceOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_union_id: str = None,
        end_time_gmt: int = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_union_id = caller_union_id
        self.end_time_gmt = end_time_gmt
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class RenewApplicationAuthorizationServiceOrderResponseBody(TeaModel):
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


class RenewApplicationAuthorizationServiceOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RenewApplicationAuthorizationServiceOrderResponseBody = None,
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
            temp_model = RenewApplicationAuthorizationServiceOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RenewTenantOrderHeaders(TeaModel):
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


class RenewTenantOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_union_id: str = None,
        end_time_gmt: int = None,
    ):
        self.access_key = access_key
        self.caller_union_id = caller_union_id
        self.end_time_gmt = end_time_gmt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.end_time_gmt is not None:
            result['endTimeGMT'] = self.end_time_gmt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('endTimeGMT') is not None:
            self.end_time_gmt = m.get('endTimeGMT')
        return self


class RenewTenantOrderResponseBody(TeaModel):
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


class RenewTenantOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RenewTenantOrderResponseBody = None,
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
            temp_model = RenewTenantOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveFormDataHeaders(TeaModel):
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


class SaveFormDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_data_json: str = None,
        form_uuid: str = None,
        language: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        # This parameter is required.
        self.form_data_json = form_data_json
        # This parameter is required.
        self.form_uuid = form_uuid
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SaveFormDataResponseBody(TeaModel):
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


class SaveFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveFormDataResponseBody = None,
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
            temp_model = SaveFormDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveFormRemarkHeaders(TeaModel):
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


class SaveFormRemarkRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        at_user_id: str = None,
        content: str = None,
        form_instance_id: str = None,
        language: str = None,
        reply_id: int = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.at_user_id = at_user_id
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.language = language
        self.reply_id = reply_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.at_user_id is not None:
            result['atUserId'] = self.at_user_id
        if self.content is not None:
            result['content'] = self.content
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.language is not None:
            result['language'] = self.language
        if self.reply_id is not None:
            result['replyId'] = self.reply_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('atUserId') is not None:
            self.at_user_id = m.get('atUserId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('replyId') is not None:
            self.reply_id = m.get('replyId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SaveFormRemarkResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
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


class SaveFormRemarkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveFormRemarkResponseBody = None,
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
            temp_model = SaveFormRemarkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SavePrintTplDetailInfoHeaders(TeaModel):
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


class SavePrintTplDetailInfoRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        description: str = None,
        file_name_config: str = None,
        form_uuid: str = None,
        form_version: int = None,
        setting: str = None,
        template_id: int = None,
        title: str = None,
        user_id: str = None,
        vm: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.description = description
        self.file_name_config = file_name_config
        # This parameter is required.
        self.form_uuid = form_uuid
        self.form_version = form_version
        self.setting = setting
        self.template_id = template_id
        self.title = title
        # This parameter is required.
        self.user_id = user_id
        self.vm = vm

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.description is not None:
            result['description'] = self.description
        if self.file_name_config is not None:
            result['fileNameConfig'] = self.file_name_config
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.form_version is not None:
            result['formVersion'] = self.form_version
        if self.setting is not None:
            result['setting'] = self.setting
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.vm is not None:
            result['vm'] = self.vm
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('fileNameConfig') is not None:
            self.file_name_config = m.get('fileNameConfig')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('formVersion') is not None:
            self.form_version = m.get('formVersion')
        if m.get('setting') is not None:
            self.setting = m.get('setting')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('vm') is not None:
            self.vm = m.get('vm')
        return self


class SavePrintTplDetailInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
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


class SavePrintTplDetailInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SavePrintTplDetailInfoResponseBody = None,
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
            temp_model = SavePrintTplDetailInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchActivationCodeHeaders(TeaModel):
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


class SearchActivationCodeRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.access_key = access_key
        # This parameter is required.
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class SearchActivationCodeResponseBody(TeaModel):
    def __init__(
        self,
        activation_code: str = None,
        auth_type: str = None,
        expire_time_gmt: str = None,
        instance_id: str = None,
        status: int = None,
    ):
        self.activation_code = activation_code
        self.auth_type = auth_type
        self.expire_time_gmt = expire_time_gmt
        self.instance_id = instance_id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activation_code is not None:
            result['activationCode'] = self.activation_code
        if self.auth_type is not None:
            result['authType'] = self.auth_type
        if self.expire_time_gmt is not None:
            result['expireTimeGMT'] = self.expire_time_gmt
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activationCode') is not None:
            self.activation_code = m.get('activationCode')
        if m.get('authType') is not None:
            self.auth_type = m.get('authType')
        if m.get('expireTimeGMT') is not None:
            self.expire_time_gmt = m.get('expireTimeGMT')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SearchActivationCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchActivationCodeResponseBody = None,
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
            temp_model = SearchActivationCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchEmployeeFieldValuesHeaders(TeaModel):
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


class SearchEmployeeFieldValuesRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        language: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        originator_id: str = None,
        search_field_json: str = None,
        system_token: str = None,
        target_field_json: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.form_uuid = form_uuid
        self.language = language
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.originator_id = originator_id
        self.search_field_json = search_field_json
        self.system_token = system_token
        self.target_field_json = target_field_json
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.target_field_json is not None:
            result['targetFieldJson'] = self.target_field_json
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('targetFieldJson') is not None:
            self.target_field_json = m.get('targetFieldJson')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchEmployeeFieldValuesResponseBody(TeaModel):
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


class SearchEmployeeFieldValuesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchEmployeeFieldValuesResponseBody = None,
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
            temp_model = SearchEmployeeFieldValuesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchFormDataIdListHeaders(TeaModel):
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


class SearchFormDataIdListRequest(TeaModel):
    def __init__(
        self,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        language: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        originator_id: str = None,
        search_field_json: str = None,
        system_token: str = None,
        user_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.language = language
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.originator_id = originator_id
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.language is not None:
            result['language'] = self.language
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class SearchFormDataIdListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[str] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchFormDataIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchFormDataIdListResponseBody = None,
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
            temp_model = SearchFormDataIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchFormDataRemovalTableDataHeaders(TeaModel):
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


class SearchFormDataRemovalTableDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        order_config_json: str = None,
        originator_id: str = None,
        page_number: int = None,
        page_size: int = None,
        search_field_json: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        # This parameter is required.
        self.form_uuid = form_uuid
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.order_config_json = order_config_json
        self.originator_id = originator_id
        self.page_number = page_number
        self.page_size = page_size
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.order_config_json is not None:
            result['orderConfigJson'] = self.order_config_json
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('orderConfigJson') is not None:
            self.order_config_json = m.get('orderConfigJson')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataRemovalTableDataResponseBodyDataModifyUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataRemovalTableDataResponseBodyDataModifyUser(TeaModel):
    def __init__(
        self,
        department_name: str = None,
        email: str = None,
        name: SearchFormDataRemovalTableDataResponseBodyDataModifyUserName = None,
        user_id: str = None,
    ):
        self.department_name = department_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = SearchFormDataRemovalTableDataResponseBodyDataModifyUserName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataRemovalTableDataResponseBodyDataOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataRemovalTableDataResponseBodyDataOriginator(TeaModel):
    def __init__(
        self,
        department_name: str = None,
        email: str = None,
        name: SearchFormDataRemovalTableDataResponseBodyDataOriginatorName = None,
        user_id: str = None,
    ):
        self.department_name = department_name
        self.email = email
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            temp_model = SearchFormDataRemovalTableDataResponseBodyDataOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataRemovalTableDataResponseBodyData(TeaModel):
    def __init__(
        self,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        form_data: Dict[str, Any] = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        id: int = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        modify_user: SearchFormDataRemovalTableDataResponseBodyDataModifyUser = None,
        originator: SearchFormDataRemovalTableDataResponseBodyDataOriginator = None,
        sequence: str = None,
        serial_number: str = None,
        title: str = None,
        version: int = None,
    ):
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.form_data = form_data
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.id = id
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.modify_user = modify_user
        self.originator = originator
        self.sequence = sequence
        self.serial_number = serial_number
        self.title = title
        self.version = version

    def validate(self):
        if self.modify_user:
            self.modify_user.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.id is not None:
            result['id'] = self.id
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyUser') is not None:
            temp_model = SearchFormDataRemovalTableDataResponseBodyDataModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('originator') is not None:
            temp_model = SearchFormDataRemovalTableDataResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SearchFormDataRemovalTableDataResponseBody(TeaModel):
    def __init__(
        self,
        data: List[SearchFormDataRemovalTableDataResponseBodyData] = None,
        has_more_data: bool = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.has_more_data = has_more_data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.has_more_data is not None:
            result['hasMoreData'] = self.has_more_data
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SearchFormDataRemovalTableDataResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMoreData') is not None:
            self.has_more_data = m.get('hasMoreData')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchFormDataRemovalTableDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchFormDataRemovalTableDataResponseBody = None,
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
            temp_model = SearchFormDataRemovalTableDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchFormDataSecondGenerationHeaders(TeaModel):
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


class SearchFormDataSecondGenerationRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        order_config_json: str = None,
        originator_id: str = None,
        page_number: int = None,
        page_size: int = None,
        search_condition: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        # This parameter is required.
        self.form_uuid = form_uuid
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.order_config_json = order_config_json
        self.originator_id = originator_id
        self.page_number = page_number
        self.page_size = page_size
        self.search_condition = search_condition
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.order_config_json is not None:
            result['orderConfigJson'] = self.order_config_json
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_condition is not None:
            result['searchCondition'] = self.search_condition
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('orderConfigJson') is not None:
            self.order_config_json = m.get('orderConfigJson')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchCondition') is not None:
            self.search_condition = m.get('searchCondition')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationResponseBodyDataModifyUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataSecondGenerationResponseBodyDataModifyUser(TeaModel):
    def __init__(
        self,
        name: SearchFormDataSecondGenerationResponseBodyDataModifyUserName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = SearchFormDataSecondGenerationResponseBodyDataModifyUserName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationResponseBodyDataOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataSecondGenerationResponseBodyDataOriginator(TeaModel):
    def __init__(
        self,
        name: SearchFormDataSecondGenerationResponseBodyDataOriginatorName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = SearchFormDataSecondGenerationResponseBodyDataOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationResponseBodyData(TeaModel):
    def __init__(
        self,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        form_data: Dict[str, Any] = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        id: int = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        modify_user: SearchFormDataSecondGenerationResponseBodyDataModifyUser = None,
        originator: SearchFormDataSecondGenerationResponseBodyDataOriginator = None,
        sequence: str = None,
        serial_number: str = None,
        title: str = None,
        version: int = None,
    ):
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.form_data = form_data
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.id = id
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.modify_user = modify_user
        self.originator = originator
        self.sequence = sequence
        self.serial_number = serial_number
        self.title = title
        self.version = version

    def validate(self):
        if self.modify_user:
            self.modify_user.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.id is not None:
            result['id'] = self.id
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyUser') is not None:
            temp_model = SearchFormDataSecondGenerationResponseBodyDataModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('originator') is not None:
            temp_model = SearchFormDataSecondGenerationResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SearchFormDataSecondGenerationResponseBody(TeaModel):
    def __init__(
        self,
        data: List[SearchFormDataSecondGenerationResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SearchFormDataSecondGenerationResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchFormDataSecondGenerationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchFormDataSecondGenerationResponseBody = None,
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
            temp_model = SearchFormDataSecondGenerationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchFormDataSecondGenerationNoTableFieldHeaders(TeaModel):
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


class SearchFormDataSecondGenerationNoTableFieldRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        form_uuid: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        order_config_json: str = None,
        originator_id: str = None,
        page_number: int = None,
        page_size: int = None,
        search_condition: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        # This parameter is required.
        self.form_uuid = form_uuid
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.order_config_json = order_config_json
        self.originator_id = originator_id
        self.page_number = page_number
        self.page_size = page_size
        self.search_condition = search_condition
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.order_config_json is not None:
            result['orderConfigJson'] = self.order_config_json
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_condition is not None:
            result['searchCondition'] = self.search_condition
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('orderConfigJson') is not None:
            self.order_config_json = m.get('orderConfigJson')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchCondition') is not None:
            self.search_condition = m.get('searchCondition')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser(TeaModel):
    def __init__(
        self,
        name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUserName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator(TeaModel):
    def __init__(
        self,
        name: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBodyData(TeaModel):
    def __init__(
        self,
        create_time_gmt: str = None,
        creator_user_id: str = None,
        form_data: Dict[str, Any] = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        id: int = None,
        instance_value: str = None,
        modified_time_gmt: str = None,
        modifier: str = None,
        modify_user: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser = None,
        originator: SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator = None,
        sequence: str = None,
        serial_number: str = None,
        title: str = None,
        version: int = None,
    ):
        self.create_time_gmt = create_time_gmt
        self.creator_user_id = creator_user_id
        self.form_data = form_data
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.id = id
        self.instance_value = instance_value
        self.modified_time_gmt = modified_time_gmt
        self.modifier = modifier
        self.modify_user = modify_user
        self.originator = originator
        self.sequence = sequence
        self.serial_number = serial_number
        self.title = title
        self.version = version

    def validate(self):
        if self.modify_user:
            self.modify_user.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.id is not None:
            result['id'] = self.id
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier is not None:
            result['modifier'] = self.modifier
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifier') is not None:
            self.modifier = m.get('modifier')
        if m.get('modifyUser') is not None:
            temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBodyDataModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('originator') is not None:
            temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponseBody(TeaModel):
    def __init__(
        self,
        data: List[SearchFormDataSecondGenerationNoTableFieldResponseBodyData] = None,
        page_number: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchFormDataSecondGenerationNoTableFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchFormDataSecondGenerationNoTableFieldResponseBody = None,
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
            temp_model = SearchFormDataSecondGenerationNoTableFieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchFormDatasHeaders(TeaModel):
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


class SearchFormDatasRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        current_page: int = None,
        dynamic_order: str = None,
        form_uuid: str = None,
        language: str = None,
        logic_operator: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        originator_id: str = None,
        page_size: int = None,
        search_field_json: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.create_from_time_gmt = create_from_time_gmt
        self.create_to_time_gmt = create_to_time_gmt
        self.current_page = current_page
        self.dynamic_order = dynamic_order
        # This parameter is required.
        self.form_uuid = form_uuid
        self.language = language
        self.logic_operator = logic_operator
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.originator_id = originator_id
        self.page_size = page_size
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.dynamic_order is not None:
            result['dynamicOrder'] = self.dynamic_order
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.logic_operator is not None:
            result['logicOperator'] = self.logic_operator
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('dynamicOrder') is not None:
            self.dynamic_order = m.get('dynamicOrder')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('logicOperator') is not None:
            self.logic_operator = m.get('logicOperator')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchFormDatasResponseBodyDataModifyUserUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SearchFormDatasResponseBodyDataModifyUser(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        user_name: SearchFormDatasResponseBodyDataModifyUserUserName = None,
    ):
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        if self.user_name:
            self.user_name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            temp_model = SearchFormDatasResponseBodyDataModifyUserUserName()
            self.user_name = temp_model.from_map(m['userName'])
        return self


class SearchFormDatasResponseBodyDataOriginatorUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        self.name_in_chinese = name_in_chinese
        self.name_in_english = name_in_english
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SearchFormDatasResponseBodyDataOriginator(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        user_name: SearchFormDatasResponseBodyDataOriginatorUserName = None,
    ):
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        if self.user_name:
            self.user_name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            temp_model = SearchFormDatasResponseBodyDataOriginatorUserName()
            self.user_name = temp_model.from_map(m['userName'])
        return self


class SearchFormDatasResponseBodyData(TeaModel):
    def __init__(
        self,
        created_time_gmt: str = None,
        creator_user_id: str = None,
        data_id: int = None,
        form_data: Dict[str, Any] = None,
        form_instance_id: str = None,
        form_uuid: str = None,
        instance_value: str = None,
        model_uuid: str = None,
        modified_time_gmt: str = None,
        modifier_user_id: str = None,
        modify_user: SearchFormDatasResponseBodyDataModifyUser = None,
        originator: SearchFormDatasResponseBodyDataOriginator = None,
        sequence: str = None,
        serial_no: str = None,
        title: str = None,
        version: int = None,
    ):
        self.created_time_gmt = created_time_gmt
        self.creator_user_id = creator_user_id
        self.data_id = data_id
        self.form_data = form_data
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.instance_value = instance_value
        self.model_uuid = model_uuid
        self.modified_time_gmt = modified_time_gmt
        self.modifier_user_id = modifier_user_id
        self.modify_user = modify_user
        self.originator = originator
        self.sequence = sequence
        self.serial_no = serial_no
        self.title = title
        self.version = version

    def validate(self):
        if self.modify_user:
            self.modify_user.validate()
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_time_gmt is not None:
            result['createdTimeGMT'] = self.created_time_gmt
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.model_uuid is not None:
            result['modelUuid'] = self.model_uuid
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.modifier_user_id is not None:
            result['modifierUserId'] = self.modifier_user_id
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.title is not None:
            result['title'] = self.title
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdTimeGMT') is not None:
            self.created_time_gmt = m.get('createdTimeGMT')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('modelUuid') is not None:
            self.model_uuid = m.get('modelUuid')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('modifierUserId') is not None:
            self.modifier_user_id = m.get('modifierUserId')
        if m.get('modifyUser') is not None:
            temp_model = SearchFormDatasResponseBodyDataModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('originator') is not None:
            temp_model = SearchFormDatasResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SearchFormDatasResponseBody(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        data: List[SearchFormDatasResponseBodyData] = None,
        total_count: int = None,
    ):
        self.current_page = current_page
        self.data = data
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SearchFormDatasResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchFormDatasResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchFormDatasResponseBody = None,
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
            temp_model = SearchFormDatasResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartInstanceHeaders(TeaModel):
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


class StartInstanceRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        department_id: str = None,
        form_data_json: str = None,
        form_uuid: str = None,
        language: str = None,
        process_code: str = None,
        process_data: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.department_id = department_id
        # This parameter is required.
        self.form_data_json = form_data_json
        # This parameter is required.
        self.form_uuid = form_uuid
        self.language = language
        self.process_code = process_code
        self.process_data = process_data
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_data is not None:
            result['processData'] = self.process_data
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processData') is not None:
            self.process_data = m.get('processData')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class StartInstanceResponseBody(TeaModel):
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


class StartInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartInstanceResponseBody = None,
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
            temp_model = StartInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TerminateCloudAuthorizationHeaders(TeaModel):
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


class TerminateCloudAuthorizationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_union_id: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_union_id = caller_union_id
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class TerminateCloudAuthorizationResponseBody(TeaModel):
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


class TerminateCloudAuthorizationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TerminateCloudAuthorizationResponseBody = None,
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
            temp_model = TerminateCloudAuthorizationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TerminateInstanceHeaders(TeaModel):
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


class TerminateInstanceRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_id: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TerminateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateCloudAccountInformationHeaders(TeaModel):
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


class UpdateCloudAccountInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        account_number: str = None,
        caller_union_id: str = None,
        commodity_type: str = None,
    ):
        self.access_key = access_key
        self.account_number = account_number
        self.caller_union_id = caller_union_id
        self.commodity_type = commodity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.commodity_type is not None:
            result['commodityType'] = self.commodity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('commodityType') is not None:
            self.commodity_type = m.get('commodityType')
        return self


class UpdateCloudAccountInformationResponseBody(TeaModel):
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


class UpdateCloudAccountInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateCloudAccountInformationResponseBody = None,
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
            temp_model = UpdateCloudAccountInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFormDataHeaders(TeaModel):
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


class UpdateFormDataRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        form_instance_id: str = None,
        language: str = None,
        system_token: str = None,
        update_form_data_json: str = None,
        use_latest_version: bool = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.update_form_data_json = update_form_data_json
        self.use_latest_version = use_latest_version
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        if self.use_latest_version is not None:
            result['useLatestVersion'] = self.use_latest_version
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        if m.get('useLatestVersion') is not None:
            self.use_latest_version = m.get('useLatestVersion')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateInstanceHeaders(TeaModel):
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


class UpdateInstanceRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        language: str = None,
        process_instance_id: str = None,
        system_token: str = None,
        update_form_data_json: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.language = language
        # This parameter is required.
        self.process_instance_id = process_instance_id
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.update_form_data_json = update_form_data_json
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateStatusHeaders(TeaModel):
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


class UpdateStatusRequest(TeaModel):
    def __init__(
        self,
        app_type: str = None,
        error_lines: List[int] = None,
        import_sequence: str = None,
        language: str = None,
        status: str = None,
        system_token: str = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.error_lines = error_lines
        self.import_sequence = import_sequence
        self.language = language
        self.status = status
        self.system_token = system_token
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.error_lines is not None:
            result['errorLines'] = self.error_lines
        if self.import_sequence is not None:
            result['importSequence'] = self.import_sequence
        if self.language is not None:
            result['language'] = self.language
        if self.status is not None:
            result['status'] = self.status
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('errorLines') is not None:
            self.error_lines = m.get('errorLines')
        if m.get('importSequence') is not None:
            self.import_sequence = m.get('importSequence')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpgradeTenantInformationHeaders(TeaModel):
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


class UpgradeTenantInformationRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        account_number: str = None,
        caller_union_id: str = None,
        commodity_type: str = None,
    ):
        self.access_key = access_key
        self.account_number = account_number
        self.caller_union_id = caller_union_id
        self.commodity_type = commodity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        if self.commodity_type is not None:
            result['commodityType'] = self.commodity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        if m.get('commodityType') is not None:
            self.commodity_type = m.get('commodityType')
        return self


class UpgradeTenantInformationResponseBody(TeaModel):
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


class UpgradeTenantInformationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpgradeTenantInformationResponseBody = None,
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
            temp_model = UpgradeTenantInformationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateApplicationAuthorizationOrderHeaders(TeaModel):
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


class ValidateApplicationAuthorizationOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_union_id: str = None,
    ):
        self.access_key = access_key
        self.caller_union_id = caller_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_union_id is not None:
            result['callerUnionId'] = self.caller_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUnionId') is not None:
            self.caller_union_id = m.get('callerUnionId')
        return self


class ValidateApplicationAuthorizationOrderResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateApplicationAuthorizationOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateApplicationAuthorizationOrderResponseBody = None,
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
            temp_model = ValidateApplicationAuthorizationOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateApplicationAuthorizationServiceOrderHeaders(TeaModel):
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


class ValidateApplicationAuthorizationServiceOrderRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
    ):
        self.access_key = access_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        return self


class ValidateApplicationAuthorizationServiceOrderResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateApplicationAuthorizationServiceOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateApplicationAuthorizationServiceOrderResponseBody = None,
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
            temp_model = ValidateApplicationAuthorizationServiceOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateApplicationServiceOrderUpgradeHeaders(TeaModel):
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


class ValidateApplicationServiceOrderUpgradeRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
    ):
        self.access_key = access_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        return self


class ValidateApplicationServiceOrderUpgradeResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateApplicationServiceOrderUpgradeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateApplicationServiceOrderUpgradeResponseBody = None,
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
            temp_model = ValidateApplicationServiceOrderUpgradeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateOrderBuyHeaders(TeaModel):
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


class ValidateOrderBuyRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class ValidateOrderBuyResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateOrderBuyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateOrderBuyResponseBody = None,
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
            temp_model = ValidateOrderBuyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateOrderUpdateHeaders(TeaModel):
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


class ValidateOrderUpdateRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class ValidateOrderUpdateResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateOrderUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateOrderUpdateResponseBody = None,
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
            temp_model = ValidateOrderUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ValidateOrderUpgradeHeaders(TeaModel):
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


class ValidateOrderUpgradeRequest(TeaModel):
    def __init__(
        self,
        access_key: str = None,
        caller_uid: str = None,
        instance_id: str = None,
    ):
        self.access_key = access_key
        self.caller_uid = caller_uid
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class ValidateOrderUpgradeResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        self.message = message
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ValidateOrderUpgradeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ValidateOrderUpgradeResponseBody = None,
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
            temp_model = ValidateOrderUpgradeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


