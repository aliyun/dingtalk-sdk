# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
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
        self._product_id = 'dingtalk'
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def create_jsapi_ticket_with_options(
        self,
        headers: dingtalkoauth_2__1__0_models.CreateJsapiTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse:
        """
        @summary 生成jsapi ticket
        
        @param headers: CreateJsapiTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateJsapiTicketResponse
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
            action='CreateJsapiTicket',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/jsapiTickets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def create_jsapi_ticket_with_options_async(
        self,
        headers: dingtalkoauth_2__1__0_models.CreateJsapiTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse:
        """
        @summary 生成jsapi ticket
        
        @param headers: CreateJsapiTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateJsapiTicketResponse
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
            action='CreateJsapiTicket',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/jsapiTickets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_jsapi_ticket(self) -> dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse:
        """
        @summary 生成jsapi ticket
        
        @return: CreateJsapiTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.CreateJsapiTicketHeaders()
        return self.create_jsapi_ticket_with_options(headers, runtime)

    async def create_jsapi_ticket_async(self) -> dingtalkoauth_2__1__0_models.CreateJsapiTicketResponse:
        """
        @summary 生成jsapi ticket
        
        @return: CreateJsapiTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.CreateJsapiTicketHeaders()
        return await self.create_jsapi_ticket_with_options_async(headers, runtime)

    def get_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        """
        @summary 获取企业accessToken(企业内部应用)
        
        @param request: GetAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccessTokenResponse
        """
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
        params = open_api_models.Params(
            action='GetAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/accessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAccessTokenResponse(),
            self.do_roarequest_with_form(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        """
        @summary 获取企业accessToken(企业内部应用)
        
        @param request: GetAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccessTokenResponse
        """
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
        params = open_api_models.Params(
            action='GetAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/accessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAccessTokenResponse(),
            await self.do_roarequest_with_form_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        """
        @summary 获取企业accessToken(企业内部应用)
        
        @param request: GetAccessTokenRequest
        @return: GetAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_access_token_with_options(request, headers, runtime)

    async def get_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAccessTokenResponse:
        """
        @summary 获取企业accessToken(企业内部应用)
        
        @param request: GetAccessTokenRequest
        @return: GetAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_access_token_with_options_async(request, headers, runtime)

    def get_auth_info_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetAuthInfoRequest,
        headers: dingtalkoauth_2__1__0_models.GetAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAuthInfoResponse:
        """
        @summary 获取企业开通应用后的授权信息
        
        @param request: GetAuthInfoRequest
        @param headers: GetAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAuthInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_corp_id):
            query['authCorpId'] = request.auth_corp_id
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
            action='GetAuthInfo',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/apps/authInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_auth_info_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAuthInfoRequest,
        headers: dingtalkoauth_2__1__0_models.GetAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetAuthInfoResponse:
        """
        @summary 获取企业开通应用后的授权信息
        
        @param request: GetAuthInfoRequest
        @param headers: GetAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAuthInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_corp_id):
            query['authCorpId'] = request.auth_corp_id
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
            action='GetAuthInfo',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/apps/authInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_auth_info(
        self,
        request: dingtalkoauth_2__1__0_models.GetAuthInfoRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAuthInfoResponse:
        """
        @summary 获取企业开通应用后的授权信息
        
        @param request: GetAuthInfoRequest
        @return: GetAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetAuthInfoHeaders()
        return self.get_auth_info_with_options(request, headers, runtime)

    async def get_auth_info_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetAuthInfoRequest,
    ) -> dingtalkoauth_2__1__0_models.GetAuthInfoResponse:
        """
        @summary 获取企业开通应用后的授权信息
        
        @param request: GetAuthInfoRequest
        @return: GetAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetAuthInfoHeaders()
        return await self.get_auth_info_with_options_async(request, headers, runtime)

    def get_corp_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        """
        @summary 获取企业accessToken(应用商店应用)
        
        @param request: GetCorpAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpAccessTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_corp_id):
            body['authCorpId'] = request.auth_corp_id
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
        params = open_api_models.Params(
            action='GetCorpAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/corpAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse(),
            self.do_roarequest_with_form(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_corp_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        """
        @summary 获取企业accessToken(应用商店应用)
        
        @param request: GetCorpAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpAccessTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_corp_id):
            body['authCorpId'] = request.auth_corp_id
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
        params = open_api_models.Params(
            action='GetCorpAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/corpAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse(),
            await self.do_roarequest_with_form_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_corp_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        """
        @summary 获取企业accessToken(应用商店应用)
        
        @param request: GetCorpAccessTokenRequest
        @return: GetCorpAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_corp_access_token_with_options(request, headers, runtime)

    async def get_corp_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetCorpAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetCorpAccessTokenResponse:
        """
        @summary 获取企业accessToken(应用商店应用)
        
        @param request: GetCorpAccessTokenRequest
        @return: GetCorpAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_corp_access_token_with_options_async(request, headers, runtime)

    def get_personal_auth_rule_with_options(
        self,
        headers: dingtalkoauth_2__1__0_models.GetPersonalAuthRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse:
        """
        @summary 查询个人授权记录
        
        @param headers: GetPersonalAuthRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalAuthRuleResponse
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
            action='GetPersonalAuthRule',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/authRules/user',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def get_personal_auth_rule_with_options_async(
        self,
        headers: dingtalkoauth_2__1__0_models.GetPersonalAuthRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse:
        """
        @summary 查询个人授权记录
        
        @param headers: GetPersonalAuthRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalAuthRuleResponse
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
            action='GetPersonalAuthRule',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/authRules/user',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_personal_auth_rule(self) -> dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse:
        """
        @summary 查询个人授权记录
        
        @return: GetPersonalAuthRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetPersonalAuthRuleHeaders()
        return self.get_personal_auth_rule_with_options(headers, runtime)

    async def get_personal_auth_rule_async(self) -> dingtalkoauth_2__1__0_models.GetPersonalAuthRuleResponse:
        """
        @summary 查询个人授权记录
        
        @return: GetPersonalAuthRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetPersonalAuthRuleHeaders()
        return await self.get_personal_auth_rule_with_options_async(headers, runtime)

    def get_sso_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse:
        """
        @summary 生成微应用管理后台accessToken
        
        @param request: GetSsoAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSsoAccessTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corpid):
            body['corpid'] = request.corpid
        if not UtilClient.is_unset(request.sso_secret):
            body['ssoSecret'] = request.sso_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSsoAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/ssoAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse(),
            self.do_roarequest(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_sso_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse:
        """
        @summary 生成微应用管理后台accessToken
        
        @param request: GetSsoAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSsoAccessTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corpid):
            body['corpid'] = request.corpid
        if not UtilClient.is_unset(request.sso_secret):
            body['ssoSecret'] = request.sso_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSsoAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/ssoAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse(),
            await self.do_roarequest_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_sso_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse:
        """
        @summary 生成微应用管理后台accessToken
        
        @param request: GetSsoAccessTokenRequest
        @return: GetSsoAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_sso_access_token_with_options(request, headers, runtime)

    async def get_sso_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSsoAccessTokenResponse:
        """
        @summary 生成微应用管理后台accessToken
        
        @param request: GetSsoAccessTokenRequest
        @return: GetSsoAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_sso_access_token_with_options_async(request, headers, runtime)

    def get_sso_user_info_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoUserInfoRequest,
        headers: dingtalkoauth_2__1__0_models.GetSsoUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse:
        """
        @summary 查询微应用后台免登的用户信息
        
        @param request: GetSsoUserInfoRequest
        @param headers: GetSsoUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSsoUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
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
            action='GetSsoUserInfo',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/ssoUserInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sso_user_info_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoUserInfoRequest,
        headers: dingtalkoauth_2__1__0_models.GetSsoUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse:
        """
        @summary 查询微应用后台免登的用户信息
        
        @param request: GetSsoUserInfoRequest
        @param headers: GetSsoUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSsoUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
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
            action='GetSsoUserInfo',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/ssoUserInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sso_user_info(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoUserInfoRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse:
        """
        @summary 查询微应用后台免登的用户信息
        
        @param request: GetSsoUserInfoRequest
        @return: GetSsoUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetSsoUserInfoHeaders()
        return self.get_sso_user_info_with_options(request, headers, runtime)

    async def get_sso_user_info_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSsoUserInfoRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSsoUserInfoResponse:
        """
        @summary 查询微应用后台免登的用户信息
        
        @param request: GetSsoUserInfoRequest
        @return: GetSsoUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkoauth_2__1__0_models.GetSsoUserInfoHeaders()
        return await self.get_sso_user_info_with_options_async(request, headers, runtime)

    def get_suite_access_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        """
        @summary 获取isvAccessToken（三方企业应用）
        
        @param request: GetSuiteAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSuiteAccessTokenResponse
        """
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
        params = open_api_models.Params(
            action='GetSuiteAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/suiteAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse(),
            self.do_roarequest(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_suite_access_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        """
        @summary 获取isvAccessToken（三方企业应用）
        
        @param request: GetSuiteAccessTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSuiteAccessTokenResponse
        """
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
        params = open_api_models.Params(
            action='GetSuiteAccessToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/suiteAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse(),
            await self.do_roarequest_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_suite_access_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        """
        @summary 获取isvAccessToken（三方企业应用）
        
        @param request: GetSuiteAccessTokenRequest
        @return: GetSuiteAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_suite_access_token_with_options(request, headers, runtime)

    async def get_suite_access_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetSuiteAccessTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetSuiteAccessTokenResponse:
        """
        @summary 获取isvAccessToken（三方企业应用）
        
        @param request: GetSuiteAccessTokenRequest
        @return: GetSuiteAccessTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_suite_access_token_with_options_async(request, headers, runtime)

    def get_token_with_options(
        self,
        corp_id: str,
        request: dingtalkoauth_2__1__0_models.GetTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetTokenResponse:
        """
        @summary 获取Access Token
        
        @param request: GetTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['client_id'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['client_secret'] = request.client_secret
        if not UtilClient.is_unset(request.grant_type):
            body['grant_type'] = request.grant_type
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/{corp_id}/token',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetTokenResponse(),
            self.do_roarequest_with_form(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_token_with_options_async(
        self,
        corp_id: str,
        request: dingtalkoauth_2__1__0_models.GetTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetTokenResponse:
        """
        @summary 获取Access Token
        
        @param request: GetTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['client_id'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['client_secret'] = request.client_secret
        if not UtilClient.is_unset(request.grant_type):
            body['grant_type'] = request.grant_type
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/{corp_id}/token',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetTokenResponse(),
            await self.do_roarequest_with_form_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_token(
        self,
        corp_id: str,
        request: dingtalkoauth_2__1__0_models.GetTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetTokenResponse:
        """
        @summary 获取Access Token
        
        @param request: GetTokenRequest
        @return: GetTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_token_with_options(corp_id, request, headers, runtime)

    async def get_token_async(
        self,
        corp_id: str,
        request: dingtalkoauth_2__1__0_models.GetTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetTokenResponse:
        """
        @summary 获取Access Token
        
        @param request: GetTokenRequest
        @return: GetTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_token_with_options_async(corp_id, request, headers, runtime)

    def get_user_token_with_options(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        """
        @summary 获取用户token
        
        @param request: GetUserTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.grant_type):
            body['grantType'] = request.grant_type
        if not UtilClient.is_unset(request.refresh_token):
            body['refreshToken'] = request.refresh_token
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/userAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetUserTokenResponse(),
            self.do_roarequest(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def get_user_token_with_options_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        """
        @summary 获取用户token
        
        @param request: GetUserTokenRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.grant_type):
            body['grantType'] = request.grant_type
        if not UtilClient.is_unset(request.refresh_token):
            body['refreshToken'] = request.refresh_token
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetUserToken',
            version='oauth2_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/oauth2/userAccessToken',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkoauth_2__1__0_models.GetUserTokenResponse(),
            await self.do_roarequest_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def get_user_token(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        """
        @summary 获取用户token
        
        @param request: GetUserTokenRequest
        @return: GetUserTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.get_user_token_with_options(request, headers, runtime)

    async def get_user_token_async(
        self,
        request: dingtalkoauth_2__1__0_models.GetUserTokenRequest,
    ) -> dingtalkoauth_2__1__0_models.GetUserTokenResponse:
        """
        @summary 获取用户token
        
        @param request: GetUserTokenRequest
        @return: GetUserTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.get_user_token_with_options_async(request, headers, runtime)
