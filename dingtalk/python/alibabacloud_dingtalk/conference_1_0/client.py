# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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

    def add_record_permission_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.AddRecordPermissionRequest,
        headers: dingtalkconference__1__0_models.AddRecordPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.AddRecordPermissionResponse:
        """
        @summary 增加闪记权限
        
        @param request: AddRecordPermissionRequest
        @param headers: AddRecordPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRecordPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
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
            action='AddRecordPermission',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/recordPermissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.AddRecordPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def add_record_permission_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.AddRecordPermissionRequest,
        headers: dingtalkconference__1__0_models.AddRecordPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.AddRecordPermissionResponse:
        """
        @summary 增加闪记权限
        
        @param request: AddRecordPermissionRequest
        @param headers: AddRecordPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRecordPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
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
            action='AddRecordPermission',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/recordPermissions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.AddRecordPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_record_permission(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.AddRecordPermissionRequest,
    ) -> dingtalkconference__1__0_models.AddRecordPermissionResponse:
        """
        @summary 增加闪记权限
        
        @param request: AddRecordPermissionRequest
        @return: AddRecordPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.AddRecordPermissionHeaders()
        return self.add_record_permission_with_options(conference_id, request, headers, runtime)

    async def add_record_permission_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.AddRecordPermissionRequest,
    ) -> dingtalkconference__1__0_models.AddRecordPermissionResponse:
        """
        @summary 增加闪记权限
        
        @param request: AddRecordPermissionRequest
        @return: AddRecordPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.AddRecordPermissionHeaders()
        return await self.add_record_permission_with_options_async(conference_id, request, headers, runtime)

    def cancel_schedule_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.CancelScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.CancelScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CancelScheduleConferenceResponse:
        """
        @summary 取消预约会议
        
        @param request: CancelScheduleConferenceRequest
        @param headers: CancelScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
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
            action='CancelScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CancelScheduleConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_schedule_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.CancelScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.CancelScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CancelScheduleConferenceResponse:
        """
        @summary 取消预约会议
        
        @param request: CancelScheduleConferenceRequest
        @param headers: CancelScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
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
            action='CancelScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CancelScheduleConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_schedule_conference(
        self,
        request: dingtalkconference__1__0_models.CancelScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.CancelScheduleConferenceResponse:
        """
        @summary 取消预约会议
        
        @param request: CancelScheduleConferenceRequest
        @return: CancelScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CancelScheduleConferenceHeaders()
        return self.cancel_schedule_conference_with_options(request, headers, runtime)

    async def cancel_schedule_conference_async(
        self,
        request: dingtalkconference__1__0_models.CancelScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.CancelScheduleConferenceResponse:
        """
        @summary 取消预约会议
        
        @param request: CancelScheduleConferenceRequest
        @return: CancelScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CancelScheduleConferenceHeaders()
        return await self.cancel_schedule_conference_with_options_async(request, headers, runtime)

    def close_video_conference_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CloseVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        """
        @summary 关闭视频会议
        
        @param request: CloseVideoConferenceRequest
        @param headers: CloseVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseVideoConferenceResponse
        """
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
        """
        @summary 关闭视频会议
        
        @param request: CloseVideoConferenceRequest
        @param headers: CloseVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseVideoConferenceResponse
        """
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
        """
        @summary 关闭视频会议
        
        @param request: CloseVideoConferenceRequest
        @return: CloseVideoConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CloseVideoConferenceHeaders()
        return self.close_video_conference_with_options(conference_id, request, headers, runtime)

    async def close_video_conference_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        """
        @summary 关闭视频会议
        
        @param request: CloseVideoConferenceRequest
        @return: CloseVideoConferenceResponse
        """
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
        """
        @summary 设置联席主持人
        
        @param request: CohostsRequest
        @param headers: CohostsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CohostsResponse
        """
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
        """
        @summary 设置联席主持人
        
        @param request: CohostsRequest
        @param headers: CohostsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CohostsResponse
        """
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
        """
        @summary 设置联席主持人
        
        @param request: CohostsRequest
        @return: CohostsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CohostsHeaders()
        return self.cohosts_with_options(conference_id, request, headers, runtime)

    async def cohosts_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CohostsRequest,
    ) -> dingtalkconference__1__0_models.CohostsResponse:
        """
        @summary 设置联席主持人
        
        @param request: CohostsRequest
        @return: CohostsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CohostsHeaders()
        return await self.cohosts_with_options_async(conference_id, request, headers, runtime)

    def create_custom_short_link_with_options(
        self,
        request: dingtalkconference__1__0_models.CreateCustomShortLinkRequest,
        headers: dingtalkconference__1__0_models.CreateCustomShortLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateCustomShortLinkResponse:
        """
        @summary 创建专属短链
        
        @param request: CreateCustomShortLinkRequest
        @param headers: CreateCustomShortLinkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomShortLinkResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.extension_app_biz_data):
            body['extensionAppBizData'] = request.extension_app_biz_data
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
        if not UtilClient.is_unset(request.use_extension_app):
            body['useExtensionApp'] = request.use_extension_app
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
            action='CreateCustomShortLink',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/customShortLinks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateCustomShortLinkResponse(),
            self.execute(params, req, runtime)
        )

    async def create_custom_short_link_with_options_async(
        self,
        request: dingtalkconference__1__0_models.CreateCustomShortLinkRequest,
        headers: dingtalkconference__1__0_models.CreateCustomShortLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateCustomShortLinkResponse:
        """
        @summary 创建专属短链
        
        @param request: CreateCustomShortLinkRequest
        @param headers: CreateCustomShortLinkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCustomShortLinkResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.extension_app_biz_data):
            body['extensionAppBizData'] = request.extension_app_biz_data
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
        if not UtilClient.is_unset(request.use_extension_app):
            body['useExtensionApp'] = request.use_extension_app
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
            action='CreateCustomShortLink',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/customShortLinks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateCustomShortLinkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_custom_short_link(
        self,
        request: dingtalkconference__1__0_models.CreateCustomShortLinkRequest,
    ) -> dingtalkconference__1__0_models.CreateCustomShortLinkResponse:
        """
        @summary 创建专属短链
        
        @param request: CreateCustomShortLinkRequest
        @return: CreateCustomShortLinkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateCustomShortLinkHeaders()
        return self.create_custom_short_link_with_options(request, headers, runtime)

    async def create_custom_short_link_async(
        self,
        request: dingtalkconference__1__0_models.CreateCustomShortLinkRequest,
    ) -> dingtalkconference__1__0_models.CreateCustomShortLinkResponse:
        """
        @summary 创建专属短链
        
        @param request: CreateCustomShortLinkRequest
        @return: CreateCustomShortLinkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateCustomShortLinkHeaders()
        return await self.create_custom_short_link_with_options_async(request, headers, runtime)

    def create_schedule_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.CreateScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateScheduleConferenceResponse:
        """
        @summary 创建预约会议
        
        @param request: CreateScheduleConferenceRequest
        @param headers: CreateScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.schedule_conf_setting_model):
            body['scheduleConfSettingModel'] = request.schedule_conf_setting_model
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateScheduleConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_schedule_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.CreateScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateScheduleConferenceResponse:
        """
        @summary 创建预约会议
        
        @param request: CreateScheduleConferenceRequest
        @param headers: CreateScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.schedule_conf_setting_model):
            body['scheduleConfSettingModel'] = request.schedule_conf_setting_model
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CreateScheduleConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_schedule_conference(
        self,
        request: dingtalkconference__1__0_models.CreateScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateScheduleConferenceResponse:
        """
        @summary 创建预约会议
        
        @param request: CreateScheduleConferenceRequest
        @return: CreateScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateScheduleConferenceHeaders()
        return self.create_schedule_conference_with_options(request, headers, runtime)

    async def create_schedule_conference_async(
        self,
        request: dingtalkconference__1__0_models.CreateScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateScheduleConferenceResponse:
        """
        @summary 创建预约会议
        
        @param request: CreateScheduleConferenceRequest
        @return: CreateScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateScheduleConferenceHeaders()
        return await self.create_schedule_conference_with_options_async(request, headers, runtime)

    def create_video_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        """
        @summary 创建视频会议
        
        @param request: CreateVideoConferenceRequest
        @param headers: CreateVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVideoConferenceResponse
        """
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
        """
        @summary 创建视频会议
        
        @param request: CreateVideoConferenceRequest
        @param headers: CreateVideoConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVideoConferenceResponse
        """
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
        """
        @summary 创建视频会议
        
        @param request: CreateVideoConferenceRequest
        @return: CreateVideoConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateVideoConferenceHeaders()
        return self.create_video_conference_with_options(request, headers, runtime)

    async def create_video_conference_async(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        """
        @summary 创建视频会议
        
        @param request: CreateVideoConferenceRequest
        @return: CreateVideoConferenceResponse
        """
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
        """
        @summary 设置全员看他
        
        @param request: FocusRequest
        @param headers: FocusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FocusResponse
        """
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
        """
        @summary 设置全员看他
        
        @param request: FocusRequest
        @param headers: FocusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FocusResponse
        """
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
        """
        @summary 设置全员看他
        
        @param request: FocusRequest
        @return: FocusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.FocusHeaders()
        return self.focus_with_options(conference_id, request, headers, runtime)

    async def focus_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.FocusRequest,
    ) -> dingtalkconference__1__0_models.FocusResponse:
        """
        @summary 设置全员看他
        
        @param request: FocusRequest
        @return: FocusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.FocusHeaders()
        return await self.focus_with_options_async(conference_id, request, headers, runtime)

    def generate_flash_minutes_document_url_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlRequest,
        headers: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse:
        """
        @summary 生成会议闪记文档的下载链接
        
        @param request: GenerateFlashMinutesDocumentUrlRequest
        @param headers: GenerateFlashMinutesDocumentUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateFlashMinutesDocumentUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.expire_time):
            query['expireTime'] = request.expire_time
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
            action='GenerateFlashMinutesDocumentUrl',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/document/generate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def generate_flash_minutes_document_url_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlRequest,
        headers: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse:
        """
        @summary 生成会议闪记文档的下载链接
        
        @param request: GenerateFlashMinutesDocumentUrlRequest
        @param headers: GenerateFlashMinutesDocumentUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateFlashMinutesDocumentUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.expire_time):
            query['expireTime'] = request.expire_time
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
            action='GenerateFlashMinutesDocumentUrl',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/document/generate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def generate_flash_minutes_document_url(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlRequest,
    ) -> dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse:
        """
        @summary 生成会议闪记文档的下载链接
        
        @param request: GenerateFlashMinutesDocumentUrlRequest
        @return: GenerateFlashMinutesDocumentUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlHeaders()
        return self.generate_flash_minutes_document_url_with_options(conference_id, request, headers, runtime)

    async def generate_flash_minutes_document_url_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlRequest,
    ) -> dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlResponse:
        """
        @summary 生成会议闪记文档的下载链接
        
        @param request: GenerateFlashMinutesDocumentUrlRequest
        @return: GenerateFlashMinutesDocumentUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GenerateFlashMinutesDocumentUrlHeaders()
        return await self.generate_flash_minutes_document_url_with_options_async(conference_id, request, headers, runtime)

    def get_conf_data_by_conference_id_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDataByConferenceIdRequest,
        headers: dingtalkconference__1__0_models.GetConfDataByConferenceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse:
        """
        @summary 通过conferenceId获取指定音视频会议信息
        
        @param request: GetConfDataByConferenceIdRequest
        @param headers: GetConfDataByConferenceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfDataByConferenceIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.real_data):
            query['realData'] = request.real_data
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
            action='GetConfDataByConferenceId',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conf_data_by_conference_id_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDataByConferenceIdRequest,
        headers: dingtalkconference__1__0_models.GetConfDataByConferenceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse:
        """
        @summary 通过conferenceId获取指定音视频会议信息
        
        @param request: GetConfDataByConferenceIdRequest
        @param headers: GetConfDataByConferenceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfDataByConferenceIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.real_data):
            query['realData'] = request.real_data
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
            action='GetConfDataByConferenceId',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conf_data_by_conference_id(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDataByConferenceIdRequest,
    ) -> dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse:
        """
        @summary 通过conferenceId获取指定音视频会议信息
        
        @param request: GetConfDataByConferenceIdRequest
        @return: GetConfDataByConferenceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetConfDataByConferenceIdHeaders()
        return self.get_conf_data_by_conference_id_with_options(conference_id, request, headers, runtime)

    async def get_conf_data_by_conference_id_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDataByConferenceIdRequest,
    ) -> dingtalkconference__1__0_models.GetConfDataByConferenceIdResponse:
        """
        @summary 通过conferenceId获取指定音视频会议信息
        
        @param request: GetConfDataByConferenceIdRequest
        @return: GetConfDataByConferenceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetConfDataByConferenceIdHeaders()
        return await self.get_conf_data_by_conference_id_with_options_async(conference_id, request, headers, runtime)

    def get_conf_detail_data_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDetailDataRequest,
        headers: dingtalkconference__1__0_models.GetConfDetailDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetConfDetailDataResponse:
        """
        @summary 通过conferenceId获取指定音视频会议成员信息
        
        @param request: GetConfDetailDataRequest
        @param headers: GetConfDetailDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfDetailDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.nick):
            query['nick'] = request.nick
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
            action='GetConfDetailData',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetConfDetailDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conf_detail_data_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDetailDataRequest,
        headers: dingtalkconference__1__0_models.GetConfDetailDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetConfDetailDataResponse:
        """
        @summary 通过conferenceId获取指定音视频会议成员信息
        
        @param request: GetConfDetailDataRequest
        @param headers: GetConfDetailDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfDetailDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.nick):
            query['nick'] = request.nick
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
            action='GetConfDetailData',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetConfDetailDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conf_detail_data(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDetailDataRequest,
    ) -> dingtalkconference__1__0_models.GetConfDetailDataResponse:
        """
        @summary 通过conferenceId获取指定音视频会议成员信息
        
        @param request: GetConfDetailDataRequest
        @return: GetConfDetailDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetConfDetailDataHeaders()
        return self.get_conf_detail_data_with_options(conference_id, request, headers, runtime)

    async def get_conf_detail_data_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetConfDetailDataRequest,
    ) -> dingtalkconference__1__0_models.GetConfDetailDataResponse:
        """
        @summary 通过conferenceId获取指定音视频会议成员信息
        
        @param request: GetConfDetailDataRequest
        @return: GetConfDetailDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetConfDetailDataHeaders()
        return await self.get_conf_detail_data_with_options_async(conference_id, request, headers, runtime)

    def get_history_conf_data_list_with_options(
        self,
        request: dingtalkconference__1__0_models.GetHistoryConfDataListRequest,
        headers: dingtalkconference__1__0_models.GetHistoryConfDataListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetHistoryConfDataListResponse:
        """
        @summary 获取音视频会议列表数据
        
        @param request: GetHistoryConfDataListRequest
        @param headers: GetHistoryConfDataListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHistoryConfDataListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_nike):
            query['creatorNike'] = request.creator_nike
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.free_type):
            query['freeType'] = request.free_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.real_data):
            query['realData'] = request.real_data
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='GetHistoryConfDataList',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/histories/dataLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetHistoryConfDataListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_history_conf_data_list_with_options_async(
        self,
        request: dingtalkconference__1__0_models.GetHistoryConfDataListRequest,
        headers: dingtalkconference__1__0_models.GetHistoryConfDataListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetHistoryConfDataListResponse:
        """
        @summary 获取音视频会议列表数据
        
        @param request: GetHistoryConfDataListRequest
        @param headers: GetHistoryConfDataListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHistoryConfDataListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_nike):
            query['creatorNike'] = request.creator_nike
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.free_type):
            query['freeType'] = request.free_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.real_data):
            query['realData'] = request.real_data
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='GetHistoryConfDataList',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/histories/dataLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetHistoryConfDataListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_history_conf_data_list(
        self,
        request: dingtalkconference__1__0_models.GetHistoryConfDataListRequest,
    ) -> dingtalkconference__1__0_models.GetHistoryConfDataListResponse:
        """
        @summary 获取音视频会议列表数据
        
        @param request: GetHistoryConfDataListRequest
        @return: GetHistoryConfDataListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetHistoryConfDataListHeaders()
        return self.get_history_conf_data_list_with_options(request, headers, runtime)

    async def get_history_conf_data_list_async(
        self,
        request: dingtalkconference__1__0_models.GetHistoryConfDataListRequest,
    ) -> dingtalkconference__1__0_models.GetHistoryConfDataListResponse:
        """
        @summary 获取音视频会议列表数据
        
        @param request: GetHistoryConfDataListRequest
        @return: GetHistoryConfDataListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetHistoryConfDataListHeaders()
        return await self.get_history_conf_data_list_with_options_async(request, headers, runtime)

    def get_user_last_metric_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserLastMetricRequest,
        headers: dingtalkconference__1__0_models.GetUserLastMetricHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetUserLastMetricResponse:
        """
        @summary 通过conferenceId和unionId获取最新会议质量数据
        
        @param request: GetUserLastMetricRequest
        @param headers: GetUserLastMetricHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserLastMetricResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.union_id_list):
            body['unionIdList'] = request.union_id_list
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
            action='GetUserLastMetric',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/lastMetricDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetUserLastMetricResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_last_metric_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserLastMetricRequest,
        headers: dingtalkconference__1__0_models.GetUserLastMetricHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetUserLastMetricResponse:
        """
        @summary 通过conferenceId和unionId获取最新会议质量数据
        
        @param request: GetUserLastMetricRequest
        @param headers: GetUserLastMetricHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserLastMetricResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.union_id_list):
            body['unionIdList'] = request.union_id_list
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
            action='GetUserLastMetric',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/lastMetricDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetUserLastMetricResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_last_metric(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserLastMetricRequest,
    ) -> dingtalkconference__1__0_models.GetUserLastMetricResponse:
        """
        @summary 通过conferenceId和unionId获取最新会议质量数据
        
        @param request: GetUserLastMetricRequest
        @return: GetUserLastMetricResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetUserLastMetricHeaders()
        return self.get_user_last_metric_with_options(conference_id, request, headers, runtime)

    async def get_user_last_metric_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserLastMetricRequest,
    ) -> dingtalkconference__1__0_models.GetUserLastMetricResponse:
        """
        @summary 通过conferenceId和unionId获取最新会议质量数据
        
        @param request: GetUserLastMetricRequest
        @return: GetUserLastMetricResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetUserLastMetricHeaders()
        return await self.get_user_last_metric_with_options_async(conference_id, request, headers, runtime)

    def get_user_metric_data_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserMetricDataRequest,
        headers: dingtalkconference__1__0_models.GetUserMetricDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetUserMetricDataResponse:
        """
        @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
        
        @param request: GetUserMetricDataRequest
        @param headers: GetUserMetricDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserMetricDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetUserMetricData',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/metricDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetUserMetricDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_metric_data_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserMetricDataRequest,
        headers: dingtalkconference__1__0_models.GetUserMetricDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.GetUserMetricDataResponse:
        """
        @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
        
        @param request: GetUserMetricDataRequest
        @param headers: GetUserMetricDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserMetricDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetUserMetricData',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/metricDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.GetUserMetricDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_metric_data(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserMetricDataRequest,
    ) -> dingtalkconference__1__0_models.GetUserMetricDataResponse:
        """
        @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
        
        @param request: GetUserMetricDataRequest
        @return: GetUserMetricDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetUserMetricDataHeaders()
        return self.get_user_metric_data_with_options(conference_id, request, headers, runtime)

    async def get_user_metric_data_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.GetUserMetricDataRequest,
    ) -> dingtalkconference__1__0_models.GetUserMetricDataResponse:
        """
        @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
        
        @param request: GetUserMetricDataRequest
        @return: GetUserMetricDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.GetUserMetricDataHeaders()
        return await self.get_user_metric_data_with_options_async(conference_id, request, headers, runtime)

    def invite_users_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
        headers: dingtalkconference__1__0_models.InviteUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        """
        @summary 邀请其他人员
        
        @param request: InviteUsersRequest
        @param headers: InviteUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InviteUsersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invitee_list):
            body['inviteeList'] = request.invitee_list
        if not UtilClient.is_unset(request.phone_invitee_list):
            body['phoneInviteeList'] = request.phone_invitee_list
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
        """
        @summary 邀请其他人员
        
        @param request: InviteUsersRequest
        @param headers: InviteUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InviteUsersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.invitee_list):
            body['inviteeList'] = request.invitee_list
        if not UtilClient.is_unset(request.phone_invitee_list):
            body['phoneInviteeList'] = request.phone_invitee_list
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
        """
        @summary 邀请其他人员
        
        @param request: InviteUsersRequest
        @return: InviteUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.InviteUsersHeaders()
        return self.invite_users_with_options(conference_id, request, headers, runtime)

    async def invite_users_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.InviteUsersRequest,
    ) -> dingtalkconference__1__0_models.InviteUsersResponse:
        """
        @summary 邀请其他人员
        
        @param request: InviteUsersRequest
        @return: InviteUsersResponse
        """
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
        """
        @summary 会议踢出成员
        
        @param request: KickMembersRequest
        @param headers: KickMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: KickMembersResponse
        """
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
        """
        @summary 会议踢出成员
        
        @param request: KickMembersRequest
        @param headers: KickMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: KickMembersResponse
        """
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
        """
        @summary 会议踢出成员
        
        @param request: KickMembersRequest
        @return: KickMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.KickMembersHeaders()
        return self.kick_members_with_options(conference_id, request, headers, runtime)

    async def kick_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.KickMembersRequest,
    ) -> dingtalkconference__1__0_models.KickMembersResponse:
        """
        @summary 会议踢出成员
        
        @param request: KickMembersRequest
        @return: KickMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.KickMembersHeaders()
        return await self.kick_members_with_options_async(conference_id, request, headers, runtime)

    def lock_conference_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.LockConferenceRequest,
        headers: dingtalkconference__1__0_models.LockConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.LockConferenceResponse:
        """
        @summary 锁定会议
        
        @param request: LockConferenceRequest
        @param headers: LockConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LockConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
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
            action='LockConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/lock',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.LockConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def lock_conference_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.LockConferenceRequest,
        headers: dingtalkconference__1__0_models.LockConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.LockConferenceResponse:
        """
        @summary 锁定会议
        
        @param request: LockConferenceRequest
        @param headers: LockConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LockConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
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
            action='LockConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/lock',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.LockConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def lock_conference(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.LockConferenceRequest,
    ) -> dingtalkconference__1__0_models.LockConferenceResponse:
        """
        @summary 锁定会议
        
        @param request: LockConferenceRequest
        @return: LockConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.LockConferenceHeaders()
        return self.lock_conference_with_options(conference_id, request, headers, runtime)

    async def lock_conference_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.LockConferenceRequest,
    ) -> dingtalkconference__1__0_models.LockConferenceResponse:
        """
        @summary 锁定会议
        
        @param request: LockConferenceRequest
        @return: LockConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.LockConferenceHeaders()
        return await self.lock_conference_with_options_async(conference_id, request, headers, runtime)

    def mute_all_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
        headers: dingtalkconference__1__0_models.MuteAllHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        """
        @summary 会议全员静音或解除静音
        
        @param request: MuteAllRequest
        @param headers: MuteAllHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MuteAllResponse
        """
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
        """
        @summary 会议全员静音或解除静音
        
        @param request: MuteAllRequest
        @param headers: MuteAllHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MuteAllResponse
        """
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
        """
        @summary 会议全员静音或解除静音
        
        @param request: MuteAllRequest
        @return: MuteAllResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteAllHeaders()
        return self.mute_all_with_options(conference_id, request, headers, runtime)

    async def mute_all_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteAllRequest,
    ) -> dingtalkconference__1__0_models.MuteAllResponse:
        """
        @summary 会议全员静音或解除静音
        
        @param request: MuteAllRequest
        @return: MuteAllResponse
        """
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
        """
        @summary 指定人员静音或取消静音
        
        @param request: MuteMembersRequest
        @param headers: MuteMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MuteMembersResponse
        """
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
        """
        @summary 指定人员静音或取消静音
        
        @param request: MuteMembersRequest
        @param headers: MuteMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MuteMembersResponse
        """
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
        """
        @summary 指定人员静音或取消静音
        
        @param request: MuteMembersRequest
        @return: MuteMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.MuteMembersHeaders()
        return self.mute_members_with_options(conference_id, request, headers, runtime)

    async def mute_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.MuteMembersRequest,
    ) -> dingtalkconference__1__0_models.MuteMembersResponse:
        """
        @summary 指定人员静音或取消静音
        
        @param request: MuteMembersRequest
        @return: MuteMembersResponse
        """
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
        """
        @summary 查询云录制文本信息
        
        @param request: QueryCloudRecordTextRequest
        @param headers: QueryCloudRecordTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordTextResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制文本信息
        
        @param request: QueryCloudRecordTextRequest
        @param headers: QueryCloudRecordTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordTextResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制文本信息
        
        @param request: QueryCloudRecordTextRequest
        @return: QueryCloudRecordTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordTextHeaders()
        return self.query_cloud_record_text_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_text_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordTextRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordTextResponse:
        """
        @summary 查询云录制文本信息
        
        @param request: QueryCloudRecordTextRequest
        @return: QueryCloudRecordTextResponse
        """
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
        """
        @summary 查询云录制视频
        
        @param request: QueryCloudRecordVideoRequest
        @param headers: QueryCloudRecordVideoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordVideoResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制视频
        
        @param request: QueryCloudRecordVideoRequest
        @param headers: QueryCloudRecordVideoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordVideoResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制视频
        
        @param request: QueryCloudRecordVideoRequest
        @return: QueryCloudRecordVideoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoHeaders()
        return self.query_cloud_record_video_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_video_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoResponse:
        """
        @summary 查询云录制视频
        
        @param request: QueryCloudRecordVideoRequest
        @return: QueryCloudRecordVideoResponse
        """
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
        """
        @summary 查询云录制视频播放信息
        
        @param request: QueryCloudRecordVideoPlayInfoRequest
        @param headers: QueryCloudRecordVideoPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordVideoPlayInfoResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制视频播放信息
        
        @param request: QueryCloudRecordVideoPlayInfoRequest
        @param headers: QueryCloudRecordVideoPlayInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCloudRecordVideoPlayInfoResponse
        """
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
            req_body_type='none',
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
        """
        @summary 查询云录制视频播放信息
        
        @param request: QueryCloudRecordVideoPlayInfoRequest
        @return: QueryCloudRecordVideoPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders()
        return self.query_cloud_record_video_play_info_with_options(conference_id, request, headers, runtime)

    async def query_cloud_record_video_play_info_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoRequest,
    ) -> dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoResponse:
        """
        @summary 查询云录制视频播放信息
        
        @param request: QueryCloudRecordVideoPlayInfoRequest
        @return: QueryCloudRecordVideoPlayInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryCloudRecordVideoPlayInfoHeaders()
        return await self.query_cloud_record_video_play_info_with_options_async(conference_id, request, headers, runtime)

    def query_conference_info_with_options(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        """
        @summary 查询视频会议信息
        
        @param headers: QueryConferenceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceInfoResponse
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
        """
        @summary 查询视频会议信息
        
        @param headers: QueryConferenceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceInfoResponse
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
        """
        @summary 查询视频会议信息
        
        @return: QueryConferenceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoHeaders()
        return self.query_conference_info_with_options(conference_id, headers, runtime)

    async def query_conference_info_async(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoResponse:
        """
        @summary 查询视频会议信息
        
        @return: QueryConferenceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoHeaders()
        return await self.query_conference_info_with_options_async(conference_id, headers, runtime)

    def query_conference_info_batch_with_options(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        """
        @summary 批量查询视频会议信息
        
        @param request: QueryConferenceInfoBatchRequest
        @param headers: QueryConferenceInfoBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceInfoBatchResponse
        """
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
        """
        @summary 批量查询视频会议信息
        
        @param request: QueryConferenceInfoBatchRequest
        @param headers: QueryConferenceInfoBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceInfoBatchResponse
        """
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
        """
        @summary 批量查询视频会议信息
        
        @param request: QueryConferenceInfoBatchRequest
        @return: QueryConferenceInfoBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders()
        return self.query_conference_info_batch_with_options(request, headers, runtime)

    async def query_conference_info_batch_async(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        """
        @summary 批量查询视频会议信息
        
        @param request: QueryConferenceInfoBatchRequest
        @return: QueryConferenceInfoBatchResponse
        """
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
        """
        @summary 查询视频会议成员
        
        @param request: QueryConferenceMembersRequest
        @param headers: QueryConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceMembersResponse
        """
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
        """
        @summary 查询视频会议成员
        
        @param request: QueryConferenceMembersRequest
        @param headers: QueryConferenceMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConferenceMembersResponse
        """
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
        """
        @summary 查询视频会议成员
        
        @param request: QueryConferenceMembersRequest
        @return: QueryConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceMembersHeaders()
        return self.query_conference_members_with_options(conference_id, request, headers, runtime)

    async def query_conference_members_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryConferenceMembersRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceMembersResponse:
        """
        @summary 查询视频会议成员
        
        @param request: QueryConferenceMembersRequest
        @return: QueryConferenceMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceMembersHeaders()
        return await self.query_conference_members_with_options_async(conference_id, request, headers, runtime)

    def query_flash_minutes_summary_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryFlashMinutesSummaryRequest,
        headers: dingtalkconference__1__0_models.QueryFlashMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse:
        """
        @summary 查询云录制摘要请求
        
        @param request: QueryFlashMinutesSummaryRequest
        @param headers: QueryFlashMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryFlashMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.recorder_union_id):
            query['recorderUnionId'] = request.recorder_union_id
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
            action='QueryFlashMinutesSummary',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/summaries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_flash_minutes_summary_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryFlashMinutesSummaryRequest,
        headers: dingtalkconference__1__0_models.QueryFlashMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse:
        """
        @summary 查询云录制摘要请求
        
        @param request: QueryFlashMinutesSummaryRequest
        @param headers: QueryFlashMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryFlashMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.recorder_union_id):
            query['recorderUnionId'] = request.recorder_union_id
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
            action='QueryFlashMinutesSummary',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/summaries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_flash_minutes_summary(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryFlashMinutesSummaryRequest,
    ) -> dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse:
        """
        @summary 查询云录制摘要请求
        
        @param request: QueryFlashMinutesSummaryRequest
        @return: QueryFlashMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryFlashMinutesSummaryHeaders()
        return self.query_flash_minutes_summary_with_options(conference_id, request, headers, runtime)

    async def query_flash_minutes_summary_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryFlashMinutesSummaryRequest,
    ) -> dingtalkconference__1__0_models.QueryFlashMinutesSummaryResponse:
        """
        @summary 查询云录制摘要请求
        
        @param request: QueryFlashMinutesSummaryRequest
        @return: QueryFlashMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryFlashMinutesSummaryHeaders()
        return await self.query_flash_minutes_summary_with_options_async(conference_id, request, headers, runtime)

    def query_minutes_audio_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesAudioRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesAudioHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesAudioResponse:
        """
        @summary 查询会议闪记的音频信息
        
        @param request: QueryMinutesAudioRequest
        @param headers: QueryMinutesAudioHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesAudioResponse
        """
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
            action='QueryMinutesAudio',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/audioInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesAudioResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_audio_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesAudioRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesAudioHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesAudioResponse:
        """
        @summary 查询会议闪记的音频信息
        
        @param request: QueryMinutesAudioRequest
        @param headers: QueryMinutesAudioHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesAudioResponse
        """
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
            action='QueryMinutesAudio',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/audioInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesAudioResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_audio(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesAudioRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesAudioResponse:
        """
        @summary 查询会议闪记的音频信息
        
        @param request: QueryMinutesAudioRequest
        @return: QueryMinutesAudioResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesAudioHeaders()
        return self.query_minutes_audio_with_options(conference_id, request, headers, runtime)

    async def query_minutes_audio_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesAudioRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesAudioResponse:
        """
        @summary 查询会议闪记的音频信息
        
        @param request: QueryMinutesAudioRequest
        @return: QueryMinutesAudioResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesAudioHeaders()
        return await self.query_minutes_audio_with_options_async(conference_id, request, headers, runtime)

    def query_minutes_summary_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesSummaryRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesSummaryResponse:
        """
        @summary 查询会议闪记智能纪要
        
        @param request: QueryMinutesSummaryRequest
        @param headers: QueryMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary_type_list):
            body['summaryTypeList'] = request.summary_type_list
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
            action='QueryMinutesSummary',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/summaries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_summary_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesSummaryRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesSummaryResponse:
        """
        @summary 查询会议闪记智能纪要
        
        @param request: QueryMinutesSummaryRequest
        @param headers: QueryMinutesSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesSummaryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.summary_type_list):
            body['summaryTypeList'] = request.summary_type_list
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
            action='QueryMinutesSummary',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/summaries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_summary(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesSummaryRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesSummaryResponse:
        """
        @summary 查询会议闪记智能纪要
        
        @param request: QueryMinutesSummaryRequest
        @return: QueryMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesSummaryHeaders()
        return self.query_minutes_summary_with_options(conference_id, request, headers, runtime)

    async def query_minutes_summary_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesSummaryRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesSummaryResponse:
        """
        @summary 查询会议闪记智能纪要
        
        @param request: QueryMinutesSummaryRequest
        @return: QueryMinutesSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesSummaryHeaders()
        return await self.query_minutes_summary_with_options_async(conference_id, request, headers, runtime)

    def query_minutes_text_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesTextRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询会议闪记文本信息
        
        @param request: QueryMinutesTextRequest
        @param headers: QueryMinutesTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryMinutesText',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/textInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesTextResponse(),
            self.execute(params, req, runtime)
        )

    async def query_minutes_text_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesTextRequest,
        headers: dingtalkconference__1__0_models.QueryMinutesTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询会议闪记文本信息
        
        @param request: QueryMinutesTextRequest
        @param headers: QueryMinutesTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMinutesTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.direction):
            query['direction'] = request.direction
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryMinutesText',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/textInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryMinutesTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_minutes_text(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesTextRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询会议闪记文本信息
        
        @param request: QueryMinutesTextRequest
        @return: QueryMinutesTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesTextHeaders()
        return self.query_minutes_text_with_options(conference_id, request, headers, runtime)

    async def query_minutes_text_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryMinutesTextRequest,
    ) -> dingtalkconference__1__0_models.QueryMinutesTextResponse:
        """
        @summary 查询会议闪记文本信息
        
        @param request: QueryMinutesTextRequest
        @return: QueryMinutesTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryMinutesTextHeaders()
        return await self.query_minutes_text_with_options_async(conference_id, request, headers, runtime)

    def query_record_minutes_url_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryRecordMinutesUrlRequest,
        headers: dingtalkconference__1__0_models.QueryRecordMinutesUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse:
        """
        @summary 查询闪记链接
        
        @param request: QueryRecordMinutesUrlRequest
        @param headers: QueryRecordMinutesUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecordMinutesUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.recorder_union_id):
            query['recorderUnionId'] = request.recorder_union_id
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
            action='QueryRecordMinutesUrl',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/recordUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def query_record_minutes_url_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryRecordMinutesUrlRequest,
        headers: dingtalkconference__1__0_models.QueryRecordMinutesUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse:
        """
        @summary 查询闪记链接
        
        @param request: QueryRecordMinutesUrlRequest
        @param headers: QueryRecordMinutesUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecordMinutesUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.recorder_union_id):
            query['recorderUnionId'] = request.recorder_union_id
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
            action='QueryRecordMinutesUrl',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/flashMinutes/recordUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_record_minutes_url(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryRecordMinutesUrlRequest,
    ) -> dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse:
        """
        @summary 查询闪记链接
        
        @param request: QueryRecordMinutesUrlRequest
        @return: QueryRecordMinutesUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryRecordMinutesUrlHeaders()
        return self.query_record_minutes_url_with_options(conference_id, request, headers, runtime)

    async def query_record_minutes_url_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.QueryRecordMinutesUrlRequest,
    ) -> dingtalkconference__1__0_models.QueryRecordMinutesUrlResponse:
        """
        @summary 查询闪记链接
        
        @param request: QueryRecordMinutesUrlRequest
        @return: QueryRecordMinutesUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryRecordMinutesUrlHeaders()
        return await self.query_record_minutes_url_with_options_async(conference_id, request, headers, runtime)

    def query_schedule_conf_settings_with_options(
        self,
        request: dingtalkconference__1__0_models.QueryScheduleConfSettingsRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConfSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse:
        """
        @summary 查询预约会议设置
        
        @param request: QueryScheduleConfSettingsRequest
        @param headers: QueryScheduleConfSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConfSettingsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.schedule_conference_id):
            query['scheduleConferenceId'] = request.schedule_conference_id
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
            action='QueryScheduleConfSettings',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_schedule_conf_settings_with_options_async(
        self,
        request: dingtalkconference__1__0_models.QueryScheduleConfSettingsRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConfSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse:
        """
        @summary 查询预约会议设置
        
        @param request: QueryScheduleConfSettingsRequest
        @param headers: QueryScheduleConfSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConfSettingsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.schedule_conference_id):
            query['scheduleConferenceId'] = request.schedule_conference_id
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
            action='QueryScheduleConfSettings',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_schedule_conf_settings(
        self,
        request: dingtalkconference__1__0_models.QueryScheduleConfSettingsRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse:
        """
        @summary 查询预约会议设置
        
        @param request: QueryScheduleConfSettingsRequest
        @return: QueryScheduleConfSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConfSettingsHeaders()
        return self.query_schedule_conf_settings_with_options(request, headers, runtime)

    async def query_schedule_conf_settings_async(
        self,
        request: dingtalkconference__1__0_models.QueryScheduleConfSettingsRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConfSettingsResponse:
        """
        @summary 查询预约会议设置
        
        @param request: QueryScheduleConfSettingsRequest
        @return: QueryScheduleConfSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConfSettingsHeaders()
        return await self.query_schedule_conf_settings_with_options_async(request, headers, runtime)

    def query_schedule_conference_with_options(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceResponse:
        """
        @summary 查询预约会议信息
        
        @param request: QueryScheduleConferenceRequest
        @param headers: QueryScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.request_union_id):
            query['requestUnionId'] = request.request_union_id
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
            action='QueryScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/{schedule_conference_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_schedule_conference_with_options_async(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceResponse:
        """
        @summary 查询预约会议信息
        
        @param request: QueryScheduleConferenceRequest
        @param headers: QueryScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.request_union_id):
            query['requestUnionId'] = request.request_union_id
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
            action='QueryScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/{schedule_conference_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_schedule_conference(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceResponse:
        """
        @summary 查询预约会议信息
        
        @param request: QueryScheduleConferenceRequest
        @return: QueryScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConferenceHeaders()
        return self.query_schedule_conference_with_options(schedule_conference_id, request, headers, runtime)

    async def query_schedule_conference_async(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceResponse:
        """
        @summary 查询预约会议信息
        
        @param request: QueryScheduleConferenceRequest
        @return: QueryScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConferenceHeaders()
        return await self.query_schedule_conference_with_options_async(schedule_conference_id, request, headers, runtime)

    def query_schedule_conference_info_with_options(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceInfoRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConferenceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse:
        """
        @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
        
        @param request: QueryScheduleConferenceInfoRequest
        @param headers: QueryScheduleConferenceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConferenceInfoResponse
        """
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
            action='QueryScheduleConferenceInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/scheduleConferences/{schedule_conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_schedule_conference_info_with_options_async(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceInfoRequest,
        headers: dingtalkconference__1__0_models.QueryScheduleConferenceInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse:
        """
        @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
        
        @param request: QueryScheduleConferenceInfoRequest
        @param headers: QueryScheduleConferenceInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScheduleConferenceInfoResponse
        """
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
            action='QueryScheduleConferenceInfo',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/scheduleConferences/{schedule_conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_schedule_conference_info(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceInfoRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse:
        """
        @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
        
        @param request: QueryScheduleConferenceInfoRequest
        @return: QueryScheduleConferenceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConferenceInfoHeaders()
        return self.query_schedule_conference_info_with_options(schedule_conference_id, request, headers, runtime)

    async def query_schedule_conference_info_async(
        self,
        schedule_conference_id: str,
        request: dingtalkconference__1__0_models.QueryScheduleConferenceInfoRequest,
    ) -> dingtalkconference__1__0_models.QueryScheduleConferenceInfoResponse:
        """
        @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
        
        @param request: QueryScheduleConferenceInfoRequest
        @return: QueryScheduleConferenceInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryScheduleConferenceInfoHeaders()
        return await self.query_schedule_conference_info_with_options_async(schedule_conference_id, request, headers, runtime)

    def query_user_on_going_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.QueryUserOnGoingConferenceRequest,
        headers: dingtalkconference__1__0_models.QueryUserOnGoingConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse:
        """
        @summary 查询用户进行中会议
        
        @param request: QueryUserOnGoingConferenceRequest
        @param headers: QueryUserOnGoingConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserOnGoingConferenceResponse
        """
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
            action='QueryUserOnGoingConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/users/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_on_going_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.QueryUserOnGoingConferenceRequest,
        headers: dingtalkconference__1__0_models.QueryUserOnGoingConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse:
        """
        @summary 查询用户进行中会议
        
        @param request: QueryUserOnGoingConferenceRequest
        @param headers: QueryUserOnGoingConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserOnGoingConferenceResponse
        """
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
            action='QueryUserOnGoingConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/users/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_on_going_conference(
        self,
        request: dingtalkconference__1__0_models.QueryUserOnGoingConferenceRequest,
    ) -> dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse:
        """
        @summary 查询用户进行中会议
        
        @param request: QueryUserOnGoingConferenceRequest
        @return: QueryUserOnGoingConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryUserOnGoingConferenceHeaders()
        return self.query_user_on_going_conference_with_options(request, headers, runtime)

    async def query_user_on_going_conference_async(
        self,
        request: dingtalkconference__1__0_models.QueryUserOnGoingConferenceRequest,
    ) -> dingtalkconference__1__0_models.QueryUserOnGoingConferenceResponse:
        """
        @summary 查询用户进行中会议
        
        @param request: QueryUserOnGoingConferenceRequest
        @return: QueryUserOnGoingConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryUserOnGoingConferenceHeaders()
        return await self.query_user_on_going_conference_with_options_async(request, headers, runtime)

    def start_cloud_record_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
        headers: dingtalkconference__1__0_models.StartCloudRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        """
        @summary 开启云录制
        
        @param request: StartCloudRecordRequest
        @param headers: StartCloudRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCloudRecordResponse
        """
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
        """
        @summary 开启云录制
        
        @param request: StartCloudRecordRequest
        @param headers: StartCloudRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCloudRecordResponse
        """
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
        """
        @summary 开启云录制
        
        @param request: StartCloudRecordRequest
        @return: StartCloudRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartCloudRecordHeaders()
        return self.start_cloud_record_with_options(conference_id, request, headers, runtime)

    async def start_cloud_record_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StartCloudRecordResponse:
        """
        @summary 开启云录制
        
        @param request: StartCloudRecordRequest
        @return: StartCloudRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartCloudRecordHeaders()
        return await self.start_cloud_record_with_options_async(conference_id, request, headers, runtime)

    def start_minutes_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartMinutesRequest,
        headers: dingtalkconference__1__0_models.StartMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartMinutesResponse:
        """
        @summary 开启会议闪记
        
        @param request: StartMinutesRequest
        @param headers: StartMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartMinutesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        if not UtilClient.is_unset(request.record_audio):
            body['recordAudio'] = request.record_audio
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
            action='StartMinutes',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def start_minutes_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartMinutesRequest,
        headers: dingtalkconference__1__0_models.StartMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartMinutesResponse:
        """
        @summary 开启会议闪记
        
        @param request: StartMinutesRequest
        @param headers: StartMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartMinutesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        if not UtilClient.is_unset(request.record_audio):
            body['recordAudio'] = request.record_audio
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
            action='StartMinutes',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StartMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_minutes(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartMinutesRequest,
    ) -> dingtalkconference__1__0_models.StartMinutesResponse:
        """
        @summary 开启会议闪记
        
        @param request: StartMinutesRequest
        @return: StartMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartMinutesHeaders()
        return self.start_minutes_with_options(conference_id, request, headers, runtime)

    async def start_minutes_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartMinutesRequest,
    ) -> dingtalkconference__1__0_models.StartMinutesResponse:
        """
        @summary 开启会议闪记
        
        @param request: StartMinutesRequest
        @return: StartMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartMinutesHeaders()
        return await self.start_minutes_with_options_async(conference_id, request, headers, runtime)

    def start_stream_out_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
        headers: dingtalkconference__1__0_models.StartStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        """
        @summary 会议开始直播推流
        
        @param request: StartStreamOutRequest
        @param headers: StartStreamOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartStreamOutResponse
        """
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
        """
        @summary 会议开始直播推流
        
        @param request: StartStreamOutRequest
        @param headers: StartStreamOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartStreamOutResponse
        """
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
        """
        @summary 会议开始直播推流
        
        @param request: StartStreamOutRequest
        @return: StartStreamOutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StartStreamOutHeaders()
        return self.start_stream_out_with_options(conference_id, request, headers, runtime)

    async def start_stream_out_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StartStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StartStreamOutResponse:
        """
        @summary 会议开始直播推流
        
        @param request: StartStreamOutRequest
        @return: StartStreamOutResponse
        """
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
        """
        @summary 关闭云录制
        
        @param request: StopCloudRecordRequest
        @param headers: StopCloudRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopCloudRecordResponse
        """
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
        """
        @summary 关闭云录制
        
        @param request: StopCloudRecordRequest
        @param headers: StopCloudRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopCloudRecordResponse
        """
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
        """
        @summary 关闭云录制
        
        @param request: StopCloudRecordRequest
        @return: StopCloudRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopCloudRecordHeaders()
        return self.stop_cloud_record_with_options(conference_id, request, headers, runtime)

    async def stop_cloud_record_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopCloudRecordRequest,
    ) -> dingtalkconference__1__0_models.StopCloudRecordResponse:
        """
        @summary 关闭云录制
        
        @param request: StopCloudRecordRequest
        @return: StopCloudRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopCloudRecordHeaders()
        return await self.stop_cloud_record_with_options_async(conference_id, request, headers, runtime)

    def stop_minutes_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopMinutesRequest,
        headers: dingtalkconference__1__0_models.StopMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopMinutesResponse:
        """
        @summary 暂停会议闪记
        
        @param request: StopMinutesRequest
        @param headers: StopMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopMinutesResponse
        """
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
            action='StopMinutes',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/pause',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopMinutesResponse(),
            self.execute(params, req, runtime)
        )

    async def stop_minutes_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopMinutesRequest,
        headers: dingtalkconference__1__0_models.StopMinutesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopMinutesResponse:
        """
        @summary 暂停会议闪记
        
        @param request: StopMinutesRequest
        @param headers: StopMinutesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopMinutesResponse
        """
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
            action='StopMinutes',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/videoConferences/{conference_id}/minutes/pause',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.StopMinutesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def stop_minutes(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopMinutesRequest,
    ) -> dingtalkconference__1__0_models.StopMinutesResponse:
        """
        @summary 暂停会议闪记
        
        @param request: StopMinutesRequest
        @return: StopMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopMinutesHeaders()
        return self.stop_minutes_with_options(conference_id, request, headers, runtime)

    async def stop_minutes_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopMinutesRequest,
    ) -> dingtalkconference__1__0_models.StopMinutesResponse:
        """
        @summary 暂停会议闪记
        
        @param request: StopMinutesRequest
        @return: StopMinutesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopMinutesHeaders()
        return await self.stop_minutes_with_options_async(conference_id, request, headers, runtime)

    def stop_stream_out_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
        headers: dingtalkconference__1__0_models.StopStreamOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        """
        @summary 会议停止直播推流
        
        @param request: StopStreamOutRequest
        @param headers: StopStreamOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopStreamOutResponse
        """
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
        """
        @summary 会议停止直播推流
        
        @param request: StopStreamOutRequest
        @param headers: StopStreamOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopStreamOutResponse
        """
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
        """
        @summary 会议停止直播推流
        
        @param request: StopStreamOutRequest
        @return: StopStreamOutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopStreamOutHeaders()
        return self.stop_stream_out_with_options(conference_id, request, headers, runtime)

    async def stop_stream_out_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.StopStreamOutRequest,
    ) -> dingtalkconference__1__0_models.StopStreamOutResponse:
        """
        @summary 会议停止直播推流
        
        @param request: StopStreamOutRequest
        @return: StopStreamOutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.StopStreamOutHeaders()
        return await self.stop_stream_out_with_options_async(conference_id, request, headers, runtime)

    def update_schedule_conf_settings_with_options(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConfSettingsRequest,
        headers: dingtalkconference__1__0_models.UpdateScheduleConfSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse:
        """
        @summary 更新预约会议设置
        
        @param request: UpdateScheduleConfSettingsRequest
        @param headers: UpdateScheduleConfSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateScheduleConfSettingsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.schedule_conf_setting_model):
            body['scheduleConfSettingModel'] = request.schedule_conf_setting_model
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
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
            action='UpdateScheduleConfSettings',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse(),
            self.execute(params, req, runtime)
        )

    async def update_schedule_conf_settings_with_options_async(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConfSettingsRequest,
        headers: dingtalkconference__1__0_models.UpdateScheduleConfSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse:
        """
        @summary 更新预约会议设置
        
        @param request: UpdateScheduleConfSettingsRequest
        @param headers: UpdateScheduleConfSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateScheduleConfSettingsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.schedule_conf_setting_model):
            body['scheduleConfSettingModel'] = request.schedule_conf_setting_model
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
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
            action='UpdateScheduleConfSettings',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_schedule_conf_settings(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConfSettingsRequest,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse:
        """
        @summary 更新预约会议设置
        
        @param request: UpdateScheduleConfSettingsRequest
        @return: UpdateScheduleConfSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateScheduleConfSettingsHeaders()
        return self.update_schedule_conf_settings_with_options(request, headers, runtime)

    async def update_schedule_conf_settings_async(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConfSettingsRequest,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConfSettingsResponse:
        """
        @summary 更新预约会议设置
        
        @param request: UpdateScheduleConfSettingsRequest
        @return: UpdateScheduleConfSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateScheduleConfSettingsHeaders()
        return await self.update_schedule_conf_settings_with_options_async(request, headers, runtime)

    def update_schedule_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.UpdateScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConferenceResponse:
        """
        @summary 更新预约会议
        
        @param request: UpdateScheduleConferenceRequest
        @param headers: UpdateScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='UpdateScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateScheduleConferenceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_schedule_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConferenceRequest,
        headers: dingtalkconference__1__0_models.UpdateScheduleConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConferenceResponse:
        """
        @summary 更新预约会议
        
        @param request: UpdateScheduleConferenceRequest
        @param headers: UpdateScheduleConferenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateScheduleConferenceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.schedule_conference_id):
            body['scheduleConferenceId'] = request.schedule_conference_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='UpdateScheduleConference',
            version='conference_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/conference/scheduleConferences',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.UpdateScheduleConferenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_schedule_conference(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConferenceResponse:
        """
        @summary 更新预约会议
        
        @param request: UpdateScheduleConferenceRequest
        @return: UpdateScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateScheduleConferenceHeaders()
        return self.update_schedule_conference_with_options(request, headers, runtime)

    async def update_schedule_conference_async(
        self,
        request: dingtalkconference__1__0_models.UpdateScheduleConferenceRequest,
    ) -> dingtalkconference__1__0_models.UpdateScheduleConferenceResponse:
        """
        @summary 更新预约会议
        
        @param request: UpdateScheduleConferenceRequest
        @return: UpdateScheduleConferenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateScheduleConferenceHeaders()
        return await self.update_schedule_conference_with_options_async(request, headers, runtime)

    def update_video_conference_ext_info_with_options(
        self,
        conference_id: str,
        headers: dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        """
        @summary 更新会议额外信息
        
        @param headers: UpdateVideoConferenceExtInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVideoConferenceExtInfoResponse
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
        """
        @summary 更新会议额外信息
        
        @param headers: UpdateVideoConferenceExtInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVideoConferenceExtInfoResponse
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
        """
        @summary 更新会议额外信息
        
        @return: UpdateVideoConferenceExtInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoHeaders()
        return self.update_video_conference_ext_info_with_options(conference_id, headers, runtime)

    async def update_video_conference_ext_info_async(
        self,
        conference_id: str,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceExtInfoResponse:
        """
        @summary 更新会议额外信息
        
        @return: UpdateVideoConferenceExtInfoResponse
        """
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
        """
        @summary 设置会议中的会议属性
        
        @param request: UpdateVideoConferenceSettingRequest
        @param headers: UpdateVideoConferenceSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVideoConferenceSettingResponse
        """
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
        """
        @summary 设置会议中的会议属性
        
        @param request: UpdateVideoConferenceSettingRequest
        @param headers: UpdateVideoConferenceSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVideoConferenceSettingResponse
        """
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
        """
        @summary 设置会议中的会议属性
        
        @param request: UpdateVideoConferenceSettingRequest
        @return: UpdateVideoConferenceSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders()
        return self.update_video_conference_setting_with_options(conference_id, request, headers, runtime)

    async def update_video_conference_setting_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.UpdateVideoConferenceSettingRequest,
    ) -> dingtalkconference__1__0_models.UpdateVideoConferenceSettingResponse:
        """
        @summary 设置会议中的会议属性
        
        @param request: UpdateVideoConferenceSettingRequest
        @return: UpdateVideoConferenceSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.UpdateVideoConferenceSettingHeaders()
        return await self.update_video_conference_setting_with_options_async(conference_id, request, headers, runtime)
