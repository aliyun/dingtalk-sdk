# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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


class CreatWithholdingOrderAndPayHeaders(TeaModel):
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


class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList(TeaModel):
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
        # 资金明细创建时间
        self.gmt_create = gmt_create
        # 资金明细完成时间
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


class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList(TeaModel):
    def __init__(
        self,
        pay_channel_name: str = None,
        pay_channel_type: str = None,
        amount: str = None,
        pay_channel_order_no: str = None,
        promotion_amount: str = None,
        fund_tool_detail_info_list: List[CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList] = None,
    ):
        # 渠道名称
        self.pay_channel_name = pay_channel_name
        # 渠道类型
        self.pay_channel_type = pay_channel_type
        # 渠道金额
        self.amount = amount
        # 支付渠道单号
        self.pay_channel_order_no = pay_channel_order_no
        # 总优惠金额
        self.promotion_amount = promotion_amount
        # 资金明细列表
        self.fund_tool_detail_info_list = fund_tool_detail_info_list

    def validate(self):
        if self.fund_tool_detail_info_list:
            for k in self.fund_tool_detail_info_list:
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
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        result['fundToolDetailInfoList'] = []
        if self.fund_tool_detail_info_list is not None:
            for k in self.fund_tool_detail_info_list:
                result['fundToolDetailInfoList'].append(k.to_map() if k else None)
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
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        self.fund_tool_detail_info_list = []
        if m.get('fundToolDetailInfoList') is not None:
            for k in m.get('fundToolDetailInfoList'):
                temp_model = CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList()
                self.fund_tool_detail_info_list.append(temp_model.from_map(k))
        return self


class CreatWithholdingOrderAndPayRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        payer_user_id: str = None,
        pay_channel: str = None,
        amount: str = None,
        out_trade_no: str = None,
        title: str = None,
        remark: str = None,
        time_out_express: str = None,
        other_pay_channel_detail_info_list: List[CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList] = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人staffId
        self.payer_user_id = payer_user_id
        # 支付渠道
        self.pay_channel = pay_channel
        # 扣款金额
        self.amount = amount
        # 外部订单号
        self.out_trade_no = out_trade_no
        # 代扣标题
        self.title = title
        # 代扣备注
        self.remark = remark
        # 代扣过期时间
        self.time_out_express = time_out_express
        # 其他资金渠道付款明细
        self.other_pay_channel_detail_info_list = other_pay_channel_detail_info_list
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.other_pay_channel_detail_info_list:
            for k in self.other_pay_channel_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.amount is not None:
            result['amount'] = self.amount
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.time_out_express is not None:
            result['timeOutExpress'] = self.time_out_express
        result['otherPayChannelDetailInfoList'] = []
        if self.other_pay_channel_detail_info_list is not None:
            for k in self.other_pay_channel_detail_info_list:
                result['otherPayChannelDetailInfoList'].append(k.to_map() if k else None)
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('timeOutExpress') is not None:
            self.time_out_express = m.get('timeOutExpress')
        self.other_pay_channel_detail_info_list = []
        if m.get('otherPayChannelDetailInfoList') is not None:
            for k in m.get('otherPayChannelDetailInfoList'):
                temp_model = CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList()
                self.other_pay_channel_detail_info_list.append(temp_model.from_map(k))
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class CreatWithholdingOrderAndPayResponseBody(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        payer_staff_id: str = None,
        pay_channel: str = None,
        amount: str = None,
        out_trade_no: str = None,
        title: str = None,
        remark: str = None,
        status: str = None,
        order_no: str = None,
        gmt_pay: str = None,
        pay_channel_account_no: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人staffId
        self.payer_staff_id = payer_staff_id
        # 支付渠道
        self.pay_channel = pay_channel
        # 代扣金额（元）
        self.amount = amount
        # 外部订单号
        self.out_trade_no = out_trade_no
        # 代扣标题
        self.title = title
        # 代扣备注
        self.remark = remark
        # 状态
        self.status = status
        # 钉钉订单号
        self.order_no = order_no
        # 付款完成日期
        self.gmt_pay = gmt_pay
        # 支付渠道支付账号（脱敏后返回）
        self.pay_channel_account_no = pay_channel_account_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.payer_staff_id is not None:
            result['payerStaffId'] = self.payer_staff_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.amount is not None:
            result['amount'] = self.amount
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.gmt_pay is not None:
            result['gmtPay'] = self.gmt_pay
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('payerStaffId') is not None:
            self.payer_staff_id = m.get('payerStaffId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('gmtPay') is not None:
            self.gmt_pay = m.get('gmtPay')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        return self


class CreatWithholdingOrderAndPayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreatWithholdingOrderAndPayResponseBody = None,
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
            temp_model = CreatWithholdingOrderAndPayResponseBody()
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


class UserAgreementPageSignHeaders(TeaModel):
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


class UserAgreementPageSignRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
        remark: str = None,
        pay_channel: str = None,
        sub_merchant_service_name: str = None,
        sub_merchant_service_desc: str = None,
        sub_merchant_name: str = None,
        biz_code: str = None,
        biz_scene: str = None,
        sign_scene: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人staffId
        self.user_id = user_id
        # 备注
        self.remark = remark
        # 支付渠道
        self.pay_channel = pay_channel
        # 子商户服务名称
        self.sub_merchant_service_name = sub_merchant_service_name
        # 子商户服务描述
        self.sub_merchant_service_desc = sub_merchant_service_desc
        # 子商户商户名称
        self.sub_merchant_name = sub_merchant_name
        # 业务编码
        self.biz_code = biz_code
        # 业务场景
        self.biz_scene = biz_scene
        # 签约场景
        self.sign_scene = sign_scene
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.sub_merchant_service_name is not None:
            result['subMerchantServiceName'] = self.sub_merchant_service_name
        if self.sub_merchant_service_desc is not None:
            result['subMerchantServiceDesc'] = self.sub_merchant_service_desc
        if self.sub_merchant_name is not None:
            result['subMerchantName'] = self.sub_merchant_name
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        if self.sign_scene is not None:
            result['signScene'] = self.sign_scene
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('subMerchantServiceName') is not None:
            self.sub_merchant_service_name = m.get('subMerchantServiceName')
        if m.get('subMerchantServiceDesc') is not None:
            self.sub_merchant_service_desc = m.get('subMerchantServiceDesc')
        if m.get('subMerchantName') is not None:
            self.sub_merchant_name = m.get('subMerchantName')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        if m.get('signScene') is not None:
            self.sign_scene = m.get('signScene')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class UserAgreementPageSignResponseBody(TeaModel):
    def __init__(
        self,
        page_data: str = None,
    ):
        # 拉起签约页的字符串
        self.page_data = page_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_data is not None:
            result['pageData'] = self.page_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageData') is not None:
            self.page_data = m.get('pageData')
        return self


class UserAgreementPageSignResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UserAgreementPageSignResponseBody = None,
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
            temp_model = UserAgreementPageSignResponseBody()
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
        code_identity: str = None,
        code_id: str = None,
        out_biz_id: str = None,
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
        # 工牌码：DT_IDENTITY，访客码：DT_VISITOR，会展码：DT_CONFERENCE
        self.code_identity = code_identity
        # 码ID，对于访客或会展码等静态码值返回
        self.code_id = code_id
        # 外部业务ID,其值为调用创建用户码接口传入的requestId
        self.out_biz_id = out_biz_id

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
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.out_biz_id is not None:
            result['outBizId'] = self.out_biz_id
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
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('outBizId') is not None:
            self.out_biz_id = m.get('outBizId')
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


class QueryUserAgreementHeaders(TeaModel):
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


class QueryUserAgreementRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
        biz_code: str = None,
        biz_scene: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人staffId
        self.user_id = user_id
        # 业务编码
        self.biz_code = biz_code
        # 业务场景
        self.biz_scene = biz_scene

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        return self


class QueryUserAgreementResponseBody(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        corp_id: str = None,
        inst_id: str = None,
        sub_inst_id: str = None,
        pay_channel: str = None,
        agreement_no: str = None,
        pay_channel_account_no: str = None,
        pay_channel_account_name: str = None,
        gmt_sign: str = None,
        status: str = None,
        gmt_valid: str = None,
        gmt_expire: str = None,
    ):
        # 用户id
        self.user_id = user_id
        # 组织id
        self.corp_id = corp_id
        # 主机构id
        self.inst_id = inst_id
        # 子机构id
        self.sub_inst_id = sub_inst_id
        # 支付渠道
        self.pay_channel = pay_channel
        # 协议编号
        self.agreement_no = agreement_no
        # 实际支付账号（脱敏）
        self.pay_channel_account_no = pay_channel_account_no
        # 实际支付账户名（脱敏）
        self.pay_channel_account_name = pay_channel_account_name
        # 实际签约日期
        self.gmt_sign = gmt_sign
        # 签约状态
        self.status = status
        # 实际生效日期
        self.gmt_valid = gmt_valid
        # 实际过期日期
        self.gmt_expire = gmt_expire

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.agreement_no is not None:
            result['agreementNo'] = self.agreement_no
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.pay_channel_account_name is not None:
            result['payChannelAccountName'] = self.pay_channel_account_name
        if self.gmt_sign is not None:
            result['gmtSign'] = self.gmt_sign
        if self.status is not None:
            result['status'] = self.status
        if self.gmt_valid is not None:
            result['gmtValid'] = self.gmt_valid
        if self.gmt_expire is not None:
            result['gmtExpire'] = self.gmt_expire
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('agreementNo') is not None:
            self.agreement_no = m.get('agreementNo')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('payChannelAccountName') is not None:
            self.pay_channel_account_name = m.get('payChannelAccountName')
        if m.get('gmtSign') is not None:
            self.gmt_sign = m.get('gmtSign')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('gmtValid') is not None:
            self.gmt_valid = m.get('gmtValid')
        if m.get('gmtExpire') is not None:
            self.gmt_expire = m.get('gmtExpire')
        return self


class QueryUserAgreementResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserAgreementResponseBody = None,
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
            temp_model = QueryUserAgreementResponseBody()
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
        code_value_type: str = None,
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
        # 码值类型，钉钉静态码值：DING_STATIC，访客码或会展码传入
        self.code_value_type = code_value_type
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
        if self.code_value_type is not None:
            result['codeValueType'] = self.code_value_type
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
        if m.get('codeValueType') is not None:
            self.code_value_type = m.get('codeValueType')
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
        code_detail_url: str = None,
    ):
        # 码ID
        self.code_id = code_id
        # 码详情跳转地址
        self.code_detail_url = code_detail_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_detail_url is not None:
            result['codeDetailUrl'] = self.code_detail_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeDetailUrl') is not None:
            self.code_detail_url = m.get('codeDetailUrl')
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


class QueryAcquireRefundOrderHeaders(TeaModel):
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


class QueryAcquireRefundOrderRequest(TeaModel):
    def __init__(
        self,
        out_refund_no: str = None,
    ):
        # 外部退款订单流水号
        self.out_refund_no = out_refund_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        return self


class QueryAcquireRefundOrderResponseBody(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        payer_user_id: str = None,
        pay_channel: str = None,
        amount: str = None,
        out_refund_no: str = None,
        title: str = None,
        remark: str = None,
        status: str = None,
        order_no: str = None,
        gmt_refund: str = None,
        pay_channel_account_no: str = None,
        gmt_create: str = None,
        origin_out_trade_no: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 退款人userId
        self.payer_user_id = payer_user_id
        # 支付渠道
        self.pay_channel = pay_channel
        # 代扣金额（元）
        self.amount = amount
        # 外部退款订单号
        self.out_refund_no = out_refund_no
        # 代扣标题
        self.title = title
        # 代扣备注
        self.remark = remark
        # 状态
        self.status = status
        # 钉钉订单号
        self.order_no = order_no
        # 退款完成日期
        self.gmt_refund = gmt_refund
        # 支付渠道支付账号（脱敏后返回）
        self.pay_channel_account_no = pay_channel_account_no
        # 订单创建日期
        self.gmt_create = gmt_create
        # 原支付单外部流水号
        self.origin_out_trade_no = origin_out_trade_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.amount is not None:
            result['amount'] = self.amount
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.origin_out_trade_no is not None:
            result['originOutTradeNo'] = self.origin_out_trade_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('originOutTradeNo') is not None:
            self.origin_out_trade_no = m.get('originOutTradeNo')
        return self


class QueryAcquireRefundOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAcquireRefundOrderResponseBody = None,
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
            temp_model = QueryAcquireRefundOrderResponseBody()
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
        verify_no: str = None,
        verify_event: str = None,
        remark: str = None,
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
        # 验证地点，调用时请务必传入，以便生成工牌使用记录
        self.verify_location = verify_location
        # 验证流水号，长度不超过32位，用户下唯一，调用时请务必传入，以便生成工牌使用记录
        self.verify_no = verify_no
        # 验证事件，长度不超过8个中文
        self.verify_event = verify_event
        # 备注信息
        self.remark = remark
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
        if self.verify_no is not None:
            result['verifyNo'] = self.verify_no
        if self.verify_event is not None:
            result['verifyEvent'] = self.verify_event
        if self.remark is not None:
            result['remark'] = self.remark
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
        if m.get('verifyNo') is not None:
            self.verify_no = m.get('verifyNo')
        if m.get('verifyEvent') is not None:
            self.verify_event = m.get('verifyEvent')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
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


class ConsultCreateSubInstitutionHeaders(TeaModel):
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


class ConsultCreateSubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        sub_inst_name: str = None,
        alias_name: str = None,
        type: str = None,
        mcc: str = None,
    ):
        # 名称
        self.sub_inst_name = sub_inst_name
        # 别名
        self.alias_name = alias_name
        # 类型
        self.type = type
        # 机构识别码
        self.mcc = mcc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.type is not None:
            result['type'] = self.type
        if self.mcc is not None:
            result['mcc'] = self.mcc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        return self


class ConsultCreateSubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_no: str = None,
        cert_type: str = None,
        cert_image: str = None,
    ):
        # 证件号码
        self.cert_no = cert_no
        # 证件类型
        self.cert_type = cert_type
        # 证件图片, 如果是特殊行业必填
        self.cert_image = cert_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        return self


class ConsultCreateSubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_name: str = None,
        id_card_no: str = None,
        cert_front_image: str = None,
        cert_back_image: str = None,
        cert_type: str = None,
    ):
        # 法人姓名
        self.cert_name = cert_name
        # 法人证件号
        self.id_card_no = id_card_no
        # 法人证件正面url
        self.cert_front_image = cert_front_image
        # 法人证件反面url
        self.cert_back_image = cert_back_image
        # 法人证件类型 不填默认为身份证
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class ConsultCreateSubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
        account_name: str = None,
        account_id: str = None,
        bank_name: str = None,
        bank_branch_name: str = None,
        bank_short_name_code: str = None,
        bank_code: str = None,
        bank_province: str = None,
        bank_city: str = None,
        account_type: str = None,
        usage_type: str = None,
    ):
        # 账号类型
        self.type = type
        # 账户名称 账号类型银行卡时为卡户名
        self.account_name = account_name
        # 账户账号
        self.account_id = account_id
        # 银行名称
        self.bank_name = bank_name
        # 支行名称
        self.bank_branch_name = bank_branch_name
        # 开户行简称缩写
        self.bank_short_name_code = bank_short_name_code
        # 联行号
        self.bank_code = bank_code
        # 开户行所在地 省
        self.bank_province = bank_province
        # 开户行所在地 市
        self.bank_city = bank_city
        # 卡类型
        self.account_type = account_type
        # 账户使用类型
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class ConsultCreateSubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # 联系人姓名
        self.contact_name = contact_name
        # 联系人手机号
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ConsultCreateSubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_type: str = None,
        qualification_image: str = None,
    ):
        # 子机构行业资质类型
        self.qualification_type = qualification_type
        # 子机构行业资质图片
        self.qualification_image = qualification_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        return self


class ConsultCreateSubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        # 授权函图片url
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class ConsultCreateSubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class ConsultCreateSubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        # 内景照
        self.in_door_images = in_door_images
        # 外景照
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        auto_invoice: bool = None,
        accept_electronic: bool = None,
        tax_payer_qualification: str = None,
        title: str = None,
        tax_no: str = None,
        tax_payer_valid_date: str = None,
        address: str = None,
        telephone: str = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_name: str = None,
        mail_phone: str = None,
        mail_address: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
    ):
        # 是否自动开票
        self.auto_invoice = auto_invoice
        # 是否接受电票
        self.accept_electronic = accept_electronic
        # 纳税人资质
        self.tax_payer_qualification = tax_payer_qualification
        # 纳税人抬头
        self.title = title
        # 纳税人识别号
        self.tax_no = tax_no
        # 纳税人资格开始时间
        self.tax_payer_valid_date = tax_payer_valid_date
        # 开票地址
        self.address = address
        # 开票电话
        self.telephone = telephone
        # 银行账户
        self.bank_account = bank_account
        # 银行名称
        self.bank_name = bank_name
        # 收件人名称
        self.mail_name = mail_name
        # 收件人号码
        self.mail_phone = mail_phone
        # 收件地址
        self.mail_address = mail_address

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.title is not None:
            result['title'] = self.title
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.address is not None:
            result['address'] = self.address
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('mailAddress') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        return self


class ConsultCreateSubInstitutionRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        out_trade_no: str = None,
        services: List[str] = None,
        solution: str = None,
        pay_channel: str = None,
        sub_inst_basic_info: ConsultCreateSubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: ConsultCreateSubInstitutionRequestSubInstCertifyInfo = None,
        legal_person_cert_info: ConsultCreateSubInstitutionRequestLegalPersonCertInfo = None,
        settle_info: ConsultCreateSubInstitutionRequestSettleInfo = None,
        contact_info: ConsultCreateSubInstitutionRequestContactInfo = None,
        qualification_infos: List[ConsultCreateSubInstitutionRequestQualificationInfos] = None,
        sub_inst_auth_info: ConsultCreateSubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_address_info: ConsultCreateSubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_shop_info: ConsultCreateSubInstitutionRequestSubInstShopInfo = None,
        sub_inst_invoice_info: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo = None,
        binding_alipay_logon_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 进件创建外部流水号
        self.out_trade_no = out_trade_no
        # 开通的服务类型
        self.services = services
        # 解决方案，包含清算、费率规则
        self.solution = solution
        # 进件渠道
        self.pay_channel = pay_channel
        # 子机构基本信息
        self.sub_inst_basic_info = sub_inst_basic_info
        # 子机构认证信息
        self.sub_inst_certify_info = sub_inst_certify_info
        self.legal_person_cert_info = legal_person_cert_info
        # 资金账户信息
        self.settle_info = settle_info
        # 联系人
        self.contact_info = contact_info
        # 资质信息
        self.qualification_infos = qualification_infos
        # 授权信息
        self.sub_inst_auth_info = sub_inst_auth_info
        # 子机构地址信息
        self.sub_inst_address_info = sub_inst_address_info
        # 子机构门店信息
        self.sub_inst_shop_info = sub_inst_shop_info
        # 开票信息
        self.sub_inst_invoice_info = sub_inst_invoice_info
        # 签约支付宝账户，用于协议确认
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.contact_info:
            self.contact_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.services is not None:
            result['services'] = self.services
        if self.solution is not None:
            result['solution'] = self.solution
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('solution') is not None:
            self.solution = m.get('solution')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('subInstBasicInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('legalPersonCertInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('settleInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('contactInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = ConsultCreateSubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('subInstAuthInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstAddressInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class ConsultCreateSubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        # 进件申请单号
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class ConsultCreateSubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ConsultCreateSubInstitutionResponseBody = None,
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
            temp_model = ConsultCreateSubInstitutionResponseBody()
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


class QueryWithholdingOrderHeaders(TeaModel):
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


class QueryWithholdingOrderRequest(TeaModel):
    def __init__(
        self,
        out_trade_no: str = None,
    ):
        # 外部订单流水号
        self.out_trade_no = out_trade_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        return self


class QueryWithholdingOrderResponseBody(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        payer_user_id: str = None,
        pay_channel: str = None,
        amount: str = None,
        out_trade_no: str = None,
        title: str = None,
        remark: str = None,
        status: str = None,
        order_no: str = None,
        gmt_pay: str = None,
        pay_channel_account_no: str = None,
        gmt_create: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人userId
        self.payer_user_id = payer_user_id
        # 支付渠道
        self.pay_channel = pay_channel
        # 代扣金额（元）
        self.amount = amount
        # 外部订单号
        self.out_trade_no = out_trade_no
        # 代扣标题
        self.title = title
        # 代扣备注
        self.remark = remark
        # 状态
        self.status = status
        # 钉钉订单号
        self.order_no = order_no
        # 付款完成日期
        self.gmt_pay = gmt_pay
        # 支付渠道支付账号（脱敏后返回）
        self.pay_channel_account_no = pay_channel_account_no
        # 订单创建日期
        self.gmt_create = gmt_create

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.amount is not None:
            result['amount'] = self.amount
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.gmt_pay is not None:
            result['gmtPay'] = self.gmt_pay
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('gmtPay') is not None:
            self.gmt_pay = m.get('gmtPay')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        return self


class QueryWithholdingOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryWithholdingOrderResponseBody = None,
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
            temp_model = QueryWithholdingOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class CreateAcquireRefundOrderHeaders(TeaModel):
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


class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList(TeaModel):
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
        # 资金明细创建时间
        self.gmt_create = gmt_create
        # 资金明细完成时间
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


class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList(TeaModel):
    def __init__(
        self,
        pay_channel_name: str = None,
        pay_channel_type: str = None,
        amount: str = None,
        pay_channel_order_no: str = None,
        promotion_amount: str = None,
        fund_tool_detail_info_list: List[CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList] = None,
    ):
        # 渠道名称
        self.pay_channel_name = pay_channel_name
        # 渠道类型
        self.pay_channel_type = pay_channel_type
        # 渠道金额
        self.amount = amount
        # 支付渠道单号
        self.pay_channel_order_no = pay_channel_order_no
        # 总优惠金额
        self.promotion_amount = promotion_amount
        # 资金明细列表
        self.fund_tool_detail_info_list = fund_tool_detail_info_list

    def validate(self):
        if self.fund_tool_detail_info_list:
            for k in self.fund_tool_detail_info_list:
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
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        result['fundToolDetailInfoList'] = []
        if self.fund_tool_detail_info_list is not None:
            for k in self.fund_tool_detail_info_list:
                result['fundToolDetailInfoList'].append(k.to_map() if k else None)
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
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        self.fund_tool_detail_info_list = []
        if m.get('fundToolDetailInfoList') is not None:
            for k in m.get('fundToolDetailInfoList'):
                temp_model = CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList()
                self.fund_tool_detail_info_list.append(temp_model.from_map(k))
        return self


class CreateAcquireRefundOrderRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        operator_user_id: str = None,
        refund_amount: str = None,
        out_refund_no: str = None,
        title: str = None,
        remark: str = None,
        origin_out_trade_no: str = None,
        other_pay_channel_detail_info_list: List[CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList] = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 操作人userId
        self.operator_user_id = operator_user_id
        # 退款金额，支持部分退款
        self.refund_amount = refund_amount
        # 外部退款订单号
        self.out_refund_no = out_refund_no
        # 代扣标题
        self.title = title
        # 退款备注
        self.remark = remark
        # 原支付单外部流水号
        self.origin_out_trade_no = origin_out_trade_no
        # 其他资金渠道退款明细
        self.other_pay_channel_detail_info_list = other_pay_channel_detail_info_list
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.other_pay_channel_detail_info_list:
            for k in self.other_pay_channel_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.title is not None:
            result['title'] = self.title
        if self.remark is not None:
            result['remark'] = self.remark
        if self.origin_out_trade_no is not None:
            result['originOutTradeNo'] = self.origin_out_trade_no
        result['otherPayChannelDetailInfoList'] = []
        if self.other_pay_channel_detail_info_list is not None:
            for k in self.other_pay_channel_detail_info_list:
                result['otherPayChannelDetailInfoList'].append(k.to_map() if k else None)
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('originOutTradeNo') is not None:
            self.origin_out_trade_no = m.get('originOutTradeNo')
        self.other_pay_channel_detail_info_list = []
        if m.get('otherPayChannelDetailInfoList') is not None:
            for k in m.get('otherPayChannelDetailInfoList'):
                temp_model = CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList()
                self.other_pay_channel_detail_info_list.append(temp_model.from_map(k))
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class CreateAcquireRefundOrderResponseBody(TeaModel):
    def __init__(
        self,
        out_refund_no: str = None,
        refund_order_no: str = None,
        status: str = None,
    ):
        # 外部退款单号
        self.out_refund_no = out_refund_no
        # 钉钉退款单号
        self.refund_order_no = refund_order_no
        # 退款状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.refund_order_no is not None:
            result['refundOrderNo'] = self.refund_order_no
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('refundOrderNo') is not None:
            self.refund_order_no = m.get('refundOrderNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateAcquireRefundOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateAcquireRefundOrderResponseBody = None,
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
            temp_model = CreateAcquireRefundOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRegisterOrderHeaders(TeaModel):
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


class QueryRegisterOrderRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        out_trade_no: str = None,
        order_id: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 外部流水号，和申请单编号至少一个必填
        self.out_trade_no = out_trade_no
        # 申请单号，和外部流水号至少一个必填
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class QueryRegisterOrderResponseBody(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        out_trade_no: str = None,
        order_id: str = None,
        sub_inst_name: str = None,
        status: str = None,
        gmt_audit: str = None,
        fail_reason: str = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 外部流水号
        self.out_trade_no = out_trade_no
        # 申请单号
        self.order_id = order_id
        # 子机构名称
        self.sub_inst_name = sub_inst_name
        # 申请单状态
        self.status = status
        # 审核时间
        self.gmt_audit = gmt_audit
        # 失败原因
        self.fail_reason = fail_reason

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.status is not None:
            result['status'] = self.status
        if self.gmt_audit is not None:
            result['gmtAudit'] = self.gmt_audit
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('gmtAudit') is not None:
            self.gmt_audit = m.get('gmtAudit')
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        return self


class QueryRegisterOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryRegisterOrderResponseBody = None,
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
            temp_model = QueryRegisterOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadRegisterImageHeaders(TeaModel):
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


class UploadRegisterImageRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        pay_channel: str = None,
        image_type: str = None,
        image_name: str = None,
        image_content: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构id
        self.inst_id = inst_id
        # 进件渠道
        self.pay_channel = pay_channel
        # 图片类型
        self.image_type = image_type
        # 图片名称
        self.image_name = image_name
        # 图片内容
        self.image_content = image_content
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.image_type is not None:
            result['imageType'] = self.image_type
        if self.image_name is not None:
            result['imageName'] = self.image_name
        if self.image_content is not None:
            result['imageContent'] = self.image_content
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('imageType') is not None:
            self.image_type = m.get('imageType')
        if m.get('imageName') is not None:
            self.image_name = m.get('imageName')
        if m.get('imageContent') is not None:
            self.image_content = m.get('imageContent')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class UploadRegisterImageResponseBody(TeaModel):
    def __init__(
        self,
        oss_url: str = None,
    ):
        # 进件图片上传响应
        self.oss_url = oss_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.oss_url is not None:
            result['ossUrl'] = self.oss_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ossUrl') is not None:
            self.oss_url = m.get('ossUrl')
        return self


class UploadRegisterImageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UploadRegisterImageResponseBody = None,
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
            temp_model = UploadRegisterImageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsignUserAgreementHeaders(TeaModel):
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


class UnsignUserAgreementRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
        biz_code: str = None,
        biz_scene: str = None,
        agreement_no: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 付款人staffId
        self.user_id = user_id
        # 业务代码
        self.biz_code = biz_code
        # 业务场景
        self.biz_scene = biz_scene
        # 协议编号
        self.agreement_no = agreement_no
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        if self.agreement_no is not None:
            result['agreementNo'] = self.agreement_no
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        if m.get('agreementNo') is not None:
            self.agreement_no = m.get('agreementNo')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class UnsignUserAgreementResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class ModifySubInstitutionHeaders(TeaModel):
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


class ModifySubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        sub_inst_name: str = None,
        alias_name: str = None,
        type: str = None,
        mcc: str = None,
    ):
        # 名称
        self.sub_inst_name = sub_inst_name
        # 别名
        self.alias_name = alias_name
        # 类型
        self.type = type
        # 机构识别码
        self.mcc = mcc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.type is not None:
            result['type'] = self.type
        if self.mcc is not None:
            result['mcc'] = self.mcc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        return self


class ModifySubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_no: str = None,
        cert_type: str = None,
        cert_image: str = None,
    ):
        # 证件号码
        self.cert_no = cert_no
        # 证件类型
        self.cert_type = cert_type
        # 证件图片, 如果是特殊行业必填
        self.cert_image = cert_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        return self


class ModifySubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_name: str = None,
        id_card_no: str = None,
        cert_front_image: str = None,
        cert_back_image: str = None,
        cert_type: str = None,
    ):
        # 法人姓名
        self.cert_name = cert_name
        # 法人证件号
        self.id_card_no = id_card_no
        # 法人证件正面url
        self.cert_front_image = cert_front_image
        # 法人证件反面url
        self.cert_back_image = cert_back_image
        # 法人证件类型 不填默认为身份证
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class ModifySubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
        account_name: str = None,
        account_id: str = None,
        bank_name: str = None,
        bank_branch_name: str = None,
        bank_short_name_code: str = None,
        bank_code: str = None,
        bank_province: str = None,
        bank_city: str = None,
        account_type: str = None,
        usage_type: str = None,
    ):
        # 账号类型
        self.type = type
        # 账户名称 账号类型银行卡时为卡户名
        self.account_name = account_name
        # 账户账号
        self.account_id = account_id
        # 银行名称
        self.bank_name = bank_name
        # 支行名称
        self.bank_branch_name = bank_branch_name
        # 开户行简称缩写
        self.bank_short_name_code = bank_short_name_code
        # 联行号
        self.bank_code = bank_code
        # 开户行所在地 省
        self.bank_province = bank_province
        # 开户行所在地 市
        self.bank_city = bank_city
        # 卡类型
        self.account_type = account_type
        # 账户使用类型
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class ModifySubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # 联系人姓名
        self.contact_name = contact_name
        # 联系人手机号
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ModifySubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_type: str = None,
        qualification_image: str = None,
    ):
        # 子机构行业资质类型
        self.qualification_type = qualification_type
        # 子机构行业资质图片
        self.qualification_image = qualification_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        return self


class ModifySubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        # 授权函图片url
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class ModifySubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class ModifySubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        # 内景照
        self.in_door_images = in_door_images
        # 外景照
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class ModifySubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        auto_invoice: bool = None,
        accept_electronic: bool = None,
        tax_payer_qualification: str = None,
        title: str = None,
        tax_no: str = None,
        tax_payer_valid_date: str = None,
        address: str = None,
        telephone: str = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_name: str = None,
        mail_phone: str = None,
        mail_address: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
    ):
        # 是否自动开票
        self.auto_invoice = auto_invoice
        # 是否接受电票
        self.accept_electronic = accept_electronic
        # 纳税人资质
        self.tax_payer_qualification = tax_payer_qualification
        # 纳税人抬头
        self.title = title
        # 纳税人识别号
        self.tax_no = tax_no
        # 纳税人资格开始时间
        self.tax_payer_valid_date = tax_payer_valid_date
        # 开票地址
        self.address = address
        # 开票电话
        self.telephone = telephone
        # 银行账户
        self.bank_account = bank_account
        # 银行名称
        self.bank_name = bank_name
        # 收件人名称
        self.mail_name = mail_name
        # 收件人号码
        self.mail_phone = mail_phone
        # 收件地址
        self.mail_address = mail_address

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.title is not None:
            result['title'] = self.title
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.address is not None:
            result['address'] = self.address
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('mailAddress') is not None:
            temp_model = ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        return self


class ModifySubInstitutionRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        out_trade_no: str = None,
        services: List[str] = None,
        pay_channel: str = None,
        sub_inst_basic_info: ModifySubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: ModifySubInstitutionRequestSubInstCertifyInfo = None,
        legal_person_cert_info: ModifySubInstitutionRequestLegalPersonCertInfo = None,
        settle_info: ModifySubInstitutionRequestSettleInfo = None,
        contact_info: ModifySubInstitutionRequestContactInfo = None,
        qualification_infos: List[ModifySubInstitutionRequestQualificationInfos] = None,
        sub_inst_auth_info: ModifySubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_address_info: ModifySubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_shop_info: ModifySubInstitutionRequestSubInstShopInfo = None,
        sub_inst_invoice_info: ModifySubInstitutionRequestSubInstInvoiceInfo = None,
        binding_alipay_logon_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 进件创建外部流水号
        self.out_trade_no = out_trade_no
        # 开通的服务类型
        self.services = services
        # 进件渠道
        self.pay_channel = pay_channel
        # 子机构基本信息
        self.sub_inst_basic_info = sub_inst_basic_info
        # 子机构认证信息
        self.sub_inst_certify_info = sub_inst_certify_info
        self.legal_person_cert_info = legal_person_cert_info
        # 资金账户信息
        self.settle_info = settle_info
        # 联系人
        self.contact_info = contact_info
        # 资质信息
        self.qualification_infos = qualification_infos
        # 授权信息
        self.sub_inst_auth_info = sub_inst_auth_info
        # 子机构地址信息
        self.sub_inst_address_info = sub_inst_address_info
        # 子机构门店信息
        self.sub_inst_shop_info = sub_inst_shop_info
        # 开票信息
        self.sub_inst_invoice_info = sub_inst_invoice_info
        # 签约支付宝账户，用于协议确认
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.contact_info:
            self.contact_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.services is not None:
            result['services'] = self.services
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('subInstBasicInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('legalPersonCertInfo') is not None:
            temp_model = ModifySubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('settleInfo') is not None:
            temp_model = ModifySubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('contactInfo') is not None:
            temp_model = ModifySubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = ModifySubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('subInstAuthInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstAddressInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class ModifySubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        # 修改申请单号
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class ModifySubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ModifySubInstitutionResponseBody = None,
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
            temp_model = ModifySubInstitutionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSubInstitutionHeaders(TeaModel):
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


class CreateSubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        sub_inst_name: str = None,
        alias_name: str = None,
        type: str = None,
        mcc: str = None,
    ):
        # 名称
        self.sub_inst_name = sub_inst_name
        # 别名
        self.alias_name = alias_name
        # 类型
        self.type = type
        # 机构识别码
        self.mcc = mcc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.type is not None:
            result['type'] = self.type
        if self.mcc is not None:
            result['mcc'] = self.mcc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        return self


class CreateSubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_no: str = None,
        cert_type: str = None,
        cert_image: str = None,
    ):
        # 证件号码
        self.cert_no = cert_no
        # 证件类型
        self.cert_type = cert_type
        # 证件图片, 如果是特殊行业必填
        self.cert_image = cert_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        return self


class CreateSubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_name: str = None,
        id_card_no: str = None,
        cert_front_image: str = None,
        cert_back_image: str = None,
        cert_type: str = None,
    ):
        # 法人姓名
        self.cert_name = cert_name
        # 法人证件号
        self.id_card_no = id_card_no
        # 法人证件正面url
        self.cert_front_image = cert_front_image
        # 法人证件反面url
        self.cert_back_image = cert_back_image
        # 法人证件类型 不填默认为身份证
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class CreateSubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
        account_name: str = None,
        account_id: str = None,
        bank_name: str = None,
        bank_branch_name: str = None,
        bank_short_name_code: str = None,
        bank_code: str = None,
        bank_province: str = None,
        bank_city: str = None,
        account_type: str = None,
        usage_type: str = None,
    ):
        # 账号类型
        self.type = type
        # 账户名称 账号类型银行卡时为卡户名
        self.account_name = account_name
        # 账户账号
        self.account_id = account_id
        # 银行名称
        self.bank_name = bank_name
        # 支行名称
        self.bank_branch_name = bank_branch_name
        # 开户行简称缩写
        self.bank_short_name_code = bank_short_name_code
        # 联行号
        self.bank_code = bank_code
        # 开户行所在地 省
        self.bank_province = bank_province
        # 开户行所在地 市
        self.bank_city = bank_city
        # 卡类型, DEBIT_CARD借记卡，CREDIT_CARD信用卡
        self.account_type = account_type
        # 账户使用类型
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class CreateSubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # 联系人姓名
        self.contact_name = contact_name
        # 联系人手机号
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class CreateSubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_type: str = None,
        qualification_image: str = None,
    ):
        # 子机构行业资质类型
        self.qualification_type = qualification_type
        # 子机构行业资质图片
        self.qualification_image = qualification_image

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        return self


class CreateSubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        # 授权函图片url
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class CreateSubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class CreateSubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        # 内景照
        self.in_door_images = in_door_images
        # 外景照
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        province_code: str = None,
        city_code: str = None,
        district_code: str = None,
        address: str = None,
    ):
        # 省码
        self.province_code = province_code
        # 市码
        self.city_code = city_code
        # 区码
        self.district_code = district_code
        # 详细地址
        self.address = address

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.address is not None:
            result['address'] = self.address
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('address') is not None:
            self.address = m.get('address')
        return self


class CreateSubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        auto_invoice: bool = None,
        accept_electronic: bool = None,
        tax_payer_qualification: str = None,
        title: str = None,
        tax_no: str = None,
        tax_payer_valid_date: str = None,
        address: str = None,
        telephone: str = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_name: str = None,
        mail_phone: str = None,
        mail_address: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
    ):
        # 是否自动开票
        self.auto_invoice = auto_invoice
        # 是否接受电票
        self.accept_electronic = accept_electronic
        # 纳税人资质
        self.tax_payer_qualification = tax_payer_qualification
        # 纳税人抬头
        self.title = title
        # 纳税人识别号
        self.tax_no = tax_no
        # 纳税人资格开始时间
        self.tax_payer_valid_date = tax_payer_valid_date
        # 开票地址
        self.address = address
        # 开票电话
        self.telephone = telephone
        # 银行账户
        self.bank_account = bank_account
        # 银行名称
        self.bank_name = bank_name
        # 收件人名称
        self.mail_name = mail_name
        # 收件人号码
        self.mail_phone = mail_phone
        # 收件地址
        self.mail_address = mail_address

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.title is not None:
            result['title'] = self.title
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.address is not None:
            result['address'] = self.address
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('mailAddress') is not None:
            temp_model = CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        return self


class CreateSubInstitutionRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        sub_inst_id: str = None,
        out_trade_no: str = None,
        services: List[str] = None,
        solution: str = None,
        pay_channel: str = None,
        sub_inst_basic_info: CreateSubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: CreateSubInstitutionRequestSubInstCertifyInfo = None,
        legal_person_cert_info: CreateSubInstitutionRequestLegalPersonCertInfo = None,
        settle_info: CreateSubInstitutionRequestSettleInfo = None,
        contact_info: CreateSubInstitutionRequestContactInfo = None,
        qualification_infos: List[CreateSubInstitutionRequestQualificationInfos] = None,
        sub_inst_auth_info: CreateSubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_address_info: CreateSubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_shop_info: CreateSubInstitutionRequestSubInstShopInfo = None,
        sub_inst_invoice_info: CreateSubInstitutionRequestSubInstInvoiceInfo = None,
        binding_alipay_logon_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_client_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 主机构编号
        self.inst_id = inst_id
        # 子机构编号
        self.sub_inst_id = sub_inst_id
        # 进件创建外部流水号
        self.out_trade_no = out_trade_no
        # 开通的服务类型
        self.services = services
        # 解决方案，包含费率、清算规则等
        self.solution = solution
        # 进件渠道
        self.pay_channel = pay_channel
        # 子机构基本信息
        self.sub_inst_basic_info = sub_inst_basic_info
        # 子机构认证信息
        self.sub_inst_certify_info = sub_inst_certify_info
        self.legal_person_cert_info = legal_person_cert_info
        # 资金账户信息
        self.settle_info = settle_info
        # 联系人
        self.contact_info = contact_info
        # 资质信息
        self.qualification_infos = qualification_infos
        # 授权信息
        self.sub_inst_auth_info = sub_inst_auth_info
        # 子机构地址信息
        self.sub_inst_address_info = sub_inst_address_info
        # 子机构门店信息
        self.sub_inst_shop_info = sub_inst_shop_info
        # 开票信息
        self.sub_inst_invoice_info = sub_inst_invoice_info
        # 签约支付宝账户，用于协议确认
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # 组织id
        self.ding_org_id = ding_org_id
        # isv组织id
        self.ding_isv_org_id = ding_isv_org_id
        # 应用id
        self.ding_client_id = ding_client_id
        # 应用类型
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.contact_info:
            self.contact_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.services is not None:
            result['services'] = self.services
        if self.solution is not None:
            result['solution'] = self.solution
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('solution') is not None:
            self.solution = m.get('solution')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('subInstBasicInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('legalPersonCertInfo') is not None:
            temp_model = CreateSubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('settleInfo') is not None:
            temp_model = CreateSubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('contactInfo') is not None:
            temp_model = CreateSubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = CreateSubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('subInstAuthInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstAddressInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class CreateSubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        # 进件申请单号
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class CreateSubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateSubInstitutionResponseBody = None,
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
            temp_model = CreateSubInstitutionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


