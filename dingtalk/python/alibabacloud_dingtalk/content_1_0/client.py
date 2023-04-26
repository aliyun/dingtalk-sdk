# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.content_1_0 import models as dingtalkcontent__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.feed_info):
            body['feedInfo'] = request.feed_info
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
            action='CreateFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.CreateFeedResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.create_user_id):
            body['createUserId'] = request.create_user_id
        if not UtilClient.is_unset(request.feed_info):
            body['feedInfo'] = request.feed_info
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
            action='CreateFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.CreateFeedResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_feed_with_options(
        self,
        feed_id: str,
        request: dingtalkcontent__1__0_models.GetFeedRequest,
        headers: dingtalkcontent__1__0_models.GetFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetFeedResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
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
            action='GetFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/{feed_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.GetFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def get_feed_with_options_async(
        self,
        feed_id: str,
        request: dingtalkcontent__1__0_models.GetFeedRequest,
        headers: dingtalkcontent__1__0_models.GetFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetFeedResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
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
            action='GetFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/{feed_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.GetFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_feed(
        self,
        feed_id: str,
        request: dingtalkcontent__1__0_models.GetFeedRequest,
    ) -> dingtalkcontent__1__0_models.GetFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.GetFeedHeaders()
        return self.get_feed_with_options(feed_id, request, headers, runtime)

    async def get_feed_async(
        self,
        feed_id: str,
        request: dingtalkcontent__1__0_models.GetFeedRequest,
    ) -> dingtalkcontent__1__0_models.GetFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.GetFeedHeaders()
        return await self.get_feed_with_options_async(feed_id, request, headers, runtime)

    def get_media_cerficate_with_options(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
        headers: dingtalkcontent__1__0_models.GetMediaCerficateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.media_introduction):
            query['mediaIntroduction'] = request.media_introduction
        if not UtilClient.is_unset(request.media_title):
            query['mediaTitle'] = request.media_title
        if not UtilClient.is_unset(request.thumb_url):
            query['thumbUrl'] = request.thumb_url
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='GetMediaCerficate',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/media/cerficates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.GetMediaCerficateResponse(),
            self.execute(params, req, runtime)
        )

    async def get_media_cerficate_with_options_async(
        self,
        request: dingtalkcontent__1__0_models.GetMediaCerficateRequest,
        headers: dingtalkcontent__1__0_models.GetMediaCerficateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.GetMediaCerficateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.media_introduction):
            query['mediaIntroduction'] = request.media_introduction
        if not UtilClient.is_unset(request.media_title):
            query['mediaTitle'] = request.media_title
        if not UtilClient.is_unset(request.thumb_url):
            query['thumbUrl'] = request.thumb_url
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            action='GetMediaCerficate',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/media/cerficates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.GetMediaCerficateResponse(),
            await self.execute_async(params, req, runtime)
        )

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

    def list_item_user_data_with_options(
        self,
        item_id: str,
        request: dingtalkcontent__1__0_models.ListItemUserDataRequest,
        headers: dingtalkcontent__1__0_models.ListItemUserDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.ListItemUserDataResponse:
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListItemUserData',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/items/{item_id}/userStatistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.ListItemUserDataResponse(),
            self.execute(params, req, runtime)
        )

    async def list_item_user_data_with_options_async(
        self,
        item_id: str,
        request: dingtalkcontent__1__0_models.ListItemUserDataRequest,
        headers: dingtalkcontent__1__0_models.ListItemUserDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.ListItemUserDataResponse:
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListItemUserData',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/items/{item_id}/userStatistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.ListItemUserDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_item_user_data(
        self,
        item_id: str,
        request: dingtalkcontent__1__0_models.ListItemUserDataRequest,
    ) -> dingtalkcontent__1__0_models.ListItemUserDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.ListItemUserDataHeaders()
        return self.list_item_user_data_with_options(item_id, request, headers, runtime)

    async def list_item_user_data_async(
        self,
        item_id: str,
        request: dingtalkcontent__1__0_models.ListItemUserDataRequest,
    ) -> dingtalkcontent__1__0_models.ListItemUserDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.ListItemUserDataHeaders()
        return await self.list_item_user_data_with_options_async(item_id, request, headers, runtime)

    def page_feed_with_options(
        self,
        request: dingtalkcontent__1__0_models.PageFeedRequest,
        headers: dingtalkcontent__1__0_models.PageFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.PageFeedResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        params = open_api_models.Params(
            action='PageFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.PageFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def page_feed_with_options_async(
        self,
        request: dingtalkcontent__1__0_models.PageFeedRequest,
        headers: dingtalkcontent__1__0_models.PageFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontent__1__0_models.PageFeedResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.mcn_id):
            query['mcnId'] = request.mcn_id
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=request.body
        )
        params = open_api_models.Params(
            action='PageFeed',
            version='content_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/content/feeds/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontent__1__0_models.PageFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_feed(
        self,
        request: dingtalkcontent__1__0_models.PageFeedRequest,
    ) -> dingtalkcontent__1__0_models.PageFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.PageFeedHeaders()
        return self.page_feed_with_options(request, headers, runtime)

    async def page_feed_async(
        self,
        request: dingtalkcontent__1__0_models.PageFeedRequest,
    ) -> dingtalkcontent__1__0_models.PageFeedResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontent__1__0_models.PageFeedHeaders()
        return await self.page_feed_with_options_async(request, headers, runtime)
