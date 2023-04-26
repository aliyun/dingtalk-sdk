# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.conv_file_1_0 import models as dingtalkconv_file__1__0_models
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

    def get_space_with_options(
        self,
        request: dingtalkconv_file__1__0_models.GetSpaceRequest,
        headers: dingtalkconv_file__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.GetSpaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetSpace',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.GetSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_with_options_async(
        self,
        request: dingtalkconv_file__1__0_models.GetSpaceRequest,
        headers: dingtalkconv_file__1__0_models.GetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.GetSpaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetSpace',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.GetSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space(
        self,
        request: dingtalkconv_file__1__0_models.GetSpaceRequest,
    ) -> dingtalkconv_file__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.GetSpaceHeaders()
        return self.get_space_with_options(request, headers, runtime)

    async def get_space_async(
        self,
        request: dingtalkconv_file__1__0_models.GetSpaceRequest,
    ) -> dingtalkconv_file__1__0_models.GetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.GetSpaceHeaders()
        return await self.get_space_with_options_async(request, headers, runtime)

    def send_with_options(
        self,
        request: dingtalkconv_file__1__0_models.SendRequest,
        headers: dingtalkconv_file__1__0_models.SendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='Send',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/files/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendResponse(),
            self.execute(params, req, runtime)
        )

    async def send_with_options_async(
        self,
        request: dingtalkconv_file__1__0_models.SendRequest,
        headers: dingtalkconv_file__1__0_models.SendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='Send',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/files/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send(
        self,
        request: dingtalkconv_file__1__0_models.SendRequest,
    ) -> dingtalkconv_file__1__0_models.SendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendHeaders()
        return self.send_with_options(request, headers, runtime)

    async def send_async(
        self,
        request: dingtalkconv_file__1__0_models.SendRequest,
    ) -> dingtalkconv_file__1__0_models.SendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendHeaders()
        return await self.send_with_options_async(request, headers, runtime)

    def send_by_app_with_options(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
        headers: dingtalkconv_file__1__0_models.SendByAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='SendByApp',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/apps/conversations/files/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendByAppResponse(),
            self.execute(params, req, runtime)
        )

    async def send_by_app_with_options_async(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
        headers: dingtalkconv_file__1__0_models.SendByAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='SendByApp',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/apps/conversations/files/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendByAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_by_app(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendByAppHeaders()
        return self.send_by_app_with_options(request, headers, runtime)

    async def send_by_app_async(
        self,
        request: dingtalkconv_file__1__0_models.SendByAppRequest,
    ) -> dingtalkconv_file__1__0_models.SendByAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendByAppHeaders()
        return await self.send_by_app_with_options_async(request, headers, runtime)

    def send_link_with_options(
        self,
        request: dingtalkconv_file__1__0_models.SendLinkRequest,
        headers: dingtalkconv_file__1__0_models.SendLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendLinkResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='SendLink',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/files/links/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendLinkResponse(),
            self.execute(params, req, runtime)
        )

    async def send_link_with_options_async(
        self,
        request: dingtalkconv_file__1__0_models.SendLinkRequest,
        headers: dingtalkconv_file__1__0_models.SendLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconv_file__1__0_models.SendLinkResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='SendLink',
            version='convFile_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/convFile/conversations/files/links/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconv_file__1__0_models.SendLinkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_link(
        self,
        request: dingtalkconv_file__1__0_models.SendLinkRequest,
    ) -> dingtalkconv_file__1__0_models.SendLinkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendLinkHeaders()
        return self.send_link_with_options(request, headers, runtime)

    async def send_link_async(
        self,
        request: dingtalkconv_file__1__0_models.SendLinkRequest,
    ) -> dingtalkconv_file__1__0_models.SendLinkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconv_file__1__0_models.SendLinkHeaders()
        return await self.send_link_with_options_async(request, headers, runtime)
