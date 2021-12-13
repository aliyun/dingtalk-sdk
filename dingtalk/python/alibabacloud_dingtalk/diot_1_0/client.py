# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.diot_1_0 import models as dingtalkdiot__1__0_models
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
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.device_status):
            body['deviceStatus'] = request.device_status
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.device_type_name):
            body['deviceTypeName'] = request.device_type_name
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.product_type):
            body['productType'] = request.product_type
        if not UtilClient.is_unset(request.live_url):
            body['liveUrl'] = request.live_url
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
            dingtalkdiot__1__0_models.RegisterDeviceResponse(),
            self.do_roarequest('RegisterDevice', 'diot_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/diot/devices/register', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.device_status):
            body['deviceStatus'] = request.device_status
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
        if not UtilClient.is_unset(request.device_type_name):
            body['deviceTypeName'] = request.device_type_name
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.product_type):
            body['productType'] = request.product_type
        if not UtilClient.is_unset(request.live_url):
            body['liveUrl'] = request.live_url
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
            dingtalkdiot__1__0_models.RegisterDeviceResponse(),
            await self.do_roarequest_async('RegisterDevice', 'diot_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/diot/devices/register', 'json', req, runtime)
        )
