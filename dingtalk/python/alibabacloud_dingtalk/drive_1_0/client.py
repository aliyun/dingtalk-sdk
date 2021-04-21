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
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddFileHeaders()
        return self.add_file_with_options(union_id, space_id, request, headers, runtime)

    async def add_file_async(
        self,
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.AddFileRequest,
    ) -> dingtalkdrive__1__0_models.AddFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.AddFileHeaders()
        return await self.add_file_with_options_async(union_id, space_id, request, headers, runtime)

    def add_file_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files', 'json', req, runtime)
        )

    async def add_file_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files', 'json', req, runtime)
        )

    def recover_recycle_files(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders()
        return self.recover_recycle_files_with_options(union_id, request, headers, runtime)

    async def recover_recycle_files_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.RecoverRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.RecoverRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RecoverRecycleFilesHeaders()
        return await self.recover_recycle_files_with_options_async(union_id, request, headers, runtime)

    def recover_recycle_files_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/recover', 'none', req, runtime)
        )

    async def recover_recycle_files_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/recover', 'none', req, runtime)
        )

    def delete_recycle_files(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders()
        return self.delete_recycle_files_with_options(union_id, request, headers, runtime)

    async def delete_recycle_files_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.DeleteRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.DeleteRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteRecycleFilesHeaders()
        return await self.delete_recycle_files_with_options_async(union_id, request, headers, runtime)

    def delete_recycle_files_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/delete', 'none', req, runtime)
        )

    async def delete_recycle_files_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/delete', 'none', req, runtime)
        )

    def get_file_info(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetFileInfoHeaders()
        return self.get_file_info_with_options(union_id, space_id, file_id, headers, runtime)

    async def get_file_info_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetFileInfoHeaders()
        return await self.get_file_info_with_options_async(union_id, space_id, file_id, headers, runtime)

    def get_file_info_with_options(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            self.do_roarequest('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
        )

    async def get_file_info_with_options_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetFileInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetFileInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetFileInfoResponse(),
            await self.do_roarequest_async('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
        )

    def list_recycle_files(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListRecycleFilesHeaders()
        return self.list_recycle_files_with_options(union_id, request, headers, runtime)

    async def list_recycle_files_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListRecycleFilesHeaders()
        return await self.list_recycle_files_with_options_async(union_id, request, headers, runtime)

    def list_recycle_files_with_options(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            self.do_roarequest('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems', 'json', req, runtime)
        )

    async def list_recycle_files_with_options_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ListRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListRecycleFilesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            await self.do_roarequest_async('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems', 'json', req, runtime)
        )

    def rename_file(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RenameFileHeaders()
        return self.rename_file_with_options(union_id, space_id, file_id, request, headers, runtime)

    async def rename_file_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.RenameFileRequest,
    ) -> dingtalkdrive__1__0_models.RenameFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.RenameFileHeaders()
        return await self.rename_file_with_options_async(union_id, space_id, file_id, request, headers, runtime)

    def rename_file_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/rename', 'json', req, runtime)
        )

    async def rename_file_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/rename', 'json', req, runtime)
        )

    def list_files(
        self,
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListFilesHeaders()
        return self.list_files_with_options(union_id, space_id, request, headers, runtime)

    async def list_files_async(
        self,
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListFilesHeaders()
        return await self.list_files_with_options_async(union_id, space_id, request, headers, runtime)

    def list_files_with_options(
        self,
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
        headers: dingtalkdrive__1__0_models.ListFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            self.do_roarequest('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files', 'json', req, runtime)
        )

    async def list_files_with_options_async(
        self,
        union_id: str,
        space_id: str,
        request: dingtalkdrive__1__0_models.ListFilesRequest,
        headers: dingtalkdrive__1__0_models.ListFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListFilesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            await self.do_roarequest_async('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files', 'json', req, runtime)
        )

    def move_file(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFileHeaders()
        return self.move_file_with_options(union_id, space_id, file_id, request, headers, runtime)

    async def move_file_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.MoveFileRequest,
    ) -> dingtalkdrive__1__0_models.MoveFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.MoveFileHeaders()
        return await self.move_file_with_options_async(union_id, space_id, file_id, request, headers, runtime)

    def move_file_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/move', 'json', req, runtime)
        )

    async def move_file_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/move', 'json', req, runtime)
        )

    def get_download_info(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return self.get_download_info_with_options(union_id, space_id, file_id, headers, runtime)

    async def get_download_info_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return await self.get_download_info_with_options_async(union_id, space_id, file_id, headers, runtime)

    def get_download_info_with_options(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            self.do_roarequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/downloadInfos', 'json', req, runtime)
        )

    async def get_download_info_with_options_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            await self.do_roarequest_async('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}/downloadInfos', 'json', req, runtime)
        )

    def get_upload_info(
        self,
        union_id: str,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetUploadInfoHeaders()
        return self.get_upload_info_with_options(union_id, space_id, parent_id, request, headers, runtime)

    async def get_upload_info_async(
        self,
        union_id: str,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetUploadInfoHeaders()
        return await self.get_upload_info_with_options_async(union_id, space_id, parent_id, request, headers, runtime)

    def get_upload_info_with_options(
        self,
        union_id: str,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
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
            self.do_roarequest('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{parent_id}/uploadInfos', 'json', req, runtime)
        )

    async def get_upload_info_with_options_async(
        self,
        union_id: str,
        space_id: str,
        parent_id: str,
        request: dingtalkdrive__1__0_models.GetUploadInfoRequest,
        headers: dingtalkdrive__1__0_models.GetUploadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetUploadInfoResponse:
        UtilClient.validate_model(request)
        query = {}
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
            await self.do_roarequest_async('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{parent_id}/uploadInfos', 'json', req, runtime)
        )

    def list_spaces(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListSpacesHeaders()
        return self.list_spaces_with_options(union_id, request, headers, runtime)

    async def list_spaces_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ListSpacesHeaders()
        return await self.list_spaces_with_options_async(union_id, request, headers, runtime)

    def list_spaces_with_options(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            self.do_roarequest('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces', 'json', req, runtime)
        )

    async def list_spaces_with_options_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ListSpacesRequest,
        headers: dingtalkdrive__1__0_models.ListSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ListSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
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
            await self.do_roarequest_async('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{union_id}/spaces', 'json', req, runtime)
        )

    def clear_recycle_files(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ClearRecycleFilesHeaders()
        return self.clear_recycle_files_with_options(union_id, request, headers, runtime)

    async def clear_recycle_files_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.ClearRecycleFilesHeaders()
        return await self.clear_recycle_files_with_options_async(union_id, request, headers, runtime)

    def clear_recycle_files_with_options(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ClearRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            self.do_roarequest('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/clear', 'none', req, runtime)
        )

    async def clear_recycle_files_with_options_async(
        self,
        union_id: str,
        request: dingtalkdrive__1__0_models.ClearRecycleFilesRequest,
        headers: dingtalkdrive__1__0_models.ClearRecycleFilesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.ClearRecycleFilesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.recycle_type):
            body['recycleType'] = request.recycle_type
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
            await self.do_roarequest_async('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/drive/users/{union_id}/recycleItems/clear', 'none', req, runtime)
        )

    def delete_file(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFileHeaders()
        return self.delete_file_with_options(union_id, space_id, file_id, request, headers, runtime)

    async def delete_file_async(
        self,
        union_id: str,
        space_id: str,
        file_id: str,
        request: dingtalkdrive__1__0_models.DeleteFileRequest,
    ) -> dingtalkdrive__1__0_models.DeleteFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.DeleteFileHeaders()
        return await self.delete_file_with_options_async(union_id, space_id, file_id, request, headers, runtime)

    def delete_file_with_options(
        self,
        union_id: str,
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
            self.do_roarequest('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
        )

    async def delete_file_with_options_async(
        self,
        union_id: str,
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
            await self.do_roarequest_async('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/drive/users/{union_id}/spaces/{space_id}/files/{file_id}', 'json', req, runtime)
        )
