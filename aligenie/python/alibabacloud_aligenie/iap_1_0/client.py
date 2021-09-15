# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_aligenie.iap_1_0 import models as ali_genieiap__1__0_models
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

    def wake_up_app(
        self,
        request: ali_genieiap__1__0_models.WakeUpAppRequest,
    ) -> ali_genieiap__1__0_models.WakeUpAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = ali_genieiap__1__0_models.WakeUpAppHeaders()
        return self.wake_up_app_with_options(request, headers, runtime)

    async def wake_up_app_async(
        self,
        request: ali_genieiap__1__0_models.WakeUpAppRequest,
    ) -> ali_genieiap__1__0_models.WakeUpAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = ali_genieiap__1__0_models.WakeUpAppHeaders()
        return await self.wake_up_app_with_options_async(request, headers, runtime)

    def wake_up_app_with_options(
        self,
        request: ali_genieiap__1__0_models.WakeUpAppRequest,
        headers: ali_genieiap__1__0_models.WakeUpAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> ali_genieiap__1__0_models.WakeUpAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.path):
            body['Path'] = request.path
        if not UtilClient.is_unset(request.genie_app_id):
            body['GenieAppId'] = request.genie_app_id
        if not UtilClient.is_unset(request.target_info):
            body['TargetInfo'] = request.target_info
        if not UtilClient.is_unset(request.is_debug):
            body['IsDebug'] = request.is_debug
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_aligenie_access_token):
            real_headers['x-acs-aligenie-access-token'] = headers.x_acs_aligenie_access_token
        if not UtilClient.is_unset(headers.authorization):
            real_headers['Authorization'] = headers.authorization
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            ali_genieiap__1__0_models.WakeUpAppResponse(),
            self.do_roarequest('WakeUpApp', 'iap_1.0', 'HTTPS', 'PUT', 'AK', f'/v1.0/v1.0/iap/wakeup', 'none', req, runtime)
        )

    async def wake_up_app_with_options_async(
        self,
        request: ali_genieiap__1__0_models.WakeUpAppRequest,
        headers: ali_genieiap__1__0_models.WakeUpAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> ali_genieiap__1__0_models.WakeUpAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.path):
            body['Path'] = request.path
        if not UtilClient.is_unset(request.genie_app_id):
            body['GenieAppId'] = request.genie_app_id
        if not UtilClient.is_unset(request.target_info):
            body['TargetInfo'] = request.target_info
        if not UtilClient.is_unset(request.is_debug):
            body['IsDebug'] = request.is_debug
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_aligenie_access_token):
            real_headers['x-acs-aligenie-access-token'] = headers.x_acs_aligenie_access_token
        if not UtilClient.is_unset(headers.authorization):
            real_headers['Authorization'] = headers.authorization
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            ali_genieiap__1__0_models.WakeUpAppResponse(),
            await self.do_roarequest_async('WakeUpApp', 'iap_1.0', 'HTTPS', 'PUT', 'AK', f'/v1.0/v1.0/iap/wakeup', 'none', req, runtime)
        )

    def push_notifications(
        self,
        request: ali_genieiap__1__0_models.PushNotificationsRequest,
    ) -> ali_genieiap__1__0_models.PushNotificationsResponse:
        runtime = util_models.RuntimeOptions()
        headers = ali_genieiap__1__0_models.PushNotificationsHeaders()
        return self.push_notifications_with_options(request, headers, runtime)

    async def push_notifications_async(
        self,
        request: ali_genieiap__1__0_models.PushNotificationsRequest,
    ) -> ali_genieiap__1__0_models.PushNotificationsResponse:
        runtime = util_models.RuntimeOptions()
        headers = ali_genieiap__1__0_models.PushNotificationsHeaders()
        return await self.push_notifications_with_options_async(request, headers, runtime)

    def push_notifications_with_options(
        self,
        tmp_req: ali_genieiap__1__0_models.PushNotificationsRequest,
        headers: ali_genieiap__1__0_models.PushNotificationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> ali_genieiap__1__0_models.PushNotificationsResponse:
        UtilClient.validate_model(tmp_req)
        request = ali_genieiap__1__0_models.PushNotificationsShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.notification_unicast_request):
            request.notification_unicast_request_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.notification_unicast_request), 'NotificationUnicastRequest', 'json')
        if not UtilClient.is_unset(tmp_req.tenant_info):
            request.tenant_info_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.tenant_info), 'TenantInfo', 'json')
        body = {}
        if not UtilClient.is_unset(request.notification_unicast_request_shrink):
            body['NotificationUnicastRequest'] = request.notification_unicast_request_shrink
        if not UtilClient.is_unset(request.tenant_info_shrink):
            body['TenantInfo'] = request.tenant_info_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_aligenie_access_token):
            real_headers['x-acs-aligenie-access-token'] = headers.x_acs_aligenie_access_token
        if not UtilClient.is_unset(headers.authorization):
            real_headers['Authorization'] = headers.authorization
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            ali_genieiap__1__0_models.PushNotificationsResponse(),
            self.do_roarequest_with_form('PushNotifications', 'iap_1.0', 'HTTPS', 'PUT', 'AK', f'/v1.0/v1.0/iap/notifications', 'none', req, runtime)
        )

    async def push_notifications_with_options_async(
        self,
        tmp_req: ali_genieiap__1__0_models.PushNotificationsRequest,
        headers: ali_genieiap__1__0_models.PushNotificationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> ali_genieiap__1__0_models.PushNotificationsResponse:
        UtilClient.validate_model(tmp_req)
        request = ali_genieiap__1__0_models.PushNotificationsShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.notification_unicast_request):
            request.notification_unicast_request_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.notification_unicast_request), 'NotificationUnicastRequest', 'json')
        if not UtilClient.is_unset(tmp_req.tenant_info):
            request.tenant_info_shrink = OpenApiUtilClient.array_to_string_with_specified_style(TeaCore.to_map(tmp_req.tenant_info), 'TenantInfo', 'json')
        body = {}
        if not UtilClient.is_unset(request.notification_unicast_request_shrink):
            body['NotificationUnicastRequest'] = request.notification_unicast_request_shrink
        if not UtilClient.is_unset(request.tenant_info_shrink):
            body['TenantInfo'] = request.tenant_info_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_aligenie_access_token):
            real_headers['x-acs-aligenie-access-token'] = headers.x_acs_aligenie_access_token
        if not UtilClient.is_unset(headers.authorization):
            real_headers['Authorization'] = headers.authorization
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            ali_genieiap__1__0_models.PushNotificationsResponse(),
            await self.do_roarequest_with_form_async('PushNotifications', 'iap_1.0', 'HTTPS', 'PUT', 'AK', f'/v1.0/v1.0/iap/notifications', 'none', req, runtime)
        )
