# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class ValidateOrderUpgradeResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        status: int = None,
    ):
        # message
        self.message = message
        # status
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
        body: ValidateOrderUpgradeResponseBody = None,
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
            temp_model = ValidateOrderUpgradeResponseBody()
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
        body: GetCorpLevelByAccountIdResponseBody = None,
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
            temp_model = GetCorpLevelByAccountIdResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        import_sequence: str = None,
        error_lines: List[int] = None,
        app_type: str = None,
        system_token: str = None,
        language: str = None,
        user_id: str = None,
        status: str = None,
    ):
        self.import_sequence = import_sequence
        self.error_lines = error_lines
        self.app_type = app_type
        self.system_token = system_token
        self.language = language
        self.user_id = user_id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.import_sequence is not None:
            result['importSequence'] = self.import_sequence
        if self.error_lines is not None:
            result['errorLines'] = self.error_lines
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('importSequence') is not None:
            self.import_sequence = m.get('importSequence')
        if m.get('errorLines') is not None:
            self.error_lines = m.get('errorLines')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateStatusResponse(TeaModel):
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
        out_result: str = None,
        no_execute_expressions: str = None,
        app_type: str = None,
        form_data_json: str = None,
        system_token: str = None,
        language: str = None,
        remark: str = None,
        process_instance_id: str = None,
        user_id: str = None,
    ):
        # 审批结果
        self.out_result = out_result
        # 是否不执行校验&关联操作
        self.no_execute_expressions = no_execute_expressions
        # 应用ID
        self.app_type = app_type
        # 更新的表单数据
        self.form_data_json = form_data_json
        # 应用秘钥
        self.system_token = system_token
        # 语言
        self.language = language
        # 审批意见
        self.remark = remark
        # 流程实例ID
        self.process_instance_id = process_instance_id
        # 钉钉的userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.no_execute_expressions is not None:
            result['noExecuteExpressions'] = self.no_execute_expressions
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.remark is not None:
            result['remark'] = self.remark
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('noExecuteExpressions') is not None:
            self.no_execute_expressions = m.get('noExecuteExpressions')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExecutePlatformTaskResponse(TeaModel):
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
        system_token: str = None,
        reply_id: int = None,
        language: str = None,
        form_instance_id: str = None,
        user_id: str = None,
        at_user_id: str = None,
        content: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 对评论进行回复
        self.reply_id = reply_id
        # 语言
        self.language = language
        # 实例ID
        self.form_instance_id = form_instance_id
        # 评论人钉钉的userId
        self.user_id = user_id
        # 将评论内容通过钉钉发给指定用户
        self.at_user_id = at_user_id
        # 评论内容
        self.content = content

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
        if self.reply_id is not None:
            result['replyId'] = self.reply_id
        if self.language is not None:
            result['language'] = self.language
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.at_user_id is not None:
            result['atUserId'] = self.at_user_id
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('replyId') is not None:
            self.reply_id = m.get('replyId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('atUserId') is not None:
            self.at_user_id = m.get('atUserId')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class SaveFormRemarkResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
    ):
        # 评论的ID
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
        body: SaveFormRemarkResponseBody = None,
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
            temp_model = SaveFormRemarkResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_uuid: str = None,
        search_field_json: str = None,
        current_page: int = None,
        page_size: int = None,
        originator_id: str = None,
        create_from_time_gmt: str = None,
        create_to_time_gmt: str = None,
        modified_from_time_gmt: str = None,
        modified_to_time_gmt: str = None,
        dynamic_order: str = None,
    ):
        # 应用编码
        self.app_type = app_type
        # 应用秘钥。在应用数据中获取。
        self.system_token = system_token
        # 钉钉userId
        self.user_id = user_id
        # 语言。可选值：zh_CN/en_US 默认：zh_CN
        self.language = language
        # 表单ID
        self.form_uuid = form_uuid
        # 根据表单内组件值查询
        self.search_field_json = search_field_json
        # 当前页
        self.current_page = current_page
        # 每页记录数
        self.page_size = page_size
        # 根据数据提交人工号查询
        self.originator_id = originator_id
        # createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表, 字符串格式，且为yyyy-MM-DD格式
        self.create_from_time_gmt = create_from_time_gmt
        # createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。字符串格式，且为yyyy-MM-DD格式。 和createFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)创建的数据。
        self.create_to_time_gmt = create_to_time_gmt
        # modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式
        self.modified_from_time_gmt = modified_from_time_gmt
        # modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式。 和modifiedFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)被修改的数据。
        self.modified_to_time_gmt = modified_to_time_gmt
        # 指定排序字段
        self.dynamic_order = dynamic_order

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.dynamic_order is not None:
            result['dynamicOrder'] = self.dynamic_order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('dynamicOrder') is not None:
            self.dynamic_order = m.get('dynamicOrder')
        return self


class SearchFormDatasResponseBodyDataOriginatorUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        # 中文名称
        self.name_in_chinese = name_in_chinese
        # 英文名称
        self.name_in_english = name_in_english
        # 国际化
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
        department_name: str = None,
        email: str = None,
    ):
        # 用户工号
        self.user_id = user_id
        # 用户名
        self.user_name = user_name
        # 部门名称
        self.department_name = department_name
        # 邮箱
        self.email = email

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
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            temp_model = SearchFormDatasResponseBodyDataOriginatorUserName()
            self.user_name = temp_model.from_map(m['userName'])
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class SearchFormDatasResponseBodyDataModifyUserUserName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        # 中文名称
        self.name_in_chinese = name_in_chinese
        # 英文名称
        self.name_in_english = name_in_english
        # 国际化
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
        department_name: str = None,
        email: str = None,
    ):
        # 用户工号
        self.user_id = user_id
        # 用户名
        self.user_name = user_name
        # 部门名称
        self.department_name = department_name
        # 邮箱
        self.email = email

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
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            temp_model = SearchFormDatasResponseBodyDataModifyUserUserName()
            self.user_name = temp_model.from_map(m['userName'])
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class SearchFormDatasResponseBodyData(TeaModel):
    def __init__(
        self,
        data_id: int = None,
        form_instance_id: str = None,
        created_time_gmt: str = None,
        modified_time_gmt: str = None,
        form_uuid: str = None,
        model_uuid: str = None,
        originator: SearchFormDatasResponseBodyDataOriginator = None,
        modify_user: SearchFormDatasResponseBodyDataModifyUser = None,
        form_data: Dict[str, Any] = None,
        title: str = None,
        serial_no: str = None,
        instance_value: str = None,
        version: int = None,
        creator_user_id: str = None,
        modifier_user_id: str = None,
        sequence: str = None,
    ):
        # 实体主键id
        self.data_id = data_id
        # 表单实例ID
        self.form_instance_id = form_instance_id
        # 数据创建时间
        self.created_time_gmt = created_time_gmt
        # 最近修改时间
        self.modified_time_gmt = modified_time_gmt
        # 表单id
        self.form_uuid = form_uuid
        # 模型id
        self.model_uuid = model_uuid
        # 发起人
        self.originator = originator
        # 修改者
        self.modify_user = modify_user
        # 表单数据
        self.form_data = form_data
        # 标题
        self.title = title
        # 流水号
        self.serial_no = serial_no
        # 表单实例原始格式值
        self.instance_value = instance_value
        # 数据版本
        self.version = version
        # 创建人
        self.creator_user_id = creator_user_id
        # 修改人
        self.modifier_user_id = modifier_user_id
        # 批次号
        self.sequence = sequence

    def validate(self):
        if self.originator:
            self.originator.validate()
        if self.modify_user:
            self.modify_user.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.created_time_gmt is not None:
            result['createdTimeGMT'] = self.created_time_gmt
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.model_uuid is not None:
            result['modelUuid'] = self.model_uuid
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.modify_user is not None:
            result['modifyUser'] = self.modify_user.to_map()
        if self.form_data is not None:
            result['formData'] = self.form_data
        if self.title is not None:
            result['title'] = self.title
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.instance_value is not None:
            result['instanceValue'] = self.instance_value
        if self.version is not None:
            result['version'] = self.version
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.modifier_user_id is not None:
            result['modifierUserId'] = self.modifier_user_id
        if self.sequence is not None:
            result['sequence'] = self.sequence
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('createdTimeGMT') is not None:
            self.created_time_gmt = m.get('createdTimeGMT')
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('modelUuid') is not None:
            self.model_uuid = m.get('modelUuid')
        if m.get('originator') is not None:
            temp_model = SearchFormDatasResponseBodyDataOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('modifyUser') is not None:
            temp_model = SearchFormDatasResponseBodyDataModifyUser()
            self.modify_user = temp_model.from_map(m['modifyUser'])
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('instanceValue') is not None:
            self.instance_value = m.get('instanceValue')
        if m.get('version') is not None:
            self.version = m.get('version')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('modifierUserId') is not None:
            self.modifier_user_id = m.get('modifierUserId')
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        return self


class SearchFormDatasResponseBody(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        total_count: int = None,
        data: List[SearchFormDatasResponseBodyData] = None,
    ):
        # 当前页
        self.current_page = current_page
        # 符合条件的实例总数
        self.total_count = total_count
        # 实例详情列表
        self.data = data

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SearchFormDatasResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class SearchFormDatasResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchFormDatasResponseBody = None,
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
            temp_model = SearchFormDatasResponseBody()
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
        # 访问key
        self.access_key = access_key
        # 用户的uid
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
        instance_id: str = None,
        activation_code: str = None,
        auth_type: str = None,
        expire_time_gmt: str = None,
        status: int = None,
    ):
        # instanceId
        self.instance_id = instance_id
        # activationCode
        self.activation_code = activation_code
        # authType
        self.auth_type = auth_type
        # expireTime
        self.expire_time_gmt = expire_time_gmt
        # status
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.activation_code is not None:
            result['activationCode'] = self.activation_code
        if self.auth_type is not None:
            result['authType'] = self.auth_type
        if self.expire_time_gmt is not None:
            result['expireTimeGMT'] = self.expire_time_gmt
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('activationCode') is not None:
            self.activation_code = m.get('activationCode')
        if m.get('authType') is not None:
            self.auth_type = m.get('authType')
        if m.get('expireTimeGMT') is not None:
            self.expire_time_gmt = m.get('expireTimeGMT')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SearchActivationCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchActivationCodeResponseBody = None,
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
        target_field_json: str = None,
        form_uuid: str = None,
        app_type: str = None,
        modified_to_time_gmt: str = None,
        system_token: str = None,
        modified_from_time_gmt: str = None,
        language: str = None,
        search_field_json: str = None,
        originator_id: str = None,
        user_id: str = None,
        create_to_time_gmt: str = None,
        create_from_time_gmt: str = None,
    ):
        self.target_field_json = target_field_json
        self.form_uuid = form_uuid
        self.app_type = app_type
        self.modified_to_time_gmt = modified_to_time_gmt
        self.system_token = system_token
        self.modified_from_time_gmt = modified_from_time_gmt
        self.language = language
        self.search_field_json = search_field_json
        self.originator_id = originator_id
        self.user_id = user_id
        self.create_to_time_gmt = create_to_time_gmt
        self.create_from_time_gmt = create_from_time_gmt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_field_json is not None:
            result['targetFieldJson'] = self.target_field_json
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.modified_to_time_gmt is not None:
            result['modifiedToTimeGMT'] = self.modified_to_time_gmt
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.modified_from_time_gmt is not None:
            result['modifiedFromTimeGMT'] = self.modified_from_time_gmt
        if self.language is not None:
            result['language'] = self.language
        if self.search_field_json is not None:
            result['searchFieldJson'] = self.search_field_json
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.create_to_time_gmt is not None:
            result['createToTimeGMT'] = self.create_to_time_gmt
        if self.create_from_time_gmt is not None:
            result['createFromTimeGMT'] = self.create_from_time_gmt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetFieldJson') is not None:
            self.target_field_json = m.get('targetFieldJson')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('modifiedToTimeGMT') is not None:
            self.modified_to_time_gmt = m.get('modifiedToTimeGMT')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('modifiedFromTimeGMT') is not None:
            self.modified_from_time_gmt = m.get('modifiedFromTimeGMT')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('searchFieldJson') is not None:
            self.search_field_json = m.get('searchFieldJson')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('createToTimeGMT') is not None:
            self.create_to_time_gmt = m.get('createToTimeGMT')
        if m.get('createFromTimeGMT') is not None:
            self.create_from_time_gmt = m.get('createFromTimeGMT')
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
        body: SearchEmployeeFieldValuesResponseBody = None,
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
            temp_model = SearchEmployeeFieldValuesResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_instance_id: str = None,
        use_latest_version: bool = None,
        update_form_data_json: str = None,
    ):
        # 应用编码
        self.app_type = app_type
        # 应用秘钥。在应用数据中获取。
        self.system_token = system_token
        # 钉钉userId
        self.user_id = user_id
        # 语言。可选值：zh_CN/en_US 默认：zh_CN
        self.language = language
        # 要更新的表单数据ID
        self.form_instance_id = form_instance_id
        # 使用最新的表单版本进行更新。默认为false
        self.use_latest_version = use_latest_version
        # 要更新的表单组件值。参数有的组件更新，没有的组件保持不变。 明细的值只能统一更新，无法只更新明细下某个组件的值
        self.update_form_data_json = update_form_data_json

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        if self.use_latest_version is not None:
            result['useLatestVersion'] = self.use_latest_version
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        if m.get('useLatestVersion') is not None:
            self.use_latest_version = m.get('useLatestVersion')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        return self


class UpdateFormDataResponse(TeaModel):
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        process_instance_id: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 钉钉的userId
        self.user_id = user_id
        # 语言
        self.language = language
        # 流程实例ID
        self.process_instance_id = process_instance_id

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
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetOperationRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
        show_name: str = None,
        operator_nick_name: str = None,
        active_time_gmt: str = None,
        operate_time_gmt: str = None,
        operate_type: str = None,
        operator_status: str = None,
        remark: str = None,
        task_hold_time_gmt: int = None,
        type: str = None,
        operator_name: str = None,
        operator_user_id: str = None,
        activity_id: str = None,
        task_type: str = None,
        task_execute_type: str = None,
        size: int = None,
        operator_display_name: str = None,
        files: str = None,
        action: str = None,
        action_exit: str = None,
        data_id: int = None,
        task_id: str = None,
        digital_sign: str = None,
        operator_photo_url: str = None,
    ):
        # processInstanceId
        self.process_instance_id = process_instance_id
        # showName
        self.show_name = show_name
        # operatorNick
        self.operator_nick_name = operator_nick_name
        # activeTime
        self.active_time_gmt = active_time_gmt
        # operateTime
        self.operate_time_gmt = operate_time_gmt
        # operateType
        self.operate_type = operate_type
        # operatorStatus
        self.operator_status = operator_status
        # remark
        self.remark = remark
        # taskHoldTime
        self.task_hold_time_gmt = task_hold_time_gmt
        # type
        self.type = type
        # operatorName
        self.operator_name = operator_name
        # operator
        self.operator_user_id = operator_user_id
        # activityId
        self.activity_id = activity_id
        # taskType
        self.task_type = task_type
        # taskExecuteType
        self.task_execute_type = task_execute_type
        # size
        self.size = size
        # operatorDisplayName
        self.operator_display_name = operator_display_name
        # files
        self.files = files
        # action
        self.action = action
        # actionExt
        self.action_exit = action_exit
        # id
        self.data_id = data_id
        # taskId
        self.task_id = task_id
        # digitalSign
        self.digital_sign = digital_sign
        # operatorPhotoUrl
        self.operator_photo_url = operator_photo_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.show_name is not None:
            result['showName'] = self.show_name
        if self.operator_nick_name is not None:
            result['operatorNickName'] = self.operator_nick_name
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.operate_time_gmt is not None:
            result['operateTimeGMT'] = self.operate_time_gmt
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_status is not None:
            result['operatorStatus'] = self.operator_status
        if self.remark is not None:
            result['remark'] = self.remark
        if self.task_hold_time_gmt is not None:
            result['taskHoldTimeGMT'] = self.task_hold_time_gmt
        if self.type is not None:
            result['type'] = self.type
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.task_execute_type is not None:
            result['taskExecuteType'] = self.task_execute_type
        if self.size is not None:
            result['size'] = self.size
        if self.operator_display_name is not None:
            result['operatorDisplayName'] = self.operator_display_name
        if self.files is not None:
            result['files'] = self.files
        if self.action is not None:
            result['action'] = self.action
        if self.action_exit is not None:
            result['actionExit'] = self.action_exit
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.digital_sign is not None:
            result['digitalSign'] = self.digital_sign
        if self.operator_photo_url is not None:
            result['operatorPhotoUrl'] = self.operator_photo_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('showName') is not None:
            self.show_name = m.get('showName')
        if m.get('operatorNickName') is not None:
            self.operator_nick_name = m.get('operatorNickName')
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('operateTimeGMT') is not None:
            self.operate_time_gmt = m.get('operateTimeGMT')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorStatus') is not None:
            self.operator_status = m.get('operatorStatus')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('taskHoldTimeGMT') is not None:
            self.task_hold_time_gmt = m.get('taskHoldTimeGMT')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('taskExecuteType') is not None:
            self.task_execute_type = m.get('taskExecuteType')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('operatorDisplayName') is not None:
            self.operator_display_name = m.get('operatorDisplayName')
        if m.get('files') is not None:
            self.files = m.get('files')
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionExit') is not None:
            self.action_exit = m.get('actionExit')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('digitalSign') is not None:
            self.digital_sign = m.get('digitalSign')
        if m.get('operatorPhotoUrl') is not None:
            self.operator_photo_url = m.get('operatorPhotoUrl')
        return self


class GetOperationRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetOperationRecordsResponseBodyResult] = None,
    ):
        # 流程实例操作记录数组
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
        body: GetOperationRecordsResponseBody = None,
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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class GetPlatformResourceResponseBody(TeaModel):
    def __init__(
        self,
        app_total_amount: int = None,
        instance_total_amount: int = None,
        instance_usage_amount: int = None,
        account_usage_amount: int = None,
        account_total_amount: int = None,
        plugin_usage_amount: int = None,
        attachment_total_amount: int = None,
        attachment_usage_amount: int = None,
    ):
        # appTotalAmount
        self.app_total_amount = app_total_amount
        # instanceTotalAmount
        self.instance_total_amount = instance_total_amount
        # instanceUsageAmount
        self.instance_usage_amount = instance_usage_amount
        # accountUsageAmount
        self.account_usage_amount = account_usage_amount
        # accountTotalAmount
        self.account_total_amount = account_total_amount
        # pluginUsageAmount
        self.plugin_usage_amount = plugin_usage_amount
        # attachmentTotalAmount
        self.attachment_total_amount = attachment_total_amount
        # attachmentUsageAmount
        self.attachment_usage_amount = attachment_usage_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_total_amount is not None:
            result['appTotalAmount'] = self.app_total_amount
        if self.instance_total_amount is not None:
            result['instanceTotalAmount'] = self.instance_total_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        if self.account_usage_amount is not None:
            result['accountUsageAmount'] = self.account_usage_amount
        if self.account_total_amount is not None:
            result['accountTotalAmount'] = self.account_total_amount
        if self.plugin_usage_amount is not None:
            result['pluginUsageAmount'] = self.plugin_usage_amount
        if self.attachment_total_amount is not None:
            result['attachmentTotalAmount'] = self.attachment_total_amount
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTotalAmount') is not None:
            self.app_total_amount = m.get('appTotalAmount')
        if m.get('instanceTotalAmount') is not None:
            self.instance_total_amount = m.get('instanceTotalAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        if m.get('accountUsageAmount') is not None:
            self.account_usage_amount = m.get('accountUsageAmount')
        if m.get('accountTotalAmount') is not None:
            self.account_total_amount = m.get('accountTotalAmount')
        if m.get('pluginUsageAmount') is not None:
            self.plugin_usage_amount = m.get('pluginUsageAmount')
        if m.get('attachmentTotalAmount') is not None:
            self.attachment_total_amount = m.get('attachmentTotalAmount')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        return self


class GetPlatformResourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPlatformResourceResponseBody = None,
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
            temp_model = GetPlatformResourceResponseBody()
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
        process_instance_id: str = None,
        app_type: str = None,
        system_token: str = None,
        language: str = None,
        user_id: str = None,
    ):
        self.process_instance_id = process_instance_id
        self.app_type = app_type
        self.system_token = system_token
        self.language = language
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRunningTasksResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time_gmt: str = None,
        activity_id: str = None,
        process_instance_id: str = None,
        task_type: str = None,
        title_in_english: str = None,
        active_time_gmt: str = None,
        actual_actioner_id: str = None,
        originator_id: str = None,
        finish_time_gmt: str = None,
        title: str = None,
        task_id: str = None,
        status: str = None,
    ):
        # createTime
        self.create_time_gmt = create_time_gmt
        # activityId
        self.activity_id = activity_id
        # processInstanceId
        self.process_instance_id = process_instance_id
        # taskType
        self.task_type = task_type
        # titleEn
        self.title_in_english = title_in_english
        # activeTime
        self.active_time_gmt = active_time_gmt
        # actualActionerId
        self.actual_actioner_id = actual_actioner_id
        # originatorId
        self.originator_id = originator_id
        # finishTime
        self.finish_time_gmt = finish_time_gmt
        # title
        self.title = title
        # taskId
        self.task_id = task_id
        # status
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_gmt is not None:
            result['createTimeGMT'] = self.create_time_gmt
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title_in_english is not None:
            result['titleInEnglish'] = self.title_in_english
        if self.active_time_gmt is not None:
            result['activeTimeGMT'] = self.active_time_gmt
        if self.actual_actioner_id is not None:
            result['actualActionerId'] = self.actual_actioner_id
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.finish_time_gmt is not None:
            result['finishTimeGMT'] = self.finish_time_gmt
        if self.title is not None:
            result['title'] = self.title
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeGMT') is not None:
            self.create_time_gmt = m.get('createTimeGMT')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('titleInEnglish') is not None:
            self.title_in_english = m.get('titleInEnglish')
        if m.get('activeTimeGMT') is not None:
            self.active_time_gmt = m.get('activeTimeGMT')
        if m.get('actualActionerId') is not None:
            self.actual_actioner_id = m.get('actualActionerId')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('finishTimeGMT') is not None:
            self.finish_time_gmt = m.get('finishTimeGMT')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('status') is not None:
            self.status = m.get('status')
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
        body: GetRunningTasksResponseBody = None,
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
            temp_model = GetRunningTasksResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_type: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 评论人钉钉的userId
        self.user_id = user_id
        # 语言
        self.language = language
        # 页面类型
        self.form_type = form_type

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_type is not None:
            result['formType'] = self.form_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formType') is not None:
            self.form_type = m.get('formType')
        return self


class ListNavigationByFormTypeResponseBodyResultTitle(TeaModel):
    def __init__(
        self,
        name_in_english: str = None,
        type: str = None,
        name_in_chinese: str = None,
    ):
        # 英文名称
        self.name_in_english = name_in_english
        # type
        self.type = type
        # 中文名称
        self.name_in_chinese = name_in_chinese

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_in_english is not None:
            result['nameInEnglish'] = self.name_in_english
        if self.type is not None:
            result['type'] = self.type
        if self.name_in_chinese is not None:
            result['nameInChinese'] = self.name_in_chinese
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameInEnglish') is not None:
            self.name_in_english = m.get('nameInEnglish')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('nameInChinese') is not None:
            self.name_in_chinese = m.get('nameInChinese')
        return self


class ListNavigationByFormTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        title: ListNavigationByFormTypeResponseBodyResultTitle = None,
        process_code: str = None,
        form_uuid: str = None,
    ):
        # title
        self.title = title
        # processCode
        self.process_code = process_code
        # formUuid
        self.form_uuid = form_uuid

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
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            temp_model = ListNavigationByFormTypeResponseBodyResultTitle()
            self.title = temp_model.from_map(m['title'])
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
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
        body: ListNavigationByFormTypeResponseBody = None,
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
            temp_model = ListNavigationByFormTypeResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        process_instance_id: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 钉钉的userId
        self.user_id = user_id
        # 语言
        self.language = language
        # 流程实例ID
        self.process_instance_id = process_instance_id

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
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class TerminateInstanceResponse(TeaModel):
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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class ExpireCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        # message
        self.message = message
        # success
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
        body: ExpireCommodityResponseBody = None,
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
            temp_model = ExpireCommodityResponseBody()
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
        # message
        self.message = message
        # status
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
        body: ValidateOrderBuyResponseBody = None,
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
            temp_model = ValidateOrderBuyResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_uuid: str = None,
        form_data_json: str = None,
    ):
        # 应用编码
        self.app_type = app_type
        # 应用秘钥。在应用数据中获取。
        self.system_token = system_token
        # 钉钉userId
        self.user_id = user_id
        # 语言。可选值：zh_CN/en_US 默认：zh_CN
        self.language = language
        # 表单ID
        self.form_uuid = form_uuid
        # 表单数据
        self.form_data_json = form_data_json

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        return self


class SaveFormDataResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 表单实例ID
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
        body: SaveFormDataResponseBody = None,
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
            temp_model = SaveFormDataResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_instance_id: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 钉钉的userId
        self.user_id = user_id
        # 语言
        self.language = language
        # 要删除的表单数据ID
        self.form_instance_id = form_instance_id

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_instance_id is not None:
            result['formInstanceId'] = self.form_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formInstanceId') is not None:
            self.form_instance_id = m.get('formInstanceId')
        return self


class DeleteFormDataResponse(TeaModel):
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
        process_instance_id: str = None,
        app_type: str = None,
        update_form_data_json: str = None,
        system_token: str = None,
        language: str = None,
        user_id: str = None,
    ):
        # 实例ID
        self.process_instance_id = process_instance_id
        # 应用ID
        self.app_type = app_type
        # 更新的表单数据
        self.update_form_data_json = update_form_data_json
        # 应用秘钥
        self.system_token = system_token
        # 语言环境
        self.language = language
        # 钉钉的userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.update_form_data_json is not None:
            result['updateFormDataJson'] = self.update_form_data_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('updateFormDataJson') is not None:
            self.update_form_data_json = m.get('updateFormDataJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateInstanceResponse(TeaModel):
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
        page_size: int = None,
        caller_uid: str = None,
        current_page: int = None,
    ):
        # accessKey
        self.access_key = access_key
        # pageSize
        self.page_size = page_size
        # callerUid
        self.caller_uid = caller_uid
        # currentPage
        self.current_page = current_page

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class ListCommodityResponseBodyCommodityVOList(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        buy_date_gmt: str = None,
        expire_date_gmt: str = None,
        activation_code: str = None,
        account_number: int = None,
        account_distribution_number: int = None,
        version: int = None,
        status: str = None,
    ):
        # instanceId
        self.instance_id = instance_id
        # buyDate
        self.buy_date_gmt = buy_date_gmt
        # expireDate
        self.expire_date_gmt = expire_date_gmt
        # activationCode
        self.activation_code = activation_code
        # accountNum
        self.account_number = account_number
        # accountDistributionNumber
        self.account_distribution_number = account_distribution_number
        # version
        self.version = version
        # status
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.buy_date_gmt is not None:
            result['buyDateGMT'] = self.buy_date_gmt
        if self.expire_date_gmt is not None:
            result['expireDateGMT'] = self.expire_date_gmt
        if self.activation_code is not None:
            result['activationCode'] = self.activation_code
        if self.account_number is not None:
            result['accountNumber'] = self.account_number
        if self.account_distribution_number is not None:
            result['accountDistributionNumber'] = self.account_distribution_number
        if self.version is not None:
            result['version'] = self.version
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('buyDateGMT') is not None:
            self.buy_date_gmt = m.get('buyDateGMT')
        if m.get('expireDateGMT') is not None:
            self.expire_date_gmt = m.get('expireDateGMT')
        if m.get('activationCode') is not None:
            self.activation_code = m.get('activationCode')
        if m.get('accountNumber') is not None:
            self.account_number = m.get('accountNumber')
        if m.get('accountDistributionNumber') is not None:
            self.account_distribution_number = m.get('accountDistributionNumber')
        if m.get('version') is not None:
            self.version = m.get('version')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListCommodityResponseBody(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        commodity_volist: List[ListCommodityResponseBodyCommodityVOList] = None,
        current_page: int = None,
        total_count: int = None,
    ):
        # 分页大小
        self.page_size = page_size
        # commodityVOList
        self.commodity_volist = commodity_volist
        # 当前第几页
        self.current_page = current_page
        # 总数量
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
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['commodityVOList'] = []
        if self.commodity_volist is not None:
            for k in self.commodity_volist:
                result['commodityVOList'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.commodity_volist = []
        if m.get('commodityVOList') is not None:
            for k in m.get('commodityVOList'):
                temp_model = ListCommodityResponseBodyCommodityVOList()
                self.commodity_volist.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListCommodityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListCommodityResponseBody = None,
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
            temp_model = ListCommodityResponseBody()
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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class GetApplicationAuthorizationServicePlatformResourceResponseBody(TeaModel):
    def __init__(
        self,
        app_total_amount: int = None,
        instance_id: str = None,
        instance_total_amount: int = None,
        instance_usage_amount: int = None,
        account_usage_amount: int = None,
        account_total_amount: int = None,
        plugin_usage_amount: int = None,
        attachment_total_amount: int = None,
        attachment_usage_amount: int = None,
    ):
        # appTotalAmount
        self.app_total_amount = app_total_amount
        # instanceId
        self.instance_id = instance_id
        # instanceTotalAmount
        self.instance_total_amount = instance_total_amount
        # instanceUsageAmount
        self.instance_usage_amount = instance_usage_amount
        # accountUsageAmount
        self.account_usage_amount = account_usage_amount
        # accountTotalAmount
        self.account_total_amount = account_total_amount
        # pluginUsageAmount
        self.plugin_usage_amount = plugin_usage_amount
        # attachmentTotalAmount
        self.attachment_total_amount = attachment_total_amount
        # attachmentUsageAmount
        self.attachment_usage_amount = attachment_usage_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_total_amount is not None:
            result['appTotalAmount'] = self.app_total_amount
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_total_amount is not None:
            result['instanceTotalAmount'] = self.instance_total_amount
        if self.instance_usage_amount is not None:
            result['instanceUsageAmount'] = self.instance_usage_amount
        if self.account_usage_amount is not None:
            result['accountUsageAmount'] = self.account_usage_amount
        if self.account_total_amount is not None:
            result['accountTotalAmount'] = self.account_total_amount
        if self.plugin_usage_amount is not None:
            result['pluginUsageAmount'] = self.plugin_usage_amount
        if self.attachment_total_amount is not None:
            result['attachmentTotalAmount'] = self.attachment_total_amount
        if self.attachment_usage_amount is not None:
            result['attachmentUsageAmount'] = self.attachment_usage_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTotalAmount') is not None:
            self.app_total_amount = m.get('appTotalAmount')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceTotalAmount') is not None:
            self.instance_total_amount = m.get('instanceTotalAmount')
        if m.get('instanceUsageAmount') is not None:
            self.instance_usage_amount = m.get('instanceUsageAmount')
        if m.get('accountUsageAmount') is not None:
            self.account_usage_amount = m.get('accountUsageAmount')
        if m.get('accountTotalAmount') is not None:
            self.account_total_amount = m.get('accountTotalAmount')
        if m.get('pluginUsageAmount') is not None:
            self.plugin_usage_amount = m.get('pluginUsageAmount')
        if m.get('attachmentTotalAmount') is not None:
            self.attachment_total_amount = m.get('attachmentTotalAmount')
        if m.get('attachmentUsageAmount') is not None:
            self.attachment_usage_amount = m.get('attachmentUsageAmount')
        return self


class GetApplicationAuthorizationServicePlatformResourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetApplicationAuthorizationServicePlatformResourceResponseBody = None,
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
            temp_model = GetApplicationAuthorizationServicePlatformResourceResponseBody()
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
        process_code: str = None,
        app_type: str = None,
        system_token: str = None,
        language: str = None,
        user_id: str = None,
    ):
        self.process_code = process_code
        self.app_type = app_type
        self.system_token = system_token
        self.language = language
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetActivityListResponseBodyResult(TeaModel):
    def __init__(
        self,
        activity_name: str = None,
        activity_name_in_english: str = None,
        activity_id: str = None,
    ):
        # activityName
        self.activity_name = activity_name
        # activityNameEn
        self.activity_name_in_english = activity_name_in_english
        # activityId
        self.activity_id = activity_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_name_in_english is not None:
            result['activityNameInEnglish'] = self.activity_name_in_english
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityNameInEnglish') is not None:
            self.activity_name_in_english = m.get('activityNameInEnglish')
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        return self


class GetActivityListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetActivityListResponseBodyResult] = None,
    ):
        # Id of the request
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
        body: GetActivityListResponseBody = None,
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
            temp_model = GetActivityListResponseBody()
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
    ):
        # 应用编码
        self.app_type = app_type
        # 应用秘钥。在应用数据中获取。
        self.system_token = system_token
        # 钉钉userId
        self.user_id = user_id
        # 语言。可选值：zh_CN/en_US 默认：zh_CN
        self.language = language

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
        if self.language is not None:
            result['language'] = self.language
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        return self


class GetFormDataByIDResponseBodyOriginatorName(TeaModel):
    def __init__(
        self,
        name_in_chinese: str = None,
        name_in_english: str = None,
        type: str = None,
    ):
        # 中文名称
        self.name_in_chinese = name_in_chinese
        # 英文名称
        self.name_in_english = name_in_english
        # 国际化
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
        user_id: str = None,
        name: GetFormDataByIDResponseBodyOriginatorName = None,
        department_name: str = None,
        email: str = None,
    ):
        # 用户工号
        self.user_id = user_id
        # 用户名
        self.name = name
        # 部门名称
        self.department_name = department_name
        # 邮箱
        self.email = email

    def validate(self):
        if self.name:
            self.name.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name.to_map()
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            temp_model = GetFormDataByIDResponseBodyOriginatorName()
            self.name = temp_model.from_map(m['name'])
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class GetFormDataByIDResponseBody(TeaModel):
    def __init__(
        self,
        originator: GetFormDataByIDResponseBodyOriginator = None,
        modified_time_gmt: str = None,
        form_uuid: str = None,
        form_inst_id: str = None,
        form_data: Dict[str, Any] = None,
    ):
        # 发起人详情
        self.originator = originator
        # 最后修改时间
        self.modified_time_gmt = modified_time_gmt
        # 表单ID
        self.form_uuid = form_uuid
        # 表单实例ID
        self.form_inst_id = form_inst_id
        # 表单数据详情
        self.form_data = form_data

    def validate(self):
        if self.originator:
            self.originator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.originator is not None:
            result['originator'] = self.originator.to_map()
        if self.modified_time_gmt is not None:
            result['modifiedTimeGMT'] = self.modified_time_gmt
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.form_inst_id is not None:
            result['formInstId'] = self.form_inst_id
        if self.form_data is not None:
            result['formData'] = self.form_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('originator') is not None:
            temp_model = GetFormDataByIDResponseBodyOriginator()
            self.originator = temp_model.from_map(m['originator'])
        if m.get('modifiedTimeGMT') is not None:
            self.modified_time_gmt = m.get('modifiedTimeGMT')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('formInstId') is not None:
            self.form_inst_id = m.get('formInstId')
        if m.get('formData') is not None:
            self.form_data = m.get('formData')
        return self


class GetFormDataByIDResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFormDataByIDResponseBody = None,
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
            temp_model = GetFormDataByIDResponseBody()
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
        data: str = None,
        app_type: str = None,
        system_token: str = None,
        language: str = None,
        service_id: str = None,
        user_id: str = None,
    ):
        self.data = data
        self.app_type = app_type
        self.system_token = system_token
        self.language = language
        self.service_id = service_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
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
        body: ExecuteCustomApiResponseBody = None,
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
            temp_model = ExecuteCustomApiResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class RefundCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        # message
        self.message = message
        # success
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
        body: RefundCommodityResponseBody = None,
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
            temp_model = RefundCommodityResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        user_id: str = None,
        sequence: str = None,
        system_token: str = None,
        language: str = None,
        app_type: str = None,
    ):
        self.user_id = user_id
        self.sequence = sequence
        self.system_token = system_token
        self.language = language
        self.app_type = app_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.app_type is not None:
            result['appType'] = self.app_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        return self


class DeleteSequenceResponse(TeaModel):
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
        instance_id: str = None,
        access_key: str = None,
        caller_uid: str = None,
    ):
        self.instance_id = instance_id
        self.access_key = access_key
        self.caller_uid = caller_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.access_key is not None:
            result['accessKey'] = self.access_key
        if self.caller_uid is not None:
            result['callerUid'] = self.caller_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('accessKey') is not None:
            self.access_key = m.get('accessKey')
        if m.get('callerUid') is not None:
            self.caller_uid = m.get('callerUid')
        return self


class ReleaseCommodityResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
    ):
        # message
        self.message = message
        # success
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
        body: ReleaseCommodityResponseBody = None,
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
            temp_model = ReleaseCommodityResponseBody()
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
        # userId
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
        # result
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
        body: LoginCodeGenResponseBody = None,
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
            temp_model = LoginCodeGenResponseBody()
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
        self.corp_id = corp_id
        self.namespace = namespace
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
        namespace: str = None,
        corp_id: str = None,
        corp_name: str = None,
    ):
        # namespace
        self.namespace = namespace
        # corpId
        self.corp_id = corp_id
        # corpName
        self.corp_name = corp_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.namespace is not None:
            result['namespace'] = self.namespace
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('namespace') is not None:
            self.namespace = m.get('namespace')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        return self


class GetSaleUserInfoByUserIdResponseBody(TeaModel):
    def __init__(
        self,
        user_name: str = None,
        user_id: str = None,
        account_id: int = None,
        corp_list: List[GetSaleUserInfoByUserIdResponseBodyCorpList] = None,
    ):
        # userName
        self.user_name = user_name
        # userId
        self.user_id = user_id
        # accountId
        self.account_id = account_id
        # corpList
        self.corp_list = corp_list

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
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.account_id is not None:
            result['accountId'] = self.account_id
        result['corpList'] = []
        if self.corp_list is not None:
            for k in self.corp_list:
                result['corpList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        self.corp_list = []
        if m.get('corpList') is not None:
            for k in m.get('corpList'):
                temp_model = GetSaleUserInfoByUserIdResponseBodyCorpList()
                self.corp_list.append(temp_model.from_map(k))
        return self


class GetSaleUserInfoByUserIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSaleUserInfoByUserIdResponseBody = None,
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
            temp_model = GetSaleUserInfoByUserIdResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        out_result: str = None,
        no_execute_expressions: str = None,
        app_type: str = None,
        form_data_json: str = None,
        system_token: str = None,
        language: str = None,
        remark: str = None,
        process_instance_id: str = None,
        user_id: str = None,
        task_id: int = None,
    ):
        # 审批结果
        self.out_result = out_result
        # 是否不执行校验&关联操作
        self.no_execute_expressions = no_execute_expressions
        # 应用ID
        self.app_type = app_type
        # 更新的表单值
        self.form_data_json = form_data_json
        # 应用秘钥
        self.system_token = system_token
        # 语言
        self.language = language
        # 审批意见
        self.remark = remark
        # 实例ID
        self.process_instance_id = process_instance_id
        # 钉钉的userId
        self.user_id = user_id
        # 任务ID
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_result is not None:
            result['outResult'] = self.out_result
        if self.no_execute_expressions is not None:
            result['noExecuteExpressions'] = self.no_execute_expressions
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.system_token is not None:
            result['systemToken'] = self.system_token
        if self.language is not None:
            result['language'] = self.language
        if self.remark is not None:
            result['remark'] = self.remark
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outResult') is not None:
            self.out_result = m.get('outResult')
        if m.get('noExecuteExpressions') is not None:
            self.no_execute_expressions = m.get('noExecuteExpressions')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class ExecuteTaskResponse(TeaModel):
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        form_uuid: str = None,
        form_data_json: str = None,
        process_code: str = None,
        department_id: str = None,
    ):
        # 应用编码
        self.app_type = app_type
        # 应用秘钥。在应用数据中获取。
        self.system_token = system_token
        # 钉钉userId
        self.user_id = user_id
        # 语言。可选值：zh_CN/en_US 默认：zh_CN
        self.language = language
        # 表单唯一编码
        self.form_uuid = form_uuid
        # 表单数据
        self.form_data_json = form_data_json
        # 流程编码
        self.process_code = process_code
        # 发起人所在部门编号
        self.department_id = department_id

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
        if self.language is not None:
            result['language'] = self.language
        if self.form_uuid is not None:
            result['formUuid'] = self.form_uuid
        if self.form_data_json is not None:
            result['formDataJson'] = self.form_data_json
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('formUuid') is not None:
            self.form_uuid = m.get('formUuid')
        if m.get('formDataJson') is not None:
            self.form_data_json = m.get('formDataJson')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        return self


class StartInstanceResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 流程实例ID
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
        body: StartInstanceResponseBody = None,
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
            temp_model = StartInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        system_token: str = None,
        user_id: str = None,
        language: str = None,
        process_instance_id: str = None,
    ):
        # 应用ID
        self.app_type = app_type
        # 应用秘钥
        self.system_token = system_token
        # 钉钉的userId
        self.user_id = user_id
        # 语言
        self.language = language
        # 流程实例ID
        self.process_instance_id = process_instance_id

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
        if self.language is not None:
            result['language'] = self.language
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('systemToken') is not None:
            self.system_token = m.get('systemToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class DeleteInstanceResponse(TeaModel):
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


