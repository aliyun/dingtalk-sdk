# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


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


