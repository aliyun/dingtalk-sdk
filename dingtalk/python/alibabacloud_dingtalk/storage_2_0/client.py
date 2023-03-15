# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.storage_2_0 import models as dingtalkstorage__2__0_models
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

    def commit_file(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.CommitFileHeaders()
        return self.commit_file_with_options(parent_dentry_uuid, request, headers, runtime)

    async def commit_file_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.CommitFileHeaders()
        return await self.commit_file_with_options_async(parent_dentry_uuid, request, headers, runtime)

    def commit_file_with_options(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
        headers: dingtalkstorage__2__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        parent_dentry_uuid = OpenApiUtilClient.get_encode_param(parent_dentry_uuid)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.upload_key):
            body['uploadKey'] = request.upload_key
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
            dingtalkstorage__2__0_models.CommitFileResponse(),
            self.do_roarequest('CommitFile', 'storage_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/commit', 'json', req, runtime)
        )

    async def commit_file_with_options_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
        headers: dingtalkstorage__2__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        parent_dentry_uuid = OpenApiUtilClient.get_encode_param(parent_dentry_uuid)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.upload_key):
            body['uploadKey'] = request.upload_key
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
            dingtalkstorage__2__0_models.CommitFileResponse(),
            await self.do_roarequest_async('CommitFile', 'storage_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/commit', 'json', req, runtime)
        )

    def get_file_upload_info(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.GetFileUploadInfoHeaders()
        return self.get_file_upload_info_with_options(parent_dentry_uuid, request, headers, runtime)

    async def get_file_upload_info_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.GetFileUploadInfoHeaders()
        return await self.get_file_upload_info_with_options_async(parent_dentry_uuid, request, headers, runtime)

    def get_file_upload_info_with_options(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__2__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        parent_dentry_uuid = OpenApiUtilClient.get_encode_param(parent_dentry_uuid)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.protocol):
            body['protocol'] = request.protocol
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
            dingtalkstorage__2__0_models.GetFileUploadInfoResponse(),
            self.do_roarequest('GetFileUploadInfo', 'storage_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/uploadInfos/query', 'json', req, runtime)
        )

    async def get_file_upload_info_with_options_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__2__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        parent_dentry_uuid = OpenApiUtilClient.get_encode_param(parent_dentry_uuid)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.protocol):
            body['protocol'] = request.protocol
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
            dingtalkstorage__2__0_models.GetFileUploadInfoResponse(),
            await self.do_roarequest_async('GetFileUploadInfo', 'storage_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/uploadInfos/query', 'json', req, runtime)
        )
