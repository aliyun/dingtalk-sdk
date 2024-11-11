# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.vip_member_1_0 import models as dingtalkvip_member__1__0_models
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

    def query_vip_member_info_with_options(
        self,
        request: dingtalkvip_member__1__0_models.QueryVipMemberInfoRequest,
        headers: dingtalkvip_member__1__0_models.QueryVipMemberInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse:
        """
        @summary 查询365会员信息
        
        @param request: QueryVipMemberInfoRequest
        @param headers: QueryVipMemberInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVipMemberInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_code):
            body['channelCode'] = request.channel_code
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
            action='QueryVipMemberInfo',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/memberInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_vip_member_info_with_options_async(
        self,
        request: dingtalkvip_member__1__0_models.QueryVipMemberInfoRequest,
        headers: dingtalkvip_member__1__0_models.QueryVipMemberInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse:
        """
        @summary 查询365会员信息
        
        @param request: QueryVipMemberInfoRequest
        @param headers: QueryVipMemberInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVipMemberInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_code):
            body['channelCode'] = request.channel_code
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
            action='QueryVipMemberInfo',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/memberInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_vip_member_info(
        self,
        request: dingtalkvip_member__1__0_models.QueryVipMemberInfoRequest,
    ) -> dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse:
        """
        @summary 查询365会员信息
        
        @param request: QueryVipMemberInfoRequest
        @return: QueryVipMemberInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.QueryVipMemberInfoHeaders()
        return self.query_vip_member_info_with_options(request, headers, runtime)

    async def query_vip_member_info_async(
        self,
        request: dingtalkvip_member__1__0_models.QueryVipMemberInfoRequest,
    ) -> dingtalkvip_member__1__0_models.QueryVipMemberInfoResponse:
        """
        @summary 查询365会员信息
        
        @param request: QueryVipMemberInfoRequest
        @return: QueryVipMemberInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.QueryVipMemberInfoHeaders()
        return await self.query_vip_member_info_with_options_async(request, headers, runtime)
