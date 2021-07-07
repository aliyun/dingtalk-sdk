# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class NotifyPayCodePayResultHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        fund_tool_name: str = None,
        amount: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
        ext_info: str = None,
    ):
        # 资金渠道名称
        self.fund_tool_name = fund_tool_name
        # 1.00
        self.amount = amount
        # 开始时间
        self.gmt_create = gmt_create
        # 结束时间
        self.gmt_finish = gmt_finish
        # 是否是优惠工具
        self.promotion_fund_tool = promotion_fund_tool
        # 扩展信息
        self.ext_info = ext_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.amount is not None:
            result['amount'] = self.amount
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        return self


class NotifyPayCodePayResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        pay_channel_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        pay_channel_type: str = None,
        amount: str = None,
        pay_channel_order_no: str = None,
        promotion_amount: str = None,
        fund_tool_detail_list: List[NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList] = None,
    ):
        # 支付渠道名称
        self.pay_channel_name = pay_channel_name
        # 开始时间
        self.gmt_create = gmt_create
        # 结束时间
        self.gmt_finish = gmt_finish
        # 支付渠道类型
        self.pay_channel_type = pay_channel_type
        # 支付金额
        self.amount = amount
        # 支付渠道单号
        self.pay_channel_order_no = pay_channel_order_no
        # 优惠金额
        self.promotion_amount = promotion_amount
        # 资金工具明细
        self.fund_tool_detail_list = fund_tool_detail_list

    def validate(self):
        if self.fund_tool_detail_list:
            for k in self.fund_tool_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        return self


class NotifyPayCodePayResultRequest(TeaModel):
    def __init__(
        self,
        pay_code: str = None,
        corp_id: str = None,
        user_id: str = None,
        gmt_trade_create: str = None,
        gmt_trade_finish: str = None,
        trade_no: str = None,
        trade_status: str = None,
        title: str = None,
        remark: str = None,
        amount: str = None,
        promotion_amount: str = None,
        charge_amount: str = None,
        pay_channel_detail_list: List[NotifyPayCodePayResultRequestPayChannelDetailList] = None,
        trade_error_code: str = None,
        trade_error_msg: str = None,
        ext_info: str = None,
        ding_isv_org_id: int = None,
        merchant_name: str = None,
    ):
        # 付款码值
        self.pay_code = pay_code
        # 企业id
        self.corp_id = corp_id
        # 用户id
        self.user_id = user_id
        # 交易开始时间
        self.gmt_trade_create = gmt_trade_create
        # 交易结束时间
        self.gmt_trade_finish = gmt_trade_finish
        # 交易号
        self.trade_no = trade_no
        # 交易状态
        self.trade_status = trade_status
        # 订单标题
        self.title = title
        # 备注
        self.remark = remark
        # 订单金额
        self.amount = amount
        # 订单优惠金额
        self.promotion_amount = promotion_amount
        # 收费金额
        self.charge_amount = charge_amount
        # 支付渠道明细信息
        self.pay_channel_detail_list = pay_channel_detail_list
        # 支付失败错误码
        self.trade_error_code = trade_error_code
        # 支付失败信息
        self.trade_error_msg = trade_error_msg
        # 扩展信息
        self.ext_info = ext_info
        # isvOrgId
        self.ding_isv_org_id = ding_isv_org_id
        # merchantName
        self.merchant_name = merchant_name

    def validate(self):
        if self.pay_channel_detail_list:
            for k in self.pay_channel_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.gmt_trade_create is not None:
            result['gmtTradeCreate'] = self.gmt_trade_create
        if self.gmt_trade_finish is not None:
            result['gmtTradeFinish'] = self.gmt_trade_finish
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.trade_status is not None:
            result['tradeStatus'] = self.trade_status
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.amount is not None:
            result['amount'] = self.amount
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        if self.charge_amount is not None:
            result['chargeAmount'] = self.charge_amount
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.trade_error_code is not None:
            result['tradeErrorCode'] = self.trade_error_code
        if self.trade_error_msg is not None:
            result['tradeErrorMsg'] = self.trade_error_msg
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.merchant_name is not None:
            result['merchantName'] = self.merchant_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('gmtTradeCreate') is not None:
            self.gmt_trade_create = m.get('gmtTradeCreate')
        if m.get('gmtTradeFinish') is not None:
            self.gmt_trade_finish = m.get('gmtTradeFinish')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('tradeStatus') is not None:
            self.trade_status = m.get('tradeStatus')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        if m.get('chargeAmount') is not None:
            self.charge_amount = m.get('chargeAmount')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyPayCodePayResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('tradeErrorCode') is not None:
            self.trade_error_code = m.get('tradeErrorCode')
        if m.get('tradeErrorMsg') is not None:
            self.trade_error_msg = m.get('tradeErrorMsg')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('merchantName') is not None:
            self.merchant_name = m.get('merchantName')
        return self


class NotifyPayCodePayResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 处理结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class NotifyPayCodePayResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: NotifyPayCodePayResultResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = NotifyPayCodePayResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyPayCodeRefundResultHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        fund_tool_name: str = None,
        amount: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
        ext_info: str = None,
    ):
        # 资金工具名称
        self.fund_tool_name = fund_tool_name
        # 金额
        self.amount = amount
        # 创建时间
        self.gmt_create = gmt_create
        # 完成时间
        self.gmt_finish = gmt_finish
        # 是否是优惠工具
        self.promotion_fund_tool = promotion_fund_tool
        # 扩展信息
        self.ext_info = ext_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.amount is not None:
            result['amount'] = self.amount
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        return self


class NotifyPayCodeRefundResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        pay_channel_name: str = None,
        pay_channel_type: str = None,
        amount: str = None,
        pay_channel_order_no: str = None,
        pay_channel_refund_order_no: str = None,
        promotion_amount: str = None,
        fund_tool_detail_list: List[NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList] = None,
    ):
        # 支付渠道名称
        self.pay_channel_name = pay_channel_name
        # 支付渠道类型
        self.pay_channel_type = pay_channel_type
        # 金额
        self.amount = amount
        # 支付渠道号
        self.pay_channel_order_no = pay_channel_order_no
        # 支付渠道退款号
        self.pay_channel_refund_order_no = pay_channel_refund_order_no
        # 优惠金额
        self.promotion_amount = promotion_amount
        # 支付资金列表
        self.fund_tool_detail_list = fund_tool_detail_list

    def validate(self):
        if self.fund_tool_detail_list:
            for k in self.fund_tool_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_refund_order_no is not None:
            result['payChannelRefundOrderNo'] = self.pay_channel_refund_order_no
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelRefundOrderNo') is not None:
            self.pay_channel_refund_order_no = m.get('payChannelRefundOrderNo')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        return self


class NotifyPayCodeRefundResultRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        trade_no: str = None,
        refund_order_no: str = None,
        remark: str = None,
        refund_amount: str = None,
        refund_promotion_amount: str = None,
        gmt_refund: str = None,
        pay_channel_detail_list: List[NotifyPayCodeRefundResultRequestPayChannelDetailList] = None,
        ding_isv_org_id: int = None,
        pay_code: str = None,
    ):
        # 企业id
        self.corp_id = corp_id
        # 用户id
        self.user_id = user_id
        # 交易订单号
        self.trade_no = trade_no
        # 本次退款订单号
        self.refund_order_no = refund_order_no
        # 备注
        self.remark = remark
        # 退款金额
        self.refund_amount = refund_amount
        # 退款的优惠金额
        self.refund_promotion_amount = refund_promotion_amount
        # 退款时间
        self.gmt_refund = gmt_refund
        # 支付渠道信息
        self.pay_channel_detail_list = pay_channel_detail_list
        # isvOrgId
        self.ding_isv_org_id = ding_isv_org_id
        # 支付时使用的付款码
        self.pay_code = pay_code

    def validate(self):
        if self.pay_channel_detail_list:
            for k in self.pay_channel_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.refund_order_no is not None:
            result['refundOrderNo'] = self.refund_order_no
        if self.remark is not None:
            result['remark'] = self.remark
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.refund_promotion_amount is not None:
            result['refundPromotionAmount'] = self.refund_promotion_amount
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('refundOrderNo') is not None:
            self.refund_order_no = m.get('refundOrderNo')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('refundPromotionAmount') is not None:
            self.refund_promotion_amount = m.get('refundPromotionAmount')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyPayCodeRefundResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        return self


class NotifyPayCodeRefundResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 处理结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class NotifyPayCodeRefundResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: NotifyPayCodeRefundResultResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = NotifyPayCodeRefundResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DecodePayCodeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DecodePayCodeRequest(TeaModel):
    def __init__(
        self,
        pay_code: str = None,
        request_id: str = None,
    ):
        # payCode
        self.pay_code = pay_code
        # requestId
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DecodePayCodeResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_in_corp: bool = None,
        code_type: str = None,
        alipay_code: str = None,
    ):
        # 企业id
        self.corp_id = corp_id
        # 员工id
        self.user_id = user_id
        # 用户是否还在组织内
        self.user_in_corp = user_in_corp
        # 码类型
        self.code_type = code_type
        # 支付宝付款码
        self.alipay_code = alipay_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_in_corp is not None:
            result['userInCorp'] = self.user_in_corp
        if self.code_type is not None:
            result['codeType'] = self.code_type
        if self.alipay_code is not None:
            result['alipayCode'] = self.alipay_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userInCorp') is not None:
            self.user_in_corp = m.get('userInCorp')
        if m.get('codeType') is not None:
            self.code_type = m.get('codeType')
        if m.get('alipayCode') is not None:
            self.alipay_code = m.get('alipayCode')
        return self


class DecodePayCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DecodePayCodeResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = DecodePayCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveCorpPayCodeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SaveCorpPayCodeRequest(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        status: str = None,
        ext_info: Dict[str, Any] = None,
        ding_org_id: int = None,
        ding_client_id: str = None,
        ding_isv_org_id: int = None,
    ):
        # 码标识，由钉钉颁发
        self.code_identity = code_identity
        # 开通的企业ID
        self.corp_id = corp_id
        # 状态，OPEN或CLOSED
        self.status = status
        # 扩展参数
        self.ext_info = ext_info
        # 企业orgId
        self.ding_org_id = ding_org_id
        self.ding_client_id = ding_client_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.status is not None:
            result['status'] = self.status
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class SaveCorpPayCodeResponseBody(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        status: str = None,
        ext_info: Dict[str, Any] = None,
    ):
        # 码标识
        self.code_identity = code_identity
        # 开通的企业ID
        self.corp_id = corp_id
        # 状态
        self.status = status
        # 扩展参数
        self.ext_info = ext_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.status is not None:
            result['status'] = self.status
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        return self


class SaveCorpPayCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveCorpPayCodeResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = SaveCorpPayCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


