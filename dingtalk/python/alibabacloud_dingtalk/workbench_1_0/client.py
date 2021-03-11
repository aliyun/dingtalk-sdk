# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkworkbench_1_0 import models as dingtalkworkbench__1__0_models
from alibabacloud_tea_util import models as util_models


class Client(OpenApiClient):
    """
    *\
    """
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def query_shortcut_scopes(
        self,
        shortcut_key: str,
    ) -> dingtalkworkbench__1__0_models.QueryShortcutScopesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.QueryShortcutScopesHeaders()
        return self.query_shortcut_scopes_with_options(shortcut_key, headers, runtime)

    async def query_shortcut_scopes_async(
        self,
        shortcut_key: str,
    ) -> dingtalkworkbench__1__0_models.QueryShortcutScopesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.QueryShortcutScopesHeaders()
        return await self.query_shortcut_scopes_with_options_async(shortcut_key, headers, runtime)

    def query_shortcut_scopes_with_options(
        self,
        shortcut_key: str,
        headers: dingtalkworkbench__1__0_models.QueryShortcutScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.QueryShortcutScopesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkworkbench__1__0_models.QueryShortcutScopesResponse().from_map(
            self.do_roarequest('QueryShortcutScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/shortcuts/{shortcut_key}/scopes', 'json', req, runtime)
        )

    async def query_shortcut_scopes_with_options_async(
        self,
        shortcut_key: str,
        headers: dingtalkworkbench__1__0_models.QueryShortcutScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.QueryShortcutScopesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkworkbench__1__0_models.QueryShortcutScopesResponse().from_map(
            await self.do_roarequest_async('QueryShortcutScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/shortcuts/{shortcut_key}/scopes', 'json', req, runtime)
        )

    def query_component_scopes(
        self,
        component_id: str,
    ) -> dingtalkworkbench__1__0_models.QueryComponentScopesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.QueryComponentScopesHeaders()
        return self.query_component_scopes_with_options(component_id, headers, runtime)

    async def query_component_scopes_async(
        self,
        component_id: str,
    ) -> dingtalkworkbench__1__0_models.QueryComponentScopesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.QueryComponentScopesHeaders()
        return await self.query_component_scopes_with_options_async(component_id, headers, runtime)

    def query_component_scopes_with_options(
        self,
        component_id: str,
        headers: dingtalkworkbench__1__0_models.QueryComponentScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.QueryComponentScopesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkworkbench__1__0_models.QueryComponentScopesResponse().from_map(
            self.do_roarequest('QueryComponentScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/components/{component_id}/scopes', 'json', req, runtime)
        )

    async def query_component_scopes_with_options_async(
        self,
        component_id: str,
        headers: dingtalkworkbench__1__0_models.QueryComponentScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.QueryComponentScopesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkworkbench__1__0_models.QueryComponentScopesResponse().from_map(
            await self.do_roarequest_async('QueryComponentScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/components/{component_id}/scopes', 'json', req, runtime)
        )
