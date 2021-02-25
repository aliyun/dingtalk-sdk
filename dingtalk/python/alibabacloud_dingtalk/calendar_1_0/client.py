# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkcalendar_1_0 import models as dingtalkcalendar__1__0_models
from alibabacloud_tea_util import models as util_models


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
        return dingtalkcalendar__1__0_models.DeleteEventResponse().from_map(
            self.do_roarequest('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
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
        return dingtalkcalendar__1__0_models.DeleteEventResponse().from_map(
            await self.do_roarequest_async('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    def respond_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RespondEventHeaders()
        return self.respond_event_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def respond_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RespondEventHeaders()
        return await self.respond_event_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def respond_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.RespondEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.RespondEventResponse().from_map(
            self.do_roarequest('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/respond', 'json', req, runtime)
        )

    async def respond_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.RespondEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RespondEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.RespondEventResponse().from_map(
            await self.do_roarequest_async('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/respond', 'json', req, runtime)
        )

    def list_events(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsHeaders()
        return self.list_events_with_options(user_id, calendar_id, headers, runtime)

    async def list_events_async(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.ListEventsHeaders()
        return await self.list_events_with_options_async(user_id, calendar_id, headers, runtime)

    def list_events_with_options(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.ListEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.ListEventsResponse().from_map(
            self.do_roarequest('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    async def list_events_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.ListEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.ListEventsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.ListEventsResponse().from_map(
            await self.do_roarequest_async('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    def remove_attendee(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RemoveAttendeeHeaders()
        return self.remove_attendee_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def remove_attendee_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.RemoveAttendeeHeaders()
        return await self.remove_attendee_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def remove_attendee_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.RemoveAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.RemoveAttendeeResponse().from_map(
            self.do_roarequest('RemoveAttendee', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'json', req, runtime)
        )

    async def remove_attendee_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.RemoveAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.RemoveAttendeeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.RemoveAttendeeResponse().from_map(
            await self.do_roarequest_async('RemoveAttendee', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'json', req, runtime)
        )

    def add_attendee(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.AddAttendeeHeaders()
        return self.add_attendee_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def add_attendee_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.AddAttendeeHeaders()
        return await self.add_attendee_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def add_attendee_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.AddAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.AddAttendeeResponse().from_map(
            self.do_roarequest('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'json', req, runtime)
        )

    async def add_attendee_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.AddAttendeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.AddAttendeeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.AddAttendeeResponse().from_map(
            await self.do_roarequest_async('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}/attendees', 'json', req, runtime)
        )

    def get_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetEventHeaders()
        return self.get_event_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def get_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.GetEventHeaders()
        return await self.get_event_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def get_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.GetEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.GetEventResponse().from_map(
            self.do_roarequest('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    async def get_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.GetEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.GetEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.GetEventResponse().from_map(
            await self.do_roarequest_async('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    def patch_event(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.PatchEventHeaders()
        return self.patch_event_with_options(user_id, calendar_id, event_id, headers, runtime)

    async def patch_event_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.PatchEventHeaders()
        return await self.patch_event_with_options_async(user_id, calendar_id, event_id, headers, runtime)

    def patch_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.PatchEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.PatchEventResponse().from_map(
            self.do_roarequest('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    async def patch_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        event_id: str,
        headers: dingtalkcalendar__1__0_models.PatchEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.PatchEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.PatchEventResponse().from_map(
            await self.do_roarequest_async('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events/{event_id}', 'json', req, runtime)
        )

    def create_event(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateEventHeaders()
        return self.create_event_with_options(user_id, calendar_id, headers, runtime)

    async def create_event_async(
        self,
        user_id: str,
        calendar_id: str,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcalendar__1__0_models.CreateEventHeaders()
        return await self.create_event_with_options_async(user_id, calendar_id, headers, runtime)

    def create_event_with_options(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.CreateEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.CreateEventResponse().from_map(
            self.do_roarequest('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )

    async def create_event_with_options_async(
        self,
        user_id: str,
        calendar_id: str,
        headers: dingtalkcalendar__1__0_models.CreateEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcalendar__1__0_models.CreateEventResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return dingtalkcalendar__1__0_models.CreateEventResponse().from_map(
            await self.do_roarequest_async('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/calendar/users/{user_id}/calendars/{calendar_id}/events', 'json', req, runtime)
        )
