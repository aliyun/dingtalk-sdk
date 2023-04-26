# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.drive_1_0 import models as dingtalkdrive__1__0_models
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

    def add_custom_space_with_options(
        self,
        request: dingtalkdrive__1__0_models.AddCustomSpaceRequest,
        headers: dingtalkdrive__1__0_models.AddCustomSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddCustomSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.permission_mode):
            body['permissionMode'] = request.permission_mode
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
            action='AddCustomSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/customSpaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddCustomSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_custom_space_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.AddCustomSpaceRequest,
        headers: dingtalkdrive__1__0_models.AddCustomSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddCustomSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.permission_mode):
            body['permissionMode'] = request.permission_mode
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
            action='AddCustomSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/customSpaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddCustomSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_custom_space(
        self,
        request: dingtalkdrive__1__0_models.AddCustomSpaceRequest,
    ) -> dingtalkdrive__1__0_models.AddCustomSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddCustomSpaceHeaders()
        return self.add_custom_space_with_options(request, headers, runtime)

    async def add_custom_space_async(
        self,
        request: dingtalkdrive__1__0_models.AddCustomSpaceRequest,
    ) -> dingtalkdrive__1__0_models.AddCustomSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddCustomSpaceHeaders()
        return await self.add_custom_space_with_options_async(request, headers, runtime)

    def add_file_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
        headers: dingtalkdrive__1__0_models.AddFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
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
            action='AddFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddFileResponse(),
            self.execute(params, req, runtime)
        )

    async def add_file_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
        headers: dingtalkdrive__1__0_models.AddFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
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
            action='AddFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_file(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddFileHeaders()
        return self.add_file_with_options(space_id, request, headers, runtime)

    async def add_file_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddFileHeaders()
        return await self.add_file_with_options_async(space_id, request, headers, runtime)

    def add_permission_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.AddPermissionRequest,
        headers: dingtalkdrive__1__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='AddPermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def add_permission_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.AddPermissionRequest,
        headers: dingtalkdrive__1__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='AddPermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_permission(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.AddPermissionRequest,
    ) -> dingtalkdrive__1__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddPermissionHeaders()
        return self.add_permission_with_options(space_id, file_id, request, headers, runtime)

    async def add_permission_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.AddPermissionRequest,
    ) -> dingtalkdrive__1__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddPermissionHeaders()
        return await self.add_permission_with_options_async(space_id, file_id, request, headers, runtime)

    def add_space_with_options(
        self,
        request: dingtalkdrive__1__0_models.AddSpaceRequest,
        headers: dingtalkdrive__1__0_models.AddSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='AddSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_space_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.AddSpaceRequest,
        headers: dingtalkdrive__1__0_models.AddSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='AddSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_space(
        self,
        request: dingtalkdrive__1__0_models.AddSpaceRequest,
    ) -> dingtalkdrive__1__0_models.AddSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddSpaceHeaders()
        return self.add_space_with_options(request, headers, runtime)

    async def add_space_async(
        self,
        request: dingtalkdrive__1__0_models.AddSpaceRequest,
    ) -> dingtalkdrive__1__0_models.AddSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddSpaceHeaders()
        return await self.add_space_with_options_async(request, headers, runtime)

    def clear_recycle_files_with_options(
        self,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ClearRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='ClearRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ClearRecycleFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def clear_recycle_files_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ClearRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='ClearRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ClearRecycleFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def clear_recycle_files(
        self,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ClearRecycleFilesHeaders()
        return self.clear_recycle_files_with_options(request, headers, runtime)

    async def clear_recycle_files_async(
        self,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ClearRecycleFilesHeaders()
        return await self.clear_recycle_files_with_options_async(request, headers, runtime)

    def copy_file_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.CopyFileRequest,
        headers: dingtalkdrive__1__0_models.CopyFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.CopyFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.CopyFileResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_file_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.CopyFileRequest,
        headers: dingtalkdrive__1__0_models.CopyFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.CopyFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='CopyFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.CopyFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_file(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.CopyFileRequest,
    ) -> dingtalkdrive__1__0_models.CopyFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.CopyFileHeaders()
        return self.copy_file_with_options(space_id, file_id, request, headers, runtime)

    async def copy_file_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.CopyFileRequest,
    ) -> dingtalkdrive__1__0_models.CopyFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.CopyFileHeaders()
        return await self.copy_file_with_options_async(space_id, file_id, request, headers, runtime)

    def delete_file_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
        headers: dingtalkdrive__1__0_models.DeleteFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.delete_policy):
            query['deletePolicy'] = request.delete_policy
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
            action='DeleteFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFileResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_file_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
        headers: dingtalkdrive__1__0_models.DeleteFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.delete_policy):
            query['deletePolicy'] = request.delete_policy
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
            action='DeleteFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_file(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFileHeaders()
        return self.delete_file_with_options(space_id, file_id, request, headers, runtime)

    async def delete_file_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFileHeaders()
        return await self.delete_file_with_options_async(space_id, file_id, request, headers, runtime)

    def delete_files_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteFilesRequest,
        headers: dingtalkdrive__1__0_models.DeleteFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_policy):
            body['deletePolicy'] = request.delete_policy
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
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
            action='DeleteFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_files_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteFilesRequest,
        headers: dingtalkdrive__1__0_models.DeleteFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_policy):
            body['deletePolicy'] = request.delete_policy
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
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
            action='DeleteFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_files(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFilesHeaders()
        return self.delete_files_with_options(space_id, request, headers, runtime)

    async def delete_files_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFilesHeaders()
        return await self.delete_files_with_options_async(space_id, request, headers, runtime)

    def delete_permission_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeletePermissionRequest,
        headers: dingtalkdrive__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeletePermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='DeletePermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeletePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_permission_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeletePermissionRequest,
        headers: dingtalkdrive__1__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeletePermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='DeletePermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeletePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_permission(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeletePermissionRequest,
    ) -> dingtalkdrive__1__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeletePermissionHeaders()
        return self.delete_permission_with_options(space_id, file_id, request, headers, runtime)

    async def delete_permission_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeletePermissionRequest,
    ) -> dingtalkdrive__1__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeletePermissionHeaders()
        return await self.delete_permission_with_options_async(space_id, file_id, request, headers, runtime)

    def delete_recycle_files_with_options(
        self,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_item_id_list):
            body['recycleItemIdList'] = request.recycle_item_id_list
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='DeleteRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteRecycleFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_recycle_files_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_item_id_list):
            body['recycleItemIdList'] = request.recycle_item_id_list
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='DeleteRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteRecycleFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_recycle_files(
        self,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders()
        return self.delete_recycle_files_with_options(request, headers, runtime)

    async def delete_recycle_files_async(
        self,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders()
        return await self.delete_recycle_files_with_options_async(request, headers, runtime)

    def delete_space_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteSpaceRequest,
        headers: dingtalkdrive__1__0_models.DeleteSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteSpaceResponse:
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
            action='DeleteSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteSpaceRequest,
        headers: dingtalkdrive__1__0_models.DeleteSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.DeleteSpaceResponse:
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
            action='DeleteSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_space(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteSpaceRequest,
    ) -> dingtalkdrive__1__0_models.DeleteSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteSpaceHeaders()
        return self.delete_space_with_options(space_id, request, headers, runtime)

    async def delete_space_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.DeleteSpaceRequest,
    ) -> dingtalkdrive__1__0_models.DeleteSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteSpaceHeaders()
        return await self.delete_space_with_options_async(space_id, request, headers, runtime)

    def get_async_task_info_with_options(
        self,
        task_id: str,
        request: dingtalkdrive__1__0_models.GetAsyncTaskInfoRequest,
        headers: dingtalkdrive__1__0_models.GetAsyncTaskInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse:
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
            action='GetAsyncTaskInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_async_task_info_with_options_async(
        self,
        task_id: str,
        request: dingtalkdrive__1__0_models.GetAsyncTaskInfoRequest,
        headers: dingtalkdrive__1__0_models.GetAsyncTaskInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse:
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
            action='GetAsyncTaskInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_async_task_info(
        self,
        task_id: str,
        request: dingtalkdrive__1__0_models.GetAsyncTaskInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetAsyncTaskInfoHeaders()
        return self.get_async_task_info_with_options(task_id, request, headers, runtime)

    async def get_async_task_info_async(
        self,
        task_id: str,
        request: dingtalkdrive__1__0_models.GetAsyncTaskInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetAsyncTaskInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetAsyncTaskInfoHeaders()
        return await self.get_async_task_info_with_options_async(task_id, request, headers, runtime)

    def get_download_info_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetDownloadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_internal_resource_url):
            query['withInternalResourceUrl'] = request.with_internal_resource_url
        if not UtilClient.is_unset(request.with_region):
            query['withRegion'] = request.with_region
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
            action='GetDownloadInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/downloadInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_download_info_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetDownloadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_internal_resource_url):
            query['withInternalResourceUrl'] = request.with_internal_resource_url
        if not UtilClient.is_unset(request.with_region):
            query['withRegion'] = request.with_region
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
            action='GetDownloadInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/downloadInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_download_info(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetDownloadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return self.get_download_info_with_options(space_id, file_id, request, headers, runtime)

    async def get_download_info_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetDownloadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return await self.get_download_info_with_options_async(space_id, file_id, request, headers, runtime)

    def get_file_info_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetFileInfoRequest,
        headers: dingtalkdrive__1__0_models.GetFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
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
            action='GetFileInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_info_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetFileInfoRequest,
        headers: dingtalkdrive__1__0_models.GetFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
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
            action='GetFileInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_file_info(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetFileInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetFileInfoHeaders()
        return self.get_file_info_with_options(space_id, file_id, request, headers, runtime)

    async def get_file_info_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetFileInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetFileInfoHeaders()
        return await self.get_file_info_with_options_async(space_id, file_id, request, headers, runtime)

    def get_my_space_info_with_options(
        self,
        request: dingtalkdrive__1__0_models.GetMySpaceInfoRequest,
        headers: dingtalkdrive__1__0_models.GetMySpaceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetMySpaceInfoResponse:
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
            action='GetMySpaceInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/mySpaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetMySpaceInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_my_space_info_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.GetMySpaceInfoRequest,
        headers: dingtalkdrive__1__0_models.GetMySpaceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetMySpaceInfoResponse:
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
            action='GetMySpaceInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/mySpaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetMySpaceInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_my_space_info(
        self,
        request: dingtalkdrive__1__0_models.GetMySpaceInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetMySpaceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetMySpaceInfoHeaders()
        return self.get_my_space_info_with_options(request, headers, runtime)

    async def get_my_space_info_async(
        self,
        request: dingtalkdrive__1__0_models.GetMySpaceInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetMySpaceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetMySpaceInfoHeaders()
        return await self.get_my_space_info_with_options_async(request, headers, runtime)

    def get_preview_info_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPreviewInfoRequest,
        headers: dingtalkdrive__1__0_models.GetPreviewInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetPreviewInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
        if not UtilClient.is_unset(request.watermark):
            query['watermark'] = request.watermark
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
            action='GetPreviewInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/previewInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetPreviewInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_preview_info_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPreviewInfoRequest,
        headers: dingtalkdrive__1__0_models.GetPreviewInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetPreviewInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
        if not UtilClient.is_unset(request.watermark):
            query['watermark'] = request.watermark
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
            action='GetPreviewInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/previewInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetPreviewInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_preview_info(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPreviewInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetPreviewInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetPreviewInfoHeaders()
        return self.get_preview_info_with_options(space_id, file_id, request, headers, runtime)

    async def get_preview_info_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPreviewInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetPreviewInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetPreviewInfoHeaders()
        return await self.get_preview_info_with_options_async(space_id, file_id, request, headers, runtime)

    def get_privilege_info_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPrivilegeInfoRequest,
        headers: dingtalkdrive__1__0_models.GetPrivilegeInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetPrivilegeInfoResponse:
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
            action='GetPrivilegeInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/privileges',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetPrivilegeInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_privilege_info_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPrivilegeInfoRequest,
        headers: dingtalkdrive__1__0_models.GetPrivilegeInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetPrivilegeInfoResponse:
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
            action='GetPrivilegeInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/privileges',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetPrivilegeInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_privilege_info(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPrivilegeInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetPrivilegeInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetPrivilegeInfoHeaders()
        return self.get_privilege_info_with_options(space_id, file_id, request, headers, runtime)

    async def get_privilege_info_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.GetPrivilegeInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetPrivilegeInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetPrivilegeInfoHeaders()
        return await self.get_privilege_info_with_options_async(space_id, file_id, request, headers, runtime)

    def get_quota_infos_with_options(
        self,
        request: dingtalkdrive__1__0_models.GetQuotaInfosRequest,
        headers: dingtalkdrive__1__0_models.GetQuotaInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetQuotaInfosResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.identifiers):
            body['identifiers'] = request.identifiers
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='GetQuotaInfos',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/quotaInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetQuotaInfosResponse(),
            self.execute(params, req, runtime)
        )

    async def get_quota_infos_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.GetQuotaInfosRequest,
        headers: dingtalkdrive__1__0_models.GetQuotaInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetQuotaInfosResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.identifiers):
            body['identifiers'] = request.identifiers
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='GetQuotaInfos',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/quotaInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetQuotaInfosResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_quota_infos(
        self,
        request: dingtalkdrive__1__0_models.GetQuotaInfosRequest,
    ) -> dingtalkdrive__1__0_models.GetQuotaInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetQuotaInfosHeaders()
        return self.get_quota_infos_with_options(request, headers, runtime)

    async def get_quota_infos_async(
        self,
        request: dingtalkdrive__1__0_models.GetQuotaInfosRequest,
    ) -> dingtalkdrive__1__0_models.GetQuotaInfosResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetQuotaInfosHeaders()
        return await self.get_quota_infos_with_options_async(request, headers, runtime)

    def get_upload_info_with_options(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            query['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.caller_region):
            query['callerRegion'] = request.caller_region
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            query['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.md_5):
            query['md5'] = request.md_5
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_internal_end_point):
            query['withInternalEndPoint'] = request.with_internal_end_point
        if not UtilClient.is_unset(request.with_region):
            query['withRegion'] = request.with_region
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
            action='GetUploadInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{parent_id}/uploadInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetUploadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_upload_info_with_options_async(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            query['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.caller_region):
            query['callerRegion'] = request.caller_region
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            query['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.md_5):
            query['md5'] = request.md_5
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_internal_end_point):
            query['withInternalEndPoint'] = request.with_internal_end_point
        if not UtilClient.is_unset(request.with_region):
            query['withRegion'] = request.with_region
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
            action='GetUploadInfo',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{parent_id}/uploadInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetUploadInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_upload_info(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetUploadInfoHeaders()
        return self.get_upload_info_with_options(space_id, parent_id, request, headers, runtime)

    async def get_upload_info_async(
        self,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetUploadInfoHeaders()
        return await self.get_upload_info_with_options_async(space_id, parent_id, request, headers, runtime)

    def grant_privilege_of_custom_space_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceRequest,
        headers: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GrantPrivilegeOfCustomSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/customSpacePrivileges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def grant_privilege_of_custom_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceRequest,
        headers: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GrantPrivilegeOfCustomSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/customSpacePrivileges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def grant_privilege_of_custom_space(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceRequest,
    ) -> dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceHeaders()
        return self.grant_privilege_of_custom_space_with_options(space_id, request, headers, runtime)

    async def grant_privilege_of_custom_space_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceRequest,
    ) -> dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GrantPrivilegeOfCustomSpaceHeaders()
        return await self.grant_privilege_of_custom_space_with_options_async(space_id, request, headers, runtime)

    def info_space_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.InfoSpaceRequest,
        headers: dingtalkdrive__1__0_models.InfoSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.InfoSpaceResponse:
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
            action='InfoSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.InfoSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def info_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.InfoSpaceRequest,
        headers: dingtalkdrive__1__0_models.InfoSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.InfoSpaceResponse:
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
            action='InfoSpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.InfoSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def info_space(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.InfoSpaceRequest,
    ) -> dingtalkdrive__1__0_models.InfoSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.InfoSpaceHeaders()
        return self.info_space_with_options(space_id, request, headers, runtime)

    async def info_space_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.InfoSpaceRequest,
    ) -> dingtalkdrive__1__0_models.InfoSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.InfoSpaceHeaders()
        return await self.info_space_with_options_async(space_id, request, headers, runtime)

    def list_files_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
        headers: dingtalkdrive__1__0_models.ListFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_icon):
            query['withIcon'] = request.with_icon
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
            action='ListFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_files_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
        headers: dingtalkdrive__1__0_models.ListFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.with_icon):
            query['withIcon'] = request.with_icon
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
            action='ListFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_files(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListFilesHeaders()
        return self.list_files_with_options(space_id, request, headers, runtime)

    async def list_files_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListFilesHeaders()
        return await self.list_files_with_options_async(space_id, request, headers, runtime)

    def list_permissions_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ListPermissionsRequest,
        headers: dingtalkdrive__1__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListPermissionsResponse:
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
            action='ListPermissions',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListPermissionsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_permissions_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ListPermissionsRequest,
        headers: dingtalkdrive__1__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListPermissionsResponse:
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
            action='ListPermissions',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListPermissionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_permissions(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ListPermissionsRequest,
    ) -> dingtalkdrive__1__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListPermissionsHeaders()
        return self.list_permissions_with_options(space_id, file_id, request, headers, runtime)

    async def list_permissions_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ListPermissionsRequest,
    ) -> dingtalkdrive__1__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListPermissionsHeaders()
        return await self.list_permissions_with_options_async(space_id, file_id, request, headers, runtime)

    def list_recycle_files_with_options(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        if not UtilClient.is_unset(request.recycle_type):
            query['recycleType'] = request.recycle_type
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
            action='ListRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListRecycleFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_recycle_files_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        if not UtilClient.is_unset(request.recycle_type):
            query['recycleType'] = request.recycle_type
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
            action='ListRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListRecycleFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_recycle_files(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListRecycleFilesHeaders()
        return self.list_recycle_files_with_options(request, headers, runtime)

    async def list_recycle_files_async(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListRecycleFilesHeaders()
        return await self.list_recycle_files_with_options_async(request, headers, runtime)

    def list_spaces_with_options(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.space_type):
            query['spaceType'] = request.space_type
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
            action='ListSpaces',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_spaces_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.space_type):
            query['spaceType'] = request.space_type
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
            action='ListSpaces',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_spaces(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListSpacesHeaders()
        return self.list_spaces_with_options(request, headers, runtime)

    async def list_spaces_async(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListSpacesHeaders()
        return await self.list_spaces_with_options_async(request, headers, runtime)

    def management_buy_quota_with_options(
        self,
        request: dingtalkdrive__1__0_models.ManagementBuyQuotaRequest,
        headers: dingtalkdrive__1__0_models.ManagementBuyQuotaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementBuyQuotaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='ManagementBuyQuota',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/quotas/buy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementBuyQuotaResponse(),
            self.execute(params, req, runtime)
        )

    async def management_buy_quota_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementBuyQuotaRequest,
        headers: dingtalkdrive__1__0_models.ManagementBuyQuotaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementBuyQuotaResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='ManagementBuyQuota',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/quotas/buy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementBuyQuotaResponse(),
            await self.execute_async(params, req, runtime)
        )

    def management_buy_quota(
        self,
        request: dingtalkdrive__1__0_models.ManagementBuyQuotaRequest,
    ) -> dingtalkdrive__1__0_models.ManagementBuyQuotaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementBuyQuotaHeaders()
        return self.management_buy_quota_with_options(request, headers, runtime)

    async def management_buy_quota_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementBuyQuotaRequest,
    ) -> dingtalkdrive__1__0_models.ManagementBuyQuotaResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementBuyQuotaHeaders()
        return await self.management_buy_quota_with_options_async(request, headers, runtime)

    def management_list_spaces_with_options(
        self,
        request: dingtalkdrive__1__0_models.ManagementListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ManagementListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementListSpacesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_ids):
            body['spaceIds'] = request.space_ids
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
            action='ManagementListSpaces',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementListSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def management_list_spaces_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ManagementListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementListSpacesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_ids):
            body['spaceIds'] = request.space_ids
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
            action='ManagementListSpaces',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementListSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def management_list_spaces(
        self,
        request: dingtalkdrive__1__0_models.ManagementListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ManagementListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementListSpacesHeaders()
        return self.management_list_spaces_with_options(request, headers, runtime)

    async def management_list_spaces_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ManagementListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementListSpacesHeaders()
        return await self.management_list_spaces_with_options_async(request, headers, runtime)

    def management_modify_space_with_options(
        self,
        request: dingtalkdrive__1__0_models.ManagementModifySpaceRequest,
        headers: dingtalkdrive__1__0_models.ManagementModifySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementModifySpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.quota):
            body['quota'] = request.quota
        if not UtilClient.is_unset(request.space_ids):
            body['spaceIds'] = request.space_ids
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
            action='ManagementModifySpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementModifySpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def management_modify_space_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementModifySpaceRequest,
        headers: dingtalkdrive__1__0_models.ManagementModifySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ManagementModifySpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.quota):
            body['quota'] = request.quota
        if not UtilClient.is_unset(request.space_ids):
            body['spaceIds'] = request.space_ids
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
            action='ManagementModifySpace',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/managements/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ManagementModifySpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def management_modify_space(
        self,
        request: dingtalkdrive__1__0_models.ManagementModifySpaceRequest,
    ) -> dingtalkdrive__1__0_models.ManagementModifySpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementModifySpaceHeaders()
        return self.management_modify_space_with_options(request, headers, runtime)

    async def management_modify_space_async(
        self,
        request: dingtalkdrive__1__0_models.ManagementModifySpaceRequest,
    ) -> dingtalkdrive__1__0_models.ManagementModifySpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ManagementModifySpaceHeaders()
        return await self.management_modify_space_with_options_async(request, headers, runtime)

    def modify_permission_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ModifyPermissionRequest,
        headers: dingtalkdrive__1__0_models.ModifyPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ModifyPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='ModifyPermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ModifyPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def modify_permission_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ModifyPermissionRequest,
        headers: dingtalkdrive__1__0_models.ModifyPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ModifyPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='ModifyPermission',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ModifyPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def modify_permission(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ModifyPermissionRequest,
    ) -> dingtalkdrive__1__0_models.ModifyPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ModifyPermissionHeaders()
        return self.modify_permission_with_options(space_id, file_id, request, headers, runtime)

    async def modify_permission_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.ModifyPermissionRequest,
    ) -> dingtalkdrive__1__0_models.ModifyPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ModifyPermissionHeaders()
        return await self.modify_permission_with_options_async(space_id, file_id, request, headers, runtime)

    def move_file_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
        headers: dingtalkdrive__1__0_models.MoveFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFileResponse(),
            self.execute(params, req, runtime)
        )

    async def move_file_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
        headers: dingtalkdrive__1__0_models.MoveFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_file(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFileHeaders()
        return self.move_file_with_options(space_id, file_id, request, headers, runtime)

    async def move_file_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFileHeaders()
        return await self.move_file_with_options_async(space_id, file_id, request, headers, runtime)

    def move_files_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.MoveFilesRequest,
        headers: dingtalkdrive__1__0_models.MoveFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.MoveFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/batchMove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def move_files_with_options_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.MoveFilesRequest,
        headers: dingtalkdrive__1__0_models.MoveFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.MoveFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.file_ids):
            body['fileIds'] = request.file_ids
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
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
            action='MoveFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/batchMove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_files(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.MoveFilesRequest,
    ) -> dingtalkdrive__1__0_models.MoveFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFilesHeaders()
        return self.move_files_with_options(space_id, request, headers, runtime)

    async def move_files_async(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.MoveFilesRequest,
    ) -> dingtalkdrive__1__0_models.MoveFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFilesHeaders()
        return await self.move_files_with_options_async(space_id, request, headers, runtime)

    def recover_recycle_files_with_options(
        self,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_item_id_list):
            body['recycleItemIdList'] = request.recycle_item_id_list
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='RecoverRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/recover',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RecoverRecycleFilesResponse(),
            self.execute(params, req, runtime)
        )

    async def recover_recycle_files_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_item_id_list):
            body['recycleItemIdList'] = request.recycle_item_id_list
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            action='RecoverRecycleFiles',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/recycleItems/recover',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RecoverRecycleFilesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def recover_recycle_files(
        self,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders()
        return self.recover_recycle_files_with_options(request, headers, runtime)

    async def recover_recycle_files_async(
        self,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders()
        return await self.recover_recycle_files_with_options_async(request, headers, runtime)

    def rename_file_with_options(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
        headers: dingtalkdrive__1__0_models.RenameFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.new_file_name):
            body['newFileName'] = request.new_file_name
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
            action='RenameFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RenameFileResponse(),
            self.execute(params, req, runtime)
        )

    async def rename_file_with_options_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
        headers: dingtalkdrive__1__0_models.RenameFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.new_file_name):
            body['newFileName'] = request.new_file_name
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
            action='RenameFile',
            version='drive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/drive/spaces/{space_id}/files/{file_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RenameFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rename_file(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RenameFileHeaders()
        return self.rename_file_with_options(space_id, file_id, request, headers, runtime)

    async def rename_file_async(
        self,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RenameFileHeaders()
        return await self.rename_file_with_options_async(space_id, file_id, request, headers, runtime)
