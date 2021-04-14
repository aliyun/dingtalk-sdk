# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkdingmi_1_0 import models as dingtalkdingmi__1__0_models
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

    def get_ding_me_base_data(
        self,
        request: dingtalkdingmi__1__0_models.GetDingMeBaseDataRequest,
    ) -> dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdingmi__1__0_models.GetDingMeBaseDataHeaders()
        return self.get_ding_me_base_data_with_options(request, headers, runtime)

    async def get_ding_me_base_data_async(
        self,
        request: dingtalkdingmi__1__0_models.GetDingMeBaseDataRequest,
    ) -> dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdingmi__1__0_models.GetDingMeBaseDataHeaders()
        return await self.get_ding_me_base_data_with_options_async(request, headers, runtime)

    def get_ding_me_base_data_with_options(
        self,
        request: dingtalkdingmi__1__0_models.GetDingMeBaseDataRequest,
        headers: dingtalkdingmi__1__0_models.GetDingMeBaseDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_key):
            query['appKey'] = request.app_key
        if not UtilClient.is_unset(request.start_day):
            query['startDay'] = request.start_day
        if not UtilClient.is_unset(request.end_day):
            query['endDay'] = request.end_day
        if not UtilClient.is_unset(request.by_day):
            query['byDay'] = request.by_day
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
            dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse(),
            self.do_roarequest('GetDingMeBaseData', 'dingmi_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/dingmi/robots/data', 'json', req, runtime)
        )

    async def get_ding_me_base_data_with_options_async(
        self,
        request: dingtalkdingmi__1__0_models.GetDingMeBaseDataRequest,
        headers: dingtalkdingmi__1__0_models.GetDingMeBaseDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_key):
            query['appKey'] = request.app_key
        if not UtilClient.is_unset(request.start_day):
            query['startDay'] = request.start_day
        if not UtilClient.is_unset(request.end_day):
            query['endDay'] = request.end_day
        if not UtilClient.is_unset(request.by_day):
            query['byDay'] = request.by_day
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
            dingtalkdingmi__1__0_models.GetDingMeBaseDataResponse(),
            await self.do_roarequest_async('GetDingMeBaseData', 'dingmi_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/dingmi/robots/data', 'json', req, runtime)
        )
