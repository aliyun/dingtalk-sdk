# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkcontent_1_0 import models as dingtalkcontent__1__0_models
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

    def get_media_cerficate(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.GetMediaCerficateHeaders()
        return self.get_media_cerficate_with_options(request, headers, runtime)

    async def get_media_cerficate_async(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.GetMediaCerficateHeaders()
        return await self.get_media_cerficate_with_options_async(request, headers, runtime)

    def get_media_cerficate_with_options(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
        headers: dingtalkcontent__1__0_models.GetMediaCerficateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.thumb_url):
            query['thumbUrl'] = request.thumb_url
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.media_title):
            query['mediaTitle'] = request.media_title
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.media_introduction):
            query['mediaIntroduction'] = request.media_introduction
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
            dingtalkcontent__1__0_models.GetMediaCerficateResponse(),
            self.do_roarequest('GetMediaCerficate', 'content_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/content/media/cerficates', 'json', req, runtime)
        )

    async def get_media_cerficate_with_options_async(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
        headers: dingtalkcontent__1__0_models.GetMediaCerficateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.thumb_url):
            query['thumbUrl'] = request.thumb_url
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.media_title):
            query['mediaTitle'] = request.media_title
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.media_introduction):
            query['mediaIntroduction'] = request.media_introduction
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
            dingtalkcontent__1__0_models.GetMediaCerficateResponse(),
            await self.do_roarequest_async('GetMediaCerficate', 'content_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/content/media/cerficates', 'json', req, runtime)
        )

    def create_feed(
        self,
        request: dingtalkcontent__1__0_models.CreateFeedRequest,
    ) -> dingtalkcontent__1__0_models.CreateFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.CreateFeedHeaders()
        return self.create_feed_with_options(request, headers, runtime)

    async def create_feed_async(
        self,
        request: dingtalkcontent__1__0_models.CreateFeedRequest,
    ) -> dingtalkcontent__1__0_models.CreateFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.CreateFeedHeaders()
        return await self.create_feed_with_options_async(request, headers, runtime)

    def create_feed_with_options(
        self,
        request: dingtalkcontent__1__0_models.CreateFeedRequest,
        headers: dingtalkcontent__1__0_models.CreateFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.CreateFeedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_info):
            body['courseInfo'] = request.course_info
        if not UtilClient.is_unset(request.feed_info):
            body['feedInfo'] = request.feed_info
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
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
            dingtalkcontent__1__0_models.CreateFeedResponse(),
            self.do_roarequest('CreateFeed', 'content_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/content/feeds', 'json', req, runtime)
        )

    async def create_feed_with_options_async(
        self,
        request: dingtalkcontent__1__0_models.CreateFeedRequest,
        headers: dingtalkcontent__1__0_models.CreateFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.CreateFeedResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.course_info):
            body['courseInfo'] = request.course_info
        if not UtilClient.is_unset(request.feed_info):
            body['feedInfo'] = request.feed_info
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
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
            dingtalkcontent__1__0_models.CreateFeedResponse(),
            await self.do_roarequest_async('CreateFeed', 'content_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/content/feeds', 'json', req, runtime)
        )
