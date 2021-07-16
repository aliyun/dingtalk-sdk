# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from typing import Dict
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.oauth2_1_0 import models as dingtalkoauth_2__1__0_models
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

    def get_user_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_user_token_with_options(request, headers, runtime)

    async def get_user_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_user_token_with_options_async(request, headers, runtime)

    def get_user_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.refresh_token):
            body['refreshToken'] = request.refresh_token
        if not UtilClient.is_unset(request.grant_type):
            body['grantType'] = request.grant_type
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetUserTokenResponse(),
            self.do_roarequest('GetUserToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/userAccessToken', 'json', req, runtime)
        )

    async def get_user_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.refresh_token):
            body['refreshToken'] = request.refresh_token
        if not UtilClient.is_unset(request.grant_type):
            body['grantType'] = request.grant_type
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetUserTokenResponse(),
            await self.do_roarequest_async('GetUserToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/userAccessToken', 'json', req, runtime)
        )

    def get_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_access_token_with_options(request, headers, runtime)

    async def get_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_access_token_with_options_async(request, headers, runtime)

    def get_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.app_secret):
            body['appSecret'] = request.app_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAccessTokenResponse(),
            self.do_roarequest('GetAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/accessToken', 'json', req, runtime)
        )

    async def get_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.app_secret):
            body['appSecret'] = request.app_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAccessTokenResponse(),
            await self.do_roarequest_async('GetAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/accessToken', 'json', req, runtime)
        )

    def get_suite_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_suite_access_token_with_options(request, headers, runtime)

    async def get_suite_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_suite_access_token_with_options_async(request, headers, runtime)

    def get_suite_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.suite_secret):
            body['suiteSecret'] = request.suite_secret
        if not UtilClient.is_unset(request.suite_ticket):
            body['suiteTicket'] = request.suite_ticket
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse(),
            self.do_roarequest('GetSuiteAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/suiteAccessToken', 'json', req, runtime)
        )

    async def get_suite_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.suite_secret):
            body['suiteSecret'] = request.suite_secret
        if not UtilClient.is_unset(request.suite_ticket):
            body['suiteTicket'] = request.suite_ticket
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse(),
            await self.do_roarequest_async('GetSuiteAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/suiteAccessToken', 'json', req, runtime)
        )

    def get_corp_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_corp_access_token_with_options(request, headers, runtime)

    async def get_corp_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_corp_access_token_with_options_async(request, headers, runtime)

    def get_corp_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.suite_secret):
            body['suiteSecret'] = request.suite_secret
        if not UtilClient.is_unset(request.auth_corp_id):
            body['authCorpId'] = request.auth_corp_id
        if not UtilClient.is_unset(request.suite_ticket):
            body['suiteTicket'] = request.suite_ticket
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse(),
            self.do_roarequest('GetCorpAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/corpAccessToken', 'json', req, runtime)
        )

    async def get_corp_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.suite_secret):
            body['suiteSecret'] = request.suite_secret
        if not UtilClient.is_unset(request.auth_corp_id):
            body['authCorpId'] = request.auth_corp_id
        if not UtilClient.is_unset(request.suite_ticket):
            body['suiteTicket'] = request.suite_ticket
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse(),
            await self.do_roarequest_async('GetCorpAccessToken', 'oauth2_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/oauth2/corpAccessToken', 'json', req, runtime)
        )
