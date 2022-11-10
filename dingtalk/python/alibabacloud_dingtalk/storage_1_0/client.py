# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.storage_1_0 import models as dingtalkstorage__1__0_models
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

    def add_folder_with_options(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkstorage__1__0_models.AddFolderRequest,
        headers: dingtalkstorage__1__0_models.AddFolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddFolderResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        parent_id = OpenApiUtilClient.get_encode_param(parent_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddFolderResponse(),
            self.do_roarequest('AddFolder', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{parent_id}/folders', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        parent_id = OpenApiUtilClient.get_encode_param(parent_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddFolderResponse(),
            await self.do_roarequest_async('AddFolder', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{parent_id}/folders', 'json', req, runtime)
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

    def add_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.AddPermissionRequest,
        headers: dingtalkstorage__1__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.AddPermissionResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddPermissionResponse(),
            self.do_roarequest('AddPermission', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddPermissionResponse(),
            await self.do_roarequest_async('AddPermission', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddSpaceResponse(),
            self.do_roarequest('AddSpace', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.AddSpaceResponse(),
            await self.do_roarequest_async('AddSpace', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces', 'json', req, runtime)
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

    def clear_recycle_bin_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.ClearRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ClearRecycleBinResponse(),
            self.do_roarequest('ClearRecycleBin', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/clear', 'json', req, runtime)
        )

    async def clear_recycle_bin_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ClearRecycleBinRequest,
        headers: dingtalkstorage__1__0_models.ClearRecycleBinHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ClearRecycleBinResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ClearRecycleBinResponse(),
            await self.do_roarequest_async('ClearRecycleBin', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/clear', 'json', req, runtime)
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

    def commit_file_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
        headers: dingtalkstorage__1__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CommitFileResponse(),
            self.do_roarequest('CommitFile', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/commit', 'json', req, runtime)
        )

    async def commit_file_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CommitFileRequest,
        headers: dingtalkstorage__1__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CommitFileResponse(),
            await self.do_roarequest_async('CommitFile', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/commit', 'json', req, runtime)
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

    def copy_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
        headers: dingtalkstorage__1__0_models.CopyDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentriesResponse(),
            self.do_roarequest('CopyDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchCopy', 'json', req, runtime)
        )

    async def copy_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.CopyDentriesRequest,
        headers: dingtalkstorage__1__0_models.CopyDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentriesResponse:
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentriesResponse(),
            await self.do_roarequest_async('CopyDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchCopy', 'json', req, runtime)
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

    def copy_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.CopyDentryRequest,
        headers: dingtalkstorage__1__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.CopyDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentryResponse(),
            self.do_roarequest('CopyDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/copy', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.CopyDentryResponse(),
            await self.do_roarequest_async('CopyDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/copy', 'json', req, runtime)
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

    def delete_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
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
            dingtalkstorage__1__0_models.DeleteDentriesResponse(),
            self.do_roarequest('DeleteDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchRemove', 'json', req, runtime)
        )

    async def delete_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentriesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentriesResponse:
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
            dingtalkstorage__1__0_models.DeleteDentriesResponse(),
            await self.do_roarequest_async('DeleteDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchRemove', 'json', req, runtime)
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

    def delete_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryResponse(),
            self.do_roarequest('DeleteDentry', 'storage_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryResponse(),
            await self.do_roarequest_async('DeleteDentry', 'storage_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}', 'json', req, runtime)
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

    def delete_dentry_app_properties_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.DeleteDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse(),
            self.do_roarequest('DeleteDentryAppProperties', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties/remove', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteDentryAppPropertiesResponse(),
            await self.do_roarequest_async('DeleteDentryAppProperties', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties/remove', 'json', req, runtime)
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

    def delete_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.DeletePermissionRequest,
        headers: dingtalkstorage__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeletePermissionResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeletePermissionResponse(),
            self.do_roarequest('DeletePermission', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/remove', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeletePermissionResponse(),
            await self.do_roarequest_async('DeletePermission', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/remove', 'json', req, runtime)
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

    def delete_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemResponse(),
            self.do_roarequest('DeleteRecycleItem', 'storage_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}', 'json', req, runtime)
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
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemResponse(),
            await self.do_roarequest_async('DeleteRecycleItem', 'storage_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}', 'json', req, runtime)
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

    def delete_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemsResponse(),
            self.do_roarequest('DeleteRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRemove', 'json', req, runtime)
        )

    async def delete_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.DeleteRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.DeleteRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.DeleteRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.DeleteRecycleItemsResponse(),
            await self.do_roarequest_async('DeleteRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRemove', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetCurrentAppResponse(),
            self.do_roarequest('GetCurrentApp', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/currentApps/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetCurrentAppResponse(),
            await self.do_roarequest_async('GetCurrentApp', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/currentApps/query', 'json', req, runtime)
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

    def get_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryRequest,
        headers: dingtalkstorage__1__0_models.GetDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryResponse:
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
            dingtalkstorage__1__0_models.GetDentryResponse(),
            self.do_roarequest('GetDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/query', 'json', req, runtime)
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
            dingtalkstorage__1__0_models.GetDentryResponse(),
            await self.do_roarequest_async('GetDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/query', 'json', req, runtime)
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

    def get_dentry_open_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetDentryOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.GetDentryOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetDentryOpenInfoResponse:
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
            dingtalkstorage__1__0_models.GetDentryOpenInfoResponse(),
            self.do_roarequest('GetDentryOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/query', 'json', req, runtime)
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
            dingtalkstorage__1__0_models.GetDentryOpenInfoResponse(),
            await self.do_roarequest_async('GetDentryOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/query', 'json', req, runtime)
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

    def get_file_download_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.GetFileDownloadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileDownloadInfoResponse:
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
            dingtalkstorage__1__0_models.GetFileDownloadInfoResponse(),
            self.do_roarequest('GetFileDownloadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query', 'json', req, runtime)
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
            dingtalkstorage__1__0_models.GetFileDownloadInfoResponse(),
            await self.do_roarequest_async('GetFileDownloadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/downloadInfos/query', 'json', req, runtime)
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

    def get_file_upload_info_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileUploadInfoResponse(),
            self.do_roarequest('GetFileUploadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/uploadInfos/query', 'json', req, runtime)
        )

    async def get_file_upload_info_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__1__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetFileUploadInfoResponse(),
            await self.do_roarequest_async('GetFileUploadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/uploadInfos/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse(),
            self.do_roarequest('GetMultipartFileUploadInfos', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/files/multiPartUploadInfos/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetMultipartFileUploadInfosResponse(),
            await self.do_roarequest_async('GetMultipartFileUploadInfos', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/files/multiPartUploadInfos/query', 'json', req, runtime)
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

    def get_org_with_options(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
        headers: dingtalkstorage__1__0_models.GetOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
        UtilClient.validate_model(request)
        corp_id = OpenApiUtilClient.get_encode_param(corp_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetOrgResponse(),
            self.do_roarequest('GetOrg', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/orgs/{corp_id}', 'json', req, runtime)
        )

    async def get_org_with_options_async(
        self,
        corp_id: str,
        request: dingtalkstorage__1__0_models.GetOrgRequest,
        headers: dingtalkstorage__1__0_models.GetOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetOrgResponse:
        UtilClient.validate_model(request)
        corp_id = OpenApiUtilClient.get_encode_param(corp_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetOrgResponse(),
            await self.do_roarequest_async('GetOrg', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/orgs/{corp_id}', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleBinResponse(),
            self.do_roarequest('GetRecycleBin', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleBinResponse(),
            await self.do_roarequest_async('GetRecycleBin', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins', 'json', req, runtime)
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

    def get_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.GetRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.GetRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetRecycleItemResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleItemResponse(),
            self.do_roarequest('GetRecycleItem', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}', 'json', req, runtime)
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
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetRecycleItemResponse(),
            await self.do_roarequest_async('GetRecycleItem', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}', 'json', req, runtime)
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

    def get_space_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
        headers: dingtalkstorage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetSpaceResponse(),
            self.do_roarequest('GetSpace', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}', 'json', req, runtime)
        )

    async def get_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.GetSpaceRequest,
        headers: dingtalkstorage__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetSpaceResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetSpaceResponse(),
            await self.do_roarequest_async('GetSpace', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}', 'json', req, runtime)
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

    def get_task_with_options(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
        headers: dingtalkstorage__1__0_models.GetTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetTaskResponse(),
            self.do_roarequest('GetTask', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/tasks/{task_id}', 'json', req, runtime)
        )

    async def get_task_with_options_async(
        self,
        task_id: str,
        request: dingtalkstorage__1__0_models.GetTaskRequest,
        headers: dingtalkstorage__1__0_models.GetTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.GetTaskResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.GetTaskResponse(),
            await self.do_roarequest_async('GetTask', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/tasks/{task_id}', 'json', req, runtime)
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

    def init_multipart_file_upload_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
        headers: dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
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
            dingtalkstorage__1__0_models.InitMultipartFileUploadResponse(),
            self.do_roarequest('InitMultipartFileUpload', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/multiPartUploadInfos/init', 'json', req, runtime)
        )

    async def init_multipart_file_upload_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.InitMultipartFileUploadRequest,
        headers: dingtalkstorage__1__0_models.InitMultipartFileUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.InitMultipartFileUploadResponse:
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
            dingtalkstorage__1__0_models.InitMultipartFileUploadResponse(),
            await self.do_roarequest_async('InitMultipartFileUpload', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/files/multiPartUploadInfos/init', 'json', req, runtime)
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

    def list_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
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
            dingtalkstorage__1__0_models.ListDentriesResponse(),
            self.do_roarequest('ListDentries', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries', 'json', req, runtime)
        )

    async def list_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.ListDentriesRequest,
        headers: dingtalkstorage__1__0_models.ListDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentriesResponse:
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
            dingtalkstorage__1__0_models.ListDentriesResponse(),
            await self.do_roarequest_async('ListDentries', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries', 'json', req, runtime)
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

    def list_dentry_versions_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListDentryVersionsRequest,
        headers: dingtalkstorage__1__0_models.ListDentryVersionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListDentryVersionsResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentryVersionsResponse(),
            self.do_roarequest('ListDentryVersions', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListDentryVersionsResponse(),
            await self.do_roarequest_async('ListDentryVersions', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions', 'json', req, runtime)
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

    def list_permissions_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.ListPermissionsRequest,
        headers: dingtalkstorage__1__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListPermissionsResponse:
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
            dingtalkstorage__1__0_models.ListPermissionsResponse(),
            self.do_roarequest('ListPermissions', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/query', 'json', req, runtime)
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
            dingtalkstorage__1__0_models.ListPermissionsResponse(),
            await self.do_roarequest_async('ListPermissions', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions/query', 'json', req, runtime)
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

    def list_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.ListRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListRecycleItemsResponse(),
            self.do_roarequest('ListRecycleItems', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems', 'json', req, runtime)
        )

    async def list_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.ListRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.ListRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.ListRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.ListRecycleItemsResponse(),
            await self.do_roarequest_async('ListRecycleItems', 'storage_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems', 'json', req, runtime)
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

    def move_dentries_with_options(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
        headers: dingtalkstorage__1__0_models.MoveDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentriesResponse(),
            self.do_roarequest('MoveDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchMove', 'json', req, runtime)
        )

    async def move_dentries_with_options_async(
        self,
        space_id: str,
        request: dingtalkstorage__1__0_models.MoveDentriesRequest,
        headers: dingtalkstorage__1__0_models.MoveDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentriesResponse:
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentriesResponse(),
            await self.do_roarequest_async('MoveDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/batchMove', 'json', req, runtime)
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

    def move_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.MoveDentryRequest,
        headers: dingtalkstorage__1__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.MoveDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentryResponse(),
            self.do_roarequest('MoveDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/move', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.MoveDentryResponse(),
            await self.do_roarequest_async('MoveDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/move', 'json', req, runtime)
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

    def register_open_info_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RegisterOpenInfoRequest,
        headers: dingtalkstorage__1__0_models.RegisterOpenInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RegisterOpenInfoResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RegisterOpenInfoResponse(),
            self.do_roarequest('RegisterOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/register', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RegisterOpenInfoResponse(),
            await self.do_roarequest_async('RegisterOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/openInfos/register', 'json', req, runtime)
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

    def rename_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.RenameDentryRequest,
        headers: dingtalkstorage__1__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RenameDentryResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RenameDentryResponse(),
            self.do_roarequest('RenameDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/rename', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RenameDentryResponse(),
            await self.do_roarequest_async('RenameDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/rename', 'json', req, runtime)
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

    def restore_recycle_item_with_options(
        self,
        recycle_bin_id: str,
        recycle_item_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
            dingtalkstorage__1__0_models.RestoreRecycleItemResponse(),
            self.do_roarequest('RestoreRecycleItem', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}/restore', 'json', req, runtime)
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
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
        recycle_item_id = OpenApiUtilClient.get_encode_param(recycle_item_id)
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
            dingtalkstorage__1__0_models.RestoreRecycleItemResponse(),
            await self.do_roarequest_async('RestoreRecycleItem', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/{recycle_item_id}/restore', 'json', req, runtime)
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

    def restore_recycle_items_with_options(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemsResponse(),
            self.do_roarequest('RestoreRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRestore', 'json', req, runtime)
        )

    async def restore_recycle_items_with_options_async(
        self,
        recycle_bin_id: str,
        request: dingtalkstorage__1__0_models.RestoreRecycleItemsRequest,
        headers: dingtalkstorage__1__0_models.RestoreRecycleItemsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.RestoreRecycleItemsResponse:
        UtilClient.validate_model(request)
        recycle_bin_id = OpenApiUtilClient.get_encode_param(recycle_bin_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RestoreRecycleItemsResponse(),
            await self.do_roarequest_async('RestoreRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/recycleBins/{recycle_bin_id}/recycleItems/batchRestore', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        version = OpenApiUtilClient.get_encode_param(version)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RevertDentryVersionResponse(),
            self.do_roarequest('RevertDentryVersion', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions/{version}/revert', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
        version = OpenApiUtilClient.get_encode_param(version)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.RevertDentryVersionResponse(),
            await self.do_roarequest_async('RevertDentryVersion', 'storage_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/versions/{version}/revert', 'json', req, runtime)
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

    def update_dentry_app_properties_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesRequest,
        headers: dingtalkstorage__1__0_models.UpdateDentryAppPropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse(),
            self.do_roarequest('UpdateDentryAppProperties', 'storage_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdateDentryAppPropertiesResponse(),
            await self.do_roarequest_async('UpdateDentryAppProperties', 'storage_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/appProperties', 'json', req, runtime)
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

    def update_permission_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkstorage__1__0_models.UpdatePermissionRequest,
        headers: dingtalkstorage__1__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__1__0_models.UpdatePermissionResponse:
        UtilClient.validate_model(request)
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdatePermissionResponse(),
            self.do_roarequest('UpdatePermission', 'storage_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions', 'json', req, runtime)
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
        space_id = OpenApiUtilClient.get_encode_param(space_id)
        dentry_id = OpenApiUtilClient.get_encode_param(dentry_id)
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
        return TeaCore.from_map(
            dingtalkstorage__1__0_models.UpdatePermissionResponse(),
            await self.do_roarequest_async('UpdatePermission', 'storage_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/storage/spaces/{space_id}/dentries/{dentry_id}/permissions', 'json', req, runtime)
        )
