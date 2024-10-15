# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.transcribe_1_0 import models as dingtalktranscribe__1__0_models
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

    def get_transcribe_brief_with_options(
        self,
        task_uuid: str,
        headers: dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        """
        @summary 获取闪记任务的概要信息
        
        @param headers: GetTranscribeBriefHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranscribeBriefResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetTranscribeBrief',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/briefInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.GetTranscribeBriefResponse(),
            self.execute(params, req, runtime)
        )

    async def get_transcribe_brief_with_options_async(
        self,
        task_uuid: str,
        headers: dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        """
        @summary 获取闪记任务的概要信息
        
        @param headers: GetTranscribeBriefHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranscribeBriefResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetTranscribeBrief',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/briefInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.GetTranscribeBriefResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_transcribe_brief(
        self,
        task_uuid: str,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        """
        @summary 获取闪记任务的概要信息
        
        @return: GetTranscribeBriefResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders()
        return self.get_transcribe_brief_with_options(task_uuid, headers, runtime)

    async def get_transcribe_brief_async(
        self,
        task_uuid: str,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        """
        @summary 获取闪记任务的概要信息
        
        @return: GetTranscribeBriefResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders()
        return await self.get_transcribe_brief_with_options_async(task_uuid, headers, runtime)

    def remove_permission_with_options(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
        headers: dingtalktranscribe__1__0_models.RemovePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        """
        @summary 移除指定用户对闪记任务的权限
        
        @param request: RemovePermissionRequest
        @param headers: RemovePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemovePermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.task_creator):
            body['taskCreator'] = request.task_creator
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='RemovePermission',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/permissions/remove',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.RemovePermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_permission_with_options_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
        headers: dingtalktranscribe__1__0_models.RemovePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        """
        @summary 移除指定用户对闪记任务的权限
        
        @param request: RemovePermissionRequest
        @param headers: RemovePermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemovePermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.task_creator):
            body['taskCreator'] = request.task_creator
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='RemovePermission',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/permissions/remove',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.RemovePermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_permission(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        """
        @summary 移除指定用户对闪记任务的权限
        
        @param request: RemovePermissionRequest
        @return: RemovePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.RemovePermissionHeaders()
        return self.remove_permission_with_options(task_uuid, request, headers, runtime)

    async def remove_permission_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        """
        @summary 移除指定用户对闪记任务的权限
        
        @param request: RemovePermissionRequest
        @return: RemovePermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.RemovePermissionHeaders()
        return await self.remove_permission_with_options_async(task_uuid, request, headers, runtime)

    def update_permission_for_users_with_options(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
        headers: dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        """
        @summary 针对指定的闪记，修改或者授予指定用户权限
        
        @param request: UpdatePermissionForUsersRequest
        @param headers: UpdatePermissionForUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePermissionForUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_uid):
            query['operatorUid'] = request.operator_uid
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.task_creator):
            body['taskCreator'] = request.task_creator
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
            action='UpdatePermissionForUsers',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def update_permission_for_users_with_options_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
        headers: dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        """
        @summary 针对指定的闪记，修改或者授予指定用户权限
        
        @param request: UpdatePermissionForUsersRequest
        @param headers: UpdatePermissionForUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePermissionForUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_uid):
            query['operatorUid'] = request.operator_uid
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.task_creator):
            body['taskCreator'] = request.task_creator
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
            action='UpdatePermissionForUsers',
            version='transcribe_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/transcribe/tasks/{task_uuid}/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_permission_for_users(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        """
        @summary 针对指定的闪记，修改或者授予指定用户权限
        
        @param request: UpdatePermissionForUsersRequest
        @return: UpdatePermissionForUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders()
        return self.update_permission_for_users_with_options(task_uuid, request, headers, runtime)

    async def update_permission_for_users_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        """
        @summary 针对指定的闪记，修改或者授予指定用户权限
        
        @param request: UpdatePermissionForUsersRequest
        @return: UpdatePermissionForUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders()
        return await self.update_permission_for_users_with_options_async(task_uuid, request, headers, runtime)
