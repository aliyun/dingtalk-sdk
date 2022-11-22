# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.event_1_0 import models as dingtalkevent__1__0_models
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

    def get_call_back_faile_result(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return self.get_call_back_faile_result_with_options(request, headers, runtime)

    async def get_call_back_faile_result_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return await self.get_call_back_faile_result_with_options_async(request, headers, runtime)

    def get_call_back_faile_result_with_options(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            self.do_roarequest('GetCallBackFaileResult', 'event_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/event/callbacks/failedResults', 'json', req, runtime)
        )

    async def get_call_back_faile_result_with_options_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            await self.do_roarequest_async('GetCallBackFaileResult', 'event_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/event/callbacks/failedResults', 'json', req, runtime)
        )
