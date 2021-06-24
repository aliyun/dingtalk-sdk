# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkdrive_1_0 import models as dingtalkdrive__1__0_models
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

    def add_file_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
        headers: dingtalkdrive__1__0_models.AddFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddFileResponse(),
            self.do_roarequest('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddFileResponse(),
            await self.do_roarequest_async('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RecoverRecycleFilesResponse(),
            self.do_roarequest('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/recover', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RecoverRecycleFilesResponse(),
            await self.do_roarequest_async('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/recover', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddSpaceResponse(),
            self.do_roarequest('AddSpace', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddSpaceResponse(),
            await self.do_roarequest_async('AddSpace', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteRecycleFilesResponse(),
            self.do_roarequest('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/delete', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteRecycleFilesResponse(),
            await self.do_roarequest_async('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/delete', 'none', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddPermissionResponse(),
            self.do_roarequest('AddPermission', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'none', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.AddPermissionResponse(),
            await self.do_roarequest_async('AddPermission', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            self.do_roarequest('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            await self.do_roarequest_async('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
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

    def list_recycle_files_with_options(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.recycle_type):
            query['recycleType'] = request.recycle_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListRecycleFilesResponse(),
            self.do_roarequest('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/recycleItems', 'json', req, runtime)
        )

    async def list_recycle_files_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.recycle_type):
            query['recycleType'] = request.recycle_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.order_type):
            query['orderType'] = request.order_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListRecycleFilesResponse(),
            await self.do_roarequest_async('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/recycleItems', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RenameFileResponse(),
            self.do_roarequest('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/rename', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.RenameFileResponse(),
            await self.do_roarequest_async('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/rename', 'json', req, runtime)
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

    def list_files_with_options(
        self,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
        headers: dingtalkdrive__1__0_models.ListFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListFilesResponse(),
            self.do_roarequest('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.parent_id):
            query['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListFilesResponse(),
            await self.do_roarequest_async('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ModifyPermissionResponse(),
            self.do_roarequest('ModifyPermission', 'drive_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'none', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ModifyPermissionResponse(),
            await self.do_roarequest_async('ModifyPermission', 'drive_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListPermissionsResponse(),
            self.do_roarequest('ListPermissions', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListPermissionsResponse(),
            await self.do_roarequest_async('ListPermissions', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFileResponse(),
            self.do_roarequest('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/move', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.target_parent_id):
            body['targetParentId'] = request.target_parent_id
        if not UtilClient.is_unset(request.add_conflict_policy):
            body['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.MoveFileResponse(),
            await self.do_roarequest_async('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/move', 'json', req, runtime)
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
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            self.do_roarequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/downloadInfos', 'json', req, runtime)
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
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            await self.do_roarequest_async('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/downloadInfos', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            query['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.md_5):
            query['md5'] = request.md_5
        if not UtilClient.is_unset(request.add_conflict_policy):
            query['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetUploadInfoResponse(),
            self.do_roarequest('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{parent_id}/uploadInfos', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            query['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.md_5):
            query['md5'] = request.md_5
        if not UtilClient.is_unset(request.add_conflict_policy):
            query['addConflictPolicy'] = request.add_conflict_policy
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetUploadInfoResponse(),
            await self.do_roarequest_async('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{parent_id}/uploadInfos', 'json', req, runtime)
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

    def list_spaces_with_options(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.space_type):
            query['spaceType'] = request.space_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListSpacesResponse(),
            self.do_roarequest('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces', 'json', req, runtime)
        )

    async def list_spaces_with_options_async(
        self,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.space_type):
            query['spaceType'] = request.space_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ListSpacesResponse(),
            await self.do_roarequest_async('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/spaces', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeletePermissionResponse(),
            self.do_roarequest('DeletePermission', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions/delete', 'none', req, runtime)
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
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeletePermissionResponse(),
            await self.do_roarequest_async('DeletePermission', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}/permissions/delete', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteSpaceResponse(),
            self.do_roarequest('DeleteSpace', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/spaces/{space_id}', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteSpaceResponse(),
            await self.do_roarequest_async('DeleteSpace', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/spaces/{space_id}', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ClearRecycleFilesResponse(),
            self.do_roarequest('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/clear', 'none', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.ClearRecycleFilesResponse(),
            await self.do_roarequest_async('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/recycleItems/clear', 'none', req, runtime)
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
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.delete_policy):
            query['deletePolicy'] = request.delete_policy
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFileResponse(),
            self.do_roarequest('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        if not UtilClient.is_unset(request.delete_policy):
            query['deletePolicy'] = request.delete_policy
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.DeleteFileResponse(),
            await self.do_roarequest_async('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
        )
