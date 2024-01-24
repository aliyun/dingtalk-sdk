# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.mail_1_0 import models as dingtalkmail__1__0_models
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

    def create_user_with_options(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
        headers: dingtalkmail__1__0_models.CreateUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.employee_type):
            body['employeeType'] = request.employee_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.password):
            body['password'] = request.password
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
            action='CreateUser',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateUserResponse(),
            self.execute(params, req, runtime)
        )

    async def create_user_with_options_async(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
        headers: dingtalkmail__1__0_models.CreateUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.email):
            body['email'] = request.email
        if not UtilClient.is_unset(request.employee_type):
            body['employeeType'] = request.employee_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.password):
            body['password'] = request.password
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
            action='CreateUser',
            version='mail_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mail/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmail__1__0_models.CreateUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_user(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateUserHeaders()
        return self.create_user_with_options(request, headers, runtime)

    async def create_user_async(
        self,
        request: dingtalkmail__1__0_models.CreateUserRequest,
    ) -> dingtalkmail__1__0_models.CreateUserResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmail__1__0_models.CreateUserHeaders()
        return await self.create_user_with_options_async(request, headers, runtime)
