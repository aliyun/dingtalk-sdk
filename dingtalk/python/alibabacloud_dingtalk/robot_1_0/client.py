# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.robot_1_0 import models as dingtalkrobot__1__0_models
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

    def batch_send_oto(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchSendOTOHeaders()
        return self.batch_send_otowith_options(request, headers, runtime)

    async def batch_send_oto_async(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchSendOTOHeaders()
        return await self.batch_send_otowith_options_async(request, headers, runtime)

    def batch_send_otowith_options(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
        headers: dingtalkrobot__1__0_models.BatchSendOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchSendOTOResponse(),
            self.do_roarequest('BatchSendOTO', 'robot_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/robot/oToMessages/batchSend', 'json', req, runtime)
        )

    async def batch_send_otowith_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
        headers: dingtalkrobot__1__0_models.BatchSendOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchSendOTOResponse(),
            await self.do_roarequest_async('BatchSendOTO', 'robot_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/robot/oToMessages/batchSend', 'json', req, runtime)
        )

    def batch_otoquery(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchOTOQueryHeaders()
        return self.batch_otoquery_with_options(request, headers, runtime)

    async def batch_otoquery_async(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchOTOQueryHeaders()
        return await self.batch_otoquery_with_options_async(request, headers, runtime)

    def batch_otoquery_with_options(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
        headers: dingtalkrobot__1__0_models.BatchOTOQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.process_query_key):
            query['processQueryKey'] = request.process_query_key
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
            dingtalkrobot__1__0_models.BatchOTOQueryResponse(),
            self.do_roarequest('BatchOTOQuery', 'robot_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/robot/oToMessages/readStatus', 'json', req, runtime)
        )

    async def batch_otoquery_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
        headers: dingtalkrobot__1__0_models.BatchOTOQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.process_query_key):
            query['processQueryKey'] = request.process_query_key
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
            dingtalkrobot__1__0_models.BatchOTOQueryResponse(),
            await self.do_roarequest_async('BatchOTOQuery', 'robot_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/robot/oToMessages/readStatus', 'json', req, runtime)
        )
