# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.activity_1_0 import models as dingtalkactivity__1__0_models
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def create_activity_with_options(
        self,
        request: dingtalkactivity__1__0_models.CreateActivityRequest,
        headers: dingtalkactivity__1__0_models.CreateActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkactivity__1__0_models.CreateActivityResponse:
        """
        @summary 创建活动
        
        @param request: CreateActivityRequest
        @param headers: CreateActivityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateActivityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='CreateActivity',
            version='activity_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/activity/meta',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkactivity__1__0_models.CreateActivityResponse(),
            self.execute(params, req, runtime)
        )

    async def create_activity_with_options_async(
        self,
        request: dingtalkactivity__1__0_models.CreateActivityRequest,
        headers: dingtalkactivity__1__0_models.CreateActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkactivity__1__0_models.CreateActivityResponse:
        """
        @summary 创建活动
        
        @param request: CreateActivityRequest
        @param headers: CreateActivityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateActivityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='CreateActivity',
            version='activity_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/activity/meta',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkactivity__1__0_models.CreateActivityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_activity(
        self,
        request: dingtalkactivity__1__0_models.CreateActivityRequest,
    ) -> dingtalkactivity__1__0_models.CreateActivityResponse:
        """
        @summary 创建活动
        
        @param request: CreateActivityRequest
        @return: CreateActivityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkactivity__1__0_models.CreateActivityHeaders()
        return self.create_activity_with_options(request, headers, runtime)

    async def create_activity_async(
        self,
        request: dingtalkactivity__1__0_models.CreateActivityRequest,
    ) -> dingtalkactivity__1__0_models.CreateActivityResponse:
        """
        @summary 创建活动
        
        @param request: CreateActivityRequest
        @return: CreateActivityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkactivity__1__0_models.CreateActivityHeaders()
        return await self.create_activity_with_options_async(request, headers, runtime)

    def list_activity_with_options(
        self,
        request: dingtalkactivity__1__0_models.ListActivityRequest,
        headers: dingtalkactivity__1__0_models.ListActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkactivity__1__0_models.ListActivityResponse:
        """
        @summary 查询活动列表
        
        @param request: ListActivityRequest
        @param headers: ListActivityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListActivityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='ListActivity',
            version='activity_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/activity/metaLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkactivity__1__0_models.ListActivityResponse(),
            self.execute(params, req, runtime)
        )

    async def list_activity_with_options_async(
        self,
        request: dingtalkactivity__1__0_models.ListActivityRequest,
        headers: dingtalkactivity__1__0_models.ListActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkactivity__1__0_models.ListActivityResponse:
        """
        @summary 查询活动列表
        
        @param request: ListActivityRequest
        @param headers: ListActivityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListActivityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='ListActivity',
            version='activity_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/activity/metaLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkactivity__1__0_models.ListActivityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_activity(
        self,
        request: dingtalkactivity__1__0_models.ListActivityRequest,
    ) -> dingtalkactivity__1__0_models.ListActivityResponse:
        """
        @summary 查询活动列表
        
        @param request: ListActivityRequest
        @return: ListActivityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkactivity__1__0_models.ListActivityHeaders()
        return self.list_activity_with_options(request, headers, runtime)

    async def list_activity_async(
        self,
        request: dingtalkactivity__1__0_models.ListActivityRequest,
    ) -> dingtalkactivity__1__0_models.ListActivityResponse:
        """
        @summary 查询活动列表
        
        @param request: ListActivityRequest
        @return: ListActivityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkactivity__1__0_models.ListActivityHeaders()
        return await self.list_activity_with_options_async(request, headers, runtime)
