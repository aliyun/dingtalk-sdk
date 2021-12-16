# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.finance_1_0 import models as dingtalkfinance__1__0_models
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

    def notify_pay_code_pay_result(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodePayResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyPayCodePayResultHeaders()
        return self.notify_pay_code_pay_result_with_options(request, headers, runtime)

    async def notify_pay_code_pay_result_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodePayResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyPayCodePayResultHeaders()
        return await self.notify_pay_code_pay_result_with_options_async(request, headers, runtime)

    def notify_pay_code_pay_result_with_options(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodePayResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyPayCodePayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.gmt_trade_create):
            body['gmtTradeCreate'] = request.gmt_trade_create
        if not UtilClient.is_unset(request.gmt_trade_finish):
            body['gmtTradeFinish'] = request.gmt_trade_finish
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
        if not UtilClient.is_unset(request.trade_status):
            body['tradeStatus'] = request.trade_status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.promotion_amount):
            body['promotionAmount'] = request.promotion_amount
        if not UtilClient.is_unset(request.charge_amount):
            body['chargeAmount'] = request.charge_amount
        if not UtilClient.is_unset(request.pay_channel_detail_list):
            body['payChannelDetailList'] = request.pay_channel_detail_list
        if not UtilClient.is_unset(request.trade_error_code):
            body['tradeErrorCode'] = request.trade_error_code
        if not UtilClient.is_unset(request.trade_error_msg):
            body['tradeErrorMsg'] = request.trade_error_msg
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.merchant_name):
            body['merchantName'] = request.merchant_name
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
            dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse(),
            self.do_roarequest('NotifyPayCodePayResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/payResults/notify', 'json', req, runtime)
        )

    async def notify_pay_code_pay_result_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodePayResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyPayCodePayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.gmt_trade_create):
            body['gmtTradeCreate'] = request.gmt_trade_create
        if not UtilClient.is_unset(request.gmt_trade_finish):
            body['gmtTradeFinish'] = request.gmt_trade_finish
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
        if not UtilClient.is_unset(request.trade_status):
            body['tradeStatus'] = request.trade_status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.promotion_amount):
            body['promotionAmount'] = request.promotion_amount
        if not UtilClient.is_unset(request.charge_amount):
            body['chargeAmount'] = request.charge_amount
        if not UtilClient.is_unset(request.pay_channel_detail_list):
            body['payChannelDetailList'] = request.pay_channel_detail_list
        if not UtilClient.is_unset(request.trade_error_code):
            body['tradeErrorCode'] = request.trade_error_code
        if not UtilClient.is_unset(request.trade_error_msg):
            body['tradeErrorMsg'] = request.trade_error_msg
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.merchant_name):
            body['merchantName'] = request.merchant_name
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
            dingtalkfinance__1__0_models.NotifyPayCodePayResultResponse(),
            await self.do_roarequest_async('NotifyPayCodePayResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/payResults/notify', 'json', req, runtime)
        )

    def upate_user_code_instance(
        self,
        request: dingtalkfinance__1__0_models.UpateUserCodeInstanceRequest,
    ) -> dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.UpateUserCodeInstanceHeaders()
        return self.upate_user_code_instance_with_options(request, headers, runtime)

    async def upate_user_code_instance_async(
        self,
        request: dingtalkfinance__1__0_models.UpateUserCodeInstanceRequest,
    ) -> dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.UpateUserCodeInstanceHeaders()
        return await self.upate_user_code_instance_with_options_async(request, headers, runtime)

    def upate_user_code_instance_with_options(
        self,
        request: dingtalkfinance__1__0_models.UpateUserCodeInstanceRequest,
        headers: dingtalkfinance__1__0_models.UpateUserCodeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code_id):
            body['codeId'] = request.code_id
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.code_value):
            body['codeValue'] = request.code_value
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.gmt_expired):
            body['gmtExpired'] = request.gmt_expired
        if not UtilClient.is_unset(request.available_times):
            body['availableTimes'] = request.available_times
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse(),
            self.do_roarequest('UpateUserCodeInstance', 'finance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/finance/payCodes/userInstances', 'json', req, runtime)
        )

    async def upate_user_code_instance_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.UpateUserCodeInstanceRequest,
        headers: dingtalkfinance__1__0_models.UpateUserCodeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code_id):
            body['codeId'] = request.code_id
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.code_value):
            body['codeValue'] = request.code_value
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.gmt_expired):
            body['gmtExpired'] = request.gmt_expired
        if not UtilClient.is_unset(request.available_times):
            body['availableTimes'] = request.available_times
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.UpateUserCodeInstanceResponse(),
            await self.do_roarequest_async('UpateUserCodeInstance', 'finance_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/finance/payCodes/userInstances', 'json', req, runtime)
        )

    def apply_batch_pay(
        self,
        request: dingtalkfinance__1__0_models.ApplyBatchPayRequest,
    ) -> dingtalkfinance__1__0_models.ApplyBatchPayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.ApplyBatchPayHeaders()
        return self.apply_batch_pay_with_options(request, headers, runtime)

    async def apply_batch_pay_async(
        self,
        request: dingtalkfinance__1__0_models.ApplyBatchPayRequest,
    ) -> dingtalkfinance__1__0_models.ApplyBatchPayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.ApplyBatchPayHeaders()
        return await self.apply_batch_pay_with_options_async(request, headers, runtime)

    def apply_batch_pay_with_options(
        self,
        request: dingtalkfinance__1__0_models.ApplyBatchPayRequest,
        headers: dingtalkfinance__1__0_models.ApplyBatchPayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.ApplyBatchPayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.staff_id):
            body['staffId'] = request.staff_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.trans_amount):
            body['transAmount'] = request.trans_amount
        if not UtilClient.is_unset(request.return_url):
            body['returnUrl'] = request.return_url
        if not UtilClient.is_unset(request.pass_back_params):
            body['passBackParams'] = request.pass_back_params
        if not UtilClient.is_unset(request.pay_terminal):
            body['payTerminal'] = request.pay_terminal
        if not UtilClient.is_unset(request.trans_expire_time):
            body['transExpireTime'] = request.trans_expire_time
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
            dingtalkfinance__1__0_models.ApplyBatchPayResponse(),
            self.do_roarequest('ApplyBatchPay', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders/pay', 'json', req, runtime)
        )

    async def apply_batch_pay_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.ApplyBatchPayRequest,
        headers: dingtalkfinance__1__0_models.ApplyBatchPayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.ApplyBatchPayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.staff_id):
            body['staffId'] = request.staff_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.trans_amount):
            body['transAmount'] = request.trans_amount
        if not UtilClient.is_unset(request.return_url):
            body['returnUrl'] = request.return_url
        if not UtilClient.is_unset(request.pass_back_params):
            body['passBackParams'] = request.pass_back_params
        if not UtilClient.is_unset(request.pay_terminal):
            body['payTerminal'] = request.pay_terminal
        if not UtilClient.is_unset(request.trans_expire_time):
            body['transExpireTime'] = request.trans_expire_time
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
            dingtalkfinance__1__0_models.ApplyBatchPayResponse(),
            await self.do_roarequest_async('ApplyBatchPay', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders/pay', 'json', req, runtime)
        )

    def query_user_alipay_account(self) -> dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryUserAlipayAccountHeaders()
        return self.query_user_alipay_account_with_options(headers, runtime)

    async def query_user_alipay_account_async(self) -> dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryUserAlipayAccountHeaders()
        return await self.query_user_alipay_account_with_options_async(headers, runtime)

    def query_user_alipay_account_with_options(
        self,
        headers: dingtalkfinance__1__0_models.QueryUserAlipayAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse(),
            self.do_roarequest('QueryUserAlipayAccount', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/userAlipayAccounts', 'json', req, runtime)
        )

    async def query_user_alipay_account_with_options_async(
        self,
        headers: dingtalkfinance__1__0_models.QueryUserAlipayAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkfinance__1__0_models.QueryUserAlipayAccountResponse(),
            await self.do_roarequest_async('QueryUserAlipayAccount', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/userAlipayAccounts', 'json', req, runtime)
        )

    def decode_pay_code(
        self,
        request: dingtalkfinance__1__0_models.DecodePayCodeRequest,
    ) -> dingtalkfinance__1__0_models.DecodePayCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.DecodePayCodeHeaders()
        return self.decode_pay_code_with_options(request, headers, runtime)

    async def decode_pay_code_async(
        self,
        request: dingtalkfinance__1__0_models.DecodePayCodeRequest,
    ) -> dingtalkfinance__1__0_models.DecodePayCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.DecodePayCodeHeaders()
        return await self.decode_pay_code_with_options_async(request, headers, runtime)

    def decode_pay_code_with_options(
        self,
        request: dingtalkfinance__1__0_models.DecodePayCodeRequest,
        headers: dingtalkfinance__1__0_models.DecodePayCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.DecodePayCodeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
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
            dingtalkfinance__1__0_models.DecodePayCodeResponse(),
            self.do_roarequest('DecodePayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/decode', 'json', req, runtime)
        )

    async def decode_pay_code_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.DecodePayCodeRequest,
        headers: dingtalkfinance__1__0_models.DecodePayCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.DecodePayCodeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
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
            dingtalkfinance__1__0_models.DecodePayCodeResponse(),
            await self.do_roarequest_async('DecodePayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/decode', 'json', req, runtime)
        )

    def create_batch_trade_order(
        self,
        request: dingtalkfinance__1__0_models.CreateBatchTradeOrderRequest,
    ) -> dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.CreateBatchTradeOrderHeaders()
        return self.create_batch_trade_order_with_options(request, headers, runtime)

    async def create_batch_trade_order_async(
        self,
        request: dingtalkfinance__1__0_models.CreateBatchTradeOrderRequest,
    ) -> dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.CreateBatchTradeOrderHeaders()
        return await self.create_batch_trade_order_with_options_async(request, headers, runtime)

    def create_batch_trade_order_with_options(
        self,
        request: dingtalkfinance__1__0_models.CreateBatchTradeOrderRequest,
        headers: dingtalkfinance__1__0_models.CreateBatchTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.staff_id):
            body['staffId'] = request.staff_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.account_no):
            body['accountNo'] = request.account_no
        if not UtilClient.is_unset(request.trade_title):
            body['tradeTitle'] = request.trade_title
        if not UtilClient.is_unset(request.out_batch_no):
            body['outBatchNo'] = request.out_batch_no
        if not UtilClient.is_unset(request.batch_remark):
            body['batchRemark'] = request.batch_remark
        if not UtilClient.is_unset(request.total_count):
            body['totalCount'] = request.total_count
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.batch_trade_details):
            body['batchTradeDetails'] = request.batch_trade_details
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
            dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse(),
            self.do_roarequest('CreateBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders', 'json', req, runtime)
        )

    async def create_batch_trade_order_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.CreateBatchTradeOrderRequest,
        headers: dingtalkfinance__1__0_models.CreateBatchTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.staff_id):
            body['staffId'] = request.staff_id
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.account_no):
            body['accountNo'] = request.account_no
        if not UtilClient.is_unset(request.trade_title):
            body['tradeTitle'] = request.trade_title
        if not UtilClient.is_unset(request.out_batch_no):
            body['outBatchNo'] = request.out_batch_no
        if not UtilClient.is_unset(request.batch_remark):
            body['batchRemark'] = request.batch_remark
        if not UtilClient.is_unset(request.total_count):
            body['totalCount'] = request.total_count
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.batch_trade_details):
            body['batchTradeDetails'] = request.batch_trade_details
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
            dingtalkfinance__1__0_models.CreateBatchTradeOrderResponse(),
            await self.do_roarequest_async('CreateBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders', 'json', req, runtime)
        )

    def notify_pay_code_refund_result(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyPayCodeRefundResultHeaders()
        return self.notify_pay_code_refund_result_with_options(request, headers, runtime)

    async def notify_pay_code_refund_result_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyPayCodeRefundResultHeaders()
        return await self.notify_pay_code_refund_result_with_options_async(request, headers, runtime)

    def notify_pay_code_refund_result_with_options(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
        if not UtilClient.is_unset(request.refund_order_no):
            body['refundOrderNo'] = request.refund_order_no
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.refund_promotion_amount):
            body['refundPromotionAmount'] = request.refund_promotion_amount
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.pay_channel_detail_list):
            body['payChannelDetailList'] = request.pay_channel_detail_list
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
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
            dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse(),
            self.do_roarequest('NotifyPayCodeRefundResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/refundResults/notify', 'json', req, runtime)
        )

    async def notify_pay_code_refund_result_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyPayCodeRefundResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
        if not UtilClient.is_unset(request.refund_order_no):
            body['refundOrderNo'] = request.refund_order_no
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.refund_promotion_amount):
            body['refundPromotionAmount'] = request.refund_promotion_amount
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.pay_channel_detail_list):
            body['payChannelDetailList'] = request.pay_channel_detail_list
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
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
            dingtalkfinance__1__0_models.NotifyPayCodeRefundResultResponse(),
            await self.do_roarequest_async('NotifyPayCodeRefundResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/refundResults/notify', 'json', req, runtime)
        )

    def query_batch_trade_detail_list(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeDetailListRequest,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryBatchTradeDetailListHeaders()
        return self.query_batch_trade_detail_list_with_options(request, headers, runtime)

    async def query_batch_trade_detail_list_async(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeDetailListRequest,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryBatchTradeDetailListHeaders()
        return await self.query_batch_trade_detail_list_with_options_async(request, headers, runtime)

    def query_batch_trade_detail_list_with_options(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeDetailListRequest,
        headers: dingtalkfinance__1__0_models.QueryBatchTradeDetailListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.out_batch_no):
            query['outBatchNo'] = request.out_batch_no
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse(),
            self.do_roarequest('QueryBatchTradeDetailList', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/batchTrades/details', 'json', req, runtime)
        )

    async def query_batch_trade_detail_list_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeDetailListRequest,
        headers: dingtalkfinance__1__0_models.QueryBatchTradeDetailListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.out_batch_no):
            query['outBatchNo'] = request.out_batch_no
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkfinance__1__0_models.QueryBatchTradeDetailListResponse(),
            await self.do_roarequest_async('QueryBatchTradeDetailList', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/batchTrades/details', 'json', req, runtime)
        )

    def create_user_code_instance(
        self,
        request: dingtalkfinance__1__0_models.CreateUserCodeInstanceRequest,
    ) -> dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.CreateUserCodeInstanceHeaders()
        return self.create_user_code_instance_with_options(request, headers, runtime)

    async def create_user_code_instance_async(
        self,
        request: dingtalkfinance__1__0_models.CreateUserCodeInstanceRequest,
    ) -> dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.CreateUserCodeInstanceHeaders()
        return await self.create_user_code_instance_with_options_async(request, headers, runtime)

    def create_user_code_instance_with_options(
        self,
        request: dingtalkfinance__1__0_models.CreateUserCodeInstanceRequest,
        headers: dingtalkfinance__1__0_models.CreateUserCodeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.code_value):
            body['codeValue'] = request.code_value
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.gmt_expired):
            body['gmtExpired'] = request.gmt_expired
        if not UtilClient.is_unset(request.available_times):
            body['availableTimes'] = request.available_times
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse(),
            self.do_roarequest('CreateUserCodeInstance', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/userInstances', 'json', req, runtime)
        )

    async def create_user_code_instance_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.CreateUserCodeInstanceRequest,
        headers: dingtalkfinance__1__0_models.CreateUserCodeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_id):
            body['requestId'] = request.request_id
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.code_value):
            body['codeValue'] = request.code_value
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.gmt_expired):
            body['gmtExpired'] = request.gmt_expired
        if not UtilClient.is_unset(request.available_times):
            body['availableTimes'] = request.available_times
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.CreateUserCodeInstanceResponse(),
            await self.do_roarequest_async('CreateUserCodeInstance', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/userInstances', 'json', req, runtime)
        )

    def query_batch_trade_order(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeOrderRequest,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryBatchTradeOrderHeaders()
        return self.query_batch_trade_order_with_options(request, headers, runtime)

    async def query_batch_trade_order_async(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeOrderRequest,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryBatchTradeOrderHeaders()
        return await self.query_batch_trade_order_with_options_async(request, headers, runtime)

    def query_batch_trade_order_with_options(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeOrderRequest,
        headers: dingtalkfinance__1__0_models.QueryBatchTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_batch_nos):
            body['outBatchNos'] = request.out_batch_nos
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
            dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse(),
            self.do_roarequest('QueryBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders/query', 'json', req, runtime)
        )

    async def query_batch_trade_order_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.QueryBatchTradeOrderRequest,
        headers: dingtalkfinance__1__0_models.QueryBatchTradeOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_batch_nos):
            body['outBatchNos'] = request.out_batch_nos
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
            dingtalkfinance__1__0_models.QueryBatchTradeOrderResponse(),
            await self.do_roarequest_async('QueryBatchTradeOrder', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/batchTrades/orders/query', 'json', req, runtime)
        )

    def save_corp_pay_code(
        self,
        request: dingtalkfinance__1__0_models.SaveCorpPayCodeRequest,
    ) -> dingtalkfinance__1__0_models.SaveCorpPayCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.SaveCorpPayCodeHeaders()
        return self.save_corp_pay_code_with_options(request, headers, runtime)

    async def save_corp_pay_code_async(
        self,
        request: dingtalkfinance__1__0_models.SaveCorpPayCodeRequest,
    ) -> dingtalkfinance__1__0_models.SaveCorpPayCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.SaveCorpPayCodeHeaders()
        return await self.save_corp_pay_code_with_options_async(request, headers, runtime)

    def save_corp_pay_code_with_options(
        self,
        request: dingtalkfinance__1__0_models.SaveCorpPayCodeRequest,
        headers: dingtalkfinance__1__0_models.SaveCorpPayCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.SaveCorpPayCodeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.SaveCorpPayCodeResponse(),
            self.do_roarequest('SaveCorpPayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/corpSettings', 'json', req, runtime)
        )

    async def save_corp_pay_code_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.SaveCorpPayCodeRequest,
        headers: dingtalkfinance__1__0_models.SaveCorpPayCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.SaveCorpPayCodeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code_identity):
            body['codeIdentity'] = request.code_identity
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.SaveCorpPayCodeResponse(),
            await self.do_roarequest_async('SaveCorpPayCode', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/corpSettings', 'json', req, runtime)
        )

    def notify_verify_result(
        self,
        request: dingtalkfinance__1__0_models.NotifyVerifyResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyVerifyResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyVerifyResultHeaders()
        return self.notify_verify_result_with_options(request, headers, runtime)

    async def notify_verify_result_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyVerifyResultRequest,
    ) -> dingtalkfinance__1__0_models.NotifyVerifyResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.NotifyVerifyResultHeaders()
        return await self.notify_verify_result_with_options_async(request, headers, runtime)

    def notify_verify_result_with_options(
        self,
        request: dingtalkfinance__1__0_models.NotifyVerifyResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyVerifyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyVerifyResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.verify_time):
            body['verifyTime'] = request.verify_time
        if not UtilClient.is_unset(request.verify_result):
            body['verifyResult'] = request.verify_result
        if not UtilClient.is_unset(request.verify_location):
            body['verifyLocation'] = request.verify_location
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.NotifyVerifyResultResponse(),
            self.do_roarequest('NotifyVerifyResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/verifyResults/notify', 'json', req, runtime)
        )

    async def notify_verify_result_with_options_async(
        self,
        request: dingtalkfinance__1__0_models.NotifyVerifyResultRequest,
        headers: dingtalkfinance__1__0_models.NotifyVerifyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.NotifyVerifyResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.pay_code):
            body['payCode'] = request.pay_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.user_corp_relation_type):
            body['userCorpRelationType'] = request.user_corp_relation_type
        if not UtilClient.is_unset(request.user_identity):
            body['userIdentity'] = request.user_identity
        if not UtilClient.is_unset(request.verify_time):
            body['verifyTime'] = request.verify_time
        if not UtilClient.is_unset(request.verify_result):
            body['verifyResult'] = request.verify_result
        if not UtilClient.is_unset(request.verify_location):
            body['verifyLocation'] = request.verify_location
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
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
            dingtalkfinance__1__0_models.NotifyVerifyResultResponse(),
            await self.do_roarequest_async('NotifyVerifyResult', 'finance_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/finance/payCodes/verifyResults/notify', 'json', req, runtime)
        )

    def query_pay_account_list(self) -> dingtalkfinance__1__0_models.QueryPayAccountListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryPayAccountListHeaders()
        return self.query_pay_account_list_with_options(headers, runtime)

    async def query_pay_account_list_async(self) -> dingtalkfinance__1__0_models.QueryPayAccountListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkfinance__1__0_models.QueryPayAccountListHeaders()
        return await self.query_pay_account_list_with_options_async(headers, runtime)

    def query_pay_account_list_with_options(
        self,
        headers: dingtalkfinance__1__0_models.QueryPayAccountListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryPayAccountListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkfinance__1__0_models.QueryPayAccountListResponse(),
            self.do_roarequest('QueryPayAccountList', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/payAccounts', 'json', req, runtime)
        )

    async def query_pay_account_list_with_options_async(
        self,
        headers: dingtalkfinance__1__0_models.QueryPayAccountListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkfinance__1__0_models.QueryPayAccountListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkfinance__1__0_models.QueryPayAccountListResponse(),
            await self.do_roarequest_async('QueryPayAccountList', 'finance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/finance/payAccounts', 'json', req, runtime)
        )
