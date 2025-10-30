# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ding_one_1_0 import models as dingtalkding_one__1__0_models
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

    def deliver_one_feed_with_options(
        self,
        request: dingtalkding_one__1__0_models.DeliverOneFeedRequest,
        headers: dingtalkding_one__1__0_models.DeliverOneFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_one__1__0_models.DeliverOneFeedResponse:
        """
        @summary 投放钉钉one中feed流资讯内容
        
        @param request: DeliverOneFeedRequest
        @param headers: DeliverOneFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverOneFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.cover_media_id):
            body['coverMediaId'] = request.cover_media_id
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.video_media_id):
            body['videoMediaId'] = request.video_media_id
        if not UtilClient.is_unset(request.video_tags):
            body['videoTags'] = request.video_tags
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
            action='DeliverOneFeed',
            version='dingOne_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingOne/feed/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_one__1__0_models.DeliverOneFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def deliver_one_feed_with_options_async(
        self,
        request: dingtalkding_one__1__0_models.DeliverOneFeedRequest,
        headers: dingtalkding_one__1__0_models.DeliverOneFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_one__1__0_models.DeliverOneFeedResponse:
        """
        @summary 投放钉钉one中feed流资讯内容
        
        @param request: DeliverOneFeedRequest
        @param headers: DeliverOneFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeliverOneFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.cover_media_id):
            body['coverMediaId'] = request.cover_media_id
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.summary):
            body['summary'] = request.summary
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.video_media_id):
            body['videoMediaId'] = request.video_media_id
        if not UtilClient.is_unset(request.video_tags):
            body['videoTags'] = request.video_tags
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
            action='DeliverOneFeed',
            version='dingOne_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingOne/feed/deliver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_one__1__0_models.DeliverOneFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deliver_one_feed(
        self,
        request: dingtalkding_one__1__0_models.DeliverOneFeedRequest,
    ) -> dingtalkding_one__1__0_models.DeliverOneFeedResponse:
        """
        @summary 投放钉钉one中feed流资讯内容
        
        @param request: DeliverOneFeedRequest
        @return: DeliverOneFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_one__1__0_models.DeliverOneFeedHeaders()
        return self.deliver_one_feed_with_options(request, headers, runtime)

    async def deliver_one_feed_async(
        self,
        request: dingtalkding_one__1__0_models.DeliverOneFeedRequest,
    ) -> dingtalkding_one__1__0_models.DeliverOneFeedResponse:
        """
        @summary 投放钉钉one中feed流资讯内容
        
        @param request: DeliverOneFeedRequest
        @return: DeliverOneFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_one__1__0_models.DeliverOneFeedHeaders()
        return await self.deliver_one_feed_with_options_async(request, headers, runtime)
