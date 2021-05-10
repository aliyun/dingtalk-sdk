# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalksmart_device_1_0 import models as dingtalksmart_device__1__0_models
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

    def query_device_video_conference_book(
        self,
        device_id: str,
        book_id: str,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders()
        return self.query_device_video_conference_book_with_options(device_id, book_id, headers, runtime)

    async def query_device_video_conference_book_async(
        self,
        device_id: str,
        book_id: str,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders()
        return await self.query_device_video_conference_book_with_options_async(device_id, book_id, headers, runtime)

    def query_device_video_conference_book_with_options(
        self,
        device_id: str,
        book_id: str,
        headers: dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse(),
            self.do_roarequest('QueryDeviceVideoConferenceBook', 'smartDevice_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/smartDevice/devices/{device_id}/books/{book_id}', 'json', req, runtime)
        )

    async def query_device_video_conference_book_with_options_async(
        self,
        device_id: str,
        book_id: str,
        headers: dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalksmart_device__1__0_models.QueryDeviceVideoConferenceBookResponse(),
            await self.do_roarequest_async('QueryDeviceVideoConferenceBook', 'smartDevice_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/smartDevice/devices/{device_id}/books/{book_id}', 'json', req, runtime)
        )

    def add_device_video_conference_members(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders()
        return self.add_device_video_conference_members_with_options(device_id, conference_id, request, headers, runtime)

    async def add_device_video_conference_members_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders()
        return await self.add_device_video_conference_members_with_options_async(device_id, conference_id, request, headers, runtime)

    def add_device_video_conference_members_with_options(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse(),
            self.do_roarequest('AddDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members', 'none', req, runtime)
        )

    async def add_device_video_conference_members_with_options_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.AddDeviceVideoConferenceMembersResponse(),
            await self.do_roarequest_async('AddDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members', 'none', req, runtime)
        )

    def create_device_video_conference(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders()
        return self.create_device_video_conference_with_options(device_id, request, headers, runtime)

    async def create_device_video_conference_async(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders()
        return await self.create_device_video_conference_with_options_async(device_id, request, headers, runtime)

    def create_device_video_conference_with_options(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
        headers: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse(),
            self.do_roarequest('CreateDeviceVideoConference', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences', 'json', req, runtime)
        )

    async def create_device_video_conference_with_options_async(
        self,
        device_id: str,
        request: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceRequest,
        headers: dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.CreateDeviceVideoConferenceResponse(),
            await self.do_roarequest_async('CreateDeviceVideoConference', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences', 'json', req, runtime)
        )

    def kick_device_video_conference_members(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders()
        return self.kick_device_video_conference_members_with_options(device_id, conference_id, request, headers, runtime)

    async def kick_device_video_conference_members_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders()
        return await self.kick_device_video_conference_members_with_options_async(device_id, conference_id, request, headers, runtime)

    def kick_device_video_conference_members_with_options(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse(),
            self.do_roarequest('KickDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members/batchDelete', 'none', req, runtime)
        )

    async def kick_device_video_conference_members_with_options_async(
        self,
        device_id: str,
        conference_id: str,
        request: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersRequest,
        headers: dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            dingtalksmart_device__1__0_models.KickDeviceVideoConferenceMembersResponse(),
            await self.do_roarequest_async('KickDeviceVideoConferenceMembers', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/devices/{device_id}/videoConferences/{conference_id}/members/batchDelete', 'none', req, runtime)
        )

    def extract_facial_feature(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders()
        return self.extract_facial_feature_with_options(request, headers, runtime)

    async def extract_facial_feature_async(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders()
        return await self.extract_facial_feature_with_options_async(request, headers, runtime)

    def extract_facial_feature_with_options(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
        headers: dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse(),
            self.do_roarequest('ExtractFacialFeature', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/faceRecognitions/features/extract', 'json', req, runtime)
        )

    async def extract_facial_feature_with_options_async(
        self,
        request: dingtalksmart_device__1__0_models.ExtractFacialFeatureRequest,
        headers: dingtalksmart_device__1__0_models.ExtractFacialFeatureHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            dingtalksmart_device__1__0_models.ExtractFacialFeatureResponse(),
            await self.do_roarequest_async('ExtractFacialFeature', 'smartDevice_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/smartDevice/faceRecognitions/features/extract', 'json', req, runtime)
        )
