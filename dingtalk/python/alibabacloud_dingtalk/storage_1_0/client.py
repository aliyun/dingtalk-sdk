# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.storage_1_0 import models as dingtalkstorage__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_folder_with_options(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkstorage__1__0_models.AddFolderRequest,
        headers: dingtalkstorage__1__0_models.AddFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddFolderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='AddFolder',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{parent_id}/folders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddFolderResponse(),
            self.execute(params, req, runtime)
        )

    async def add_folder_with_options_async(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkstorage__1__0_models.AddFolderRequest,
        headers: dingtalkstorage__1__0_models.AddFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddFolderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='AddFolder',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{parent_id}/folders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddFolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_folder(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkstorage__1__0_models.AddFolderRequest,
    ) -> dingtalkstorage__1__0_models.AddFolderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddFolderHeaders()
        return self.add_folder_with_options(space_id, parent_id, request, headers, runtime)

    async def add_folder_async(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkstorage__1__0_models.AddFolderRequest,
    ) -> dingtalkstorage__1__0_models.AddFolderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddFolderHeaders()
        return await self.add_folder_with_options_async(space_id, parent_id, request, headers, runtime)

    def add_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.AddPermissionRequest,
        headers: dingtalkstorage__1__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddPermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='AddPermission',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def add_permission_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.AddPermissionRequest,
        headers: dingtalkstorage__1__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddPermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='AddPermission',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_permission(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.AddPermissionRequest,
    ) -> dingtalkstorage__1__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddPermissionHeaders()
        return self.add_permission_with_options(space_id, dentry_id, request, headers, runtime)

    async def add_permission_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.AddPermissionRequest,
    ) -> dingtalkstorage__1__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddPermissionHeaders()
        return await self.add_permission_with_options_async(space_id, dentry_id, request, headers, runtime)

    def add_space_with_options(
        self,
        request: dingtalkstorage__1__0_models.AddSpaceRequest,
        headers: dingtalkstorage__1__0_models.AddSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddSpaceResponse:
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
            action='AddSpace',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_space_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.AddSpaceRequest,
        headers: dingtalkstorage__1__0_models.AddSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddSpaceResponse:
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
            action='AddSpace',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_space(
        self,
        request: dingtalkstorage__1__0_models.AddSpaceRequest,
    ) -> dingtalkstorage__1__0_models.AddSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddSpaceHeaders()
        return self.add_space_with_options(request, headers, runtime)

    async def add_space_async(
        self,
        request: dingtalkstorage__1__0_models.AddSpaceRequest,
    ) -> dingtalkstorage__1__0_models.AddSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.AddSpaceHeaders()
        return await self.add_space_with_options_async(request, headers, runtime)

    def clear_recycle_bin_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.ClearRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
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
            action='ClearRecycleBin',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ClearRecycleBinResponse(),
            self.execute(params, req, runtime)
        )

    async def clear_recycle_bin_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.ClearRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
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
            action='ClearRecycleBin',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ClearRecycleBinResponse(),
            await self.execute_async(params, req, runtime)
        )

    def clear_recycle_bin(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ClearRecycleBinHeaders()
        return self.clear_recycle_bin_with_options(recycle_bin_id, request, headers, runtime)

    async def clear_recycle_bin_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ClearRecycleBinHeaders()
        return await self.clear_recycle_bin_with_options_async(recycle_bin_id, request, headers, runtime)

    def commit_file_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
        headers: dingtalkstorage__1__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
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
        params = open_api_models.Params(
            action='CommitFile',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CommitFileResponse(),
            self.execute(params, req, runtime)
        )

    async def commit_file_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
        headers: dingtalkstorage__1__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
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
        params = open_api_models.Params(
            action='CommitFile',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CommitFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def commit_file(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CommitFileHeaders()
        return self.commit_file_with_options(space_id, request, headers, runtime)

    async def commit_file_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CommitFileHeaders()
        return await self.commit_file_with_options_async(space_id, request, headers, runtime)

    def copy_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
        headers: dingtalkstorage__1__0_models.CopyDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchCopy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
        headers: dingtalkstorage__1__0_models.CopyDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchCopy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CopyDentriesHeaders()
        return self.copy_dentries_with_options(space_id, request, headers, runtime)

    async def copy_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CopyDentriesHeaders()
        return await self.copy_dentries_with_options_async(space_id, request, headers, runtime)

    def copy_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.CopyDentryRequest,
        headers: dingtalkstorage__1__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.CopyDentryRequest,
        headers: dingtalkstorage__1__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.CopyDentryRequest,
    ) -> dingtalkstorage__1__0_models.CopyDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CopyDentryHeaders()
        return self.copy_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def copy_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.CopyDentryRequest,
    ) -> dingtalkstorage__1__0_models.CopyDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.CopyDentryHeaders()
        return await self.copy_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def delete_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
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
            action='DeleteDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
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
            action='DeleteDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentriesHeaders()
        return self.delete_dentries_with_options(space_id, request, headers, runtime)

    async def delete_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentriesHeaders()
        return await self.delete_dentries_with_options_async(space_id, request, headers, runtime)

    def delete_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.to_recycle_bin):
            query['toRecycleBin'] = request.to_recycle_bin
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
            action='DeleteDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.to_recycle_bin):
            query['toRecycleBin'] = request.to_recycle_bin
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
            action='DeleteDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentryHeaders()
        return self.delete_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def delete_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentryHeaders()
        return await self.delete_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def delete_dentry_app_properties_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.property_names):
            body['propertyNames'] = request.property_names
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
            action='DeleteDentryAppProperties',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dentry_app_properties_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.property_names):
            body['propertyNames'] = request.property_names
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
            action='DeleteDentryAppProperties',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dentry_app_properties(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentryAppPropertiesHeaders()
        return self.delete_dentry_app_properties_with_options(space_id, dentry_id, request, headers, runtime)

    async def delete_dentry_app_properties_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesRequest,
    ) -> dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteDentryAppPropertiesHeaders()
        return await self.delete_dentry_app_properties_with_options_async(space_id, dentry_id, request, headers, runtime)

    def delete_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeletePermissionRequest,
        headers: dingtalkstorage__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeletePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='DeletePermission',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeletePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_permission_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeletePermissionRequest,
        headers: dingtalkstorage__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeletePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='DeletePermission',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeletePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_permission(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeletePermissionRequest,
    ) -> dingtalkstorage__1__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeletePermissionHeaders()
        return self.delete_permission_with_options(space_id, dentry_id, request, headers, runtime)

    async def delete_permission_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeletePermissionRequest,
    ) -> dingtalkstorage__1__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeletePermissionHeaders()
        return await self.delete_permission_with_options_async(space_id, dentry_id, request, headers, runtime)

    def delete_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemResponse:
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
            action='DeleteRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_recycle_item_with_options_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemResponse:
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
            action='DeleteRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_recycle_item(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteRecycleItemHeaders()
        return self.delete_recycle_item_with_options(recycle_bin_id, recycle_item_id, request, headers, runtime)

    async def delete_recycle_item_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteRecycleItemHeaders()
        return await self.delete_recycle_item_with_options_async(recycle_bin_id, recycle_item_id, request, headers, runtime)

    def delete_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.recycle_item_ids):
            body['recycleItemIds'] = request.recycle_item_ids
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
            action='DeleteRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.recycle_item_ids):
            body['recycleItemIds'] = request.recycle_item_ids
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
            action='DeleteRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_recycle_items(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders()
        return self.delete_recycle_items_with_options(recycle_bin_id, request, headers, runtime)

    async def delete_recycle_items_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders()
        return await self.delete_recycle_items_with_options_async(recycle_bin_id, request, headers, runtime)

    def get_current_app_with_options(
        self,
        request: dingtalkstorage__1__0_models.GetCurrentAppRequest,
        headers: dingtalkstorage__1__0_models.GetCurrentAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetCurrentAppResponse:
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
            action='GetCurrentApp',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/currentApps/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetCurrentAppResponse(),
            self.execute(params, req, runtime)
        )

    async def get_current_app_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.GetCurrentAppRequest,
        headers: dingtalkstorage__1__0_models.GetCurrentAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetCurrentAppResponse:
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
            action='GetCurrentApp',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/currentApps/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetCurrentAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_current_app(
        self,
        request: dingtalkstorage__1__0_models.GetCurrentAppRequest,
    ) -> dingtalkstorage__1__0_models.GetCurrentAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetCurrentAppHeaders()
        return self.get_current_app_with_options(request, headers, runtime)

    async def get_current_app_async(
        self,
        request: dingtalkstorage__1__0_models.GetCurrentAppRequest,
    ) -> dingtalkstorage__1__0_models.GetCurrentAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetCurrentAppHeaders()
        return await self.get_current_app_with_options_async(request, headers, runtime)

    def get_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentriesRequest,
        headers: dingtalkstorage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentriesRequest,
        headers: dingtalkstorage__1__0_models.GetDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentriesRequest,
    ) -> dingtalkstorage__1__0_models.GetDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentriesHeaders()
        return self.get_dentries_with_options(space_id, request, headers, runtime)

    async def get_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentriesRequest,
    ) -> dingtalkstorage__1__0_models.GetDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentriesHeaders()
        return await self.get_dentries_with_options_async(space_id, request, headers, runtime)

    def get_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryRequest,
        headers: dingtalkstorage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryRequest,
        headers: dingtalkstorage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryHeaders()
        return self.get_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryHeaders()
        return await self.get_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_dentry_open_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.GetDentryOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryOpenInfoResponse:
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
            action='GetDentryOpenInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryOpenInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_open_info_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.GetDentryOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryOpenInfoResponse:
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
            action='GetDentryOpenInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryOpenInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry_open_info(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryOpenInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryOpenInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryOpenInfoHeaders()
        return self.get_dentry_open_info_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_dentry_open_info_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryOpenInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryOpenInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryOpenInfoHeaders()
        return await self.get_dentry_open_info_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_dentry_thumbnails_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalkstorage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryThumbnailsResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/thumbnails/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryThumbnailsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_thumbnails_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentryThumbnailsRequest,
        headers: dingtalkstorage__1__0_models.GetDentryThumbnailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryThumbnailsResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/thumbnails/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetDentryThumbnailsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry_thumbnails(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryThumbnailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryThumbnailsHeaders()
        return self.get_dentry_thumbnails_with_options(space_id, request, headers, runtime)

    async def get_dentry_thumbnails_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetDentryThumbnailsRequest,
    ) -> dingtalkstorage__1__0_models.GetDentryThumbnailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetDentryThumbnailsHeaders()
        return await self.get_dentry_thumbnails_with_options_async(space_id, request, headers, runtime)

    def get_file_download_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileDownloadInfoResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileDownloadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_download_info_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileDownloadInfoResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileDownloadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_download_info(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetFileDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetFileDownloadInfoHeaders()
        return self.get_file_download_info_with_options(space_id, dentry_id, request, headers, runtime)

    async def get_file_download_info_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetFileDownloadInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetFileDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetFileDownloadInfoHeaders()
        return await self.get_file_download_info_with_options_async(space_id, dentry_id, request, headers, runtime)

    def get_file_upload_info_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.multipart):
            body['multipart'] = request.multipart
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
        params = open_api_models.Params(
            action='GetFileUploadInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileUploadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_upload_info_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.multipart):
            body['multipart'] = request.multipart
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
        params = open_api_models.Params(
            action='GetFileUploadInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileUploadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_upload_info(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetFileUploadInfoHeaders()
        return self.get_file_upload_info_with_options(space_id, request, headers, runtime)

    async def get_file_upload_info_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetFileUploadInfoHeaders()
        return await self.get_file_upload_info_with_options_async(space_id, request, headers, runtime)

    def get_multipart_file_upload_infos_with_options(
        self,
        request: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosRequest,
        headers: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.part_numbers):
            body['partNumbers'] = request.part_numbers
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
        params = open_api_models.Params(
            action='GetMultipartFileUploadInfos',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/files/multiPartUploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse(),
            self.execute(params, req, runtime)
        )

    async def get_multipart_file_upload_infos_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosRequest,
        headers: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.part_numbers):
            body['partNumbers'] = request.part_numbers
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
        params = open_api_models.Params(
            action='GetMultipartFileUploadInfos',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/files/multiPartUploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_multipart_file_upload_infos(
        self,
        request: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosRequest,
    ) -> dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetMultipartFileUploadInfosHeaders()
        return self.get_multipart_file_upload_infos_with_options(request, headers, runtime)

    async def get_multipart_file_upload_infos_async(
        self,
        request: dingtalkstorage__1__0_models.GetMultipartFileUploadInfosRequest,
    ) -> dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetMultipartFileUploadInfosHeaders()
        return await self.get_multipart_file_upload_infos_with_options_async(request, headers, runtime)

    def get_org_with_options(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
        headers: dingtalkstorage__1__0_models.GetOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
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
            action='GetOrg',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/orgs/{corp_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def get_org_with_options_async(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
        headers: dingtalkstorage__1__0_models.GetOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
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
            action='GetOrg',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/orgs/{corp_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_org(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetOrgHeaders()
        return self.get_org_with_options(corp_id, request, headers, runtime)

    async def get_org_async(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetOrgHeaders()
        return await self.get_org_with_options_async(corp_id, request, headers, runtime)

    def get_recycle_bin_with_options(
        self,
        request: dingtalkstorage__1__0_models.GetRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.GetRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetRecycleBinResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.recycle_bin_scope):
            query['recycleBinScope'] = request.recycle_bin_scope
        if not UtilClient.is_unset(request.scope_id):
            query['scopeId'] = request.scope_id
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
            action='GetRecycleBin',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleBinResponse(),
            self.execute(params, req, runtime)
        )

    async def get_recycle_bin_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.GetRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.GetRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetRecycleBinResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.recycle_bin_scope):
            query['recycleBinScope'] = request.recycle_bin_scope
        if not UtilClient.is_unset(request.scope_id):
            query['scopeId'] = request.scope_id
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
            action='GetRecycleBin',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleBinResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_recycle_bin(
        self,
        request: dingtalkstorage__1__0_models.GetRecycleBinRequest,
    ) -> dingtalkstorage__1__0_models.GetRecycleBinResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetRecycleBinHeaders()
        return self.get_recycle_bin_with_options(request, headers, runtime)

    async def get_recycle_bin_async(
        self,
        request: dingtalkstorage__1__0_models.GetRecycleBinRequest,
    ) -> dingtalkstorage__1__0_models.GetRecycleBinResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetRecycleBinHeaders()
        return await self.get_recycle_bin_with_options_async(request, headers, runtime)

    def get_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.GetRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.GetRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetRecycleItemResponse:
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
            action='GetRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleItemResponse(),
            self.execute(params, req, runtime)
        )

    async def get_recycle_item_with_options_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.GetRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.GetRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetRecycleItemResponse:
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
            action='GetRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_recycle_item(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.GetRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.GetRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetRecycleItemHeaders()
        return self.get_recycle_item_with_options(recycle_bin_id, recycle_item_id, request, headers, runtime)

    async def get_recycle_item_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.GetRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.GetRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetRecycleItemHeaders()
        return await self.get_recycle_item_with_options_async(recycle_bin_id, recycle_item_id, request, headers, runtime)

    def get_space_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
        headers: dingtalkstorage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
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
            action='GetSpace',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
        headers: dingtalkstorage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
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
            action='GetSpace',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetSpaceHeaders()
        return self.get_space_with_options(space_id, request, headers, runtime)

    async def get_space_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetSpaceHeaders()
        return await self.get_space_with_options_async(space_id, request, headers, runtime)

    def get_task_with_options(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
        headers: dingtalkstorage__1__0_models.GetTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
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
            action='GetTask',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_with_options_async(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
        headers: dingtalkstorage__1__0_models.GetTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
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
            action='GetTask',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetTaskHeaders()
        return self.get_task_with_options(task_id, request, headers, runtime)

    async def get_task_async(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.GetTaskHeaders()
        return await self.get_task_with_options_async(task_id, request, headers, runtime)

    def init_multipart_file_upload_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
        headers: dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
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
            action='InitMultipartFileUpload',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/multiPartUploadInfos/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.InitMultipartFileUploadResponse(),
            self.execute(params, req, runtime)
        )

    async def init_multipart_file_upload_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
        headers: dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
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
            action='InitMultipartFileUpload',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/files/multiPartUploadInfos/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.InitMultipartFileUploadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_multipart_file_upload(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders()
        return self.init_multipart_file_upload_with_options(space_id, request, headers, runtime)

    async def init_multipart_file_upload_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders()
        return await self.init_multipart_file_upload_with_options_async(space_id, request, headers, runtime)

    def list_all_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListAllDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListAllDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/listAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListAllDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_all_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListAllDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListAllDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListAllDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/listAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListAllDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_all_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalkstorage__1__0_models.ListAllDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListAllDentriesHeaders()
        return self.list_all_dentries_with_options(space_id, request, headers, runtime)

    async def list_all_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListAllDentriesRequest,
    ) -> dingtalkstorage__1__0_models.ListAllDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListAllDentriesHeaders()
        return await self.list_all_dentries_with_options_async(space_id, request, headers, runtime)

    def list_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListDentriesHeaders()
        return self.list_dentries_with_options(space_id, request, headers, runtime)

    async def list_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListDentriesHeaders()
        return await self.list_dentries_with_options_async(space_id, request, headers, runtime)

    def list_dentry_versions_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListDentryVersionsRequest,
        headers: dingtalkstorage__1__0_models.ListDentryVersionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentryVersionsResponse:
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
            action='ListDentryVersions',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentryVersionsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_dentry_versions_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListDentryVersionsRequest,
        headers: dingtalkstorage__1__0_models.ListDentryVersionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentryVersionsResponse:
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
            action='ListDentryVersions',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentryVersionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_dentry_versions(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListDentryVersionsRequest,
    ) -> dingtalkstorage__1__0_models.ListDentryVersionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListDentryVersionsHeaders()
        return self.list_dentry_versions_with_options(space_id, dentry_id, request, headers, runtime)

    async def list_dentry_versions_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListDentryVersionsRequest,
    ) -> dingtalkstorage__1__0_models.ListDentryVersionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListDentryVersionsHeaders()
        return await self.list_dentry_versions_with_options_async(space_id, dentry_id, request, headers, runtime)

    def list_permissions_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListPermissionsRequest,
        headers: dingtalkstorage__1__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListPermissionsResponse:
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
            action='ListPermissions',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListPermissionsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_permissions_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListPermissionsRequest,
        headers: dingtalkstorage__1__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListPermissionsResponse:
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
            action='ListPermissions',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListPermissionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_permissions(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListPermissionsRequest,
    ) -> dingtalkstorage__1__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListPermissionsHeaders()
        return self.list_permissions_with_options(space_id, dentry_id, request, headers, runtime)

    async def list_permissions_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListPermissionsRequest,
    ) -> dingtalkstorage__1__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListPermissionsHeaders()
        return await self.list_permissions_with_options_async(space_id, dentry_id, request, headers, runtime)

    def list_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.ListRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
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
            action='ListRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListRecycleItemsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.ListRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
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
            action='ListRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListRecycleItemsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_recycle_items(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListRecycleItemsHeaders()
        return self.list_recycle_items_with_options(recycle_bin_id, request, headers, runtime)

    async def list_recycle_items_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.ListRecycleItemsHeaders()
        return await self.list_recycle_items_with_options_async(recycle_bin_id, request, headers, runtime)

    def move_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
        headers: dingtalkstorage__1__0_models.MoveDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchMove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def move_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
        headers: dingtalkstorage__1__0_models.MoveDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_ids):
            body['dentryIds'] = request.dentry_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveDentries',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/batchMove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_dentries(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.MoveDentriesHeaders()
        return self.move_dentries_with_options(space_id, request, headers, runtime)

    async def move_dentries_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.MoveDentriesHeaders()
        return await self.move_dentries_with_options_async(space_id, request, headers, runtime)

    def move_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.MoveDentryRequest,
        headers: dingtalkstorage__1__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def move_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.MoveDentryRequest,
        headers: dingtalkstorage__1__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.target_folder_id):
            body['targetFolderId'] = request.target_folder_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.MoveDentryRequest,
    ) -> dingtalkstorage__1__0_models.MoveDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.MoveDentryHeaders()
        return self.move_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def move_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.MoveDentryRequest,
    ) -> dingtalkstorage__1__0_models.MoveDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.MoveDentryHeaders()
        return await self.move_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def register_open_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RegisterOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.RegisterOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RegisterOpenInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_infos):
            body['openInfos'] = request.open_infos
        if not UtilClient.is_unset(request.provider):
            body['provider'] = request.provider
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
            action='RegisterOpenInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RegisterOpenInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def register_open_info_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RegisterOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.RegisterOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RegisterOpenInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_infos):
            body['openInfos'] = request.open_infos
        if not UtilClient.is_unset(request.provider):
            body['provider'] = request.provider
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
            action='RegisterOpenInfo',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RegisterOpenInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_open_info(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RegisterOpenInfoRequest,
    ) -> dingtalkstorage__1__0_models.RegisterOpenInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RegisterOpenInfoHeaders()
        return self.register_open_info_with_options(space_id, dentry_id, request, headers, runtime)

    async def register_open_info_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RegisterOpenInfoRequest,
    ) -> dingtalkstorage__1__0_models.RegisterOpenInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RegisterOpenInfoHeaders()
        return await self.register_open_info_with_options_async(space_id, dentry_id, request, headers, runtime)

    def rename_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RenameDentryRequest,
        headers: dingtalkstorage__1__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RenameDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.new_name):
            body['newName'] = request.new_name
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
            action='RenameDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RenameDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def rename_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RenameDentryRequest,
        headers: dingtalkstorage__1__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RenameDentryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.new_name):
            body['newName'] = request.new_name
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
            action='RenameDentry',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RenameDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rename_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RenameDentryRequest,
    ) -> dingtalkstorage__1__0_models.RenameDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RenameDentryHeaders()
        return self.rename_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def rename_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RenameDentryRequest,
    ) -> dingtalkstorage__1__0_models.RenameDentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RenameDentryHeaders()
        return await self.rename_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def restore_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemResponse:
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
            action='RestoreRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}/restore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemResponse(),
            self.execute(params, req, runtime)
        )

    async def restore_recycle_item_with_options_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemResponse:
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
            action='RestoreRecycleItem',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}/restore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def restore_recycle_item(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RestoreRecycleItemHeaders()
        return self.restore_recycle_item_with_options(recycle_bin_id, recycle_item_id, request, headers, runtime)

    async def restore_recycle_item_async(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemRequest,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RestoreRecycleItemHeaders()
        return await self.restore_recycle_item_with_options_async(recycle_bin_id, recycle_item_id, request, headers, runtime)

    def restore_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.recycle_item_ids):
            body['recycleItemIds'] = request.recycle_item_ids
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
            action='RestoreRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRestore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemsResponse(),
            self.execute(params, req, runtime)
        )

    async def restore_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.recycle_item_ids):
            body['recycleItemIds'] = request.recycle_item_ids
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
            action='RestoreRecycleItems',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRestore',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def restore_recycle_items(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders()
        return self.restore_recycle_items_with_options(recycle_bin_id, request, headers, runtime)

    async def restore_recycle_items_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders()
        return await self.restore_recycle_items_with_options_async(recycle_bin_id, request, headers, runtime)

    def revert_dentry_version_with_options(
        self,
        space_id: str,
        dentry_id: str,
        version: str,
        request: dingtalkstorage__1__0_models.RevertDentryVersionRequest,
        headers: dingtalkstorage__1__0_models.RevertDentryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RevertDentryVersionResponse:
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
            action='RevertDentryVersion',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions/{version}/revert',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RevertDentryVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def revert_dentry_version_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        version: str,
        request: dingtalkstorage__1__0_models.RevertDentryVersionRequest,
        headers: dingtalkstorage__1__0_models.RevertDentryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RevertDentryVersionResponse:
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
            action='RevertDentryVersion',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions/{version}/revert',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RevertDentryVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def revert_dentry_version(
        self,
        space_id: str,
        dentry_id: str,
        version: str,
        request: dingtalkstorage__1__0_models.RevertDentryVersionRequest,
    ) -> dingtalkstorage__1__0_models.RevertDentryVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RevertDentryVersionHeaders()
        return self.revert_dentry_version_with_options(space_id, dentry_id, version, request, headers, runtime)

    async def revert_dentry_version_async(
        self,
        space_id: str,
        dentry_id: str,
        version: str,
        request: dingtalkstorage__1__0_models.RevertDentryVersionRequest,
    ) -> dingtalkstorage__1__0_models.RevertDentryVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.RevertDentryVersionHeaders()
        return await self.revert_dentry_version_with_options_async(space_id, dentry_id, version, request, headers, runtime)

    def subscribe_event_with_options(
        self,
        request: dingtalkstorage__1__0_models.SubscribeEventRequest,
        headers: dingtalkstorage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.SubscribeEventResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/events/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.SubscribeEventResponse(),
            self.execute(params, req, runtime)
        )

    async def subscribe_event_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.SubscribeEventRequest,
        headers: dingtalkstorage__1__0_models.SubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.SubscribeEventResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/events/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.SubscribeEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def subscribe_event(
        self,
        request: dingtalkstorage__1__0_models.SubscribeEventRequest,
    ) -> dingtalkstorage__1__0_models.SubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.SubscribeEventHeaders()
        return self.subscribe_event_with_options(request, headers, runtime)

    async def subscribe_event_async(
        self,
        request: dingtalkstorage__1__0_models.SubscribeEventRequest,
    ) -> dingtalkstorage__1__0_models.SubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.SubscribeEventHeaders()
        return await self.subscribe_event_with_options_async(request, headers, runtime)

    def unsubscribe_event_with_options(
        self,
        request: dingtalkstorage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalkstorage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UnsubscribeEventResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/events/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UnsubscribeEventResponse(),
            self.execute(params, req, runtime)
        )

    async def unsubscribe_event_with_options_async(
        self,
        request: dingtalkstorage__1__0_models.UnsubscribeEventRequest,
        headers: dingtalkstorage__1__0_models.UnsubscribeEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UnsubscribeEventResponse:
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/events/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UnsubscribeEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unsubscribe_event(
        self,
        request: dingtalkstorage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalkstorage__1__0_models.UnsubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UnsubscribeEventHeaders()
        return self.unsubscribe_event_with_options(request, headers, runtime)

    async def unsubscribe_event_async(
        self,
        request: dingtalkstorage__1__0_models.UnsubscribeEventRequest,
    ) -> dingtalkstorage__1__0_models.UnsubscribeEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UnsubscribeEventHeaders()
        return await self.unsubscribe_event_with_options_async(request, headers, runtime)

    def update_dentry_app_properties_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.app_properties):
            body['appProperties'] = request.app_properties
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
            action='UpdateDentryAppProperties',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse(),
            self.execute(params, req, runtime)
        )

    async def update_dentry_app_properties_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.app_properties):
            body['appProperties'] = request.app_properties
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
            action='UpdateDentryAppProperties',
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_dentry_app_properties(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesRequest,
    ) -> dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UpdateDentryAppPropertiesHeaders()
        return self.update_dentry_app_properties_with_options(space_id, dentry_id, request, headers, runtime)

    async def update_dentry_app_properties_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesRequest,
    ) -> dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UpdateDentryAppPropertiesHeaders()
        return await self.update_dentry_app_properties_with_options_async(space_id, dentry_id, request, headers, runtime)

    def update_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdatePermissionRequest,
        headers: dingtalkstorage__1__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdatePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdatePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def update_permission_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdatePermissionRequest,
        headers: dingtalkstorage__1__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdatePermissionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            version='storage_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdatePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_permission(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdatePermissionRequest,
    ) -> dingtalkstorage__1__0_models.UpdatePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UpdatePermissionHeaders()
        return self.update_permission_with_options(space_id, dentry_id, request, headers, runtime)

    async def update_permission_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdatePermissionRequest,
    ) -> dingtalkstorage__1__0_models.UpdatePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__1__0_models.UpdatePermissionHeaders()
        return await self.update_permission_with_options_async(space_id, dentry_id, request, headers, runtime)
