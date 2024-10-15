# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def batch_register_device_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        """
        @summary 批量注册设备
        
        @param request: BatchRegisterDeviceRequest
        @param headers: BatchRegisterDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRegisterDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_list):
            body['deviceList'] = request.device_list
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
            action='BatchRegisterDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/devices/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_register_device_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        """
        @summary 批量注册设备
        
        @param request: BatchRegisterDeviceRequest
        @param headers: BatchRegisterDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRegisterDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_list):
            body['deviceList'] = request.device_list
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
            action='BatchRegisterDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/devices/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_register_device(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        """
        @summary 批量注册设备
        
        @param request: BatchRegisterDeviceRequest
        @return: BatchRegisterDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders()
        return self.batch_register_device_with_options(request, headers, runtime)

    async def batch_register_device_async(
        self,
        request: dingtalkdevicemng__1__0_models.BatchRegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.BatchRegisterDeviceResponse:
        """
        @summary 批量注册设备
        
        @param request: BatchRegisterDeviceRequest
        @return: BatchRegisterDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.BatchRegisterDeviceHeaders()
        return await self.batch_register_device_with_options_async(request, headers, runtime)

    def connector_event_push_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.ConnectorEventPushRequest,
        headers: dingtalkdevicemng__1__0_models.ConnectorEventPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ConnectorEventPushResponse:
        """
        @summary 想设备上钉连接器推送设备事件
        
        @param request: ConnectorEventPushRequest
        @param headers: ConnectorEventPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConnectorEventPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type_uuid):
            body['deviceTypeUuid'] = request.device_type_uuid
        if not UtilClient.is_unset(request.event_name):
            body['eventName'] = request.event_name
        if not UtilClient.is_unset(request.input):
            body['input'] = request.input
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
            action='ConnectorEventPush',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/connectors/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ConnectorEventPushResponse(),
            self.execute(params, req, runtime)
        )

    async def connector_event_push_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.ConnectorEventPushRequest,
        headers: dingtalkdevicemng__1__0_models.ConnectorEventPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ConnectorEventPushResponse:
        """
        @summary 想设备上钉连接器推送设备事件
        
        @param request: ConnectorEventPushRequest
        @param headers: ConnectorEventPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConnectorEventPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type_uuid):
            body['deviceTypeUuid'] = request.device_type_uuid
        if not UtilClient.is_unset(request.event_name):
            body['eventName'] = request.event_name
        if not UtilClient.is_unset(request.input):
            body['input'] = request.input
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
            action='ConnectorEventPush',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/connectors/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ConnectorEventPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def connector_event_push(
        self,
        request: dingtalkdevicemng__1__0_models.ConnectorEventPushRequest,
    ) -> dingtalkdevicemng__1__0_models.ConnectorEventPushResponse:
        """
        @summary 想设备上钉连接器推送设备事件
        
        @param request: ConnectorEventPushRequest
        @return: ConnectorEventPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ConnectorEventPushHeaders()
        return self.connector_event_push_with_options(request, headers, runtime)

    async def connector_event_push_async(
        self,
        request: dingtalkdevicemng__1__0_models.ConnectorEventPushRequest,
    ) -> dingtalkdevicemng__1__0_models.ConnectorEventPushResponse:
        """
        @summary 想设备上钉连接器推送设备事件
        
        @param request: ConnectorEventPushRequest
        @return: ConnectorEventPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ConnectorEventPushHeaders()
        return await self.connector_event_push_with_options_async(request, headers, runtime)

    def create_chat_room_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.CreateChatRoomRequest,
        headers: dingtalkdevicemng__1__0_models.CreateChatRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateChatRoomResponse:
        """
        @summary 创建设备群
        
        @param request: CreateChatRoomRequest
        @param headers: CreateChatRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateChatRoomResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_group_name):
            body['chatGroupName'] = request.chat_group_name
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_type_id):
            body['deviceTypeId'] = request.device_type_id
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.role_list):
            body['roleList'] = request.role_list
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
            action='CreateChatRoom',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRoom',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateChatRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def create_chat_room_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateChatRoomRequest,
        headers: dingtalkdevicemng__1__0_models.CreateChatRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateChatRoomResponse:
        """
        @summary 创建设备群
        
        @param request: CreateChatRoomRequest
        @param headers: CreateChatRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateChatRoomResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_group_name):
            body['chatGroupName'] = request.chat_group_name
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_type_id):
            body['deviceTypeId'] = request.device_type_id
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.role_list):
            body['roleList'] = request.role_list
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
            action='CreateChatRoom',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRoom',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateChatRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_chat_room(
        self,
        request: dingtalkdevicemng__1__0_models.CreateChatRoomRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateChatRoomResponse:
        """
        @summary 创建设备群
        
        @param request: CreateChatRoomRequest
        @return: CreateChatRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateChatRoomHeaders()
        return self.create_chat_room_with_options(request, headers, runtime)

    async def create_chat_room_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateChatRoomRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateChatRoomResponse:
        """
        @summary 创建设备群
        
        @param request: CreateChatRoomRequest
        @return: CreateChatRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateChatRoomHeaders()
        return await self.create_chat_room_with_options_async(request, headers, runtime)

    def create_department_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        """
        @summary 创建部门
        
        @param request: CreateDepartmentRequest
        @param headers: CreateDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDepartmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_info):
            body['authInfo'] = request.auth_info
        if not UtilClient.is_unset(request.auth_type):
            body['authType'] = request.auth_type
        if not UtilClient.is_unset(request.biz_ext):
            body['bizExt'] = request.biz_ext
        if not UtilClient.is_unset(request.department_name):
            body['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.department_type):
            body['departmentType'] = request.department_type
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.system_url):
            body['systemUrl'] = request.system_url
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
            action='CreateDepartment',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateDepartmentResponse(),
            self.execute(params, req, runtime)
        )

    async def create_department_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        """
        @summary 创建部门
        
        @param request: CreateDepartmentRequest
        @param headers: CreateDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDepartmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_info):
            body['authInfo'] = request.auth_info
        if not UtilClient.is_unset(request.auth_type):
            body['authType'] = request.auth_type
        if not UtilClient.is_unset(request.biz_ext):
            body['bizExt'] = request.biz_ext
        if not UtilClient.is_unset(request.department_name):
            body['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.department_type):
            body['departmentType'] = request.department_type
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.system_url):
            body['systemUrl'] = request.system_url
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
            action='CreateDepartment',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateDepartmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_department(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        """
        @summary 创建部门
        
        @param request: CreateDepartmentRequest
        @return: CreateDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDepartmentHeaders()
        return self.create_department_with_options(request, headers, runtime)

    async def create_department_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDepartmentRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDepartmentResponse:
        """
        @summary 创建部门
        
        @param request: CreateDepartmentRequest
        @return: CreateDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDepartmentHeaders()
        return await self.create_department_with_options_async(request, headers, runtime)

    def create_device_chat_room_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse:
        """
        @summary 创建设备场景群
        
        @param request: CreateDeviceChatRoomRequest
        @param headers: CreateDeviceChatRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceChatRoomResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_type):
            body['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='CreateDeviceChatRoom',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def create_device_chat_room_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomRequest,
        headers: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse:
        """
        @summary 创建设备场景群
        
        @param request: CreateDeviceChatRoomRequest
        @param headers: CreateDeviceChatRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceChatRoomResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_type):
            body['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.owner_user_id):
            body['ownerUserId'] = request.owner_user_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='CreateDeviceChatRoom',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_device_chat_room(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse:
        """
        @summary 创建设备场景群
        
        @param request: CreateDeviceChatRoomRequest
        @return: CreateDeviceChatRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDeviceChatRoomHeaders()
        return self.create_device_chat_room_with_options(request, headers, runtime)

    async def create_device_chat_room_async(
        self,
        request: dingtalkdevicemng__1__0_models.CreateDeviceChatRoomRequest,
    ) -> dingtalkdevicemng__1__0_models.CreateDeviceChatRoomResponse:
        """
        @summary 创建设备场景群
        
        @param request: CreateDeviceChatRoomRequest
        @return: CreateDeviceChatRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.CreateDeviceChatRoomHeaders()
        return await self.create_device_chat_room_with_options_async(request, headers, runtime)

    def device_ding_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
        headers: dingtalkdevicemng__1__0_models.DeviceDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        """
        @summary 设备账号向目标用户发送ding消息
        
        @param request: DeviceDingRequest
        @param headers: DeviceDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceDingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.params_json):
            body['paramsJson'] = request.params_json
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
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
            action='DeviceDing',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/ding',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.DeviceDingResponse(),
            self.execute(params, req, runtime)
        )

    async def device_ding_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
        headers: dingtalkdevicemng__1__0_models.DeviceDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        """
        @summary 设备账号向目标用户发送ding消息
        
        @param request: DeviceDingRequest
        @param headers: DeviceDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeviceDingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.params_json):
            body['paramsJson'] = request.params_json
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
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
            action='DeviceDing',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/ding',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.DeviceDingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_ding(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        """
        @summary 设备账号向目标用户发送ding消息
        
        @param request: DeviceDingRequest
        @return: DeviceDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DeviceDingHeaders()
        return self.device_ding_with_options(request, headers, runtime)

    async def device_ding_async(
        self,
        request: dingtalkdevicemng__1__0_models.DeviceDingRequest,
    ) -> dingtalkdevicemng__1__0_models.DeviceDingResponse:
        """
        @summary 设备账号向目标用户发送ding消息
        
        @param request: DeviceDingRequest
        @return: DeviceDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DeviceDingHeaders()
        return await self.device_ding_with_options_async(request, headers, runtime)

    def dissolve_group_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.DissolveGroupRequest,
        headers: dingtalkdevicemng__1__0_models.DissolveGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DissolveGroupResponse:
        """
        @summary 解散设备群
        
        @param request: DissolveGroupRequest
        @param headers: DissolveGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DissolveGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='DissolveGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groups/dissolve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.DissolveGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def dissolve_group_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.DissolveGroupRequest,
        headers: dingtalkdevicemng__1__0_models.DissolveGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.DissolveGroupResponse:
        """
        @summary 解散设备群
        
        @param request: DissolveGroupRequest
        @param headers: DissolveGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DissolveGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='DissolveGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groups/dissolve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.DissolveGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def dissolve_group(
        self,
        request: dingtalkdevicemng__1__0_models.DissolveGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.DissolveGroupResponse:
        """
        @summary 解散设备群
        
        @param request: DissolveGroupRequest
        @return: DissolveGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DissolveGroupHeaders()
        return self.dissolve_group_with_options(request, headers, runtime)

    async def dissolve_group_async(
        self,
        request: dingtalkdevicemng__1__0_models.DissolveGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.DissolveGroupResponse:
        """
        @summary 解散设备群
        
        @param request: DissolveGroupRequest
        @return: DissolveGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.DissolveGroupHeaders()
        return await self.dissolve_group_with_options_async(request, headers, runtime)

    def edit_device_admin_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.EditDeviceAdminRequest,
        headers: dingtalkdevicemng__1__0_models.EditDeviceAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.EditDeviceAdminResponse:
        """
        @summary 编辑设备管理员
        
        @param request: EditDeviceAdminRequest
        @param headers: EditDeviceAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditDeviceAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.role_uuid):
            body['roleUuid'] = request.role_uuid
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='EditDeviceAdmin',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/administrators/edit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.EditDeviceAdminResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_device_admin_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.EditDeviceAdminRequest,
        headers: dingtalkdevicemng__1__0_models.EditDeviceAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.EditDeviceAdminResponse:
        """
        @summary 编辑设备管理员
        
        @param request: EditDeviceAdminRequest
        @param headers: EditDeviceAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditDeviceAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.role_uuid):
            body['roleUuid'] = request.role_uuid
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='EditDeviceAdmin',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/administrators/edit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.EditDeviceAdminResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_device_admin(
        self,
        request: dingtalkdevicemng__1__0_models.EditDeviceAdminRequest,
    ) -> dingtalkdevicemng__1__0_models.EditDeviceAdminResponse:
        """
        @summary 编辑设备管理员
        
        @param request: EditDeviceAdminRequest
        @return: EditDeviceAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.EditDeviceAdminHeaders()
        return self.edit_device_admin_with_options(request, headers, runtime)

    async def edit_device_admin_async(
        self,
        request: dingtalkdevicemng__1__0_models.EditDeviceAdminRequest,
    ) -> dingtalkdevicemng__1__0_models.EditDeviceAdminResponse:
        """
        @summary 编辑设备管理员
        
        @param request: EditDeviceAdminRequest
        @return: EditDeviceAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.EditDeviceAdminHeaders()
        return await self.edit_device_admin_with_options_async(request, headers, runtime)

    def get_device_group_info_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoRequest,
        headers: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse:
        """
        @summary 获取设备群信息
        
        @param request: GetDeviceGroupInfoRequest
        @param headers: GetDeviceGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeviceGroupInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetDeviceGroupInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groupInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_device_group_info_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoRequest,
        headers: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse:
        """
        @summary 获取设备群信息
        
        @param request: GetDeviceGroupInfoRequest
        @param headers: GetDeviceGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDeviceGroupInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetDeviceGroupInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/groupInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_device_group_info(
        self,
        request: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse:
        """
        @summary 获取设备群信息
        
        @param request: GetDeviceGroupInfoRequest
        @return: GetDeviceGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.GetDeviceGroupInfoHeaders()
        return self.get_device_group_info_with_options(request, headers, runtime)

    async def get_device_group_info_async(
        self,
        request: dingtalkdevicemng__1__0_models.GetDeviceGroupInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.GetDeviceGroupInfoResponse:
        """
        @summary 获取设备群信息
        
        @param request: GetDeviceGroupInfoRequest
        @return: GetDeviceGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.GetDeviceGroupInfoHeaders()
        return await self.get_device_group_info_with_options_async(request, headers, runtime)

    def get_whole_device_group_with_options(
        self,
        headers: dingtalkdevicemng__1__0_models.GetWholeDeviceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse:
        """
        @summary 获取设备全员群标识
        
        @param headers: GetWholeDeviceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWholeDeviceGroupResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetWholeDeviceGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/wholeGroupId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def get_whole_device_group_with_options_async(
        self,
        headers: dingtalkdevicemng__1__0_models.GetWholeDeviceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse:
        """
        @summary 获取设备全员群标识
        
        @param headers: GetWholeDeviceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWholeDeviceGroupResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetWholeDeviceGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/wholeGroupId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_whole_device_group(self) -> dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse:
        """
        @summary 获取设备全员群标识
        
        @return: GetWholeDeviceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.GetWholeDeviceGroupHeaders()
        return self.get_whole_device_group_with_options(headers, runtime)

    async def get_whole_device_group_async(self) -> dingtalkdevicemng__1__0_models.GetWholeDeviceGroupResponse:
        """
        @summary 获取设备全员群标识
        
        @return: GetWholeDeviceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.GetWholeDeviceGroupHeaders()
        return await self.get_whole_device_group_with_options_async(headers, runtime)

    def list_activate_devices_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.ListActivateDevicesRequest,
        headers: dingtalkdevicemng__1__0_models.ListActivateDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListActivateDevicesResponse:
        """
        @summary 查询激活的设备信息
        
        @param request: ListActivateDevicesRequest
        @param headers: ListActivateDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListActivateDevicesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_category):
            query['deviceCategory'] = request.device_category
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_type_id):
            query['deviceTypeId'] = request.device_type_id
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
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
            action='ListActivateDevices',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/activations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListActivateDevicesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_activate_devices_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListActivateDevicesRequest,
        headers: dingtalkdevicemng__1__0_models.ListActivateDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListActivateDevicesResponse:
        """
        @summary 查询激活的设备信息
        
        @param request: ListActivateDevicesRequest
        @param headers: ListActivateDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListActivateDevicesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_category):
            query['deviceCategory'] = request.device_category
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_type_id):
            query['deviceTypeId'] = request.device_type_id
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
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
            action='ListActivateDevices',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/activations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListActivateDevicesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_activate_devices(
        self,
        request: dingtalkdevicemng__1__0_models.ListActivateDevicesRequest,
    ) -> dingtalkdevicemng__1__0_models.ListActivateDevicesResponse:
        """
        @summary 查询激活的设备信息
        
        @param request: ListActivateDevicesRequest
        @return: ListActivateDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListActivateDevicesHeaders()
        return self.list_activate_devices_with_options(request, headers, runtime)

    async def list_activate_devices_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListActivateDevicesRequest,
    ) -> dingtalkdevicemng__1__0_models.ListActivateDevicesResponse:
        """
        @summary 查询激活的设备信息
        
        @param request: ListActivateDevicesRequest
        @return: ListActivateDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListActivateDevicesHeaders()
        return await self.list_activate_devices_with_options_async(request, headers, runtime)

    def list_inspect_info_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.ListInspectInfoRequest,
        headers: dingtalkdevicemng__1__0_models.ListInspectInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListInspectInfoResponse:
        """
        @summary 获取巡检、保养记录
        
        @param request: ListInspectInfoRequest
        @param headers: ListInspectInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInspectInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ListInspectInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/inspectInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListInspectInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def list_inspect_info_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListInspectInfoRequest,
        headers: dingtalkdevicemng__1__0_models.ListInspectInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListInspectInfoResponse:
        """
        @summary 获取巡检、保养记录
        
        @param request: ListInspectInfoRequest
        @param headers: ListInspectInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInspectInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ListInspectInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/inspectInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListInspectInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_inspect_info(
        self,
        request: dingtalkdevicemng__1__0_models.ListInspectInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.ListInspectInfoResponse:
        """
        @summary 获取巡检、保养记录
        
        @param request: ListInspectInfoRequest
        @return: ListInspectInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListInspectInfoHeaders()
        return self.list_inspect_info_with_options(request, headers, runtime)

    async def list_inspect_info_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListInspectInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.ListInspectInfoResponse:
        """
        @summary 获取巡检、保养记录
        
        @param request: ListInspectInfoRequest
        @return: ListInspectInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListInspectInfoHeaders()
        return await self.list_inspect_info_with_options_async(request, headers, runtime)

    def list_maintain_info_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.ListMaintainInfoRequest,
        headers: dingtalkdevicemng__1__0_models.ListMaintainInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListMaintainInfoResponse:
        """
        @summary 获取报修信息
        
        @param request: ListMaintainInfoRequest
        @param headers: ListMaintainInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMaintainInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='ListMaintainInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/maintainInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListMaintainInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def list_maintain_info_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListMaintainInfoRequest,
        headers: dingtalkdevicemng__1__0_models.ListMaintainInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.ListMaintainInfoResponse:
        """
        @summary 获取报修信息
        
        @param request: ListMaintainInfoRequest
        @param headers: ListMaintainInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMaintainInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
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
            action='ListMaintainInfo',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/maintainInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.ListMaintainInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_maintain_info(
        self,
        request: dingtalkdevicemng__1__0_models.ListMaintainInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.ListMaintainInfoResponse:
        """
        @summary 获取报修信息
        
        @param request: ListMaintainInfoRequest
        @return: ListMaintainInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListMaintainInfoHeaders()
        return self.list_maintain_info_with_options(request, headers, runtime)

    async def list_maintain_info_async(
        self,
        request: dingtalkdevicemng__1__0_models.ListMaintainInfoRequest,
    ) -> dingtalkdevicemng__1__0_models.ListMaintainInfoResponse:
        """
        @summary 获取报修信息
        
        @param request: ListMaintainInfoRequest
        @return: ListMaintainInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.ListMaintainInfoHeaders()
        return await self.list_maintain_info_with_options_async(request, headers, runtime)

    def pull_device_to_group_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.PullDeviceToGroupRequest,
        headers: dingtalkdevicemng__1__0_models.PullDeviceToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse:
        """
        @summary 拉设备进群
        
        @param request: PullDeviceToGroupRequest
        @param headers: PullDeviceToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDeviceToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='PullDeviceToGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def pull_device_to_group_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.PullDeviceToGroupRequest,
        headers: dingtalkdevicemng__1__0_models.PullDeviceToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse:
        """
        @summary 拉设备进群
        
        @param request: PullDeviceToGroupRequest
        @param headers: PullDeviceToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDeviceToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='PullDeviceToGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pull_device_to_group(
        self,
        request: dingtalkdevicemng__1__0_models.PullDeviceToGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse:
        """
        @summary 拉设备进群
        
        @param request: PullDeviceToGroupRequest
        @return: PullDeviceToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.PullDeviceToGroupHeaders()
        return self.pull_device_to_group_with_options(request, headers, runtime)

    async def pull_device_to_group_async(
        self,
        request: dingtalkdevicemng__1__0_models.PullDeviceToGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.PullDeviceToGroupResponse:
        """
        @summary 拉设备进群
        
        @param request: PullDeviceToGroupRequest
        @return: PullDeviceToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.PullDeviceToGroupHeaders()
        return await self.pull_device_to_group_with_options_async(request, headers, runtime)

    def pull_user_to_group_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.PullUserToGroupRequest,
        headers: dingtalkdevicemng__1__0_models.PullUserToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.PullUserToGroupResponse:
        """
        @summary 拉设用户进群
        
        @param request: PullUserToGroupRequest
        @param headers: PullUserToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullUserToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='PullUserToGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.PullUserToGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def pull_user_to_group_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.PullUserToGroupRequest,
        headers: dingtalkdevicemng__1__0_models.PullUserToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.PullUserToGroupResponse:
        """
        @summary 拉设用户进群
        
        @param request: PullUserToGroupRequest
        @param headers: PullUserToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullUserToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='PullUserToGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.PullUserToGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pull_user_to_group(
        self,
        request: dingtalkdevicemng__1__0_models.PullUserToGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.PullUserToGroupResponse:
        """
        @summary 拉设用户进群
        
        @param request: PullUserToGroupRequest
        @return: PullUserToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.PullUserToGroupHeaders()
        return self.pull_user_to_group_with_options(request, headers, runtime)

    async def pull_user_to_group_async(
        self,
        request: dingtalkdevicemng__1__0_models.PullUserToGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.PullUserToGroupResponse:
        """
        @summary 拉设用户进群
        
        @param request: PullUserToGroupRequest
        @return: PullUserToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.PullUserToGroupHeaders()
        return await self.pull_user_to_group_with_options_async(request, headers, runtime)

    def register_and_activate_device_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse:
        """
        @summary 注册与激活设备
        
        @param request: RegisterAndActivateDeviceRequest
        @param headers: RegisterAndActivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAndActivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_callback_url):
            body['deviceCallbackUrl'] = request.device_callback_url
        if not UtilClient.is_unset(request.device_category):
            body['deviceCategory'] = request.device_category
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_detail_url):
            body['deviceDetailUrl'] = request.device_detail_url
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.role_uuid):
            body['roleUuid'] = request.role_uuid
        if not UtilClient.is_unset(request.type_uuid):
            body['typeUuid'] = request.type_uuid
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='RegisterAndActivateDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/registerAndActivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def register_and_activate_device_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse:
        """
        @summary 注册与激活设备
        
        @param request: RegisterAndActivateDeviceRequest
        @param headers: RegisterAndActivateDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAndActivateDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_callback_url):
            body['deviceCallbackUrl'] = request.device_callback_url
        if not UtilClient.is_unset(request.device_category):
            body['deviceCategory'] = request.device_category
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_detail_url):
            body['deviceDetailUrl'] = request.device_detail_url
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.role_uuid):
            body['roleUuid'] = request.role_uuid
        if not UtilClient.is_unset(request.type_uuid):
            body['typeUuid'] = request.type_uuid
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='RegisterAndActivateDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/registerAndActivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_and_activate_device(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse:
        """
        @summary 注册与激活设备
        
        @param request: RegisterAndActivateDeviceRequest
        @return: RegisterAndActivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceHeaders()
        return self.register_and_activate_device_with_options(request, headers, runtime)

    async def register_and_activate_device_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceResponse:
        """
        @summary 注册与激活设备
        
        @param request: RegisterAndActivateDeviceRequest
        @return: RegisterAndActivateDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceHeaders()
        return await self.register_and_activate_device_with_options_async(request, headers, runtime)

    def register_and_activate_device_batch_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse:
        """
        @summary 批量注册与激活设备
        
        @param request: RegisterAndActivateDeviceBatchRequest
        @param headers: RegisterAndActivateDeviceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAndActivateDeviceBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.register_and_activate_vos):
            body['registerAndActivateVOS'] = request.register_and_activate_vos
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
            action='RegisterAndActivateDeviceBatch',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/registrationActivations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse(),
            self.execute(params, req, runtime)
        )

    async def register_and_activate_device_batch_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse:
        """
        @summary 批量注册与激活设备
        
        @param request: RegisterAndActivateDeviceBatchRequest
        @param headers: RegisterAndActivateDeviceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAndActivateDeviceBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.register_and_activate_vos):
            body['registerAndActivateVOS'] = request.register_and_activate_vos
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
            action='RegisterAndActivateDeviceBatch',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/registrationActivations/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_and_activate_device_batch(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse:
        """
        @summary 批量注册与激活设备
        
        @param request: RegisterAndActivateDeviceBatchRequest
        @return: RegisterAndActivateDeviceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchHeaders()
        return self.register_and_activate_device_batch_with_options(request, headers, runtime)

    async def register_and_activate_device_batch_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchResponse:
        """
        @summary 批量注册与激活设备
        
        @param request: RegisterAndActivateDeviceBatchRequest
        @return: RegisterAndActivateDeviceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterAndActivateDeviceBatchHeaders()
        return await self.register_and_activate_device_batch_with_options_async(request, headers, runtime)

    def register_device_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        """
        @summary 注册设备并为其创建机器人
        
        @param request: RegisterDeviceRequest
        @param headers: RegisterDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.collaborators):
            body['collaborators'] = request.collaborators
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.managers):
            body['managers'] = request.managers
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
            action='RegisterDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def register_device_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
        headers: dingtalkdevicemng__1__0_models.RegisterDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        """
        @summary 注册设备并为其创建机器人
        
        @param request: RegisterDeviceRequest
        @param headers: RegisterDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.collaborators):
            body['collaborators'] = request.collaborators
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.device_key):
            body['deviceKey'] = request.device_key
        if not UtilClient.is_unset(request.device_name):
            body['deviceName'] = request.device_name
        if not UtilClient.is_unset(request.managers):
            body['managers'] = request.managers
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
            action='RegisterDevice',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RegisterDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_device(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        """
        @summary 注册设备并为其创建机器人
        
        @param request: RegisterDeviceRequest
        @return: RegisterDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterDeviceHeaders()
        return self.register_device_with_options(request, headers, runtime)

    async def register_device_async(
        self,
        request: dingtalkdevicemng__1__0_models.RegisterDeviceRequest,
    ) -> dingtalkdevicemng__1__0_models.RegisterDeviceResponse:
        """
        @summary 注册设备并为其创建机器人
        
        @param request: RegisterDeviceRequest
        @return: RegisterDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RegisterDeviceHeaders()
        return await self.register_device_with_options_async(request, headers, runtime)

    def remove_device_from_group_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupRequest,
        headers: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse:
        """
        @summary 移设备出群
        
        @param request: RemoveDeviceFromGroupRequest
        @param headers: RemoveDeviceFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveDeviceFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='RemoveDeviceFromGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/devices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_device_from_group_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupRequest,
        headers: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse:
        """
        @summary 移设备出群
        
        @param request: RemoveDeviceFromGroupRequest
        @param headers: RemoveDeviceFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveDeviceFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_codes):
            body['deviceCodes'] = request.device_codes
        if not UtilClient.is_unset(request.device_uuids):
            body['deviceUuids'] = request.device_uuids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
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
            action='RemoveDeviceFromGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/devices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_device_from_group(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse:
        """
        @summary 移设备出群
        
        @param request: RemoveDeviceFromGroupRequest
        @return: RemoveDeviceFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupHeaders()
        return self.remove_device_from_group_with_options(request, headers, runtime)

    async def remove_device_from_group_async(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupResponse:
        """
        @summary 移设备出群
        
        @param request: RemoveDeviceFromGroupRequest
        @return: RemoveDeviceFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RemoveDeviceFromGroupHeaders()
        return await self.remove_device_from_group_with_options_async(request, headers, runtime)

    def remove_user_from_group_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveUserFromGroupRequest,
        headers: dingtalkdevicemng__1__0_models.RemoveUserFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse:
        """
        @summary 移用户出设备群
        
        @param request: RemoveUserFromGroupRequest
        @param headers: RemoveUserFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveUserFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='RemoveUserFromGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_user_from_group_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveUserFromGroupRequest,
        headers: dingtalkdevicemng__1__0_models.RemoveUserFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse:
        """
        @summary 移用户出设备群
        
        @param request: RemoveUserFromGroupRequest
        @param headers: RemoveUserFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveUserFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='RemoveUserFromGroup',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/chatRooms/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_user_from_group(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveUserFromGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse:
        """
        @summary 移用户出设备群
        
        @param request: RemoveUserFromGroupRequest
        @return: RemoveUserFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RemoveUserFromGroupHeaders()
        return self.remove_user_from_group_with_options(request, headers, runtime)

    async def remove_user_from_group_async(
        self,
        request: dingtalkdevicemng__1__0_models.RemoveUserFromGroupRequest,
    ) -> dingtalkdevicemng__1__0_models.RemoveUserFromGroupResponse:
        """
        @summary 移用户出设备群
        
        @param request: RemoveUserFromGroupRequest
        @return: RemoveUserFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.RemoveUserFromGroupHeaders()
        return await self.remove_user_from_group_with_options_async(request, headers, runtime)

    def send_card_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.SendCardRequest,
        headers: dingtalkdevicemng__1__0_models.SendCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.SendCardResponse:
        """
        @summary 发送卡片
        
        @param request: SendCardRequest
        @param headers: SendCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.part_visible):
            body['partVisible'] = request.part_visible
        if not UtilClient.is_unset(request.receivers):
            body['receivers'] = request.receivers
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.topbox):
            body['topbox'] = request.topbox
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
            action='SendCard',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.SendCardResponse(),
            self.execute(params, req, runtime)
        )

    async def send_card_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.SendCardRequest,
        headers: dingtalkdevicemng__1__0_models.SendCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.SendCardResponse:
        """
        @summary 发送卡片
        
        @param request: SendCardRequest
        @param headers: SendCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.part_visible):
            body['partVisible'] = request.part_visible
        if not UtilClient.is_unset(request.receivers):
            body['receivers'] = request.receivers
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.topbox):
            body['topbox'] = request.topbox
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
            action='SendCard',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.SendCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_card(
        self,
        request: dingtalkdevicemng__1__0_models.SendCardRequest,
    ) -> dingtalkdevicemng__1__0_models.SendCardResponse:
        """
        @summary 发送卡片
        
        @param request: SendCardRequest
        @return: SendCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.SendCardHeaders()
        return self.send_card_with_options(request, headers, runtime)

    async def send_card_async(
        self,
        request: dingtalkdevicemng__1__0_models.SendCardRequest,
    ) -> dingtalkdevicemng__1__0_models.SendCardResponse:
        """
        @summary 发送卡片
        
        @param request: SendCardRequest
        @return: SendCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.SendCardHeaders()
        return await self.send_card_with_options_async(request, headers, runtime)

    def send_msg_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.SendMsgRequest,
        headers: dingtalkdevicemng__1__0_models.SendMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.SendMsgResponse:
        """
        @summary 发送普通消息
        
        @param request: SendMsgRequest
        @param headers: SendMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='SendMsg',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.SendMsgResponse(),
            self.execute(params, req, runtime)
        )

    async def send_msg_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.SendMsgRequest,
        headers: dingtalkdevicemng__1__0_models.SendMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.SendMsgResponse:
        """
        @summary 发送普通消息
        
        @param request: SendMsgRequest
        @param headers: SendMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='SendMsg',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.SendMsgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_msg(
        self,
        request: dingtalkdevicemng__1__0_models.SendMsgRequest,
    ) -> dingtalkdevicemng__1__0_models.SendMsgResponse:
        """
        @summary 发送普通消息
        
        @param request: SendMsgRequest
        @return: SendMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.SendMsgHeaders()
        return self.send_msg_with_options(request, headers, runtime)

    async def send_msg_async(
        self,
        request: dingtalkdevicemng__1__0_models.SendMsgRequest,
    ) -> dingtalkdevicemng__1__0_models.SendMsgResponse:
        """
        @summary 发送普通消息
        
        @param request: SendMsgRequest
        @return: SendMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.SendMsgHeaders()
        return await self.send_msg_with_options_async(request, headers, runtime)

    def uninstall_device_robot_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.UninstallDeviceRobotRequest,
        headers: dingtalkdevicemng__1__0_models.UninstallDeviceRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse:
        """
        @summary 卸载设备
        
        @param request: UninstallDeviceRobotRequest
        @param headers: UninstallDeviceRobotHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UninstallDeviceRobotResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='UninstallDeviceRobot',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse(),
            self.execute(params, req, runtime)
        )

    async def uninstall_device_robot_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.UninstallDeviceRobotRequest,
        headers: dingtalkdevicemng__1__0_models.UninstallDeviceRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse:
        """
        @summary 卸载设备
        
        @param request: UninstallDeviceRobotRequest
        @param headers: UninstallDeviceRobotHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UninstallDeviceRobotResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='UninstallDeviceRobot',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/devices/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse(),
            await self.execute_async(params, req, runtime)
        )

    def uninstall_device_robot(
        self,
        request: dingtalkdevicemng__1__0_models.UninstallDeviceRobotRequest,
    ) -> dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse:
        """
        @summary 卸载设备
        
        @param request: UninstallDeviceRobotRequest
        @return: UninstallDeviceRobotResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UninstallDeviceRobotHeaders()
        return self.uninstall_device_robot_with_options(request, headers, runtime)

    async def uninstall_device_robot_async(
        self,
        request: dingtalkdevicemng__1__0_models.UninstallDeviceRobotRequest,
    ) -> dingtalkdevicemng__1__0_models.UninstallDeviceRobotResponse:
        """
        @summary 卸载设备
        
        @param request: UninstallDeviceRobotRequest
        @return: UninstallDeviceRobotResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UninstallDeviceRobotHeaders()
        return await self.uninstall_device_robot_with_options_async(request, headers, runtime)

    def update_card_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.UpdateCardRequest,
        headers: dingtalkdevicemng__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @param headers: UpdateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.tips):
            body['tips'] = request.tips
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
            action='UpdateCard',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/cards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UpdateCardResponse(),
            self.execute(params, req, runtime)
        )

    async def update_card_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.UpdateCardRequest,
        headers: dingtalkdevicemng__1__0_models.UpdateCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @param headers: UpdateCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.tips):
            body['tips'] = request.tips
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
            action='UpdateCard',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/customers/cards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UpdateCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_card(
        self,
        request: dingtalkdevicemng__1__0_models.UpdateCardRequest,
    ) -> dingtalkdevicemng__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @return: UpdateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UpdateCardHeaders()
        return self.update_card_with_options(request, headers, runtime)

    async def update_card_async(
        self,
        request: dingtalkdevicemng__1__0_models.UpdateCardRequest,
    ) -> dingtalkdevicemng__1__0_models.UpdateCardResponse:
        """
        @summary 更新卡片
        
        @param request: UpdateCardRequest
        @return: UpdateCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UpdateCardHeaders()
        return await self.update_card_with_options_async(request, headers, runtime)

    def upload_event_with_options(
        self,
        request: dingtalkdevicemng__1__0_models.UploadEventRequest,
        headers: dingtalkdevicemng__1__0_models.UploadEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UploadEventResponse:
        """
        @summary 设备事件上报
        
        @param request: UploadEventRequest
        @param headers: UploadEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.event_time):
            body['eventTime'] = request.event_time
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        if not UtilClient.is_unset(request.level):
            body['level'] = request.level
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
            action='UploadEvent',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/suppliers/events/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UploadEventResponse(),
            self.execute(params, req, runtime)
        )

    async def upload_event_with_options_async(
        self,
        request: dingtalkdevicemng__1__0_models.UploadEventRequest,
        headers: dingtalkdevicemng__1__0_models.UploadEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdevicemng__1__0_models.UploadEventResponse:
        """
        @summary 设备事件上报
        
        @param request: UploadEventRequest
        @param headers: UploadEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UploadEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.device_code):
            body['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_uuid):
            body['deviceUuid'] = request.device_uuid
        if not UtilClient.is_unset(request.event_time):
            body['eventTime'] = request.event_time
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        if not UtilClient.is_unset(request.level):
            body['level'] = request.level
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
            action='UploadEvent',
            version='devicemng_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/devicemng/suppliers/events/upload',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdevicemng__1__0_models.UploadEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upload_event(
        self,
        request: dingtalkdevicemng__1__0_models.UploadEventRequest,
    ) -> dingtalkdevicemng__1__0_models.UploadEventResponse:
        """
        @summary 设备事件上报
        
        @param request: UploadEventRequest
        @return: UploadEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UploadEventHeaders()
        return self.upload_event_with_options(request, headers, runtime)

    async def upload_event_async(
        self,
        request: dingtalkdevicemng__1__0_models.UploadEventRequest,
    ) -> dingtalkdevicemng__1__0_models.UploadEventResponse:
        """
        @summary 设备事件上报
        
        @param request: UploadEventRequest
        @return: UploadEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdevicemng__1__0_models.UploadEventHeaders()
        return await self.upload_event_with_options_async(request, headers, runtime)
