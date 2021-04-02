# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkats_1_0 import models as dingtalkats__1__0_models
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

    def get_job_auth(
        self,
        job_id: str,
        request: dingtalkats__1__0_models.GetJobAuthRequest,
    ) -> dingtalkats__1__0_models.GetJobAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkats__1__0_models.GetJobAuthHeaders()
        return self.get_job_auth_with_options(job_id, request, headers, runtime)

    async def get_job_auth_async(
        self,
        job_id: str,
        request: dingtalkats__1__0_models.GetJobAuthRequest,
    ) -> dingtalkats__1__0_models.GetJobAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkats__1__0_models.GetJobAuthHeaders()
        return await self.get_job_auth_with_options_async(job_id, request, headers, runtime)

    def get_job_auth_with_options(
        self,
        job_id: str,
        request: dingtalkats__1__0_models.GetJobAuthRequest,
        headers: dingtalkats__1__0_models.GetJobAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkats__1__0_models.GetJobAuthResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            dingtalkats__1__0_models.GetJobAuthResponse(),
            self.do_roarequest('GetJobAuth', 'ats_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/ats/auths/jobs/{job_id}', 'json', req, runtime)
        )

    async def get_job_auth_with_options_async(
        self,
        job_id: str,
        request: dingtalkats__1__0_models.GetJobAuthRequest,
        headers: dingtalkats__1__0_models.GetJobAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkats__1__0_models.GetJobAuthResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            dingtalkats__1__0_models.GetJobAuthResponse(),
            await self.do_roarequest_async('GetJobAuth', 'ats_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/ats/auths/jobs/{job_id}', 'json', req, runtime)
        )
