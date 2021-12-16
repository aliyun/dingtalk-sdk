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


class UpateUserCodeInstanceHeaders(TeaModel):
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


class UpateUserCodeInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_start: str = None,
        gmt_end: str = None,
    ):
        # 开始时间
        self.gmt_start = gmt_start
        # 结束时间
        self.gmt_end = gmt_end

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        return self


class UpateUserCodeInstanceRequest(TeaModel):
    def __init__(
        self,
        code_id: str = None,
        code_identity: str = None,
        code_value: str = None,
        status: str = None,
        corp_id: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
        gmt_expired: str = None,
        available_times: List[UpateUserCodeInstanceRequestAvailableTimes] = None,
        ext_info: Dict[str, Any] = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
    ):
        # 用户码ID
        self.code_id = code_id
        # 码标识
        self.code_identity = code_identity
        # 码值
        self.code_value = code_value
        # 状态
        self.status = status
        # 企业ID
        self.corp_id = corp_id
        # 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
        self.user_corp_relation_type = user_corp_relation_type
        # 用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号
        self.user_identity = user_identity
        # 临时码，传入过期时间
        self.gmt_expired = gmt_expired
        # 有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间
        self.available_times = available_times
        # 扩展参数
        self.ext_info = ext_info
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        if self.available_times:
            for k in self.available_times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.status is not None:
            result['status'] = self.status
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = UpateUserCodeInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class UpateUserCodeInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_id: str = None,
    ):
        # 码ID
        self.code_id = code_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_id is not None:
            result['codeId'] = self.code_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        return self


class UpateUserCodeInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpateUserCodeInstanceResponseBody = None,
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
            temp_model = UpateUserCodeInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ApplyBatchPayHeaders(TeaModel):
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


class ApplyBatchPayRequest(TeaModel):
    def __init__(
        self,
        staff_id: str = None,
        account_id: str = None,
        order_no: str = None,
        trans_amount: str = None,
        return_url: str = None,
        pass_back_params: Dict[str, Any] = None,
        pay_terminal: str = None,
        trans_expire_time: str = None,
    ):
        # 支付发起人staffId
        self.staff_id = staff_id
        # 支付账号唯一id
        self.account_id = account_id
        # 钉钉订单号(和商户批次号一一对应)
        self.order_no = order_no
        # 订单总金额（必填）, 单位为：元
        self.trans_amount = trans_amount
        # 回调url
        self.return_url = return_url
        # 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数
        self.pass_back_params = pass_back_params
        # 支付终端
        self.pay_terminal = pay_terminal
        # 转账过期时间
        self.trans_expire_time = trans_expire_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.trans_amount is not None:
            result['transAmount'] = self.trans_amount
        if self.return_url is not None:
            result['returnUrl'] = self.return_url
        if self.pass_back_params is not None:
            result['passBackParams'] = self.pass_back_params
        if self.pay_terminal is not None:
            result['payTerminal'] = self.pay_terminal
        if self.trans_expire_time is not None:
            result['transExpireTime'] = self.trans_expire_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('transAmount') is not None:
            self.trans_amount = m.get('transAmount')
        if m.get('returnUrl') is not None:
            self.return_url = m.get('returnUrl')
        if m.get('passBackParams') is not None:
            self.pass_back_params = m.get('passBackParams')
        if m.get('payTerminal') is not None:
            self.pay_terminal = m.get('payTerminal')
        if m.get('transExpireTime') is not None:
            self.trans_expire_time = m.get('transExpireTime')
        return self


class ApplyBatchPayResponseBody(TeaModel):
    def __init__(
        self,
        pay_data: str = None,
        order_no: str = None,
    ):
        # 支付确认页数据
        self.pay_data = pay_data
        # 钉钉支付的批次号
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_data is not None:
            result['payData'] = self.pay_data
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payData') is not None:
            self.pay_data = m.get('payData')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class ApplyBatchPayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ApplyBatchPayResponseBody = None,
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
            temp_model = ApplyBatchPayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserAlipayAccountHeaders(TeaModel):
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


class QueryUserAlipayAccountResponseBody(TeaModel):
    def __init__(
        self,
        alipay_uid: str = None,
    ):
        # 支付宝uid
        self.alipay_uid = alipay_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_uid is not None:
            result['alipayUid'] = self.alipay_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayUid') is not None:
            self.alipay_uid = m.get('alipayUid')
        return self


class QueryUserAlipayAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserAlipayAccountResponseBody = None,
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
            temp_model = QueryUserAlipayAccountResponseBody()
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
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
    ):
        # payCode
        self.pay_code = pay_code
        # requestId
        self.request_id = request_id
        # ISV组织ID
        self.ding_isv_org_id = ding_isv_org_id
        # 组织ID
        self.ding_org_id = ding_org_id

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
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        return self


class DecodePayCodeResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_in_corp: bool = None,
        code_type: str = None,
        alipay_code: str = None,
        user_corp_relation_type: str = None,
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
        # 用户和企业关系
        self.user_corp_relation_type = user_corp_relation_type

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
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
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
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
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


class CreateBatchTradeOrderHeaders(TeaModel):
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


class CreateBatchTradeOrderRequestBatchTradeDetails(TeaModel):
    def __init__(
        self,
        serial_no: int = None,
        amount: str = None,
        payee_account_name: str = None,
        payee_account_no: str = None,
        payee_account_type: str = None,
        memo: str = None,
    ):
        # 序号（必填）
        self.serial_no = serial_no
        # 金额（必填，单位：元）
        self.amount = amount
        # 收款方户名（必填）
        self.payee_account_name = payee_account_name
        # 收款方账号（必填）
        self.payee_account_no = payee_account_no
        # 收款方账号类型（必填）
        self.payee_account_type = payee_account_type
        # 备注（选填）
        self.memo = memo

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.amount is not None:
            result['amount'] = self.amount
        if self.payee_account_name is not None:
            result['payeeAccountName'] = self.payee_account_name
        if self.payee_account_no is not None:
            result['payeeAccountNo'] = self.payee_account_no
        if self.payee_account_type is not None:
            result['payeeAccountType'] = self.payee_account_type
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('payeeAccountName') is not None:
            self.payee_account_name = m.get('payeeAccountName')
        if m.get('payeeAccountNo') is not None:
            self.payee_account_no = m.get('payeeAccountNo')
        if m.get('payeeAccountType') is not None:
            self.payee_account_type = m.get('payeeAccountType')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class CreateBatchTradeOrderRequest(TeaModel):
    def __init__(
        self,
        staff_id: str = None,
        account_id: str = None,
        account_no: str = None,
        trade_title: str = None,
        out_batch_no: str = None,
        batch_remark: str = None,
        total_count: int = None,
        total_amount: str = None,
        batch_trade_details: List[CreateBatchTradeOrderRequestBatchTradeDetails] = None,
    ):
        # 员工staffId
        self.staff_id = staff_id
        # 付款账号唯一id
        self.account_id = account_id
        # 付款账号(注意：用户上送的是脱敏数据)
        self.account_no = account_no
        # 交易抬头
        self.trade_title = trade_title
        # 外部商户批次号
        self.out_batch_no = out_batch_no
        # 批次备注
        self.batch_remark = batch_remark
        # 总笔数（必填）
        self.total_count = total_count
        # 总金额（必填，单位：元）
        self.total_amount = total_amount
        # 交易明细列表
        self.batch_trade_details = batch_trade_details

    def validate(self):
        if self.batch_trade_details:
            for k in self.batch_trade_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_no is not None:
            result['accountNo'] = self.account_no
        if self.trade_title is not None:
            result['tradeTitle'] = self.trade_title
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.batch_remark is not None:
            result['batchRemark'] = self.batch_remark
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        result['batchTradeDetails'] = []
        if self.batch_trade_details is not None:
            for k in self.batch_trade_details:
                result['batchTradeDetails'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountNo') is not None:
            self.account_no = m.get('accountNo')
        if m.get('tradeTitle') is not None:
            self.trade_title = m.get('tradeTitle')
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('batchRemark') is not None:
            self.batch_remark = m.get('batchRemark')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        self.batch_trade_details = []
        if m.get('batchTradeDetails') is not None:
            for k in m.get('batchTradeDetails'):
                temp_model = CreateBatchTradeOrderRequestBatchTradeDetails()
                self.batch_trade_details.append(temp_model.from_map(k))
        return self


class CreateBatchTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        order_no: str = None,
        out_batch_no: str = None,
        order_status: str = None,
    ):
        # 钉钉批次单号
        self.order_no = order_no
        # 商户批次号
        self.out_batch_no = out_batch_no
        # 批次订单状态
        self.order_status = order_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.order_status is not None:
            result['orderStatus'] = self.order_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('orderStatus') is not None:
            self.order_status = m.get('orderStatus')
        return self


class CreateBatchTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateBatchTradeOrderResponseBody = None,
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
            temp_model = CreateBatchTradeOrderResponseBody()
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


class QueryBatchTradeDetailListHeaders(TeaModel):
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


class QueryBatchTradeDetailListRequest(TeaModel):
    def __init__(
        self,
        out_batch_no: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 外部商户批次号
        self.out_batch_no = out_batch_no
        # 当前页数
        self.page_number = page_number
        # 每页记录数
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList(TeaModel):
    def __init__(
        self,
        serial_no: int = None,
        detail_no: str = None,
        payee_account_no: str = None,
        payee_account_type: str = None,
        status: str = None,
        payee_account_name: str = None,
        amount: str = None,
        memo: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
    ):
        # 序号
        self.serial_no = serial_no
        # 明细单号
        self.detail_no = detail_no
        # 收款人账号
        self.payee_account_no = payee_account_no
        # 收款账号类型
        self.payee_account_type = payee_account_type
        # 状态
        self.status = status
        # 收款方电子钱包持有者姓名
        self.payee_account_name = payee_account_name
        # 金额
        self.amount = amount
        # 备注
        self.memo = memo
        # 订单时间时间
        self.gmt_create = gmt_create
        # 支付完成时间
        self.gmt_finish = gmt_finish

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.detail_no is not None:
            result['detailNo'] = self.detail_no
        if self.payee_account_no is not None:
            result['payeeAccountNo'] = self.payee_account_no
        if self.payee_account_type is not None:
            result['payeeAccountType'] = self.payee_account_type
        if self.status is not None:
            result['status'] = self.status
        if self.payee_account_name is not None:
            result['payeeAccountName'] = self.payee_account_name
        if self.amount is not None:
            result['amount'] = self.amount
        if self.memo is not None:
            result['memo'] = self.memo
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('detailNo') is not None:
            self.detail_no = m.get('detailNo')
        if m.get('payeeAccountNo') is not None:
            self.payee_account_no = m.get('payeeAccountNo')
        if m.get('payeeAccountType') is not None:
            self.payee_account_type = m.get('payeeAccountType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('payeeAccountName') is not None:
            self.payee_account_name = m.get('payeeAccountName')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        return self


class QueryBatchTradeDetailListResponseBody(TeaModel):
    def __init__(
        self,
        total: int = None,
        page_size: int = None,
        total_page_number: int = None,
        page_number: int = None,
        batch_trade_detail_list: List[QueryBatchTradeDetailListResponseBodyBatchTradeDetailList] = None,
    ):
        # 总记录数
        self.total = total
        # 单页条数
        self.page_size = page_size
        # 总页数
        self.total_page_number = total_page_number
        # 当前页数
        self.page_number = page_number
        # 明细列表
        self.batch_trade_detail_list = batch_trade_detail_list

    def validate(self):
        if self.batch_trade_detail_list:
            for k in self.batch_trade_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total is not None:
            result['total'] = self.total
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_page_number is not None:
            result['totalPageNumber'] = self.total_page_number
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        result['batchTradeDetailList'] = []
        if self.batch_trade_detail_list is not None:
            for k in self.batch_trade_detail_list:
                result['batchTradeDetailList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('total') is not None:
            self.total = m.get('total')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalPageNumber') is not None:
            self.total_page_number = m.get('totalPageNumber')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        self.batch_trade_detail_list = []
        if m.get('batchTradeDetailList') is not None:
            for k in m.get('batchTradeDetailList'):
                temp_model = QueryBatchTradeDetailListResponseBodyBatchTradeDetailList()
                self.batch_trade_detail_list.append(temp_model.from_map(k))
        return self


class QueryBatchTradeDetailListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryBatchTradeDetailListResponseBody = None,
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
            temp_model = QueryBatchTradeDetailListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUserCodeInstanceHeaders(TeaModel):
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


class CreateUserCodeInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_start: str = None,
        gmt_end: str = None,
    ):
        # 开始时间
        self.gmt_start = gmt_start
        # 结束时间
        self.gmt_end = gmt_end

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        return self


class CreateUserCodeInstanceRequest(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        code_identity: str = None,
        code_value: str = None,
        status: str = None,
        corp_id: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
        gmt_expired: str = None,
        available_times: List[CreateUserCodeInstanceRequestAvailableTimes] = None,
        ext_info: Dict[str, Any] = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
    ):
        # 业务幂等ID
        self.request_id = request_id
        # 码标识，由钉钉颁发
        self.code_identity = code_identity
        # 码值
        self.code_value = code_value
        # 状态，传入关闭状态需要用户手动开启后才会渲染二维
        self.status = status
        # 企业ID
        self.corp_id = corp_id
        # 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
        self.user_corp_relation_type = user_corp_relation_type
        # 用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号
        self.user_identity = user_identity
        # 临时码，传入过期时间
        self.gmt_expired = gmt_expired
        # 有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间
        self.available_times = available_times
        # 扩展参数
        self.ext_info = ext_info
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        if self.available_times:
            for k in self.available_times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.status is not None:
            result['status'] = self.status
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = CreateUserCodeInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class CreateUserCodeInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_id: str = None,
    ):
        # 码ID
        self.code_id = code_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_id is not None:
            result['codeId'] = self.code_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        return self


class CreateUserCodeInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateUserCodeInstanceResponseBody = None,
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
            temp_model = CreateUserCodeInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBatchTradeOrderHeaders(TeaModel):
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


class QueryBatchTradeOrderRequest(TeaModel):
    def __init__(
        self,
        out_batch_nos: List[str] = None,
    ):
        # 外部商户批次号列表
        self.out_batch_nos = out_batch_nos

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_batch_nos is not None:
            result['outBatchNos'] = self.out_batch_nos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outBatchNos') is not None:
            self.out_batch_nos = m.get('outBatchNos')
        return self


class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs(TeaModel):
    def __init__(
        self,
        out_batch_no: str = None,
        alipay_trans_id: str = None,
        status: str = None,
        success_count: int = None,
        success_amount: str = None,
        fail_count: int = None,
        fail_amount: str = None,
        total_amount: str = None,
        gmt_finish: str = None,
        gmt_submit: str = None,
        fail_reason: str = None,
        payment_amount: str = None,
        payment_currency: str = None,
        payer_staff_id: str = None,
    ):
        # 批次号
        self.out_batch_no = out_batch_no
        # 支付宝批次订单号
        self.alipay_trans_id = alipay_trans_id
        # 状态
        self.status = status
        # 成功笔数
        self.success_count = success_count
        # 成功金额（元）
        self.success_amount = success_amount
        # 失败笔数
        self.fail_count = fail_count
        # 明细处理失败的支付汇总金额
        self.fail_amount = fail_amount
        # 批次的总金额（元）
        self.total_amount = total_amount
        # 批次完成交易时间
        self.gmt_finish = gmt_finish
        # 批次受理交易时间
        self.gmt_submit = gmt_submit
        # 失败原因
        self.fail_reason = fail_reason
        # 付款方需要支付的金额（元）
        self.payment_amount = payment_amount
        # 支付币种
        self.payment_currency = payment_currency
        # 付款人staffId
        self.payer_staff_id = payer_staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.alipay_trans_id is not None:
            result['alipayTransId'] = self.alipay_trans_id
        if self.status is not None:
            result['status'] = self.status
        if self.success_count is not None:
            result['successCount'] = self.success_count
        if self.success_amount is not None:
            result['successAmount'] = self.success_amount
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        if self.fail_amount is not None:
            result['failAmount'] = self.fail_amount
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.gmt_submit is not None:
            result['gmtSubmit'] = self.gmt_submit
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.payment_amount is not None:
            result['paymentAmount'] = self.payment_amount
        if self.payment_currency is not None:
            result['paymentCurrency'] = self.payment_currency
        if self.payer_staff_id is not None:
            result['payerStaffId'] = self.payer_staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('alipayTransId') is not None:
            self.alipay_trans_id = m.get('alipayTransId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('successCount') is not None:
            self.success_count = m.get('successCount')
        if m.get('successAmount') is not None:
            self.success_amount = m.get('successAmount')
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        if m.get('failAmount') is not None:
            self.fail_amount = m.get('failAmount')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('gmtSubmit') is not None:
            self.gmt_submit = m.get('gmtSubmit')
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('paymentAmount') is not None:
            self.payment_amount = m.get('paymentAmount')
        if m.get('paymentCurrency') is not None:
            self.payment_currency = m.get('paymentCurrency')
        if m.get('payerStaffId') is not None:
            self.payer_staff_id = m.get('payerStaffId')
        return self


class QueryBatchTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        batch_trade_order_vos: List[QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs] = None,
    ):
        # 批量交易订单VO
        self.batch_trade_order_vos = batch_trade_order_vos

    def validate(self):
        if self.batch_trade_order_vos:
            for k in self.batch_trade_order_vos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['batchTradeOrderVOs'] = []
        if self.batch_trade_order_vos is not None:
            for k in self.batch_trade_order_vos:
                result['batchTradeOrderVOs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.batch_trade_order_vos = []
        if m.get('batchTradeOrderVOs') is not None:
            for k in m.get('batchTradeOrderVOs'):
                temp_model = QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs()
                self.batch_trade_order_vos.append(temp_model.from_map(k))
        return self


class QueryBatchTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryBatchTradeOrderResponseBody = None,
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
            temp_model = QueryBatchTradeOrderResponseBody()
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
        ext_info: Dict[str, str] = None,
        ding_org_id: int = None,
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
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class SaveCorpPayCodeResponseBody(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        status: str = None,
        ext_info: Dict[str, str] = None,
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


class NotifyVerifyResultHeaders(TeaModel):
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


class NotifyVerifyResultRequest(TeaModel):
    def __init__(
        self,
        pay_code: str = None,
        corp_id: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
        verify_time: str = None,
        verify_result: bool = None,
        verify_location: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
    ):
        # 码值
        self.pay_code = pay_code
        # 企业ID
        self.corp_id = corp_id
        # 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
        self.user_corp_relation_type = user_corp_relation_type
        # 用户身份标识
        self.user_identity = user_identity
        # 验证时间
        self.verify_time = verify_time
        # 验证结果
        self.verify_result = verify_result
        # 验证地点
        self.verify_location = verify_location
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        if self.verify_time is not None:
            result['verifyTime'] = self.verify_time
        if self.verify_result is not None:
            result['verifyResult'] = self.verify_result
        if self.verify_location is not None:
            result['verifyLocation'] = self.verify_location
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        if m.get('verifyTime') is not None:
            self.verify_time = m.get('verifyTime')
        if m.get('verifyResult') is not None:
            self.verify_result = m.get('verifyResult')
        if m.get('verifyLocation') is not None:
            self.verify_location = m.get('verifyLocation')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class NotifyVerifyResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 结果
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


class NotifyVerifyResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: NotifyVerifyResultResponseBody = None,
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
            temp_model = NotifyVerifyResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPayAccountListHeaders(TeaModel):
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


class QueryPayAccountListResponseBodyPayAccountVOList(TeaModel):
    def __init__(
        self,
        account_no: str = None,
        account_name: str = None,
        account_type: str = None,
        account_remark: str = None,
        account_id: str = None,
        account_class: str = None,
    ):
        # 付款账号（脱敏）
        self.account_no = account_no
        # 账号名称
        self.account_name = account_name
        # 账户类型
        self.account_type = account_type
        # 账户备注
        self.account_remark = account_remark
        # 账号唯一id
        self.account_id = account_id
        # 账户分类
        self.account_class = account_class

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_no is not None:
            result['accountNo'] = self.account_no
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_class is not None:
            result['accountClass'] = self.account_class
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountNo') is not None:
            self.account_no = m.get('accountNo')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountClass') is not None:
            self.account_class = m.get('accountClass')
        return self


class QueryPayAccountListResponseBody(TeaModel):
    def __init__(
        self,
        pay_account_volist: List[QueryPayAccountListResponseBodyPayAccountVOList] = None,
    ):
        # 账号列表
        self.pay_account_volist = pay_account_volist

    def validate(self):
        if self.pay_account_volist:
            for k in self.pay_account_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['payAccountVOList'] = []
        if self.pay_account_volist is not None:
            for k in self.pay_account_volist:
                result['payAccountVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.pay_account_volist = []
        if m.get('payAccountVOList') is not None:
            for k in m.get('payAccountVOList'):
                temp_model = QueryPayAccountListResponseBodyPayAccountVOList()
                self.pay_account_volist.append(temp_model.from_map(k))
        return self


class QueryPayAccountListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPayAccountListResponseBody = None,
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
            temp_model = QueryPayAccountListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


