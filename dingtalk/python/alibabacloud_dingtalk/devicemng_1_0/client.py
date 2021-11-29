# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.devicemng_1_0 import models as dingtalkdevicemng__1__0_models
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
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterDeviceHeaders()
        return self.register_device_with_options(request, headers, runtime)

    async def register_device_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterDeviceHeaders()
        return await self.register_device_with_options_async(request, headers, runtime)

    def register_device_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.managers):
            body['managers'] = request.managers
        if not UtilClient.is_unset(request.collaborators):
            body['collaborators'] = request.collaborators
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.RegisterDeviceResponse(),
            self.do_roarequest('RegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/devices', 'json', req, runtime)
        )

    async def register_device_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.managers):
            body['managers'] = request.managers
        if not UtilClient.is_unset(request.collaborators):
            body['collaborators'] = request.collaborators
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.RegisterDeviceResponse(),
            await self.do_roarequest_async('RegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/devices', 'json', req, runtime)
        )

    def batch_register_device(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders()
        return self.batch_register_device_with_options(request, headers, runtime)

    async def batch_register_device_async(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders()
        return await self.batch_register_device_with_options_async(request, headers, runtime)

    def batch_register_device_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_list):
            body['deviceList'] = request.device_list
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse(),
            self.do_roarequest('BatchRegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/devices/batch', 'json', req, runtime)
        )

    async def batch_register_device_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_list):
            body['deviceList'] = request.device_list
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse(),
            await self.do_roarequest_async('BatchRegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/devices/batch', 'json', req, runtime)
        )

    def device_ding(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DeviceDingHeaders()
        return self.device_ding_with_options(request, headers, runtime)

    async def device_ding_async(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DeviceDingHeaders()
        return await self.device_ding_with_options_async(request, headers, runtime)

    def device_ding_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
        headers: dingtalkdevicemng__1__0_models.DeviceDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.params_json):
            body['paramsJson'] = request.params_json
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
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
            dingtalkdevicemng__1__0_models.DeviceDingResponse(),
            self.do_roarequest('DeviceDing', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/ding', 'json', req, runtime)
        )

    async def device_ding_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
        headers: dingtalkdevicemng__1__0_models.DeviceDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.params_json):
            body['paramsJson'] = request.params_json
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
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
            dingtalkdevicemng__1__0_models.DeviceDingResponse(),
            await self.do_roarequest_async('DeviceDing', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/ding', 'json', req, runtime)
        )

    def create_department(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDepartmentHeaders()
        return self.create_department_with_options(request, headers, runtime)

    async def create_department_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDepartmentHeaders()
        return await self.create_department_with_options_async(request, headers, runtime)

    def create_department_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.department_name):
            body['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.department_type):
            body['departmentType'] = request.department_type
        if not UtilClient.is_unset(request.system_url):
            body['systemUrl'] = request.system_url
        if not UtilClient.is_unset(request.auth_type):
            body['authType'] = request.auth_type
        if not UtilClient.is_unset(request.auth_info):
            body['authInfo'] = request.auth_info
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.biz_ext):
            body['bizExt'] = request.biz_ext
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.CreateDepartmentResponse(),
            self.do_roarequest('CreateDepartment', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/departments', 'json', req, runtime)
        )

    async def create_department_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.department_name):
            body['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.department_type):
            body['departmentType'] = request.department_type
        if not UtilClient.is_unset(request.system_url):
            body['systemUrl'] = request.system_url
        if not UtilClient.is_unset(request.auth_type):
            body['authType'] = request.auth_type
        if not UtilClient.is_unset(request.auth_info):
            body['authInfo'] = request.auth_info
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.biz_ext):
            body['bizExt'] = request.biz_ext
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkdevicemng__1__0_models.CreateDepartmentResponse(),
            await self.do_roarequest_async('CreateDepartment', 'devicemng_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/devicemng/departments', 'json', req, runtime)
        )
