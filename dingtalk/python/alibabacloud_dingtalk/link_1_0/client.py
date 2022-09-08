# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_follower_info(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerInfoHeaders()
        return self.get_follower_info_with_options(request, headers, runtime)

    async def get_follower_info_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetFollowerInfoHeaders()
        return await self.get_follower_info_with_options_async(request, headers, runtime)

    def get_follower_info_with_options(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerInfoResponse(),
            self.do_roarequest('GetFollowerInfo', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/followers/infos', 'json', req, runtime)
        )

    async def get_follower_info_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetFollowerInfoRequest,
        headers: dingtalklink__1__0_models.GetFollowerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetFollowerInfoResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetFollowerInfoResponse(),
            await self.do_roarequest_async('GetFollowerInfo', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/followers/infos', 'json', req, runtime)
        )

    def get_picture_download_url(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetPictureDownloadUrlHeaders()
        return self.get_picture_download_url_with_options(request, headers, runtime)

    async def get_picture_download_url_async(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.GetPictureDownloadUrlHeaders()
        return await self.get_picture_download_url_with_options_async(request, headers, runtime)

    def get_picture_download_url_with_options(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
        headers: dingtalklink__1__0_models.GetPictureDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetPictureDownloadUrlResponse(),
            self.do_roarequest('GetPictureDownloadUrl', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/oToMessages/pictures/downloadUrls', 'json', req, runtime)
        )

    async def get_picture_download_url_with_options_async(
        self,
        request: dingtalklink__1__0_models.GetPictureDownloadUrlRequest,
        headers: dingtalklink__1__0_models.GetPictureDownloadUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.GetPictureDownloadUrlResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.GetPictureDownloadUrlResponse(),
            await self.do_roarequest_async('GetPictureDownloadUrl', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/oToMessages/pictures/downloadUrls', 'json', req, runtime)
        )

    def list_follower(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListFollowerHeaders()
        return self.list_follower_with_options(request, headers, runtime)

    async def list_follower_async(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.ListFollowerHeaders()
        return await self.list_follower_with_options_async(request, headers, runtime)

    def list_follower_with_options(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
        headers: dingtalklink__1__0_models.ListFollowerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListFollowerResponse(),
            self.do_roarequest('ListFollower', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/followers', 'json', req, runtime)
        )

    async def list_follower_with_options_async(
        self,
        request: dingtalklink__1__0_models.ListFollowerRequest,
        headers: dingtalklink__1__0_models.ListFollowerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.ListFollowerResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.ListFollowerResponse(),
            await self.do_roarequest_async('ListFollower', 'link_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/link/followers', 'json', req, runtime)
        )

    def send_agent_otomessage(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendAgentOTOMessageHeaders()
        return self.send_agent_otomessage_with_options(request, headers, runtime)

    async def send_agent_otomessage_async(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendAgentOTOMessageHeaders()
        return await self.send_agent_otomessage_with_options_async(request, headers, runtime)

    def send_agent_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendAgentOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendAgentOTOMessageResponse(),
            self.do_roarequest('SendAgentOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/link/oToMessages/agentMessages', 'json', req, runtime)
        )

    async def send_agent_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.SendAgentOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendAgentOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendAgentOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendAgentOTOMessageResponse(),
            await self.do_roarequest_async('SendAgentOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/link/oToMessages/agentMessages', 'json', req, runtime)
        )

    def send_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders()
        return self.send_interactive_otomessage_with_options(request, headers, runtime)

    async def send_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders()
        return await self.send_interactive_otomessage_with_options_async(request, headers, runtime)

    def send_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendInteractiveOTOMessageResponse(),
            self.do_roarequest('SendInteractiveOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/link/oToMessages/interactiveMessages', 'json', req, runtime)
        )

    async def send_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.SendInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.SendInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.SendInteractiveOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.SendInteractiveOTOMessageResponse(),
            await self.do_roarequest_async('SendInteractiveOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/link/oToMessages/interactiveMessages', 'json', req, runtime)
        )

    def update_interactive_otomessage(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders()
        return self.update_interactive_otomessage_with_options(request, headers, runtime)

    async def update_interactive_otomessage_async(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders()
        return await self.update_interactive_otomessage_with_options_async(request, headers, runtime)

    def update_interactive_otomessage_with_options(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse(),
            self.do_roarequest('UpdateInteractiveOTOMessage', 'link_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/link/oToMessages/interactiveMessages', 'json', req, runtime)
        )

    async def update_interactive_otomessage_with_options_async(
        self,
        request: dingtalklink__1__0_models.UpdateInteractiveOTOMessageRequest,
        headers: dingtalklink__1__0_models.UpdateInteractiveOTOMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse:
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
        return TeaCore.from_map(
            dingtalklink__1__0_models.UpdateInteractiveOTOMessageResponse(),
            await self.do_roarequest_async('UpdateInteractiveOTOMessage', 'link_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/link/oToMessages/interactiveMessages', 'json', req, runtime)
        )
