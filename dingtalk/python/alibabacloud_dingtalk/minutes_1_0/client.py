# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.minutes_1_0 import models as dingtalkminutes__1__0_models
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

    def query_minutes_status_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesStatusRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesStatusResponse:
        """
        @summary 查询闪记状态
        
        @param request: QueryMinutesStatusRequest
        @param headers: QueryMinutesStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMinutesStatus',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/taskStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_status_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesStatusRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesStatusResponse:
        """
        @summary 查询闪记状态
        
        @param request: QueryMinutesStatusRequest
        @param headers: QueryMinutesStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMinutesStatus',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/taskStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_status(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesStatusRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesStatusResponse:
        """
        @summary 查询闪记状态
        
        @param request: QueryMinutesStatusRequest
        @return: QueryMinutesStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesStatusHeaders()
        return self.query_minutes_status_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_status_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesStatusRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesStatusResponse:
        """
        @summary 查询闪记状态
        
        @param request: QueryMinutesStatusRequest
        @return: QueryMinutesStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesStatusHeaders()
        return await self.query_minutes_status_with_options_async(task_uuid, request, headers, runtime)

    def query_minutes_text_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTextRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询闪记转写文本内容
        
        @param request: QueryMinutesTextRequest
        @param headers: QueryMinutesTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMinutesText',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/textInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesTextResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_text_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTextRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询闪记转写文本内容
        
        @param request: QueryMinutesTextRequest
        @param headers: QueryMinutesTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMinutesText',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/textInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_text(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTextRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询闪记转写文本内容
        
        @param request: QueryMinutesTextRequest
        @return: QueryMinutesTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesTextHeaders()
        return self.query_minutes_text_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_text_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTextRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询闪记转写文本内容
        
        @param request: QueryMinutesTextRequest
        @return: QueryMinutesTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesTextHeaders()
        return await self.query_minutes_text_with_options_async(task_uuid, request, headers, runtime)
