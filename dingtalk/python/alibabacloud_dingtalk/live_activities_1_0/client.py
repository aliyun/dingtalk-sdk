# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.live_activities_1_0 import models as dingtalklive_activities__1__0_models
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

    def push_live_activity_with_options(
        self,
        request: dingtalklive_activities__1__0_models.PushLiveActivityRequest,
        headers: dingtalklive_activities__1__0_models.PushLiveActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive_activities__1__0_models.PushLiveActivityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_event_data):
            body['activityEventData'] = request.activity_event_data
        if not UtilClient.is_unset(request.activity_event_option):
            body['activityEventOption'] = request.activity_event_option
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
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
            action='PushLiveActivity',
            version='liveActivities_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/liveActivities/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive_activities__1__0_models.PushLiveActivityResponse(),
            self.execute(params, req, runtime)
        )

    async def push_live_activity_with_options_async(
        self,
        request: dingtalklive_activities__1__0_models.PushLiveActivityRequest,
        headers: dingtalklive_activities__1__0_models.PushLiveActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive_activities__1__0_models.PushLiveActivityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_event_data):
            body['activityEventData'] = request.activity_event_data
        if not UtilClient.is_unset(request.activity_event_option):
            body['activityEventOption'] = request.activity_event_option
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
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
            action='PushLiveActivity',
            version='liveActivities_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/liveActivities/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive_activities__1__0_models.PushLiveActivityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def push_live_activity(
        self,
        request: dingtalklive_activities__1__0_models.PushLiveActivityRequest,
    ) -> dingtalklive_activities__1__0_models.PushLiveActivityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive_activities__1__0_models.PushLiveActivityHeaders()
        return self.push_live_activity_with_options(request, headers, runtime)

    async def push_live_activity_async(
        self,
        request: dingtalklive_activities__1__0_models.PushLiveActivityRequest,
    ) -> dingtalklive_activities__1__0_models.PushLiveActivityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive_activities__1__0_models.PushLiveActivityHeaders()
        return await self.push_live_activity_with_options_async(request, headers, runtime)

    def send_live_activity_with_options(
        self,
        request: dingtalklive_activities__1__0_models.SendLiveActivityRequest,
        headers: dingtalklive_activities__1__0_models.SendLiveActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive_activities__1__0_models.SendLiveActivityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_event_data):
            body['activityEventData'] = request.activity_event_data
        if not UtilClient.is_unset(request.activity_event_option):
            body['activityEventOption'] = request.activity_event_option
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
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
            action='SendLiveActivity',
            version='liveActivities_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/liveActivities/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive_activities__1__0_models.SendLiveActivityResponse(),
            self.execute(params, req, runtime)
        )

    async def send_live_activity_with_options_async(
        self,
        request: dingtalklive_activities__1__0_models.SendLiveActivityRequest,
        headers: dingtalklive_activities__1__0_models.SendLiveActivityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive_activities__1__0_models.SendLiveActivityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_event_data):
            body['activityEventData'] = request.activity_event_data
        if not UtilClient.is_unset(request.activity_event_option):
            body['activityEventOption'] = request.activity_event_option
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
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
            action='SendLiveActivity',
            version='liveActivities_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/liveActivities/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive_activities__1__0_models.SendLiveActivityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_live_activity(
        self,
        request: dingtalklive_activities__1__0_models.SendLiveActivityRequest,
    ) -> dingtalklive_activities__1__0_models.SendLiveActivityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive_activities__1__0_models.SendLiveActivityHeaders()
        return self.send_live_activity_with_options(request, headers, runtime)

    async def send_live_activity_async(
        self,
        request: dingtalklive_activities__1__0_models.SendLiveActivityRequest,
    ) -> dingtalklive_activities__1__0_models.SendLiveActivityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive_activities__1__0_models.SendLiveActivityHeaders()
        return await self.send_live_activity_with_options_async(request, headers, runtime)
