# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.workbench_1_0 import models as dingtalkworkbench__1__0_models
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

    def add_recent_user_app_list_with_options(
        self,
        request: dingtalkworkbench__1__0_models.AddRecentUserAppListRequest,
        headers: dingtalkworkbench__1__0_models.AddRecentUserAppListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.AddRecentUserAppListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.used_app_detail_list):
            body['usedAppDetailList'] = request.used_app_detail_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='AddRecentUserAppList',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/components/recentUsed/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.AddRecentUserAppListResponse(),
            self.execute(params, req, runtime)
        )

    async def add_recent_user_app_list_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.AddRecentUserAppListRequest,
        headers: dingtalkworkbench__1__0_models.AddRecentUserAppListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.AddRecentUserAppListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.used_app_detail_list):
            body['usedAppDetailList'] = request.used_app_detail_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='AddRecentUserAppList',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/components/recentUsed/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.AddRecentUserAppListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_recent_user_app_list(
        self,
        request: dingtalkworkbench__1__0_models.AddRecentUserAppListRequest,
    ) -> dingtalkworkbench__1__0_models.AddRecentUserAppListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.AddRecentUserAppListHeaders()
        return self.add_recent_user_app_list_with_options(request, headers, runtime)

    async def add_recent_user_app_list_async(
        self,
        request: dingtalkworkbench__1__0_models.AddRecentUserAppListRequest,
    ) -> dingtalkworkbench__1__0_models.AddRecentUserAppListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.AddRecentUserAppListHeaders()
        return await self.add_recent_user_app_list_with_options_async(request, headers, runtime)

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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDingPortalDetail',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/dingPortals/{app_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetDingPortalDetailResponse(),
            self.execute(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDingPortalDetail',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/dingPortals/{app_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetDingPortalDetailResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_plugin_permission_point_with_options(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginPermissionPointRequest,
        headers: dingtalkworkbench__1__0_models.GetPluginPermissionPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPluginPermissionPoint',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/plugins/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse(),
            self.execute(params, req, runtime)
        )

    async def get_plugin_permission_point_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginPermissionPointRequest,
        headers: dingtalkworkbench__1__0_models.GetPluginPermissionPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPluginPermissionPoint',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/plugins/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_plugin_permission_point(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginPermissionPointRequest,
    ) -> dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetPluginPermissionPointHeaders()
        return self.get_plugin_permission_point_with_options(request, headers, runtime)

    async def get_plugin_permission_point_async(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginPermissionPointRequest,
    ) -> dingtalkworkbench__1__0_models.GetPluginPermissionPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetPluginPermissionPointHeaders()
        return await self.get_plugin_permission_point_with_options_async(request, headers, runtime)

    def get_plugin_rule_check_info_with_options(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoRequest,
        headers: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPluginRuleCheckInfo',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/plugins/validationRules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_plugin_rule_check_info_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoRequest,
        headers: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPluginRuleCheckInfo',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/plugins/validationRules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_plugin_rule_check_info(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoRequest,
    ) -> dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoHeaders()
        return self.get_plugin_rule_check_info_with_options(request, headers, runtime)

    async def get_plugin_rule_check_info_async(
        self,
        request: dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoRequest,
    ) -> dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.GetPluginRuleCheckInfoHeaders()
        return await self.get_plugin_rule_check_info_with_options_async(request, headers, runtime)

    def list_work_bench_group_with_options(
        self,
        request: dingtalkworkbench__1__0_models.ListWorkBenchGroupRequest,
        headers: dingtalkworkbench__1__0_models.ListWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.group_type):
            query['groupType'] = request.group_type
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListWorkBenchGroup',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def list_work_bench_group_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.ListWorkBenchGroupRequest,
        headers: dingtalkworkbench__1__0_models.ListWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.group_type):
            query['groupType'] = request.group_type
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListWorkBenchGroup',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_work_bench_group(
        self,
        request: dingtalkworkbench__1__0_models.ListWorkBenchGroupRequest,
    ) -> dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.ListWorkBenchGroupHeaders()
        return self.list_work_bench_group_with_options(request, headers, runtime)

    async def list_work_bench_group_async(
        self,
        request: dingtalkworkbench__1__0_models.ListWorkBenchGroupRequest,
    ) -> dingtalkworkbench__1__0_models.ListWorkBenchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.ListWorkBenchGroupHeaders()
        return await self.list_work_bench_group_with_options_async(request, headers, runtime)

    def modify_workbench_badge_with_options(
        self,
        request: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeRequest,
        headers: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.is_added):
            body['isAdded'] = request.is_added
        if not UtilClient.is_unset(request.red_dot_relation_id):
            body['redDotRelationId'] = request.red_dot_relation_id
        if not UtilClient.is_unset(request.red_dot_type):
            body['redDotType'] = request.red_dot_type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ModifyWorkbenchBadge',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/badges/modify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse(),
            self.execute(params, req, runtime)
        )

    async def modify_workbench_badge_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeRequest,
        headers: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.is_added):
            body['isAdded'] = request.is_added
        if not UtilClient.is_unset(request.red_dot_relation_id):
            body['redDotRelationId'] = request.red_dot_relation_id
        if not UtilClient.is_unset(request.red_dot_type):
            body['redDotType'] = request.red_dot_type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ModifyWorkbenchBadge',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/badges/modify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def modify_workbench_badge(
        self,
        request: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeRequest,
    ) -> dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeHeaders()
        return self.modify_workbench_badge_with_options(request, headers, runtime)

    async def modify_workbench_badge_async(
        self,
        request: dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeRequest,
    ) -> dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.ModifyWorkbenchBadgeHeaders()
        return await self.modify_workbench_badge_with_options_async(request, headers, runtime)

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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryComponentScopes',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/components/{component_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryComponentScopesResponse(),
            self.execute(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryComponentScopes',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/components/{component_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryComponentScopesResponse(),
            await self.execute_async(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryShortcutScopes',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/shortcuts/{shortcut_key}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryShortcutScopesResponse(),
            self.execute(params, req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryShortcutScopes',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/shortcuts/{shortcut_key}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.QueryShortcutScopesResponse(),
            await self.execute_async(params, req, runtime)
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

    def undo_deletion_with_options(
        self,
        request: dingtalkworkbench__1__0_models.UndoDeletionRequest,
        headers: dingtalkworkbench__1__0_models.UndoDeletionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.UndoDeletionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.red_dot_relation_id):
            body['redDotRelationId'] = request.red_dot_relation_id
        if not UtilClient.is_unset(request.red_dot_type):
            body['redDotType'] = request.red_dot_type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UndoDeletion',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/badges/undoDeleted',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UndoDeletionResponse(),
            self.execute(params, req, runtime)
        )

    async def undo_deletion_with_options_async(
        self,
        request: dingtalkworkbench__1__0_models.UndoDeletionRequest,
        headers: dingtalkworkbench__1__0_models.UndoDeletionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkbench__1__0_models.UndoDeletionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.red_dot_relation_id):
            body['redDotRelationId'] = request.red_dot_relation_id
        if not UtilClient.is_unset(request.red_dot_type):
            body['redDotType'] = request.red_dot_type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UndoDeletion',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/badges/undoDeleted',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UndoDeletionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def undo_deletion(
        self,
        request: dingtalkworkbench__1__0_models.UndoDeletionRequest,
    ) -> dingtalkworkbench__1__0_models.UndoDeletionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.UndoDeletionHeaders()
        return self.undo_deletion_with_options(request, headers, runtime)

    async def undo_deletion_async(
        self,
        request: dingtalkworkbench__1__0_models.UndoDeletionRequest,
    ) -> dingtalkworkbench__1__0_models.UndoDeletionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkbench__1__0_models.UndoDeletionHeaders()
        return await self.undo_deletion_with_options_async(request, headers, runtime)

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
        if not UtilClient.is_unset(request.all_visible):
            body['allVisible'] = request.all_visible
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
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
            action='UpdateDingPortalPageScope',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/dingPortals/{app_uuid}/pageScopes/{page_uuid}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.all_visible):
            body['allVisible'] = request.all_visible
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
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
            action='UpdateDingPortalPageScope',
            version='workbench_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/workbench/dingPortals/{app_uuid}/pageScopes/{page_uuid}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkworkbench__1__0_models.UpdateDingPortalPageScopeResponse(),
            await self.execute_async(params, req, runtime)
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
