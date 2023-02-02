# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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


class CreateActionRequestActionInfoInputMappingConfig(TeaModel):
    def __init__(
        self,
        custom_schema_mapping: str = None,
        rules: str = None,
    ):
        self.custom_schema_mapping = custom_schema_mapping
        self.rules = rules

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_schema_mapping is not None:
            result['customSchemaMapping'] = self.custom_schema_mapping
        if self.rules is not None:
            result['rules'] = self.rules
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customSchemaMapping') is not None:
            self.custom_schema_mapping = m.get('customSchemaMapping')
        if m.get('rules') is not None:
            self.rules = m.get('rules')
        return self


class CreateActionRequestActionInfoOutputDataRules(TeaModel):
    def __init__(
        self,
        expect_value: str = None,
        operate: str = None,
        property_path: str = None,
    ):
        # 规则的预期值。
        self.expect_value = expect_value
        # 操作类型。
        self.operate = operate
        # 规则的属性路径。
        self.property_path = property_path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expect_value is not None:
            result['expectValue'] = self.expect_value
        if self.operate is not None:
            result['operate'] = self.operate
        if self.property_path is not None:
            result['propertyPath'] = self.property_path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expectValue') is not None:
            self.expect_value = m.get('expectValue')
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('propertyPath') is not None:
            self.property_path = m.get('propertyPath')
        return self


class CreateActionRequestActionInfoOutputMappingConfig(TeaModel):
    def __init__(
        self,
        custom_schema_mapping: str = None,
        rules: str = None,
    ):
        self.custom_schema_mapping = custom_schema_mapping
        self.rules = rules

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_schema_mapping is not None:
            result['customSchemaMapping'] = self.custom_schema_mapping
        if self.rules is not None:
            result['rules'] = self.rules
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customSchemaMapping') is not None:
            self.custom_schema_mapping = m.get('customSchemaMapping')
        if m.get('rules') is not None:
            self.rules = m.get('rules')
        return self


class CreateActionRequestActionInfo(TeaModel):
    def __init__(
        self,
        api_path: str = None,
        description: str = None,
        ding_connector_id: str = None,
        input_mapping_config: CreateActionRequestActionInfoInputMappingConfig = None,
        input_schema: str = None,
        integrator_action_id: str = None,
        integrator_connector_id: str = None,
        name: str = None,
        output_data_rules: List[CreateActionRequestActionInfoOutputDataRules] = None,
        output_mapping_config: CreateActionRequestActionInfoOutputMappingConfig = None,
        output_schema: str = None,
    ):
        # api请求url path，结合Connector上的apiDomain使用
        self.api_path = api_path
        # 描述
        self.description = description
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        self.input_mapping_config = input_mapping_config
        # 入参schema
        self.input_schema = input_schema
        # 服务商的执行事件Id
        self.integrator_action_id = integrator_action_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 名称
        self.name = name
        # 执行动作接口成功调用规则。
        self.output_data_rules = output_data_rules
        self.output_mapping_config = output_mapping_config
        # 出参schema
        self.output_schema = output_schema

    def validate(self):
        if self.input_mapping_config:
            self.input_mapping_config.validate()
        if self.output_data_rules:
            for k in self.output_data_rules:
                if k:
                    k.validate()
        if self.output_mapping_config:
            self.output_mapping_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_path is not None:
            result['apiPath'] = self.api_path
        if self.description is not None:
            result['description'] = self.description
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.input_mapping_config is not None:
            result['inputMappingConfig'] = self.input_mapping_config.to_map()
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.name is not None:
            result['name'] = self.name
        result['outputDataRules'] = []
        if self.output_data_rules is not None:
            for k in self.output_data_rules:
                result['outputDataRules'].append(k.to_map() if k else None)
        if self.output_mapping_config is not None:
            result['outputMappingConfig'] = self.output_mapping_config.to_map()
        if self.output_schema is not None:
            result['outputSchema'] = self.output_schema
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiPath') is not None:
            self.api_path = m.get('apiPath')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('inputMappingConfig') is not None:
            temp_model = CreateActionRequestActionInfoInputMappingConfig()
            self.input_mapping_config = temp_model.from_map(m['inputMappingConfig'])
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.output_data_rules = []
        if m.get('outputDataRules') is not None:
            for k in m.get('outputDataRules'):
                temp_model = CreateActionRequestActionInfoOutputDataRules()
                self.output_data_rules.append(temp_model.from_map(k))
        if m.get('outputMappingConfig') is not None:
            temp_model = CreateActionRequestActionInfoOutputMappingConfig()
            self.output_mapping_config = temp_model.from_map(m['outputMappingConfig'])
        if m.get('outputSchema') is not None:
            self.output_schema = m.get('outputSchema')
        return self


class CreateActionRequest(TeaModel):
    def __init__(
        self,
        action_info: List[CreateActionRequestActionInfo] = None,
        integrator_flag: str = None,
    ):
        self.action_info = action_info
        self.integrator_flag = integrator_flag

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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_info = []
        if m.get('actionInfo') is not None:
            for k in m.get('actionInfo'):
                temp_model = CreateActionRequestActionInfo()
                self.action_info.append(temp_model.from_map(k))
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
        return self


class CreateActionResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_action_id: str = None,
        ding_connector_id: str = None,
        integrator_action_id: str = None,
        integrator_connector_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: str = None,
    ):
        # 连接平台执行事件id
        self.ding_action_id = ding_action_id
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的执行事件id
        self.integrator_action_id = integrator_action_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否执行成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_action_id is not None:
            result['dingActionId'] = self.ding_action_id
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingActionId') is not None:
            self.ding_action_id = m.get('dingActionId')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
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
        api_domain: str = None,
        api_secret: str = None,
        app_id: int = None,
        auth_value_env: bool = None,
        description: str = None,
        domain_env: bool = None,
        icon_media_id: str = None,
        integrator_connector_id: str = None,
        name: str = None,
    ):
        # 连接器中执行动作的接口路径域名。
        self.api_domain = api_domain
        # 连接器中执行动作接口的加密签名。
        self.api_secret = api_secret
        self.app_id = app_id
        # 将apiSecret设置为模板变量。
        self.auth_value_env = auth_value_env
        self.description = description
        # 将执行动作域名设为环境变量。
        self.domain_env = domain_env
        self.icon_media_id = icon_media_id
        self.integrator_connector_id = integrator_connector_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_domain is not None:
            result['apiDomain'] = self.api_domain
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.auth_value_env is not None:
            result['authValueEnv'] = self.auth_value_env
        if self.description is not None:
            result['description'] = self.description
        if self.domain_env is not None:
            result['domainEnv'] = self.domain_env
        if self.icon_media_id is not None:
            result['iconMediaId'] = self.icon_media_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiDomain') is not None:
            self.api_domain = m.get('apiDomain')
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('authValueEnv') is not None:
            self.auth_value_env = m.get('authValueEnv')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('domainEnv') is not None:
            self.domain_env = m.get('domainEnv')
        if m.get('iconMediaId') is not None:
            self.icon_media_id = m.get('iconMediaId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateConnectorRequest(TeaModel):
    def __init__(
        self,
        connector_info: List[CreateConnectorRequestConnectorInfo] = None,
        integrator_flag: str = None,
    ):
        self.connector_info = connector_info
        self.integrator_flag = integrator_flag

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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.connector_info = []
        if m.get('connectorInfo') is not None:
            for k in m.get('connectorInfo'):
                temp_model = CreateConnectorRequestConnectorInfo()
                self.connector_info.append(temp_model.from_map(k))
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
        return self


class CreateConnectorResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: bool = None,
    ):
        # 连接平台connectorId
        self.ding_connector_id = ding_connector_id
        # 服务商连接器connectorId
        self.integrator_connector_id = integrator_connector_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否成功
        self.success = success

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
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
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


class CreateInvocableInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateInvocableInstanceRequest(TeaModel):
    def __init__(
        self,
        connect_asset_uri: str = None,
        instance_key: str = None,
    ):
        # 连接资产标识
        self.connect_asset_uri = connect_asset_uri
        # 关联实例标识
        self.instance_key = instance_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        if self.instance_key is not None:
            result['instanceKey'] = self.instance_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        if m.get('instanceKey') is not None:
            self.instance_key = m.get('instanceKey')
        return self


class CreateInvocableInstanceResponseBody(TeaModel):
    def __init__(
        self,
        connect_asset_uri: str = None,
        version_id: str = None,
    ):
        # 资产标识
        self.connect_asset_uri = connect_asset_uri
        # 连接实例版本ID
        self.version_id = version_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        if self.version_id is not None:
            result['versionId'] = self.version_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        if m.get('versionId') is not None:
            self.version_id = m.get('versionId')
        return self


class CreateInvocableInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateInvocableInstanceResponseBody = None,
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
            temp_model = CreateInvocableInstanceResponseBody()
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
        description: str = None,
        ding_connector_id: str = None,
        input_schema: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        name: str = None,
    ):
        # 描述
        self.description = description
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 入参jsonSchema
        self.input_schema = input_schema
        # 服务商的连接器Id，优先使用dingConnectorId，其次使用integratorConnectorId
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件Id
        self.integrator_trigger_id = integrator_trigger_id
        # 名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateTriggerRequest(TeaModel):
    def __init__(
        self,
        integrator_flag: str = None,
        trigger_info: List[CreateTriggerRequestTriggerInfo] = None,
    ):
        self.integrator_flag = integrator_flag
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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        result['triggerInfo'] = []
        if self.trigger_info is not None:
            for k in self.trigger_info:
                result['triggerInfo'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
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
        ding_trigger_id: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: bool = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 连接平台触发事件id
        self.ding_trigger_id = ding_trigger_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件id
        self.integrator_trigger_id = integrator_trigger_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.ding_trigger_id is not None:
            result['dingTriggerId'] = self.ding_trigger_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('dingTriggerId') is not None:
            self.ding_trigger_id = m.get('dingTriggerId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
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


class GetActionDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetActionDetailRequest(TeaModel):
    def __init__(
        self,
        connect_asset_uri: str = None,
    ):
        # 连接资产标识
        self.connect_asset_uri = connect_asset_uri

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        return self


class GetActionDetailResponseBodyIntegrationConfigCategoryNames(TeaModel):
    def __init__(
        self,
        value: str = None,
    ):
        # 类目名称
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetActionDetailResponseBodyIntegrationConfigProps(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 配置的KEY值
        self.key = key
        # 配置的属性值
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
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetActionDetailResponseBodyIntegrationConfig(TeaModel):
    def __init__(
        self,
        category_names: List[GetActionDetailResponseBodyIntegrationConfigCategoryNames] = None,
        entity_name: str = None,
        props: List[GetActionDetailResponseBodyIntegrationConfigProps] = None,
    ):
        # 类目配置
        self.category_names = category_names
        # 集成对象的名称
        self.entity_name = entity_name
        # 其它额外属性
        self.props = props

    def validate(self):
        if self.category_names:
            for k in self.category_names:
                if k:
                    k.validate()
        if self.props:
            for k in self.props:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categoryNames'] = []
        if self.category_names is not None:
            for k in self.category_names:
                result['categoryNames'].append(k.to_map() if k else None)
        if self.entity_name is not None:
            result['entityName'] = self.entity_name
        result['props'] = []
        if self.props is not None:
            for k in self.props:
                result['props'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.category_names = []
        if m.get('categoryNames') is not None:
            for k in m.get('categoryNames'):
                temp_model = GetActionDetailResponseBodyIntegrationConfigCategoryNames()
                self.category_names.append(temp_model.from_map(k))
        if m.get('entityName') is not None:
            self.entity_name = m.get('entityName')
        self.props = []
        if m.get('props') is not None:
            for k in m.get('props'):
                temp_model = GetActionDetailResponseBodyIntegrationConfigProps()
                self.props.append(temp_model.from_map(k))
        return self


class GetActionDetailResponseBody(TeaModel):
    def __init__(
        self,
        connect_asset_uri: str = None,
        input_schema: str = None,
        integration_config: GetActionDetailResponseBodyIntegrationConfig = None,
        name: str = None,
        output_schema: str = None,
        ref_id: str = None,
        ref_provider_corp_id: str = None,
        ref_type: str = None,
    ):
        # 连接资产标识
        self.connect_asset_uri = connect_asset_uri
        # 调用时以JsonSchema描述的入参格式
        self.input_schema = input_schema
        # 执行动作集成配置信息
        self.integration_config = integration_config
        # 执行动作的名称
        self.name = name
        # 调用时以JsonSchema描述的出参格式
        self.output_schema = output_schema
        # 执行动作的ID
        self.ref_id = ref_id
        # 执行动作提供组织
        self.ref_provider_corp_id = ref_provider_corp_id
        # 连接资产类型
        self.ref_type = ref_type

    def validate(self):
        if self.integration_config:
            self.integration_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.integration_config is not None:
            result['integrationConfig'] = self.integration_config.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.output_schema is not None:
            result['outputSchema'] = self.output_schema
        if self.ref_id is not None:
            result['refId'] = self.ref_id
        if self.ref_provider_corp_id is not None:
            result['refProviderCorpId'] = self.ref_provider_corp_id
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('integrationConfig') is not None:
            temp_model = GetActionDetailResponseBodyIntegrationConfig()
            self.integration_config = temp_model.from_map(m['integrationConfig'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outputSchema') is not None:
            self.output_schema = m.get('outputSchema')
        if m.get('refId') is not None:
            self.ref_id = m.get('refId')
        if m.get('refProviderCorpId') is not None:
            self.ref_provider_corp_id = m.get('refProviderCorpId')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        return self


class GetActionDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetActionDetailResponseBody = None,
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
            temp_model = GetActionDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InvokeInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class InvokeInstanceRequest(TeaModel):
    def __init__(
        self,
        connect_asset_uri: str = None,
        input_json_string: str = None,
        instance_key: str = None,
    ):
        # 连接资产标识
        self.connect_asset_uri = connect_asset_uri
        # 入参JSON文本
        self.input_json_string = input_json_string
        # 外部实例唯一标识
        self.instance_key = instance_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        if self.input_json_string is not None:
            result['inputJsonString'] = self.input_json_string
        if self.instance_key is not None:
            result['instanceKey'] = self.instance_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        if m.get('inputJsonString') is not None:
            self.input_json_string = m.get('inputJsonString')
        if m.get('instanceKey') is not None:
            self.instance_key = m.get('instanceKey')
        return self


class InvokeInstanceResponseBody(TeaModel):
    def __init__(
        self,
        cost: int = None,
        error_code: str = None,
        error_message: str = None,
        instance_id: str = None,
        output_json: str = None,
    ):
        # 本次执行耗时
        self.cost = cost
        # 连接器错误码
        self.error_code = error_code
        # 连接器错误信息
        self.error_message = error_message
        # 调用记录的ID
        self.instance_id = instance_id
        # Id of the request
        self.output_json = output_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cost is not None:
            result['cost'] = self.cost
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_message is not None:
            result['errorMessage'] = self.error_message
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.output_json is not None:
            result['outputJson'] = self.output_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cost') is not None:
            self.cost = m.get('cost')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMessage') is not None:
            self.error_message = m.get('errorMessage')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('outputJson') is not None:
            self.output_json = m.get('outputJson')
        return self


class InvokeInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InvokeInstanceResponseBody = None,
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
            temp_model = InvokeInstanceResponseBody()
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
        app_id: str = None,
        data_model_id: str = None,
        datetime_filter_field: str = None,
        max_datetime: int = None,
        max_results: int = None,
        min_datetime: int = None,
        next_token: str = None,
    ):
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id
        # 要拉取的主数据模型id。
        self.data_model_id = data_model_id
        # 用于过滤时间范围的字段，包含数据创建时间(dataGmtCreate)和数据修改时间(dataGmtModified)，如不传则不过滤。
        self.datetime_filter_field = datetime_filter_field
        # 当配置了datetimeFilterField字段后，数据的时间终点，如果不传则按最新一条数据作为终点。
        self.max_datetime = max_datetime
        # 单次获取的最大记录条数，最大限制100条。
        self.max_results = max_results
        # 当配置了datetimeFilterField字段后，数据的时间起点，如果不传则将最早一条数据作为起点。
        self.min_datetime = min_datetime
        # 用于翻页的游标，如果为空则从第一条数据开始查询。
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.data_model_id is not None:
            result['dataModelId'] = self.data_model_id
        if self.datetime_filter_field is not None:
            result['datetimeFilterField'] = self.datetime_filter_field
        if self.max_datetime is not None:
            result['maxDatetime'] = self.max_datetime
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.min_datetime is not None:
            result['minDatetime'] = self.min_datetime
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('dataModelId') is not None:
            self.data_model_id = m.get('dataModelId')
        if m.get('datetimeFilterField') is not None:
            self.datetime_filter_field = m.get('datetimeFilterField')
        if m.get('maxDatetime') is not None:
            self.max_datetime = m.get('maxDatetime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('minDatetime') is not None:
            self.min_datetime = m.get('minDatetime')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PullDataByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        data_create_app_id: str = None,
        data_create_app_type: str = None,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        data_modified_app_id: str = None,
        data_modified_app_type: str = None,
        json_data: str = None,
    ):
        # 创建数据的应用id。
        self.data_create_app_id = data_create_app_id
        # 创建数据的应用类型，isv应用为premium_microapp。
        self.data_create_app_type = data_create_app_type
        # 数据创建时间。
        self.data_gmt_create = data_gmt_create
        # 数据最后修改时间。
        self.data_gmt_modified = data_gmt_modified
        # 最后修改数据的应用id。
        self.data_modified_app_id = data_modified_app_id
        # 最后修改数据的应用类型，取值同dataCreateAppType。
        self.data_modified_app_type = data_modified_app_type
        # 数据完整内容。
        self.json_data = json_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_create_app_id is not None:
            result['dataCreateAppId'] = self.data_create_app_id
        if self.data_create_app_type is not None:
            result['dataCreateAppType'] = self.data_create_app_type
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.data_modified_app_id is not None:
            result['dataModifiedAppId'] = self.data_modified_app_id
        if self.data_modified_app_type is not None:
            result['dataModifiedAppType'] = self.data_modified_app_type
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataCreateAppId') is not None:
            self.data_create_app_id = m.get('dataCreateAppId')
        if m.get('dataCreateAppType') is not None:
            self.data_create_app_type = m.get('dataCreateAppType')
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('dataModifiedAppId') is not None:
            self.data_modified_app_id = m.get('dataModifiedAppId')
        if m.get('dataModifiedAppType') is not None:
            self.data_modified_app_type = m.get('dataModifiedAppType')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        return self


class PullDataByPageResponseBody(TeaModel):
    def __init__(
        self,
        list: List[PullDataByPageResponseBodyList] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # resultList
        self.list = list
        # 单次获取的最大记录条数。
        self.max_results = max_results
        # 用于查看下一页数据的游标，如果为空则说明没有更多数据了。
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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PullDataByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
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
        app_id: str = None,
        primary_key: str = None,
    ):
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id
        # 数据的主键字段值。
        self.primary_key = primary_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.primary_key is not None:
            result['primaryKey'] = self.primary_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('primaryKey') is not None:
            self.primary_key = m.get('primaryKey')
        return self


class PullDataByPkResponseBody(TeaModel):
    def __init__(
        self,
        data_create_app_id: str = None,
        data_create_app_type: str = None,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        data_modified_app_id: str = None,
        data_modified_app_type: str = None,
        json_data: str = None,
    ):
        # 创建数据的应用id。
        self.data_create_app_id = data_create_app_id
        # 创建数据的应用类型，isv应用为premium_microapp。
        self.data_create_app_type = data_create_app_type
        # 数据创建时间。
        self.data_gmt_create = data_gmt_create
        # 数据最后修改时间。
        self.data_gmt_modified = data_gmt_modified
        # 最后修改数据的应用id。
        self.data_modified_app_id = data_modified_app_id
        # 最后修改数据的应用类型，取值同dataCreateAppType。
        self.data_modified_app_type = data_modified_app_type
        # 数据完整内容。
        self.json_data = json_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_create_app_id is not None:
            result['dataCreateAppId'] = self.data_create_app_id
        if self.data_create_app_type is not None:
            result['dataCreateAppType'] = self.data_create_app_type
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.data_modified_app_id is not None:
            result['dataModifiedAppId'] = self.data_modified_app_id
        if self.data_modified_app_type is not None:
            result['dataModifiedAppType'] = self.data_modified_app_type
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataCreateAppId') is not None:
            self.data_create_app_id = m.get('dataCreateAppId')
        if m.get('dataCreateAppType') is not None:
            self.data_create_app_type = m.get('dataCreateAppType')
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('dataModifiedAppId') is not None:
            self.data_modified_app_id = m.get('dataModifiedAppId')
        if m.get('dataModifiedAppType') is not None:
            self.data_modified_app_type = m.get('dataModifiedAppType')
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


class SearchActionsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SearchActionsRequest(TeaModel):
    def __init__(
        self,
        connector_id: str = None,
        connector_provider_corp_id: str = None,
        integration_types: List[str] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # 连接器的ID
        self.connector_id = connector_id
        # 连接器提供组织ID
        self.connector_provider_corp_id = connector_provider_corp_id
        # 集成类型，默认只有basic-基础类型
        self.integration_types = integration_types
        # 最大返回记录数
        self.max_results = max_results
        # 查询位置，为空表示从头开始
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.connector_id is not None:
            result['connectorId'] = self.connector_id
        if self.connector_provider_corp_id is not None:
            result['connectorProviderCorpId'] = self.connector_provider_corp_id
        if self.integration_types is not None:
            result['integrationTypes'] = self.integration_types
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('connectorId') is not None:
            self.connector_id = m.get('connectorId')
        if m.get('connectorProviderCorpId') is not None:
            self.connector_provider_corp_id = m.get('connectorProviderCorpId')
        if m.get('integrationTypes') is not None:
            self.integration_types = m.get('integrationTypes')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchActionsResponseBodyList(TeaModel):
    def __init__(
        self,
        authority_url: str = None,
        authorized: bool = None,
        connect_asset_uri: str = None,
        connector_id: str = None,
        description: str = None,
        icon: str = None,
        id: str = None,
        integration_type: str = None,
        name: str = None,
        provider_corp_id: str = None,
    ):
        # 授权页地址
        self.authority_url = authority_url
        # 是否已授权
        self.authorized = authorized
        # 连接资产唯一标识
        self.connect_asset_uri = connect_asset_uri
        # 执行动作所属连接器ID
        self.connector_id = connector_id
        # 描述
        self.description = description
        # 图标
        self.icon = icon
        # 执行动作的ID
        self.id = id
        # 集成类型
        self.integration_type = integration_type
        # 名称
        self.name = name
        # 提供组织
        self.provider_corp_id = provider_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authority_url is not None:
            result['authorityUrl'] = self.authority_url
        if self.authorized is not None:
            result['authorized'] = self.authorized
        if self.connect_asset_uri is not None:
            result['connectAssetUri'] = self.connect_asset_uri
        if self.connector_id is not None:
            result['connectorId'] = self.connector_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.integration_type is not None:
            result['integrationType'] = self.integration_type
        if self.name is not None:
            result['name'] = self.name
        if self.provider_corp_id is not None:
            result['providerCorpId'] = self.provider_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorityUrl') is not None:
            self.authority_url = m.get('authorityUrl')
        if m.get('authorized') is not None:
            self.authorized = m.get('authorized')
        if m.get('connectAssetUri') is not None:
            self.connect_asset_uri = m.get('connectAssetUri')
        if m.get('connectorId') is not None:
            self.connector_id = m.get('connectorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('integrationType') is not None:
            self.integration_type = m.get('integrationType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('providerCorpId') is not None:
            self.provider_corp_id = m.get('providerCorpId')
        return self


class SearchActionsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[SearchActionsResponseBodyList] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        # 是否有更多记录
        self.has_more = has_more
        # 执行动作列表
        self.list = list
        # 下一页位置
        self.next_token = next_token
        # 总记录数
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
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
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = SearchActionsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchActionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchActionsResponseBody = None,
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
            temp_model = SearchActionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchConnectorsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SearchConnectorsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        type: str = None,
    ):
        # 最大返回记录数，最多50
        self.max_results = max_results
        # 查询指定位置的记录，为空则从头开始
        self.next_token = next_token
        # 查询连接器的类型
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


class SearchConnectorsResponseBodyList(TeaModel):
    def __init__(
        self,
        description: str = None,
        icon: str = None,
        id: str = None,
        name: str = None,
        provider_corp_id: str = None,
    ):
        # 连接器的描述信息
        self.description = description
        # 连接器的图标
        self.icon = icon
        # 连接器的ID
        self.id = id
        # 连接器的名称
        self.name = name
        # 连接器的提供组织
        self.provider_corp_id = provider_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.provider_corp_id is not None:
            result['providerCorpId'] = self.provider_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('providerCorpId') is not None:
            self.provider_corp_id = m.get('providerCorpId')
        return self


class SearchConnectorsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[SearchConnectorsResponseBodyList] = None,
        next_token: str = None,
        total_count: str = None,
    ):
        # 是否有更多记录
        self.has_more = has_more
        # 连接器信息列表
        self.list = list
        # 下一页记录的查询位置
        self.next_token = next_token
        # 总记录数
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
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
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = SearchConnectorsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchConnectorsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchConnectorsResponseBody = None,
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
            temp_model = SearchConnectorsResponseBody()
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
        action: str = None,
        custom_trigger_id: str = None,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        integration_object: str = None,
        json_data: str = None,
        trigger_condition: str = None,
        trigger_id: str = None,
    ):
        self.action = action
        self.custom_trigger_id = custom_trigger_id
        self.data_gmt_create = data_gmt_create
        self.data_gmt_modified = data_gmt_modified
        self.integration_object = integration_object
        self.json_data = json_data
        self.trigger_condition = trigger_condition
        self.trigger_id = trigger_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.custom_trigger_id is not None:
            result['customTriggerId'] = self.custom_trigger_id
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.integration_object is not None:
            result['integrationObject'] = self.integration_object
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        if self.trigger_condition is not None:
            result['triggerCondition'] = self.trigger_condition
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('customTriggerId') is not None:
            self.custom_trigger_id = m.get('customTriggerId')
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('integrationObject') is not None:
            self.integration_object = m.get('integrationObject')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        if m.get('triggerCondition') is not None:
            self.trigger_condition = m.get('triggerCondition')
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
        return self


class SyncDataRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        trigger_data_list: List[SyncDataRequestTriggerDataList] = None,
    ):
        # 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
        self.app_id = app_id
        self.trigger_data_list = trigger_data_list

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
        if self.app_id is not None:
            result['appId'] = self.app_id
        result['triggerDataList'] = []
        if self.trigger_data_list is not None:
            for k in self.trigger_data_list:
                result['triggerDataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        self.trigger_data_list = []
        if m.get('triggerDataList') is not None:
            for k in m.get('triggerDataList'):
                temp_model = SyncDataRequestTriggerDataList()
                self.trigger_data_list.append(temp_model.from_map(k))
        return self


class SyncDataResponseBodyList(TeaModel):
    def __init__(
        self,
        biz_primary_key: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: bool = None,
        trigger_id: str = None,
    ):
        self.biz_primary_key = biz_primary_key
        self.sub_err_code = sub_err_code
        self.sub_err_msg = sub_err_msg
        self.success = success
        self.trigger_id = trigger_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_primary_key is not None:
            result['bizPrimaryKey'] = self.biz_primary_key
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizPrimaryKey') is not None:
            self.biz_primary_key = m.get('bizPrimaryKey')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
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


class UpdateActionHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateActionRequestActionInfoInputMappingConfig(TeaModel):
    def __init__(
        self,
        custom_schema_mapping: str = None,
        rules: str = None,
    ):
        self.custom_schema_mapping = custom_schema_mapping
        self.rules = rules

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_schema_mapping is not None:
            result['customSchemaMapping'] = self.custom_schema_mapping
        if self.rules is not None:
            result['rules'] = self.rules
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customSchemaMapping') is not None:
            self.custom_schema_mapping = m.get('customSchemaMapping')
        if m.get('rules') is not None:
            self.rules = m.get('rules')
        return self


class UpdateActionRequestActionInfoOutputDataRules(TeaModel):
    def __init__(
        self,
        expect_value: str = None,
        operate: str = None,
        property_path: str = None,
    ):
        # 规则的预期值。
        self.expect_value = expect_value
        # 操作类型。
        self.operate = operate
        # 规则的属性路径。
        self.property_path = property_path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expect_value is not None:
            result['expectValue'] = self.expect_value
        if self.operate is not None:
            result['operate'] = self.operate
        if self.property_path is not None:
            result['propertyPath'] = self.property_path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expectValue') is not None:
            self.expect_value = m.get('expectValue')
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('propertyPath') is not None:
            self.property_path = m.get('propertyPath')
        return self


class UpdateActionRequestActionInfoOutputMappingConfig(TeaModel):
    def __init__(
        self,
        custom_schema_mapping: str = None,
        rules: str = None,
    ):
        self.custom_schema_mapping = custom_schema_mapping
        self.rules = rules

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_schema_mapping is not None:
            result['customSchemaMapping'] = self.custom_schema_mapping
        if self.rules is not None:
            result['rules'] = self.rules
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customSchemaMapping') is not None:
            self.custom_schema_mapping = m.get('customSchemaMapping')
        if m.get('rules') is not None:
            self.rules = m.get('rules')
        return self


class UpdateActionRequestActionInfo(TeaModel):
    def __init__(
        self,
        api_path: str = None,
        description: str = None,
        ding_action_id: str = None,
        ding_connector_id: str = None,
        input_mapping_config: UpdateActionRequestActionInfoInputMappingConfig = None,
        input_schema: str = None,
        integrator_action_id: str = None,
        integrator_connector_id: str = None,
        name: str = None,
        output_data_rules: List[UpdateActionRequestActionInfoOutputDataRules] = None,
        output_mapping_config: UpdateActionRequestActionInfoOutputMappingConfig = None,
        output_schema: str = None,
    ):
        # api请求url path，结合Connector上的apiDomain使用
        self.api_path = api_path
        # 描述
        self.description = description
        # 连接平台的执行动作唯一标识。
        self.ding_action_id = ding_action_id
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        self.input_mapping_config = input_mapping_config
        # 入参schema
        self.input_schema = input_schema
        # 服务商的执行事件Id
        self.integrator_action_id = integrator_action_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 名称
        self.name = name
        # 执行动作接口成功调用规则。
        self.output_data_rules = output_data_rules
        self.output_mapping_config = output_mapping_config
        # 出参schema
        self.output_schema = output_schema

    def validate(self):
        if self.input_mapping_config:
            self.input_mapping_config.validate()
        if self.output_data_rules:
            for k in self.output_data_rules:
                if k:
                    k.validate()
        if self.output_mapping_config:
            self.output_mapping_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_path is not None:
            result['apiPath'] = self.api_path
        if self.description is not None:
            result['description'] = self.description
        if self.ding_action_id is not None:
            result['dingActionId'] = self.ding_action_id
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.input_mapping_config is not None:
            result['inputMappingConfig'] = self.input_mapping_config.to_map()
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.name is not None:
            result['name'] = self.name
        result['outputDataRules'] = []
        if self.output_data_rules is not None:
            for k in self.output_data_rules:
                result['outputDataRules'].append(k.to_map() if k else None)
        if self.output_mapping_config is not None:
            result['outputMappingConfig'] = self.output_mapping_config.to_map()
        if self.output_schema is not None:
            result['outputSchema'] = self.output_schema
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiPath') is not None:
            self.api_path = m.get('apiPath')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dingActionId') is not None:
            self.ding_action_id = m.get('dingActionId')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('inputMappingConfig') is not None:
            temp_model = UpdateActionRequestActionInfoInputMappingConfig()
            self.input_mapping_config = temp_model.from_map(m['inputMappingConfig'])
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.output_data_rules = []
        if m.get('outputDataRules') is not None:
            for k in m.get('outputDataRules'):
                temp_model = UpdateActionRequestActionInfoOutputDataRules()
                self.output_data_rules.append(temp_model.from_map(k))
        if m.get('outputMappingConfig') is not None:
            temp_model = UpdateActionRequestActionInfoOutputMappingConfig()
            self.output_mapping_config = temp_model.from_map(m['outputMappingConfig'])
        if m.get('outputSchema') is not None:
            self.output_schema = m.get('outputSchema')
        return self


class UpdateActionRequest(TeaModel):
    def __init__(
        self,
        action_info: List[UpdateActionRequestActionInfo] = None,
        integrator_flag: str = None,
    ):
        self.action_info = action_info
        self.integrator_flag = integrator_flag

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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_info = []
        if m.get('actionInfo') is not None:
            for k in m.get('actionInfo'):
                temp_model = UpdateActionRequestActionInfo()
                self.action_info.append(temp_model.from_map(k))
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
        return self


class UpdateActionResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_action_id: str = None,
        ding_connector_id: str = None,
        integrator_action_id: str = None,
        integrator_connector_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: str = None,
    ):
        # 连接平台执行事件id
        self.ding_action_id = ding_action_id
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 服务商的执行事件id
        self.integrator_action_id = integrator_action_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否执行成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_action_id is not None:
            result['dingActionId'] = self.ding_action_id
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.integrator_action_id is not None:
            result['integratorActionId'] = self.integrator_action_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingActionId') is not None:
            self.ding_action_id = m.get('dingActionId')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorActionId') is not None:
            self.integrator_action_id = m.get('integratorActionId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateActionResponseBody(TeaModel):
    def __init__(
        self,
        item: List[UpdateActionResponseBodyItem] = None,
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
                temp_model = UpdateActionResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class UpdateActionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateActionResponseBody = None,
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
            temp_model = UpdateActionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateConnectorHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateConnectorRequestConnectorInfo(TeaModel):
    def __init__(
        self,
        api_domain: str = None,
        api_secret: str = None,
        app_id: int = None,
        auth_value_env: bool = None,
        description: str = None,
        ding_connector_id: str = None,
        domain_env: bool = None,
        icon_media_id: str = None,
        integrator_connector_id: str = None,
        name: str = None,
    ):
        # 连接器中执行动作的接口路径域名。
        self.api_domain = api_domain
        # 连接器中执行动作接口的加密签名。
        self.api_secret = api_secret
        # 应用id。
        self.app_id = app_id
        # 将执行动作鉴权值设为环境变量。
        self.auth_value_env = auth_value_env
        # 连接器描述。
        self.description = description
        # 连接平台连接器唯一标识。
        self.ding_connector_id = ding_connector_id
        # 将执行动作域名设为环境变量。
        self.domain_env = domain_env
        self.icon_media_id = icon_media_id
        # 服务商的连接器唯一标识。
        self.integrator_connector_id = integrator_connector_id
        # 连接器名称。
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_domain is not None:
            result['apiDomain'] = self.api_domain
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.auth_value_env is not None:
            result['authValueEnv'] = self.auth_value_env
        if self.description is not None:
            result['description'] = self.description
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.domain_env is not None:
            result['domainEnv'] = self.domain_env
        if self.icon_media_id is not None:
            result['iconMediaId'] = self.icon_media_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiDomain') is not None:
            self.api_domain = m.get('apiDomain')
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('authValueEnv') is not None:
            self.auth_value_env = m.get('authValueEnv')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('domainEnv') is not None:
            self.domain_env = m.get('domainEnv')
        if m.get('iconMediaId') is not None:
            self.icon_media_id = m.get('iconMediaId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class UpdateConnectorRequest(TeaModel):
    def __init__(
        self,
        connector_info: List[UpdateConnectorRequestConnectorInfo] = None,
        integrator_flag: str = None,
    ):
        self.connector_info = connector_info
        self.integrator_flag = integrator_flag

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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.connector_info = []
        if m.get('connectorInfo') is not None:
            for k in m.get('connectorInfo'):
                temp_model = UpdateConnectorRequestConnectorInfo()
                self.connector_info.append(temp_model.from_map(k))
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
        return self


class UpdateConnectorResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        integrator_connector_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: bool = None,
    ):
        # 连接平台connectorId
        self.ding_connector_id = ding_connector_id
        # 服务商连接器connectorId
        self.integrator_connector_id = integrator_connector_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否成功
        self.success = success

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
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateConnectorResponseBody(TeaModel):
    def __init__(
        self,
        item: List[UpdateConnectorResponseBodyItem] = None,
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
                temp_model = UpdateConnectorResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class UpdateConnectorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateConnectorResponseBody = None,
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
            temp_model = UpdateConnectorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTriggerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateTriggerRequestTriggerInfo(TeaModel):
    def __init__(
        self,
        description: str = None,
        ding_connector_id: str = None,
        ding_trigger_id: str = None,
        input_schema: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        name: str = None,
    ):
        # 触发事件描述。
        self.description = description
        # 连接平台连接器唯一标识。
        self.ding_connector_id = ding_connector_id
        # 连接平台触发事件唯一标识。
        self.ding_trigger_id = ding_trigger_id
        # 入参属性描述。
        self.input_schema = input_schema
        # 服务商的连接器唯一标识。
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件唯一标识。
        self.integrator_trigger_id = integrator_trigger_id
        # 触发事件名称。
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.ding_trigger_id is not None:
            result['dingTriggerId'] = self.ding_trigger_id
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('dingTriggerId') is not None:
            self.ding_trigger_id = m.get('dingTriggerId')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class UpdateTriggerRequest(TeaModel):
    def __init__(
        self,
        integrator_flag: str = None,
        trigger_info: List[UpdateTriggerRequestTriggerInfo] = None,
    ):
        self.integrator_flag = integrator_flag
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
        if self.integrator_flag is not None:
            result['integratorFlag'] = self.integrator_flag
        result['triggerInfo'] = []
        if self.trigger_info is not None:
            for k in self.trigger_info:
                result['triggerInfo'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('integratorFlag') is not None:
            self.integrator_flag = m.get('integratorFlag')
        self.trigger_info = []
        if m.get('triggerInfo') is not None:
            for k in m.get('triggerInfo'):
                temp_model = UpdateTriggerRequestTriggerInfo()
                self.trigger_info.append(temp_model.from_map(k))
        return self


class UpdateTriggerResponseBodyItem(TeaModel):
    def __init__(
        self,
        ding_connector_id: str = None,
        ding_trigger_id: str = None,
        integrator_connector_id: str = None,
        integrator_trigger_id: str = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
        success: bool = None,
    ):
        # 连接平台连接器id
        self.ding_connector_id = ding_connector_id
        # 连接平台触发事件id
        self.ding_trigger_id = ding_trigger_id
        # 服务商的连接器Id
        self.integrator_connector_id = integrator_connector_id
        # 服务商的触发事件id
        self.integrator_trigger_id = integrator_trigger_id
        # 错误码
        self.sub_err_code = sub_err_code
        # 错误信息
        self.sub_err_msg = sub_err_msg
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_connector_id is not None:
            result['dingConnectorId'] = self.ding_connector_id
        if self.ding_trigger_id is not None:
            result['dingTriggerId'] = self.ding_trigger_id
        if self.integrator_connector_id is not None:
            result['integratorConnectorId'] = self.integrator_connector_id
        if self.integrator_trigger_id is not None:
            result['integratorTriggerId'] = self.integrator_trigger_id
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingConnectorId') is not None:
            self.ding_connector_id = m.get('dingConnectorId')
        if m.get('dingTriggerId') is not None:
            self.ding_trigger_id = m.get('dingTriggerId')
        if m.get('integratorConnectorId') is not None:
            self.integrator_connector_id = m.get('integratorConnectorId')
        if m.get('integratorTriggerId') is not None:
            self.integrator_trigger_id = m.get('integratorTriggerId')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateTriggerResponseBody(TeaModel):
    def __init__(
        self,
        item: List[UpdateTriggerResponseBodyItem] = None,
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
                temp_model = UpdateTriggerResponseBodyItem()
                self.item.append(temp_model.from_map(k))
        return self


class UpdateTriggerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateTriggerResponseBody = None,
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
            temp_model = UpdateTriggerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


