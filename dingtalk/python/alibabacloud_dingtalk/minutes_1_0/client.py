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

    def batch_get_minutes_details_with_options(
        self,
        request: dingtalkminutes__1__0_models.BatchGetMinutesDetailsRequest,
        headers: dingtalkminutes__1__0_models.BatchGetMinutesDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse:
        """
        @summary 批量获取闪记详情
        
        @param request: BatchGetMinutesDetailsRequest
        @param headers: BatchGetMinutesDetailsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetMinutesDetailsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.task_uuids):
            body['taskUuids'] = request.task_uuids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchGetMinutesDetails',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_minutes_details_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.BatchGetMinutesDetailsRequest,
        headers: dingtalkminutes__1__0_models.BatchGetMinutesDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse:
        """
        @summary 批量获取闪记详情
        
        @param request: BatchGetMinutesDetailsRequest
        @param headers: BatchGetMinutesDetailsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetMinutesDetailsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.task_uuids):
            body['taskUuids'] = request.task_uuids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchGetMinutesDetails',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_minutes_details(
        self,
        request: dingtalkminutes__1__0_models.BatchGetMinutesDetailsRequest,
    ) -> dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse:
        """
        @summary 批量获取闪记详情
        
        @param request: BatchGetMinutesDetailsRequest
        @return: BatchGetMinutesDetailsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.BatchGetMinutesDetailsHeaders()
        return self.batch_get_minutes_details_with_options(request, headers, runtime)

    async def batch_get_minutes_details_async(
        self,
        request: dingtalkminutes__1__0_models.BatchGetMinutesDetailsRequest,
    ) -> dingtalkminutes__1__0_models.BatchGetMinutesDetailsResponse:
        """
        @summary 批量获取闪记详情
        
        @param request: BatchGetMinutesDetailsRequest
        @return: BatchGetMinutesDetailsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.BatchGetMinutesDetailsHeaders()
        return await self.batch_get_minutes_details_with_options_async(request, headers, runtime)

    def delete_minutes_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.DeleteMinutesRequest,
        headers: dingtalkminutes__1__0_models.DeleteMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.DeleteMinutesResponse:
        """
        @summary 删除闪记
        
        @param request: DeleteMinutesRequest
        @param headers: DeleteMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMinutesResponse
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
            action='DeleteMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.DeleteMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_minutes_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.DeleteMinutesRequest,
        headers: dingtalkminutes__1__0_models.DeleteMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.DeleteMinutesResponse:
        """
        @summary 删除闪记
        
        @param request: DeleteMinutesRequest
        @param headers: DeleteMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMinutesResponse
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
            action='DeleteMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.DeleteMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_minutes(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.DeleteMinutesRequest,
    ) -> dingtalkminutes__1__0_models.DeleteMinutesResponse:
        """
        @summary 删除闪记
        
        @param request: DeleteMinutesRequest
        @return: DeleteMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.DeleteMinutesHeaders()
        return self.delete_minutes_with_options(task_uuid, request, headers, runtime)

    async def delete_minutes_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.DeleteMinutesRequest,
    ) -> dingtalkminutes__1__0_models.DeleteMinutesResponse:
        """
        @summary 删除闪记
        
        @param request: DeleteMinutesRequest
        @return: DeleteMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.DeleteMinutesHeaders()
        return await self.delete_minutes_with_options_async(task_uuid, request, headers, runtime)

    def query_minutes_play_info_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesPlayInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse:
        """
        @summary 查询闪记媒体播放信息
        
        @param request: QueryMinutesPlayInfoRequest
        @param headers: QueryMinutesPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesPlayInfoResponse
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
            action='QueryMinutesPlayInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/playInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_play_info_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesPlayInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse:
        """
        @summary 查询闪记媒体播放信息
        
        @param request: QueryMinutesPlayInfoRequest
        @param headers: QueryMinutesPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesPlayInfoResponse
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
            action='QueryMinutesPlayInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/playInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_play_info(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesPlayInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse:
        """
        @summary 查询闪记媒体播放信息
        
        @param request: QueryMinutesPlayInfoRequest
        @return: QueryMinutesPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesPlayInfoHeaders()
        return self.query_minutes_play_info_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_play_info_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesPlayInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesPlayInfoResponse:
        """
        @summary 查询闪记媒体播放信息
        
        @param request: QueryMinutesPlayInfoRequest
        @return: QueryMinutesPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesPlayInfoHeaders()
        return await self.query_minutes_play_info_with_options_async(task_uuid, request, headers, runtime)

    def query_minutes_share_list_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesShareListRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesShareListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesShareListResponse:
        """
        @summary 获取与我共享闪记列表
        
        @param request: QueryMinutesShareListRequest
        @param headers: QueryMinutesShareListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesShareListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
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
            action='QueryMinutesShareList',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/shareLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesShareListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_share_list_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesShareListRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesShareListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesShareListResponse:
        """
        @summary 获取与我共享闪记列表
        
        @param request: QueryMinutesShareListRequest
        @param headers: QueryMinutesShareListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesShareListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
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
            action='QueryMinutesShareList',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/shareLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesShareListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_share_list(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesShareListRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesShareListResponse:
        """
        @summary 获取与我共享闪记列表
        
        @param request: QueryMinutesShareListRequest
        @return: QueryMinutesShareListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesShareListHeaders()
        return self.query_minutes_share_list_with_options(request, headers, runtime)

    async def query_minutes_share_list_async(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesShareListRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesShareListResponse:
        """
        @summary 获取与我共享闪记列表
        
        @param request: QueryMinutesShareListRequest
        @return: QueryMinutesShareListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesShareListHeaders()
        return await self.query_minutes_share_list_with_options_async(request, headers, runtime)

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

    def query_upload_video_play_info_with_options(
        self,
        video_id: str,
        request: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse:
        """
        @summary 查询上传视频播放信息
        
        @param request: QueryUploadVideoPlayInfoRequest
        @param headers: QueryUploadVideoPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUploadVideoPlayInfoResponse
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
            action='QueryUploadVideoPlayInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/uploadVideos/{video_id}/playInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_upload_video_play_info_with_options_async(
        self,
        video_id: str,
        request: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse:
        """
        @summary 查询上传视频播放信息
        
        @param request: QueryUploadVideoPlayInfoRequest
        @param headers: QueryUploadVideoPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUploadVideoPlayInfoResponse
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
            action='QueryUploadVideoPlayInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/uploadVideos/{video_id}/playInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_upload_video_play_info(
        self,
        video_id: str,
        request: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse:
        """
        @summary 查询上传视频播放信息
        
        @param request: QueryUploadVideoPlayInfoRequest
        @return: QueryUploadVideoPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoHeaders()
        return self.query_upload_video_play_info_with_options(video_id, request, headers, runtime)

    async def query_upload_video_play_info_async(
        self,
        video_id: str,
        request: dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoResponse:
        """
        @summary 查询上传视频播放信息
        
        @param request: QueryUploadVideoPlayInfoRequest
        @return: QueryUploadVideoPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUploadVideoPlayInfoHeaders()
        return await self.query_upload_video_play_info_with_options_async(video_id, request, headers, runtime)

    def update_minutes_title_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdateMinutesTitleRequest,
        headers: dingtalkminutes__1__0_models.UpdateMinutesTitleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.UpdateMinutesTitleResponse:
        """
        @summary 更新闪记标题
        
        @param request: UpdateMinutesTitleRequest
        @param headers: UpdateMinutesTitleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMinutesTitleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='UpdateMinutesTitle',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/titles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.UpdateMinutesTitleResponse(),
            self.execute(params, req, runtime)
        )

    async def update_minutes_title_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdateMinutesTitleRequest,
        headers: dingtalkminutes__1__0_models.UpdateMinutesTitleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.UpdateMinutesTitleResponse:
        """
        @summary 更新闪记标题
        
        @param request: UpdateMinutesTitleRequest
        @param headers: UpdateMinutesTitleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMinutesTitleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='UpdateMinutesTitle',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/titles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.UpdateMinutesTitleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_minutes_title(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdateMinutesTitleRequest,
    ) -> dingtalkminutes__1__0_models.UpdateMinutesTitleResponse:
        """
        @summary 更新闪记标题
        
        @param request: UpdateMinutesTitleRequest
        @return: UpdateMinutesTitleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.UpdateMinutesTitleHeaders()
        return self.update_minutes_title_with_options(task_uuid, request, headers, runtime)

    async def update_minutes_title_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdateMinutesTitleRequest,
    ) -> dingtalkminutes__1__0_models.UpdateMinutesTitleResponse:
        """
        @summary 更新闪记标题
        
        @param request: UpdateMinutesTitleRequest
        @return: UpdateMinutesTitleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.UpdateMinutesTitleHeaders()
        return await self.update_minutes_title_with_options_async(task_uuid, request, headers, runtime)
