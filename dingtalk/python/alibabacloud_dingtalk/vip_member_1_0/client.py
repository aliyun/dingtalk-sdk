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

    def direct_redeem_vip_member_by_mobile_with_options(
        self,
        request: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileRequest,
        headers: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse:
        """
        @summary 通过手机号直充365会员
        
        @param request: DirectRedeemVipMemberByMobileRequest
        @param headers: DirectRedeemVipMemberByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DirectRedeemVipMemberByMobileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='DirectRedeemVipMemberByMobile',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/directRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse(),
            self.execute(params, req, runtime)
        )

    async def direct_redeem_vip_member_by_mobile_with_options_async(
        self,
        request: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileRequest,
        headers: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse:
        """
        @summary 通过手机号直充365会员
        
        @param request: DirectRedeemVipMemberByMobileRequest
        @param headers: DirectRedeemVipMemberByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DirectRedeemVipMemberByMobileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='DirectRedeemVipMemberByMobile',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/directRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def direct_redeem_vip_member_by_mobile(
        self,
        request: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileRequest,
    ) -> dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse:
        """
        @summary 通过手机号直充365会员
        
        @param request: DirectRedeemVipMemberByMobileRequest
        @return: DirectRedeemVipMemberByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileHeaders()
        return self.direct_redeem_vip_member_by_mobile_with_options(request, headers, runtime)

    async def direct_redeem_vip_member_by_mobile_async(
        self,
        request: dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileRequest,
    ) -> dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileResponse:
        """
        @summary 通过手机号直充365会员
        
        @param request: DirectRedeemVipMemberByMobileRequest
        @return: DirectRedeemVipMemberByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.DirectRedeemVipMemberByMobileHeaders()
        return await self.direct_redeem_vip_member_by_mobile_with_options_async(request, headers, runtime)

    def invalid_redeem_vip_member_by_biz_request_id_with_options(
        self,
        request: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdRequest,
        headers: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse:
        """
        @summary 通过虚拟订单号作废365会员权益
        
        @param request: InvalidRedeemVipMemberByBizRequestIdRequest
        @param headers: InvalidRedeemVipMemberByBizRequestIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidRedeemVipMemberByBizRequestIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='InvalidRedeemVipMemberByBizRequestId',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/invalidRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse(),
            self.execute(params, req, runtime)
        )

    async def invalid_redeem_vip_member_by_biz_request_id_with_options_async(
        self,
        request: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdRequest,
        headers: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse:
        """
        @summary 通过虚拟订单号作废365会员权益
        
        @param request: InvalidRedeemVipMemberByBizRequestIdRequest
        @param headers: InvalidRedeemVipMemberByBizRequestIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvalidRedeemVipMemberByBizRequestIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='InvalidRedeemVipMemberByBizRequestId',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/invalidRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invalid_redeem_vip_member_by_biz_request_id(
        self,
        request: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdRequest,
    ) -> dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse:
        """
        @summary 通过虚拟订单号作废365会员权益
        
        @param request: InvalidRedeemVipMemberByBizRequestIdRequest
        @return: InvalidRedeemVipMemberByBizRequestIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdHeaders()
        return self.invalid_redeem_vip_member_by_biz_request_id_with_options(request, headers, runtime)

    async def invalid_redeem_vip_member_by_biz_request_id_async(
        self,
        request: dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdRequest,
    ) -> dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdResponse:
        """
        @summary 通过虚拟订单号作废365会员权益
        
        @param request: InvalidRedeemVipMemberByBizRequestIdRequest
        @return: InvalidRedeemVipMemberByBizRequestIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.InvalidRedeemVipMemberByBizRequestIdHeaders()
        return await self.invalid_redeem_vip_member_by_biz_request_id_with_options_async(request, headers, runtime)

    def pre_check_redeem_vip_member_with_options(
        self,
        request: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberRequest,
        headers: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse:
        """
        @summary 直充会员预校验是否满足条件
        
        @param request: PreCheckRedeemVipMemberRequest
        @param headers: PreCheckRedeemVipMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreCheckRedeemVipMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='PreCheckRedeemVipMember',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/preCheckRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def pre_check_redeem_vip_member_with_options_async(
        self,
        request: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberRequest,
        headers: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse:
        """
        @summary 直充会员预校验是否满足条件
        
        @param request: PreCheckRedeemVipMemberRequest
        @param headers: PreCheckRedeemVipMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreCheckRedeemVipMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='PreCheckRedeemVipMember',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/preCheckRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pre_check_redeem_vip_member(
        self,
        request: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberRequest,
    ) -> dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse:
        """
        @summary 直充会员预校验是否满足条件
        
        @param request: PreCheckRedeemVipMemberRequest
        @return: PreCheckRedeemVipMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberHeaders()
        return self.pre_check_redeem_vip_member_with_options(request, headers, runtime)

    async def pre_check_redeem_vip_member_async(
        self,
        request: dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberRequest,
    ) -> dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberResponse:
        """
        @summary 直充会员预校验是否满足条件
        
        @param request: PreCheckRedeemVipMemberRequest
        @return: PreCheckRedeemVipMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.PreCheckRedeemVipMemberHeaders()
        return await self.pre_check_redeem_vip_member_with_options_async(request, headers, runtime)

    def query_redeem_vip_member_with_options(
        self,
        request: dingtalkvip_member__1__0_models.QueryRedeemVipMemberRequest,
        headers: dingtalkvip_member__1__0_models.QueryRedeemVipMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse:
        """
        @summary 查询365会员直充信息
        
        @param request: QueryRedeemVipMemberRequest
        @param headers: QueryRedeemVipMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedeemVipMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='QueryRedeemVipMember',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/queryRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def query_redeem_vip_member_with_options_async(
        self,
        request: dingtalkvip_member__1__0_models.QueryRedeemVipMemberRequest,
        headers: dingtalkvip_member__1__0_models.QueryRedeemVipMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse:
        """
        @summary 查询365会员直充信息
        
        @param request: QueryRedeemVipMemberRequest
        @param headers: QueryRedeemVipMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedeemVipMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_request_id):
            body['bizRequestId'] = request.biz_request_id
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.dingtalk_id):
            body['dingtalkId'] = request.dingtalk_id
        if not UtilClient.is_unset(request.duration):
            body['duration'] = request.duration
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='QueryRedeemVipMember',
            version='vipMember_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/vipMember/users/queryRedeemVip',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_redeem_vip_member(
        self,
        request: dingtalkvip_member__1__0_models.QueryRedeemVipMemberRequest,
    ) -> dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse:
        """
        @summary 查询365会员直充信息
        
        @param request: QueryRedeemVipMemberRequest
        @return: QueryRedeemVipMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.QueryRedeemVipMemberHeaders()
        return self.query_redeem_vip_member_with_options(request, headers, runtime)

    async def query_redeem_vip_member_async(
        self,
        request: dingtalkvip_member__1__0_models.QueryRedeemVipMemberRequest,
    ) -> dingtalkvip_member__1__0_models.QueryRedeemVipMemberResponse:
        """
        @summary 查询365会员直充信息
        
        @param request: QueryRedeemVipMemberRequest
        @return: QueryRedeemVipMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkvip_member__1__0_models.QueryRedeemVipMemberHeaders()
        return await self.query_redeem_vip_member_with_options_async(request, headers, runtime)

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
