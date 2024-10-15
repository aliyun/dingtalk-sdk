# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.check_in_1_0 import models as dingtalkcheck_in__1__0_models
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
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_checkin_record_by_user_with_options(
        self,
        request: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserRequest,
        headers: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse:
        """
        @summary 调用本接口，获取用户签到记录
        
        @param request: GetCheckinRecordByUserRequest
        @param headers: GetCheckinRecordByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCheckinRecordByUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetCheckinRecordByUser',
            version='checkIn_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/checkIn/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_checkin_record_by_user_with_options_async(
        self,
        request: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserRequest,
        headers: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse:
        """
        @summary 调用本接口，获取用户签到记录
        
        @param request: GetCheckinRecordByUserRequest
        @param headers: GetCheckinRecordByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCheckinRecordByUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='GetCheckinRecordByUser',
            version='checkIn_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/checkIn/records/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_checkin_record_by_user(
        self,
        request: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserRequest,
    ) -> dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse:
        """
        @summary 调用本接口，获取用户签到记录
        
        @param request: GetCheckinRecordByUserRequest
        @return: GetCheckinRecordByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcheck_in__1__0_models.GetCheckinRecordByUserHeaders()
        return self.get_checkin_record_by_user_with_options(request, headers, runtime)

    async def get_checkin_record_by_user_async(
        self,
        request: dingtalkcheck_in__1__0_models.GetCheckinRecordByUserRequest,
    ) -> dingtalkcheck_in__1__0_models.GetCheckinRecordByUserResponse:
        """
        @summary 调用本接口，获取用户签到记录
        
        @param request: GetCheckinRecordByUserRequest
        @return: GetCheckinRecordByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcheck_in__1__0_models.GetCheckinRecordByUserHeaders()
        return await self.get_checkin_record_by_user_with_options_async(request, headers, runtime)
