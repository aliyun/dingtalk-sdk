# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from typing import Dict
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.diot_1_0 import models as dingtalkdiot__1__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def ayun_onlien_test_with_options(
        self,
        request: dingtalkdiot__1__0_models.AyunOnlienTestRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.AyunOnlienTestResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.req_id):
            query['reqId'] = request.req_id
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AyunOnlienTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/ayunTest',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.AyunOnlienTestResponse(),
            self.execute(params, req, runtime)
        )

    async def ayun_onlien_test_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.AyunOnlienTestRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.AyunOnlienTestResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.req_id):
            query['reqId'] = request.req_id
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AyunOnlienTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/ayunTest',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.AyunOnlienTestResponse(),
            await self.execute_async(params, req, runtime)
        )

    def ayun_onlien_test(
        self,
        request: dingtalkdiot__1__0_models.AyunOnlienTestRequest,
    ) -> dingtalkdiot__1__0_models.AyunOnlienTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.ayun_onlien_test_with_options(request, headers, runtime)

    async def ayun_onlien_test_async(
        self,
        request: dingtalkdiot__1__0_models.AyunOnlienTestRequest,
    ) -> dingtalkdiot__1__0_models.AyunOnlienTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.ayun_onlien_test_with_options_async(request, headers, runtime)

    def batch_delete_device_with_options(
        self,
        request: dingtalkdiot__1__0_models.BatchDeleteDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchDeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchDeleteDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_ids):
            body['deviceIds'] = request.device_ids
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
            action='BatchDeleteDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchDeleteDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_delete_device_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.BatchDeleteDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchDeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchDeleteDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_ids):
            body['deviceIds'] = request.device_ids
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
            action='BatchDeleteDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchDeleteDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_delete_device(
        self,
        request: dingtalkdiot__1__0_models.BatchDeleteDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchDeleteDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchDeleteDeviceHeaders()
        return self.batch_delete_device_with_options(request, headers, runtime)

    async def batch_delete_device_async(
        self,
        request: dingtalkdiot__1__0_models.BatchDeleteDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchDeleteDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchDeleteDeviceHeaders()
        return await self.batch_delete_device_with_options_async(request, headers, runtime)

    def batch_register_device_with_options(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchRegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.devices):
            body['devices'] = request.devices
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
            action='BatchRegisterDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/registrations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchRegisterDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_register_device_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchRegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.devices):
            body['devices'] = request.devices
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
            action='BatchRegisterDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/registrations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchRegisterDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_register_device(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchRegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchRegisterDeviceHeaders()
        return self.batch_register_device_with_options(request, headers, runtime)

    async def batch_register_device_async(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchRegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchRegisterDeviceHeaders()
        return await self.batch_register_device_with_options_async(request, headers, runtime)

    def batch_register_event_type_with_options(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterEventTypeRequest,
        headers: dingtalkdiot__1__0_models.BatchRegisterEventTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.event_types):
            body['eventTypes'] = request.event_types
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
            action='BatchRegisterEventType',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/eventTypes/registrations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_register_event_type_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterEventTypeRequest,
        headers: dingtalkdiot__1__0_models.BatchRegisterEventTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.event_types):
            body['eventTypes'] = request.event_types
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
            action='BatchRegisterEventType',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/eventTypes/registrations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_register_event_type(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterEventTypeRequest,
    ) -> dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchRegisterEventTypeHeaders()
        return self.batch_register_event_type_with_options(request, headers, runtime)

    async def batch_register_event_type_async(
        self,
        request: dingtalkdiot__1__0_models.BatchRegisterEventTypeRequest,
    ) -> dingtalkdiot__1__0_models.BatchRegisterEventTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchRegisterEventTypeHeaders()
        return await self.batch_register_event_type_with_options_async(request, headers, runtime)

    def batch_update_device_with_options(
        self,
        request: dingtalkdiot__1__0_models.BatchUpdateDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchUpdateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchUpdateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.devices):
            body['devices'] = request.devices
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
            action='BatchUpdateDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchUpdateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_device_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.BatchUpdateDeviceRequest,
        headers: dingtalkdiot__1__0_models.BatchUpdateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BatchUpdateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.devices):
            body['devices'] = request.devices
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
            action='BatchUpdateDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/batch',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BatchUpdateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_device(
        self,
        request: dingtalkdiot__1__0_models.BatchUpdateDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchUpdateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchUpdateDeviceHeaders()
        return self.batch_update_device_with_options(request, headers, runtime)

    async def batch_update_device_async(
        self,
        request: dingtalkdiot__1__0_models.BatchUpdateDeviceRequest,
    ) -> dingtalkdiot__1__0_models.BatchUpdateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BatchUpdateDeviceHeaders()
        return await self.batch_update_device_with_options_async(request, headers, runtime)

    def bind_system_with_options(
        self,
        request: dingtalkdiot__1__0_models.BindSystemRequest,
        headers: dingtalkdiot__1__0_models.BindSystemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BindSystemResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_name):
            body['clientName'] = request.client_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extra_data):
            body['extraData'] = request.extra_data
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
            action='BindSystem',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/systems/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BindSystemResponse(),
            self.execute(params, req, runtime)
        )

    async def bind_system_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.BindSystemRequest,
        headers: dingtalkdiot__1__0_models.BindSystemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.BindSystemResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_name):
            body['clientName'] = request.client_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.extra_data):
            body['extraData'] = request.extra_data
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
            action='BindSystem',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/systems/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.BindSystemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bind_system(
        self,
        request: dingtalkdiot__1__0_models.BindSystemRequest,
    ) -> dingtalkdiot__1__0_models.BindSystemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BindSystemHeaders()
        return self.bind_system_with_options(request, headers, runtime)

    async def bind_system_async(
        self,
        request: dingtalkdiot__1__0_models.BindSystemRequest,
    ) -> dingtalkdiot__1__0_models.BindSystemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.BindSystemHeaders()
        return await self.bind_system_with_options_async(request, headers, runtime)

    def device_conference_with_options(
        self,
        request: dingtalkdiot__1__0_models.DeviceConferenceRequest,
        headers: dingtalkdiot__1__0_models.DeviceConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DeviceConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.conference_id):
            body['conferenceId'] = request.conference_id
        if not UtilClient.is_unset(request.conference_password):
            body['conferencePassword'] = request.conference_password
        if not UtilClient.is_unset(request.device_ids):
            body['deviceIds'] = request.device_ids
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
            action='DeviceConference',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/deviceConferences/initiate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DeviceConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def device_conference_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.DeviceConferenceRequest,
        headers: dingtalkdiot__1__0_models.DeviceConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DeviceConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.conference_id):
            body['conferenceId'] = request.conference_id
        if not UtilClient.is_unset(request.conference_password):
            body['conferencePassword'] = request.conference_password
        if not UtilClient.is_unset(request.device_ids):
            body['deviceIds'] = request.device_ids
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
            action='DeviceConference',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/deviceConferences/initiate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DeviceConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_conference(
        self,
        request: dingtalkdiot__1__0_models.DeviceConferenceRequest,
    ) -> dingtalkdiot__1__0_models.DeviceConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.DeviceConferenceHeaders()
        return self.device_conference_with_options(request, headers, runtime)

    async def device_conference_async(
        self,
        request: dingtalkdiot__1__0_models.DeviceConferenceRequest,
    ) -> dingtalkdiot__1__0_models.DeviceConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.DeviceConferenceHeaders()
        return await self.device_conference_with_options_async(request, headers, runtime)

    def diot_market_manager_test_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotMarketManagerTestResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DiotMarketManagerTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/market/manager/test',
            method='PUT',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotMarketManagerTestResponse(),
            self.execute(params, req, runtime)
        )

    async def diot_market_manager_test_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotMarketManagerTestResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DiotMarketManagerTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/market/manager/test',
            method='PUT',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotMarketManagerTestResponse(),
            await self.execute_async(params, req, runtime)
        )

    def diot_market_manager_test(self) -> dingtalkdiot__1__0_models.DiotMarketManagerTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.diot_market_manager_test_with_options(headers, runtime)

    async def diot_market_manager_test_async(self) -> dingtalkdiot__1__0_models.DiotMarketManagerTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.diot_market_manager_test_with_options_async(headers, runtime)

    def diot_system_mark_test_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotSystemMarkTestResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DiotSystemMarkTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/sys/mark/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotSystemMarkTestResponse(),
            self.execute(params, req, runtime)
        )

    async def diot_system_mark_test_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotSystemMarkTestResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='DiotSystemMarkTest',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/sys/mark/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotSystemMarkTestResponse(),
            await self.execute_async(params, req, runtime)
        )

    def diot_system_mark_test(self) -> dingtalkdiot__1__0_models.DiotSystemMarkTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.diot_system_mark_test_with_options(headers, runtime)

    async def diot_system_mark_test_async(self) -> dingtalkdiot__1__0_models.DiotSystemMarkTestResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.diot_system_mark_test_with_options_async(headers, runtime)

    def diot__market__manager_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotMarketManagerResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='Diot_Market_Manager',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotMarketManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def diot__market__manager_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.DiotMarketManagerResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='Diot_Market_Manager',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.DiotMarketManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def diot__market__manager(self) -> dingtalkdiot__1__0_models.DiotMarketManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.diot__market__manager_with_options(headers, runtime)

    async def diot__market__manager_async(self) -> dingtalkdiot__1__0_models.DiotMarketManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.diot__market__manager_with_options_async(headers, runtime)

    def push_event_with_options(
        self,
        request: dingtalkdiot__1__0_models.PushEventRequest,
        headers: dingtalkdiot__1__0_models.PushEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.PushEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.event_name):
            body['eventName'] = request.event_name
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        if not UtilClient.is_unset(request.extra_data):
            body['extraData'] = request.extra_data
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.msg):
            body['msg'] = request.msg
        if not UtilClient.is_unset(request.occurrence_time):
            body['occurrenceTime'] = request.occurrence_time
        if not UtilClient.is_unset(request.pic_urls):
            body['picUrls'] = request.pic_urls
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
            action='PushEvent',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.PushEventResponse(),
            self.execute(params, req, runtime)
        )

    async def push_event_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.PushEventRequest,
        headers: dingtalkdiot__1__0_models.PushEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.PushEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.event_name):
            body['eventName'] = request.event_name
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        if not UtilClient.is_unset(request.extra_data):
            body['extraData'] = request.extra_data
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.msg):
            body['msg'] = request.msg
        if not UtilClient.is_unset(request.occurrence_time):
            body['occurrenceTime'] = request.occurrence_time
        if not UtilClient.is_unset(request.pic_urls):
            body['picUrls'] = request.pic_urls
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
            action='PushEvent',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.PushEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def push_event(
        self,
        request: dingtalkdiot__1__0_models.PushEventRequest,
    ) -> dingtalkdiot__1__0_models.PushEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.PushEventHeaders()
        return self.push_event_with_options(request, headers, runtime)

    async def push_event_async(
        self,
        request: dingtalkdiot__1__0_models.PushEventRequest,
    ) -> dingtalkdiot__1__0_models.PushEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.PushEventHeaders()
        return await self.push_event_with_options_async(request, headers, runtime)

    def query_device_with_options(
        self,
        request: dingtalkdiot__1__0_models.QueryDeviceRequest,
        headers: dingtalkdiot__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.QueryDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.QueryDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.QueryDeviceRequest,
        headers: dingtalkdiot__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.QueryDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.QueryDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device(
        self,
        request: dingtalkdiot__1__0_models.QueryDeviceRequest,
    ) -> dingtalkdiot__1__0_models.QueryDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.QueryDeviceHeaders()
        return self.query_device_with_options(request, headers, runtime)

    async def query_device_async(
        self,
        request: dingtalkdiot__1__0_models.QueryDeviceRequest,
    ) -> dingtalkdiot__1__0_models.QueryDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.QueryDeviceHeaders()
        return await self.query_device_with_options_async(request, headers, runtime)

    def query_event_with_options(
        self,
        request: dingtalkdiot__1__0_models.QueryEventRequest,
        headers: dingtalkdiot__1__0_models.QueryEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.QueryEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.event_status_list):
            body['eventStatusList'] = request.event_status_list
        if not UtilClient.is_unset(request.event_type_list):
            body['eventTypeList'] = request.event_type_list
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='QueryEvent',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/events/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.QueryEventResponse(),
            self.execute(params, req, runtime)
        )

    async def query_event_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.QueryEventRequest,
        headers: dingtalkdiot__1__0_models.QueryEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.QueryEventResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_id_list):
            body['deviceIdList'] = request.device_id_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.event_id):
            body['eventId'] = request.event_id
        if not UtilClient.is_unset(request.event_status_list):
            body['eventStatusList'] = request.event_status_list
        if not UtilClient.is_unset(request.event_type_list):
            body['eventTypeList'] = request.event_type_list
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='QueryEvent',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/events/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.QueryEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_event(
        self,
        request: dingtalkdiot__1__0_models.QueryEventRequest,
    ) -> dingtalkdiot__1__0_models.QueryEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.QueryEventHeaders()
        return self.query_event_with_options(request, headers, runtime)

    async def query_event_async(
        self,
        request: dingtalkdiot__1__0_models.QueryEventRequest,
    ) -> dingtalkdiot__1__0_models.QueryEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.QueryEventHeaders()
        return await self.query_event_with_options_async(request, headers, runtime)

    def register_device_with_options(
        self,
        request: dingtalkdiot__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdiot__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.RegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.device_status):
            body['deviceStatus'] = request.device_status
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.device_type_name):
            body['deviceTypeName'] = request.device_type_name
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.live_urls):
            body['liveUrls'] = request.live_urls
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.product_type):
            body['productType'] = request.product_type
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
            action='RegisterDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.RegisterDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def register_device_with_options_async(
        self,
        request: dingtalkdiot__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdiot__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.RegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.device_status):
            body['deviceStatus'] = request.device_status
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.device_type_name):
            body['deviceTypeName'] = request.device_type_name
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.live_urls):
            body['liveUrls'] = request.live_urls
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.product_type):
            body['productType'] = request.product_type
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
            action='RegisterDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/devices/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.RegisterDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_device(
        self,
        request: dingtalkdiot__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdiot__1__0_models.RegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.RegisterDeviceHeaders()
        return self.register_device_with_options(request, headers, runtime)

    async def register_device_async(
        self,
        request: dingtalkdiot__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdiot__1__0_models.RegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdiot__1__0_models.RegisterDeviceHeaders()
        return await self.register_device_with_options_async(request, headers, runtime)

    def upgrade_device_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.UpgradeDeviceResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='UpgradeDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/upgrade/device',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.UpgradeDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def upgrade_device_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.UpgradeDeviceResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='UpgradeDevice',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/upgrade/device',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.UpgradeDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upgrade_device(self) -> dingtalkdiot__1__0_models.UpgradeDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.upgrade_device_with_options(headers, runtime)

    async def upgrade_device_async(self) -> dingtalkdiot__1__0_models.UpgradeDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.upgrade_device_with_options_async(headers, runtime)

    def workbench_transform_info_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='WorkbenchTransformInfo',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/workbench/transform',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def workbench_transform_info_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='WorkbenchTransformInfo',
            version='diot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/diot/workbench/transform',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def workbench_transform_info(self) -> dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.workbench_transform_info_with_options(headers, runtime)

    async def workbench_transform_info_async(self) -> dingtalkdiot__1__0_models.WorkbenchTransformInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.workbench_transform_info_with_options_async(headers, runtime)
