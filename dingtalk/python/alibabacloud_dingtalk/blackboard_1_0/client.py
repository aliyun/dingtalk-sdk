# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.blackboard_1_0 import models as dingtalkblackboard__1__0_models
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

    def query_blackboard_read_un_read_with_options(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse:
        """
        @summary 查询公告已读未读人员列表
        
        @param request: QueryBlackboardReadUnReadRequest
        @param headers: QueryBlackboardReadUnReadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardReadUnReadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.blackboard_id):
            query['blackboardId'] = request.blackboard_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
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
            action='QueryBlackboardReadUnRead',
            version='blackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/blackboard/readers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse(),
            self.execute(params, req, runtime)
        )

    async def query_blackboard_read_un_read_with_options_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse:
        """
        @summary 查询公告已读未读人员列表
        
        @param request: QueryBlackboardReadUnReadRequest
        @param headers: QueryBlackboardReadUnReadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardReadUnReadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.blackboard_id):
            query['blackboardId'] = request.blackboard_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
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
            action='QueryBlackboardReadUnRead',
            version='blackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/blackboard/readers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_blackboard_read_un_read(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse:
        """
        @summary 查询公告已读未读人员列表
        
        @param request: QueryBlackboardReadUnReadRequest
        @return: QueryBlackboardReadUnReadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadHeaders()
        return self.query_blackboard_read_un_read_with_options(request, headers, runtime)

    async def query_blackboard_read_un_read_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadResponse:
        """
        @summary 查询公告已读未读人员列表
        
        @param request: QueryBlackboardReadUnReadRequest
        @return: QueryBlackboardReadUnReadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardReadUnReadHeaders()
        return await self.query_blackboard_read_un_read_with_options_async(request, headers, runtime)

    def query_blackboard_space_with_options(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        """
        @summary 获取公告钉盘空间信息
        
        @param request: QueryBlackboardSpaceRequest
        @param headers: QueryBlackboardSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
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
            action='QueryBlackboardSpace',
            version='blackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/blackboard/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_blackboard_space_with_options_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
        headers: dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        """
        @summary 获取公告钉盘空间信息
        
        @param request: QueryBlackboardSpaceRequest
        @param headers: QueryBlackboardSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
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
            action='QueryBlackboardSpace',
            version='blackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/blackboard/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_blackboard_space(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        """
        @summary 获取公告钉盘空间信息
        
        @param request: QueryBlackboardSpaceRequest
        @return: QueryBlackboardSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders()
        return self.query_blackboard_space_with_options(request, headers, runtime)

    async def query_blackboard_space_async(
        self,
        request: dingtalkblackboard__1__0_models.QueryBlackboardSpaceRequest,
    ) -> dingtalkblackboard__1__0_models.QueryBlackboardSpaceResponse:
        """
        @summary 获取公告钉盘空间信息
        
        @param request: QueryBlackboardSpaceRequest
        @return: QueryBlackboardSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkblackboard__1__0_models.QueryBlackboardSpaceHeaders()
        return await self.query_blackboard_space_with_options_async(request, headers, runtime)
