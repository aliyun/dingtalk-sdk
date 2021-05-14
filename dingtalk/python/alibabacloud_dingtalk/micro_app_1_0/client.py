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
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
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
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
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
