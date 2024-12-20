# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.live_1_0 import models as dingtalklive__1__0_models
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

    def add_live_interaction_plugin_with_options(
        self,
        request: dingtalklive__1__0_models.AddLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.AddLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddLiveInteractionPluginResponse:
        """
        @summary 增加直播间互动插件
        
        @param request: AddLiveInteractionPluginRequest
        @param headers: AddLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.anchor_jump_url):
            body['anchorJumpUrl'] = request.anchor_jump_url
        if not UtilClient.is_unset(request.plugin_icon_url):
            body['pluginIconUrl'] = request.plugin_icon_url
        if not UtilClient.is_unset(request.plugin_name):
            body['pluginName'] = request.plugin_name
        if not UtilClient.is_unset(request.plugin_name_en):
            body['pluginNameEn'] = request.plugin_name_en
        if not UtilClient.is_unset(request.viewer_jump_url):
            body['viewerJumpUrl'] = request.viewer_jump_url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddLiveInteractionPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def add_live_interaction_plugin_with_options_async(
        self,
        request: dingtalklive__1__0_models.AddLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.AddLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddLiveInteractionPluginResponse:
        """
        @summary 增加直播间互动插件
        
        @param request: AddLiveInteractionPluginRequest
        @param headers: AddLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.anchor_jump_url):
            body['anchorJumpUrl'] = request.anchor_jump_url
        if not UtilClient.is_unset(request.plugin_icon_url):
            body['pluginIconUrl'] = request.plugin_icon_url
        if not UtilClient.is_unset(request.plugin_name):
            body['pluginName'] = request.plugin_name
        if not UtilClient.is_unset(request.plugin_name_en):
            body['pluginNameEn'] = request.plugin_name_en
        if not UtilClient.is_unset(request.viewer_jump_url):
            body['viewerJumpUrl'] = request.viewer_jump_url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddLiveInteractionPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_live_interaction_plugin(
        self,
        request: dingtalklive__1__0_models.AddLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.AddLiveInteractionPluginResponse:
        """
        @summary 增加直播间互动插件
        
        @param request: AddLiveInteractionPluginRequest
        @return: AddLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddLiveInteractionPluginHeaders()
        return self.add_live_interaction_plugin_with_options(request, headers, runtime)

    async def add_live_interaction_plugin_async(
        self,
        request: dingtalklive__1__0_models.AddLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.AddLiveInteractionPluginResponse:
        """
        @summary 增加直播间互动插件
        
        @param request: AddLiveInteractionPluginRequest
        @return: AddLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddLiveInteractionPluginHeaders()
        return await self.add_live_interaction_plugin_with_options_async(request, headers, runtime)

    def add_live_notice_widget_with_options(
        self,
        request: dingtalklive__1__0_models.AddLiveNoticeWidgetRequest,
        headers: dingtalklive__1__0_models.AddLiveNoticeWidgetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddLiveNoticeWidgetResponse:
        """
        @summary 增加直播间的公告槽位信息
        
        @param request: AddLiveNoticeWidgetRequest
        @param headers: AddLiveNoticeWidgetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLiveNoticeWidgetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.icon_url):
            query['iconUrl'] = request.icon_url
        if not UtilClient.is_unset(request.jump_url):
            query['jumpUrl'] = request.jump_url
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.notice_text):
            query['noticeText'] = request.notice_text
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
            action='AddLiveNoticeWidget',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/noticeWidgets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddLiveNoticeWidgetResponse(),
            self.execute(params, req, runtime)
        )

    async def add_live_notice_widget_with_options_async(
        self,
        request: dingtalklive__1__0_models.AddLiveNoticeWidgetRequest,
        headers: dingtalklive__1__0_models.AddLiveNoticeWidgetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddLiveNoticeWidgetResponse:
        """
        @summary 增加直播间的公告槽位信息
        
        @param request: AddLiveNoticeWidgetRequest
        @param headers: AddLiveNoticeWidgetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLiveNoticeWidgetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.icon_url):
            query['iconUrl'] = request.icon_url
        if not UtilClient.is_unset(request.jump_url):
            query['jumpUrl'] = request.jump_url
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.notice_text):
            query['noticeText'] = request.notice_text
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
            action='AddLiveNoticeWidget',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/noticeWidgets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddLiveNoticeWidgetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_live_notice_widget(
        self,
        request: dingtalklive__1__0_models.AddLiveNoticeWidgetRequest,
    ) -> dingtalklive__1__0_models.AddLiveNoticeWidgetResponse:
        """
        @summary 增加直播间的公告槽位信息
        
        @param request: AddLiveNoticeWidgetRequest
        @return: AddLiveNoticeWidgetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddLiveNoticeWidgetHeaders()
        return self.add_live_notice_widget_with_options(request, headers, runtime)

    async def add_live_notice_widget_async(
        self,
        request: dingtalklive__1__0_models.AddLiveNoticeWidgetRequest,
    ) -> dingtalklive__1__0_models.AddLiveNoticeWidgetResponse:
        """
        @summary 增加直播间的公告槽位信息
        
        @param request: AddLiveNoticeWidgetRequest
        @return: AddLiveNoticeWidgetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddLiveNoticeWidgetHeaders()
        return await self.add_live_notice_widget_with_options_async(request, headers, runtime)

    def add_share_cid_list_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.AddShareCidListRequest,
        headers: dingtalklive__1__0_models.AddShareCidListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddShareCidListResponse:
        """
        @summary 添加云导播联播群列表
        
        @param request: AddShareCidListRequest
        @param headers: AddShareCidListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddShareCidListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id_type):
            body['groupIdType'] = request.group_id_type
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
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
            action='AddShareCidList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/share',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddShareCidListResponse(),
            self.execute(params, req, runtime)
        )

    async def add_share_cid_list_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.AddShareCidListRequest,
        headers: dingtalklive__1__0_models.AddShareCidListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.AddShareCidListResponse:
        """
        @summary 添加云导播联播群列表
        
        @param request: AddShareCidListRequest
        @param headers: AddShareCidListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddShareCidListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id_type):
            body['groupIdType'] = request.group_id_type
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
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
            action='AddShareCidList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/share',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.AddShareCidListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_share_cid_list(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.AddShareCidListRequest,
    ) -> dingtalklive__1__0_models.AddShareCidListResponse:
        """
        @summary 添加云导播联播群列表
        
        @param request: AddShareCidListRequest
        @return: AddShareCidListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddShareCidListHeaders()
        return self.add_share_cid_list_with_options(feed_id, request, headers, runtime)

    async def add_share_cid_list_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.AddShareCidListRequest,
    ) -> dingtalklive__1__0_models.AddShareCidListResponse:
        """
        @summary 添加云导播联播群列表
        
        @param request: AddShareCidListRequest
        @return: AddShareCidListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.AddShareCidListHeaders()
        return await self.add_share_cid_list_with_options_async(feed_id, request, headers, runtime)

    def create_cloud_feed_with_options(
        self,
        request: dingtalklive__1__0_models.CreateCloudFeedRequest,
        headers: dingtalklive__1__0_models.CreateCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.CreateCloudFeedResponse:
        """
        @summary 创建云导播课程
        
        @param request: CreateCloudFeedRequest
        @param headers: CreateCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.intro):
            body['intro'] = request.intro
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.video_url):
            body['videoUrl'] = request.video_url
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
            action='CreateCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.CreateCloudFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def create_cloud_feed_with_options_async(
        self,
        request: dingtalklive__1__0_models.CreateCloudFeedRequest,
        headers: dingtalklive__1__0_models.CreateCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.CreateCloudFeedResponse:
        """
        @summary 创建云导播课程
        
        @param request: CreateCloudFeedRequest
        @param headers: CreateCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.intro):
            body['intro'] = request.intro
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.video_url):
            body['videoUrl'] = request.video_url
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
            action='CreateCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.CreateCloudFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_cloud_feed(
        self,
        request: dingtalklive__1__0_models.CreateCloudFeedRequest,
    ) -> dingtalklive__1__0_models.CreateCloudFeedResponse:
        """
        @summary 创建云导播课程
        
        @param request: CreateCloudFeedRequest
        @return: CreateCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.CreateCloudFeedHeaders()
        return self.create_cloud_feed_with_options(request, headers, runtime)

    async def create_cloud_feed_async(
        self,
        request: dingtalklive__1__0_models.CreateCloudFeedRequest,
    ) -> dingtalklive__1__0_models.CreateCloudFeedResponse:
        """
        @summary 创建云导播课程
        
        @param request: CreateCloudFeedRequest
        @return: CreateCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.CreateCloudFeedHeaders()
        return await self.create_cloud_feed_with_options_async(request, headers, runtime)

    def create_live_with_options(
        self,
        request: dingtalklive__1__0_models.CreateLiveRequest,
        headers: dingtalklive__1__0_models.CreateLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.CreateLiveResponse:
        """
        @summary 创建直播
        
        @param request: CreateLiveRequest
        @param headers: CreateLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateLiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.pre_end_time):
            body['preEndTime'] = request.pre_end_time
        if not UtilClient.is_unset(request.pre_start_time):
            body['preStartTime'] = request.pre_start_time
        if not UtilClient.is_unset(request.public_type):
            body['publicType'] = request.public_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.CreateLiveResponse(),
            self.execute(params, req, runtime)
        )

    async def create_live_with_options_async(
        self,
        request: dingtalklive__1__0_models.CreateLiveRequest,
        headers: dingtalklive__1__0_models.CreateLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.CreateLiveResponse:
        """
        @summary 创建直播
        
        @param request: CreateLiveRequest
        @param headers: CreateLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateLiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.pre_end_time):
            body['preEndTime'] = request.pre_end_time
        if not UtilClient.is_unset(request.pre_start_time):
            body['preStartTime'] = request.pre_start_time
        if not UtilClient.is_unset(request.public_type):
            body['publicType'] = request.public_type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='CreateLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.CreateLiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_live(
        self,
        request: dingtalklive__1__0_models.CreateLiveRequest,
    ) -> dingtalklive__1__0_models.CreateLiveResponse:
        """
        @summary 创建直播
        
        @param request: CreateLiveRequest
        @return: CreateLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.CreateLiveHeaders()
        return self.create_live_with_options(request, headers, runtime)

    async def create_live_async(
        self,
        request: dingtalklive__1__0_models.CreateLiveRequest,
    ) -> dingtalklive__1__0_models.CreateLiveResponse:
        """
        @summary 创建直播
        
        @param request: CreateLiveRequest
        @return: CreateLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.CreateLiveHeaders()
        return await self.create_live_with_options_async(request, headers, runtime)

    def del_live_interaction_plugin_with_options(
        self,
        request: dingtalklive__1__0_models.DelLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.DelLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DelLiveInteractionPluginResponse:
        """
        @summary 删除直播间内某一互动插件
        
        @param request: DelLiveInteractionPluginRequest
        @param headers: DelLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='DelLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DelLiveInteractionPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def del_live_interaction_plugin_with_options_async(
        self,
        request: dingtalklive__1__0_models.DelLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.DelLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DelLiveInteractionPluginResponse:
        """
        @summary 删除直播间内某一互动插件
        
        @param request: DelLiveInteractionPluginRequest
        @param headers: DelLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='DelLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DelLiveInteractionPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def del_live_interaction_plugin(
        self,
        request: dingtalklive__1__0_models.DelLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.DelLiveInteractionPluginResponse:
        """
        @summary 删除直播间内某一互动插件
        
        @param request: DelLiveInteractionPluginRequest
        @return: DelLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DelLiveInteractionPluginHeaders()
        return self.del_live_interaction_plugin_with_options(request, headers, runtime)

    async def del_live_interaction_plugin_async(
        self,
        request: dingtalklive__1__0_models.DelLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.DelLiveInteractionPluginResponse:
        """
        @summary 删除直播间内某一互动插件
        
        @param request: DelLiveInteractionPluginRequest
        @return: DelLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DelLiveInteractionPluginHeaders()
        return await self.del_live_interaction_plugin_with_options_async(request, headers, runtime)

    def del_live_notice_widget_with_options(
        self,
        request: dingtalklive__1__0_models.DelLiveNoticeWidgetRequest,
        headers: dingtalklive__1__0_models.DelLiveNoticeWidgetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DelLiveNoticeWidgetResponse:
        """
        @summary 删除直播间的公告槽位信息
        
        @param request: DelLiveNoticeWidgetRequest
        @param headers: DelLiveNoticeWidgetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelLiveNoticeWidgetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='DelLiveNoticeWidget',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/noticeWidgets',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DelLiveNoticeWidgetResponse(),
            self.execute(params, req, runtime)
        )

    async def del_live_notice_widget_with_options_async(
        self,
        request: dingtalklive__1__0_models.DelLiveNoticeWidgetRequest,
        headers: dingtalklive__1__0_models.DelLiveNoticeWidgetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DelLiveNoticeWidgetResponse:
        """
        @summary 删除直播间的公告槽位信息
        
        @param request: DelLiveNoticeWidgetRequest
        @param headers: DelLiveNoticeWidgetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelLiveNoticeWidgetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='DelLiveNoticeWidget',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/noticeWidgets',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DelLiveNoticeWidgetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def del_live_notice_widget(
        self,
        request: dingtalklive__1__0_models.DelLiveNoticeWidgetRequest,
    ) -> dingtalklive__1__0_models.DelLiveNoticeWidgetResponse:
        """
        @summary 删除直播间的公告槽位信息
        
        @param request: DelLiveNoticeWidgetRequest
        @return: DelLiveNoticeWidgetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DelLiveNoticeWidgetHeaders()
        return self.del_live_notice_widget_with_options(request, headers, runtime)

    async def del_live_notice_widget_async(
        self,
        request: dingtalklive__1__0_models.DelLiveNoticeWidgetRequest,
    ) -> dingtalklive__1__0_models.DelLiveNoticeWidgetResponse:
        """
        @summary 删除直播间的公告槽位信息
        
        @param request: DelLiveNoticeWidgetRequest
        @return: DelLiveNoticeWidgetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DelLiveNoticeWidgetHeaders()
        return await self.del_live_notice_widget_with_options_async(request, headers, runtime)

    def delete_live_with_options(
        self,
        request: dingtalklive__1__0_models.DeleteLiveRequest,
        headers: dingtalklive__1__0_models.DeleteLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DeleteLiveResponse:
        """
        @summary 删除直播
        
        @param request: DeleteLiveRequest
        @param headers: DeleteLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='DeleteLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DeleteLiveResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_live_with_options_async(
        self,
        request: dingtalklive__1__0_models.DeleteLiveRequest,
        headers: dingtalklive__1__0_models.DeleteLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DeleteLiveResponse:
        """
        @summary 删除直播
        
        @param request: DeleteLiveRequest
        @param headers: DeleteLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='DeleteLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DeleteLiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_live(
        self,
        request: dingtalklive__1__0_models.DeleteLiveRequest,
    ) -> dingtalklive__1__0_models.DeleteLiveResponse:
        """
        @summary 删除直播
        
        @param request: DeleteLiveRequest
        @return: DeleteLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DeleteLiveHeaders()
        return self.delete_live_with_options(request, headers, runtime)

    async def delete_live_async(
        self,
        request: dingtalklive__1__0_models.DeleteLiveRequest,
    ) -> dingtalklive__1__0_models.DeleteLiveResponse:
        """
        @summary 删除直播
        
        @param request: DeleteLiveRequest
        @return: DeleteLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DeleteLiveHeaders()
        return await self.delete_live_with_options_async(request, headers, runtime)

    def delete_live_feed_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.DeleteLiveFeedRequest,
        headers: dingtalklive__1__0_models.DeleteLiveFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DeleteLiveFeedResponse:
        """
        @summary 删除直播培训课程
        
        @param request: DeleteLiveFeedRequest
        @param headers: DeleteLiveFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLiveFeedResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='DeleteLiveFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DeleteLiveFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_live_feed_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.DeleteLiveFeedRequest,
        headers: dingtalklive__1__0_models.DeleteLiveFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.DeleteLiveFeedResponse:
        """
        @summary 删除直播培训课程
        
        @param request: DeleteLiveFeedRequest
        @param headers: DeleteLiveFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteLiveFeedResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='DeleteLiveFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.DeleteLiveFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_live_feed(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.DeleteLiveFeedRequest,
    ) -> dingtalklive__1__0_models.DeleteLiveFeedResponse:
        """
        @summary 删除直播培训课程
        
        @param request: DeleteLiveFeedRequest
        @return: DeleteLiveFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DeleteLiveFeedHeaders()
        return self.delete_live_feed_with_options(feed_id, request, headers, runtime)

    async def delete_live_feed_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.DeleteLiveFeedRequest,
    ) -> dingtalklive__1__0_models.DeleteLiveFeedResponse:
        """
        @summary 删除直播培训课程
        
        @param request: DeleteLiveFeedRequest
        @return: DeleteLiveFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.DeleteLiveFeedHeaders()
        return await self.delete_live_feed_with_options_async(feed_id, request, headers, runtime)

    def edit_feed_replay_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.EditFeedReplayRequest,
        headers: dingtalklive__1__0_models.EditFeedReplayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.EditFeedReplayResponse:
        """
        @summary 剪辑直播课程的回放
        
        @param request: EditFeedReplayRequest
        @param headers: EditFeedReplayHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditFeedReplayResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.edit_end_time):
            body['editEndTime'] = request.edit_end_time
        if not UtilClient.is_unset(request.edit_start_time):
            body['editStartTime'] = request.edit_start_time
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
            action='EditFeedReplay',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/cutReplay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.EditFeedReplayResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_feed_replay_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.EditFeedReplayRequest,
        headers: dingtalklive__1__0_models.EditFeedReplayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.EditFeedReplayResponse:
        """
        @summary 剪辑直播课程的回放
        
        @param request: EditFeedReplayRequest
        @param headers: EditFeedReplayHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditFeedReplayResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.edit_end_time):
            body['editEndTime'] = request.edit_end_time
        if not UtilClient.is_unset(request.edit_start_time):
            body['editStartTime'] = request.edit_start_time
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
            action='EditFeedReplay',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/cutReplay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.EditFeedReplayResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_feed_replay(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.EditFeedReplayRequest,
    ) -> dingtalklive__1__0_models.EditFeedReplayResponse:
        """
        @summary 剪辑直播课程的回放
        
        @param request: EditFeedReplayRequest
        @return: EditFeedReplayResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.EditFeedReplayHeaders()
        return self.edit_feed_replay_with_options(feed_id, request, headers, runtime)

    async def edit_feed_replay_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.EditFeedReplayRequest,
    ) -> dingtalklive__1__0_models.EditFeedReplayResponse:
        """
        @summary 剪辑直播课程的回放
        
        @param request: EditFeedReplayRequest
        @return: EditFeedReplayResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.EditFeedReplayHeaders()
        return await self.edit_feed_replay_with_options_async(feed_id, request, headers, runtime)

    def get_group_live_list_with_options(
        self,
        tmp_req: dingtalklive__1__0_models.GetGroupLiveListRequest,
        headers: dingtalklive__1__0_models.GetGroupLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetGroupLiveListResponse:
        """
        @summary 获取群内的直播列表
        
        @param tmp_req: GetGroupLiveListRequest
        @param headers: GetGroupLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupLiveListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.GetGroupLiveListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request_body):
            request.request_body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request_body, 'requestBody', 'json')
        query = {}
        if not UtilClient.is_unset(request.request_body_shrink):
            query['requestBody'] = request.request_body_shrink
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
            action='GetGroupLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/groupLives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetGroupLiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_group_live_list_with_options_async(
        self,
        tmp_req: dingtalklive__1__0_models.GetGroupLiveListRequest,
        headers: dingtalklive__1__0_models.GetGroupLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetGroupLiveListResponse:
        """
        @summary 获取群内的直播列表
        
        @param tmp_req: GetGroupLiveListRequest
        @param headers: GetGroupLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupLiveListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.GetGroupLiveListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request_body):
            request.request_body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request_body, 'requestBody', 'json')
        query = {}
        if not UtilClient.is_unset(request.request_body_shrink):
            query['requestBody'] = request.request_body_shrink
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
            action='GetGroupLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/groupLives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetGroupLiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_group_live_list(
        self,
        request: dingtalklive__1__0_models.GetGroupLiveListRequest,
    ) -> dingtalklive__1__0_models.GetGroupLiveListResponse:
        """
        @summary 获取群内的直播列表
        
        @param request: GetGroupLiveListRequest
        @return: GetGroupLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetGroupLiveListHeaders()
        return self.get_group_live_list_with_options(request, headers, runtime)

    async def get_group_live_list_async(
        self,
        request: dingtalklive__1__0_models.GetGroupLiveListRequest,
    ) -> dingtalklive__1__0_models.GetGroupLiveListResponse:
        """
        @summary 获取群内的直播列表
        
        @param request: GetGroupLiveListRequest
        @return: GetGroupLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetGroupLiveListHeaders()
        return await self.get_group_live_list_with_options_async(request, headers, runtime)

    def get_live_replay_url_with_options(
        self,
        request: dingtalklive__1__0_models.GetLiveReplayUrlRequest,
        headers: dingtalklive__1__0_models.GetLiveReplayUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetLiveReplayUrlResponse:
        """
        @summary 获取直播的可下载回放地址
        
        @param request: GetLiveReplayUrlRequest
        @param headers: GetLiveReplayUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLiveReplayUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='GetLiveReplayUrl',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/replayUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetLiveReplayUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_live_replay_url_with_options_async(
        self,
        request: dingtalklive__1__0_models.GetLiveReplayUrlRequest,
        headers: dingtalklive__1__0_models.GetLiveReplayUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetLiveReplayUrlResponse:
        """
        @summary 获取直播的可下载回放地址
        
        @param request: GetLiveReplayUrlRequest
        @param headers: GetLiveReplayUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLiveReplayUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='GetLiveReplayUrl',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/replayUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetLiveReplayUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_live_replay_url(
        self,
        request: dingtalklive__1__0_models.GetLiveReplayUrlRequest,
    ) -> dingtalklive__1__0_models.GetLiveReplayUrlResponse:
        """
        @summary 获取直播的可下载回放地址
        
        @param request: GetLiveReplayUrlRequest
        @return: GetLiveReplayUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetLiveReplayUrlHeaders()
        return self.get_live_replay_url_with_options(request, headers, runtime)

    async def get_live_replay_url_async(
        self,
        request: dingtalklive__1__0_models.GetLiveReplayUrlRequest,
    ) -> dingtalklive__1__0_models.GetLiveReplayUrlResponse:
        """
        @summary 获取直播的可下载回放地址
        
        @param request: GetLiveReplayUrlRequest
        @return: GetLiveReplayUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetLiveReplayUrlHeaders()
        return await self.get_live_replay_url_with_options_async(request, headers, runtime)

    def get_org_live_list_with_options(
        self,
        tmp_req: dingtalklive__1__0_models.GetOrgLiveListRequest,
        headers: dingtalklive__1__0_models.GetOrgLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetOrgLiveListResponse:
        """
        @summary 获取某组织内的直播列表
        
        @param tmp_req: GetOrgLiveListRequest
        @param headers: GetOrgLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgLiveListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.GetOrgLiveListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request_body):
            request.request_body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request_body, 'requestBody', 'json')
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.request_body_shrink):
            query['requestBody'] = request.request_body_shrink
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
            action='GetOrgLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/organizations/liveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetOrgLiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_org_live_list_with_options_async(
        self,
        tmp_req: dingtalklive__1__0_models.GetOrgLiveListRequest,
        headers: dingtalklive__1__0_models.GetOrgLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetOrgLiveListResponse:
        """
        @summary 获取某组织内的直播列表
        
        @param tmp_req: GetOrgLiveListRequest
        @param headers: GetOrgLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgLiveListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.GetOrgLiveListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.request_body):
            request.request_body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.request_body, 'requestBody', 'json')
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.request_body_shrink):
            query['requestBody'] = request.request_body_shrink
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
            action='GetOrgLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/organizations/liveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetOrgLiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_org_live_list(
        self,
        request: dingtalklive__1__0_models.GetOrgLiveListRequest,
    ) -> dingtalklive__1__0_models.GetOrgLiveListResponse:
        """
        @summary 获取某组织内的直播列表
        
        @param request: GetOrgLiveListRequest
        @return: GetOrgLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetOrgLiveListHeaders()
        return self.get_org_live_list_with_options(request, headers, runtime)

    async def get_org_live_list_async(
        self,
        request: dingtalklive__1__0_models.GetOrgLiveListRequest,
    ) -> dingtalklive__1__0_models.GetOrgLiveListResponse:
        """
        @summary 获取某组织内的直播列表
        
        @param request: GetOrgLiveListRequest
        @return: GetOrgLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetOrgLiveListHeaders()
        return await self.get_org_live_list_with_options_async(request, headers, runtime)

    def get_user_all_live_list_with_options(
        self,
        request: dingtalklive__1__0_models.GetUserAllLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserAllLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserAllLiveListResponse:
        """
        @summary 根据状态拉我相关的直播
        
        @param request: GetUserAllLiveListRequest
        @param headers: GetUserAllLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAllLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.statuses):
            body['statuses'] = request.statuses
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserAllLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/allLiveInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserAllLiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_all_live_list_with_options_async(
        self,
        request: dingtalklive__1__0_models.GetUserAllLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserAllLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserAllLiveListResponse:
        """
        @summary 根据状态拉我相关的直播
        
        @param request: GetUserAllLiveListRequest
        @param headers: GetUserAllLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAllLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.statuses):
            body['statuses'] = request.statuses
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserAllLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/allLiveInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserAllLiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_all_live_list(
        self,
        request: dingtalklive__1__0_models.GetUserAllLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserAllLiveListResponse:
        """
        @summary 根据状态拉我相关的直播
        
        @param request: GetUserAllLiveListRequest
        @return: GetUserAllLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserAllLiveListHeaders()
        return self.get_user_all_live_list_with_options(request, headers, runtime)

    async def get_user_all_live_list_async(
        self,
        request: dingtalklive__1__0_models.GetUserAllLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserAllLiveListResponse:
        """
        @summary 根据状态拉我相关的直播
        
        @param request: GetUserAllLiveListRequest
        @return: GetUserAllLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserAllLiveListHeaders()
        return await self.get_user_all_live_list_with_options_async(request, headers, runtime)

    def get_user_create_live_list_with_options(
        self,
        request: dingtalklive__1__0_models.GetUserCreateLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserCreateLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserCreateLiveListResponse:
        """
        @summary 根据状态获取用户创建的直播
        
        @param request: GetUserCreateLiveListRequest
        @param headers: GetUserCreateLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserCreateLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.statuses):
            body['statuses'] = request.statuses
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserCreateLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/createLiveInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserCreateLiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_create_live_list_with_options_async(
        self,
        request: dingtalklive__1__0_models.GetUserCreateLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserCreateLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserCreateLiveListResponse:
        """
        @summary 根据状态获取用户创建的直播
        
        @param request: GetUserCreateLiveListRequest
        @param headers: GetUserCreateLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserCreateLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.statuses):
            body['statuses'] = request.statuses
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserCreateLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/createLiveInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserCreateLiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_create_live_list(
        self,
        request: dingtalklive__1__0_models.GetUserCreateLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserCreateLiveListResponse:
        """
        @summary 根据状态获取用户创建的直播
        
        @param request: GetUserCreateLiveListRequest
        @return: GetUserCreateLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserCreateLiveListHeaders()
        return self.get_user_create_live_list_with_options(request, headers, runtime)

    async def get_user_create_live_list_async(
        self,
        request: dingtalklive__1__0_models.GetUserCreateLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserCreateLiveListResponse:
        """
        @summary 根据状态获取用户创建的直播
        
        @param request: GetUserCreateLiveListRequest
        @return: GetUserCreateLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserCreateLiveListHeaders()
        return await self.get_user_create_live_list_with_options_async(request, headers, runtime)

    def get_user_watch_live_list_with_options(
        self,
        request: dingtalklive__1__0_models.GetUserWatchLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserWatchLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserWatchLiveListResponse:
        """
        @summary 获取用户观看直播记录
        
        @param request: GetUserWatchLiveListRequest
        @param headers: GetUserWatchLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserWatchLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.filter_type):
            query['filterType'] = request.filter_type
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
            action='GetUserWatchLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/watchRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserWatchLiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_watch_live_list_with_options_async(
        self,
        request: dingtalklive__1__0_models.GetUserWatchLiveListRequest,
        headers: dingtalklive__1__0_models.GetUserWatchLiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.GetUserWatchLiveListResponse:
        """
        @summary 获取用户观看直播记录
        
        @param request: GetUserWatchLiveListRequest
        @param headers: GetUserWatchLiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserWatchLiveListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.filter_type):
            query['filterType'] = request.filter_type
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
            action='GetUserWatchLiveList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/users/watchRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.GetUserWatchLiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_watch_live_list(
        self,
        request: dingtalklive__1__0_models.GetUserWatchLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserWatchLiveListResponse:
        """
        @summary 获取用户观看直播记录
        
        @param request: GetUserWatchLiveListRequest
        @return: GetUserWatchLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserWatchLiveListHeaders()
        return self.get_user_watch_live_list_with_options(request, headers, runtime)

    async def get_user_watch_live_list_async(
        self,
        request: dingtalklive__1__0_models.GetUserWatchLiveListRequest,
    ) -> dingtalklive__1__0_models.GetUserWatchLiveListResponse:
        """
        @summary 获取用户观看直播记录
        
        @param request: GetUserWatchLiveListRequest
        @return: GetUserWatchLiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.GetUserWatchLiveListHeaders()
        return await self.get_user_watch_live_list_with_options_async(request, headers, runtime)

    def modify_feed_white_list_with_options(
        self,
        feed_id: str,
        tmp_req: dingtalklive__1__0_models.ModifyFeedWhiteListRequest,
        headers: dingtalklive__1__0_models.ModifyFeedWhiteListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.ModifyFeedWhiteListResponse:
        """
        @summary 修改直播课程可见白名单
        
        @param tmp_req: ModifyFeedWhiteListRequest
        @param headers: ModifyFeedWhiteListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ModifyFeedWhiteListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.ModifyFeedWhiteListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.modify_user_list):
            request.modify_user_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.modify_user_list, 'modifyUserList', 'json')
        query = {}
        if not UtilClient.is_unset(request.action):
            query['action'] = request.action
        if not UtilClient.is_unset(request.modify_user_list_shrink):
            query['modifyUserList'] = request.modify_user_list_shrink
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
            action='ModifyFeedWhiteList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/whiteList',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.ModifyFeedWhiteListResponse(),
            self.execute(params, req, runtime)
        )

    async def modify_feed_white_list_with_options_async(
        self,
        feed_id: str,
        tmp_req: dingtalklive__1__0_models.ModifyFeedWhiteListRequest,
        headers: dingtalklive__1__0_models.ModifyFeedWhiteListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.ModifyFeedWhiteListResponse:
        """
        @summary 修改直播课程可见白名单
        
        @param tmp_req: ModifyFeedWhiteListRequest
        @param headers: ModifyFeedWhiteListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ModifyFeedWhiteListResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.ModifyFeedWhiteListShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.modify_user_list):
            request.modify_user_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.modify_user_list, 'modifyUserList', 'json')
        query = {}
        if not UtilClient.is_unset(request.action):
            query['action'] = request.action
        if not UtilClient.is_unset(request.modify_user_list_shrink):
            query['modifyUserList'] = request.modify_user_list_shrink
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
            action='ModifyFeedWhiteList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/whiteList',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.ModifyFeedWhiteListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def modify_feed_white_list(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.ModifyFeedWhiteListRequest,
    ) -> dingtalklive__1__0_models.ModifyFeedWhiteListResponse:
        """
        @summary 修改直播课程可见白名单
        
        @param request: ModifyFeedWhiteListRequest
        @return: ModifyFeedWhiteListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.ModifyFeedWhiteListHeaders()
        return self.modify_feed_white_list_with_options(feed_id, request, headers, runtime)

    async def modify_feed_white_list_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.ModifyFeedWhiteListRequest,
    ) -> dingtalklive__1__0_models.ModifyFeedWhiteListResponse:
        """
        @summary 修改直播课程可见白名单
        
        @param request: ModifyFeedWhiteListRequest
        @return: ModifyFeedWhiteListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.ModifyFeedWhiteListHeaders()
        return await self.modify_feed_white_list_with_options_async(feed_id, request, headers, runtime)

    def query_feed_white_list_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.QueryFeedWhiteListRequest,
        headers: dingtalklive__1__0_models.QueryFeedWhiteListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryFeedWhiteListResponse:
        """
        @summary 查询直播课程的观看白名单
        
        @param request: QueryFeedWhiteListRequest
        @param headers: QueryFeedWhiteListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryFeedWhiteListResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryFeedWhiteList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/whiteList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryFeedWhiteListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_feed_white_list_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.QueryFeedWhiteListRequest,
        headers: dingtalklive__1__0_models.QueryFeedWhiteListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryFeedWhiteListResponse:
        """
        @summary 查询直播课程的观看白名单
        
        @param request: QueryFeedWhiteListRequest
        @param headers: QueryFeedWhiteListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryFeedWhiteListResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryFeedWhiteList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}/whiteList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryFeedWhiteListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_feed_white_list(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.QueryFeedWhiteListRequest,
    ) -> dingtalklive__1__0_models.QueryFeedWhiteListResponse:
        """
        @summary 查询直播课程的观看白名单
        
        @param request: QueryFeedWhiteListRequest
        @return: QueryFeedWhiteListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryFeedWhiteListHeaders()
        return self.query_feed_white_list_with_options(feed_id, request, headers, runtime)

    async def query_feed_white_list_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.QueryFeedWhiteListRequest,
    ) -> dingtalklive__1__0_models.QueryFeedWhiteListResponse:
        """
        @summary 查询直播课程的观看白名单
        
        @param request: QueryFeedWhiteListRequest
        @return: QueryFeedWhiteListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryFeedWhiteListHeaders()
        return await self.query_feed_white_list_with_options_async(feed_id, request, headers, runtime)

    def query_live_info_with_options(
        self,
        request: dingtalklive__1__0_models.QueryLiveInfoRequest,
        headers: dingtalklive__1__0_models.QueryLiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveInfoResponse:
        """
        @summary 查询直播详情
        
        @param request: QueryLiveInfoRequest
        @param headers: QueryLiveInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='QueryLiveInfo',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_live_info_with_options_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveInfoRequest,
        headers: dingtalklive__1__0_models.QueryLiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveInfoResponse:
        """
        @summary 查询直播详情
        
        @param request: QueryLiveInfoRequest
        @param headers: QueryLiveInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='QueryLiveInfo',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_live_info(
        self,
        request: dingtalklive__1__0_models.QueryLiveInfoRequest,
    ) -> dingtalklive__1__0_models.QueryLiveInfoResponse:
        """
        @summary 查询直播详情
        
        @param request: QueryLiveInfoRequest
        @return: QueryLiveInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveInfoHeaders()
        return self.query_live_info_with_options(request, headers, runtime)

    async def query_live_info_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveInfoRequest,
    ) -> dingtalklive__1__0_models.QueryLiveInfoResponse:
        """
        @summary 查询直播详情
        
        @param request: QueryLiveInfoRequest
        @return: QueryLiveInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveInfoHeaders()
        return await self.query_live_info_with_options_async(request, headers, runtime)

    def query_live_interaction_plugin_with_options(
        self,
        request: dingtalklive__1__0_models.QueryLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.QueryLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveInteractionPluginResponse:
        """
        @summary 查询直播间内某一互动插件的信息
        
        @param request: QueryLiveInteractionPluginRequest
        @param headers: QueryLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='QueryLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveInteractionPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def query_live_interaction_plugin_with_options_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.QueryLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveInteractionPluginResponse:
        """
        @summary 查询直播间内某一互动插件的信息
        
        @param request: QueryLiveInteractionPluginRequest
        @param headers: QueryLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='QueryLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveInteractionPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_live_interaction_plugin(
        self,
        request: dingtalklive__1__0_models.QueryLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.QueryLiveInteractionPluginResponse:
        """
        @summary 查询直播间内某一互动插件的信息
        
        @param request: QueryLiveInteractionPluginRequest
        @return: QueryLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveInteractionPluginHeaders()
        return self.query_live_interaction_plugin_with_options(request, headers, runtime)

    async def query_live_interaction_plugin_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.QueryLiveInteractionPluginResponse:
        """
        @summary 查询直播间内某一互动插件的信息
        
        @param request: QueryLiveInteractionPluginRequest
        @return: QueryLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveInteractionPluginHeaders()
        return await self.query_live_interaction_plugin_with_options_async(request, headers, runtime)

    def query_live_watch_detail_with_options(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchDetailRequest,
        headers: dingtalklive__1__0_models.QueryLiveWatchDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveWatchDetailResponse:
        """
        @summary 获取直播的观看数据
        
        @param request: QueryLiveWatchDetailRequest
        @param headers: QueryLiveWatchDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveWatchDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='QueryLiveWatchDetail',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/watchDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveWatchDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_live_watch_detail_with_options_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchDetailRequest,
        headers: dingtalklive__1__0_models.QueryLiveWatchDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveWatchDetailResponse:
        """
        @summary 获取直播的观看数据
        
        @param request: QueryLiveWatchDetailRequest
        @param headers: QueryLiveWatchDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveWatchDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
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
            action='QueryLiveWatchDetail',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/watchDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveWatchDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_live_watch_detail(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchDetailRequest,
    ) -> dingtalklive__1__0_models.QueryLiveWatchDetailResponse:
        """
        @summary 获取直播的观看数据
        
        @param request: QueryLiveWatchDetailRequest
        @return: QueryLiveWatchDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveWatchDetailHeaders()
        return self.query_live_watch_detail_with_options(request, headers, runtime)

    async def query_live_watch_detail_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchDetailRequest,
    ) -> dingtalklive__1__0_models.QueryLiveWatchDetailResponse:
        """
        @summary 获取直播的观看数据
        
        @param request: QueryLiveWatchDetailRequest
        @return: QueryLiveWatchDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveWatchDetailHeaders()
        return await self.query_live_watch_detail_with_options_async(request, headers, runtime)

    def query_live_watch_user_list_with_options(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchUserListRequest,
        headers: dingtalklive__1__0_models.QueryLiveWatchUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveWatchUserListResponse:
        """
        @summary 获取直播观看用户列表
        
        @param request: QueryLiveWatchUserListRequest
        @param headers: QueryLiveWatchUserListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveWatchUserListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryLiveWatchUserList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/watchUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveWatchUserListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_live_watch_user_list_with_options_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchUserListRequest,
        headers: dingtalklive__1__0_models.QueryLiveWatchUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QueryLiveWatchUserListResponse:
        """
        @summary 获取直播观看用户列表
        
        @param request: QueryLiveWatchUserListRequest
        @param headers: QueryLiveWatchUserListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryLiveWatchUserListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryLiveWatchUserList',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/watchUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QueryLiveWatchUserListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_live_watch_user_list(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchUserListRequest,
    ) -> dingtalklive__1__0_models.QueryLiveWatchUserListResponse:
        """
        @summary 获取直播观看用户列表
        
        @param request: QueryLiveWatchUserListRequest
        @return: QueryLiveWatchUserListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveWatchUserListHeaders()
        return self.query_live_watch_user_list_with_options(request, headers, runtime)

    async def query_live_watch_user_list_async(
        self,
        request: dingtalklive__1__0_models.QueryLiveWatchUserListRequest,
    ) -> dingtalklive__1__0_models.QueryLiveWatchUserListResponse:
        """
        @summary 获取直播观看用户列表
        
        @param request: QueryLiveWatchUserListRequest
        @return: QueryLiveWatchUserListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QueryLiveWatchUserListHeaders()
        return await self.query_live_watch_user_list_with_options_async(request, headers, runtime)

    def query_subscribe_status_with_options(
        self,
        tmp_req: dingtalklive__1__0_models.QuerySubscribeStatusRequest,
        headers: dingtalklive__1__0_models.QuerySubscribeStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QuerySubscribeStatusResponse:
        """
        @summary 批量查询直播是否订阅
        
        @param tmp_req: QuerySubscribeStatusRequest
        @param headers: QuerySubscribeStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySubscribeStatusResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.QuerySubscribeStatusShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='QuerySubscribeStatus',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/subscribeStatuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QuerySubscribeStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_subscribe_status_with_options_async(
        self,
        tmp_req: dingtalklive__1__0_models.QuerySubscribeStatusRequest,
        headers: dingtalklive__1__0_models.QuerySubscribeStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.QuerySubscribeStatusResponse:
        """
        @summary 批量查询直播是否订阅
        
        @param tmp_req: QuerySubscribeStatusRequest
        @param headers: QuerySubscribeStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySubscribeStatusResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.QuerySubscribeStatusShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='QuerySubscribeStatus',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/subscribeStatuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.QuerySubscribeStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_subscribe_status(
        self,
        request: dingtalklive__1__0_models.QuerySubscribeStatusRequest,
    ) -> dingtalklive__1__0_models.QuerySubscribeStatusResponse:
        """
        @summary 批量查询直播是否订阅
        
        @param request: QuerySubscribeStatusRequest
        @return: QuerySubscribeStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QuerySubscribeStatusHeaders()
        return self.query_subscribe_status_with_options(request, headers, runtime)

    async def query_subscribe_status_async(
        self,
        request: dingtalklive__1__0_models.QuerySubscribeStatusRequest,
    ) -> dingtalklive__1__0_models.QuerySubscribeStatusResponse:
        """
        @summary 批量查询直播是否订阅
        
        @param request: QuerySubscribeStatusRequest
        @return: QuerySubscribeStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.QuerySubscribeStatusHeaders()
        return await self.query_subscribe_status_with_options_async(request, headers, runtime)

    def send_live_interaction_plugin_effects_msg_with_options(
        self,
        request: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgRequest,
        headers: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLiveInteractionPluginEffectsMsgRequest
        @param headers: SendLiveInteractionPluginEffectsMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendLiveInteractionPluginEffectsMsgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
        body = {}
        if not UtilClient.is_unset(request.count):
            body['count'] = request.count
        if not UtilClient.is_unset(request.lottie_file_url):
            body['lottieFileUrl'] = request.lottie_file_url
        if not UtilClient.is_unset(request.msg_icon_url):
            body['msgIconUrl'] = request.msg_icon_url
        if not UtilClient.is_unset(request.msg_text):
            body['msgText'] = request.msg_text
        if not UtilClient.is_unset(request.plugin_sub_id):
            body['pluginSubId'] = request.plugin_sub_id
        if not UtilClient.is_unset(request.sender_union_id):
            body['senderUnionId'] = request.sender_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendLiveInteractionPluginEffectsMsg',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins/effectMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse(),
            self.execute(params, req, runtime)
        )

    async def send_live_interaction_plugin_effects_msg_with_options_async(
        self,
        request: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgRequest,
        headers: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLiveInteractionPluginEffectsMsgRequest
        @param headers: SendLiveInteractionPluginEffectsMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendLiveInteractionPluginEffectsMsgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
        body = {}
        if not UtilClient.is_unset(request.count):
            body['count'] = request.count
        if not UtilClient.is_unset(request.lottie_file_url):
            body['lottieFileUrl'] = request.lottie_file_url
        if not UtilClient.is_unset(request.msg_icon_url):
            body['msgIconUrl'] = request.msg_icon_url
        if not UtilClient.is_unset(request.msg_text):
            body['msgText'] = request.msg_text
        if not UtilClient.is_unset(request.plugin_sub_id):
            body['pluginSubId'] = request.plugin_sub_id
        if not UtilClient.is_unset(request.sender_union_id):
            body['senderUnionId'] = request.sender_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendLiveInteractionPluginEffectsMsg',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins/effectMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_live_interaction_plugin_effects_msg(
        self,
        request: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgRequest,
    ) -> dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLiveInteractionPluginEffectsMsgRequest
        @return: SendLiveInteractionPluginEffectsMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgHeaders()
        return self.send_live_interaction_plugin_effects_msg_with_options(request, headers, runtime)

    async def send_live_interaction_plugin_effects_msg_async(
        self,
        request: dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgRequest,
    ) -> dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLiveInteractionPluginEffectsMsgRequest
        @return: SendLiveInteractionPluginEffectsMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SendLiveInteractionPluginEffectsMsgHeaders()
        return await self.send_live_interaction_plugin_effects_msg_with_options_async(request, headers, runtime)

    def send_live_plugin_user_action_msg_with_options(
        self,
        tmp_req: dingtalklive__1__0_models.SendLivePluginUserActionMsgRequest,
        headers: dingtalklive__1__0_models.SendLivePluginUserActionMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param tmp_req: SendLivePluginUserActionMsgRequest
        @param headers: SendLivePluginUserActionMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendLivePluginUserActionMsgResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.SendLivePluginUserActionMsgShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.plugin_effects_message):
            request.plugin_effects_message_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.plugin_effects_message, 'pluginEffectsMessage', 'json')
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_effects_message_shrink):
            query['pluginEffectsMessage'] = request.plugin_effects_message_shrink
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='SendLivePluginUserActionMsg',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins/actionMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse(),
            self.execute(params, req, runtime)
        )

    async def send_live_plugin_user_action_msg_with_options_async(
        self,
        tmp_req: dingtalklive__1__0_models.SendLivePluginUserActionMsgRequest,
        headers: dingtalklive__1__0_models.SendLivePluginUserActionMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param tmp_req: SendLivePluginUserActionMsgRequest
        @param headers: SendLivePluginUserActionMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendLivePluginUserActionMsgResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalklive__1__0_models.SendLivePluginUserActionMsgShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.plugin_effects_message):
            request.plugin_effects_message_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.plugin_effects_message, 'pluginEffectsMessage', 'json')
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_effects_message_shrink):
            query['pluginEffectsMessage'] = request.plugin_effects_message_shrink
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
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
            action='SendLivePluginUserActionMsg',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins/actionMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_live_plugin_user_action_msg(
        self,
        request: dingtalklive__1__0_models.SendLivePluginUserActionMsgRequest,
    ) -> dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLivePluginUserActionMsgRequest
        @return: SendLivePluginUserActionMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SendLivePluginUserActionMsgHeaders()
        return self.send_live_plugin_user_action_msg_with_options(request, headers, runtime)

    async def send_live_plugin_user_action_msg_async(
        self,
        request: dingtalklive__1__0_models.SendLivePluginUserActionMsgRequest,
    ) -> dingtalklive__1__0_models.SendLivePluginUserActionMsgResponse:
        """
        @summary 用户对互动插件进行操作广播到直播间
        
        @param request: SendLivePluginUserActionMsgRequest
        @return: SendLivePluginUserActionMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SendLivePluginUserActionMsgHeaders()
        return await self.send_live_plugin_user_action_msg_with_options_async(request, headers, runtime)

    def start_cloud_feed_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StartCloudFeedRequest,
        headers: dingtalklive__1__0_models.StartCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.StartCloudFeedResponse:
        """
        @summary 开始一场云导播
        
        @param request: StartCloudFeedRequest
        @param headers: StartCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='StartCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.StartCloudFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def start_cloud_feed_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StartCloudFeedRequest,
        headers: dingtalklive__1__0_models.StartCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.StartCloudFeedResponse:
        """
        @summary 开始一场云导播
        
        @param request: StartCloudFeedRequest
        @param headers: StartCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='StartCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.StartCloudFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_cloud_feed(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StartCloudFeedRequest,
    ) -> dingtalklive__1__0_models.StartCloudFeedResponse:
        """
        @summary 开始一场云导播
        
        @param request: StartCloudFeedRequest
        @return: StartCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.StartCloudFeedHeaders()
        return self.start_cloud_feed_with_options(feed_id, request, headers, runtime)

    async def start_cloud_feed_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StartCloudFeedRequest,
    ) -> dingtalklive__1__0_models.StartCloudFeedResponse:
        """
        @summary 开始一场云导播
        
        @param request: StartCloudFeedRequest
        @return: StartCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.StartCloudFeedHeaders()
        return await self.start_cloud_feed_with_options_async(feed_id, request, headers, runtime)

    def stop_cloud_feed_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StopCloudFeedRequest,
        headers: dingtalklive__1__0_models.StopCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.StopCloudFeedResponse:
        """
        @summary 结束一场云导播
        
        @param request: StopCloudFeedRequest
        @param headers: StopCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='StopCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.StopCloudFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def stop_cloud_feed_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StopCloudFeedRequest,
        headers: dingtalklive__1__0_models.StopCloudFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.StopCloudFeedResponse:
        """
        @summary 结束一场云导播
        
        @param request: StopCloudFeedRequest
        @param headers: StopCloudFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StopCloudFeedResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='StopCloudFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/cloudFeeds/{feed_id}/stop',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.StopCloudFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def stop_cloud_feed(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StopCloudFeedRequest,
    ) -> dingtalklive__1__0_models.StopCloudFeedResponse:
        """
        @summary 结束一场云导播
        
        @param request: StopCloudFeedRequest
        @return: StopCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.StopCloudFeedHeaders()
        return self.stop_cloud_feed_with_options(feed_id, request, headers, runtime)

    async def stop_cloud_feed_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.StopCloudFeedRequest,
    ) -> dingtalklive__1__0_models.StopCloudFeedResponse:
        """
        @summary 结束一场云导播
        
        @param request: StopCloudFeedRequest
        @return: StopCloudFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.StopCloudFeedHeaders()
        return await self.stop_cloud_feed_with_options_async(feed_id, request, headers, runtime)

    def subscribe_live_with_options(
        self,
        request: dingtalklive__1__0_models.SubscribeLiveRequest,
        headers: dingtalklive__1__0_models.SubscribeLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SubscribeLiveResponse:
        """
        @summary 预约直播
        
        @param request: SubscribeLiveRequest
        @param headers: SubscribeLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeLiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.subscribe):
            query['subscribe'] = request.subscribe
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
            action='SubscribeLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SubscribeLiveResponse(),
            self.execute(params, req, runtime)
        )

    async def subscribe_live_with_options_async(
        self,
        request: dingtalklive__1__0_models.SubscribeLiveRequest,
        headers: dingtalklive__1__0_models.SubscribeLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.SubscribeLiveResponse:
        """
        @summary 预约直播
        
        @param request: SubscribeLiveRequest
        @param headers: SubscribeLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubscribeLiveResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.subscribe):
            query['subscribe'] = request.subscribe
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
            action='SubscribeLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.SubscribeLiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def subscribe_live(
        self,
        request: dingtalklive__1__0_models.SubscribeLiveRequest,
    ) -> dingtalklive__1__0_models.SubscribeLiveResponse:
        """
        @summary 预约直播
        
        @param request: SubscribeLiveRequest
        @return: SubscribeLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SubscribeLiveHeaders()
        return self.subscribe_live_with_options(request, headers, runtime)

    async def subscribe_live_async(
        self,
        request: dingtalklive__1__0_models.SubscribeLiveRequest,
    ) -> dingtalklive__1__0_models.SubscribeLiveResponse:
        """
        @summary 预约直播
        
        @param request: SubscribeLiveRequest
        @return: SubscribeLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.SubscribeLiveHeaders()
        return await self.subscribe_live_with_options_async(request, headers, runtime)

    def update_live_with_options(
        self,
        request: dingtalklive__1__0_models.UpdateLiveRequest,
        headers: dingtalklive__1__0_models.UpdateLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveResponse:
        """
        @summary 修改直播
        
        @param request: UpdateLiveRequest
        @param headers: UpdateLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.live_id):
            body['liveId'] = request.live_id
        if not UtilClient.is_unset(request.pre_end_time):
            body['preEndTime'] = request.pre_end_time
        if not UtilClient.is_unset(request.pre_start_time):
            body['preStartTime'] = request.pre_start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='UpdateLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveResponse(),
            self.execute(params, req, runtime)
        )

    async def update_live_with_options_async(
        self,
        request: dingtalklive__1__0_models.UpdateLiveRequest,
        headers: dingtalklive__1__0_models.UpdateLiveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveResponse:
        """
        @summary 修改直播
        
        @param request: UpdateLiveRequest
        @param headers: UpdateLiveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover_url):
            body['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            body['introduction'] = request.introduction
        if not UtilClient.is_unset(request.live_id):
            body['liveId'] = request.live_id
        if not UtilClient.is_unset(request.pre_end_time):
            body['preEndTime'] = request.pre_end_time
        if not UtilClient.is_unset(request.pre_start_time):
            body['preStartTime'] = request.pre_start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='UpdateLive',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/lives',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_live(
        self,
        request: dingtalklive__1__0_models.UpdateLiveRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveResponse:
        """
        @summary 修改直播
        
        @param request: UpdateLiveRequest
        @return: UpdateLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveHeaders()
        return self.update_live_with_options(request, headers, runtime)

    async def update_live_async(
        self,
        request: dingtalklive__1__0_models.UpdateLiveRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveResponse:
        """
        @summary 修改直播
        
        @param request: UpdateLiveRequest
        @return: UpdateLiveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveHeaders()
        return await self.update_live_with_options_async(request, headers, runtime)

    def update_live_feed_with_options(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.UpdateLiveFeedRequest,
        headers: dingtalklive__1__0_models.UpdateLiveFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveFeedResponse:
        """
        @summary 修改培训课程信息
        
        @param request: UpdateLiveFeedRequest
        @param headers: UpdateLiveFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveFeedResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cover_url):
            query['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            query['introduction'] = request.introduction
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='UpdateLiveFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveFeedResponse(),
            self.execute(params, req, runtime)
        )

    async def update_live_feed_with_options_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.UpdateLiveFeedRequest,
        headers: dingtalklive__1__0_models.UpdateLiveFeedHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveFeedResponse:
        """
        @summary 修改培训课程信息
        
        @param request: UpdateLiveFeedRequest
        @param headers: UpdateLiveFeedHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveFeedResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cover_url):
            query['coverUrl'] = request.cover_url
        if not UtilClient.is_unset(request.introduction):
            query['introduction'] = request.introduction
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='UpdateLiveFeed',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/openFeeds/{feed_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveFeedResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_live_feed(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.UpdateLiveFeedRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveFeedResponse:
        """
        @summary 修改培训课程信息
        
        @param request: UpdateLiveFeedRequest
        @return: UpdateLiveFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveFeedHeaders()
        return self.update_live_feed_with_options(feed_id, request, headers, runtime)

    async def update_live_feed_async(
        self,
        feed_id: str,
        request: dingtalklive__1__0_models.UpdateLiveFeedRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveFeedResponse:
        """
        @summary 修改培训课程信息
        
        @param request: UpdateLiveFeedRequest
        @return: UpdateLiveFeedResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveFeedHeaders()
        return await self.update_live_feed_with_options_async(feed_id, request, headers, runtime)

    def update_live_interaction_plugin_with_options(
        self,
        request: dingtalklive__1__0_models.UpdateLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.UpdateLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse:
        """
        @summary 修改直播间内某一互动插件的信息
        
        @param request: UpdateLiveInteractionPluginRequest
        @param headers: UpdateLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.anchor_jump_url):
            body['anchorJumpUrl'] = request.anchor_jump_url
        if not UtilClient.is_unset(request.plugin_icon_url):
            body['pluginIconUrl'] = request.plugin_icon_url
        if not UtilClient.is_unset(request.plugin_name):
            body['pluginName'] = request.plugin_name
        if not UtilClient.is_unset(request.plugin_name_en):
            body['pluginNameEn'] = request.plugin_name_en
        if not UtilClient.is_unset(request.viewer_jump_url):
            body['viewerJumpUrl'] = request.viewer_jump_url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def update_live_interaction_plugin_with_options_async(
        self,
        request: dingtalklive__1__0_models.UpdateLiveInteractionPluginRequest,
        headers: dingtalklive__1__0_models.UpdateLiveInteractionPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse:
        """
        @summary 修改直播间内某一互动插件的信息
        
        @param request: UpdateLiveInteractionPluginRequest
        @param headers: UpdateLiveInteractionPluginHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateLiveInteractionPluginResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.live_id):
            query['liveId'] = request.live_id
        if not UtilClient.is_unset(request.plugin_id):
            query['pluginId'] = request.plugin_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.anchor_jump_url):
            body['anchorJumpUrl'] = request.anchor_jump_url
        if not UtilClient.is_unset(request.plugin_icon_url):
            body['pluginIconUrl'] = request.plugin_icon_url
        if not UtilClient.is_unset(request.plugin_name):
            body['pluginName'] = request.plugin_name
        if not UtilClient.is_unset(request.plugin_name_en):
            body['pluginNameEn'] = request.plugin_name_en
        if not UtilClient.is_unset(request.viewer_jump_url):
            body['viewerJumpUrl'] = request.viewer_jump_url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateLiveInteractionPlugin',
            version='live_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/live/interactionPlugins',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_live_interaction_plugin(
        self,
        request: dingtalklive__1__0_models.UpdateLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse:
        """
        @summary 修改直播间内某一互动插件的信息
        
        @param request: UpdateLiveInteractionPluginRequest
        @return: UpdateLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveInteractionPluginHeaders()
        return self.update_live_interaction_plugin_with_options(request, headers, runtime)

    async def update_live_interaction_plugin_async(
        self,
        request: dingtalklive__1__0_models.UpdateLiveInteractionPluginRequest,
    ) -> dingtalklive__1__0_models.UpdateLiveInteractionPluginResponse:
        """
        @summary 修改直播间内某一互动插件的信息
        
        @param request: UpdateLiveInteractionPluginRequest
        @return: UpdateLiveInteractionPluginResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklive__1__0_models.UpdateLiveInteractionPluginHeaders()
        return await self.update_live_interaction_plugin_with_options_async(request, headers, runtime)
