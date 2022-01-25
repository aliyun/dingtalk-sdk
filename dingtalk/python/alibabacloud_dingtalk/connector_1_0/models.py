# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class PullDataByPkHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PullDataByPkRequest(TeaModel):
    def __init__(
        self,
        primary_key: str = None,
        app_id: str = None,
    ):
        # 数据的主键字段值。
        self.primary_key = primary_key
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.primary_key is not None:
            result['primaryKey'] = self.primary_key
        if self.app_id is not None:
            result['appId'] = self.app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('primaryKey') is not None:
            self.primary_key = m.get('primaryKey')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        return self


class PullDataByPkResponseBody(TeaModel):
    def __init__(
        self,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        data_create_app_type: str = None,
        data_create_app_id: str = None,
        data_modified_app_type: str = None,
        data_modified_app_id: str = None,
        json_data: str = None,
    ):
        # 数据创建时间。
        self.data_gmt_create = data_gmt_create
        # 数据最后修改时间。
        self.data_gmt_modified = data_gmt_modified
        # 创建数据的应用类型，isv应用为premium_microapp。
        self.data_create_app_type = data_create_app_type
        # 创建数据的应用id。
        self.data_create_app_id = data_create_app_id
        # 最后修改数据的应用类型，取值同dataCreateAppType。
        self.data_modified_app_type = data_modified_app_type
        # 最后修改数据的应用id。
        self.data_modified_app_id = data_modified_app_id
        # 数据完整内容。
        self.json_data = json_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.data_create_app_type is not None:
            result['dataCreateAppType'] = self.data_create_app_type
        if self.data_create_app_id is not None:
            result['dataCreateAppId'] = self.data_create_app_id
        if self.data_modified_app_type is not None:
            result['dataModifiedAppType'] = self.data_modified_app_type
        if self.data_modified_app_id is not None:
            result['dataModifiedAppId'] = self.data_modified_app_id
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('dataCreateAppType') is not None:
            self.data_create_app_type = m.get('dataCreateAppType')
        if m.get('dataCreateAppId') is not None:
            self.data_create_app_id = m.get('dataCreateAppId')
        if m.get('dataModifiedAppType') is not None:
            self.data_modified_app_type = m.get('dataModifiedAppType')
        if m.get('dataModifiedAppId') is not None:
            self.data_modified_app_id = m.get('dataModifiedAppId')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        return self


class PullDataByPkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PullDataByPkResponseBody = None,
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
            temp_model = PullDataByPkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncDataHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SyncDataRequestTriggerDataList(TeaModel):
    def __init__(
        self,
        trigger_id: str = None,
        custom_trigger_id: str = None,
        json_data: str = None,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        action: str = None,
    ):
        self.trigger_id = trigger_id
        self.custom_trigger_id = custom_trigger_id
        self.json_data = json_data
        self.data_gmt_create = data_gmt_create
        self.data_gmt_modified = data_gmt_modified
        self.action = action

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        if self.custom_trigger_id is not None:
            result['customTriggerId'] = self.custom_trigger_id
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.action is not None:
            result['action'] = self.action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
        if m.get('customTriggerId') is not None:
            self.custom_trigger_id = m.get('customTriggerId')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('action') is not None:
            self.action = m.get('action')
        return self


class SyncDataRequest(TeaModel):
    def __init__(
        self,
        trigger_data_list: List[SyncDataRequestTriggerDataList] = None,
        app_id: str = None,
    ):
        self.trigger_data_list = trigger_data_list
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id

    def validate(self):
        if self.trigger_data_list:
            for k in self.trigger_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['triggerDataList'] = []
        if self.trigger_data_list is not None:
            for k in self.trigger_data_list:
                result['triggerDataList'].append(k.to_map() if k else None)
        if self.app_id is not None:
            result['appId'] = self.app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.trigger_data_list = []
        if m.get('triggerDataList') is not None:
            for k in m.get('triggerDataList'):
                temp_model = SyncDataRequestTriggerDataList()
                self.trigger_data_list.append(temp_model.from_map(k))
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        return self


class SyncDataResponseBodyList(TeaModel):
    def __init__(
        self,
        trigger_id: str = None,
        biz_primary_key: str = None,
        success: bool = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
    ):
        self.trigger_id = trigger_id
        self.biz_primary_key = biz_primary_key
        self.success = success
        self.sub_err_code = sub_err_code
        self.sub_err_msg = sub_err_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        if self.biz_primary_key is not None:
            result['bizPrimaryKey'] = self.biz_primary_key
        if self.success is not None:
            result['success'] = self.success
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
        if m.get('bizPrimaryKey') is not None:
            self.biz_primary_key = m.get('bizPrimaryKey')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        return self


class SyncDataResponseBody(TeaModel):
    def __init__(
        self,
        list: List[SyncDataResponseBodyList] = None,
    ):
        # resultList
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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = SyncDataResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class SyncDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncDataResponseBody = None,
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
            temp_model = SyncDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateConnectorHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateConnectorRequestConnectorInfo(TeaModel):
    def __init__(
        self,
        integrator_connector_id: str = None,
        name: str = None,
        description: str = None,
        icon_media_id: str = None,
        app_id: int = None,
        api_domain: str = None,
        api_secret: str = None,
        base_variables: List[str] = None,
    ):
        self.integrator_connector_id = integrator_connector_id
        self.name = name
        self.description = description
        self.icon_media_id = icon_media_id
        self.app_id = app_id
        # 连接器下action api请求url域名，当baseVariables中无apiDomain，该项必填
        self.api_domain = api_domain
        # 连接器下action api请求时使用http加密签名，当baseVariables无apiSecret，该项必填
        self.api_secret = api_secret
        # 变量列表。目前支持将apiDomain、apiSecret声明为基础变量。若声明为变量，则对应属性可不传值
        self.base_variables = base_variables

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.name is not None:
            result['name'] = self.name
        if self.description is not None:
            result['description'] = self.description
        if self.icon_media_id is not None:
            result['iconMediaId'] = self.icon_media_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.api_domain is not None:
            result['apiDomain'] = self.api_domain
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.base_variables is not None:
            result['baseVariables'] = self.base_variables
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('iconMediaId') is not None:
            self.icon_media_id = m.get('iconMediaId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('apiDomain') is not None:
            self.api_domain = m.get('apiDomain')
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('baseVariables') is not None:
            self.base_variables = m.get('baseVariables')
        return self


class CreateConnectorRequest(TeaModel):
    def __init__(
        self,
        connector_info: List[CreateConnectorRequestConnectorInfo] = None,
    ):
        self.connector_info = connector_info

    def validate(self):
        if self.connector_info:
            for k in self.connector_info:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['connectorInfo'] = []
        if self.connector_info is not None:
            for k in self.connector_info:
                result['connectorInfo'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.connector_info = []
        if m.get('connectorInfo') is not None:
            for k in m.get('connectorInfo'):
                temp_model = CreateConnectorRequestConnectorInfo()
                self.connector_info.append(temp_model.from_map(k))
        return self


class CreateConnectorResponseBodyItem(TeaModel):
    def __init__(
        self,
        integrator_connector_id: str = None,
        ding_connector_id: str = None,
        success: bool = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
    ):
        # 服务商连接器connectorId
        self.integrator_connector_id = integrator_connector_id
        # 连接平台connectorId
        self.ding_connector_id = ding_connector_id
        # 是否成功
        self.success = success
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.success is not None:
            result['success'] = self.success
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        return self


class CreateConnectorResponseBody(TeaModel):
    def __init__(
        self,
        item: List[CreateConnectorResponseBodyItem] = None,
    ):
        # responseUnitList
        self.item = item

    def validate(self):
        if self.item:
            for k in self.item:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['item'] = []
        if self.item is not None:
            for k in self.item:
                result['item'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item = []
        if m.get('item') is not None:
            for k in m.get('item'):
                temp_model = CreateConnectorResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class CreateConnectorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateConnectorResponseBody = None,
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
            temp_model = CreateConnectorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PullDataByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PullDataByPageRequest(TeaModel):
    def __init__(
        self,
        data_model_id: str = None,
        datetime_filter_field: str = None,
        min_datetime: int = None,
        max_datetime: int = None,
        next_token: str = None,
        max_results: int = None,
        app_id: str = None,
    ):
        # 要拉取的主数据模型id。
        self.data_model_id = data_model_id
        # 用于过滤时间范围的字段，包含数据创建时间(dataGmtCreate)和数据修改时间(dataGmtModified)，如不传则不过滤。
        self.datetime_filter_field = datetime_filter_field
        # 当配置了datetimeFilterField字段后，数据的时间起点，如果不传则将最早一条数据作为起点。
        self.min_datetime = min_datetime
        # 当配置了datetimeFilterField字段后，数据的时间终点，如果不传则按最新一条数据作为终点。
        self.max_datetime = max_datetime
        # 用于翻页的游标，如果为空则从第一条数据开始查询。
        self.next_token = next_token
        # 单次获取的最大记录条数，最大限制100条。
        self.max_results = max_results
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_model_id is not None:
            result['dataModelId'] = self.data_model_id
        if self.datetime_filter_field is not None:
            result['datetimeFilterField'] = self.datetime_filter_field
        if self.min_datetime is not None:
            result['minDatetime'] = self.min_datetime
        if self.max_datetime is not None:
            result['maxDatetime'] = self.max_datetime
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.app_id is not None:
            result['appId'] = self.app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataModelId') is not None:
            self.data_model_id = m.get('dataModelId')
        if m.get('datetimeFilterField') is not None:
            self.datetime_filter_field = m.get('datetimeFilterField')
        if m.get('minDatetime') is not None:
            self.min_datetime = m.get('minDatetime')
        if m.get('maxDatetime') is not None:
            self.max_datetime = m.get('maxDatetime')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        return self


class PullDataByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        data_create_app_type: str = None,
        data_create_app_id: str = None,
        data_modified_app_type: str = None,
        data_modified_app_id: str = None,
        json_data: str = None,
    ):
        # 数据创建时间。
        self.data_gmt_create = data_gmt_create
        # 数据最后修改时间。
        self.data_gmt_modified = data_gmt_modified
        # 创建数据的应用类型，isv应用为premium_microapp。
        self.data_create_app_type = data_create_app_type
        # 创建数据的应用id。
        self.data_create_app_id = data_create_app_id
        # 最后修改数据的应用类型，取值同dataCreateAppType。
        self.data_modified_app_type = data_modified_app_type
        # 最后修改数据的应用id。
        self.data_modified_app_id = data_modified_app_id
        # 数据完整内容。
        self.json_data = json_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.data_create_app_type is not None:
            result['dataCreateAppType'] = self.data_create_app_type
        if self.data_create_app_id is not None:
            result['dataCreateAppId'] = self.data_create_app_id
        if self.data_modified_app_type is not None:
            result['dataModifiedAppType'] = self.data_modified_app_type
        if self.data_modified_app_id is not None:
            result['dataModifiedAppId'] = self.data_modified_app_id
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('dataCreateAppType') is not None:
            self.data_create_app_type = m.get('dataCreateAppType')
        if m.get('dataCreateAppId') is not None:
            self.data_create_app_id = m.get('dataCreateAppId')
        if m.get('dataModifiedAppType') is not None:
            self.data_modified_app_type = m.get('dataModifiedAppType')
        if m.get('dataModifiedAppId') is not None:
            self.data_modified_app_id = m.get('dataModifiedAppId')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        return self


class PullDataByPageResponseBody(TeaModel):
    def __init__(
        self,
        list: List[PullDataByPageResponseBodyList] = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # resultList
        self.list = list
        # 用于查看下一页数据的游标，如果为空则说明没有更多数据了。
        self.next_token = next_token
        # 单次获取的最大记录条数。
        self.max_results = max_results

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PullDataByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class PullDataByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PullDataByPageResponseBody = None,
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
            temp_model = PullDataByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTriggerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateTriggerRequestTriggerInfo(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        name: str = None,
        description: str = None,
        input_schema: str = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的连接器Id，优先使用dingConnectorId，其次使用integratorConnectorId
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件Id
        self.integrator_trigger_id = integrator_trigger_id
        # 名称
        self.name = name
        # 描述
        self.description = description
        # 入参jsonSchema
        self.input_schema = input_schema

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.name is not None:
            result['name'] = self.name
        if self.description is not None:
            result['description'] = self.description
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        return self


class CreateTriggerRequest(TeaModel):
    def __init__(
        self,
        trigger_info: List[CreateTriggerRequestTriggerInfo] = None,
    ):
        self.trigger_info = trigger_info

    def validate(self):
        if self.trigger_info:
            for k in self.trigger_info:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['triggerInfo'] = []
        if self.trigger_info is not None:
            for k in self.trigger_info:
                result['triggerInfo'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.trigger_info = []
        if m.get('triggerInfo') is not None:
            for k in m.get('triggerInfo'):
                temp_model = CreateTriggerRequestTriggerInfo()
                self.trigger_info.append(temp_model.from_map(k))
        return self


class CreateTriggerResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        ding_trigger_id: str = None,
        success: bool = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件id
        self.integrator_trigger_id = integrator_trigger_id
        # 连接平台触发事件id
        self.ding_trigger_id = ding_trigger_id
        # 是否成功
        self.success = success
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.ding_trigger_id is not None:
            result['dingTriggerId'] = self.ding_trigger_id
        if self.success is not None:
            result['success'] = self.success
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('dingTriggerId') is not None:
            self.ding_trigger_id = m.get('dingTriggerId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        return self


class CreateTriggerResponseBody(TeaModel):
    def __init__(
        self,
        item: List[CreateTriggerResponseBodyItem] = None,
    ):
        # Id of the request
        self.item = item

    def validate(self):
        if self.item:
            for k in self.item:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['item'] = []
        if self.item is not None:
            for k in self.item:
                result['item'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item = []
        if m.get('item') is not None:
            for k in m.get('item'):
                temp_model = CreateTriggerResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class CreateTriggerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTriggerResponseBody = None,
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
            temp_model = CreateTriggerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateActionHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateActionRequestActionInfo(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        integrator_action_id: str = None,
        name: str = None,
        description: str = None,
        api_path: str = None,
        input_schema: str = None,
        output_schema: str = None,
        api_url: str = None,
        api_secret: str = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 服务商的执行事件Id
        self.integrator_action_id = integrator_action_id
        # 名称
        self.name = name
        # 描述
        self.description = description
        # api请求url path，结合Connector上的apiDomain使用
        self.api_path = api_path
        # 入参schema
        self.input_schema = input_schema
        # 出参schema
        self.output_schema = output_schema
        # action维度的api请求url
        self.api_url = api_url
        # action维度的apiSecret
        self.api_secret = api_secret

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.name is not None:
            result['name'] = self.name
        if self.description is not None:
            result['description'] = self.description
        if self.api_path is not None:
            result['apiPath'] = self.api_path
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.output_schema is not None:
            result['outputSchema'] = self.output_schema
        if self.api_url is not None:
            result['apiUrl'] = self.api_url
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('apiPath') is not None:
            self.api_path = m.get('apiPath')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('outputSchema') is not None:
            self.output_schema = m.get('outputSchema')
        if m.get('apiUrl') is not None:
            self.api_url = m.get('apiUrl')
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        return self


class CreateActionRequest(TeaModel):
    def __init__(
        self,
        action_info: List[CreateActionRequestActionInfo] = None,
    ):
        self.action_info = action_info

    def validate(self):
        if self.action_info:
            for k in self.action_info:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionInfo'] = []
        if self.action_info is not None:
            for k in self.action_info:
                result['actionInfo'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_info = []
        if m.get('actionInfo') is not None:
            for k in m.get('actionInfo'):
                temp_model = CreateActionRequestActionInfo()
                self.action_info.append(temp_model.from_map(k))
        return self


class CreateActionResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        integrator_action_id: str = None,
        ding_action_id: str = None,
        success: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 服务商的执行事件id
        self.integrator_action_id = integrator_action_id
        # 连接平台执行事件id
        self.ding_action_id = ding_action_id
        # 是否执行成功
        self.success = success
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.ding_action_id is not None:
            result['dingActionId'] = self.ding_action_id
        if self.success is not None:
            result['success'] = self.success
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('dingActionId') is not None:
            self.ding_action_id = m.get('dingActionId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        return self


class CreateActionResponseBody(TeaModel):
    def __init__(
        self,
        item: List[CreateActionResponseBodyItem] = None,
    ):
        # Id of the request
        self.item = item

    def validate(self):
        if self.item:
            for k in self.item:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['item'] = []
        if self.item is not None:
            for k in self.item:
                result['item'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item = []
        if m.get('item') is not None:
            for k in m.get('item'):
                temp_model = CreateActionResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class CreateActionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateActionResponseBody = None,
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
            temp_model = CreateActionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


