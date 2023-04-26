# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.conference_1_0 import models as dingtalkconference__1__0_models
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

    def close_video_conference_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CloseVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
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
            action='CloseVideoConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CloseVideoConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def close_video_conference_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CloseVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
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
            action='CloseVideoConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CloseVideoConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def close_video_conference(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CloseVideoConferenceHeaders()
        return self.close_video_conference_with_options(conference_id, request, headers, runtime)

    async def close_video_conference_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CloseVideoConferenceHeaders()
        return await self.close_video_conference_with_options_async(conference_id, request, headers, runtime)

    def cohosts_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CohostsRequest,
        headers: dingtalkconference__1__0_models.CohostsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CohostsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='Cohosts',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/coHosts/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CohostsResponse(),
            self.execute(params, req, runtime)
        )

    async def cohosts_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CohostsRequest,
        headers: dingtalkconference__1__0_models.CohostsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CohostsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='Cohosts',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/coHosts/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CohostsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cohosts(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CohostsRequest,
    ) -> dingtalkconference__1__0_models.CohostsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CohostsHeaders()
        return self.cohosts_with_options(conference_id, request, headers, runtime)

    async def cohosts_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CohostsRequest,
    ) -> dingtalkconference__1__0_models.CohostsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CohostsHeaders()
        return await self.cohosts_with_options_async(conference_id, request, headers, runtime)

    def create_video_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.invite_caller):
            body['inviteCaller'] = request.invite_caller
        if not UtilClient.is_unset(request.invite_user_ids):
            body['inviteUserIds'] = request.invite_user_ids
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
            action='CreateVideoConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateVideoConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_video_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.invite_caller):
            body['inviteCaller'] = request.invite_caller
        if not UtilClient.is_unset(request.invite_user_ids):
            body['inviteUserIds'] = request.invite_user_ids
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
            action='CreateVideoConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateVideoConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_video_conference(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateVideoConferenceHeaders()
        return self.create_video_conference_with_options(request, headers, runtime)

    async def create_video_conference_async(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateVideoConferenceHeaders()
        return await self.create_video_conference_with_options_async(request, headers, runtime)

    def focus_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.FocusRequest,
        headers: dingtalkconference__1__0_models.FocusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.FocusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
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
            action='Focus',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/focus',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.FocusResponse(),
            self.execute(params, req, runtime)
        )

    async def focus_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.FocusRequest,
        headers: dingtalkconference__1__0_models.FocusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.FocusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
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
            action='Focus',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/focus',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.FocusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def focus(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.FocusRequest,
    ) -> dingtalkconference__1__0_models.FocusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.FocusHeaders()
        return self.focus_with_options(conference_id, request, headers, runtime)

    async def focus_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.FocusRequest,
    ) -> dingtalkconference__1__0_models.FocusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.FocusHeaders()
        return await self.focus_with_options_async(conference_id, request, headers, runtime)

    def invite_users_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
        headers: dingtalkconference__1__0_models.InviteUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invitee_list):
            body['inviteeList'] = request.invitee_list
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
            action='InviteUsers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/users/invite',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.InviteUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def invite_users_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
        headers: dingtalkconference__1__0_models.InviteUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invitee_list):
            body['inviteeList'] = request.invitee_list
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
            action='InviteUsers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/users/invite',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.InviteUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invite_users(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.InviteUsersHeaders()
        return self.invite_users_with_options(conference_id, request, headers, runtime)

    async def invite_users_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.InviteUsersHeaders()
        return await self.invite_users_with_options_async(conference_id, request, headers, runtime)

    def kick_members_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.KickMembersRequest,
        headers: dingtalkconference__1__0_models.KickMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.KickMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.forbidden_rejoin):
            body['forbiddenRejoin'] = request.forbidden_rejoin
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='KickMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members/kick',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.KickMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def kick_members_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.KickMembersRequest,
        headers: dingtalkconference__1__0_models.KickMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.KickMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.forbidden_rejoin):
            body['forbiddenRejoin'] = request.forbidden_rejoin
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='KickMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members/kick',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.KickMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def kick_members(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.KickMembersRequest,
    ) -> dingtalkconference__1__0_models.KickMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.KickMembersHeaders()
        return self.kick_members_with_options(conference_id, request, headers, runtime)

    async def kick_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.KickMembersRequest,
    ) -> dingtalkconference__1__0_models.KickMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.KickMembersHeaders()
        return await self.kick_members_with_options_async(conference_id, request, headers, runtime)

    def mute_all_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
        headers: dingtalkconference__1__0_models.MuteAllHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.force_mute):
            body['forceMute'] = request.force_mute
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
            action='MuteAll',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/allMembers/mute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.MuteAllResponse(),
            self.execute(params, req, runtime)
        )

    async def mute_all_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
        headers: dingtalkconference__1__0_models.MuteAllHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.force_mute):
            body['forceMute'] = request.force_mute
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
            action='MuteAll',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/allMembers/mute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.MuteAllResponse(),
            await self.execute_async(params, req, runtime)
        )

    def mute_all(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteAllHeaders()
        return self.mute_all_with_options(conference_id, request, headers, runtime)

    async def mute_all_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteAllHeaders()
        return await self.mute_all_with_options_async(conference_id, request, headers, runtime)

    def mute_members_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteMembersRequest,
        headers: dingtalkconference__1__0_models.MuteMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.MuteMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='MuteMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members/mute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.MuteMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def mute_members_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteMembersRequest,
        headers: dingtalkconference__1__0_models.MuteMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.MuteMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.user_list):
            body['userList'] = request.user_list
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
            action='MuteMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members/mute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.MuteMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def mute_members(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteMembersRequest,
    ) -> dingtalkconference__1__0_models.MuteMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteMembersHeaders()
        return self.mute_members_with_options(conference_id, request, headers, runtime)

    async def mute_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteMembersRequest,
    ) -> dingtalkconference__1__0_models.MuteMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteMembersHeaders()
        return await self.mute_members_with_options_async(conference_id, request, headers, runtime)

    def query_cloud_record_text_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordTextRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordTextResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryCloudRecordText',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/getTexts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordTextResponse(),
            self.execute(params, req, runtime)
        )

    async def query_cloud_record_text_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordTextRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordTextResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryCloudRecordText',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/getTexts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_cloud_record_text(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordTextRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordTextResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordTextHeaders()
        return self.query_cloud_record_text_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_text_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordTextRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordTextResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordTextHeaders()
        return await self.query_cloud_record_text_with_options_async(conference_id, request, headers, runtime)

    def query_cloud_record_video_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordVideoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoResponse:
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
            action='QueryCloudRecordVideo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/getVideos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordVideoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_cloud_record_video_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordVideoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoResponse:
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
            action='QueryCloudRecordVideo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/getVideos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordVideoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_cloud_record_video(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoHeaders()
        return self.query_cloud_record_video_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_video_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoHeaders()
        return await self.query_cloud_record_video_with_options_async(conference_id, request, headers, runtime)

    def query_cloud_record_video_play_info_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.region_id):
            query['regionId'] = request.region_id
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
            action='QueryCloudRecordVideoPlayInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/videos/getPlayInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_cloud_record_video_play_info_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoRequest,
        headers: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.region_id):
            query['regionId'] = request.region_id
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
            action='QueryCloudRecordVideoPlayInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/videos/getPlayInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_cloud_record_video_play_info(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders()
        return self.query_cloud_record_video_play_info_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_video_play_info_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders()
        return await self.query_cloud_record_video_play_info_with_options_async(conference_id, request, headers, runtime)

    def query_conference_info_with_options(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryConferenceInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_conference_info_with_options_async(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryConferenceInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_conference_info(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoHeaders()
        return self.query_conference_info_with_options(conference_id, headers, runtime)

    async def query_conference_info_async(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoHeaders()
        return await self.query_conference_info_with_options_async(conference_id, headers, runtime)

    def query_conference_info_batch_with_options(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conference_id_list):
            body['conferenceIdList'] = request.conference_id_list
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
            action='QueryConferenceInfoBatch',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse(),
            self.execute(params, req, runtime)
        )

    async def query_conference_info_batch_with_options_async(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conference_id_list):
            body['conferenceIdList'] = request.conference_id_list
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
            action='QueryConferenceInfoBatch',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_conference_info_batch(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders()
        return self.query_conference_info_batch_with_options(request, headers, runtime)

    async def query_conference_info_batch_async(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders()
        return await self.query_conference_info_batch_with_options_async(request, headers, runtime)

    def query_conference_members_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryConferenceMembersRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceMembersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryConferenceMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_conference_members_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryConferenceMembersRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceMembersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryConferenceMembers',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryConferenceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_conference_members(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryConferenceMembersRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceMembersHeaders()
        return self.query_conference_members_with_options(conference_id, request, headers, runtime)

    async def query_conference_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryConferenceMembersRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceMembersHeaders()
        return await self.query_conference_members_with_options_async(conference_id, request, headers, runtime)

    def start_cloud_record_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
        headers: dingtalkconference__1__0_models.StartCloudRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mode):
            body['mode'] = request.mode
        if not UtilClient.is_unset(request.small_window_position):
            body['smallWindowPosition'] = request.small_window_position
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
            action='StartCloudRecord',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartCloudRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def start_cloud_record_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
        headers: dingtalkconference__1__0_models.StartCloudRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mode):
            body['mode'] = request.mode
        if not UtilClient.is_unset(request.small_window_position):
            body['smallWindowPosition'] = request.small_window_position
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
            action='StartCloudRecord',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartCloudRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_cloud_record(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartCloudRecordHeaders()
        return self.start_cloud_record_with_options(conference_id, request, headers, runtime)

    async def start_cloud_record_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartCloudRecordHeaders()
        return await self.start_cloud_record_with_options_async(conference_id, request, headers, runtime)

    def start_stream_out_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
        headers: dingtalkconference__1__0_models.StartStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mode):
            body['mode'] = request.mode
        if not UtilClient.is_unset(request.need_host_join):
            body['needHostJoin'] = request.need_host_join
        if not UtilClient.is_unset(request.small_window_position):
            body['smallWindowPosition'] = request.small_window_position
        if not UtilClient.is_unset(request.stream_name):
            body['streamName'] = request.stream_name
        if not UtilClient.is_unset(request.stream_url_list):
            body['streamUrlList'] = request.stream_url_list
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
            action='StartStreamOut',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/streamOuts/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartStreamOutResponse(),
            self.execute(params, req, runtime)
        )

    async def start_stream_out_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
        headers: dingtalkconference__1__0_models.StartStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mode):
            body['mode'] = request.mode
        if not UtilClient.is_unset(request.need_host_join):
            body['needHostJoin'] = request.need_host_join
        if not UtilClient.is_unset(request.small_window_position):
            body['smallWindowPosition'] = request.small_window_position
        if not UtilClient.is_unset(request.stream_name):
            body['streamName'] = request.stream_name
        if not UtilClient.is_unset(request.stream_url_list):
            body['streamUrlList'] = request.stream_url_list
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
            action='StartStreamOut',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/streamOuts/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartStreamOutResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_stream_out(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartStreamOutHeaders()
        return self.start_stream_out_with_options(conference_id, request, headers, runtime)

    async def start_stream_out_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartStreamOutHeaders()
        return await self.start_stream_out_with_options_async(conference_id, request, headers, runtime)

    def stop_cloud_record_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopCloudRecordRequest,
        headers: dingtalkconference__1__0_models.StopCloudRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopCloudRecordResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='StopCloudRecord',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopCloudRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def stop_cloud_record_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopCloudRecordRequest,
        headers: dingtalkconference__1__0_models.StopCloudRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopCloudRecordResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='StopCloudRecord',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/cloudRecords/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopCloudRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def stop_cloud_record(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StopCloudRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopCloudRecordHeaders()
        return self.stop_cloud_record_with_options(conference_id, request, headers, runtime)

    async def stop_cloud_record_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StopCloudRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopCloudRecordHeaders()
        return await self.stop_cloud_record_with_options_async(conference_id, request, headers, runtime)

    def stop_stream_out_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
        headers: dingtalkconference__1__0_models.StopStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.stop_all_stream):
            body['stopAllStream'] = request.stop_all_stream
        if not UtilClient.is_unset(request.stream_id):
            body['streamId'] = request.stream_id
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
            action='StopStreamOut',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/streamOuts/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopStreamOutResponse(),
            self.execute(params, req, runtime)
        )

    async def stop_stream_out_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
        headers: dingtalkconference__1__0_models.StopStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.stop_all_stream):
            body['stopAllStream'] = request.stop_all_stream
        if not UtilClient.is_unset(request.stream_id):
            body['streamId'] = request.stream_id
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
            action='StopStreamOut',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/streamOuts/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopStreamOutResponse(),
            await self.execute_async(params, req, runtime)
        )

    def stop_stream_out(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopStreamOutHeaders()
        return self.stop_stream_out_with_options(conference_id, request, headers, runtime)

    async def stop_stream_out_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopStreamOutHeaders()
        return await self.stop_stream_out_with_options_async(conference_id, request, headers, runtime)

    def update_video_conference_ext_info_with_options(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UpdateVideoConferenceExtInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/extInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_video_conference_ext_info_with_options_async(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UpdateVideoConferenceExtInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/extInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_video_conference_ext_info(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders()
        return self.update_video_conference_ext_info_with_options(conference_id, headers, runtime)

    async def update_video_conference_ext_info_async(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders()
        return await self.update_video_conference_ext_info_with_options_async(conference_id, headers, runtime)

    def update_video_conference_setting_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.UpdateVideoConferenceSettingRequest,
        headers: dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.allow_unmute_self):
            body['allowUnmuteSelf'] = request.allow_unmute_self
        if not UtilClient.is_unset(request.auto_transfer_host):
            body['autoTransferHost'] = request.auto_transfer_host
        if not UtilClient.is_unset(request.forbidden_share_screen):
            body['forbiddenShareScreen'] = request.forbidden_share_screen
        if not UtilClient.is_unset(request.lock_conference):
            body['lockConference'] = request.lock_conference
        if not UtilClient.is_unset(request.mute_all):
            body['muteAll'] = request.mute_all
        if not UtilClient.is_unset(request.only_internal_employees_join):
            body['onlyInternalEmployeesJoin'] = request.only_internal_employees_join
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
            action='UpdateVideoConferenceSetting',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_video_conference_setting_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.UpdateVideoConferenceSettingRequest,
        headers: dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.allow_unmute_self):
            body['allowUnmuteSelf'] = request.allow_unmute_self
        if not UtilClient.is_unset(request.auto_transfer_host):
            body['autoTransferHost'] = request.auto_transfer_host
        if not UtilClient.is_unset(request.forbidden_share_screen):
            body['forbiddenShareScreen'] = request.forbidden_share_screen
        if not UtilClient.is_unset(request.lock_conference):
            body['lockConference'] = request.lock_conference
        if not UtilClient.is_unset(request.mute_all):
            body['muteAll'] = request.mute_all
        if not UtilClient.is_unset(request.only_internal_employees_join):
            body['onlyInternalEmployeesJoin'] = request.only_internal_employees_join
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
            action='UpdateVideoConferenceSetting',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_video_conference_setting(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.UpdateVideoConferenceSettingRequest,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders()
        return self.update_video_conference_setting_with_options(conference_id, request, headers, runtime)

    async def update_video_conference_setting_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.UpdateVideoConferenceSettingRequest,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders()
        return await self.update_video_conference_setting_with_options_async(conference_id, request, headers, runtime)
