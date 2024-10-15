# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.link_1_0 import models as dingtalklink__1__0_models
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

    def apply_follower_auth_info_with_options(
        self,
        request: dingtalklink__1__0_models.ApplyFollowerAuthInfoRequest,
        headers: dingtalklink__1__0_models.ApplyFollowerAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse:
        """
        @summary 发送用户授权信息申请
        
        @param request: ApplyFollowerAuthInfoRequest
        @param headers: ApplyFollowerAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApplyFollowerAuthInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_auth_key):
            body['appAuthKey'] = request.app_auth_key
        if not UtilClient.is_unset(request.field_scope):
            body['fieldScope'] = request.field_scope
        if not UtilClient.is_unset(request.session_id):
            body['sessionId'] = request.session_id
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
            action='ApplyFollowerAuthInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/authInfos/apply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def apply_follower_auth_info_with_options_async(
        self,
        request: dingtalklink__1__0_models.ApplyFollowerAuthInfoRequest,
        headers: dingtalklink__1__0_models.ApplyFollowerAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse:
        """
        @summary 发送用户授权信息申请
        
        @param request: ApplyFollowerAuthInfoRequest
        @param headers: ApplyFollowerAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApplyFollowerAuthInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_auth_key):
            body['appAuthKey'] = request.app_auth_key
        if not UtilClient.is_unset(request.field_scope):
            body['fieldScope'] = request.field_scope
        if not UtilClient.is_unset(request.session_id):
            body['sessionId'] = request.session_id
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
            action='ApplyFollowerAuthInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/authInfos/apply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def apply_follower_auth_info(
        self,
        request: dingtalklink__1__0_models.ApplyFollowerAuthInfoRequest,
    ) -> dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse:
        """
        @summary 发送用户授权信息申请
        
        @param request: ApplyFollowerAuthInfoRequest
        @return: ApplyFollowerAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ApplyFollowerAuthInfoHeaders()
        return self.apply_follower_auth_info_with_options(request, headers, runtime)

    async def apply_follower_auth_info_async(
        self,
        request: dingtalklink__1__0_models.ApplyFollowerAuthInfoRequest,
    ) -> dingtalklink__1__0_models.ApplyFollowerAuthInfoResponse:
        """
        @summary 发送用户授权信息申请
        
        @param request: ApplyFollowerAuthInfoRequest
        @return: ApplyFollowerAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ApplyFollowerAuthInfoHeaders()
        return await self.apply_follower_auth_info_with_options_async(request, headers, runtime)

    def callback_regiester_with_options(
        self,
        request: dingtalklink__1__0_models.CallbackRegiesterRequest,
        headers: dingtalklink__1__0_models.CallbackRegiesterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.CallbackRegiesterResponse:
        """
        @summary 注册服务窗消息回调服务
        
        @param request: CallbackRegiesterRequest
        @param headers: CallbackRegiesterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CallbackRegiesterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.callback_key):
            body['callbackKey'] = request.callback_key
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
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
            action='CallbackRegiester',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/callbacks/regiester',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.CallbackRegiesterResponse(),
            self.execute(params, req, runtime)
        )

    async def callback_regiester_with_options_async(
        self,
        request: dingtalklink__1__0_models.CallbackRegiesterRequest,
        headers: dingtalklink__1__0_models.CallbackRegiesterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.CallbackRegiesterResponse:
        """
        @summary 注册服务窗消息回调服务
        
        @param request: CallbackRegiesterRequest
        @param headers: CallbackRegiesterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CallbackRegiesterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.callback_key):
            body['callbackKey'] = request.callback_key
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
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
            action='CallbackRegiester',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/callbacks/regiester',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.CallbackRegiesterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def callback_regiester(
        self,
        request: dingtalklink__1__0_models.CallbackRegiesterRequest,
    ) -> dingtalklink__1__0_models.CallbackRegiesterResponse:
        """
        @summary 注册服务窗消息回调服务
        
        @param request: CallbackRegiesterRequest
        @return: CallbackRegiesterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.CallbackRegiesterHeaders()
        return self.callback_regiester_with_options(request, headers, runtime)

    async def callback_regiester_async(
        self,
        request: dingtalklink__1__0_models.CallbackRegiesterRequest,
    ) -> dingtalklink__1__0_models.CallbackRegiesterResponse:
        """
        @summary 注册服务窗消息回调服务
        
        @param request: CallbackRegiesterRequest
        @return: CallbackRegiesterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.CallbackRegiesterHeaders()
        return await self.callback_regiester_with_options_async(request, headers, runtime)

    def close_top_box_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片关闭接口
        
        @param request: CloseTopBoxInteractiveOTOMessageRequest
        @param headers: CloseTopBoxInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseTopBoxInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='CloseTopBoxInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def close_top_box_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片关闭接口
        
        @param request: CloseTopBoxInteractiveOTOMessageRequest
        @param headers: CloseTopBoxInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseTopBoxInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='CloseTopBoxInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def close_top_box_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片关闭接口
        
        @param request: CloseTopBoxInteractiveOTOMessageRequest
        @return: CloseTopBoxInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageHeaders()
        return self.close_top_box_interactive_otomessage_with_options(request, headers, runtime)

    async def close_top_box_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片关闭接口
        
        @param request: CloseTopBoxInteractiveOTOMessageRequest
        @return: CloseTopBoxInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.CloseTopBoxInteractiveOTOMessageHeaders()
        return await self.close_top_box_interactive_otomessage_with_options_async(request, headers, runtime)

    def get_follower_auth_info_with_options(
        self,
        request: dingtalklink__1__0_models.GetFollowerAuthInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerAuthInfoResponse:
        """
        @summary 获取用户授权信息
        
        @param request: GetFollowerAuthInfoRequest
        @param headers: GetFollowerAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFollowerAuthInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='GetFollowerAuthInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_follower_auth_info_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerAuthInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerAuthInfoResponse:
        """
        @summary 获取用户授权信息
        
        @param request: GetFollowerAuthInfoRequest
        @param headers: GetFollowerAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFollowerAuthInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='GetFollowerAuthInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_follower_auth_info(
        self,
        request: dingtalklink__1__0_models.GetFollowerAuthInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerAuthInfoResponse:
        """
        @summary 获取用户授权信息
        
        @param request: GetFollowerAuthInfoRequest
        @return: GetFollowerAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerAuthInfoHeaders()
        return self.get_follower_auth_info_with_options(request, headers, runtime)

    async def get_follower_auth_info_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerAuthInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerAuthInfoResponse:
        """
        @summary 获取用户授权信息
        
        @param request: GetFollowerAuthInfoRequest
        @return: GetFollowerAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerAuthInfoHeaders()
        return await self.get_follower_auth_info_with_options_async(request, headers, runtime)

    def get_follower_info_with_options(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        """
        @summary 获取服务窗关注人信息
        
        @param request: GetFollowerInfoRequest
        @param headers: GetFollowerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFollowerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetFollowerInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_follower_info_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        """
        @summary 获取服务窗关注人信息
        
        @param request: GetFollowerInfoRequest
        @param headers: GetFollowerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFollowerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetFollowerInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_follower_info(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        """
        @summary 获取服务窗关注人信息
        
        @param request: GetFollowerInfoRequest
        @return: GetFollowerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerInfoHeaders()
        return self.get_follower_info_with_options(request, headers, runtime)

    async def get_follower_info_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        """
        @summary 获取服务窗关注人信息
        
        @param request: GetFollowerInfoRequest
        @return: GetFollowerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerInfoHeaders()
        return await self.get_follower_info_with_options_async(request, headers, runtime)

    def get_picture_download_url_with_options(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
        headers: dingtalklink__1__0_models.GetPictureDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        """
        @summary 服务窗图片消息下载地址获取接口
        
        @param request: GetPictureDownloadUrlRequest
        @param headers: GetPictureDownloadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPictureDownloadUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.download_code):
            query['downloadCode'] = request.download_code
        if not UtilClient.is_unset(request.session_id):
            query['sessionId'] = request.session_id
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
            action='GetPictureDownloadUrl',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/pictures/downloadUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetPictureDownloadUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_picture_download_url_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
        headers: dingtalklink__1__0_models.GetPictureDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        """
        @summary 服务窗图片消息下载地址获取接口
        
        @param request: GetPictureDownloadUrlRequest
        @param headers: GetPictureDownloadUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPictureDownloadUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.download_code):
            query['downloadCode'] = request.download_code
        if not UtilClient.is_unset(request.session_id):
            query['sessionId'] = request.session_id
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
            action='GetPictureDownloadUrl',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/pictures/downloadUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetPictureDownloadUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_picture_download_url(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        """
        @summary 服务窗图片消息下载地址获取接口
        
        @param request: GetPictureDownloadUrlRequest
        @return: GetPictureDownloadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetPictureDownloadUrlHeaders()
        return self.get_picture_download_url_with_options(request, headers, runtime)

    async def get_picture_download_url_async(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        """
        @summary 服务窗图片消息下载地址获取接口
        
        @param request: GetPictureDownloadUrlRequest
        @return: GetPictureDownloadUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetPictureDownloadUrlHeaders()
        return await self.get_picture_download_url_with_options_async(request, headers, runtime)

    def get_user_follow_status_with_options(
        self,
        request: dingtalklink__1__0_models.GetUserFollowStatusRequest,
        headers: dingtalklink__1__0_models.GetUserFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetUserFollowStatusResponse:
        """
        @summary 获取用户关注状态
        
        @param request: GetUserFollowStatusRequest
        @param headers: GetUserFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetUserFollowStatus',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetUserFollowStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_follow_status_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetUserFollowStatusRequest,
        headers: dingtalklink__1__0_models.GetUserFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetUserFollowStatusResponse:
        """
        @summary 获取用户关注状态
        
        @param request: GetUserFollowStatusRequest
        @param headers: GetUserFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetUserFollowStatus',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetUserFollowStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_follow_status(
        self,
        request: dingtalklink__1__0_models.GetUserFollowStatusRequest,
    ) -> dingtalklink__1__0_models.GetUserFollowStatusResponse:
        """
        @summary 获取用户关注状态
        
        @param request: GetUserFollowStatusRequest
        @return: GetUserFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetUserFollowStatusHeaders()
        return self.get_user_follow_status_with_options(request, headers, runtime)

    async def get_user_follow_status_async(
        self,
        request: dingtalklink__1__0_models.GetUserFollowStatusRequest,
    ) -> dingtalklink__1__0_models.GetUserFollowStatusResponse:
        """
        @summary 获取用户关注状态
        
        @param request: GetUserFollowStatusRequest
        @return: GetUserFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetUserFollowStatusHeaders()
        return await self.get_user_follow_status_with_options_async(request, headers, runtime)

    def list_account_with_options(
        self,
        headers: dingtalklink__1__0_models.ListAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListAccountResponse:
        """
        @summary 获取企业下服务窗帐号列表
        
        @param headers: ListAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAccountResponse
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
            action='ListAccount',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def list_account_with_options_async(
        self,
        headers: dingtalklink__1__0_models.ListAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListAccountResponse:
        """
        @summary 获取企业下服务窗帐号列表
        
        @param headers: ListAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAccountResponse
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
            action='ListAccount',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_account(self) -> dingtalklink__1__0_models.ListAccountResponse:
        """
        @summary 获取企业下服务窗帐号列表
        
        @return: ListAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListAccountHeaders()
        return self.list_account_with_options(headers, runtime)

    async def list_account_async(self) -> dingtalklink__1__0_models.ListAccountResponse:
        """
        @summary 获取企业下服务窗帐号列表
        
        @return: ListAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListAccountHeaders()
        return await self.list_account_with_options_async(headers, runtime)

    def list_account_info_with_options(
        self,
        headers: dingtalklink__1__0_models.ListAccountInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListAccountInfoResponse:
        """
        @summary 第三方企业应用查询服务窗帐号列表
        
        @param headers: ListAccountInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAccountInfoResponse
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
            action='ListAccountInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/isv/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListAccountInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def list_account_info_with_options_async(
        self,
        headers: dingtalklink__1__0_models.ListAccountInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListAccountInfoResponse:
        """
        @summary 第三方企业应用查询服务窗帐号列表
        
        @param headers: ListAccountInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAccountInfoResponse
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
            action='ListAccountInfo',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/isv/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListAccountInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_account_info(self) -> dingtalklink__1__0_models.ListAccountInfoResponse:
        """
        @summary 第三方企业应用查询服务窗帐号列表
        
        @return: ListAccountInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListAccountInfoHeaders()
        return self.list_account_info_with_options(headers, runtime)

    async def list_account_info_async(self) -> dingtalklink__1__0_models.ListAccountInfoResponse:
        """
        @summary 第三方企业应用查询服务窗帐号列表
        
        @return: ListAccountInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListAccountInfoHeaders()
        return await self.list_account_info_with_options_async(headers, runtime)

    def list_follower_with_options(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
        headers: dingtalklink__1__0_models.ListFollowerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        """
        @summary 批量获取服务窗关注人列表
        
        @param request: ListFollowerRequest
        @param headers: ListFollowerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFollowerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='ListFollower',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListFollowerResponse(),
            self.execute(params, req, runtime)
        )

    async def list_follower_with_options_async(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
        headers: dingtalklink__1__0_models.ListFollowerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        """
        @summary 批量获取服务窗关注人列表
        
        @param request: ListFollowerRequest
        @param headers: ListFollowerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFollowerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='ListFollower',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/followers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListFollowerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_follower(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        """
        @summary 批量获取服务窗关注人列表
        
        @param request: ListFollowerRequest
        @return: ListFollowerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListFollowerHeaders()
        return self.list_follower_with_options(request, headers, runtime)

    async def list_follower_async(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        """
        @summary 批量获取服务窗关注人列表
        
        @param request: ListFollowerRequest
        @return: ListFollowerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListFollowerHeaders()
        return await self.list_follower_with_options_async(request, headers, runtime)

    def query_user_follow_status_with_options(
        self,
        request: dingtalklink__1__0_models.QueryUserFollowStatusRequest,
        headers: dingtalklink__1__0_models.QueryUserFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.QueryUserFollowStatusResponse:
        """
        @summary 第三方企业应用查询用户是否关注服务窗
        
        @param request: QueryUserFollowStatusRequest
        @param headers: QueryUserFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='QueryUserFollowStatus',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/isv/followers/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.QueryUserFollowStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_follow_status_with_options_async(
        self,
        request: dingtalklink__1__0_models.QueryUserFollowStatusRequest,
        headers: dingtalklink__1__0_models.QueryUserFollowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.QueryUserFollowStatusResponse:
        """
        @summary 第三方企业应用查询用户是否关注服务窗
        
        @param request: QueryUserFollowStatusRequest
        @param headers: QueryUserFollowStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserFollowStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='QueryUserFollowStatus',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/isv/followers/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.QueryUserFollowStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_follow_status(
        self,
        request: dingtalklink__1__0_models.QueryUserFollowStatusRequest,
    ) -> dingtalklink__1__0_models.QueryUserFollowStatusResponse:
        """
        @summary 第三方企业应用查询用户是否关注服务窗
        
        @param request: QueryUserFollowStatusRequest
        @return: QueryUserFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.QueryUserFollowStatusHeaders()
        return self.query_user_follow_status_with_options(request, headers, runtime)

    async def query_user_follow_status_async(
        self,
        request: dingtalklink__1__0_models.QueryUserFollowStatusRequest,
    ) -> dingtalklink__1__0_models.QueryUserFollowStatusResponse:
        """
        @summary 第三方企业应用查询用户是否关注服务窗
        
        @param request: QueryUserFollowStatusRequest
        @return: QueryUserFollowStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.QueryUserFollowStatusHeaders()
        return await self.query_user_follow_status_with_options_async(request, headers, runtime)

    def send_agent_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendAgentOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        """
        @summary 发送服务窗客服消息
        
        @param request: SendAgentOTOMessageRequest
        @param headers: SendAgentOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAgentOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendAgentOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/agentMessages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendAgentOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_agent_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendAgentOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        """
        @summary 发送服务窗客服消息
        
        @param request: SendAgentOTOMessageRequest
        @param headers: SendAgentOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAgentOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendAgentOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/agentMessages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendAgentOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_agent_otomessage(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        """
        @summary 发送服务窗客服消息
        
        @param request: SendAgentOTOMessageRequest
        @return: SendAgentOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendAgentOTOMessageHeaders()
        return self.send_agent_otomessage_with_options(request, headers, runtime)

    async def send_agent_otomessage_async(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        """
        @summary 发送服务窗客服消息
        
        @param request: SendAgentOTOMessageRequest
        @return: SendAgentOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendAgentOTOMessageHeaders()
        return await self.send_agent_otomessage_with_options_async(request, headers, runtime)

    def send_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片单发接口
        
        @param request: SendInteractiveOTOMessageRequest
        @param headers: SendInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/interactiveMessages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendInteractiveOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片单发接口
        
        @param request: SendInteractiveOTOMessageRequest
        @param headers: SendInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/interactiveMessages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendInteractiveOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片单发接口
        
        @param request: SendInteractiveOTOMessageRequest
        @return: SendInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders()
        return self.send_interactive_otomessage_with_options(request, headers, runtime)

    async def send_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片单发接口
        
        @param request: SendInteractiveOTOMessageRequest
        @return: SendInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders()
        return await self.send_interactive_otomessage_with_options_async(request, headers, runtime)

    def send_top_box_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片发送接口
        
        @param request: SendTopBoxInteractiveOTOMessageRequest
        @param headers: SendTopBoxInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendTopBoxInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendTopBoxInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/topBoxes/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_top_box_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片发送接口
        
        @param request: SendTopBoxInteractiveOTOMessageRequest
        @param headers: SendTopBoxInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendTopBoxInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='SendTopBoxInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/topBoxes/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_top_box_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片发送接口
        
        @param request: SendTopBoxInteractiveOTOMessageRequest
        @return: SendTopBoxInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageHeaders()
        return self.send_top_box_interactive_otomessage_with_options(request, headers, runtime)

    async def send_top_box_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageResponse:
        """
        @summary 服务窗吊顶卡片发送接口
        
        @param request: SendTopBoxInteractiveOTOMessageRequest
        @return: SendTopBoxInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendTopBoxInteractiveOTOMessageHeaders()
        return await self.send_top_box_interactive_otomessage_with_options_async(request, headers, runtime)

    def update_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片修改接口
        
        @param request: UpdateInteractiveOTOMessageRequest
        @param headers: UpdateInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='UpdateInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/interactiveMessages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def update_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片修改接口
        
        @param request: UpdateInteractiveOTOMessageRequest
        @param headers: UpdateInteractiveOTOMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInteractiveOTOMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail):
            body['detail'] = request.detail
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
            action='UpdateInteractiveOTOMessage',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/oToMessages/interactiveMessages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片修改接口
        
        @param request: UpdateInteractiveOTOMessageRequest
        @return: UpdateInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders()
        return self.update_interactive_otomessage_with_options(request, headers, runtime)

    async def update_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        """
        @summary 服务窗互动卡片修改接口
        
        @param request: UpdateInteractiveOTOMessageRequest
        @return: UpdateInteractiveOTOMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders()
        return await self.update_interactive_otomessage_with_options_async(request, headers, runtime)

    def update_shortcuts_with_options(
        self,
        request: dingtalklink__1__0_models.UpdateShortcutsRequest,
        headers: dingtalklink__1__0_models.UpdateShortcutsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateShortcutsResponse:
        """
        @summary 服务窗会话窗口快捷栏配置接口
        
        @param request: UpdateShortcutsRequest
        @param headers: UpdateShortcutsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateShortcutsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.details):
            body['details'] = request.details
        if not UtilClient.is_unset(request.session_id):
            body['sessionId'] = request.session_id
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
            action='UpdateShortcuts',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/shortcuts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateShortcutsResponse(),
            self.execute(params, req, runtime)
        )

    async def update_shortcuts_with_options_async(
        self,
        request: dingtalklink__1__0_models.UpdateShortcutsRequest,
        headers: dingtalklink__1__0_models.UpdateShortcutsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateShortcutsResponse:
        """
        @summary 服务窗会话窗口快捷栏配置接口
        
        @param request: UpdateShortcutsRequest
        @param headers: UpdateShortcutsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateShortcutsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.details):
            body['details'] = request.details
        if not UtilClient.is_unset(request.session_id):
            body['sessionId'] = request.session_id
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
            action='UpdateShortcuts',
            version='link_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/link/shortcuts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateShortcutsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_shortcuts(
        self,
        request: dingtalklink__1__0_models.UpdateShortcutsRequest,
    ) -> dingtalklink__1__0_models.UpdateShortcutsResponse:
        """
        @summary 服务窗会话窗口快捷栏配置接口
        
        @param request: UpdateShortcutsRequest
        @return: UpdateShortcutsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateShortcutsHeaders()
        return self.update_shortcuts_with_options(request, headers, runtime)

    async def update_shortcuts_async(
        self,
        request: dingtalklink__1__0_models.UpdateShortcutsRequest,
    ) -> dingtalklink__1__0_models.UpdateShortcutsResponse:
        """
        @summary 服务窗会话窗口快捷栏配置接口
        
        @param request: UpdateShortcutsRequest
        @return: UpdateShortcutsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateShortcutsHeaders()
        return await self.update_shortcuts_with_options_async(request, headers, runtime)
