# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ai_global_e_c_1_0 import models as dingtalkai_global_e_c__1__0_models
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

    def connection_omni_channel_tiktok_message_with_options(
        self,
        request: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageRequest,
        headers: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse:
        """
        @summary 全渠道运营客服tiktok消息接入
        
        @param request: ConnectionOmniChannelTiktokMessageRequest
        @param headers: ConnectionOmniChannelTiktokMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConnectionOmniChannelTiktokMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tiktok_content_json_string):
            body['tiktokContentJsonString'] = request.tiktok_content_json_string
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
            action='ConnectionOmniChannelTiktokMessage',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def connection_omni_channel_tiktok_message_with_options_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageRequest,
        headers: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse:
        """
        @summary 全渠道运营客服tiktok消息接入
        
        @param request: ConnectionOmniChannelTiktokMessageRequest
        @param headers: ConnectionOmniChannelTiktokMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConnectionOmniChannelTiktokMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tiktok_content_json_string):
            body['tiktokContentJsonString'] = request.tiktok_content_json_string
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
            action='ConnectionOmniChannelTiktokMessage',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def connection_omni_channel_tiktok_message(
        self,
        request: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageRequest,
    ) -> dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse:
        """
        @summary 全渠道运营客服tiktok消息接入
        
        @param request: ConnectionOmniChannelTiktokMessageRequest
        @return: ConnectionOmniChannelTiktokMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageHeaders()
        return self.connection_omni_channel_tiktok_message_with_options(request, headers, runtime)

    async def connection_omni_channel_tiktok_message_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageRequest,
    ) -> dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageResponse:
        """
        @summary 全渠道运营客服tiktok消息接入
        
        @param request: ConnectionOmniChannelTiktokMessageRequest
        @return: ConnectionOmniChannelTiktokMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.ConnectionOmniChannelTiktokMessageHeaders()
        return await self.connection_omni_channel_tiktok_message_with_options_async(request, headers, runtime)

    def get_login_user_with_options(
        self,
        request: dingtalkai_global_e_c__1__0_models.GetLoginUserRequest,
        headers: dingtalkai_global_e_c__1__0_models.GetLoginUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.GetLoginUserResponse:
        """
        @summary 获取当前登录用户版本信息
        
        @param request: GetLoginUserRequest
        @param headers: GetLoginUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLoginUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
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
            action='GetLoginUser',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/authCode/getLoginUser',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.GetLoginUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_login_user_with_options_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.GetLoginUserRequest,
        headers: dingtalkai_global_e_c__1__0_models.GetLoginUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.GetLoginUserResponse:
        """
        @summary 获取当前登录用户版本信息
        
        @param request: GetLoginUserRequest
        @param headers: GetLoginUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLoginUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
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
            action='GetLoginUser',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/authCode/getLoginUser',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.GetLoginUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_login_user(
        self,
        request: dingtalkai_global_e_c__1__0_models.GetLoginUserRequest,
    ) -> dingtalkai_global_e_c__1__0_models.GetLoginUserResponse:
        """
        @summary 获取当前登录用户版本信息
        
        @param request: GetLoginUserRequest
        @return: GetLoginUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.GetLoginUserHeaders()
        return self.get_login_user_with_options(request, headers, runtime)

    async def get_login_user_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.GetLoginUserRequest,
    ) -> dingtalkai_global_e_c__1__0_models.GetLoginUserResponse:
        """
        @summary 获取当前登录用户版本信息
        
        @param request: GetLoginUserRequest
        @return: GetLoginUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.GetLoginUserHeaders()
        return await self.get_login_user_with_options_async(request, headers, runtime)

    def launch_with_options(
        self,
        request: dingtalkai_global_e_c__1__0_models.LaunchRequest,
        headers: dingtalkai_global_e_c__1__0_models.LaunchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.LaunchResponse:
        """
        @summary 刊登的对外开放Api
        
        @param request: LaunchRequest
        @param headers: LaunchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LaunchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_agent_id):
            query['dingAgentId'] = request.ding_agent_id
        if not UtilClient.is_unset(request.ding_client_id):
            query['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            query['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            query['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            query['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            query['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_uid):
            query['dingUid'] = request.ding_uid
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.image_urls):
            body['imageUrls'] = request.image_urls
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.selling_points):
            body['sellingPoints'] = request.selling_points
        if not UtilClient.is_unset(request.source_data):
            body['sourceData'] = request.source_data
        if not UtilClient.is_unset(request.variants):
            body['variants'] = request.variants
        if not UtilClient.is_unset(request.video_urls):
            body['videoUrls'] = request.video_urls
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
            action='Launch',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/launch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.LaunchResponse(),
            self.execute(params, req, runtime)
        )

    async def launch_with_options_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.LaunchRequest,
        headers: dingtalkai_global_e_c__1__0_models.LaunchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.LaunchResponse:
        """
        @summary 刊登的对外开放Api
        
        @param request: LaunchRequest
        @param headers: LaunchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LaunchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_agent_id):
            query['dingAgentId'] = request.ding_agent_id
        if not UtilClient.is_unset(request.ding_client_id):
            query['dingClientId'] = request.ding_client_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            query['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            query['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            query['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            query['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_uid):
            query['dingUid'] = request.ding_uid
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.image_urls):
            body['imageUrls'] = request.image_urls
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.selling_points):
            body['sellingPoints'] = request.selling_points
        if not UtilClient.is_unset(request.source_data):
            body['sourceData'] = request.source_data
        if not UtilClient.is_unset(request.variants):
            body['variants'] = request.variants
        if not UtilClient.is_unset(request.video_urls):
            body['videoUrls'] = request.video_urls
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
            action='Launch',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/launch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.LaunchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def launch(
        self,
        request: dingtalkai_global_e_c__1__0_models.LaunchRequest,
    ) -> dingtalkai_global_e_c__1__0_models.LaunchResponse:
        """
        @summary 刊登的对外开放Api
        
        @param request: LaunchRequest
        @return: LaunchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.LaunchHeaders()
        return self.launch_with_options(request, headers, runtime)

    async def launch_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.LaunchRequest,
    ) -> dingtalkai_global_e_c__1__0_models.LaunchResponse:
        """
        @summary 刊登的对外开放Api
        
        @param request: LaunchRequest
        @return: LaunchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.LaunchHeaders()
        return await self.launch_with_options_async(request, headers, runtime)

    def query_notable_info_with_options(
        self,
        request: dingtalkai_global_e_c__1__0_models.QueryNotableInfoRequest,
        headers: dingtalkai_global_e_c__1__0_models.QueryNotableInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse:
        """
        @summary 全渠道AI表格业务信息
        
        @param request: QueryNotableInfoRequest
        @param headers: QueryNotableInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryNotableInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
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
            action='QueryNotableInfo',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/notable',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_notable_info_with_options_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.QueryNotableInfoRequest,
        headers: dingtalkai_global_e_c__1__0_models.QueryNotableInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse:
        """
        @summary 全渠道AI表格业务信息
        
        @param request: QueryNotableInfoRequest
        @param headers: QueryNotableInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryNotableInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
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
            action='QueryNotableInfo',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/notable',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_notable_info(
        self,
        request: dingtalkai_global_e_c__1__0_models.QueryNotableInfoRequest,
    ) -> dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse:
        """
        @summary 全渠道AI表格业务信息
        
        @param request: QueryNotableInfoRequest
        @return: QueryNotableInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.QueryNotableInfoHeaders()
        return self.query_notable_info_with_options(request, headers, runtime)

    async def query_notable_info_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.QueryNotableInfoRequest,
    ) -> dingtalkai_global_e_c__1__0_models.QueryNotableInfoResponse:
        """
        @summary 全渠道AI表格业务信息
        
        @param request: QueryNotableInfoRequest
        @return: QueryNotableInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.QueryNotableInfoHeaders()
        return await self.query_notable_info_with_options_async(request, headers, runtime)

    def tiktok_shop_auth_callback_with_options(
        self,
        request: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackRequest,
        headers: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse:
        """
        @summary 平台店铺授权回调
        
        @param request: TiktokShopAuthCallbackRequest
        @param headers: TiktokShopAuthCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TiktokShopAuthCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.seller_type):
            body['sellerType'] = request.seller_type
        if not UtilClient.is_unset(request.shop_id):
            body['shopId'] = request.shop_id
        if not UtilClient.is_unset(request.shop_name):
            body['shopName'] = request.shop_name
        if not UtilClient.is_unset(request.shop_region):
            body['shopRegion'] = request.shop_region
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
            action='TiktokShopAuthCallback',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def tiktok_shop_auth_callback_with_options_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackRequest,
        headers: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse:
        """
        @summary 平台店铺授权回调
        
        @param request: TiktokShopAuthCallbackRequest
        @param headers: TiktokShopAuthCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TiktokShopAuthCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.seller_type):
            body['sellerType'] = request.seller_type
        if not UtilClient.is_unset(request.shop_id):
            body['shopId'] = request.shop_id
        if not UtilClient.is_unset(request.shop_name):
            body['shopName'] = request.shop_name
        if not UtilClient.is_unset(request.shop_region):
            body['shopRegion'] = request.shop_region
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
            action='TiktokShopAuthCallback',
            version='aiGlobalEC_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def tiktok_shop_auth_callback(
        self,
        request: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackRequest,
    ) -> dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse:
        """
        @summary 平台店铺授权回调
        
        @param request: TiktokShopAuthCallbackRequest
        @return: TiktokShopAuthCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackHeaders()
        return self.tiktok_shop_auth_callback_with_options(request, headers, runtime)

    async def tiktok_shop_auth_callback_async(
        self,
        request: dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackRequest,
    ) -> dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackResponse:
        """
        @summary 平台店铺授权回调
        
        @param request: TiktokShopAuthCallbackRequest
        @return: TiktokShopAuthCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_global_e_c__1__0_models.TiktokShopAuthCallbackHeaders()
        return await self.tiktok_shop_auth_callback_with_options_async(request, headers, runtime)
