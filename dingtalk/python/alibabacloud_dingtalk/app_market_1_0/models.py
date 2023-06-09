# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class CreateAppGoodsServiceConversationHeaders(TeaModel):
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


class CreateAppGoodsServiceConversationRequest(TeaModel):
    def __init__(
        self,
        isv_user_id: str = None,
        order_id: int = None,
    ):
        self.isv_user_id = isv_user_id
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_user_id is not None:
            result['isvUserId'] = self.isv_user_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvUserId') is not None:
            self.isv_user_id = m.get('isvUserId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class CreateAppGoodsServiceConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_name: str = None,
        new_conversation: bool = None,
    ):
        self.conversation_name = conversation_name
        self.new_conversation = new_conversation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_name is not None:
            result['conversationName'] = self.conversation_name
        if self.new_conversation is not None:
            result['newConversation'] = self.new_conversation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationName') is not None:
            self.conversation_name = m.get('conversationName')
        if m.get('newConversation') is not None:
            self.new_conversation = m.get('newConversation')
        return self


class CreateAppGoodsServiceConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAppGoodsServiceConversationResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = CreateAppGoodsServiceConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCoolAppAccessStatusHeaders(TeaModel):
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


class GetCoolAppAccessStatusRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        cool_app_code: str = None,
        enc_field_biz_code: str = None,
    ):
        self.auth_code = auth_code
        self.cool_app_code = cool_app_code
        self.enc_field_biz_code = enc_field_biz_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.enc_field_biz_code is not None:
            result['encFieldBizCode'] = self.enc_field_biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('encFieldBizCode') is not None:
            self.enc_field_biz_code = m.get('encFieldBizCode')
        return self


class GetCoolAppAccessStatusResponseBody(TeaModel):
    def __init__(
        self,
        status: str = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetCoolAppAccessStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCoolAppAccessStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetCoolAppAccessStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInAppSkuUrlHeaders(TeaModel):
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


class GetInAppSkuUrlRequest(TeaModel):
    def __init__(
        self,
        callback_page: str = None,
        extend_param: str = None,
        goods_code: str = None,
        item_code: str = None,
    ):
        self.callback_page = callback_page
        self.extend_param = extend_param
        self.goods_code = goods_code
        self.item_code = item_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_page is not None:
            result['callbackPage'] = self.callback_page
        if self.extend_param is not None:
            result['extendParam'] = self.extend_param
        if self.goods_code is not None:
            result['goodsCode'] = self.goods_code
        if self.item_code is not None:
            result['itemCode'] = self.item_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackPage') is not None:
            self.callback_page = m.get('callbackPage')
        if m.get('extendParam') is not None:
            self.extend_param = m.get('extendParam')
        if m.get('goodsCode') is not None:
            self.goods_code = m.get('goodsCode')
        if m.get('itemCode') is not None:
            self.item_code = m.get('itemCode')
        return self


class GetInAppSkuUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetInAppSkuUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInAppSkuUrlResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetInAppSkuUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPersonalExperienceInfoHeaders(TeaModel):
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


class GetPersonalExperienceInfoRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetPersonalExperienceInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        main_corp_id: str = None,
    ):
        self.main_corp_id = main_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.main_corp_id is not None:
            result['mainCorpId'] = self.main_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mainCorpId') is not None:
            self.main_corp_id = m.get('mainCorpId')
        return self


class GetPersonalExperienceInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetPersonalExperienceInfoResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetPersonalExperienceInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetPersonalExperienceInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPersonalExperienceInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetPersonalExperienceInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMarketOrderHeaders(TeaModel):
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


class QueryMarketOrderResponseBody(TeaModel):
    def __init__(
        self,
        biz_order_id: int = None,
        corp_id: str = None,
        create_timestamp: int = None,
        end_timestamp: int = None,
        goods_code: str = None,
        goods_name: str = None,
        in_app_order: bool = None,
        item_code: str = None,
        item_name: str = None,
        paid_timestamp: int = None,
        quantity: int = None,
        start_timestamp: int = None,
        status: int = None,
        total_actual_pay_fee: int = None,
    ):
        self.biz_order_id = biz_order_id
        self.corp_id = corp_id
        self.create_timestamp = create_timestamp
        self.end_timestamp = end_timestamp
        self.goods_code = goods_code
        self.goods_name = goods_name
        self.in_app_order = in_app_order
        self.item_code = item_code
        self.item_name = item_name
        self.paid_timestamp = paid_timestamp
        self.quantity = quantity
        self.start_timestamp = start_timestamp
        self.status = status
        self.total_actual_pay_fee = total_actual_pay_fee

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_order_id is not None:
            result['bizOrderId'] = self.biz_order_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_timestamp is not None:
            result['createTimestamp'] = self.create_timestamp
        if self.end_timestamp is not None:
            result['endTimestamp'] = self.end_timestamp
        if self.goods_code is not None:
            result['goodsCode'] = self.goods_code
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.in_app_order is not None:
            result['inAppOrder'] = self.in_app_order
        if self.item_code is not None:
            result['itemCode'] = self.item_code
        if self.item_name is not None:
            result['itemName'] = self.item_name
        if self.paid_timestamp is not None:
            result['paidTimestamp'] = self.paid_timestamp
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.start_timestamp is not None:
            result['startTimestamp'] = self.start_timestamp
        if self.status is not None:
            result['status'] = self.status
        if self.total_actual_pay_fee is not None:
            result['totalActualPayFee'] = self.total_actual_pay_fee
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizOrderId') is not None:
            self.biz_order_id = m.get('bizOrderId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTimestamp') is not None:
            self.create_timestamp = m.get('createTimestamp')
        if m.get('endTimestamp') is not None:
            self.end_timestamp = m.get('endTimestamp')
        if m.get('goodsCode') is not None:
            self.goods_code = m.get('goodsCode')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('inAppOrder') is not None:
            self.in_app_order = m.get('inAppOrder')
        if m.get('itemCode') is not None:
            self.item_code = m.get('itemCode')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        if m.get('paidTimestamp') is not None:
            self.paid_timestamp = m.get('paidTimestamp')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('startTimestamp') is not None:
            self.start_timestamp = m.get('startTimestamp')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('totalActualPayFee') is not None:
            self.total_actual_pay_fee = m.get('totalActualPayFee')
        return self


class QueryMarketOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMarketOrderResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryMarketOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UserTaskReportHeaders(TeaModel):
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


class UserTaskReportRequest(TeaModel):
    def __init__(
        self,
        biz_no: str = None,
        operate_date: str = None,
        task_tag: str = None,
        userid: str = None,
    ):
        self.biz_no = biz_no
        self.operate_date = operate_date
        self.task_tag = task_tag
        self.userid = userid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_no is not None:
            result['bizNo'] = self.biz_no
        if self.operate_date is not None:
            result['operateDate'] = self.operate_date
        if self.task_tag is not None:
            result['taskTag'] = self.task_tag
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizNo') is not None:
            self.biz_no = m.get('bizNo')
        if m.get('operateDate') is not None:
            self.operate_date = m.get('operateDate')
        if m.get('taskTag') is not None:
            self.task_tag = m.get('taskTag')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        return self


class UserTaskReportResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: bool = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')

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
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


