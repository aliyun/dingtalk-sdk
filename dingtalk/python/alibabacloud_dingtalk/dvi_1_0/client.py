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
