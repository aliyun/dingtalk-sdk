# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CreateBadgeCodeUserInstanceHeaders(TeaModel):
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


class CreateBadgeCodeUserInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_end: str = None,
        gmt_start: str = None,
    ):
        # This parameter is required.
        self.gmt_end = gmt_end
        # This parameter is required.
        self.gmt_start = gmt_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        return self


class CreateBadgeCodeUserInstanceRequest(TeaModel):
    def __init__(
        self,
        available_times: List[CreateBadgeCodeUserInstanceRequestAvailableTimes] = None,
        code_identity: str = None,
        code_value: str = None,
        code_value_type: str = None,
        corp_id: str = None,
        ext_info: Dict[str, Any] = None,
        gmt_expired: str = None,
        request_id: str = None,
        status: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
    ):
        # This parameter is required.
        self.available_times = available_times
        # This parameter is required.
        self.code_identity = code_identity
        self.code_value = code_value
        self.code_value_type = code_value_type
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_expired = gmt_expired
        # This parameter is required.
        self.request_id = request_id
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity

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
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.code_value_type is not None:
            result['codeValueType'] = self.code_value_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.status is not None:
            result['status'] = self.status
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = CreateBadgeCodeUserInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('codeValueType') is not None:
            self.code_value_type = m.get('codeValueType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        return self


class CreateBadgeCodeUserInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_detail_url: str = None,
        code_id: str = None,
    ):
        self.code_detail_url = code_detail_url
        # This parameter is required.
        self.code_id = code_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_detail_url is not None:
            result['codeDetailUrl'] = self.code_detail_url
        if self.code_id is not None:
            result['codeId'] = self.code_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeDetailUrl') is not None:
            self.code_detail_url = m.get('codeDetailUrl')
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        return self


class CreateBadgeCodeUserInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateBadgeCodeUserInstanceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateBadgeCodeUserInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateBadgeNotifyHeaders(TeaModel):
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


class CreateBadgeNotifyRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        msg_id: str = None,
        msg_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.msg_id = msg_id
        # This parameter is required.
        self.msg_type = msg_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateBadgeNotifyResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class CreateBadgeNotifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateBadgeNotifyResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateBadgeNotifyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DecodeBadgeCodeHeaders(TeaModel):
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


class DecodeBadgeCodeRequest(TeaModel):
    def __init__(
        self,
        pay_code: str = None,
        request_id: str = None,
    ):
        # This parameter is required.
        self.pay_code = pay_code
        # This parameter is required.
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


class DecodeBadgeCodeResponseBody(TeaModel):
    def __init__(
        self,
        alipay_code: str = None,
        code_id: str = None,
        code_identity: str = None,
        code_type: str = None,
        corp_id: str = None,
        ext_info: str = None,
        out_biz_id: str = None,
        user_corp_relation_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.alipay_code = alipay_code
        self.code_id = code_id
        self.code_identity = code_identity
        # This parameter is required.
        self.code_type = code_type
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_info = ext_info
        self.out_biz_id = out_biz_id
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_code is not None:
            result['alipayCode'] = self.alipay_code
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_type is not None:
            result['codeType'] = self.code_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.out_biz_id is not None:
            result['outBizId'] = self.out_biz_id
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayCode') is not None:
            self.alipay_code = m.get('alipayCode')
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeType') is not None:
            self.code_type = m.get('codeType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('outBizId') is not None:
            self.out_biz_id = m.get('outBizId')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DecodeBadgeCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DecodeBadgeCodeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = DecodeBadgeCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyBadgeCodePayResultHeaders(TeaModel):
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


class NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class NotifyBadgeCodePayResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_list: List[NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList] = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_list = fund_tool_detail_list
        self.gmt_create = gmt_create
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

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
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class NotifyBadgeCodePayResultRequest(TeaModel):
    def __init__(
        self,
        amount: str = None,
        charge_amount: str = None,
        corp_id: str = None,
        ext_info: str = None,
        gmt_trade_create: str = None,
        gmt_trade_finish: str = None,
        merchant_name: str = None,
        pay_channel_detail_list: List[NotifyBadgeCodePayResultRequestPayChannelDetailList] = None,
        pay_code: str = None,
        promotion_amount: str = None,
        remark: str = None,
        title: str = None,
        trade_error_code: str = None,
        trade_error_msg: str = None,
        trade_no: str = None,
        trade_status: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.charge_amount = charge_amount
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_trade_create = gmt_trade_create
        # This parameter is required.
        self.gmt_trade_finish = gmt_trade_finish
        # This parameter is required.
        self.merchant_name = merchant_name
        # This parameter is required.
        self.pay_channel_detail_list = pay_channel_detail_list
        # This parameter is required.
        self.pay_code = pay_code
        # This parameter is required.
        self.promotion_amount = promotion_amount
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.title = title
        self.trade_error_code = trade_error_code
        self.trade_error_msg = trade_error_msg
        # This parameter is required.
        self.trade_no = trade_no
        # This parameter is required.
        self.trade_status = trade_status
        # This parameter is required.
        self.user_id = user_id

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
        if self.amount is not None:
            result['amount'] = self.amount
        if self.charge_amount is not None:
            result['chargeAmount'] = self.charge_amount
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_trade_create is not None:
            result['gmtTradeCreate'] = self.gmt_trade_create
        if self.gmt_trade_finish is not None:
            result['gmtTradeFinish'] = self.gmt_trade_finish
        if self.merchant_name is not None:
            result['merchantName'] = self.merchant_name
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.title is not None:
            result['title'] = self.title
        if self.trade_error_code is not None:
            result['tradeErrorCode'] = self.trade_error_code
        if self.trade_error_msg is not None:
            result['tradeErrorMsg'] = self.trade_error_msg
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.trade_status is not None:
            result['tradeStatus'] = self.trade_status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('chargeAmount') is not None:
            self.charge_amount = m.get('chargeAmount')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtTradeCreate') is not None:
            self.gmt_trade_create = m.get('gmtTradeCreate')
        if m.get('gmtTradeFinish') is not None:
            self.gmt_trade_finish = m.get('gmtTradeFinish')
        if m.get('merchantName') is not None:
            self.merchant_name = m.get('merchantName')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyBadgeCodePayResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('tradeErrorCode') is not None:
            self.trade_error_code = m.get('tradeErrorCode')
        if m.get('tradeErrorMsg') is not None:
            self.trade_error_msg = m.get('tradeErrorMsg')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('tradeStatus') is not None:
            self.trade_status = m.get('tradeStatus')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class NotifyBadgeCodePayResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class NotifyBadgeCodePayResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyBadgeCodePayResultResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = NotifyBadgeCodePayResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyBadgeCodeRefundResultHeaders(TeaModel):
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


class NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class NotifyBadgeCodeRefundResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_list: List[NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList] = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_refund_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_list = fund_tool_detail_list
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_refund_order_no = pay_channel_refund_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

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
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_refund_order_no is not None:
            result['payChannelRefundOrderNo'] = self.pay_channel_refund_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelRefundOrderNo') is not None:
            self.pay_channel_refund_order_no = m.get('payChannelRefundOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class NotifyBadgeCodeRefundResultRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_refund: str = None,
        pay_channel_detail_list: List[NotifyBadgeCodeRefundResultRequestPayChannelDetailList] = None,
        pay_code: str = None,
        refund_amount: str = None,
        refund_order_no: str = None,
        refund_promotion_amount: str = None,
        remark: str = None,
        trade_no: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.gmt_refund = gmt_refund
        # This parameter is required.
        self.pay_channel_detail_list = pay_channel_detail_list
        # This parameter is required.
        self.pay_code = pay_code
        # This parameter is required.
        self.refund_amount = refund_amount
        # This parameter is required.
        self.refund_order_no = refund_order_no
        # This parameter is required.
        self.refund_promotion_amount = refund_promotion_amount
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.trade_no = trade_no
        # This parameter is required.
        self.user_id = user_id

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
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.refund_order_no is not None:
            result['refundOrderNo'] = self.refund_order_no
        if self.refund_promotion_amount is not None:
            result['refundPromotionAmount'] = self.refund_promotion_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyBadgeCodeRefundResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('refundOrderNo') is not None:
            self.refund_order_no = m.get('refundOrderNo')
        if m.get('refundPromotionAmount') is not None:
            self.refund_promotion_amount = m.get('refundPromotionAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class NotifyBadgeCodeRefundResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class NotifyBadgeCodeRefundResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyBadgeCodeRefundResultResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = NotifyBadgeCodeRefundResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyBadgeCodeVerifyResultHeaders(TeaModel):
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


class NotifyBadgeCodeVerifyResultRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        pay_code: str = None,
        remark: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
        verify_event: str = None,
        verify_location: str = None,
        verify_no: str = None,
        verify_result: bool = None,
        verify_time: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.pay_code = pay_code
        self.remark = remark
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity
        self.verify_event = verify_event
        self.verify_location = verify_location
        self.verify_no = verify_no
        # This parameter is required.
        self.verify_result = verify_result
        # This parameter is required.
        self.verify_time = verify_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        if self.verify_event is not None:
            result['verifyEvent'] = self.verify_event
        if self.verify_location is not None:
            result['verifyLocation'] = self.verify_location
        if self.verify_no is not None:
            result['verifyNo'] = self.verify_no
        if self.verify_result is not None:
            result['verifyResult'] = self.verify_result
        if self.verify_time is not None:
            result['verifyTime'] = self.verify_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        if m.get('verifyEvent') is not None:
            self.verify_event = m.get('verifyEvent')
        if m.get('verifyLocation') is not None:
            self.verify_location = m.get('verifyLocation')
        if m.get('verifyNo') is not None:
            self.verify_no = m.get('verifyNo')
        if m.get('verifyResult') is not None:
            self.verify_result = m.get('verifyResult')
        if m.get('verifyTime') is not None:
            self.verify_time = m.get('verifyTime')
        return self


class NotifyBadgeCodeVerifyResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class NotifyBadgeCodeVerifyResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyBadgeCodeVerifyResultResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = NotifyBadgeCodeVerifyResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveBadgeCodeCorpInstanceHeaders(TeaModel):
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


class SaveBadgeCodeCorpInstanceRequest(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        ext_info: Dict[str, str] = None,
        status: str = None,
    ):
        # This parameter is required.
        self.code_identity = code_identity
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_info = ext_info
        # This parameter is required.
        self.status = status

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
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SaveBadgeCodeCorpInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        ext_info: Dict[str, str] = None,
        status: str = None,
    ):
        self.code_identity = code_identity
        self.corp_id = corp_id
        self.ext_info = ext_info
        self.status = status

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
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SaveBadgeCodeCorpInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveBadgeCodeCorpInstanceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = SaveBadgeCodeCorpInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateBadgeCodeUserInstanceHeaders(TeaModel):
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


class UpdateBadgeCodeUserInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_end: str = None,
        gmt_start: str = None,
    ):
        # This parameter is required.
        self.gmt_end = gmt_end
        # This parameter is required.
        self.gmt_start = gmt_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        return self


class UpdateBadgeCodeUserInstanceRequest(TeaModel):
    def __init__(
        self,
        available_times: List[UpdateBadgeCodeUserInstanceRequestAvailableTimes] = None,
        code_id: str = None,
        code_identity: str = None,
        code_value: str = None,
        corp_id: str = None,
        ext_info: Dict[str, Any] = None,
        gmt_expired: str = None,
        status: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
    ):
        # This parameter is required.
        self.available_times = available_times
        # This parameter is required.
        self.code_id = code_id
        # This parameter is required.
        self.code_identity = code_identity
        self.code_value = code_value
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_expired = gmt_expired
        self.status = status
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity

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
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        if self.status is not None:
            result['status'] = self.status
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = UpdateBadgeCodeUserInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        return self


class UpdateBadgeCodeUserInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_id: str = None,
    ):
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


class UpdateBadgeCodeUserInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateBadgeCodeUserInstanceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateBadgeCodeUserInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


