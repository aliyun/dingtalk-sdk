# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class QueryTradeOrderHeaders(TeaModel):
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


class QueryTradeOrderRequest(TeaModel):
    def __init__(
        self,
        outer_order_id: str = None,
        order_id: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
    ):
        # 外部订单号
        self.outer_order_id = outer_order_id
        # 内部订单号
        self.order_id = order_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.outer_order_id is not None:
            result['outerOrderId'] = self.outer_order_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerOrderId') is not None:
            self.outer_order_id = m.get('outerOrderId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class QueryTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        isv_crop_id: str = None,
        article_name: str = None,
        article_code: str = None,
        article_item_name: str = None,
        article_item_code: str = None,
        quantity: int = None,
        outer_order_id: str = None,
        order_id: int = None,
        fee: int = None,
        pay_fee: int = None,
        create_time: int = None,
        refund_time: int = None,
        close_time: int = None,
        pay_time: int = None,
        status: int = None,
    ):
        # ISV的组织ID
        self.isv_crop_id = isv_crop_id
        # 商品名称
        self.article_name = article_name
        # 商品编码
        self.article_code = article_code
        # 规格名称
        self.article_item_name = article_item_name
        # 规格编码
        self.article_item_code = article_item_code
        # 商品数量
        self.quantity = quantity
        # 外部订单号
        self.outer_order_id = outer_order_id
        # 内部订单号
        self.order_id = order_id
        # 原价（单位：分）
        self.fee = fee
        # 实际支付的价格（单位：分）
        self.pay_fee = pay_fee
        # 订单创建时间（单位：ms）
        self.create_time = create_time
        # 订单退款时间（单位：ms）
        self.refund_time = refund_time
        # 订单关闭时间（单位：ms）
        self.close_time = close_time
        # 订单支付时间（单位：ms）
        self.pay_time = pay_time
        # 订单状态：-1表示已关闭、0表示未支付、1表示已支付、2表示已退款
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_crop_id is not None:
            result['isvCropId'] = self.isv_crop_id
        if self.article_name is not None:
            result['articleName'] = self.article_name
        if self.article_code is not None:
            result['articleCode'] = self.article_code
        if self.article_item_name is not None:
            result['articleItemName'] = self.article_item_name
        if self.article_item_code is not None:
            result['articleItemCode'] = self.article_item_code
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.outer_order_id is not None:
            result['outerOrderId'] = self.outer_order_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.fee is not None:
            result['fee'] = self.fee
        if self.pay_fee is not None:
            result['payFee'] = self.pay_fee
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.refund_time is not None:
            result['refundTime'] = self.refund_time
        if self.close_time is not None:
            result['closeTime'] = self.close_time
        if self.pay_time is not None:
            result['payTime'] = self.pay_time
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvCropId') is not None:
            self.isv_crop_id = m.get('isvCropId')
        if m.get('articleName') is not None:
            self.article_name = m.get('articleName')
        if m.get('articleCode') is not None:
            self.article_code = m.get('articleCode')
        if m.get('articleItemName') is not None:
            self.article_item_name = m.get('articleItemName')
        if m.get('articleItemCode') is not None:
            self.article_item_code = m.get('articleItemCode')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('outerOrderId') is not None:
            self.outer_order_id = m.get('outerOrderId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('fee') is not None:
            self.fee = m.get('fee')
        if m.get('payFee') is not None:
            self.pay_fee = m.get('payFee')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('refundTime') is not None:
            self.refund_time = m.get('refundTime')
        if m.get('closeTime') is not None:
            self.close_time = m.get('closeTime')
        if m.get('payTime') is not None:
            self.pay_time = m.get('payTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryTradeOrderResponseBody = None,
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
            temp_model = QueryTradeOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


