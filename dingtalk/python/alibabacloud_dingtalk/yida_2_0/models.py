# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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


class GetFormComponentAliasListHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetFormComponentAliasListRequest(TeaModel):
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


class GetFormComponentAliasListResponseBodyResult(TeaModel):
    def __init__(
        self,
        alias: str = None,
        field_id: str = None,
    ):
        self.alias = alias
        self.field_id = field_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alias is not None:
            result['alias'] = self.alias
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alias') is not None:
            self.alias = m.get('alias')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        return self


class GetFormComponentAliasListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetFormComponentAliasListResponseBodyResult] = None,
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
                temp_model = GetFormComponentAliasListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetFormComponentAliasListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormComponentAliasListResponseBody = None,
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
            temp_model = GetFormComponentAliasListResponseBody()
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
        form_uuid: str = None,
        language: str = None,
        system_token: str = None,
        use_alias: bool = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        self.form_uuid = form_uuid
        self.language = language
        self.system_token = system_token
        self.use_alias = use_alias
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
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        form_uuid: str = None,
        language: str = None,
        system_token: str = None,
        use_alias: bool = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_type = app_type
        self.form_uuid = form_uuid
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        self.use_alias = use_alias
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
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        originator_id: str = None,
        page_size: int = None,
        search_field_json: str = None,
        system_token: str = None,
        use_alias: bool = None,
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
        self.modified_from_time_gmt = modified_from_time_gmt
        self.modified_to_time_gmt = modified_to_time_gmt
        self.originator_id = originator_id
        self.page_size = page_size
        self.search_field_json = search_field_json
        # This parameter is required.
        self.system_token = system_token
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        use_alias: bool = None,
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
        self.use_alias = use_alias
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
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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
        form_uuid: str = None,
        language: str = None,
        system_token: str = None,
        update_form_data_json: str = None,
        use_alias: bool = None,
        use_latest_version: bool = None,
        user_id: str = None,
    ):
        self.app_type = app_type
        # This parameter is required.
        self.form_instance_id = form_instance_id
        self.form_uuid = form_uuid
        self.language = language
        # This parameter is required.
        self.system_token = system_token
        # This parameter is required.
        self.update_form_data_json = update_form_data_json
        self.use_alias = use_alias
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
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.language is not None:
            result['language'] = self.language
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        if self.use_alias is not None:
            result['useAlias'] = self.use_alias
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
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        if m.get('useAlias') is not None:
            self.use_alias = m.get('useAlias')
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


