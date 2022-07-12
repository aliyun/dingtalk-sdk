# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_transcribe_brief(
        self,
        task_uuid: str,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders()
        return self.get_transcribe_brief_with_options(task_uuid, headers, runtime)

    async def get_transcribe_brief_async(
        self,
        task_uuid: str,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders()
        return await self.get_transcribe_brief_with_options_async(task_uuid, headers, runtime)

    def get_transcribe_brief_with_options(
        self,
        task_uuid: str,
        headers: dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.GetTranscribeBriefResponse(),
            self.do_roarequest('GetTranscribeBrief', 'transcribe_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/briefInfos', 'json', req, runtime)
        )

    async def get_transcribe_brief_with_options_async(
        self,
        task_uuid: str,
        headers: dingtalktranscribe__1__0_models.GetTranscribeBriefHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.GetTranscribeBriefResponse:
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.GetTranscribeBriefResponse(),
            await self.do_roarequest_async('GetTranscribeBrief', 'transcribe_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/briefInfos', 'json', req, runtime)
        )

    def remove_permission(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.RemovePermissionHeaders()
        return self.remove_permission_with_options(task_uuid, request, headers, runtime)

    async def remove_permission_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.RemovePermissionHeaders()
        return await self.remove_permission_with_options_async(task_uuid, request, headers, runtime)

    def remove_permission_with_options(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
        headers: dingtalktranscribe__1__0_models.RemovePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        UtilClient.validate_model(request)
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
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
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.RemovePermissionResponse(),
            self.do_roarequest('RemovePermission', 'transcribe_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/permissions/remove', 'json', req, runtime)
        )

    async def remove_permission_with_options_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.RemovePermissionRequest,
        headers: dingtalktranscribe__1__0_models.RemovePermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.RemovePermissionResponse:
        UtilClient.validate_model(request)
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
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
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.RemovePermissionResponse(),
            await self.do_roarequest_async('RemovePermission', 'transcribe_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/permissions/remove', 'json', req, runtime)
        )

    def update_permission_for_users(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders()
        return self.update_permission_for_users_with_options(task_uuid, request, headers, runtime)

    async def update_permission_for_users_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders()
        return await self.update_permission_for_users_with_options_async(task_uuid, request, headers, runtime)

    def update_permission_for_users_with_options(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
        headers: dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        UtilClient.validate_model(request)
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
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
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse(),
            self.do_roarequest('UpdatePermissionForUsers', 'transcribe_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/permissions', 'json', req, runtime)
        )

    async def update_permission_for_users_with_options_async(
        self,
        task_uuid: str,
        request: dingtalktranscribe__1__0_models.UpdatePermissionForUsersRequest,
        headers: dingtalktranscribe__1__0_models.UpdatePermissionForUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse:
        UtilClient.validate_model(request)
        task_uuid = OpenApiUtilClient.get_encode_param(task_uuid)
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
        return TeaCore.from_map(
            dingtalktranscribe__1__0_models.UpdatePermissionForUsersResponse(),
            await self.do_roarequest_async('UpdatePermissionForUsers', 'transcribe_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/transcribe/tasks/{task_uuid}/permissions', 'json', req, runtime)
        )
