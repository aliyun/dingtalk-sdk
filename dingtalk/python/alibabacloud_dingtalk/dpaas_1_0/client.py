# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.dpaas_1_0 import models as dingtalkdpaas__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def install_cool_app_order_to_group_with_options(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupRequest,
        headers: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse:
        """
        @summary 群酷应用排序
        
        @param request: InstallCoolAppOrderToGroupRequest
        @param headers: InstallCoolAppOrderToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppOrderToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.sorted_plugin_id_list):
            body['sortedPluginIdList'] = request.sorted_plugin_id_list
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.unsorted_plugin_id_list):
            body['unsortedPluginIdList'] = request.unsorted_plugin_id_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InstallCoolAppOrderToGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def install_cool_app_order_to_group_with_options_async(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupRequest,
        headers: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse:
        """
        @summary 群酷应用排序
        
        @param request: InstallCoolAppOrderToGroupRequest
        @param headers: InstallCoolAppOrderToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppOrderToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.sorted_plugin_id_list):
            body['sortedPluginIdList'] = request.sorted_plugin_id_list
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.unsorted_plugin_id_list):
            body['unsortedPluginIdList'] = request.unsorted_plugin_id_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InstallCoolAppOrderToGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_cool_app_order_to_group(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupRequest,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse:
        """
        @summary 群酷应用排序
        
        @param request: InstallCoolAppOrderToGroupRequest
        @return: InstallCoolAppOrderToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupHeaders()
        return self.install_cool_app_order_to_group_with_options(request, headers, runtime)

    async def install_cool_app_order_to_group_async(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupRequest,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupResponse:
        """
        @summary 群酷应用排序
        
        @param request: InstallCoolAppOrderToGroupRequest
        @return: InstallCoolAppOrderToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.InstallCoolAppOrderToGroupHeaders()
        return await self.install_cool_app_order_to_group_with_options_async(request, headers, runtime)

    def install_cool_app_to_group_with_options(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppToGroupRequest,
        headers: dingtalkdpaas__1__0_models.InstallCoolAppToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse:
        """
        @summary 安装酷应用到群
        
        @param request: InstallCoolAppToGroupRequest
        @param headers: InstallCoolAppToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operate_cool_app_code):
            body['operateCoolAppCode'] = request.operate_cool_app_code
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InstallCoolAppToGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def install_cool_app_to_group_with_options_async(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppToGroupRequest,
        headers: dingtalkdpaas__1__0_models.InstallCoolAppToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse:
        """
        @summary 安装酷应用到群
        
        @param request: InstallCoolAppToGroupRequest
        @param headers: InstallCoolAppToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallCoolAppToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operate_cool_app_code):
            body['operateCoolAppCode'] = request.operate_cool_app_code
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InstallCoolAppToGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_cool_app_to_group(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppToGroupRequest,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse:
        """
        @summary 安装酷应用到群
        
        @param request: InstallCoolAppToGroupRequest
        @return: InstallCoolAppToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.InstallCoolAppToGroupHeaders()
        return self.install_cool_app_to_group_with_options(request, headers, runtime)

    async def install_cool_app_to_group_async(
        self,
        request: dingtalkdpaas__1__0_models.InstallCoolAppToGroupRequest,
    ) -> dingtalkdpaas__1__0_models.InstallCoolAppToGroupResponse:
        """
        @summary 安装酷应用到群
        
        @param request: InstallCoolAppToGroupRequest
        @return: InstallCoolAppToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.InstallCoolAppToGroupHeaders()
        return await self.install_cool_app_to_group_with_options_async(request, headers, runtime)

    def query_cool_app_shortcut_order_with_options(
        self,
        request: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderRequest,
        headers: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse:
        """
        @summary 查询群插件栏
        
        @param request: QueryCoolAppShortcutOrderRequest
        @param headers: QueryCoolAppShortcutOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCoolAppShortcutOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCoolAppShortcutOrder',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_cool_app_shortcut_order_with_options_async(
        self,
        request: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderRequest,
        headers: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse:
        """
        @summary 查询群插件栏
        
        @param request: QueryCoolAppShortcutOrderRequest
        @param headers: QueryCoolAppShortcutOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCoolAppShortcutOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCoolAppShortcutOrder',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_cool_app_shortcut_order(
        self,
        request: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderRequest,
    ) -> dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse:
        """
        @summary 查询群插件栏
        
        @param request: QueryCoolAppShortcutOrderRequest
        @return: QueryCoolAppShortcutOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderHeaders()
        return self.query_cool_app_shortcut_order_with_options(request, headers, runtime)

    async def query_cool_app_shortcut_order_async(
        self,
        request: dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderRequest,
    ) -> dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderResponse:
        """
        @summary 查询群插件栏
        
        @param request: QueryCoolAppShortcutOrderRequest
        @return: QueryCoolAppShortcutOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.QueryCoolAppShortcutOrderHeaders()
        return await self.query_cool_app_shortcut_order_with_options_async(request, headers, runtime)

    def uninstall_cool_app_from_group_with_options(
        self,
        request: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupRequest,
        headers: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse:
        """
        @summary 从群内卸载酷应用
        
        @param request: UninstallCoolAppFromGroupRequest
        @param headers: UninstallCoolAppFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UninstallCoolAppFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operate_cool_app_code):
            body['operateCoolAppCode'] = request.operate_cool_app_code
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UninstallCoolAppFromGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def uninstall_cool_app_from_group_with_options_async(
        self,
        request: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupRequest,
        headers: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse:
        """
        @summary 从群内卸载酷应用
        
        @param request: UninstallCoolAppFromGroupRequest
        @param headers: UninstallCoolAppFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UninstallCoolAppFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operate_cool_app_code):
            body['operateCoolAppCode'] = request.operate_cool_app_code
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UninstallCoolAppFromGroup',
            version='dpaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def uninstall_cool_app_from_group(
        self,
        request: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupRequest,
    ) -> dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse:
        """
        @summary 从群内卸载酷应用
        
        @param request: UninstallCoolAppFromGroupRequest
        @return: UninstallCoolAppFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupHeaders()
        return self.uninstall_cool_app_from_group_with_options(request, headers, runtime)

    async def uninstall_cool_app_from_group_async(
        self,
        request: dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupRequest,
    ) -> dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupResponse:
        """
        @summary 从群内卸载酷应用
        
        @param request: UninstallCoolAppFromGroupRequest
        @return: UninstallCoolAppFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdpaas__1__0_models.UninstallCoolAppFromGroupHeaders()
        return await self.uninstall_cool_app_from_group_with_options_async(request, headers, runtime)
