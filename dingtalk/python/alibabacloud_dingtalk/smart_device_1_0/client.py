# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.smart_device_1_0 import models as dingtalksmart_device__1__0_models
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

    def add_device_video_conference_members_with_options(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        """
        @summary 添加硬件视频会议参会人
        
        @param request: AddDeviceVideoConferenceMembersRequest
        @param headers: AddDeviceVideoConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDeviceVideoConferenceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='AddDeviceVideoConferenceMembers',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def add_device_video_conference_members_with_options_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        """
        @summary 添加硬件视频会议参会人
        
        @param request: AddDeviceVideoConferenceMembersRequest
        @param headers: AddDeviceVideoConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDeviceVideoConferenceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='AddDeviceVideoConferenceMembers',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_device_video_conference_members(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        """
        @summary 添加硬件视频会议参会人
        
        @param request: AddDeviceVideoConferenceMembersRequest
        @return: AddDeviceVideoConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders()
        return self.add_device_video_conference_members_with_options(device_id, conference_id, request, headers, runtime)

    async def add_device_video_conference_members_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        """
        @summary 添加硬件视频会议参会人
        
        @param request: AddDeviceVideoConferenceMembersRequest
        @return: AddDeviceVideoConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders()
        return await self.add_device_video_conference_members_with_options_async(device_id, conference_id, request, headers, runtime)

    def create_device_video_conference_with_options(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
        headers: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        """
        @summary 创建硬件视频会议
        
        @param request: CreateDeviceVideoConferenceRequest
        @param headers: CreateDeviceVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceVideoConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='CreateDeviceVideoConference',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_device_video_conference_with_options_async(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
        headers: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        """
        @summary 创建硬件视频会议
        
        @param request: CreateDeviceVideoConferenceRequest
        @param headers: CreateDeviceVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceVideoConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='CreateDeviceVideoConference',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_device_video_conference(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        """
        @summary 创建硬件视频会议
        
        @param request: CreateDeviceVideoConferenceRequest
        @return: CreateDeviceVideoConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders()
        return self.create_device_video_conference_with_options(device_id, request, headers, runtime)

    async def create_device_video_conference_async(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        """
        @summary 创建硬件视频会议
        
        @param request: CreateDeviceVideoConferenceRequest
        @return: CreateDeviceVideoConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders()
        return await self.create_device_video_conference_with_options_async(device_id, request, headers, runtime)

    def extract_facial_feature_with_options(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
        headers: dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        """
        @summary 基于企业员工照片为终端提取人脸识别特征
        
        @param request: ExtractFacialFeatureRequest
        @param headers: ExtractFacialFeatureHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExtractFacialFeatureResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='ExtractFacialFeature',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/faceRecognitions/features/extract',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse(),
            self.execute(params, req, runtime)
        )

    async def extract_facial_feature_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
        headers: dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        """
        @summary 基于企业员工照片为终端提取人脸识别特征
        
        @param request: ExtractFacialFeatureRequest
        @param headers: ExtractFacialFeatureHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExtractFacialFeatureResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='ExtractFacialFeature',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/faceRecognitions/features/extract',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse(),
            await self.execute_async(params, req, runtime)
        )

    def extract_facial_feature(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        """
        @summary 基于企业员工照片为终端提取人脸识别特征
        
        @param request: ExtractFacialFeatureRequest
        @return: ExtractFacialFeatureResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders()
        return self.extract_facial_feature_with_options(request, headers, runtime)

    async def extract_facial_feature_async(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        """
        @summary 基于企业员工照片为终端提取人脸识别特征
        
        @param request: ExtractFacialFeatureRequest
        @return: ExtractFacialFeatureResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders()
        return await self.extract_facial_feature_with_options_async(request, headers, runtime)

    def kick_device_video_conference_members_with_options(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        """
        @summary 踢出硬件视频会议参会人
        
        @param request: KickDeviceVideoConferenceMembersRequest
        @param headers: KickDeviceVideoConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: KickDeviceVideoConferenceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='KickDeviceVideoConferenceMembers',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def kick_device_video_conference_members_with_options_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        """
        @summary 踢出硬件视频会议参会人
        
        @param request: KickDeviceVideoConferenceMembersRequest
        @param headers: KickDeviceVideoConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: KickDeviceVideoConferenceMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='KickDeviceVideoConferenceMembers',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def kick_device_video_conference_members(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        """
        @summary 踢出硬件视频会议参会人
        
        @param request: KickDeviceVideoConferenceMembersRequest
        @return: KickDeviceVideoConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders()
        return self.kick_device_video_conference_members_with_options(device_id, conference_id, request, headers, runtime)

    async def kick_device_video_conference_members_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        """
        @summary 踢出硬件视频会议参会人
        
        @param request: KickDeviceVideoConferenceMembersRequest
        @return: KickDeviceVideoConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders()
        return await self.kick_device_video_conference_members_with_options_async(device_id, conference_id, request, headers, runtime)

    def machine_manager_update_with_options(
        self,
        request: dingtalksmart_device__1__0_models.MachineManagerUpdateRequest,
        headers: dingtalksmart_device__1__0_models.MachineManagerUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.MachineManagerUpdateResponse:
        """
        @summary 变更智能考勤机设备管理员
        
        @param request: MachineManagerUpdateRequest
        @param headers: MachineManagerUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MachineManagerUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.atm_manager_right_map):
            body['atmManagerRightMap'] = request.atm_manager_right_map
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.scope_dept_ids):
            body['scopeDeptIds'] = request.scope_dept_ids
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
            action='MachineManagerUpdate',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/atmachines/managers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.MachineManagerUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def machine_manager_update_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.MachineManagerUpdateRequest,
        headers: dingtalksmart_device__1__0_models.MachineManagerUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.MachineManagerUpdateResponse:
        """
        @summary 变更智能考勤机设备管理员
        
        @param request: MachineManagerUpdateRequest
        @param headers: MachineManagerUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MachineManagerUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.atm_manager_right_map):
            body['atmManagerRightMap'] = request.atm_manager_right_map
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.scope_dept_ids):
            body['scopeDeptIds'] = request.scope_dept_ids
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
            action='MachineManagerUpdate',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/atmachines/managers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.MachineManagerUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def machine_manager_update(
        self,
        request: dingtalksmart_device__1__0_models.MachineManagerUpdateRequest,
    ) -> dingtalksmart_device__1__0_models.MachineManagerUpdateResponse:
        """
        @summary 变更智能考勤机设备管理员
        
        @param request: MachineManagerUpdateRequest
        @return: MachineManagerUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.MachineManagerUpdateHeaders()
        return self.machine_manager_update_with_options(request, headers, runtime)

    async def machine_manager_update_async(
        self,
        request: dingtalksmart_device__1__0_models.MachineManagerUpdateRequest,
    ) -> dingtalksmart_device__1__0_models.MachineManagerUpdateResponse:
        """
        @summary 变更智能考勤机设备管理员
        
        @param request: MachineManagerUpdateRequest
        @return: MachineManagerUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.MachineManagerUpdateHeaders()
        return await self.machine_manager_update_with_options_async(request, headers, runtime)

    def machine_users_update_with_options(
        self,
        request: dingtalksmart_device__1__0_models.MachineUsersUpdateRequest,
        headers: dingtalksmart_device__1__0_models.MachineUsersUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.MachineUsersUpdateResponse:
        """
        @summary 变更智能考勤机员工
        
        @param request: MachineUsersUpdateRequest
        @param headers: MachineUsersUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MachineUsersUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_dept_ids):
            body['addDeptIds'] = request.add_dept_ids
        if not UtilClient.is_unset(request.add_user_ids):
            body['addUserIds'] = request.add_user_ids
        if not UtilClient.is_unset(request.del_dept_ids):
            body['delDeptIds'] = request.del_dept_ids
        if not UtilClient.is_unset(request.del_user_ids):
            body['delUserIds'] = request.del_user_ids
        if not UtilClient.is_unset(request.dev_ids):
            body['devIds'] = request.dev_ids
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
            action='MachineUsersUpdate',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/atmachines/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.MachineUsersUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def machine_users_update_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.MachineUsersUpdateRequest,
        headers: dingtalksmart_device__1__0_models.MachineUsersUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.MachineUsersUpdateResponse:
        """
        @summary 变更智能考勤机员工
        
        @param request: MachineUsersUpdateRequest
        @param headers: MachineUsersUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MachineUsersUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_dept_ids):
            body['addDeptIds'] = request.add_dept_ids
        if not UtilClient.is_unset(request.add_user_ids):
            body['addUserIds'] = request.add_user_ids
        if not UtilClient.is_unset(request.del_dept_ids):
            body['delDeptIds'] = request.del_dept_ids
        if not UtilClient.is_unset(request.del_user_ids):
            body['delUserIds'] = request.del_user_ids
        if not UtilClient.is_unset(request.dev_ids):
            body['devIds'] = request.dev_ids
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
            action='MachineUsersUpdate',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/atmachines/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.MachineUsersUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def machine_users_update(
        self,
        request: dingtalksmart_device__1__0_models.MachineUsersUpdateRequest,
    ) -> dingtalksmart_device__1__0_models.MachineUsersUpdateResponse:
        """
        @summary 变更智能考勤机员工
        
        @param request: MachineUsersUpdateRequest
        @return: MachineUsersUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.MachineUsersUpdateHeaders()
        return self.machine_users_update_with_options(request, headers, runtime)

    async def machine_users_update_async(
        self,
        request: dingtalksmart_device__1__0_models.MachineUsersUpdateRequest,
    ) -> dingtalksmart_device__1__0_models.MachineUsersUpdateResponse:
        """
        @summary 变更智能考勤机员工
        
        @param request: MachineUsersUpdateRequest
        @return: MachineUsersUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.MachineUsersUpdateHeaders()
        return await self.machine_users_update_with_options_async(request, headers, runtime)

    def query_device_video_conference_book_with_options(
        self,
        device_id: str,
        book_id: str,
        headers: dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        """
        @summary 查询硬件视频会议预约信息
        
        @param headers: QueryDeviceVideoConferenceBookHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceVideoConferenceBookResponse
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
            action='QueryDeviceVideoConferenceBook',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/books/{book_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_video_conference_book_with_options_async(
        self,
        device_id: str,
        book_id: str,
        headers: dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        """
        @summary 查询硬件视频会议预约信息
        
        @param headers: QueryDeviceVideoConferenceBookHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceVideoConferenceBookResponse
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
            action='QueryDeviceVideoConferenceBook',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/devices/{device_id}/books/{book_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_video_conference_book(
        self,
        device_id: str,
        book_id: str,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        """
        @summary 查询硬件视频会议预约信息
        
        @return: QueryDeviceVideoConferenceBookResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders()
        return self.query_device_video_conference_book_with_options(device_id, book_id, headers, runtime)

    async def query_device_video_conference_book_async(
        self,
        device_id: str,
        book_id: str,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        """
        @summary 查询硬件视频会议预约信息
        
        @return: QueryDeviceVideoConferenceBookResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders()
        return await self.query_device_video_conference_book_with_options_async(device_id, book_id, headers, runtime)

    def text_to_image_with_options(
        self,
        request: dingtalksmart_device__1__0_models.TextToImageRequest,
        headers: dingtalksmart_device__1__0_models.TextToImageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.TextToImageResponse:
        """
        @summary 文生图开放接口
        
        @param request: TextToImageRequest
        @param headers: TextToImageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TextToImageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.picture_num):
            body['pictureNum'] = request.picture_num
        if not UtilClient.is_unset(request.picture_size):
            body['pictureSize'] = request.picture_size
        if not UtilClient.is_unset(request.query):
            body['query'] = request.query
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
            action='TextToImage',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/textToImages/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.TextToImageResponse(),
            self.execute(params, req, runtime)
        )

    async def text_to_image_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.TextToImageRequest,
        headers: dingtalksmart_device__1__0_models.TextToImageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.TextToImageResponse:
        """
        @summary 文生图开放接口
        
        @param request: TextToImageRequest
        @param headers: TextToImageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TextToImageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.picture_num):
            body['pictureNum'] = request.picture_num
        if not UtilClient.is_unset(request.picture_size):
            body['pictureSize'] = request.picture_size
        if not UtilClient.is_unset(request.query):
            body['query'] = request.query
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
            action='TextToImage',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/textToImages/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.TextToImageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def text_to_image(
        self,
        request: dingtalksmart_device__1__0_models.TextToImageRequest,
    ) -> dingtalksmart_device__1__0_models.TextToImageResponse:
        """
        @summary 文生图开放接口
        
        @param request: TextToImageRequest
        @return: TextToImageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.TextToImageHeaders()
        return self.text_to_image_with_options(request, headers, runtime)

    async def text_to_image_async(
        self,
        request: dingtalksmart_device__1__0_models.TextToImageRequest,
    ) -> dingtalksmart_device__1__0_models.TextToImageResponse:
        """
        @summary 文生图开放接口
        
        @param request: TextToImageRequest
        @return: TextToImageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.TextToImageHeaders()
        return await self.text_to_image_with_options_async(request, headers, runtime)

    def voice_clone_with_options(
        self,
        request: dingtalksmart_device__1__0_models.VoiceCloneRequest,
        headers: dingtalksmart_device__1__0_models.VoiceCloneHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.VoiceCloneResponse:
        """
        @summary 音频复刻
        
        @param request: VoiceCloneRequest
        @param headers: VoiceCloneHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: VoiceCloneResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.voice_id):
            body['voiceId'] = request.voice_id
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
            action='VoiceClone',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/voices/clone',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.VoiceCloneResponse(),
            self.execute(params, req, runtime)
        )

    async def voice_clone_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.VoiceCloneRequest,
        headers: dingtalksmart_device__1__0_models.VoiceCloneHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.VoiceCloneResponse:
        """
        @summary 音频复刻
        
        @param request: VoiceCloneRequest
        @param headers: VoiceCloneHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: VoiceCloneResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.voice_id):
            body['voiceId'] = request.voice_id
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
            action='VoiceClone',
            version='smartDevice_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/smartDevice/voices/clone',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.VoiceCloneResponse(),
            await self.execute_async(params, req, runtime)
        )

    def voice_clone(
        self,
        request: dingtalksmart_device__1__0_models.VoiceCloneRequest,
    ) -> dingtalksmart_device__1__0_models.VoiceCloneResponse:
        """
        @summary 音频复刻
        
        @param request: VoiceCloneRequest
        @return: VoiceCloneResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.VoiceCloneHeaders()
        return self.voice_clone_with_options(request, headers, runtime)

    async def voice_clone_async(
        self,
        request: dingtalksmart_device__1__0_models.VoiceCloneRequest,
    ) -> dingtalksmart_device__1__0_models.VoiceCloneResponse:
        """
        @summary 音频复刻
        
        @param request: VoiceCloneRequest
        @return: VoiceCloneResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.VoiceCloneHeaders()
        return await self.voice_clone_with_options_async(request, headers, runtime)
