# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


class CloseDataDeliverHeaders(TeaModel):
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


class CloseDataDeliverRequest(TeaModel):
    def __init__(
        self,
        deliver_id: str = None,
        dispatching_item_type: str = None,
    ):
        self.deliver_id = deliver_id
        self.dispatching_item_type = dispatching_item_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deliver_id is not None:
            result['deliverId'] = self.deliver_id
        if self.dispatching_item_type is not None:
            result['dispatchingItemType'] = self.dispatching_item_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deliverId') is not None:
            self.deliver_id = m.get('deliverId')
        if m.get('dispatchingItemType') is not None:
            self.dispatching_item_type = m.get('dispatchingItemType')
        return self


class CloseDataDeliverResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CloseDataDeliverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CloseDataDeliverResponseBody = None,
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
            temp_model = CloseDataDeliverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateDataDeliverHeaders(TeaModel):
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


class CreateDataDeliverRequest(TeaModel):
    def __init__(
        self,
        bizcode: str = None,
        param: str = None,
        user_id: str = None,
        dispatching_cycle: str = None,
        dispatching_item_type: str = None,
        dispatching_start_date: int = None,
    ):
        self.bizcode = bizcode
        self.param = param
        self.user_id = user_id
        self.dispatching_cycle = dispatching_cycle
        self.dispatching_item_type = dispatching_item_type
        self.dispatching_start_date = dispatching_start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bizcode is not None:
            result['bizcode'] = self.bizcode
        if self.param is not None:
            result['param'] = self.param
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.dispatching_cycle is not None:
            result['dispatchingCycle'] = self.dispatching_cycle
        if self.dispatching_item_type is not None:
            result['dispatchingItemType'] = self.dispatching_item_type
        if self.dispatching_start_date is not None:
            result['dispatchingStartDate'] = self.dispatching_start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizcode') is not None:
            self.bizcode = m.get('bizcode')
        if m.get('param') is not None:
            self.param = m.get('param')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('dispatchingCycle') is not None:
            self.dispatching_cycle = m.get('dispatchingCycle')
        if m.get('dispatchingItemType') is not None:
            self.dispatching_item_type = m.get('dispatchingItemType')
        if m.get('dispatchingStartDate') is not None:
            self.dispatching_start_date = m.get('dispatchingStartDate')
        return self


class CreateDataDeliverResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateDataDeliverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateDataDeliverResponseBody = None,
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
            temp_model = CreateDataDeliverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateScreenHeaders(TeaModel):
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


class CreateScreenRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        template_id: str = None,
    ):
        self.operator_id = operator_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class CreateScreenResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateScreenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateScreenResponseBody = None,
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
            temp_model = CreateScreenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DataMarketIsvServiceHeaders(TeaModel):
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


class DataMarketIsvServiceRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        api_id: str = None,
        args: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        # This parameter is required.
        self.api_id = api_id
        # This parameter is required.
        self.args = args
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.api_id is not None:
            result['apiId'] = self.api_id
        if self.args is not None:
            result['args'] = self.args
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('apiId') is not None:
            self.api_id = m.get('apiId')
        if m.get('args') is not None:
            self.args = m.get('args')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DataMarketIsvServiceResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        data: str = None,
        msg: str = None,
    ):
        self.code = code
        self.data = data
        self.msg = msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.msg is not None:
            result['msg'] = self.msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        return self


class DataMarketIsvServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DataMarketIsvServiceResponseBody = None,
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
            temp_model = DataMarketIsvServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DataMarketServiceHeaders(TeaModel):
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


class DataMarketServiceRequest(TeaModel):
    def __init__(
        self,
        api_id: str = None,
        args: str = None,
    ):
        self.api_id = api_id
        self.args = args

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_id is not None:
            result['apiId'] = self.api_id
        if self.args is not None:
            result['args'] = self.args
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiId') is not None:
            self.api_id = m.get('apiId')
        if m.get('args') is not None:
            self.args = m.get('args')
        return self


class DataMarketServiceResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        data: str = None,
        msg: str = None,
        total_quota: int = None,
        used_quota: int = None,
    ):
        self.code = code
        self.data = data
        self.msg = msg
        self.total_quota = total_quota
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.msg is not None:
            result['msg'] = self.msg
        if self.total_quota is not None:
            result['totalQuota'] = self.total_quota
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('totalQuota') is not None:
            self.total_quota = m.get('totalQuota')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class DataMarketServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DataMarketServiceResponseBody = None,
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
            temp_model = DataMarketServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAbnormalOperationHeaders(TeaModel):
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


class GetAbnormalOperationRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetAbnormalOperationResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetAbnormalOperationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAbnormalOperationResponseBody = None,
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
            temp_model = GetAbnormalOperationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAdministrativeLicensingHeaders(TeaModel):
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


class GetAdministrativeLicensingRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetAdministrativeLicensingResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetAdministrativeLicensingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAdministrativeLicensingResponseBody = None,
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
            temp_model = GetAdministrativeLicensingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAdministrativePenaltiesHeaders(TeaModel):
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


class GetAdministrativePenaltiesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetAdministrativePenaltiesResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetAdministrativePenaltiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAdministrativePenaltiesResponseBody = None,
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
            temp_model = GetAdministrativePenaltiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBasicInfoHeaders(TeaModel):
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


class GetBasicInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetBasicInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetBasicInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBasicInfoResponseBody = None,
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
            temp_model = GetBasicInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBiddingInfoHeaders(TeaModel):
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


class GetBiddingInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetBiddingInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetBiddingInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBiddingInfoResponseBody = None,
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
            temp_model = GetBiddingInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBranchInfoHeaders(TeaModel):
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


class GetBranchInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetBranchInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetBranchInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBranchInfoResponseBody = None,
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
            temp_model = GetBranchInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetChangeRecordHeaders(TeaModel):
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


class GetChangeRecordRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetChangeRecordResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetChangeRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetChangeRecordResponseBody = None,
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
            temp_model = GetChangeRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDataDeliverHeaders(TeaModel):
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


class GetDataDeliverRequest(TeaModel):
    def __init__(
        self,
        deliver_id: str = None,
        dispatching_item_type: str = None,
    ):
        self.deliver_id = deliver_id
        self.dispatching_item_type = dispatching_item_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deliver_id is not None:
            result['deliverId'] = self.deliver_id
        if self.dispatching_item_type is not None:
            result['dispatchingItemType'] = self.dispatching_item_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deliverId') is not None:
            self.deliver_id = m.get('deliverId')
        if m.get('dispatchingItemType') is not None:
            self.dispatching_item_type = m.get('dispatchingItemType')
        return self


class GetDataDeliverResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetDataDeliverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDataDeliverResponseBody = None,
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
            temp_model = GetDataDeliverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDomainInfoHeaders(TeaModel):
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


class GetDomainInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetDomainInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetDomainInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDomainInfoResponseBody = None,
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
            temp_model = GetDomainInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDoubleRandomHeaders(TeaModel):
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


class GetDoubleRandomRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetDoubleRandomResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetDoubleRandomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDoubleRandomResponseBody = None,
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
            temp_model = GetDoubleRandomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEnvironmentalPenaltiesHeaders(TeaModel):
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


class GetEnvironmentalPenaltiesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetEnvironmentalPenaltiesResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetEnvironmentalPenaltiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEnvironmentalPenaltiesResponseBody = None,
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
            temp_model = GetEnvironmentalPenaltiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEventDataHeaders(TeaModel):
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


class GetEventDataRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        event_uid: str = None,
        sub_id: str = None,
    ):
        self.biz_id = biz_id
        # This parameter is required.
        self.event_uid = event_uid
        self.sub_id = sub_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.event_uid is not None:
            result['eventUid'] = self.event_uid
        if self.sub_id is not None:
            result['subId'] = self.sub_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('eventUid') is not None:
            self.event_uid = m.get('eventUid')
        if m.get('subId') is not None:
            self.sub_id = m.get('subId')
        return self


class GetEventDataResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
        value: Dict[str, Any] = None,
    ):
        self.success = success
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetEventDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEventDataResponseBody = None,
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
            temp_model = GetEventDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetHolderInfoHeaders(TeaModel):
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


class GetHolderInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetHolderInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetHolderInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetHolderInfoResponseBody = None,
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
            temp_model = GetHolderInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetIntellectualPropertyHeaders(TeaModel):
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


class GetIntellectualPropertyRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetIntellectualPropertyResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetIntellectualPropertyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetIntellectualPropertyResponseBody = None,
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
            temp_model = GetIntellectualPropertyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInvestmentAbroadHeaders(TeaModel):
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


class GetInvestmentAbroadRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetInvestmentAbroadResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetInvestmentAbroadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInvestmentAbroadResponseBody = None,
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
            temp_model = GetInvestmentAbroadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetJobInfoHeaders(TeaModel):
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


class GetJobInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetJobInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetJobInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetJobInfoResponseBody = None,
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
            temp_model = GetJobInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPatentInfoHeaders(TeaModel):
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


class GetPatentInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetPatentInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetPatentInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPatentInfoResponseBody = None,
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
            temp_model = GetPatentInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPrincipalEmployeeHeaders(TeaModel):
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


class GetPrincipalEmployeeRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetPrincipalEmployeeResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetPrincipalEmployeeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPrincipalEmployeeResponseBody = None,
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
            temp_model = GetPrincipalEmployeeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetQeneralTaxpayerInfoHeaders(TeaModel):
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


class GetQeneralTaxpayerInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetQeneralTaxpayerInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetQeneralTaxpayerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetQeneralTaxpayerInfoResponseBody = None,
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
            temp_model = GetQeneralTaxpayerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetQualificationCertHeaders(TeaModel):
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


class GetQualificationCertRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetQualificationCertResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetQualificationCertResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetQualificationCertResponseBody = None,
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
            temp_model = GetQualificationCertResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSeriousViolationHeaders(TeaModel):
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


class GetSeriousViolationRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetSeriousViolationResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetSeriousViolationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSeriousViolationResponseBody = None,
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
            temp_model = GetSeriousViolationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSoftwareCopyrightHeaders(TeaModel):
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


class GetSoftwareCopyrightRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetSoftwareCopyrightResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetSoftwareCopyrightResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSoftwareCopyrightResponseBody = None,
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
            temp_model = GetSoftwareCopyrightResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTrademarkInfoHeaders(TeaModel):
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


class GetTrademarkInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetTrademarkInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetTrademarkInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTrademarkInfoResponseBody = None,
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
            temp_model = GetTrademarkInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWorkCopyrightHeaders(TeaModel):
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


class GetWorkCopyrightRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class GetWorkCopyrightResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetWorkCopyrightResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWorkCopyrightResponseBody = None,
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
            temp_model = GetWorkCopyrightResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListDataDeliversHeaders(TeaModel):
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


class ListDataDeliversRequest(TeaModel):
    def __init__(
        self,
        dispatching_item_type: str = None,
    ):
        self.dispatching_item_type = dispatching_item_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dispatching_item_type is not None:
            result['dispatchingItemType'] = self.dispatching_item_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dispatchingItemType') is not None:
            self.dispatching_item_type = m.get('dispatchingItemType')
        return self


class ListDataDeliversResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListDataDeliversResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListDataDeliversResponseBody = None,
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
            temp_model = ListDataDeliversResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OperateChartConfigHeaders(TeaModel):
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


class OperateChartConfigRequest(TeaModel):
    def __init__(
        self,
        api_key: str = None,
        corp_id: str = None,
        param: Dict[str, Any] = None,
        ticket: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.api_key = api_key
        # This parameter is required.
        self.corp_id = corp_id
        self.param = param
        # This parameter is required.
        self.ticket = ticket
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_key is not None:
            result['apiKey'] = self.api_key
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.param is not None:
            result['param'] = self.param
        if self.ticket is not None:
            result['ticket'] = self.ticket
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiKey') is not None:
            self.api_key = m.get('apiKey')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('param') is not None:
            self.param = m.get('param')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OperateChartConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: Dict[str, str] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OperateChartConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OperateChartConfigResponseBody = None,
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
            temp_model = OperateChartConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PostCorpAuthInfoHeaders(TeaModel):
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


class PostCorpAuthInfoResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PostCorpAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PostCorpAuthInfoResponseBody = None,
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
            temp_model = PostCorpAuthInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryActiveUserStatisticalDataHeaders(TeaModel):
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


class QueryActiveUserStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryActiveUserStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryActiveUserStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryActiveUserStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryActiveUserStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryActiveUserStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryActiveUserStatisticalDataResponseBody = None,
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
            temp_model = QueryActiveUserStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAnhmdStatisticalDataHeaders(TeaModel):
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


class QueryAnhmdStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryAnhmdStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryAnhmdStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryAnhmdStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryAnhmdStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryAnhmdStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAnhmdStatisticalDataResponseBody = None,
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
            temp_model = QueryAnhmdStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryApprovalStatisticalDataHeaders(TeaModel):
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


class QueryApprovalStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryApprovalStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryApprovalStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryApprovalStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryApprovalStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryApprovalStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryApprovalStatisticalDataResponseBody = None,
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
            temp_model = QueryApprovalStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAttendanceStatisticalDataHeaders(TeaModel):
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


class QueryAttendanceStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryAttendanceStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryAttendanceStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryAttendanceStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryAttendanceStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryAttendanceStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAttendanceStatisticalDataResponseBody = None,
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
            temp_model = QueryAttendanceStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBlackboardStatisticalDataHeaders(TeaModel):
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


class QueryBlackboardStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryBlackboardStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryBlackboardStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryBlackboardStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryBlackboardStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryBlackboardStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBlackboardStatisticalDataResponseBody = None,
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
            temp_model = QueryBlackboardStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCalendarStatisticalDataHeaders(TeaModel):
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


class QueryCalendarStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCalendarStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryCalendarStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCalendarStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCalendarStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCalendarStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCalendarStatisticalDataResponseBody = None,
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
            temp_model = QueryCalendarStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryChartDataHeaders(TeaModel):
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


class QueryChartDataRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        ticket: str = None,
    ):
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class QueryChartDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[Any] = None,
        success: str = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryChartDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryChartDataResponseBody = None,
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
            temp_model = QueryChartDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCheckinStatisticalDataHeaders(TeaModel):
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


class QueryCheckinStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCheckinStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryCheckinStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCheckinStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCheckinStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCheckinStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCheckinStatisticalDataResponseBody = None,
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
            temp_model = QueryCheckinStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCircleStatisticalDataHeaders(TeaModel):
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


class QueryCircleStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCircleStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryCircleStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCircleStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCircleStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCircleStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCircleStatisticalDataResponseBody = None,
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
            temp_model = QueryCircleStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCompanyBasicInfoHeaders(TeaModel):
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


class QueryCompanyBasicInfoRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.keyword = keyword
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryCompanyBasicInfoResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        data: List[Dict[str, str]] = None,
        message: str = None,
        request_id: str = None,
        total: int = None,
    ):
        self.code = code
        self.data = data
        self.message = message
        self.request_id = request_id
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.message is not None:
            result['message'] = self.message
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryCompanyBasicInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCompanyBasicInfoResponseBody = None,
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
            temp_model = QueryCompanyBasicInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDigitalDistrictOrgInfoHeaders(TeaModel):
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


class QueryDigitalDistrictOrgInfoRequest(TeaModel):
    def __init__(
        self,
        corp_ids: List[str] = None,
        stat_dates: List[str] = None,
    ):
        # This parameter is required.
        self.corp_ids = corp_ids
        # This parameter is required.
        self.stat_dates = stat_dates

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_ids is not None:
            result['corpIds'] = self.corp_ids
        if self.stat_dates is not None:
            result['statDates'] = self.stat_dates
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIds') is not None:
            self.corp_ids = m.get('corpIds')
        if m.get('statDates') is not None:
            self.stat_dates = m.get('statDates')
        return self


class QueryDigitalDistrictOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        arguments: List[str] = None,
        result: str = None,
    ):
        self.arguments = arguments
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arguments is not None:
            result['arguments'] = self.arguments
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arguments') is not None:
            self.arguments = m.get('arguments')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class QueryDigitalDistrictOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDigitalDistrictOrgInfoResponseBody = None,
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
            temp_model = QueryDigitalDistrictOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDingReciveStatisticalDataHeaders(TeaModel):
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


class QueryDingReciveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDingReciveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryDingReciveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDingReciveStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDingReciveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDingReciveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDingReciveStatisticalDataResponseBody = None,
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
            temp_model = QueryDingReciveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDingSendStatisticalDataHeaders(TeaModel):
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


class QueryDingSendStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDingSendStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryDingSendStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDingSendStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDingSendStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDingSendStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDingSendStatisticalDataResponseBody = None,
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
            temp_model = QueryDingSendStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDocumentStatisticalDataHeaders(TeaModel):
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


class QueryDocumentStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDocumentStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryDocumentStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDocumentStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDocumentStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDocumentStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDocumentStatisticalDataResponseBody = None,
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
            temp_model = QueryDocumentStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDpaasDataPackageHeaders(TeaModel):
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


class QueryDpaasDataPackageResponseBody(TeaModel):
    def __init__(
        self,
        buy: bool = None,
        end_date: str = None,
        quota: int = None,
        start_date: str = None,
        success: bool = None,
        used_num: int = None,
        white_customer: bool = None,
    ):
        self.buy = buy
        self.end_date = end_date
        self.quota = quota
        self.start_date = start_date
        self.success = success
        self.used_num = used_num
        self.white_customer = white_customer

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.buy is not None:
            result['buy'] = self.buy
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.quota is not None:
            result['quota'] = self.quota
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.success is not None:
            result['success'] = self.success
        if self.used_num is not None:
            result['usedNum'] = self.used_num
        if self.white_customer is not None:
            result['whiteCustomer'] = self.white_customer
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buy') is not None:
            self.buy = m.get('buy')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('usedNum') is not None:
            self.used_num = m.get('usedNum')
        if m.get('whiteCustomer') is not None:
            self.white_customer = m.get('whiteCustomer')
        return self


class QueryDpaasDataPackageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDpaasDataPackageResponseBody = None,
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
            temp_model = QueryDpaasDataPackageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDriveStatisticalDataHeaders(TeaModel):
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


class QueryDriveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDriveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryDriveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDriveStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDriveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDriveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDriveStatisticalDataResponseBody = None,
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
            temp_model = QueryDriveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEmployeeTypeStatisticalDataHeaders(TeaModel):
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


class QueryEmployeeTypeStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryEmployeeTypeStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryEmployeeTypeStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryEmployeeTypeStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryEmployeeTypeStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryEmployeeTypeStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryEmployeeTypeStatisticalDataResponseBody = None,
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
            temp_model = QueryEmployeeTypeStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGeneralDataServiceHeaders(TeaModel):
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


class QueryGeneralDataServiceRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        end_date: str = None,
        page_number: int = None,
        page_size: int = None,
        return_total: bool = None,
        service_id: str = None,
        start_date: str = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
        # This parameter is required.
        self.end_date = end_date
        self.page_number = page_number
        self.page_size = page_size
        self.return_total = return_total
        # This parameter is required.
        self.service_id = service_id
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.return_total is not None:
            result['returnTotal'] = self.return_total
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('returnTotal') is not None:
            self.return_total = m.get('returnTotal')
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGeneralDataServiceResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        field_desc: str = None,
        field_id: str = None,
        field_name: str = None,
        field_type: str = None,
    ):
        # This parameter is required.
        self.field_desc = field_desc
        # This parameter is required.
        self.field_id = field_id
        # This parameter is required.
        self.field_name = field_name
        # This parameter is required.
        self.field_type = field_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_desc is not None:
            result['fieldDesc'] = self.field_desc
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldDesc') is not None:
            self.field_desc = m.get('fieldDesc')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class QueryGeneralDataServiceResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGeneralDataServiceResponseBodyMetaList] = None,
        total: str = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list
        self.total = total

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGeneralDataServiceResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryGeneralDataServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGeneralDataServiceResponseBody = None,
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
            temp_model = QueryGeneralDataServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGeneralDataServiceBatchHeaders(TeaModel):
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


class QueryGeneralDataServiceBatchRequestFilters(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        operator: str = None,
        value: str = None,
    ):
        self.field_id = field_id
        self.operator = operator
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryGeneralDataServiceBatchRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[str] = None,
        end_date: str = None,
        filters: List[QueryGeneralDataServiceBatchRequestFilters] = None,
        page_number: int = None,
        page_size: int = None,
        return_total: bool = None,
        service_id: str = None,
        start_date: str = None,
        user_id: str = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        # This parameter is required.
        self.end_date = end_date
        self.filters = filters
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.return_total = return_total
        # This parameter is required.
        self.service_id = service_id
        # This parameter is required.
        self.start_date = start_date
        self.user_id = user_id
        self.user_ids = user_ids

    def validate(self):
        if self.filters:
            for k in self.filters:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.end_date is not None:
            result['endDate'] = self.end_date
        result['filters'] = []
        if self.filters is not None:
            for k in self.filters:
                result['filters'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.return_total is not None:
            result['returnTotal'] = self.return_total
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        self.filters = []
        if m.get('filters') is not None:
            for k in m.get('filters'):
                temp_model = QueryGeneralDataServiceBatchRequestFilters()
                self.filters.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('returnTotal') is not None:
            self.return_total = m.get('returnTotal')
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryGeneralDataServiceBatchResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        field_desc: str = None,
        field_id: str = None,
        field_name: str = None,
        field_type: str = None,
    ):
        # This parameter is required.
        self.field_desc = field_desc
        # This parameter is required.
        self.field_id = field_id
        # This parameter is required.
        self.field_name = field_name
        # This parameter is required.
        self.field_type = field_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_desc is not None:
            result['fieldDesc'] = self.field_desc
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldDesc') is not None:
            self.field_desc = m.get('fieldDesc')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class QueryGeneralDataServiceBatchResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGeneralDataServiceBatchResponseBodyMetaList] = None,
        total: int = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list
        self.total = total

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGeneralDataServiceBatchResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryGeneralDataServiceBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGeneralDataServiceBatchResponseBody = None,
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
            temp_model = QueryGeneralDataServiceBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGeneralDataUpdateDateHeaders(TeaModel):
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


class QueryGeneralDataUpdateDateRequest(TeaModel):
    def __init__(
        self,
        service_id: str = None,
    ):
        # This parameter is required.
        self.service_id = service_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        return self


class QueryGeneralDataUpdateDateResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        update_date: str = None,
    ):
        self.success = success
        self.update_date = update_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.update_date is not None:
            result['updateDate'] = self.update_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('updateDate') is not None:
            self.update_date = m.get('updateDate')
        return self


class QueryGeneralDataUpdateDateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGeneralDataUpdateDateResponseBody = None,
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
            temp_model = QueryGeneralDataUpdateDateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupLiveStatisticalDataHeaders(TeaModel):
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


class QueryGroupLiveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryGroupLiveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryGroupLiveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGroupLiveStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGroupLiveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryGroupLiveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupLiveStatisticalDataResponseBody = None,
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
            temp_model = QueryGroupLiveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMessageStatisticalDataHeaders(TeaModel):
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


class QueryGroupMessageStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryGroupMessageStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryGroupMessageStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGroupMessageStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGroupMessageStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryGroupMessageStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupMessageStatisticalDataResponseBody = None,
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
            temp_model = QueryGroupMessageStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHealthStatisticalDataHeaders(TeaModel):
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


class QueryHealthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryHealthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryHealthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryHealthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryHealthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryHealthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryHealthStatisticalDataResponseBody = None,
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
            temp_model = QueryHealthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMailStatisticalDataHeaders(TeaModel):
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


class QueryMailStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryMailStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryMailStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryMailStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryMailStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryMailStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMailStatisticalDataResponseBody = None,
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
            temp_model = QueryMailStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOfficialDataHeaders(TeaModel):
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


class QueryOfficialDataRequest(TeaModel):
    def __init__(
        self,
        param: str = None,
        user_id: str = None,
    ):
        self.param = param
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.param is not None:
            result['param'] = self.param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('param') is not None:
            self.param = m.get('param')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOfficialDataResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOfficialDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOfficialDataResponseBody = None,
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
            temp_model = QueryOfficialDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOfficialDatasetFieldsHeaders(TeaModel):
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


class QueryOfficialDatasetFieldsRequest(TeaModel):
    def __init__(
        self,
        ds_id: str = None,
        user_id: str = None,
    ):
        self.ds_id = ds_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ds_id is not None:
            result['dsId'] = self.ds_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dsId') is not None:
            self.ds_id = m.get('dsId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOfficialDatasetFieldsResponseBodyResultFields(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        field_id: str = None,
        field_type: str = None,
    ):
        self.display_name = display_name
        self.field_id = field_id
        self.field_type = field_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class QueryOfficialDatasetFieldsResponseBodyResult(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        ds_id: str = None,
        fields: List[QueryOfficialDatasetFieldsResponseBodyResultFields] = None,
    ):
        self.display_name = display_name
        self.ds_id = ds_id
        self.fields = fields

    def validate(self):
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.ds_id is not None:
            result['dsId'] = self.ds_id
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('dsId') is not None:
            self.ds_id = m.get('dsId')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = QueryOfficialDatasetFieldsResponseBodyResultFields()
                self.fields.append(temp_model.from_map(k))
        return self


class QueryOfficialDatasetFieldsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOfficialDatasetFieldsResponseBodyResult = None,
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
            temp_model = QueryOfficialDatasetFieldsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOfficialDatasetFieldsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOfficialDatasetFieldsResponseBody = None,
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
            temp_model = QueryOfficialDatasetFieldsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOfficialDatasetListHeaders(TeaModel):
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


class QueryOfficialDatasetListRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.keyword = keyword
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryOfficialDatasetListResponseBodyResultRows(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        ds_id: str = None,
    ):
        self.display_name = display_name
        self.ds_id = ds_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.ds_id is not None:
            result['dsId'] = self.ds_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('dsId') is not None:
            self.ds_id = m.get('dsId')
        return self


class QueryOfficialDatasetListResponseBodyResult(TeaModel):
    def __init__(
        self,
        rows: List[QueryOfficialDatasetListResponseBodyResultRows] = None,
        total_count: int = None,
    ):
        self.rows = rows
        self.total_count = total_count

    def validate(self):
        if self.rows:
            for k in self.rows:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['rows'] = []
        if self.rows is not None:
            for k in self.rows:
                result['rows'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.rows = []
        if m.get('rows') is not None:
            for k in m.get('rows'):
                temp_model = QueryOfficialDatasetListResponseBodyResultRows()
                self.rows.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryOfficialDatasetListResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOfficialDatasetListResponseBodyResult = None,
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
            temp_model = QueryOfficialDatasetListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOfficialDatasetListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOfficialDatasetListResponseBody = None,
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
            temp_model = QueryOfficialDatasetListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOfficialFormDataHeaders(TeaModel):
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


class QueryOfficialFormDataRequest(TeaModel):
    def __init__(
        self,
        param: str = None,
        user_id: str = None,
    ):
        self.param = param
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.param is not None:
            result['param'] = self.param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('param') is not None:
            self.param = m.get('param')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOfficialFormDataResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOfficialFormDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOfficialFormDataResponseBody = None,
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
            temp_model = QueryOfficialFormDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOfficialFormDataDirectHoloHeaders(TeaModel):
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


class QueryOfficialFormDataDirectHoloRequest(TeaModel):
    def __init__(
        self,
        param: str = None,
        user_id: str = None,
    ):
        self.param = param
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.param is not None:
            result['param'] = self.param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('param') is not None:
            self.param = m.get('param')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOfficialFormDataDirectHoloResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOfficialFormDataDirectHoloResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOfficialFormDataDirectHoloResponseBody = None,
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
            temp_model = QueryOfficialFormDataDirectHoloResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOnlineUserStatisticalDataHeaders(TeaModel):
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


class QueryOnlineUserStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryOnlineUserStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryOnlineUserStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryOnlineUserStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryOnlineUserStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryOnlineUserStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOnlineUserStatisticalDataResponseBody = None,
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
            temp_model = QueryOnlineUserStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRedEnvelopeReciveStatisticalDataHeaders(TeaModel):
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


class QueryRedEnvelopeReciveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryRedEnvelopeReciveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryRedEnvelopeReciveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRedEnvelopeReciveStatisticalDataResponseBody = None,
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
            temp_model = QueryRedEnvelopeReciveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRedEnvelopeSendStatisticalDataHeaders(TeaModel):
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


class QueryRedEnvelopeSendStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryRedEnvelopeSendStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryRedEnvelopeSendStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRedEnvelopeSendStatisticalDataResponseBody = None,
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
            temp_model = QueryRedEnvelopeSendStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReportStatisticalDataHeaders(TeaModel):
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


class QueryReportStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryReportStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryReportStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryReportStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryReportStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryReportStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryReportStatisticalDataResponseBody = None,
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
            temp_model = QueryReportStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScreenHeaders(TeaModel):
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


class QueryScreenRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class QueryScreenResponseBodyResult(TeaModel):
    def __init__(
        self,
        operate_permission: str = None,
        screen_id: int = None,
        screen_name: str = None,
        state: str = None,
        thumb_url: str = None,
    ):
        self.operate_permission = operate_permission
        self.screen_id = screen_id
        self.screen_name = screen_name
        self.state = state
        self.thumb_url = thumb_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate_permission is not None:
            result['operatePermission'] = self.operate_permission
        if self.screen_id is not None:
            result['screenId'] = self.screen_id
        if self.screen_name is not None:
            result['screenName'] = self.screen_name
        if self.state is not None:
            result['state'] = self.state
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatePermission') is not None:
            self.operate_permission = m.get('operatePermission')
        if m.get('screenId') is not None:
            self.screen_id = m.get('screenId')
        if m.get('screenName') is not None:
            self.screen_name = m.get('screenName')
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        return self


class QueryScreenResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryScreenResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryScreenResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryScreenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScreenResponseBody = None,
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
            temp_model = QueryScreenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScreenTemplateHeaders(TeaModel):
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


class QueryScreenTemplateRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        sample: bool = None,
    ):
        self.operator_id = operator_id
        self.sample = sample

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.sample is not None:
            result['sample'] = self.sample
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('sample') is not None:
            self.sample = m.get('sample')
        return self


class QueryScreenTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        preview_url: str = None,
        screen_size: str = None,
        template_id: str = None,
        template_name: str = None,
        thumb_url: str = None,
    ):
        self.preview_url = preview_url
        self.screen_size = screen_size
        self.template_id = template_id
        self.template_name = template_name
        self.thumb_url = thumb_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.preview_url is not None:
            result['previewUrl'] = self.preview_url
        if self.screen_size is not None:
            result['screenSize'] = self.screen_size
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('previewUrl') is not None:
            self.preview_url = m.get('previewUrl')
        if m.get('screenSize') is not None:
            self.screen_size = m.get('screenSize')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        return self


class QueryScreenTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryScreenTemplateResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryScreenTemplateResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryScreenTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScreenTemplateResponseBody = None,
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
            temp_model = QueryScreenTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySingleMessageStatisticalDataHeaders(TeaModel):
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


class QuerySingleMessageStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QuerySingleMessageStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QuerySingleMessageStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QuerySingleMessageStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QuerySingleMessageStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QuerySingleMessageStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySingleMessageStatisticalDataResponseBody = None,
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
            temp_model = QuerySingleMessageStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTelMeetingStatisticalDataHeaders(TeaModel):
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


class QueryTelMeetingStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryTelMeetingStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryTelMeetingStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryTelMeetingStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryTelMeetingStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryTelMeetingStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTelMeetingStatisticalDataResponseBody = None,
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
            temp_model = QueryTelMeetingStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTodoStatisticalDataHeaders(TeaModel):
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


class QueryTodoStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryTodoStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryTodoStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryTodoStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryTodoStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryTodoStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTodoStatisticalDataResponseBody = None,
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
            temp_model = QueryTodoStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTotalDataCountServiceHeaders(TeaModel):
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


class QueryTotalDataCountServiceRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[str] = None,
        end_date: str = None,
        page_number: int = None,
        page_size: int = None,
        service_id: str = None,
        start_date: str = None,
        user_id: str = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        self.end_date = end_date
        self.page_number = page_number
        self.page_size = page_size
        self.service_id = service_id
        self.start_date = start_date
        self.user_id = user_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryTotalDataCountServiceResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
        total: int = None,
    ):
        self.success = success
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryTotalDataCountServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTotalDataCountServiceResponseBody = None,
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
            temp_model = QueryTotalDataCountServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryVedioMeetingStatisticalDataHeaders(TeaModel):
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


class QueryVedioMeetingStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryVedioMeetingStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryVedioMeetingStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryVedioMeetingStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryVedioMeetingStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryVedioMeetingStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryVedioMeetingStatisticalDataResponseBody = None,
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
            temp_model = QueryVedioMeetingStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydActiveDayStatisticalDataHeaders(TeaModel):
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


class QueryYydActiveDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydActiveDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydActiveDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydActiveDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydActiveDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydActiveDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydActiveDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydActiveDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydActiveMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydActiveMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydActiveMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydActiveMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydActiveMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydActiveMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydActiveMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydActiveMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydActiveMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydActiveWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydActiveWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydActiveWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydActiveWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydActiveWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydActiveWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydActiveWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydActiveWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydActiveWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydAppDayStatisticalDataHeaders(TeaModel):
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


class QueryYydAppDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydAppDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydAppDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydAppDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydAppDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydAppDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydAppDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydAppDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydAppMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydAppMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydAppMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydAppMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydAppMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydAppMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydAppMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydAppMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydAppMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydAppStdStatisticalDataHeaders(TeaModel):
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


class QueryYydAppStdStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydAppStdStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydAppStdStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydAppStdStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydAppStdStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydAppStdStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydAppStdStatisticalDataResponseBody = None,
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
            temp_model = QueryYydAppStdStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydAppWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydAppWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydAppWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydAppWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydAppWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydAppWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydAppWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydAppWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydAppWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydCalendarDayStatisticalDataHeaders(TeaModel):
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


class QueryYydCalendarDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydCalendarDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydCalendarDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydCalendarDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydCalendarDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydCalendarDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydCalendarDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydCalendarDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydCalendarMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydCalendarMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydCalendarMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydCalendarMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydCalendarMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydCalendarMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydCalendarMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydCalendarMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydCalendarMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydCalendarWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydCalendarWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydCalendarWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydCalendarWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydCalendarWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydCalendarWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydCalendarWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydCalendarWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydCalendarWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydDingMsgDayStatisticalDataHeaders(TeaModel):
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


class QueryYydDingMsgDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydDingMsgDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydDingMsgDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydDingMsgDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydDingMsgDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydDingMsgDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydDingMsgDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydDingMsgDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydDingMsgMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydDingMsgMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydDingMsgMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydDingMsgMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydDingMsgMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydDingMsgMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydDingMsgWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydDingMsgWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydDingMsgWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydDingMsgWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydDingMsgWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydDingMsgWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydGroupMsgDayStatisticalDataHeaders(TeaModel):
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


class QueryYydGroupMsgDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydGroupMsgDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydGroupMsgDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydGroupMsgDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydGroupMsgDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydGroupMsgMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydGroupMsgMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydGroupMsgMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydGroupMsgMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydGroupMsgMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydGroupMsgMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydGroupMsgWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydGroupMsgWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydGroupMsgWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydGroupMsgWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydGroupMsgWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydGroupMsgWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydLogDayStatisticalDataHeaders(TeaModel):
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


class QueryYydLogDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydLogDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydLogDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydLogDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydLogDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydLogDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydLogDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydLogDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydLogMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydLogMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydLogMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydLogMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydLogMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydLogMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydLogMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydLogMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydLogMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydLogWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydLogWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydLogWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydLogWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydLogWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydLogWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydLogWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydLogWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydLogWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydMeetingDayStatisticalDataHeaders(TeaModel):
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


class QueryYydMeetingDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydMeetingDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydMeetingDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydMeetingDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydMeetingDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydMeetingDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydMeetingDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydMeetingDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydMeetingMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydMeetingMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydMeetingMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydMeetingMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydMeetingMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydMeetingMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydMeetingMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydMeetingMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydMeetingMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydMeetingWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydMeetingWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydMeetingWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydMeetingWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydMeetingWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydMeetingWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydMeetingWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydMeetingWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydMeetingWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydNoticeDayStatisticalDataHeaders(TeaModel):
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


class QueryYydNoticeDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydNoticeDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydNoticeDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydNoticeDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydNoticeDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydNoticeDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydNoticeDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydNoticeDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydNoticeMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydNoticeMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydNoticeMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydNoticeMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydNoticeMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydNoticeMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydNoticeMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydNoticeMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydNoticeMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydNoticeWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydNoticeWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydNoticeWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydNoticeWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydNoticeWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydNoticeWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydNoticeWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydNoticeWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydNoticeWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydSingleMsgDayStatisticalDataHeaders(TeaModel):
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


class QueryYydSingleMsgDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydSingleMsgDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydSingleMsgDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydSingleMsgDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydSingleMsgDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydSingleMsgMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydSingleMsgMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydSingleMsgMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydSingleMsgMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydSingleMsgMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydSingleMsgMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydSingleMsgWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydSingleMsgWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydSingleMsgWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydSingleMsgWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydSingleMsgWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydSingleMsgWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydToatlMsgDayStatisticalDataHeaders(TeaModel):
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


class QueryYydToatlMsgDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydToatlMsgDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydToatlMsgDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydToatlMsgDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydToatlMsgDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydToatlMsgMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydToatlMsgMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydToatlMsgMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydToatlMsgMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydToatlMsgMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydToatlMsgMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydToatlMsgWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydToatlMsgWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydToatlMsgWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydToatlMsgWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydToatlMsgWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydToatlMsgWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTodoDayStatisticalDataHeaders(TeaModel):
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


class QueryYydTodoDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTodoDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTodoDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTodoDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTodoDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTodoDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTodoDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTodoDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTodoMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydTodoMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTodoMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTodoMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTodoMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTodoMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTodoMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTodoMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTodoMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTodoWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydTodoWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTodoWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTodoWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTodoWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTodoWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTodoWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTodoWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTodoWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTotalDayStatisticalDataHeaders(TeaModel):
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


class QueryYydTotalDayStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTotalDayStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTotalDayStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTotalDayStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTotalDayStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTotalDayStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTotalDayStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTotalDayStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTotalMonthStatisticalDataHeaders(TeaModel):
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


class QueryYydTotalMonthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTotalMonthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTotalMonthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTotalMonthStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTotalMonthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTotalMonthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTotalMonthStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTotalMonthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTotalStdStatisticalDataHeaders(TeaModel):
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


class QueryYydTotalStdStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTotalStdStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTotalStdStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTotalStdStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTotalStdStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTotalStdStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTotalStdStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTotalStdStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryYydTotalWeekStatisticalDataHeaders(TeaModel):
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


class QueryYydTotalWeekStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryYydTotalWeekStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class QueryYydTotalWeekStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryYydTotalWeekStatisticalDataResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryYydTotalWeekStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryYydTotalWeekStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryYydTotalWeekStatisticalDataResponseBody = None,
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
            temp_model = QueryYydTotalWeekStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchCompanyHeaders(TeaModel):
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


class SearchCompanyRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        search_key: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.search_key = search_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        return self


class SearchCompanyResponseBody(TeaModel):
    def __init__(
        self,
        data: str = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class SearchCompanyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchCompanyResponseBody = None,
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
            temp_model = SearchCompanyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncDataScreenHeaders(TeaModel):
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


class SyncDataScreenRequest(TeaModel):
    def __init__(
        self,
        screen_id: str = None,
        ticket: str = None,
    ):
        # This parameter is required.
        self.screen_id = screen_id
        # This parameter is required.
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.screen_id is not None:
            result['screenId'] = self.screen_id
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('screenId') is not None:
            self.screen_id = m.get('screenId')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class SyncDataScreenResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SyncDataScreenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncDataScreenResponseBody = None,
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
            temp_model = SyncDataScreenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


