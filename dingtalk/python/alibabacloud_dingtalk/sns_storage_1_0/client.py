# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentriesHeaders()
        return self.get_dentries_with_options(space_id, request, headers, runtime)

    async def get_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentriesHeaders()
        return await self.get_dentries_with_options_async(space_id, request, headers, runtime)

    def get_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
        headers: dingtalksns_storage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentriesResponse(),
            self.do_roarequest('GetDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/batchQuery', 'json', req, runtime)
        )

    async def get_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentriesRequest,
        headers: dingtalksns_storage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentriesResponse(),
            await self.do_roarequest_async('GetDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/batchQuery', 'json', req, runtime)
        )

    def get_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryHeaders()
        return self.get_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryHeaders()
        return await self.get_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryResponse(),
            self.do_roarequest('GetDentry', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/query', 'json', req, runtime)
        )

    async def get_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryResponse(),
            await self.do_roarequest_async('GetDentry', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/query', 'json', req, runtime)
        )

    def get_dentry_thumbnails(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders()
        return self.get_dentry_thumbnails_with_options(space_id, request, headers, runtime)

    async def get_dentry_thumbnails_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders()
        return await self.get_dentry_thumbnails_with_options_async(space_id, request, headers, runtime)

    def get_dentry_thumbnails_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse(),
            self.do_roarequest('GetDentryThumbnails', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/thumbnails/query', 'json', req, runtime)
        )

    async def get_dentry_thumbnails_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalksns_storage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetDentryThumbnailsResponse(),
            await self.do_roarequest_async('GetDentryThumbnails', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/thumbnails/query', 'json', req, runtime)
        )

    def get_file_download_info(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders()
        return self.get_file_download_info_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_file_download_info_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders()
        return await self.get_file_download_info_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_file_download_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse(),
            self.do_roarequest('GetFileDownloadInfo', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query', 'json', req, runtime)
        )

    async def get_file_download_info_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalksns_storage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalksns_storage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetFileDownloadInfoResponse(),
            await self.do_roarequest_async('GetFileDownloadInfo', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query', 'json', req, runtime)
        )

    def get_space(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetSpaceHeaders()
        return self.get_space_with_options(request, headers, runtime)

    async def get_space_async(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.GetSpaceHeaders()
        return await self.get_space_with_options_async(request, headers, runtime)

    def get_space_with_options(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
        headers: dingtalksns_storage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetSpaceResponse(),
            self.do_roarequest('GetSpace', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/conversations/spaces/query', 'json', req, runtime)
        )

    async def get_space_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.GetSpaceRequest,
        headers: dingtalksns_storage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.GetSpaceResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.GetSpaceResponse(),
            await self.do_roarequest_async('GetSpace', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/conversations/spaces/query', 'json', req, runtime)
        )

    def list_all_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListAllDentriesHeaders()
        return self.list_all_dentries_with_options(space_id, request, headers, runtime)

    async def list_all_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListAllDentriesHeaders()
        return await self.list_all_dentries_with_options_async(space_id, request, headers, runtime)

    def list_all_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListAllDentriesResponse(),
            self.do_roarequest('ListAllDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/listAll', 'json', req, runtime)
        )

    async def list_all_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListAllDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListAllDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListAllDentriesResponse(),
            await self.do_roarequest_async('ListAllDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries/listAll', 'json', req, runtime)
        )

    def list_dentries(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListDentriesHeaders()
        return self.list_dentries_with_options(space_id, request, headers, runtime)

    async def list_dentries_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListDentriesHeaders()
        return await self.list_dentries_with_options_async(space_id, request, headers, runtime)

    def list_dentries_with_options(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListDentriesResponse(),
            self.do_roarequest('ListDentries', 'snsStorage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries', 'json', req, runtime)
        )

    async def list_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalksns_storage__1__0_models.ListDentriesRequest,
        headers: dingtalksns_storage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListDentriesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListDentriesResponse(),
            await self.do_roarequest_async('ListDentries', 'snsStorage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/snsStorage/spaces/{space_id}/dentries', 'json', req, runtime)
        )

    def list_expired(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListExpiredHeaders()
        return self.list_expired_with_options(request, headers, runtime)

    async def list_expired_async(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.ListExpiredHeaders()
        return await self.list_expired_with_options_async(request, headers, runtime)

    def list_expired_with_options(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
        headers: dingtalksns_storage__1__0_models.ListExpiredHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListExpiredResponse(),
            self.do_roarequest('ListExpired', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/conversations/expiredFileLists/query', 'json', req, runtime)
        )

    async def list_expired_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.ListExpiredRequest,
        headers: dingtalksns_storage__1__0_models.ListExpiredHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.ListExpiredResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.ListExpiredResponse(),
            await self.do_roarequest_async('ListExpired', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/conversations/expiredFileLists/query', 'json', req, runtime)
        )

    def subscribe_event(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.SubscribeEventHeaders()
        return self.subscribe_event_with_options(request, headers, runtime)

    async def subscribe_event_async(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.SubscribeEventHeaders()
        return await self.subscribe_event_with_options_async(request, headers, runtime)

    def subscribe_event_with_options(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.SubscribeEventResponse(),
            self.do_roarequest('SubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/events/subscribe', 'json', req, runtime)
        )

    async def subscribe_event_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.SubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.SubscribeEventResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.SubscribeEventResponse(),
            await self.do_roarequest_async('SubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/events/subscribe', 'json', req, runtime)
        )

    def unsubscribe_event(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.UnsubscribeEventHeaders()
        return self.unsubscribe_event_with_options(request, headers, runtime)

    async def unsubscribe_event_async(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksns_storage__1__0_models.UnsubscribeEventHeaders()
        return await self.unsubscribe_event_with_options_async(request, headers, runtime)

    def unsubscribe_event_with_options(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.UnsubscribeEventResponse(),
            self.do_roarequest('UnsubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/events/unsubscribe', 'json', req, runtime)
        )

    async def unsubscribe_event_with_options_async(
        self,
        request: dingtalksns_storage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalksns_storage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksns_storage__1__0_models.UnsubscribeEventResponse:
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
        return TeaCore.from_map(
            dingtalksns_storage__1__0_models.UnsubscribeEventResponse(),
            await self.do_roarequest_async('UnsubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/snsStorage/events/unsubscribe', 'json', req, runtime)
        )
