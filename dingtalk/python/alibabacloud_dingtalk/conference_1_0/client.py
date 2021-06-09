# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkconference_1_0 import models as dingtalkconference__1__0_models
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

    def query_conference_info_batch(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders()
        return self.query_conference_info_batch_with_options(request, headers, runtime)

    async def query_conference_info_batch_async(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders()
        return await self.query_conference_info_batch_with_options_async(request, headers, runtime)

    def query_conference_info_batch_with_options(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conference_id_list):
            body['conferenceIdList'] = request.conference_id_list
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
            dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse(),
            self.do_roarequest('QueryConferenceInfoBatch', 'conference_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/conference/videoConferences/query', 'json', req, runtime)
        )

    async def query_conference_info_batch_with_options_async(
        self,
        request: dingtalkconference__1__0_models.QueryConferenceInfoBatchRequest,
        headers: dingtalkconference__1__0_models.QueryConferenceInfoBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conference_id_list):
            body['conferenceIdList'] = request.conference_id_list
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
            dingtalkconference__1__0_models.QueryConferenceInfoBatchResponse(),
            await self.do_roarequest_async('QueryConferenceInfoBatch', 'conference_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/conference/videoConferences/query', 'json', req, runtime)
        )

    def create_video_conference(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateVideoConferenceHeaders()
        return self.create_video_conference_with_options(request, headers, runtime)

    async def create_video_conference_async(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CreateVideoConferenceHeaders()
        return await self.create_video_conference_with_options_async(request, headers, runtime)

    def create_video_conference_with_options(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.invite_user_ids):
            body['inviteUserIds'] = request.invite_user_ids
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
            dingtalkconference__1__0_models.CreateVideoConferenceResponse(),
            self.do_roarequest('CreateVideoConference', 'conference_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/conference/videoConferences', 'json', req, runtime)
        )

    async def create_video_conference_with_options_async(
        self,
        request: dingtalkconference__1__0_models.CreateVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CreateVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CreateVideoConferenceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.conf_title):
            body['confTitle'] = request.conf_title
        if not UtilClient.is_unset(request.invite_user_ids):
            body['inviteUserIds'] = request.invite_user_ids
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
            dingtalkconference__1__0_models.CreateVideoConferenceResponse(),
            await self.do_roarequest_async('CreateVideoConference', 'conference_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/conference/videoConferences', 'json', req, runtime)
        )

    def close_video_conference(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CloseVideoConferenceHeaders()
        return self.close_video_conference_with_options(conference_id, request, headers, runtime)

    async def close_video_conference_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconference__1__0_models.CloseVideoConferenceHeaders()
        return await self.close_video_conference_with_options_async(conference_id, request, headers, runtime)

    def close_video_conference_with_options(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CloseVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CloseVideoConferenceResponse(),
            self.do_roarequest('CloseVideoConference', 'conference_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/conference/videoConferences/{conference_id}', 'json', req, runtime)
        )

    async def close_video_conference_with_options_async(
        self,
        conference_id: str,
        request: dingtalkconference__1__0_models.CloseVideoConferenceRequest,
        headers: dingtalkconference__1__0_models.CloseVideoConferenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconference__1__0_models.CloseVideoConferenceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkconference__1__0_models.CloseVideoConferenceResponse(),
            await self.do_roarequest_async('CloseVideoConference', 'conference_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/conference/videoConferences/{conference_id}', 'json', req, runtime)
        )
