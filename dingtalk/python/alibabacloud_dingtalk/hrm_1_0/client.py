# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkhrm_1_0 import models as dingtalkhrm__1__0_models
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

    def add_hrm_preentry(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return self.add_hrm_preentry_with_options(request, headers, runtime)

    async def add_hrm_preentry_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkhrm__1__0_models.AddHrmPreentryHeaders()
        return await self.add_hrm_preentry_with_options_async(request, headers, runtime)

    def add_hrm_preentry_with_options(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
        headers: dingtalkhrm__1__0_models.AddHrmPreentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pre_entry_time):
            body['preEntryTime'] = request.pre_entry_time
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.groups):
            body['groups'] = request.groups
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkhrm__1__0_models.AddHrmPreentryResponse().from_map(
            self.do_roarequest('AddHrmPreentry', 'hrm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/hrm/preentries', 'json', req, runtime)
        )

    async def add_hrm_preentry_with_options_async(
        self,
        request: dingtalkhrm__1__0_models.AddHrmPreentryRequest,
        headers: dingtalkhrm__1__0_models.AddHrmPreentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkhrm__1__0_models.AddHrmPreentryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pre_entry_time):
            body['preEntryTime'] = request.pre_entry_time
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.groups):
            body['groups'] = request.groups
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkhrm__1__0_models.AddHrmPreentryResponse().from_map(
            await self.do_roarequest_async('AddHrmPreentry', 'hrm_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/hrm/preentries', 'json', req, runtime)
        )
