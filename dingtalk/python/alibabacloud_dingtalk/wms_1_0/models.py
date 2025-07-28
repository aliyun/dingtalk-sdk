# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryGoodsListHeaders(TeaModel):
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


class QueryGoodsListRequest(TeaModel):
    def __init__(
        self,
        end_time_in_mills: int = None,
        max_results: int = None,
        next_token: int = None,
        start_time_in_mills: int = None,
    ):
        self.end_time_in_mills = end_time_in_mills
        self.max_results = max_results
        self.next_token = next_token
        self.start_time_in_mills = start_time_in_mills

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time_in_mills is not None:
            result['endTimeInMills'] = self.end_time_in_mills
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.start_time_in_mills is not None:
            result['startTimeInMills'] = self.start_time_in_mills
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTimeInMills') is not None:
            self.end_time_in_mills = m.get('endTimeInMills')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('startTimeInMills') is not None:
            self.start_time_in_mills = m.get('startTimeInMills')
        return self


class QueryGoodsListResponseBodyResultList(TeaModel):
    def __init__(
        self,
        goods_name: str = None,
        goods_no: str = None,
        instance_id: str = None,
        product_specs: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.goods_name = goods_name
        # This parameter is required.
        self.goods_no = goods_no
        # This parameter is required.
        self.instance_id = instance_id
        # This parameter is required.
        self.product_specs = product_specs
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.goods_no is not None:
            result['goodsNo'] = self.goods_no
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.product_specs is not None:
            result['productSpecs'] = self.product_specs
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('goodsNo') is not None:
            self.goods_no = m.get('goodsNo')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('productSpecs') is not None:
            self.product_specs = m.get('productSpecs')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryGoodsListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryGoodsListResponseBodyResultList] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        self.list = list
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryGoodsListResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryGoodsListResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryGoodsListResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryGoodsListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryGoodsListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGoodsListResponseBody = None,
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
            temp_model = QueryGoodsListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


