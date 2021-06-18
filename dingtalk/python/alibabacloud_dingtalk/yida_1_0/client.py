# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkyida_1_0 import models as dingtalkyida__1__0_models
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

    def login_code_gen(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return self.login_code_gen_with_options(request, headers, runtime)

    async def login_code_gen_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return await self.login_code_gen_with_options_async(request, headers, runtime)

    def login_code_gen_with_options(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            self.do_roarequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/authorizations/loginCodes', 'json', req, runtime)
        )

    async def login_code_gen_with_options_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            await self.do_roarequest_async('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/authorizations/loginCodes', 'json', req, runtime)
        )
