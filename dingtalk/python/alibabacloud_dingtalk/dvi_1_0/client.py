# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.dvi_1_0 import models as dingtalkdvi__1__0_models
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

    def get_audio_file_download_info_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoRequest,
        headers: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse:
        """
        @summary 获取音频文件下载地址
        
        @param request: GetAudioFileDownloadInfoRequest
        @param headers: GetAudioFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAudioFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
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
            action='GetAudioFileDownloadInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/download',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_audio_file_download_info_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoRequest,
        headers: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse:
        """
        @summary 获取音频文件下载地址
        
        @param request: GetAudioFileDownloadInfoRequest
        @param headers: GetAudioFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAudioFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
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
            action='GetAudioFileDownloadInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/download',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_audio_file_download_info(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse:
        """
        @summary 获取音频文件下载地址
        
        @param request: GetAudioFileDownloadInfoRequest
        @return: GetAudioFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetAudioFileDownloadInfoHeaders()
        return self.get_audio_file_download_info_with_options(request, headers, runtime)

    async def get_audio_file_download_info_async(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileDownloadInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetAudioFileDownloadInfoResponse:
        """
        @summary 获取音频文件下载地址
        
        @param request: GetAudioFileDownloadInfoRequest
        @return: GetAudioFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetAudioFileDownloadInfoHeaders()
        return await self.get_audio_file_download_info_with_options_async(request, headers, runtime)

    def get_audio_file_info_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileInfoRequest,
        headers: dingtalkdvi__1__0_models.GetAudioFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetAudioFileInfoResponse:
        """
        @summary 获取音频文件信息
        
        @param request: GetAudioFileInfoRequest
        @param headers: GetAudioFileInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAudioFileInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
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
            action='GetAudioFileInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/get',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetAudioFileInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_audio_file_info_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileInfoRequest,
        headers: dingtalkdvi__1__0_models.GetAudioFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetAudioFileInfoResponse:
        """
        @summary 获取音频文件信息
        
        @param request: GetAudioFileInfoRequest
        @param headers: GetAudioFileInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAudioFileInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
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
            action='GetAudioFileInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/get',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetAudioFileInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_audio_file_info(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetAudioFileInfoResponse:
        """
        @summary 获取音频文件信息
        
        @param request: GetAudioFileInfoRequest
        @return: GetAudioFileInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetAudioFileInfoHeaders()
        return self.get_audio_file_info_with_options(request, headers, runtime)

    async def get_audio_file_info_async(
        self,
        request: dingtalkdvi__1__0_models.GetAudioFileInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetAudioFileInfoResponse:
        """
        @summary 获取音频文件信息
        
        @param request: GetAudioFileInfoRequest
        @return: GetAudioFileInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetAudioFileInfoHeaders()
        return await self.get_audio_file_info_with_options_async(request, headers, runtime)

    def get_customer_info_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetCustomerInfoRequest,
        headers: dingtalkdvi__1__0_models.GetCustomerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetCustomerInfoResponse:
        """
        @summary 查询客户数据
        
        @param request: GetCustomerInfoRequest
        @param headers: GetCustomerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCustomerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.customer_id):
            query['customerId'] = request.customer_id
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
            action='GetCustomerInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/customer',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetCustomerInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_customer_info_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetCustomerInfoRequest,
        headers: dingtalkdvi__1__0_models.GetCustomerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetCustomerInfoResponse:
        """
        @summary 查询客户数据
        
        @param request: GetCustomerInfoRequest
        @param headers: GetCustomerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCustomerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.customer_id):
            query['customerId'] = request.customer_id
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
            action='GetCustomerInfo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/customer',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetCustomerInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_customer_info(
        self,
        request: dingtalkdvi__1__0_models.GetCustomerInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetCustomerInfoResponse:
        """
        @summary 查询客户数据
        
        @param request: GetCustomerInfoRequest
        @return: GetCustomerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetCustomerInfoHeaders()
        return self.get_customer_info_with_options(request, headers, runtime)

    async def get_customer_info_async(
        self,
        request: dingtalkdvi__1__0_models.GetCustomerInfoRequest,
    ) -> dingtalkdvi__1__0_models.GetCustomerInfoResponse:
        """
        @summary 查询客户数据
        
        @param request: GetCustomerInfoRequest
        @return: GetCustomerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetCustomerInfoHeaders()
        return await self.get_customer_info_with_options_async(request, headers, runtime)

    def get_service_chapter_summary_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChapterSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetServiceChapterSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse:
        """
        @summary 获取服务章节摘要
        
        @param request: GetServiceChapterSummaryRequest
        @param headers: GetServiceChapterSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceChapterSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceChapterSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/chapters/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_service_chapter_summary_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChapterSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetServiceChapterSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse:
        """
        @summary 获取服务章节摘要
        
        @param request: GetServiceChapterSummaryRequest
        @param headers: GetServiceChapterSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceChapterSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceChapterSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/chapters/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_service_chapter_summary(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChapterSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse:
        """
        @summary 获取服务章节摘要
        
        @param request: GetServiceChapterSummaryRequest
        @return: GetServiceChapterSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceChapterSummaryHeaders()
        return self.get_service_chapter_summary_with_options(request, headers, runtime)

    async def get_service_chapter_summary_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChapterSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceChapterSummaryResponse:
        """
        @summary 获取服务章节摘要
        
        @param request: GetServiceChapterSummaryRequest
        @return: GetServiceChapterSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceChapterSummaryHeaders()
        return await self.get_service_chapter_summary_with_options_async(request, headers, runtime)

    def get_service_chat_summary_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChatSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetServiceChatSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceChatSummaryResponse:
        """
        @summary 获取服务会话总结
        
        @param request: GetServiceChatSummaryRequest
        @param headers: GetServiceChatSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceChatSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceChatSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/chats/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceChatSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_service_chat_summary_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChatSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetServiceChatSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceChatSummaryResponse:
        """
        @summary 获取服务会话总结
        
        @param request: GetServiceChatSummaryRequest
        @param headers: GetServiceChatSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceChatSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceChatSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/chats/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceChatSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_service_chat_summary(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChatSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceChatSummaryResponse:
        """
        @summary 获取服务会话总结
        
        @param request: GetServiceChatSummaryRequest
        @return: GetServiceChatSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceChatSummaryHeaders()
        return self.get_service_chat_summary_with_options(request, headers, runtime)

    async def get_service_chat_summary_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceChatSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceChatSummaryResponse:
        """
        @summary 获取服务会话总结
        
        @param request: GetServiceChatSummaryRequest
        @return: GetServiceChatSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceChatSummaryHeaders()
        return await self.get_service_chat_summary_with_options_async(request, headers, runtime)

    def get_service_quality_inspection_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetServiceQualityInspectionRequest,
        headers: dingtalkdvi__1__0_models.GetServiceQualityInspectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse:
        """
        @summary 查询服务质检信息
        
        @param request: GetServiceQualityInspectionRequest
        @param headers: GetServiceQualityInspectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceQualityInspectionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceQualityInspection',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/quality-inspections',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_service_quality_inspection_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceQualityInspectionRequest,
        headers: dingtalkdvi__1__0_models.GetServiceQualityInspectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse:
        """
        @summary 查询服务质检信息
        
        @param request: GetServiceQualityInspectionRequest
        @param headers: GetServiceQualityInspectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceQualityInspectionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='GetServiceQualityInspection',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/quality-inspections',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_service_quality_inspection(
        self,
        request: dingtalkdvi__1__0_models.GetServiceQualityInspectionRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse:
        """
        @summary 查询服务质检信息
        
        @param request: GetServiceQualityInspectionRequest
        @return: GetServiceQualityInspectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceQualityInspectionHeaders()
        return self.get_service_quality_inspection_with_options(request, headers, runtime)

    async def get_service_quality_inspection_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceQualityInspectionRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceQualityInspectionResponse:
        """
        @summary 查询服务质检信息
        
        @param request: GetServiceQualityInspectionRequest
        @return: GetServiceQualityInspectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceQualityInspectionHeaders()
        return await self.get_service_quality_inspection_with_options_async(request, headers, runtime)

    def get_service_record_transcript_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetServiceRecordTranscriptRequest,
        headers: dingtalkdvi__1__0_models.GetServiceRecordTranscriptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse:
        """
        @summary 获取服务记录音频转写信息
        
        @param request: GetServiceRecordTranscriptRequest
        @param headers: GetServiceRecordTranscriptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceRecordTranscriptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.id):
            query['id'] = request.id
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
            action='GetServiceRecordTranscript',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/transcript',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse(),
            self.execute(params, req, runtime)
        )

    async def get_service_record_transcript_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceRecordTranscriptRequest,
        headers: dingtalkdvi__1__0_models.GetServiceRecordTranscriptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse:
        """
        @summary 获取服务记录音频转写信息
        
        @param request: GetServiceRecordTranscriptRequest
        @param headers: GetServiceRecordTranscriptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetServiceRecordTranscriptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.id):
            query['id'] = request.id
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
            action='GetServiceRecordTranscript',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service/transcript',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_service_record_transcript(
        self,
        request: dingtalkdvi__1__0_models.GetServiceRecordTranscriptRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse:
        """
        @summary 获取服务记录音频转写信息
        
        @param request: GetServiceRecordTranscriptRequest
        @return: GetServiceRecordTranscriptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceRecordTranscriptHeaders()
        return self.get_service_record_transcript_with_options(request, headers, runtime)

    async def get_service_record_transcript_async(
        self,
        request: dingtalkdvi__1__0_models.GetServiceRecordTranscriptRequest,
    ) -> dingtalkdvi__1__0_models.GetServiceRecordTranscriptResponse:
        """
        @summary 获取服务记录音频转写信息
        
        @param request: GetServiceRecordTranscriptRequest
        @return: GetServiceRecordTranscriptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetServiceRecordTranscriptHeaders()
        return await self.get_service_record_transcript_with_options_async(request, headers, runtime)

    def get_transcript_summary_with_options(
        self,
        request: dingtalkdvi__1__0_models.GetTranscriptSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetTranscriptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetTranscriptSummaryResponse:
        """
        @summary 获取文件转写的概要信息
        
        @param request: GetTranscriptSummaryRequest
        @param headers: GetTranscriptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranscriptSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_type):
            query['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            query['fileId'] = request.file_id
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
            action='GetTranscriptSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/transcripts/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetTranscriptSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_transcript_summary_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.GetTranscriptSummaryRequest,
        headers: dingtalkdvi__1__0_models.GetTranscriptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.GetTranscriptSummaryResponse:
        """
        @summary 获取文件转写的概要信息
        
        @param request: GetTranscriptSummaryRequest
        @param headers: GetTranscriptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranscriptSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_type):
            query['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.file_id):
            query['fileId'] = request.file_id
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
            action='GetTranscriptSummary',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/transcripts/summary',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.GetTranscriptSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_transcript_summary(
        self,
        request: dingtalkdvi__1__0_models.GetTranscriptSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetTranscriptSummaryResponse:
        """
        @summary 获取文件转写的概要信息
        
        @param request: GetTranscriptSummaryRequest
        @return: GetTranscriptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetTranscriptSummaryHeaders()
        return self.get_transcript_summary_with_options(request, headers, runtime)

    async def get_transcript_summary_async(
        self,
        request: dingtalkdvi__1__0_models.GetTranscriptSummaryRequest,
    ) -> dingtalkdvi__1__0_models.GetTranscriptSummaryResponse:
        """
        @summary 获取文件转写的概要信息
        
        @param request: GetTranscriptSummaryRequest
        @return: GetTranscriptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.GetTranscriptSummaryHeaders()
        return await self.get_transcript_summary_with_options_async(request, headers, runtime)

    def list_customer_with_options(
        self,
        request: dingtalkdvi__1__0_models.ListCustomerRequest,
        headers: dingtalkdvi__1__0_models.ListCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListCustomerResponse:
        """
        @summary 查询客户列表
        
        @param request: ListCustomerRequest
        @param headers: ListCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCustomerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.owner_user_id):
            query['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.team_code):
            query['teamCode'] = request.team_code
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
            action='ListCustomer',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListCustomerResponse(),
            self.execute(params, req, runtime)
        )

    async def list_customer_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.ListCustomerRequest,
        headers: dingtalkdvi__1__0_models.ListCustomerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListCustomerResponse:
        """
        @summary 查询客户列表
        
        @param request: ListCustomerRequest
        @param headers: ListCustomerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCustomerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.owner_user_id):
            query['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.team_code):
            query['teamCode'] = request.team_code
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
            action='ListCustomer',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/customers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListCustomerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_customer(
        self,
        request: dingtalkdvi__1__0_models.ListCustomerRequest,
    ) -> dingtalkdvi__1__0_models.ListCustomerResponse:
        """
        @summary 查询客户列表
        
        @param request: ListCustomerRequest
        @return: ListCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListCustomerHeaders()
        return self.list_customer_with_options(request, headers, runtime)

    async def list_customer_async(
        self,
        request: dingtalkdvi__1__0_models.ListCustomerRequest,
    ) -> dingtalkdvi__1__0_models.ListCustomerResponse:
        """
        @summary 查询客户列表
        
        @param request: ListCustomerRequest
        @return: ListCustomerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListCustomerHeaders()
        return await self.list_customer_with_options_async(request, headers, runtime)

    def list_service_record_with_options(
        self,
        request: dingtalkdvi__1__0_models.ListServiceRecordRequest,
        headers: dingtalkdvi__1__0_models.ListServiceRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListServiceRecordResponse:
        """
        @summary 分页查询服务记录
        
        @param request: ListServiceRecordRequest
        @param headers: ListServiceRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListServiceRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.team_code):
            query['teamCode'] = request.team_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='ListServiceRecord',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service-records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListServiceRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def list_service_record_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.ListServiceRecordRequest,
        headers: dingtalkdvi__1__0_models.ListServiceRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListServiceRecordResponse:
        """
        @summary 分页查询服务记录
        
        @param request: ListServiceRecordRequest
        @param headers: ListServiceRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListServiceRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.team_code):
            query['teamCode'] = request.team_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='ListServiceRecord',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service-records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListServiceRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_service_record(
        self,
        request: dingtalkdvi__1__0_models.ListServiceRecordRequest,
    ) -> dingtalkdvi__1__0_models.ListServiceRecordResponse:
        """
        @summary 分页查询服务记录
        
        @param request: ListServiceRecordRequest
        @return: ListServiceRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListServiceRecordHeaders()
        return self.list_service_record_with_options(request, headers, runtime)

    async def list_service_record_async(
        self,
        request: dingtalkdvi__1__0_models.ListServiceRecordRequest,
    ) -> dingtalkdvi__1__0_models.ListServiceRecordResponse:
        """
        @summary 分页查询服务记录
        
        @param request: ListServiceRecordRequest
        @return: ListServiceRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListServiceRecordHeaders()
        return await self.list_service_record_with_options_async(request, headers, runtime)

    def list_service_todo_with_options(
        self,
        request: dingtalkdvi__1__0_models.ListServiceTodoRequest,
        headers: dingtalkdvi__1__0_models.ListServiceTodoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListServiceTodoResponse:
        """
        @summary 查询服务记录待办列表
        
        @param request: ListServiceTodoRequest
        @param headers: ListServiceTodoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListServiceTodoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='ListServiceTodo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service-todos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListServiceTodoResponse(),
            self.execute(params, req, runtime)
        )

    async def list_service_todo_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.ListServiceTodoRequest,
        headers: dingtalkdvi__1__0_models.ListServiceTodoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListServiceTodoResponse:
        """
        @summary 查询服务记录待办列表
        
        @param request: ListServiceTodoRequest
        @param headers: ListServiceTodoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListServiceTodoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.record_id):
            query['recordId'] = request.record_id
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
            action='ListServiceTodo',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/service-todos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListServiceTodoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_service_todo(
        self,
        request: dingtalkdvi__1__0_models.ListServiceTodoRequest,
    ) -> dingtalkdvi__1__0_models.ListServiceTodoResponse:
        """
        @summary 查询服务记录待办列表
        
        @param request: ListServiceTodoRequest
        @return: ListServiceTodoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListServiceTodoHeaders()
        return self.list_service_todo_with_options(request, headers, runtime)

    async def list_service_todo_async(
        self,
        request: dingtalkdvi__1__0_models.ListServiceTodoRequest,
    ) -> dingtalkdvi__1__0_models.ListServiceTodoResponse:
        """
        @summary 查询服务记录待办列表
        
        @param request: ListServiceTodoRequest
        @return: ListServiceTodoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListServiceTodoHeaders()
        return await self.list_service_todo_with_options_async(request, headers, runtime)

    def list_team_with_options(
        self,
        request: dingtalkdvi__1__0_models.ListTeamRequest,
        headers: dingtalkdvi__1__0_models.ListTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListTeamResponse:
        """
        @summary 查询团队列表
        
        @param request: ListTeamRequest
        @param headers: ListTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamResponse
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
            action='ListTeam',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def list_team_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.ListTeamRequest,
        headers: dingtalkdvi__1__0_models.ListTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.ListTeamResponse:
        """
        @summary 查询团队列表
        
        @param request: ListTeamRequest
        @param headers: ListTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamResponse
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
            action='ListTeam',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.ListTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_team(
        self,
        request: dingtalkdvi__1__0_models.ListTeamRequest,
    ) -> dingtalkdvi__1__0_models.ListTeamResponse:
        """
        @summary 查询团队列表
        
        @param request: ListTeamRequest
        @return: ListTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListTeamHeaders()
        return self.list_team_with_options(request, headers, runtime)

    async def list_team_async(
        self,
        request: dingtalkdvi__1__0_models.ListTeamRequest,
    ) -> dingtalkdvi__1__0_models.ListTeamResponse:
        """
        @summary 查询团队列表
        
        @param request: ListTeamRequest
        @return: ListTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.ListTeamHeaders()
        return await self.list_team_with_options_async(request, headers, runtime)

    def query_asr_task_with_options(
        self,
        request: dingtalkdvi__1__0_models.QueryAsrTaskRequest,
        headers: dingtalkdvi__1__0_models.QueryAsrTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryAsrTaskResponse:
        """
        @summary 查询asr结果
        
        @param request: QueryAsrTaskRequest
        @param headers: QueryAsrTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAsrTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='QueryAsrTask',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/asr/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryAsrTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def query_asr_task_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.QueryAsrTaskRequest,
        headers: dingtalkdvi__1__0_models.QueryAsrTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryAsrTaskResponse:
        """
        @summary 查询asr结果
        
        @param request: QueryAsrTaskRequest
        @param headers: QueryAsrTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAsrTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='QueryAsrTask',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/asr/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryAsrTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_asr_task(
        self,
        request: dingtalkdvi__1__0_models.QueryAsrTaskRequest,
    ) -> dingtalkdvi__1__0_models.QueryAsrTaskResponse:
        """
        @summary 查询asr结果
        
        @param request: QueryAsrTaskRequest
        @return: QueryAsrTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryAsrTaskHeaders()
        return self.query_asr_task_with_options(request, headers, runtime)

    async def query_asr_task_async(
        self,
        request: dingtalkdvi__1__0_models.QueryAsrTaskRequest,
    ) -> dingtalkdvi__1__0_models.QueryAsrTaskResponse:
        """
        @summary 查询asr结果
        
        @param request: QueryAsrTaskRequest
        @return: QueryAsrTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryAsrTaskHeaders()
        return await self.query_asr_task_with_options_async(request, headers, runtime)

    def query_audio_file_with_options(
        self,
        request: dingtalkdvi__1__0_models.QueryAudioFileRequest,
        headers: dingtalkdvi__1__0_models.QueryAudioFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryAudioFileResponse:
        """
        @summary 分页查询指定设备的音频文件列表
        
        @param request: QueryAudioFileRequest
        @param headers: QueryAudioFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAudioFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.end_timestamp):
            body['endTimestamp'] = request.end_timestamp
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.start_timestamp):
            body['startTimestamp'] = request.start_timestamp
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
            action='QueryAudioFile',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryAudioFileResponse(),
            self.execute(params, req, runtime)
        )

    async def query_audio_file_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.QueryAudioFileRequest,
        headers: dingtalkdvi__1__0_models.QueryAudioFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryAudioFileResponse:
        """
        @summary 分页查询指定设备的音频文件列表
        
        @param request: QueryAudioFileRequest
        @param headers: QueryAudioFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAudioFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.end_timestamp):
            body['endTimestamp'] = request.end_timestamp
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.start_timestamp):
            body['startTimestamp'] = request.start_timestamp
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
            action='QueryAudioFile',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/audio/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryAudioFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_audio_file(
        self,
        request: dingtalkdvi__1__0_models.QueryAudioFileRequest,
    ) -> dingtalkdvi__1__0_models.QueryAudioFileResponse:
        """
        @summary 分页查询指定设备的音频文件列表
        
        @param request: QueryAudioFileRequest
        @return: QueryAudioFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryAudioFileHeaders()
        return self.query_audio_file_with_options(request, headers, runtime)

    async def query_audio_file_async(
        self,
        request: dingtalkdvi__1__0_models.QueryAudioFileRequest,
    ) -> dingtalkdvi__1__0_models.QueryAudioFileResponse:
        """
        @summary 分页查询指定设备的音频文件列表
        
        @param request: QueryAudioFileRequest
        @return: QueryAudioFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryAudioFileHeaders()
        return await self.query_audio_file_with_options_async(request, headers, runtime)

    def query_device_detail_with_options(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceDetailRequest,
        headers: dingtalkdvi__1__0_models.QueryDeviceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryDeviceDetailResponse:
        """
        @summary 获取设备列表
        
        @param request: QueryDeviceDetailRequest
        @param headers: QueryDeviceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.sn_list):
            body['snList'] = request.sn_list
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
            action='QueryDeviceDetail',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryDeviceDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_detail_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceDetailRequest,
        headers: dingtalkdvi__1__0_models.QueryDeviceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryDeviceDetailResponse:
        """
        @summary 获取设备列表
        
        @param request: QueryDeviceDetailRequest
        @param headers: QueryDeviceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.sn_list):
            body['snList'] = request.sn_list
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
            action='QueryDeviceDetail',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryDeviceDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_detail(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceDetailRequest,
    ) -> dingtalkdvi__1__0_models.QueryDeviceDetailResponse:
        """
        @summary 获取设备列表
        
        @param request: QueryDeviceDetailRequest
        @return: QueryDeviceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryDeviceDetailHeaders()
        return self.query_device_detail_with_options(request, headers, runtime)

    async def query_device_detail_async(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceDetailRequest,
    ) -> dingtalkdvi__1__0_models.QueryDeviceDetailResponse:
        """
        @summary 获取设备列表
        
        @param request: QueryDeviceDetailRequest
        @return: QueryDeviceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryDeviceDetailHeaders()
        return await self.query_device_detail_with_options_async(request, headers, runtime)

    def query_device_status_with_options(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceStatusRequest,
        headers: dingtalkdvi__1__0_models.QueryDeviceStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryDeviceStatusResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDeviceStatusRequest
        @param headers: QueryDeviceStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.sn_list):
            body['snList'] = request.sn_list
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
            action='QueryDeviceStatus',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/status',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryDeviceStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_status_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceStatusRequest,
        headers: dingtalkdvi__1__0_models.QueryDeviceStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.QueryDeviceStatusResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDeviceStatusRequest
        @param headers: QueryDeviceStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.sn_list):
            body['snList'] = request.sn_list
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
            action='QueryDeviceStatus',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/device/status',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.QueryDeviceStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_status(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceStatusRequest,
    ) -> dingtalkdvi__1__0_models.QueryDeviceStatusResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDeviceStatusRequest
        @return: QueryDeviceStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryDeviceStatusHeaders()
        return self.query_device_status_with_options(request, headers, runtime)

    async def query_device_status_async(
        self,
        request: dingtalkdvi__1__0_models.QueryDeviceStatusRequest,
    ) -> dingtalkdvi__1__0_models.QueryDeviceStatusResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDeviceStatusRequest
        @return: QueryDeviceStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.QueryDeviceStatusHeaders()
        return await self.query_device_status_with_options_async(request, headers, runtime)

    def submit_asr_task_with_options(
        self,
        request: dingtalkdvi__1__0_models.SubmitAsrTaskRequest,
        headers: dingtalkdvi__1__0_models.SubmitAsrTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.SubmitAsrTaskResponse:
        """
        @summary asr离线任务
        
        @param request: SubmitAsrTaskRequest
        @param headers: SubmitAsrTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitAsrTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_key):
            body['bizKey'] = request.biz_key
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.phrases):
            body['phrases'] = request.phrases
        if not UtilClient.is_unset(request.source_language):
            body['sourceLanguage'] = request.source_language
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.transcription):
            body['transcription'] = request.transcription
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='SubmitAsrTask',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/asr/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.SubmitAsrTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def submit_asr_task_with_options_async(
        self,
        request: dingtalkdvi__1__0_models.SubmitAsrTaskRequest,
        headers: dingtalkdvi__1__0_models.SubmitAsrTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdvi__1__0_models.SubmitAsrTaskResponse:
        """
        @summary asr离线任务
        
        @param request: SubmitAsrTaskRequest
        @param headers: SubmitAsrTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitAsrTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_key):
            body['bizKey'] = request.biz_key
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.phrases):
            body['phrases'] = request.phrases
        if not UtilClient.is_unset(request.source_language):
            body['sourceLanguage'] = request.source_language
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.transcription):
            body['transcription'] = request.transcription
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='SubmitAsrTask',
            version='dvi_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dvi/asr/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdvi__1__0_models.SubmitAsrTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def submit_asr_task(
        self,
        request: dingtalkdvi__1__0_models.SubmitAsrTaskRequest,
    ) -> dingtalkdvi__1__0_models.SubmitAsrTaskResponse:
        """
        @summary asr离线任务
        
        @param request: SubmitAsrTaskRequest
        @return: SubmitAsrTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.SubmitAsrTaskHeaders()
        return self.submit_asr_task_with_options(request, headers, runtime)

    async def submit_asr_task_async(
        self,
        request: dingtalkdvi__1__0_models.SubmitAsrTaskRequest,
    ) -> dingtalkdvi__1__0_models.SubmitAsrTaskResponse:
        """
        @summary asr离线任务
        
        @param request: SubmitAsrTaskRequest
        @return: SubmitAsrTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdvi__1__0_models.SubmitAsrTaskHeaders()
        return await self.submit_asr_task_with_options_async(request, headers, runtime)
