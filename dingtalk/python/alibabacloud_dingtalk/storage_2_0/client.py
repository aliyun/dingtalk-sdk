# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.storage_2_0 import models as dingtalkstorage__2__0_models
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

    def add_permission_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.AddPermissionRequest,
        headers: dingtalkstorage__2__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.AddPermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.AddPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def add_permission_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.AddPermissionRequest,
        headers: dingtalkstorage__2__0_models.AddPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.AddPermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.AddPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_permission(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.AddPermissionRequest,
    ) -> dingtalkstorage__2__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.AddPermissionHeaders()
        return self.add_permission_with_options(dentry_uuid, request, headers, runtime)

    async def add_permission_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.AddPermissionRequest,
    ) -> dingtalkstorage__2__0_models.AddPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.AddPermissionHeaders()
        return await self.add_permission_with_options_async(dentry_uuid, request, headers, runtime)

    def commit_file_with_options(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
        headers: dingtalkstorage__2__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='CommitFile',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.CommitFileResponse(),
            self.execute(params, req, runtime)
        )

    async def commit_file_with_options_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.CommitFileRequest,
        headers: dingtalkstorage__2__0_models.CommitFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.CommitFileResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='CommitFile',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/commit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.CommitFileResponse(),
            await self.execute_async(params, req, runtime)
        )

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

    def delete_permission_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.DeletePermissionRequest,
        headers: dingtalkstorage__2__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.DeletePermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.DeletePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_permission_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.DeletePermissionRequest,
        headers: dingtalkstorage__2__0_models.DeletePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.DeletePermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.DeletePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_permission(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.DeletePermissionRequest,
    ) -> dingtalkstorage__2__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.DeletePermissionHeaders()
        return self.delete_permission_with_options(dentry_uuid, request, headers, runtime)

    async def delete_permission_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.DeletePermissionRequest,
    ) -> dingtalkstorage__2__0_models.DeletePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.DeletePermissionHeaders()
        return await self.delete_permission_with_options_async(dentry_uuid, request, headers, runtime)

    def get_file_upload_info_with_options(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__2__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetFileUploadInfo',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.GetFileUploadInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_file_upload_info_with_options_async(
        self,
        parent_dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetFileUploadInfoRequest,
        headers: dingtalkstorage__2__0_models.GetFileUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetFileUploadInfoResponse:
        UtilClient.validate_model(request)
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
        params = open_api_models.Params(
            action='GetFileUploadInfo',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/files/{parent_dentry_uuid}/uploadInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.GetFileUploadInfoResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_permission_inheritance_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetPermissionInheritanceRequest,
        headers: dingtalkstorage__2__0_models.GetPermissionInheritanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetPermissionInheritanceResponse:
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
            action='GetPermissionInheritance',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/inheritances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.GetPermissionInheritanceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_permission_inheritance_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetPermissionInheritanceRequest,
        headers: dingtalkstorage__2__0_models.GetPermissionInheritanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.GetPermissionInheritanceResponse:
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
            action='GetPermissionInheritance',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/inheritances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.GetPermissionInheritanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_permission_inheritance(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetPermissionInheritanceRequest,
    ) -> dingtalkstorage__2__0_models.GetPermissionInheritanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.GetPermissionInheritanceHeaders()
        return self.get_permission_inheritance_with_options(dentry_uuid, request, headers, runtime)

    async def get_permission_inheritance_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.GetPermissionInheritanceRequest,
    ) -> dingtalkstorage__2__0_models.GetPermissionInheritanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.GetPermissionInheritanceHeaders()
        return await self.get_permission_inheritance_with_options_async(dentry_uuid, request, headers, runtime)

    def list_permissions_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.ListPermissionsRequest,
        headers: dingtalkstorage__2__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ListPermissionsResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ListPermissionsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_permissions_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.ListPermissionsRequest,
        headers: dingtalkstorage__2__0_models.ListPermissionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ListPermissionsResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ListPermissionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_permissions(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.ListPermissionsRequest,
    ) -> dingtalkstorage__2__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ListPermissionsHeaders()
        return self.list_permissions_with_options(dentry_uuid, request, headers, runtime)

    async def list_permissions_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.ListPermissionsRequest,
    ) -> dingtalkstorage__2__0_models.ListPermissionsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ListPermissionsHeaders()
        return await self.list_permissions_with_options_async(dentry_uuid, request, headers, runtime)

    def manager_get_default_hand_over_user_with_options(
        self,
        request: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserRequest,
        headers: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ManagerGetDefaultHandOverUser',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/managementSettings/defaultHandOverUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse(),
            self.execute(params, req, runtime)
        )

    async def manager_get_default_hand_over_user_with_options_async(
        self,
        request: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserRequest,
        headers: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ManagerGetDefaultHandOverUser',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/managementSettings/defaultHandOverUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def manager_get_default_hand_over_user(
        self,
        request: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserRequest,
    ) -> dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserHeaders()
        return self.manager_get_default_hand_over_user_with_options(request, headers, runtime)

    async def manager_get_default_hand_over_user_async(
        self,
        request: dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserRequest,
    ) -> dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ManagerGetDefaultHandOverUserHeaders()
        return await self.manager_get_default_hand_over_user_with_options_async(request, headers, runtime)

    def manager_set_default_hand_over_user_with_options(
        self,
        request: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserRequest,
        headers: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_handover_user_id):
            body['defaultHandoverUserId'] = request.default_handover_user_id
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
            action='ManagerSetDefaultHandOverUser',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/managementSettings/defaultHandOverUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse(),
            self.execute(params, req, runtime)
        )

    async def manager_set_default_hand_over_user_with_options_async(
        self,
        request: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserRequest,
        headers: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_handover_user_id):
            body['defaultHandoverUserId'] = request.default_handover_user_id
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
            action='ManagerSetDefaultHandOverUser',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/managementSettings/defaultHandOverUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def manager_set_default_hand_over_user(
        self,
        request: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserRequest,
    ) -> dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserHeaders()
        return self.manager_set_default_hand_over_user_with_options(request, headers, runtime)

    async def manager_set_default_hand_over_user_async(
        self,
        request: dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserRequest,
    ) -> dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.ManagerSetDefaultHandOverUserHeaders()
        return await self.manager_set_default_hand_over_user_with_options_async(request, headers, runtime)

    def search_dentries_with_options(
        self,
        request: dingtalkstorage__2__0_models.SearchDentriesRequest,
        headers: dingtalkstorage__2__0_models.SearchDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SearchDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='SearchDentries',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/dentries/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SearchDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def search_dentries_with_options_async(
        self,
        request: dingtalkstorage__2__0_models.SearchDentriesRequest,
        headers: dingtalkstorage__2__0_models.SearchDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SearchDentriesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='SearchDentries',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/dentries/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SearchDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_dentries(
        self,
        request: dingtalkstorage__2__0_models.SearchDentriesRequest,
    ) -> dingtalkstorage__2__0_models.SearchDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SearchDentriesHeaders()
        return self.search_dentries_with_options(request, headers, runtime)

    async def search_dentries_async(
        self,
        request: dingtalkstorage__2__0_models.SearchDentriesRequest,
    ) -> dingtalkstorage__2__0_models.SearchDentriesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SearchDentriesHeaders()
        return await self.search_dentries_with_options_async(request, headers, runtime)

    def search_workspaces_with_options(
        self,
        request: dingtalkstorage__2__0_models.SearchWorkspacesRequest,
        headers: dingtalkstorage__2__0_models.SearchWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SearchWorkspacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='SearchWorkspaces',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/workspaces/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SearchWorkspacesResponse(),
            self.execute(params, req, runtime)
        )

    async def search_workspaces_with_options_async(
        self,
        request: dingtalkstorage__2__0_models.SearchWorkspacesRequest,
        headers: dingtalkstorage__2__0_models.SearchWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SearchWorkspacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='SearchWorkspaces',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/workspaces/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SearchWorkspacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_workspaces(
        self,
        request: dingtalkstorage__2__0_models.SearchWorkspacesRequest,
    ) -> dingtalkstorage__2__0_models.SearchWorkspacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SearchWorkspacesHeaders()
        return self.search_workspaces_with_options(request, headers, runtime)

    async def search_workspaces_async(
        self,
        request: dingtalkstorage__2__0_models.SearchWorkspacesRequest,
    ) -> dingtalkstorage__2__0_models.SearchWorkspacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SearchWorkspacesHeaders()
        return await self.search_workspaces_with_options_async(request, headers, runtime)

    def set_permission_inheritance_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.SetPermissionInheritanceRequest,
        headers: dingtalkstorage__2__0_models.SetPermissionInheritanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SetPermissionInheritanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.inheritance):
            body['inheritance'] = request.inheritance
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
            action='SetPermissionInheritance',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/inheritances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SetPermissionInheritanceResponse(),
            self.execute(params, req, runtime)
        )

    async def set_permission_inheritance_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.SetPermissionInheritanceRequest,
        headers: dingtalkstorage__2__0_models.SetPermissionInheritanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.SetPermissionInheritanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.inheritance):
            body['inheritance'] = request.inheritance
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
            action='SetPermissionInheritance',
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions/inheritances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.SetPermissionInheritanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_permission_inheritance(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.SetPermissionInheritanceRequest,
    ) -> dingtalkstorage__2__0_models.SetPermissionInheritanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SetPermissionInheritanceHeaders()
        return self.set_permission_inheritance_with_options(dentry_uuid, request, headers, runtime)

    async def set_permission_inheritance_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.SetPermissionInheritanceRequest,
    ) -> dingtalkstorage__2__0_models.SetPermissionInheritanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.SetPermissionInheritanceHeaders()
        return await self.set_permission_inheritance_with_options_async(dentry_uuid, request, headers, runtime)

    def update_permission_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.UpdatePermissionRequest,
        headers: dingtalkstorage__2__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.UpdatePermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.UpdatePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def update_permission_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.UpdatePermissionRequest,
        headers: dingtalkstorage__2__0_models.UpdatePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkstorage__2__0_models.UpdatePermissionResponse:
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
            version='storage_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/storage/spaces/dentries/{dentry_uuid}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkstorage__2__0_models.UpdatePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_permission(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.UpdatePermissionRequest,
    ) -> dingtalkstorage__2__0_models.UpdatePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.UpdatePermissionHeaders()
        return self.update_permission_with_options(dentry_uuid, request, headers, runtime)

    async def update_permission_async(
        self,
        dentry_uuid: str,
        request: dingtalkstorage__2__0_models.UpdatePermissionRequest,
    ) -> dingtalkstorage__2__0_models.UpdatePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkstorage__2__0_models.UpdatePermissionHeaders()
        return await self.update_permission_with_options_async(dentry_uuid, request, headers, runtime)
