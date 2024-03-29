# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.impaas_1_0 import models as dingtalkimpaas__1__0_models
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

    def add_group_members_with_options(
        self,
        request: dingtalkimpaas__1__0_models.AddGroupMembersRequest,
        headers: dingtalkimpaas__1__0_models.AddGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddGroupMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/members/batchAdd',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddGroupMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def add_group_members_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.AddGroupMembersRequest,
        headers: dingtalkimpaas__1__0_models.AddGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddGroupMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/members/batchAdd',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddGroupMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_group_members(
        self,
        request: dingtalkimpaas__1__0_models.AddGroupMembersRequest,
    ) -> dingtalkimpaas__1__0_models.AddGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddGroupMembersHeaders()
        return self.add_group_members_with_options(request, headers, runtime)

    async def add_group_members_async(
        self,
        request: dingtalkimpaas__1__0_models.AddGroupMembersRequest,
    ) -> dingtalkimpaas__1__0_models.AddGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddGroupMembersHeaders()
        return await self.add_group_members_with_options_async(request, headers, runtime)

    def add_profile_with_options(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
        headers: dingtalkimpaas__1__0_models.AddProfileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.mobile_number):
            body['mobileNumber'] = request.mobile_number
        if not UtilClient.is_unset(request.nick):
            body['nick'] = request.nick
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
            action='AddProfile',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/users/profiles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddProfileResponse(),
            self.execute(params, req, runtime)
        )

    async def add_profile_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
        headers: dingtalkimpaas__1__0_models.AddProfileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.mobile_number):
            body['mobileNumber'] = request.mobile_number
        if not UtilClient.is_unset(request.nick):
            body['nick'] = request.nick
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
            action='AddProfile',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/users/profiles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddProfileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_profile(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddProfileHeaders()
        return self.add_profile_with_options(request, headers, runtime)

    async def add_profile_async(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddProfileHeaders()
        return await self.add_profile_with_options_async(request, headers, runtime)

    def batch_send_with_options(
        self,
        request: dingtalkimpaas__1__0_models.BatchSendRequest,
        headers: dingtalkimpaas__1__0_models.BatchSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.BatchSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uids):
            body['appUids'] = request.app_uids
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.conversation_ids):
            body['conversationIds'] = request.conversation_ids
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
            action='BatchSend',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.BatchSendResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_send_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.BatchSendRequest,
        headers: dingtalkimpaas__1__0_models.BatchSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.BatchSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uids):
            body['appUids'] = request.app_uids
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.conversation_ids):
            body['conversationIds'] = request.conversation_ids
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
            action='BatchSend',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.BatchSendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_send(
        self,
        request: dingtalkimpaas__1__0_models.BatchSendRequest,
    ) -> dingtalkimpaas__1__0_models.BatchSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.BatchSendHeaders()
        return self.batch_send_with_options(request, headers, runtime)

    async def batch_send_async(
        self,
        request: dingtalkimpaas__1__0_models.BatchSendRequest,
    ) -> dingtalkimpaas__1__0_models.BatchSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.BatchSendHeaders()
        return await self.batch_send_with_options_async(request, headers, runtime)

    def create_group_with_options(
        self,
        request: dingtalkimpaas__1__0_models.CreateGroupRequest,
        headers: dingtalkimpaas__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.creator_uid):
            body['creatorUid'] = request.creator_uid
        if not UtilClient.is_unset(request.icon_media_id):
            body['iconMediaId'] = request.icon_media_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.CreateGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.CreateGroupRequest,
        headers: dingtalkimpaas__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.creator_uid):
            body['creatorUid'] = request.creator_uid
        if not UtilClient.is_unset(request.icon_media_id):
            body['iconMediaId'] = request.icon_media_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.CreateGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group(
        self,
        request: dingtalkimpaas__1__0_models.CreateGroupRequest,
    ) -> dingtalkimpaas__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkimpaas__1__0_models.CreateGroupRequest,
    ) -> dingtalkimpaas__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

    def create_trust_group_with_options(
        self,
        request: dingtalkimpaas__1__0_models.CreateTrustGroupRequest,
        headers: dingtalkimpaas__1__0_models.CreateTrustGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.CreateTrustGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.icon_media_id):
            body['iconMediaId'] = request.icon_media_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        if not UtilClient.is_unset(request.system_msg):
            body['systemMsg'] = request.system_msg
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTrustGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/trusts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.CreateTrustGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_trust_group_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.CreateTrustGroupRequest,
        headers: dingtalkimpaas__1__0_models.CreateTrustGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.CreateTrustGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.icon_media_id):
            body['iconMediaId'] = request.icon_media_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        if not UtilClient.is_unset(request.system_msg):
            body['systemMsg'] = request.system_msg
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTrustGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/trusts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.CreateTrustGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_trust_group(
        self,
        request: dingtalkimpaas__1__0_models.CreateTrustGroupRequest,
    ) -> dingtalkimpaas__1__0_models.CreateTrustGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.CreateTrustGroupHeaders()
        return self.create_trust_group_with_options(request, headers, runtime)

    async def create_trust_group_async(
        self,
        request: dingtalkimpaas__1__0_models.CreateTrustGroupRequest,
    ) -> dingtalkimpaas__1__0_models.CreateTrustGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.CreateTrustGroupHeaders()
        return await self.create_trust_group_with_options_async(request, headers, runtime)

    def dismiss_group_with_options(
        self,
        request: dingtalkimpaas__1__0_models.DismissGroupRequest,
        headers: dingtalkimpaas__1__0_models.DismissGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.DismissGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DismissGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/dismiss',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.DismissGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def dismiss_group_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.DismissGroupRequest,
        headers: dingtalkimpaas__1__0_models.DismissGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.DismissGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DismissGroup',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/dismiss',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.DismissGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def dismiss_group(
        self,
        request: dingtalkimpaas__1__0_models.DismissGroupRequest,
    ) -> dingtalkimpaas__1__0_models.DismissGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.DismissGroupHeaders()
        return self.dismiss_group_with_options(request, headers, runtime)

    async def dismiss_group_async(
        self,
        request: dingtalkimpaas__1__0_models.DismissGroupRequest,
    ) -> dingtalkimpaas__1__0_models.DismissGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.DismissGroupHeaders()
        return await self.dismiss_group_with_options_async(request, headers, runtime)

    def get_conversation_id_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
        headers: dingtalkimpaas__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
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
            action='GetConversationId',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/conversations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetConversationIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conversation_id_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
        headers: dingtalkimpaas__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
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
            action='GetConversationId',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/conversations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetConversationIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conversation_id(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetConversationIdHeaders()
        return self.get_conversation_id_with_options(request, headers, runtime)

    async def get_conversation_id_async(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetConversationIdHeaders()
        return await self.get_conversation_id_with_options_async(request, headers, runtime)

    def get_media_url_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
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
            action='GetMediaUrl',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/medium/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_media_url_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
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
            action='GetMediaUrl',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/medium/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_media_url(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlHeaders()
        return self.get_media_url_with_options(request, headers, runtime)

    async def get_media_url_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlHeaders()
        return await self.get_media_url_with_options_async(request, headers, runtime)

    def get_media_urls_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlsRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_ids):
            body['mediaIds'] = request.media_ids
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
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
            action='GetMediaUrls',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/mediaUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_media_urls_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlsRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_ids):
            body['mediaIds'] = request.media_ids
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
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
            action='GetMediaUrls',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/mediaUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_media_urls(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlsRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlsHeaders()
        return self.get_media_urls_with_options(request, headers, runtime)

    async def get_media_urls_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlsRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlsHeaders()
        return await self.get_media_urls_with_options_async(request, headers, runtime)

    def get_space_file_url_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetSpaceFileUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetSpaceFileUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_id):
            query['fileId'] = request.file_id
        if not UtilClient.is_unset(request.sender_uid):
            query['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.space_id):
            query['spaceId'] = request.space_id
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
            action='GetSpaceFileUrl',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/spaces/files/urls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_file_url_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetSpaceFileUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetSpaceFileUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_id):
            query['fileId'] = request.file_id
        if not UtilClient.is_unset(request.sender_uid):
            query['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.space_id):
            query['spaceId'] = request.space_id
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
            action='GetSpaceFileUrl',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/spaces/files/urls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space_file_url(
        self,
        request: dingtalkimpaas__1__0_models.GetSpaceFileUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetSpaceFileUrlHeaders()
        return self.get_space_file_url_with_options(request, headers, runtime)

    async def get_space_file_url_async(
        self,
        request: dingtalkimpaas__1__0_models.GetSpaceFileUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetSpaceFileUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetSpaceFileUrlHeaders()
        return await self.get_space_file_url_with_options_async(request, headers, runtime)

    def list_group_staff_members_with_options(
        self,
        request: dingtalkimpaas__1__0_models.ListGroupStaffMembersRequest,
        headers: dingtalkimpaas__1__0_models.ListGroupStaffMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
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
            action='ListGroupStaffMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/staffMemers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_group_staff_members_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.ListGroupStaffMembersRequest,
        headers: dingtalkimpaas__1__0_models.ListGroupStaffMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
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
            action='ListGroupStaffMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/staffMemers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_group_staff_members(
        self,
        request: dingtalkimpaas__1__0_models.ListGroupStaffMembersRequest,
    ) -> dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ListGroupStaffMembersHeaders()
        return self.list_group_staff_members_with_options(request, headers, runtime)

    async def list_group_staff_members_async(
        self,
        request: dingtalkimpaas__1__0_models.ListGroupStaffMembersRequest,
    ) -> dingtalkimpaas__1__0_models.ListGroupStaffMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ListGroupStaffMembersHeaders()
        return await self.list_group_staff_members_with_options_async(request, headers, runtime)

    def query_batch_send_result_with_options(
        self,
        request: dingtalkimpaas__1__0_models.QueryBatchSendResultRequest,
        headers: dingtalkimpaas__1__0_models.QueryBatchSendResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.QueryBatchSendResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sender_user_id):
            query['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='QueryBatchSendResult',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/batchSendResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.QueryBatchSendResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_batch_send_result_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.QueryBatchSendResultRequest,
        headers: dingtalkimpaas__1__0_models.QueryBatchSendResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.QueryBatchSendResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sender_user_id):
            query['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='QueryBatchSendResult',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/batchSendResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.QueryBatchSendResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_batch_send_result(
        self,
        request: dingtalkimpaas__1__0_models.QueryBatchSendResultRequest,
    ) -> dingtalkimpaas__1__0_models.QueryBatchSendResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.QueryBatchSendResultHeaders()
        return self.query_batch_send_result_with_options(request, headers, runtime)

    async def query_batch_send_result_async(
        self,
        request: dingtalkimpaas__1__0_models.QueryBatchSendResultRequest,
    ) -> dingtalkimpaas__1__0_models.QueryBatchSendResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.QueryBatchSendResultHeaders()
        return await self.query_batch_send_result_with_options_async(request, headers, runtime)

    def read_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
        headers: dingtalkimpaas__1__0_models.ReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReadMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/read',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ReadMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def read_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
        headers: dingtalkimpaas__1__0_models.ReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReadMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/read',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ReadMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def read_message(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ReadMessageHeaders()
        return self.read_message_with_options(request, headers, runtime)

    async def read_message_async(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ReadMessageHeaders()
        return await self.read_message_with_options_async(request, headers, runtime)

    def recall_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
        headers: dingtalkimpaas__1__0_models.RecallMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RecallMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RecallMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def recall_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
        headers: dingtalkimpaas__1__0_models.RecallMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RecallMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RecallMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def recall_message(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RecallMessageHeaders()
        return self.recall_message_with_options(request, headers, runtime)

    async def recall_message_async(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RecallMessageHeaders()
        return await self.recall_message_with_options_async(request, headers, runtime)

    def remove_group_members_with_options(
        self,
        request: dingtalkimpaas__1__0_models.RemoveGroupMembersRequest,
        headers: dingtalkimpaas__1__0_models.RemoveGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RemoveGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.member_uids):
            body['memberUids'] = request.member_uids
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveGroupMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/members/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RemoveGroupMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_group_members_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.RemoveGroupMembersRequest,
        headers: dingtalkimpaas__1__0_models.RemoveGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RemoveGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.member_uids):
            body['memberUids'] = request.member_uids
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveGroupMembers',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/members/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RemoveGroupMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_group_members(
        self,
        request: dingtalkimpaas__1__0_models.RemoveGroupMembersRequest,
    ) -> dingtalkimpaas__1__0_models.RemoveGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RemoveGroupMembersHeaders()
        return self.remove_group_members_with_options(request, headers, runtime)

    async def remove_group_members_async(
        self,
        request: dingtalkimpaas__1__0_models.RemoveGroupMembersRequest,
    ) -> dingtalkimpaas__1__0_models.RemoveGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RemoveGroupMembersHeaders()
        return await self.remove_group_members_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_message(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)

    def send_robot_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.SendRobotMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendRobotMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendRobotMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_all):
            body['atAll'] = request.at_all
        if not UtilClient.is_unset(request.at_app_uids):
            body['atAppUids'] = request.at_app_uids
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.at_users):
            body['atUsers'] = request.at_users
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.msg_media_id_param_map):
            body['msgMediaIdParamMap'] = request.msg_media_id_param_map
        if not UtilClient.is_unset(request.msg_param_map):
            body['msgParamMap'] = request.msg_param_map
        if not UtilClient.is_unset(request.msg_template_id):
            body['msgTemplateId'] = request.msg_template_id
        if not UtilClient.is_unset(request.receiver_app_uids):
            body['receiverAppUids'] = request.receiver_app_uids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
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
            action='SendRobotMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/robots/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendRobotMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_robot_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.SendRobotMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendRobotMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendRobotMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_all):
            body['atAll'] = request.at_all
        if not UtilClient.is_unset(request.at_app_uids):
            body['atAppUids'] = request.at_app_uids
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.at_users):
            body['atUsers'] = request.at_users
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.msg_media_id_param_map):
            body['msgMediaIdParamMap'] = request.msg_media_id_param_map
        if not UtilClient.is_unset(request.msg_param_map):
            body['msgParamMap'] = request.msg_param_map
        if not UtilClient.is_unset(request.msg_template_id):
            body['msgTemplateId'] = request.msg_template_id
        if not UtilClient.is_unset(request.receiver_app_uids):
            body['receiverAppUids'] = request.receiver_app_uids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
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
            action='SendRobotMessage',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/robots/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendRobotMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_robot_message(
        self,
        request: dingtalkimpaas__1__0_models.SendRobotMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendRobotMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendRobotMessageHeaders()
        return self.send_robot_message_with_options(request, headers, runtime)

    async def send_robot_message_async(
        self,
        request: dingtalkimpaas__1__0_models.SendRobotMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendRobotMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendRobotMessageHeaders()
        return await self.send_robot_message_with_options_async(request, headers, runtime)

    def update_group_name_with_options(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupNameRequest,
        headers: dingtalkimpaas__1__0_models.UpdateGroupNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupName',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UpdateGroupNameResponse(),
            self.execute(params, req, runtime)
        )

    async def update_group_name_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupNameRequest,
        headers: dingtalkimpaas__1__0_models.UpdateGroupNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.operation_source):
            real_headers['operationSource'] = UtilClient.to_jsonstring(headers.operation_source)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupName',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UpdateGroupNameResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_group_name(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupNameRequest,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UpdateGroupNameHeaders()
        return self.update_group_name_with_options(request, headers, runtime)

    async def update_group_name_async(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupNameRequest,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UpdateGroupNameHeaders()
        return await self.update_group_name_with_options_async(request, headers, runtime)

    def update_group_owner_with_options(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupOwnerRequest,
        headers: dingtalkimpaas__1__0_models.UpdateGroupOwnerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.owner_uid):
            body['ownerUid'] = request.owner_uid
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
            action='UpdateGroupOwner',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/owners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse(),
            self.execute(params, req, runtime)
        )

    async def update_group_owner_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupOwnerRequest,
        headers: dingtalkimpaas__1__0_models.UpdateGroupOwnerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.owner_uid):
            body['ownerUid'] = request.owner_uid
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
            action='UpdateGroupOwner',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/groups/owners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_group_owner(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupOwnerRequest,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UpdateGroupOwnerHeaders()
        return self.update_group_owner_with_options(request, headers, runtime)

    async def update_group_owner_async(
        self,
        request: dingtalkimpaas__1__0_models.UpdateGroupOwnerRequest,
    ) -> dingtalkimpaas__1__0_models.UpdateGroupOwnerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UpdateGroupOwnerHeaders()
        return await self.update_group_owner_with_options_async(request, headers, runtime)

    def upload_file_with_options(
        self,
        request: dingtalkimpaas__1__0_models.UploadFileRequest,
        headers: dingtalkimpaas__1__0_models.UploadFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UploadFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.file_url):
            body['fileUrl'] = request.file_url
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
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
            action='UploadFile',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/files/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UploadFileResponse(),
            self.execute(params, req, runtime)
        )

    async def upload_file_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.UploadFileRequest,
        headers: dingtalkimpaas__1__0_models.UploadFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.UploadFileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_type):
            body['fileType'] = request.file_type
        if not UtilClient.is_unset(request.file_url):
            body['fileUrl'] = request.file_url
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
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
            action='UploadFile',
            version='impaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/impaas/interconnections/files/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.UploadFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upload_file(
        self,
        request: dingtalkimpaas__1__0_models.UploadFileRequest,
    ) -> dingtalkimpaas__1__0_models.UploadFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UploadFileHeaders()
        return self.upload_file_with_options(request, headers, runtime)

    async def upload_file_async(
        self,
        request: dingtalkimpaas__1__0_models.UploadFileRequest,
    ) -> dingtalkimpaas__1__0_models.UploadFileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.UploadFileHeaders()
        return await self.upload_file_with_options_async(request, headers, runtime)
