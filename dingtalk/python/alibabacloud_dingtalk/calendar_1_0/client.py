# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.calendar_1_0 import models as dingtalkcalendar__1__0_models
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

    def create_acls(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateAclsRequest,
    ) -> dingtalkcalendar__1__0_models.CreateAclsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateAclsHeaders()
        return self.create_acls_with_options(user_id, calendar_id, request, headers, runtime)

    async def create_acls_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateAclsRequest,
    ) -> dingtalkcalendar__1__0_models.CreateAclsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateAclsHeaders()
        return await self.create_acls_with_options_async(user_id, calendar_id, request, headers, runtime)

    def create_acls_with_options(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateAclsRequest,
        headers: dingtalkcalendar__1__0_models.CreateAclsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateAclsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.privilege):
            body['privilege'] = request.privilege
        if not UtilClient.is_unset(request.send_msg):
            body['sendMsg'] = request.send_msg
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
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
            dingtalkcalendar__1__0_models.CreateAclsResponse(),
            self.do_roarequest('CreateAcls', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls', 'json', req, runtime)
        )

    async def create_acls_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateAclsRequest,
        headers: dingtalkcalendar__1__0_models.CreateAclsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateAclsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.privilege):
            body['privilege'] = request.privilege
        if not UtilClient.is_unset(request.send_msg):
            body['sendMsg'] = request.send_msg
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
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
            dingtalkcalendar__1__0_models.CreateAclsResponse(),
            await self.do_roarequest_async('CreateAcls', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls', 'json', req, runtime)
        )

    def list_acls(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.ListAclsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListAclsHeaders()
        return self.list_acls_with_options(user_id, calendar_id, headers, runtime)

    async def list_acls_async(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.ListAclsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListAclsHeaders()
        return await self.list_acls_with_options_async(user_id, calendar_id, headers, runtime)

    def list_acls_with_options(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.ListAclsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListAclsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ListAclsResponse(),
            self.do_roarequest('ListAcls', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls', 'json', req, runtime)
        )

    async def list_acls_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.ListAclsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListAclsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ListAclsResponse(),
            await self.do_roarequest_async('ListAcls', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls', 'json', req, runtime)
        )

    def respond_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RespondEventRequest,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RespondEventHeaders()
        return self.respond_event_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def respond_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RespondEventRequest,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RespondEventHeaders()
        return await self.respond_event_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def respond_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RespondEventRequest,
        headers: dingtalkcalendar__1__0_models.RespondEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.response_status):
            body['responseStatus'] = request.response_status
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
            dingtalkcalendar__1__0_models.RespondEventResponse(),
            self.do_roarequest('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/respond', 'none', req, runtime)
        )

    async def respond_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RespondEventRequest,
        headers: dingtalkcalendar__1__0_models.RespondEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.response_status):
            body['responseStatus'] = request.response_status
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
            dingtalkcalendar__1__0_models.RespondEventResponse(),
            await self.do_roarequest_async('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/respond', 'none', req, runtime)
        )

    def generate_caldav_account(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GenerateCaldavAccountRequest,
    ) -> dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GenerateCaldavAccountHeaders()
        return self.generate_caldav_account_with_options(user_id, request, headers, runtime)

    async def generate_caldav_account_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GenerateCaldavAccountRequest,
    ) -> dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GenerateCaldavAccountHeaders()
        return await self.generate_caldav_account_with_options_async(user_id, request, headers, runtime)

    def generate_caldav_account_with_options(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GenerateCaldavAccountRequest,
        headers: dingtalkcalendar__1__0_models.GenerateCaldavAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device):
            body['device'] = request.device
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_uid):
            real_headers['dingUid'] = headers.ding_uid
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse(),
            self.do_roarequest('GenerateCaldavAccount', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/caldavAccounts', 'json', req, runtime)
        )

    async def generate_caldav_account_with_options_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GenerateCaldavAccountRequest,
        headers: dingtalkcalendar__1__0_models.GenerateCaldavAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device):
            body['device'] = request.device
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_uid):
            real_headers['dingUid'] = headers.ding_uid
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.GenerateCaldavAccountResponse(),
            await self.do_roarequest_async('GenerateCaldavAccount', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/caldavAccounts', 'json', req, runtime)
        )

    def get_schedule(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GetScheduleRequest,
    ) -> dingtalkcalendar__1__0_models.GetScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetScheduleHeaders()
        return self.get_schedule_with_options(user_id, request, headers, runtime)

    async def get_schedule_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GetScheduleRequest,
    ) -> dingtalkcalendar__1__0_models.GetScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetScheduleHeaders()
        return await self.get_schedule_with_options_async(user_id, request, headers, runtime)

    def get_schedule_with_options(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GetScheduleRequest,
        headers: dingtalkcalendar__1__0_models.GetScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetScheduleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
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
            dingtalkcalendar__1__0_models.GetScheduleResponse(),
            self.do_roarequest('GetSchedule', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/querySchedule', 'json', req, runtime)
        )

    async def get_schedule_with_options_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.GetScheduleRequest,
        headers: dingtalkcalendar__1__0_models.GetScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetScheduleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
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
            dingtalkcalendar__1__0_models.GetScheduleResponse(),
            await self.do_roarequest_async('GetSchedule', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/querySchedule', 'json', req, runtime)
        )

    def convert_legacy_event_id(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.ConvertLegacyEventIdRequest,
    ) -> dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ConvertLegacyEventIdHeaders()
        return self.convert_legacy_event_id_with_options(user_id, request, headers, runtime)

    async def convert_legacy_event_id_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.ConvertLegacyEventIdRequest,
    ) -> dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ConvertLegacyEventIdHeaders()
        return await self.convert_legacy_event_id_with_options_async(user_id, request, headers, runtime)

    def convert_legacy_event_id_with_options(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.ConvertLegacyEventIdRequest,
        headers: dingtalkcalendar__1__0_models.ConvertLegacyEventIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.legacy_event_ids):
            body['legacyEventIds'] = request.legacy_event_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_uid):
            real_headers['dingUid'] = headers.ding_uid
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse(),
            self.do_roarequest('ConvertLegacyEventId', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/legacyEventIds/convert', 'json', req, runtime)
        )

    async def convert_legacy_event_id_with_options_async(
        self,
        user_id: str,
        request: dingtalkcalendar__1__0_models.ConvertLegacyEventIdRequest,
        headers: dingtalkcalendar__1__0_models.ConvertLegacyEventIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.legacy_event_ids):
            body['legacyEventIds'] = request.legacy_event_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = headers.ding_org_id
        if not UtilClient.is_unset(headers.ding_uid):
            real_headers['dingUid'] = headers.ding_uid
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = headers.ding_access_token_type
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ConvertLegacyEventIdResponse(),
            await self.do_roarequest_async('ConvertLegacyEventId', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/legacyEventIds/convert', 'json', req, runtime)
        )

    def remove_attendee(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RemoveAttendeeRequest,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RemoveAttendeeHeaders()
        return self.remove_attendee_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def remove_attendee_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RemoveAttendeeRequest,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RemoveAttendeeHeaders()
        return await self.remove_attendee_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def remove_attendee_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RemoveAttendeeRequest,
        headers: dingtalkcalendar__1__0_models.RemoveAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attendees_to_remove):
            body['attendeesToRemove'] = request.attendees_to_remove
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
            dingtalkcalendar__1__0_models.RemoveAttendeeResponse(),
            self.do_roarequest('RemoveAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees/batchRemove', 'none', req, runtime)
        )

    async def remove_attendee_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.RemoveAttendeeRequest,
        headers: dingtalkcalendar__1__0_models.RemoveAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attendees_to_remove):
            body['attendeesToRemove'] = request.attendees_to_remove
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
            dingtalkcalendar__1__0_models.RemoveAttendeeResponse(),
            await self.do_roarequest_async('RemoveAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees/batchRemove', 'none', req, runtime)
        )

    def add_attendee(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.AddAttendeeRequest,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.AddAttendeeHeaders()
        return self.add_attendee_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def add_attendee_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.AddAttendeeRequest,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.AddAttendeeHeaders()
        return await self.add_attendee_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def add_attendee_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.AddAttendeeRequest,
        headers: dingtalkcalendar__1__0_models.AddAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attendees_to_add):
            body['attendeesToAdd'] = request.attendees_to_add
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
            dingtalkcalendar__1__0_models.AddAttendeeResponse(),
            self.do_roarequest('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'none', req, runtime)
        )

    async def add_attendee_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.AddAttendeeRequest,
        headers: dingtalkcalendar__1__0_models.AddAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attendees_to_add):
            body['attendeesToAdd'] = request.attendees_to_add
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
            dingtalkcalendar__1__0_models.AddAttendeeResponse(),
            await self.do_roarequest_async('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'none', req, runtime)
        )

    def create_event(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateEventRequest,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateEventHeaders()
        return self.create_event_with_options(user_id, calendar_id, request, headers, runtime)

    async def create_event_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateEventRequest,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateEventHeaders()
        return await self.create_event_with_options_async(user_id, calendar_id, request, headers, runtime)

    def create_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateEventRequest,
        headers: dingtalkcalendar__1__0_models.CreateEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.is_all_day):
            body['isAllDay'] = request.is_all_day
        if not UtilClient.is_unset(request.recurrence):
            body['recurrence'] = request.recurrence
        if not UtilClient.is_unset(request.attendees):
            body['attendees'] = request.attendees
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.reminders):
            body['reminders'] = request.reminders
        if not UtilClient.is_unset(request.online_meeting_info):
            body['onlineMeetingInfo'] = request.online_meeting_info
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
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
            dingtalkcalendar__1__0_models.CreateEventResponse(),
            self.do_roarequest('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    async def create_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.CreateEventRequest,
        headers: dingtalkcalendar__1__0_models.CreateEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.is_all_day):
            body['isAllDay'] = request.is_all_day
        if not UtilClient.is_unset(request.recurrence):
            body['recurrence'] = request.recurrence
        if not UtilClient.is_unset(request.attendees):
            body['attendees'] = request.attendees
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.reminders):
            body['reminders'] = request.reminders
        if not UtilClient.is_unset(request.online_meeting_info):
            body['onlineMeetingInfo'] = request.online_meeting_info
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
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
            dingtalkcalendar__1__0_models.CreateEventResponse(),
            await self.do_roarequest_async('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    def list_calendars(
        self,
        user_id: str,
    ) -> dingtalkcalendar__1__0_models.ListCalendarsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListCalendarsHeaders()
        return self.list_calendars_with_options(user_id, headers, runtime)

    async def list_calendars_async(
        self,
        user_id: str,
    ) -> dingtalkcalendar__1__0_models.ListCalendarsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListCalendarsHeaders()
        return await self.list_calendars_with_options_async(user_id, headers, runtime)

    def list_calendars_with_options(
        self,
        user_id: str,
        headers: dingtalkcalendar__1__0_models.ListCalendarsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListCalendarsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ListCalendarsResponse(),
            self.do_roarequest('ListCalendars', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars', 'json', req, runtime)
        )

    async def list_calendars_with_options_async(
        self,
        user_id: str,
        headers: dingtalkcalendar__1__0_models.ListCalendarsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListCalendarsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.ListCalendarsResponse(),
            await self.do_roarequest_async('ListCalendars', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars', 'json', req, runtime)
        )

    def get_sign_in_list(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetSignInListRequest,
    ) -> dingtalkcalendar__1__0_models.GetSignInListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetSignInListHeaders()
        return self.get_sign_in_list_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def get_sign_in_list_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetSignInListRequest,
    ) -> dingtalkcalendar__1__0_models.GetSignInListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetSignInListHeaders()
        return await self.get_sign_in_list_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def get_sign_in_list_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetSignInListRequest,
        headers: dingtalkcalendar__1__0_models.GetSignInListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetSignInListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            dingtalkcalendar__1__0_models.GetSignInListResponse(),
            self.do_roarequest('GetSignInList', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/signin', 'json', req, runtime)
        )

    async def get_sign_in_list_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetSignInListRequest,
        headers: dingtalkcalendar__1__0_models.GetSignInListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetSignInListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            dingtalkcalendar__1__0_models.GetSignInListResponse(),
            await self.do_roarequest_async('GetSignInList', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/signin', 'json', req, runtime)
        )

    def delete_acl(
        self,
        user_id: str,
        calendar_id: str,
        acl_id: str,
    ) -> dingtalkcalendar__1__0_models.DeleteAclResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.DeleteAclHeaders()
        return self.delete_acl_with_options(user_id, calendar_id, acl_id, headers, runtime)

    async def delete_acl_async(
        self,
        user_id: str,
        calendar_id: str,
        acl_id: str,
    ) -> dingtalkcalendar__1__0_models.DeleteAclResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.DeleteAclHeaders()
        return await self.delete_acl_with_options_async(user_id, calendar_id, acl_id, headers, runtime)

    def delete_acl_with_options(
        self,
        user_id: str,
        calendar_id: str,
        acl_id: str,
        headers: dingtalkcalendar__1__0_models.DeleteAclHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.DeleteAclResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.DeleteAclResponse(),
            self.do_roarequest('DeleteAcl', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls/{acl_id}', 'none', req, runtime)
        )

    async def delete_acl_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        acl_id: str,
        headers: dingtalkcalendar__1__0_models.DeleteAclHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.DeleteAclResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.DeleteAclResponse(),
            await self.do_roarequest_async('DeleteAcl', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/acls/{acl_id}', 'none', req, runtime)
        )

    def delete_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.DeleteEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.DeleteEventHeaders()
        return self.delete_event_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def delete_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.DeleteEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.DeleteEventHeaders()
        return await self.delete_event_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def delete_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.DeleteEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.DeleteEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.DeleteEventResponse(),
            self.do_roarequest('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'none', req, runtime)
        )

    async def delete_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.DeleteEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.DeleteEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.DeleteEventResponse(),
            await self.do_roarequest_async('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'none', req, runtime)
        )

    def list_events(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsRequest,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsHeaders()
        return self.list_events_with_options(user_id, calendar_id, request, headers, runtime)

    async def list_events_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsRequest,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsHeaders()
        return await self.list_events_with_options_async(user_id, calendar_id, request, headers, runtime)

    def list_events_with_options(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsRequest,
        headers: dingtalkcalendar__1__0_models.ListEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.time_min):
            query['timeMin'] = request.time_min
        if not UtilClient.is_unset(request.time_max):
            query['timeMax'] = request.time_max
        if not UtilClient.is_unset(request.show_deleted):
            query['showDeleted'] = request.show_deleted
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sync_token):
            query['syncToken'] = request.sync_token
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
            dingtalkcalendar__1__0_models.ListEventsResponse(),
            self.do_roarequest('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    async def list_events_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsRequest,
        headers: dingtalkcalendar__1__0_models.ListEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.time_min):
            query['timeMin'] = request.time_min
        if not UtilClient.is_unset(request.time_max):
            query['timeMax'] = request.time_max
        if not UtilClient.is_unset(request.show_deleted):
            query['showDeleted'] = request.show_deleted
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sync_token):
            query['syncToken'] = request.sync_token
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
            dingtalkcalendar__1__0_models.ListEventsResponse(),
            await self.do_roarequest_async('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    def list_events_view(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsViewRequest,
    ) -> dingtalkcalendar__1__0_models.ListEventsViewResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsViewHeaders()
        return self.list_events_view_with_options(user_id, calendar_id, request, headers, runtime)

    async def list_events_view_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsViewRequest,
    ) -> dingtalkcalendar__1__0_models.ListEventsViewResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsViewHeaders()
        return await self.list_events_view_with_options_async(user_id, calendar_id, request, headers, runtime)

    def list_events_view_with_options(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsViewRequest,
        headers: dingtalkcalendar__1__0_models.ListEventsViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsViewResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.time_min):
            query['timeMin'] = request.time_min
        if not UtilClient.is_unset(request.time_max):
            query['timeMax'] = request.time_max
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkcalendar__1__0_models.ListEventsViewResponse(),
            self.do_roarequest('ListEventsView', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/eventsview', 'json', req, runtime)
        )

    async def list_events_view_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        request: dingtalkcalendar__1__0_models.ListEventsViewRequest,
        headers: dingtalkcalendar__1__0_models.ListEventsViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsViewResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.time_min):
            query['timeMin'] = request.time_min
        if not UtilClient.is_unset(request.time_max):
            query['timeMax'] = request.time_max
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkcalendar__1__0_models.ListEventsViewResponse(),
            await self.do_roarequest_async('ListEventsView', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/eventsview', 'json', req, runtime)
        )

    def sign_in(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.SignInResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.SignInHeaders()
        return self.sign_in_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def sign_in_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.SignInResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.SignInHeaders()
        return await self.sign_in_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def sign_in_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.SignInHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.SignInResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.SignInResponse(),
            self.do_roarequest('SignIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/signIn', 'json', req, runtime)
        )

    async def sign_in_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.SignInHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.SignInResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.SignInResponse(),
            await self.do_roarequest_async('SignIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/signIn', 'json', req, runtime)
        )

    def get_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetEventRequest,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetEventHeaders()
        return self.get_event_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def get_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetEventRequest,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetEventHeaders()
        return await self.get_event_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def get_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetEventRequest,
        headers: dingtalkcalendar__1__0_models.GetEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_attendees):
            query['maxAttendees'] = request.max_attendees
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
            dingtalkcalendar__1__0_models.GetEventResponse(),
            self.do_roarequest('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    async def get_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.GetEventRequest,
        headers: dingtalkcalendar__1__0_models.GetEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_attendees):
            query['maxAttendees'] = request.max_attendees
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
            dingtalkcalendar__1__0_models.GetEventResponse(),
            await self.do_roarequest_async('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    def check_in(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.CheckInResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CheckInHeaders()
        return self.check_in_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def check_in_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.CheckInResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CheckInHeaders()
        return await self.check_in_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def check_in_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.CheckInHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CheckInResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.CheckInResponse(),
            self.do_roarequest('CheckIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/checkIn', 'json', req, runtime)
        )

    async def check_in_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.CheckInHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CheckInResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkcalendar__1__0_models.CheckInResponse(),
            await self.do_roarequest_async('CheckIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/checkIn', 'json', req, runtime)
        )

    def patch_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.PatchEventRequest,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.PatchEventHeaders()
        return self.patch_event_with_options(user_id, calendar_id, event_id, request, headers, runtime)

    async def patch_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.PatchEventRequest,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.PatchEventHeaders()
        return await self.patch_event_with_options_async(user_id, calendar_id, event_id, request, headers, runtime)

    def patch_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.PatchEventRequest,
        headers: dingtalkcalendar__1__0_models.PatchEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.is_all_day):
            body['isAllDay'] = request.is_all_day
        if not UtilClient.is_unset(request.recurrence):
            body['recurrence'] = request.recurrence
        if not UtilClient.is_unset(request.attendees):
            body['attendees'] = request.attendees
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
        if not UtilClient.is_unset(request.reminders):
            body['reminders'] = request.reminders
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
            dingtalkcalendar__1__0_models.PatchEventResponse(),
            self.do_roarequest('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    async def patch_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        request: dingtalkcalendar__1__0_models.PatchEventRequest,
        headers: dingtalkcalendar__1__0_models.PatchEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.is_all_day):
            body['isAllDay'] = request.is_all_day
        if not UtilClient.is_unset(request.recurrence):
            body['recurrence'] = request.recurrence
        if not UtilClient.is_unset(request.attendees):
            body['attendees'] = request.attendees
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
        if not UtilClient.is_unset(request.reminders):
            body['reminders'] = request.reminders
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
            dingtalkcalendar__1__0_models.PatchEventResponse(),
            await self.do_roarequest_async('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )
