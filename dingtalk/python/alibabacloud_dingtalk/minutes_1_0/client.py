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

    def admin_search_minutes_with_options(
        self,
        request: dingtalkminutes__1__0_models.AdminSearchMinutesRequest,
        headers: dingtalkminutes__1__0_models.AdminSearchMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.AdminSearchMinutesResponse:
        """
        @summary 搜索企业内听记
        
        @param request: AdminSearchMinutesRequest
        @param headers: AdminSearchMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdminSearchMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.creator_union_ids):
            body['creatorUnionIds'] = request.creator_union_ids
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.query):
            body['query'] = request.query
        if not UtilClient.is_unset(request.search_type):
            body['searchType'] = request.search_type
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='AdminSearchMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/adminSearch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.AdminSearchMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def admin_search_minutes_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.AdminSearchMinutesRequest,
        headers: dingtalkminutes__1__0_models.AdminSearchMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.AdminSearchMinutesResponse:
        """
        @summary 搜索企业内听记
        
        @param request: AdminSearchMinutesRequest
        @param headers: AdminSearchMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AdminSearchMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.creator_union_ids):
            body['creatorUnionIds'] = request.creator_union_ids
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.query):
            body['query'] = request.query
        if not UtilClient.is_unset(request.search_type):
            body['searchType'] = request.search_type
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='AdminSearchMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/adminSearch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.AdminSearchMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def admin_search_minutes(
        self,
        request: dingtalkminutes__1__0_models.AdminSearchMinutesRequest,
    ) -> dingtalkminutes__1__0_models.AdminSearchMinutesResponse:
        """
        @summary 搜索企业内听记
        
        @param request: AdminSearchMinutesRequest
        @return: AdminSearchMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.AdminSearchMinutesHeaders()
        return self.admin_search_minutes_with_options(request, headers, runtime)

    async def admin_search_minutes_async(
        self,
        request: dingtalkminutes__1__0_models.AdminSearchMinutesRequest,
    ) -> dingtalkminutes__1__0_models.AdminSearchMinutesResponse:
        """
        @summary 搜索企业内听记
        
        @param request: AdminSearchMinutesRequest
        @return: AdminSearchMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.AdminSearchMinutesHeaders()
        return await self.admin_search_minutes_with_options_async(request, headers, runtime)

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

    def create_minutes_by_upload_file_with_options(
        self,
        request: dingtalkminutes__1__0_models.CreateMinutesByUploadFileRequest,
        headers: dingtalkminutes__1__0_models.CreateMinutesByUploadFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse:
        """
        @summary 从上传的媒体文件创建闪记
        
        @param request: CreateMinutesByUploadFileRequest
        @param headers: CreateMinutesByUploadFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMinutesByUploadFileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.custom_prompt):
            body['customPrompt'] = request.custom_prompt
        if not UtilClient.is_unset(request.enable_push_card):
            body['enablePushCard'] = request.enable_push_card
        if not UtilClient.is_unset(request.hidden_minutes):
            body['hiddenMinutes'] = request.hidden_minutes
        if not UtilClient.is_unset(request.media_file_url):
            body['mediaFileUrl'] = request.media_file_url
        if not UtilClient.is_unset(request.media_type):
            body['mediaType'] = request.media_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateMinutesByUploadFile',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/createMinutesByUploadFile',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse(),
            self.execute(params, req, runtime)
        )

    async def create_minutes_by_upload_file_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.CreateMinutesByUploadFileRequest,
        headers: dingtalkminutes__1__0_models.CreateMinutesByUploadFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse:
        """
        @summary 从上传的媒体文件创建闪记
        
        @param request: CreateMinutesByUploadFileRequest
        @param headers: CreateMinutesByUploadFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMinutesByUploadFileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.custom_prompt):
            body['customPrompt'] = request.custom_prompt
        if not UtilClient.is_unset(request.enable_push_card):
            body['enablePushCard'] = request.enable_push_card
        if not UtilClient.is_unset(request.hidden_minutes):
            body['hiddenMinutes'] = request.hidden_minutes
        if not UtilClient.is_unset(request.media_file_url):
            body['mediaFileUrl'] = request.media_file_url
        if not UtilClient.is_unset(request.media_type):
            body['mediaType'] = request.media_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateMinutesByUploadFile',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/createMinutesByUploadFile',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_minutes_by_upload_file(
        self,
        request: dingtalkminutes__1__0_models.CreateMinutesByUploadFileRequest,
    ) -> dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse:
        """
        @summary 从上传的媒体文件创建闪记
        
        @param request: CreateMinutesByUploadFileRequest
        @return: CreateMinutesByUploadFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.CreateMinutesByUploadFileHeaders()
        return self.create_minutes_by_upload_file_with_options(request, headers, runtime)

    async def create_minutes_by_upload_file_async(
        self,
        request: dingtalkminutes__1__0_models.CreateMinutesByUploadFileRequest,
    ) -> dingtalkminutes__1__0_models.CreateMinutesByUploadFileResponse:
        """
        @summary 从上传的媒体文件创建闪记
        
        @param request: CreateMinutesByUploadFileRequest
        @return: CreateMinutesByUploadFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.CreateMinutesByUploadFileHeaders()
        return await self.create_minutes_by_upload_file_with_options_async(request, headers, runtime)

    def create_smart_device_ai_summary_with_options(
        self,
        request: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryRequest,
        headers: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse:
        """
        @summary 创建DingTalkA1小助理分析
        
        @param request: CreateSmartDeviceAiSummaryRequest
        @param headers: CreateSmartDeviceAiSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSmartDeviceAiSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_context):
            body['isvContext'] = request.isv_context
        if not UtilClient.is_unset(request.open_file_id):
            body['openFileId'] = request.open_file_id
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
            action='CreateSmartDeviceAiSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/smartdevice/aisummary/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def create_smart_device_ai_summary_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryRequest,
        headers: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse:
        """
        @summary 创建DingTalkA1小助理分析
        
        @param request: CreateSmartDeviceAiSummaryRequest
        @param headers: CreateSmartDeviceAiSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSmartDeviceAiSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_context):
            body['isvContext'] = request.isv_context
        if not UtilClient.is_unset(request.open_file_id):
            body['openFileId'] = request.open_file_id
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
            action='CreateSmartDeviceAiSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/smartdevice/aisummary/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_smart_device_ai_summary(
        self,
        request: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryRequest,
    ) -> dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse:
        """
        @summary 创建DingTalkA1小助理分析
        
        @param request: CreateSmartDeviceAiSummaryRequest
        @return: CreateSmartDeviceAiSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryHeaders()
        return self.create_smart_device_ai_summary_with_options(request, headers, runtime)

    async def create_smart_device_ai_summary_async(
        self,
        request: dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryRequest,
    ) -> dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryResponse:
        """
        @summary 创建DingTalkA1小助理分析
        
        @param request: CreateSmartDeviceAiSummaryRequest
        @return: CreateSmartDeviceAiSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.CreateSmartDeviceAiSummaryHeaders()
        return await self.create_smart_device_ai_summary_with_options_async(request, headers, runtime)

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

    def export_minutes_task_result_with_options(
        self,
        request: dingtalkminutes__1__0_models.ExportMinutesTaskResultRequest,
        headers: dingtalkminutes__1__0_models.ExportMinutesTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse:
        """
        @summary 导出闪记任务结果
        
        @param request: ExportMinutesTaskResultRequest
        @param headers: ExportMinutesTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportMinutesTaskResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.summary_export_setting):
            body['summaryExportSetting'] = request.summary_export_setting
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_uuid):
            body['taskUuid'] = request.task_uuid
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
            action='ExportMinutesTaskResult',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/minutesTask/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse(),
            self.execute(params, req, runtime)
        )

    async def export_minutes_task_result_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.ExportMinutesTaskResultRequest,
        headers: dingtalkminutes__1__0_models.ExportMinutesTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse:
        """
        @summary 导出闪记任务结果
        
        @param request: ExportMinutesTaskResultRequest
        @param headers: ExportMinutesTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportMinutesTaskResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.summary_export_setting):
            body['summaryExportSetting'] = request.summary_export_setting
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_uuid):
            body['taskUuid'] = request.task_uuid
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
            action='ExportMinutesTaskResult',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/minutesTask/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def export_minutes_task_result(
        self,
        request: dingtalkminutes__1__0_models.ExportMinutesTaskResultRequest,
    ) -> dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse:
        """
        @summary 导出闪记任务结果
        
        @param request: ExportMinutesTaskResultRequest
        @return: ExportMinutesTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.ExportMinutesTaskResultHeaders()
        return self.export_minutes_task_result_with_options(request, headers, runtime)

    async def export_minutes_task_result_async(
        self,
        request: dingtalkminutes__1__0_models.ExportMinutesTaskResultRequest,
    ) -> dingtalkminutes__1__0_models.ExportMinutesTaskResultResponse:
        """
        @summary 导出闪记任务结果
        
        @param request: ExportMinutesTaskResultRequest
        @return: ExportMinutesTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.ExportMinutesTaskResultHeaders()
        return await self.export_minutes_task_result_with_options_async(request, headers, runtime)

    def generate_summary_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.GenerateSummaryRequest,
        headers: dingtalkminutes__1__0_models.GenerateSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.GenerateSummaryResponse:
        """
        @summary 生成摘要
        
        @param request: GenerateSummaryRequest
        @param headers: GenerateSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.diy_template_version):
            body['diyTemplateVersion'] = request.diy_template_version
        if not UtilClient.is_unset(request.summary_template_id):
            body['summaryTemplateId'] = request.summary_template_id
        if not UtilClient.is_unset(request.summary_template_type):
            body['summaryTemplateType'] = request.summary_template_type
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
            action='GenerateSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/summary',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.GenerateSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def generate_summary_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.GenerateSummaryRequest,
        headers: dingtalkminutes__1__0_models.GenerateSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.GenerateSummaryResponse:
        """
        @summary 生成摘要
        
        @param request: GenerateSummaryRequest
        @param headers: GenerateSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.diy_template_version):
            body['diyTemplateVersion'] = request.diy_template_version
        if not UtilClient.is_unset(request.summary_template_id):
            body['summaryTemplateId'] = request.summary_template_id
        if not UtilClient.is_unset(request.summary_template_type):
            body['summaryTemplateType'] = request.summary_template_type
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
            action='GenerateSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/summary',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.GenerateSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def generate_summary(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.GenerateSummaryRequest,
    ) -> dingtalkminutes__1__0_models.GenerateSummaryResponse:
        """
        @summary 生成摘要
        
        @param request: GenerateSummaryRequest
        @return: GenerateSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.GenerateSummaryHeaders()
        return self.generate_summary_with_options(task_uuid, request, headers, runtime)

    async def generate_summary_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.GenerateSummaryRequest,
    ) -> dingtalkminutes__1__0_models.GenerateSummaryResponse:
        """
        @summary 生成摘要
        
        @param request: GenerateSummaryRequest
        @return: GenerateSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.GenerateSummaryHeaders()
        return await self.generate_summary_with_options_async(task_uuid, request, headers, runtime)

    def open_query_minutes_summary_with_options(
        self,
        request: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryRequest,
        headers: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse:
        """
        @summary 查询闪记摘要
        
        @param request: OpenQueryMinutesSummaryRequest
        @param headers: OpenQueryMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenQueryMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
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
            action='OpenQueryMinutesSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryMinutesSummary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def open_query_minutes_summary_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryRequest,
        headers: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse:
        """
        @summary 查询闪记摘要
        
        @param request: OpenQueryMinutesSummaryRequest
        @param headers: OpenQueryMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenQueryMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
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
            action='OpenQueryMinutesSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryMinutesSummary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_query_minutes_summary(
        self,
        request: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryRequest,
    ) -> dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse:
        """
        @summary 查询闪记摘要
        
        @param request: OpenQueryMinutesSummaryRequest
        @return: OpenQueryMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.OpenQueryMinutesSummaryHeaders()
        return self.open_query_minutes_summary_with_options(request, headers, runtime)

    async def open_query_minutes_summary_async(
        self,
        request: dingtalkminutes__1__0_models.OpenQueryMinutesSummaryRequest,
    ) -> dingtalkminutes__1__0_models.OpenQueryMinutesSummaryResponse:
        """
        @summary 查询闪记摘要
        
        @param request: OpenQueryMinutesSummaryRequest
        @return: OpenQueryMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.OpenQueryMinutesSummaryHeaders()
        return await self.open_query_minutes_summary_with_options_async(request, headers, runtime)

    def query_biz_minutes_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryBizMinutesRequest,
        headers: dingtalkminutes__1__0_models.QueryBizMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryBizMinutesResponse:
        """
        @summary 查询闪会、文档等来源的闪记列表
        
        @param request: QueryBizMinutesRequest
        @param headers: QueryBizMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBizMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_id):
            query['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
            action='QueryBizMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryBizMinutes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryBizMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_biz_minutes_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryBizMinutesRequest,
        headers: dingtalkminutes__1__0_models.QueryBizMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryBizMinutesResponse:
        """
        @summary 查询闪会、文档等来源的闪记列表
        
        @param request: QueryBizMinutesRequest
        @param headers: QueryBizMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBizMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_id):
            query['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
            action='QueryBizMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryBizMinutes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryBizMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_biz_minutes(
        self,
        request: dingtalkminutes__1__0_models.QueryBizMinutesRequest,
    ) -> dingtalkminutes__1__0_models.QueryBizMinutesResponse:
        """
        @summary 查询闪会、文档等来源的闪记列表
        
        @param request: QueryBizMinutesRequest
        @return: QueryBizMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryBizMinutesHeaders()
        return self.query_biz_minutes_with_options(request, headers, runtime)

    async def query_biz_minutes_async(
        self,
        request: dingtalkminutes__1__0_models.QueryBizMinutesRequest,
    ) -> dingtalkminutes__1__0_models.QueryBizMinutesResponse:
        """
        @summary 查询闪会、文档等来源的闪记列表
        
        @param request: QueryBizMinutesRequest
        @return: QueryBizMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryBizMinutesHeaders()
        return await self.query_biz_minutes_with_options_async(request, headers, runtime)

    def query_create_minutes_list_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryCreateMinutesListRequest,
        headers: dingtalkminutes__1__0_models.QueryCreateMinutesListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryCreateMinutesListResponse:
        """
        @summary 查询自己创建的闪记列表
        
        @param request: QueryCreateMinutesListRequest
        @param headers: QueryCreateMinutesListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCreateMinutesListResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryCreateMinutesList',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/createLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryCreateMinutesListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_create_minutes_list_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryCreateMinutesListRequest,
        headers: dingtalkminutes__1__0_models.QueryCreateMinutesListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryCreateMinutesListResponse:
        """
        @summary 查询自己创建的闪记列表
        
        @param request: QueryCreateMinutesListRequest
        @param headers: QueryCreateMinutesListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCreateMinutesListResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryCreateMinutesList',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/createLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryCreateMinutesListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_create_minutes_list(
        self,
        request: dingtalkminutes__1__0_models.QueryCreateMinutesListRequest,
    ) -> dingtalkminutes__1__0_models.QueryCreateMinutesListResponse:
        """
        @summary 查询自己创建的闪记列表
        
        @param request: QueryCreateMinutesListRequest
        @return: QueryCreateMinutesListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryCreateMinutesListHeaders()
        return self.query_create_minutes_list_with_options(request, headers, runtime)

    async def query_create_minutes_list_async(
        self,
        request: dingtalkminutes__1__0_models.QueryCreateMinutesListRequest,
    ) -> dingtalkminutes__1__0_models.QueryCreateMinutesListResponse:
        """
        @summary 查询自己创建的闪记列表
        
        @param request: QueryCreateMinutesListRequest
        @return: QueryCreateMinutesListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryCreateMinutesListHeaders()
        return await self.query_create_minutes_list_with_options_async(request, headers, runtime)

    def query_minutes_basic_info_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesBasicInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse:
        """
        @summary 查询闪记基本信息
        
        @param request: QueryMinutesBasicInfoRequest
        @param headers: QueryMinutesBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
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
            action='QueryMinutesBasicInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryMinutesBasicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_basic_info_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesBasicInfoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse:
        """
        @summary 查询闪记基本信息
        
        @param request: QueryMinutesBasicInfoRequest
        @param headers: QueryMinutesBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
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
            action='QueryMinutesBasicInfo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/queryMinutesBasicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_basic_info(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesBasicInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse:
        """
        @summary 查询闪记基本信息
        
        @param request: QueryMinutesBasicInfoRequest
        @return: QueryMinutesBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesBasicInfoHeaders()
        return self.query_minutes_basic_info_with_options(request, headers, runtime)

    async def query_minutes_basic_info_async(
        self,
        request: dingtalkminutes__1__0_models.QueryMinutesBasicInfoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesBasicInfoResponse:
        """
        @summary 查询闪记基本信息
        
        @param request: QueryMinutesBasicInfoRequest
        @return: QueryMinutesBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesBasicInfoHeaders()
        return await self.query_minutes_basic_info_with_options_async(request, headers, runtime)

    def query_minutes_chapters_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesChaptersRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesChaptersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesChaptersResponse:
        """
        @summary 查询听记智能章节列表
        
        @param request: QueryMinutesChaptersRequest
        @param headers: QueryMinutesChaptersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesChaptersResponse
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
            action='QueryMinutesChapters',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/chapters',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesChaptersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_chapters_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesChaptersRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesChaptersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesChaptersResponse:
        """
        @summary 查询听记智能章节列表
        
        @param request: QueryMinutesChaptersRequest
        @param headers: QueryMinutesChaptersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesChaptersResponse
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
            action='QueryMinutesChapters',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/chapters',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesChaptersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_chapters(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesChaptersRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesChaptersResponse:
        """
        @summary 查询听记智能章节列表
        
        @param request: QueryMinutesChaptersRequest
        @return: QueryMinutesChaptersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesChaptersHeaders()
        return self.query_minutes_chapters_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_chapters_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesChaptersRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesChaptersResponse:
        """
        @summary 查询听记智能章节列表
        
        @param request: QueryMinutesChaptersRequest
        @return: QueryMinutesChaptersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesChaptersHeaders()
        return await self.query_minutes_chapters_with_options_async(task_uuid, request, headers, runtime)

    def query_minutes_keyword_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesKeywordRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesKeywordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesKeywordResponse:
        """
        @summary 查询闪记关键字
        
        @param request: QueryMinutesKeywordRequest
        @param headers: QueryMinutesKeywordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesKeywordResponse
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
            action='QueryMinutesKeyword',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/keywords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesKeywordResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_keyword_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesKeywordRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesKeywordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesKeywordResponse:
        """
        @summary 查询闪记关键字
        
        @param request: QueryMinutesKeywordRequest
        @param headers: QueryMinutesKeywordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesKeywordResponse
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
            action='QueryMinutesKeyword',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/keywords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesKeywordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_keyword(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesKeywordRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesKeywordResponse:
        """
        @summary 查询闪记关键字
        
        @param request: QueryMinutesKeywordRequest
        @return: QueryMinutesKeywordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesKeywordHeaders()
        return self.query_minutes_keyword_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_keyword_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesKeywordRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesKeywordResponse:
        """
        @summary 查询闪记关键字
        
        @param request: QueryMinutesKeywordRequest
        @return: QueryMinutesKeywordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesKeywordHeaders()
        return await self.query_minutes_keyword_with_options_async(task_uuid, request, headers, runtime)

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

    def query_minutes_todo_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTodoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesTodoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTodoResponse:
        """
        @summary 查询闪记待办
        
        @param request: QueryMinutesTodoRequest
        @param headers: QueryMinutesTodoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTodoResponse
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
            action='QueryMinutesTodo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/todos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesTodoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_todo_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTodoRequest,
        headers: dingtalkminutes__1__0_models.QueryMinutesTodoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTodoResponse:
        """
        @summary 查询闪记待办
        
        @param request: QueryMinutesTodoRequest
        @param headers: QueryMinutesTodoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTodoResponse
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
            action='QueryMinutesTodo',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/{task_uuid}/todos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryMinutesTodoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_todo(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTodoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTodoResponse:
        """
        @summary 查询闪记待办
        
        @param request: QueryMinutesTodoRequest
        @return: QueryMinutesTodoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesTodoHeaders()
        return self.query_minutes_todo_with_options(task_uuid, request, headers, runtime)

    async def query_minutes_todo_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QueryMinutesTodoRequest,
    ) -> dingtalkminutes__1__0_models.QueryMinutesTodoResponse:
        """
        @summary 查询闪记待办
        
        @param request: QueryMinutesTodoRequest
        @return: QueryMinutesTodoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryMinutesTodoHeaders()
        return await self.query_minutes_todo_with_options_async(task_uuid, request, headers, runtime)

    def query_org_diy_templates_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesRequest,
        headers: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse:
        """
        @summary 查询企业所有自定义纪要模板列表
        
        @param request: QueryOrgDiyTemplatesRequest
        @param headers: QueryOrgDiyTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgDiyTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryOrgDiyTemplates',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/diyTemplates/orgDeclared',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_diy_templates_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesRequest,
        headers: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse:
        """
        @summary 查询企业所有自定义纪要模板列表
        
        @param request: QueryOrgDiyTemplatesRequest
        @param headers: QueryOrgDiyTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgDiyTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryOrgDiyTemplates',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/diyTemplates/orgDeclared',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_diy_templates(
        self,
        request: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesRequest,
    ) -> dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse:
        """
        @summary 查询企业所有自定义纪要模板列表
        
        @param request: QueryOrgDiyTemplatesRequest
        @return: QueryOrgDiyTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryOrgDiyTemplatesHeaders()
        return self.query_org_diy_templates_with_options(request, headers, runtime)

    async def query_org_diy_templates_async(
        self,
        request: dingtalkminutes__1__0_models.QueryOrgDiyTemplatesRequest,
    ) -> dingtalkminutes__1__0_models.QueryOrgDiyTemplatesResponse:
        """
        @summary 查询企业所有自定义纪要模板列表
        
        @param request: QueryOrgDiyTemplatesRequest
        @return: QueryOrgDiyTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryOrgDiyTemplatesHeaders()
        return await self.query_org_diy_templates_with_options_async(request, headers, runtime)

    def query_schedule_conf_minutes_with_options(
        self,
        schedule_conference_id: str,
        request: dingtalkminutes__1__0_models.QueryScheduleConfMinutesRequest,
        headers: dingtalkminutes__1__0_models.QueryScheduleConfMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse:
        """
        @summary 查询预约会议闪记列表
        
        @param request: QueryScheduleConfMinutesRequest
        @param headers: QueryScheduleConfMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConfMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.event_id):
            query['eventId'] = request.event_id
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
            action='QueryScheduleConfMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/scheduleConference/{schedule_conference_id}/minutes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_schedule_conf_minutes_with_options_async(
        self,
        schedule_conference_id: str,
        request: dingtalkminutes__1__0_models.QueryScheduleConfMinutesRequest,
        headers: dingtalkminutes__1__0_models.QueryScheduleConfMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse:
        """
        @summary 查询预约会议闪记列表
        
        @param request: QueryScheduleConfMinutesRequest
        @param headers: QueryScheduleConfMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConfMinutesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.event_id):
            query['eventId'] = request.event_id
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
            action='QueryScheduleConfMinutes',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/scheduleConference/{schedule_conference_id}/minutes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_schedule_conf_minutes(
        self,
        schedule_conference_id: str,
        request: dingtalkminutes__1__0_models.QueryScheduleConfMinutesRequest,
    ) -> dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse:
        """
        @summary 查询预约会议闪记列表
        
        @param request: QueryScheduleConfMinutesRequest
        @return: QueryScheduleConfMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryScheduleConfMinutesHeaders()
        return self.query_schedule_conf_minutes_with_options(schedule_conference_id, request, headers, runtime)

    async def query_schedule_conf_minutes_async(
        self,
        schedule_conference_id: str,
        request: dingtalkminutes__1__0_models.QueryScheduleConfMinutesRequest,
    ) -> dingtalkminutes__1__0_models.QueryScheduleConfMinutesResponse:
        """
        @summary 查询预约会议闪记列表
        
        @param request: QueryScheduleConfMinutesRequest
        @return: QueryScheduleConfMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryScheduleConfMinutesHeaders()
        return await self.query_schedule_conf_minutes_with_options_async(schedule_conference_id, request, headers, runtime)

    def query_smart_device_ai_summary_with_options(
        self,
        request: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryRequest,
        headers: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse:
        """
        @summary 查询DingTalkA1小助理分析
        
        @param request: QuerySmartDeviceAiSummaryRequest
        @param headers: QuerySmartDeviceAiSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySmartDeviceAiSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.open_file_id):
            body['openFileId'] = request.open_file_id
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
            action='QuerySmartDeviceAiSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/smartdevice/aisummary',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_smart_device_ai_summary_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryRequest,
        headers: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse:
        """
        @summary 查询DingTalkA1小助理分析
        
        @param request: QuerySmartDeviceAiSummaryRequest
        @param headers: QuerySmartDeviceAiSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySmartDeviceAiSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.open_file_id):
            body['openFileId'] = request.open_file_id
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
            action='QuerySmartDeviceAiSummary',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/smartdevice/aisummary',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_smart_device_ai_summary(
        self,
        request: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryRequest,
    ) -> dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse:
        """
        @summary 查询DingTalkA1小助理分析
        
        @param request: QuerySmartDeviceAiSummaryRequest
        @return: QuerySmartDeviceAiSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryHeaders()
        return self.query_smart_device_ai_summary_with_options(request, headers, runtime)

    async def query_smart_device_ai_summary_async(
        self,
        request: dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryRequest,
    ) -> dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryResponse:
        """
        @summary 查询DingTalkA1小助理分析
        
        @param request: QuerySmartDeviceAiSummaryRequest
        @return: QuerySmartDeviceAiSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QuerySmartDeviceAiSummaryHeaders()
        return await self.query_smart_device_ai_summary_with_options_async(request, headers, runtime)

    def query_summary_with_template_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QuerySummaryWithTemplateRequest,
        headers: dingtalkminutes__1__0_models.QuerySummaryWithTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse:
        """
        @summary 根据模板id查询摘要
        
        @param request: QuerySummaryWithTemplateRequest
        @param headers: QuerySummaryWithTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySummaryWithTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.diy_template_version):
            query['diyTemplateVersion'] = request.diy_template_version
        if not UtilClient.is_unset(request.summary_template_id):
            query['summaryTemplateId'] = request.summary_template_id
        if not UtilClient.is_unset(request.summary_template_type):
            query['summaryTemplateType'] = request.summary_template_type
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
            action='QuerySummaryWithTemplate',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/summary/template',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def query_summary_with_template_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QuerySummaryWithTemplateRequest,
        headers: dingtalkminutes__1__0_models.QuerySummaryWithTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse:
        """
        @summary 根据模板id查询摘要
        
        @param request: QuerySummaryWithTemplateRequest
        @param headers: QuerySummaryWithTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySummaryWithTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.diy_template_version):
            query['diyTemplateVersion'] = request.diy_template_version
        if not UtilClient.is_unset(request.summary_template_id):
            query['summaryTemplateId'] = request.summary_template_id
        if not UtilClient.is_unset(request.summary_template_type):
            query['summaryTemplateType'] = request.summary_template_type
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
            action='QuerySummaryWithTemplate',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/summary/template',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_summary_with_template(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QuerySummaryWithTemplateRequest,
    ) -> dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse:
        """
        @summary 根据模板id查询摘要
        
        @param request: QuerySummaryWithTemplateRequest
        @return: QuerySummaryWithTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QuerySummaryWithTemplateHeaders()
        return self.query_summary_with_template_with_options(task_uuid, request, headers, runtime)

    async def query_summary_with_template_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.QuerySummaryWithTemplateRequest,
    ) -> dingtalkminutes__1__0_models.QuerySummaryWithTemplateResponse:
        """
        @summary 根据模板id查询摘要
        
        @param request: QuerySummaryWithTemplateRequest
        @return: QuerySummaryWithTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QuerySummaryWithTemplateHeaders()
        return await self.query_summary_with_template_with_options_async(task_uuid, request, headers, runtime)

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

    def query_user_available_diy_templates_with_options(
        self,
        request: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesRequest,
        headers: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse:
        """
        @summary 查询用户可见的企业自定义纪要模版列表
        
        @param request: QueryUserAvailableDiyTemplatesRequest
        @param headers: QueryUserAvailableDiyTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserAvailableDiyTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryUserAvailableDiyTemplates',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/diyTemplates/userAvailable',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_available_diy_templates_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesRequest,
        headers: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse:
        """
        @summary 查询用户可见的企业自定义纪要模版列表
        
        @param request: QueryUserAvailableDiyTemplatesRequest
        @param headers: QueryUserAvailableDiyTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserAvailableDiyTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryUserAvailableDiyTemplates',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/diyTemplates/userAvailable',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_available_diy_templates(
        self,
        request: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesRequest,
    ) -> dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse:
        """
        @summary 查询用户可见的企业自定义纪要模版列表
        
        @param request: QueryUserAvailableDiyTemplatesRequest
        @return: QueryUserAvailableDiyTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesHeaders()
        return self.query_user_available_diy_templates_with_options(request, headers, runtime)

    async def query_user_available_diy_templates_async(
        self,
        request: dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesRequest,
    ) -> dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesResponse:
        """
        @summary 查询用户可见的企业自定义纪要模版列表
        
        @param request: QueryUserAvailableDiyTemplatesRequest
        @return: QueryUserAvailableDiyTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUserAvailableDiyTemplatesHeaders()
        return await self.query_user_available_diy_templates_with_options_async(request, headers, runtime)

    def query_user_minutes_permission_with_options(
        self,
        task_uuid: str,
        union_id: str,
        headers: dingtalkminutes__1__0_models.QueryUserMinutesPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse:
        """
        @summary 查询指定用户对某篇听记的权限
        
        @param headers: QueryUserMinutesPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserMinutesPermissionResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryUserMinutesPermission',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/permissions/{union_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_minutes_permission_with_options_async(
        self,
        task_uuid: str,
        union_id: str,
        headers: dingtalkminutes__1__0_models.QueryUserMinutesPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse:
        """
        @summary 查询指定用户对某篇听记的权限
        
        @param headers: QueryUserMinutesPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserMinutesPermissionResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryUserMinutesPermission',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/permissions/{union_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_minutes_permission(
        self,
        task_uuid: str,
        union_id: str,
    ) -> dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse:
        """
        @summary 查询指定用户对某篇听记的权限
        
        @return: QueryUserMinutesPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUserMinutesPermissionHeaders()
        return self.query_user_minutes_permission_with_options(task_uuid, union_id, headers, runtime)

    async def query_user_minutes_permission_async(
        self,
        task_uuid: str,
        union_id: str,
    ) -> dingtalkminutes__1__0_models.QueryUserMinutesPermissionResponse:
        """
        @summary 查询指定用户对某篇听记的权限
        
        @return: QueryUserMinutesPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.QueryUserMinutesPermissionHeaders()
        return await self.query_user_minutes_permission_with_options_async(task_uuid, union_id, headers, runtime)

    def regenerate_chapters_with_options(
        self,
        request: dingtalkminutes__1__0_models.RegenerateChaptersRequest,
        headers: dingtalkminutes__1__0_models.RegenerateChaptersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.RegenerateChaptersResponse:
        """
        @summary 重新生成听记智能章节
        
        @param request: RegenerateChaptersRequest
        @param headers: RegenerateChaptersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegenerateChaptersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_prompt):
            body['customPrompt'] = request.custom_prompt
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
            action='RegenerateChapters',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/chapters/regenerate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.RegenerateChaptersResponse(),
            self.execute(params, req, runtime)
        )

    async def regenerate_chapters_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.RegenerateChaptersRequest,
        headers: dingtalkminutes__1__0_models.RegenerateChaptersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.RegenerateChaptersResponse:
        """
        @summary 重新生成听记智能章节
        
        @param request: RegenerateChaptersRequest
        @param headers: RegenerateChaptersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegenerateChaptersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_uuid):
            query['taskUuid'] = request.task_uuid
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_prompt):
            body['customPrompt'] = request.custom_prompt
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
            action='RegenerateChapters',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/chapters/regenerate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.RegenerateChaptersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def regenerate_chapters(
        self,
        request: dingtalkminutes__1__0_models.RegenerateChaptersRequest,
    ) -> dingtalkminutes__1__0_models.RegenerateChaptersResponse:
        """
        @summary 重新生成听记智能章节
        
        @param request: RegenerateChaptersRequest
        @return: RegenerateChaptersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.RegenerateChaptersHeaders()
        return self.regenerate_chapters_with_options(request, headers, runtime)

    async def regenerate_chapters_async(
        self,
        request: dingtalkminutes__1__0_models.RegenerateChaptersRequest,
    ) -> dingtalkminutes__1__0_models.RegenerateChaptersResponse:
        """
        @summary 重新生成听记智能章节
        
        @param request: RegenerateChaptersRequest
        @return: RegenerateChaptersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.RegenerateChaptersHeaders()
        return await self.regenerate_chapters_with_options_async(request, headers, runtime)

    def set_detail_page_custom_tab_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetDetailPageCustomTabRequest,
        headers: dingtalkminutes__1__0_models.SetDetailPageCustomTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse:
        """
        @summary 自定义听记详情页tab
        
        @param request: SetDetailPageCustomTabRequest
        @param headers: SetDetailPageCustomTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDetailPageCustomTabResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_tab_list):
            body['customTabList'] = request.custom_tab_list
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
            action='SetDetailPageCustomTab',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/customTabs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse(),
            self.execute(params, req, runtime)
        )

    async def set_detail_page_custom_tab_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetDetailPageCustomTabRequest,
        headers: dingtalkminutes__1__0_models.SetDetailPageCustomTabHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse:
        """
        @summary 自定义听记详情页tab
        
        @param request: SetDetailPageCustomTabRequest
        @param headers: SetDetailPageCustomTabHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDetailPageCustomTabResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_tab_list):
            body['customTabList'] = request.custom_tab_list
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
            action='SetDetailPageCustomTab',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/customTabs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_detail_page_custom_tab(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetDetailPageCustomTabRequest,
    ) -> dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse:
        """
        @summary 自定义听记详情页tab
        
        @param request: SetDetailPageCustomTabRequest
        @return: SetDetailPageCustomTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetDetailPageCustomTabHeaders()
        return self.set_detail_page_custom_tab_with_options(task_uuid, request, headers, runtime)

    async def set_detail_page_custom_tab_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetDetailPageCustomTabRequest,
    ) -> dingtalkminutes__1__0_models.SetDetailPageCustomTabResponse:
        """
        @summary 自定义听记详情页tab
        
        @param request: SetDetailPageCustomTabRequest
        @return: SetDetailPageCustomTabResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetDetailPageCustomTabHeaders()
        return await self.set_detail_page_custom_tab_with_options_async(task_uuid, request, headers, runtime)

    def set_in_progress_custom_tabs_with_options(
        self,
        request: dingtalkminutes__1__0_models.SetInProgressCustomTabsRequest,
        headers: dingtalkminutes__1__0_models.SetInProgressCustomTabsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse:
        """
        @summary 配置应用在听记录制页的自定义Tab
        
        @param request: SetInProgressCustomTabsRequest
        @param headers: SetInProgressCustomTabsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetInProgressCustomTabsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_tab_list):
            body['customTabList'] = request.custom_tab_list
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
            action='SetInProgressCustomTabs',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/apps/settings/inProgressTabs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse(),
            self.execute(params, req, runtime)
        )

    async def set_in_progress_custom_tabs_with_options_async(
        self,
        request: dingtalkminutes__1__0_models.SetInProgressCustomTabsRequest,
        headers: dingtalkminutes__1__0_models.SetInProgressCustomTabsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse:
        """
        @summary 配置应用在听记录制页的自定义Tab
        
        @param request: SetInProgressCustomTabsRequest
        @param headers: SetInProgressCustomTabsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetInProgressCustomTabsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.custom_tab_list):
            body['customTabList'] = request.custom_tab_list
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
            action='SetInProgressCustomTabs',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/apps/settings/inProgressTabs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_in_progress_custom_tabs(
        self,
        request: dingtalkminutes__1__0_models.SetInProgressCustomTabsRequest,
    ) -> dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse:
        """
        @summary 配置应用在听记录制页的自定义Tab
        
        @param request: SetInProgressCustomTabsRequest
        @return: SetInProgressCustomTabsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetInProgressCustomTabsHeaders()
        return self.set_in_progress_custom_tabs_with_options(request, headers, runtime)

    async def set_in_progress_custom_tabs_async(
        self,
        request: dingtalkminutes__1__0_models.SetInProgressCustomTabsRequest,
    ) -> dingtalkminutes__1__0_models.SetInProgressCustomTabsResponse:
        """
        @summary 配置应用在听记录制页的自定义Tab
        
        @param request: SetInProgressCustomTabsRequest
        @return: SetInProgressCustomTabsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetInProgressCustomTabsHeaders()
        return await self.set_in_progress_custom_tabs_with_options_async(request, headers, runtime)

    def set_minutes_todos_visible_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetMinutesTodosVisibleRequest,
        headers: dingtalkminutes__1__0_models.SetMinutesTodosVisibleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse:
        """
        @summary 设置AI纪要待办模块可见性
        
        @param request: SetMinutesTodosVisibleRequest
        @param headers: SetMinutesTodosVisibleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetMinutesTodosVisibleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.todos_visible):
            body['todosVisible'] = request.todos_visible
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
            action='SetMinutesTodosVisible',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/todosVisible',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse(),
            self.execute(params, req, runtime)
        )

    async def set_minutes_todos_visible_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetMinutesTodosVisibleRequest,
        headers: dingtalkminutes__1__0_models.SetMinutesTodosVisibleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse:
        """
        @summary 设置AI纪要待办模块可见性
        
        @param request: SetMinutesTodosVisibleRequest
        @param headers: SetMinutesTodosVisibleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetMinutesTodosVisibleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.todos_visible):
            body['todosVisible'] = request.todos_visible
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
            action='SetMinutesTodosVisible',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/flashMinutes/tasks/{task_uuid}/todosVisible',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_minutes_todos_visible(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetMinutesTodosVisibleRequest,
    ) -> dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse:
        """
        @summary 设置AI纪要待办模块可见性
        
        @param request: SetMinutesTodosVisibleRequest
        @return: SetMinutesTodosVisibleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetMinutesTodosVisibleHeaders()
        return self.set_minutes_todos_visible_with_options(task_uuid, request, headers, runtime)

    async def set_minutes_todos_visible_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.SetMinutesTodosVisibleRequest,
    ) -> dingtalkminutes__1__0_models.SetMinutesTodosVisibleResponse:
        """
        @summary 设置AI纪要待办模块可见性
        
        @param request: SetMinutesTodosVisibleRequest
        @return: SetMinutesTodosVisibleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.SetMinutesTodosVisibleHeaders()
        return await self.set_minutes_todos_visible_with_options_async(task_uuid, request, headers, runtime)

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

    def update_permission_with_options(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdatePermissionRequest,
        headers: dingtalkminutes__1__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.UpdatePermissionResponse:
        """
        @summary 更新闪记权限
        
        @param request: UpdatePermissionRequest
        @param headers: UpdatePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.member_info_list):
            body['memberInfoList'] = request.member_info_list
        if not UtilClient.is_unset(request.op_type):
            body['opType'] = request.op_type
        if not UtilClient.is_unset(request.role_code):
            body['roleCode'] = request.role_code
        if not UtilClient.is_unset(request.role_sub_resource_ids):
            body['roleSubResourceIds'] = request.role_sub_resource_ids
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
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
            action='UpdatePermission',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/{task_uuid}/permission',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.UpdatePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def update_permission_with_options_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdatePermissionRequest,
        headers: dingtalkminutes__1__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkminutes__1__0_models.UpdatePermissionResponse:
        """
        @summary 更新闪记权限
        
        @param request: UpdatePermissionRequest
        @param headers: UpdatePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.member_info_list):
            body['memberInfoList'] = request.member_info_list
        if not UtilClient.is_unset(request.op_type):
            body['opType'] = request.op_type
        if not UtilClient.is_unset(request.role_code):
            body['roleCode'] = request.role_code
        if not UtilClient.is_unset(request.role_sub_resource_ids):
            body['roleSubResourceIds'] = request.role_sub_resource_ids
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
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
            action='UpdatePermission',
            version='minutes_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/minutes/{task_uuid}/permission',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkminutes__1__0_models.UpdatePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_permission(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdatePermissionRequest,
    ) -> dingtalkminutes__1__0_models.UpdatePermissionResponse:
        """
        @summary 更新闪记权限
        
        @param request: UpdatePermissionRequest
        @return: UpdatePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.UpdatePermissionHeaders()
        return self.update_permission_with_options(task_uuid, request, headers, runtime)

    async def update_permission_async(
        self,
        task_uuid: str,
        request: dingtalkminutes__1__0_models.UpdatePermissionRequest,
    ) -> dingtalkminutes__1__0_models.UpdatePermissionResponse:
        """
        @summary 更新闪记权限
        
        @param request: UpdatePermissionRequest
        @return: UpdatePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkminutes__1__0_models.UpdatePermissionHeaders()
        return await self.update_permission_with_options_async(task_uuid, request, headers, runtime)
