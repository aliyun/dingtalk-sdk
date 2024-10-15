# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.sns_storage_1_0 import models as dingtalksns_storage__1__0_models
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

    def get_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
        headers: dingtalksns_storage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        """
        @summary 三方个人应用批量获取文件或文件夹信息
        
        @param request: GetDentriesRequest
        @param headers: GetDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
        headers: dingtalksns_storage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        """
        @summary 三方个人应用批量获取文件或文件夹信息
        
        @param request: GetDentriesRequest
        @param headers: GetDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        """
        @summary 三方个人应用批量获取文件或文件夹信息
        
        @param request: GetDentriesRequest
        @return: GetDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentriesHeaders()
        return self.get_dentries_with_options(space_id, request, headers, runtime)

    async def get_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        """
        @summary 三方个人应用批量获取文件或文件夹信息
        
        @param request: GetDentriesRequest
        @return: GetDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentriesHeaders()
        return await self.get_dentries_with_options_async(space_id, request, headers, runtime)

    def get_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        """
        @summary 三方个人应用获取文件(夹)信息
        
        @param request: GetDentryRequest
        @param headers: GetDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetDentry',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        """
        @summary 三方个人应用获取文件(夹)信息
        
        @param request: GetDentryRequest
        @param headers: GetDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetDentry',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        """
        @summary 三方个人应用获取文件(夹)信息
        
        @param request: GetDentryRequest
        @return: GetDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryHeaders()
        return self.get_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        """
        @summary 三方个人应用获取文件(夹)信息
        
        @param request: GetDentryRequest
        @return: GetDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryHeaders()
        return await self.get_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_dentry_thumbnails_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        """
        @summary 三方个人应用批量获取文件缩略图
        
        @param request: GetDentryThumbnailsRequest
        @param headers: GetDentryThumbnailsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryThumbnailsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
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
            action='GetDentryThumbnails',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/thumbnails/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_thumbnails_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        """
        @summary 三方个人应用批量获取文件缩略图
        
        @param request: GetDentryThumbnailsRequest
        @param headers: GetDentryThumbnailsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryThumbnailsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
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
            action='GetDentryThumbnails',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/thumbnails/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry_thumbnails(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        """
        @summary 三方个人应用批量获取文件缩略图
        
        @param request: GetDentryThumbnailsRequest
        @return: GetDentryThumbnailsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders()
        return self.get_dentry_thumbnails_with_options(space_id, request, headers, runtime)

    async def get_dentry_thumbnails_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        """
        @summary 三方个人应用批量获取文件缩略图
        
        @param request: GetDentryThumbnailsRequest
        @return: GetDentryThumbnailsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders()
        return await self.get_dentry_thumbnails_with_options_async(space_id, request, headers, runtime)

    def get_file_download_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 三方个人应用获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @param headers: GetFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetFileDownloadInfo',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_download_info_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 三方个人应用获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @param headers: GetFileDownloadInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFileDownloadInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetFileDownloadInfo',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_download_info(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 三方个人应用获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @return: GetFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders()
        return self.get_file_download_info_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_file_download_info_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        """
        @summary 三方个人应用获取文件下载信息
        
        @param request: GetFileDownloadInfoRequest
        @return: GetFileDownloadInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders()
        return await self.get_file_download_info_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_space_with_options(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
        headers: dingtalksns_storage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        """
        @summary 三方个人应用获取IM会话存储空间信息
        
        @param request: GetSpaceRequest
        @param headers: GetSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetSpace',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/conversations/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
        headers: dingtalksns_storage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        """
        @summary 三方个人应用获取IM会话存储空间信息
        
        @param request: GetSpaceRequest
        @param headers: GetSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetSpace',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/conversations/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        """
        @summary 三方个人应用获取IM会话存储空间信息
        
        @param request: GetSpaceRequest
        @return: GetSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetSpaceHeaders()
        return self.get_space_with_options(request, headers, runtime)

    async def get_space_async(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        """
        @summary 三方个人应用获取IM会话存储空间信息
        
        @param request: GetSpaceRequest
        @return: GetSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetSpaceHeaders()
        return await self.get_space_with_options_async(request, headers, runtime)

    def list_all_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        """
        @summary 三方个人应用获取全部文件或文件夹列表
        
        @param request: ListAllDentriesRequest
        @param headers: ListAllDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListAllDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/listAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListAllDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_all_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        """
        @summary 三方个人应用获取全部文件或文件夹列表
        
        @param request: ListAllDentriesRequest
        @param headers: ListAllDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListAllDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries/listAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListAllDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_all_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        """
        @summary 三方个人应用获取全部文件或文件夹列表
        
        @param request: ListAllDentriesRequest
        @return: ListAllDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListAllDentriesHeaders()
        return self.list_all_dentries_with_options(space_id, request, headers, runtime)

    async def list_all_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        """
        @summary 三方个人应用获取全部文件或文件夹列表
        
        @param request: ListAllDentriesRequest
        @return: ListAllDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListAllDentriesHeaders()
        return await self.list_all_dentries_with_options_async(space_id, request, headers, runtime)

    def list_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        """
        @summary 三方个人应用获取文件列表
        
        @param request: ListDentriesRequest
        @param headers: ListDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
        if not UtilClient.is_unset(request.order_by):
            query['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_thumbnail):
            query['withThumbnail'] = request.with_thumbnail
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
            action='ListDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        """
        @summary 三方个人应用获取文件列表
        
        @param request: ListDentriesRequest
        @param headers: ListDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
        if not UtilClient.is_unset(request.order_by):
            query['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_thumbnail):
            query['withThumbnail'] = request.with_thumbnail
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
            action='ListDentries',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/spaces/{space_id}/dentries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        """
        @summary 三方个人应用获取文件列表
        
        @param request: ListDentriesRequest
        @return: ListDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListDentriesHeaders()
        return self.list_dentries_with_options(space_id, request, headers, runtime)

    async def list_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        """
        @summary 三方个人应用获取文件列表
        
        @param request: ListDentriesRequest
        @return: ListDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListDentriesHeaders()
        return await self.list_dentries_with_options_async(space_id, request, headers, runtime)

    def list_expired_with_options(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
        headers: dingtalksns_storage__1__0_models.ListExpiredHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        """
        @summary 获取会话过期文件列表
        
        @param request: ListExpiredRequest
        @param headers: ListExpiredHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListExpiredResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListExpired',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/conversations/expiredFileLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListExpiredResponse(),
            self.execute(params, req, runtime)
        )

    async def list_expired_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
        headers: dingtalksns_storage__1__0_models.ListExpiredHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        """
        @summary 获取会话过期文件列表
        
        @param request: ListExpiredRequest
        @param headers: ListExpiredHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListExpiredResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListExpired',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/conversations/expiredFileLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListExpiredResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_expired(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        """
        @summary 获取会话过期文件列表
        
        @param request: ListExpiredRequest
        @return: ListExpiredResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListExpiredHeaders()
        return self.list_expired_with_options(request, headers, runtime)

    async def list_expired_async(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        """
        @summary 获取会话过期文件列表
        
        @param request: ListExpiredRequest
        @return: ListExpiredResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListExpiredHeaders()
        return await self.list_expired_with_options_async(request, headers, runtime)

    def subscribe_event_with_options(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        """
        @summary 三方个人应用订阅文件变更事件
        
        @param request: SubscribeEventRequest
        @param headers: SubscribeEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeEventResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.scope_id):
            body['scopeId'] = request.scope_id
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
            action='SubscribeEvent',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/events/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.SubscribeEventResponse(),
            self.execute(params, req, runtime)
        )

    async def subscribe_event_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        """
        @summary 三方个人应用订阅文件变更事件
        
        @param request: SubscribeEventRequest
        @param headers: SubscribeEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeEventResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.scope_id):
            body['scopeId'] = request.scope_id
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
            action='SubscribeEvent',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/events/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.SubscribeEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def subscribe_event(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        """
        @summary 三方个人应用订阅文件变更事件
        
        @param request: SubscribeEventRequest
        @return: SubscribeEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.SubscribeEventHeaders()
        return self.subscribe_event_with_options(request, headers, runtime)

    async def subscribe_event_async(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        """
        @summary 三方个人应用订阅文件变更事件
        
        @param request: SubscribeEventRequest
        @return: SubscribeEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.SubscribeEventHeaders()
        return await self.subscribe_event_with_options_async(request, headers, runtime)

    def unsubscribe_event_with_options(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        """
        @summary 三方个人应用取消订阅文件变更事件
        
        @param request: UnsubscribeEventRequest
        @param headers: UnsubscribeEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnsubscribeEventResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.scope_id):
            body['scopeId'] = request.scope_id
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
            action='UnsubscribeEvent',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/events/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.UnsubscribeEventResponse(),
            self.execute(params, req, runtime)
        )

    async def unsubscribe_event_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        """
        @summary 三方个人应用取消订阅文件变更事件
        
        @param request: UnsubscribeEventRequest
        @param headers: UnsubscribeEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnsubscribeEventResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.scope_id):
            body['scopeId'] = request.scope_id
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
            action='UnsubscribeEvent',
            version='snsStorage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/snsStorage/events/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.UnsubscribeEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unsubscribe_event(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        """
        @summary 三方个人应用取消订阅文件变更事件
        
        @param request: UnsubscribeEventRequest
        @return: UnsubscribeEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.UnsubscribeEventHeaders()
        return self.unsubscribe_event_with_options(request, headers, runtime)

    async def unsubscribe_event_async(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        """
        @summary 三方个人应用取消订阅文件变更事件
        
        @param request: UnsubscribeEventRequest
        @return: UnsubscribeEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.UnsubscribeEventHeaders()
        return await self.unsubscribe_event_with_options_async(request, headers, runtime)
