# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class AddCateringCommentHeaders(TeaModel):
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


class AddCateringCommentRequest(TeaModel):
    def __init__(
        self,
        comment_id: str = None,
        order_id: str = None,
        rate_content: str = None,
        rated_at: int = None,
        rating: int = None,
        shop_id: str = None,
        source: str = None,
        status: int = None,
    ):
        # This parameter is required.
        self.comment_id = comment_id
        self.order_id = order_id
        self.rate_content = rate_content
        self.rated_at = rated_at
        self.rating = rating
        # This parameter is required.
        self.shop_id = shop_id
        # This parameter is required.
        self.source = source
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_id is not None:
            result['commentId'] = self.comment_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.rate_content is not None:
            result['rateContent'] = self.rate_content
        if self.rated_at is not None:
            result['ratedAt'] = self.rated_at
        if self.rating is not None:
            result['rating'] = self.rating
        if self.shop_id is not None:
            result['shopId'] = self.shop_id
        if self.source is not None:
            result['source'] = self.source
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentId') is not None:
            self.comment_id = m.get('commentId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('rateContent') is not None:
            self.rate_content = m.get('rateContent')
        if m.get('ratedAt') is not None:
            self.rated_at = m.get('ratedAt')
        if m.get('rating') is not None:
            self.rating = m.get('rating')
        if m.get('shopId') is not None:
            self.shop_id = m.get('shopId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class AddCateringCommentResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: str = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddCateringCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddCateringCommentResponseBody = None,
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
            temp_model = AddCateringCommentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


