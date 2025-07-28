# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class InstallCoolAppOrderToGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class InstallCoolAppOrderToGroupRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        sorted_plugin_id_list: List[int] = None,
        template_id: str = None,
        unsorted_plugin_id_list: List[int] = None,
    ):
        self.conversation_id = conversation_id
        self.sorted_plugin_id_list = sorted_plugin_id_list
        self.template_id = template_id
        self.unsorted_plugin_id_list = unsorted_plugin_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.sorted_plugin_id_list is not None:
            result['sortedPluginIdList'] = self.sorted_plugin_id_list
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.unsorted_plugin_id_list is not None:
            result['unsortedPluginIdList'] = self.unsorted_plugin_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('sortedPluginIdList') is not None:
            self.sorted_plugin_id_list = m.get('sortedPluginIdList')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('unsortedPluginIdList') is not None:
            self.unsorted_plugin_id_list = m.get('unsortedPluginIdList')
        return self


class InstallCoolAppOrderToGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: str = None,
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


class InstallCoolAppOrderToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InstallCoolAppOrderToGroupResponseBody = None,
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
            temp_model = InstallCoolAppOrderToGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InstallCoolAppToGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class InstallCoolAppToGroupRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        operate_cool_app_code: str = None,
        operator_id: str = None,
        template_id: str = None,
    ):
        self.conversation_id = conversation_id
        self.operate_cool_app_code = operate_cool_app_code
        self.operator_id = operator_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.operate_cool_app_code is not None:
            result['operateCoolAppCode'] = self.operate_cool_app_code
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('operateCoolAppCode') is not None:
            self.operate_cool_app_code = m.get('operateCoolAppCode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class InstallCoolAppToGroupResponseBody(TeaModel):
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


class InstallCoolAppToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InstallCoolAppToGroupResponseBody = None,
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
            temp_model = InstallCoolAppToGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCoolAppShortcutOrderHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCoolAppShortcutOrderRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        operator_id: str = None,
        template_id: str = None,
    ):
        self.conversation_id = conversation_id
        self.operator_id = operator_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList(TeaModel):
    def __init__(
        self,
        app_code: str = None,
        desc: str = None,
        plugin_id: str = None,
        source: str = None,
        title: str = None,
    ):
        self.app_code = app_code
        self.desc = desc
        self.plugin_id = plugin_id
        self.source = source
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.desc is not None:
            result['desc'] = self.desc
        if self.plugin_id is not None:
            result['pluginId'] = self.plugin_id
        if self.source is not None:
            result['source'] = self.source
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('pluginId') is not None:
            self.plugin_id = m.get('pluginId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryCoolAppShortcutOrderResponseBodyResultMyPluginList(TeaModel):
    def __init__(
        self,
        app_code: str = None,
        desc: str = None,
        plugin_id: str = None,
        source: str = None,
        title: str = None,
    ):
        self.app_code = app_code
        self.desc = desc
        self.plugin_id = plugin_id
        self.source = source
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.desc is not None:
            result['desc'] = self.desc
        if self.plugin_id is not None:
            result['pluginId'] = self.plugin_id
        if self.source is not None:
            result['source'] = self.source
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('pluginId') is not None:
            self.plugin_id = m.get('pluginId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList(TeaModel):
    def __init__(
        self,
        app_code: str = None,
        desc: str = None,
        plugin_id: str = None,
        source: str = None,
        title: str = None,
    ):
        self.app_code = app_code
        self.desc = desc
        self.plugin_id = plugin_id
        self.source = source
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.desc is not None:
            result['desc'] = self.desc
        if self.plugin_id is not None:
            result['pluginId'] = self.plugin_id
        if self.source is not None:
            result['source'] = self.source
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('pluginId') is not None:
            self.plugin_id = m.get('pluginId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryCoolAppShortcutOrderResponseBodyResult(TeaModel):
    def __init__(
        self,
        forbidden_plugin_list: List[QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList] = None,
        my_plugin_list: List[QueryCoolAppShortcutOrderResponseBodyResultMyPluginList] = None,
        other_plugin_list: List[QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList] = None,
    ):
        self.forbidden_plugin_list = forbidden_plugin_list
        self.my_plugin_list = my_plugin_list
        self.other_plugin_list = other_plugin_list

    def validate(self):
        if self.forbidden_plugin_list:
            for k in self.forbidden_plugin_list:
                if k:
                    k.validate()
        if self.my_plugin_list:
            for k in self.my_plugin_list:
                if k:
                    k.validate()
        if self.other_plugin_list:
            for k in self.other_plugin_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['forbiddenPluginList'] = []
        if self.forbidden_plugin_list is not None:
            for k in self.forbidden_plugin_list:
                result['forbiddenPluginList'].append(k.to_map() if k else None)
        result['myPluginList'] = []
        if self.my_plugin_list is not None:
            for k in self.my_plugin_list:
                result['myPluginList'].append(k.to_map() if k else None)
        result['otherPluginList'] = []
        if self.other_plugin_list is not None:
            for k in self.other_plugin_list:
                result['otherPluginList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.forbidden_plugin_list = []
        if m.get('forbiddenPluginList') is not None:
            for k in m.get('forbiddenPluginList'):
                temp_model = QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList()
                self.forbidden_plugin_list.append(temp_model.from_map(k))
        self.my_plugin_list = []
        if m.get('myPluginList') is not None:
            for k in m.get('myPluginList'):
                temp_model = QueryCoolAppShortcutOrderResponseBodyResultMyPluginList()
                self.my_plugin_list.append(temp_model.from_map(k))
        self.other_plugin_list = []
        if m.get('otherPluginList') is not None:
            for k in m.get('otherPluginList'):
                temp_model = QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList()
                self.other_plugin_list.append(temp_model.from_map(k))
        return self


class QueryCoolAppShortcutOrderResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryCoolAppShortcutOrderResponseBodyResult = None,
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
            temp_model = QueryCoolAppShortcutOrderResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryCoolAppShortcutOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCoolAppShortcutOrderResponseBody = None,
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
            temp_model = QueryCoolAppShortcutOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UninstallCoolAppFromGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UninstallCoolAppFromGroupRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        operate_cool_app_code: str = None,
        operator_id: str = None,
        template_id: str = None,
    ):
        self.conversation_id = conversation_id
        self.operate_cool_app_code = operate_cool_app_code
        self.operator_id = operator_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.operate_cool_app_code is not None:
            result['operateCoolAppCode'] = self.operate_cool_app_code
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('operateCoolAppCode') is not None:
            self.operate_cool_app_code = m.get('operateCoolAppCode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class UninstallCoolAppFromGroupResponseBody(TeaModel):
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


class UninstallCoolAppFromGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UninstallCoolAppFromGroupResponseBody = None,
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
            temp_model = UninstallCoolAppFromGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


