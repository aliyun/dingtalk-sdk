# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkworkbench_1_0 import models as dingtalkworkbench__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


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
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryComponentScopesResponse(),
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
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryComponentScopesResponse(),
            await self.do_roarequest_async('QueryComponentScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/components/{component_id}/scopes', 'json', req, runtime)
        )

    def update_ding_portal_page_scope(
        self,
        page_uuid: str,
        app_uuid: str,
        request: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeRequest,
    ) -> dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeHeaders()
        return self.update_ding_portal_page_scope_with_options(page_uuid, app_uuid, request, headers, runtime)

    async def update_ding_portal_page_scope_async(
        self,
        page_uuid: str,
        app_uuid: str,
        request: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeRequest,
    ) -> dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeHeaders()
        return await self.update_ding_portal_page_scope_with_options_async(page_uuid, app_uuid, request, headers, runtime)

    def update_ding_portal_page_scope_with_options(
        self,
        page_uuid: str,
        app_uuid: str,
        request: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeRequest,
        headers: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.all_visible):
            body['allVisible'] = request.all_visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse(),
            self.do_roarequest('UpdateDingPortalPageScope', 'workbench_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workbench/dingPortals/{app_uuid}/pageScopes/{page_uuid}', 'none', req, runtime)
        )

    async def update_ding_portal_page_scope_with_options_async(
        self,
        page_uuid: str,
        app_uuid: str,
        request: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeRequest,
        headers: dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.all_visible):
            body['allVisible'] = request.all_visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse(),
            await self.do_roarequest_async('UpdateDingPortalPageScope', 'workbench_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workbench/dingPortals/{app_uuid}/pageScopes/{page_uuid}', 'none', req, runtime)
        )

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
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryShortcutScopesResponse(),
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
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryShortcutScopesResponse(),
            await self.do_roarequest_async('QueryShortcutScopes', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/shortcuts/{shortcut_key}/scopes', 'json', req, runtime)
        )

    def get_ding_portal_detail(
        self,
        app_uuid: str,
    ) -> dingtalkworkbench__1__0_models.GetDingPortalDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetDingPortalDetailHeaders()
        return self.get_ding_portal_detail_with_options(app_uuid, headers, runtime)

    async def get_ding_portal_detail_async(
        self,
        app_uuid: str,
    ) -> dingtalkworkbench__1__0_models.GetDingPortalDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetDingPortalDetailHeaders()
        return await self.get_ding_portal_detail_with_options_async(app_uuid, headers, runtime)

    def get_ding_portal_detail_with_options(
        self,
        app_uuid: str,
        headers: dingtalkworkbench__1__0_models.GetDingPortalDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetDingPortalDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetDingPortalDetailResponse(),
            self.do_roarequest('GetDingPortalDetail', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/dingPortals/{app_uuid}', 'json', req, runtime)
        )

    async def get_ding_portal_detail_with_options_async(
        self,
        app_uuid: str,
        headers: dingtalkworkbench__1__0_models.GetDingPortalDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetDingPortalDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetDingPortalDetailResponse(),
            await self.do_roarequest_async('GetDingPortalDetail', 'workbench_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workbench/dingPortals/{app_uuid}', 'json', req, runtime)
        )
