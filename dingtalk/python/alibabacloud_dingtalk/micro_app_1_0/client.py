# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkmicro_app_1_0 import models as dingtalkmicro_app__1__0_models
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

    def add_app_to_work_bench_group(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders()
        return self.add_app_to_work_bench_group_with_options(agent_id, request, headers, runtime)

    async def add_app_to_work_bench_group_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders()
        return await self.add_app_to_work_bench_group_with_options_async(agent_id, request, headers, runtime)

    def add_app_to_work_bench_group_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.component_id):
            body['componentId'] = request.component_id
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
            dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse(),
            self.do_roarequest('AddAppToWorkBenchGroup', 'microApp_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/microApp/apps/{agent_id}/addToWorkBenchGroup', 'json', req, runtime)
        )

    async def add_app_to_work_bench_group_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.component_id):
            body['componentId'] = request.component_id
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
            dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse(),
            await self.do_roarequest_async('AddAppToWorkBenchGroup', 'microApp_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/microApp/apps/{agent_id}/addToWorkBenchGroup', 'json', req, runtime)
        )

    def create_inner_app(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateInnerAppHeaders()
        return self.create_inner_app_with_options(request, headers, runtime)

    async def create_inner_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateInnerAppHeaders()
        return await self.create_inner_app_with_options_async(request, headers, runtime)

    def create_inner_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
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
            dingtalkmicro_app__1__0_models.CreateInnerAppResponse(),
            self.do_roarequest('CreateInnerApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/microApp/apps', 'json', req, runtime)
        )

    async def create_inner_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
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
            dingtalkmicro_app__1__0_models.CreateInnerAppResponse(),
            await self.do_roarequest_async('CreateInnerApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/microApp/apps', 'json', req, runtime)
        )

    def update_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders()
        return self.update_inner_app_with_options(agent_id, request, headers, runtime)

    async def update_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders()
        return await self.update_inner_app_with_options_async(agent_id, request, headers, runtime)

    def update_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
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
            dingtalkmicro_app__1__0_models.UpdateInnerAppResponse(),
            self.do_roarequest('UpdateInnerApp', 'microApp_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    async def update_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
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
            dingtalkmicro_app__1__0_models.UpdateInnerAppResponse(),
            await self.do_roarequest_async('UpdateInnerApp', 'microApp_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    def delete_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders()
        return self.delete_inner_app_with_options(agent_id, request, headers, runtime)

    async def delete_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders()
        return await self.delete_inner_app_with_options_async(agent_id, request, headers, runtime)

    def delete_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteInnerAppResponse(),
            self.do_roarequest('DeleteInnerApp', 'microApp_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    async def delete_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteInnerAppResponse(),
            await self.do_roarequest_async('DeleteInnerApp', 'microApp_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    def get_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetInnerAppHeaders()
        return self.get_inner_app_with_options(agent_id, request, headers, runtime)

    async def get_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetInnerAppHeaders()
        return await self.get_inner_app_with_options_async(agent_id, request, headers, runtime)

    def get_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.GetInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetInnerAppResponse(),
            self.do_roarequest('GetInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    async def get_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.GetInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetInnerAppResponse(),
            await self.do_roarequest_async('GetInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/microApp/apps/{agent_id}', 'json', req, runtime)
        )

    def list_inner_app(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppHeaders()
        return self.list_inner_app_with_options(request, headers, runtime)

    async def list_inner_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppHeaders()
        return await self.list_inner_app_with_options_async(request, headers, runtime)

    def list_inner_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppResponse(),
            self.do_roarequest('ListInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/microApp/apps', 'json', req, runtime)
        )

    async def list_inner_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppResponse(),
            await self.do_roarequest_async('ListInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/microApp/apps', 'json', req, runtime)
        )
