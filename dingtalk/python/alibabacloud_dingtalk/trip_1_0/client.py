# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.trip_1_0 import models as dingtalktrip__1__0_models
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

    def sync_business_sign_info_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
        headers: dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type_list):
            body['bizTypeList'] = request.biz_type_list
        if not UtilClient.is_unset(request.gmt_org_pay):
            body['gmtOrgPay'] = request.gmt_org_pay
        if not UtilClient.is_unset(request.gmt_sign):
            body['gmtSign'] = request.gmt_sign
        if not UtilClient.is_unset(request.org_pay_status):
            body['orgPayStatus'] = request.org_pay_status
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_product_detail_list):
            body['tmcProductDetailList'] = request.tmc_product_detail_list
        if not UtilClient.is_unset(request.tmc_product_list):
            body['tmcProductList'] = request.tmc_product_list
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
            action='SyncBusinessSignInfo',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/businessSignInfos/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncBusinessSignInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_business_sign_info_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
        headers: dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type_list):
            body['bizTypeList'] = request.biz_type_list
        if not UtilClient.is_unset(request.gmt_org_pay):
            body['gmtOrgPay'] = request.gmt_org_pay
        if not UtilClient.is_unset(request.gmt_sign):
            body['gmtSign'] = request.gmt_sign
        if not UtilClient.is_unset(request.org_pay_status):
            body['orgPayStatus'] = request.org_pay_status
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_product_detail_list):
            body['tmcProductDetailList'] = request.tmc_product_detail_list
        if not UtilClient.is_unset(request.tmc_product_list):
            body['tmcProductList'] = request.tmc_product_list
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
            action='SyncBusinessSignInfo',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/businessSignInfos/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncBusinessSignInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_business_sign_info(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders()
        return self.sync_business_sign_info_with_options(request, headers, runtime)

    async def sync_business_sign_info_async(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders()
        return await self.sync_business_sign_info_with_options_async(request, headers, runtime)

    def sync_secret_key_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
        headers: dingtalktrip__1__0_models.SyncSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.secret_string):
            body['secretString'] = request.secret_string
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_app_key):
            body['tripAppKey'] = request.trip_app_key
        if not UtilClient.is_unset(request.trip_app_security):
            body['tripAppSecurity'] = request.trip_app_security
        if not UtilClient.is_unset(request.trip_corp_id):
            body['tripCorpId'] = request.trip_corp_id
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
            action='SyncSecretKey',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/secretKeys/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncSecretKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_secret_key_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
        headers: dingtalktrip__1__0_models.SyncSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.secret_string):
            body['secretString'] = request.secret_string
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_app_key):
            body['tripAppKey'] = request.trip_app_key
        if not UtilClient.is_unset(request.trip_app_security):
            body['tripAppSecurity'] = request.trip_app_security
        if not UtilClient.is_unset(request.trip_corp_id):
            body['tripCorpId'] = request.trip_corp_id
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
            action='SyncSecretKey',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/secretKeys/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncSecretKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_secret_key(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncSecretKeyHeaders()
        return self.sync_secret_key_with_options(request, headers, runtime)

    async def sync_secret_key_async(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncSecretKeyHeaders()
        return await self.sync_secret_key_with_options_async(request, headers, runtime)

    def sync_trip_order_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
        headers: dingtalktrip__1__0_models.SyncTripOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_type):
            body['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.currency):
            body['currency'] = request.currency
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.discount_amount):
            body['discountAmount'] = request.discount_amount
        if not UtilClient.is_unset(request.endorse_flag):
            body['endorseFlag'] = request.endorse_flag
        if not UtilClient.is_unset(request.event):
            body['event'] = request.event
        if not UtilClient.is_unset(request.gmt_order):
            body['gmtOrder'] = request.gmt_order
        if not UtilClient.is_unset(request.gmt_pay):
            body['gmtPay'] = request.gmt_pay
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.invoice_apply_url):
            body['invoiceApplyUrl'] = request.invoice_apply_url
        if not UtilClient.is_unset(request.journey_biz_no):
            body['journeyBizNo'] = request.journey_biz_no
        if not UtilClient.is_unset(request.order_details):
            body['orderDetails'] = request.order_details
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.order_url):
            body['orderUrl'] = request.order_url
        if not UtilClient.is_unset(request.process_id):
            body['processId'] = request.process_id
        if not UtilClient.is_unset(request.real_amount):
            body['realAmount'] = request.real_amount
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.relative_order_no):
            body['relativeOrderNo'] = request.relative_order_no
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.supply_logo):
            body['supplyLogo'] = request.supply_logo
        if not UtilClient.is_unset(request.supply_name):
            body['supplyName'] = request.supply_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SyncTripOrder',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/tripOrders/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_trip_order_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
        headers: dingtalktrip__1__0_models.SyncTripOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_type):
            body['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.currency):
            body['currency'] = request.currency
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.discount_amount):
            body['discountAmount'] = request.discount_amount
        if not UtilClient.is_unset(request.endorse_flag):
            body['endorseFlag'] = request.endorse_flag
        if not UtilClient.is_unset(request.event):
            body['event'] = request.event
        if not UtilClient.is_unset(request.gmt_order):
            body['gmtOrder'] = request.gmt_order
        if not UtilClient.is_unset(request.gmt_pay):
            body['gmtPay'] = request.gmt_pay
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.invoice_apply_url):
            body['invoiceApplyUrl'] = request.invoice_apply_url
        if not UtilClient.is_unset(request.journey_biz_no):
            body['journeyBizNo'] = request.journey_biz_no
        if not UtilClient.is_unset(request.order_details):
            body['orderDetails'] = request.order_details
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.order_url):
            body['orderUrl'] = request.order_url
        if not UtilClient.is_unset(request.process_id):
            body['processId'] = request.process_id
        if not UtilClient.is_unset(request.real_amount):
            body['realAmount'] = request.real_amount
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.relative_order_no):
            body['relativeOrderNo'] = request.relative_order_no
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.supply_logo):
            body['supplyLogo'] = request.supply_logo
        if not UtilClient.is_unset(request.supply_name):
            body['supplyName'] = request.supply_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SyncTripOrder',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/tripOrders/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_trip_order(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripOrderHeaders()
        return self.sync_trip_order_with_options(request, headers, runtime)

    async def sync_trip_order_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripOrderHeaders()
        return await self.sync_trip_order_with_options_async(request, headers, runtime)
