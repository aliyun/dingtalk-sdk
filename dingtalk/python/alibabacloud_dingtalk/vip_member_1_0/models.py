# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class DirectRedeemVipMemberByMobileHeaders(TeaModel):
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


class DirectRedeemVipMemberByMobileRequest(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        channel: str = None,
        dingtalk_id: str = None,
        duration: int = None,
        mobile: str = None,
        uuid: str = None,
    ):
        self.biz_request_id = biz_request_id
        self.channel = channel
        self.dingtalk_id = dingtalk_id
        self.duration = duration
        self.mobile = mobile
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.channel is not None:
            result['channel'] = self.channel
        if self.dingtalk_id is not None:
            result['dingtalkId'] = self.dingtalk_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('dingtalkId') is not None:
            self.dingtalk_id = m.get('dingtalkId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class DirectRedeemVipMemberByMobileResponseBody(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        error_code: str = None,
        error_msg: str = None,
        result: bool = None,
    ):
        self.biz_request_id = biz_request_id
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DirectRedeemVipMemberByMobileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DirectRedeemVipMemberByMobileResponseBody = None,
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
            temp_model = DirectRedeemVipMemberByMobileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InvalidRedeemVipMemberByBizRequestIdHeaders(TeaModel):
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


class InvalidRedeemVipMemberByBizRequestIdRequest(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        channel: str = None,
        dingtalk_id: str = None,
        duration: int = None,
        mobile: str = None,
        uuid: str = None,
    ):
        self.biz_request_id = biz_request_id
        self.channel = channel
        self.dingtalk_id = dingtalk_id
        self.duration = duration
        self.mobile = mobile
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.channel is not None:
            result['channel'] = self.channel
        if self.dingtalk_id is not None:
            result['dingtalkId'] = self.dingtalk_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('dingtalkId') is not None:
            self.dingtalk_id = m.get('dingtalkId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class InvalidRedeemVipMemberByBizRequestIdResponseBody(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        error_code: str = None,
        error_msg: str = None,
        result: str = None,
    ):
        self.biz_request_id = biz_request_id
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class InvalidRedeemVipMemberByBizRequestIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InvalidRedeemVipMemberByBizRequestIdResponseBody = None,
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
            temp_model = InvalidRedeemVipMemberByBizRequestIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreCheckRedeemVipMemberHeaders(TeaModel):
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


class PreCheckRedeemVipMemberRequest(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        channel: str = None,
        dingtalk_id: str = None,
        duration: int = None,
        mobile: str = None,
        uuid: str = None,
    ):
        self.biz_request_id = biz_request_id
        self.channel = channel
        self.dingtalk_id = dingtalk_id
        self.duration = duration
        self.mobile = mobile
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.channel is not None:
            result['channel'] = self.channel
        if self.dingtalk_id is not None:
            result['dingtalkId'] = self.dingtalk_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('dingtalkId') is not None:
            self.dingtalk_id = m.get('dingtalkId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PreCheckRedeemVipMemberResponseBody(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        error_code: str = None,
        error_msg: str = None,
        result: bool = None,
    ):
        self.biz_request_id = biz_request_id
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class PreCheckRedeemVipMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreCheckRedeemVipMemberResponseBody = None,
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
            temp_model = PreCheckRedeemVipMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRedeemVipMemberHeaders(TeaModel):
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


class QueryRedeemVipMemberRequest(TeaModel):
    def __init__(
        self,
        biz_request_id: str = None,
        channel: str = None,
        dingtalk_id: str = None,
        duration: int = None,
        mobile: str = None,
        uuid: str = None,
    ):
        self.biz_request_id = biz_request_id
        self.channel = channel
        self.dingtalk_id = dingtalk_id
        self.duration = duration
        self.mobile = mobile
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.channel is not None:
            result['channel'] = self.channel
        if self.dingtalk_id is not None:
            result['dingtalkId'] = self.dingtalk_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('dingtalkId') is not None:
            self.dingtalk_id = m.get('dingtalkId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class QueryRedeemVipMemberResponseBodyQueryResults(TeaModel):
    def __init__(
        self,
        action: str = None,
        action_time: str = None,
        dingtalk_id: str = None,
        duration: int = None,
        expire_date: str = None,
        nick: str = None,
    ):
        self.action = action
        self.action_time = action_time
        self.dingtalk_id = dingtalk_id
        self.duration = duration
        self.expire_date = expire_date
        self.nick = nick

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.action_time is not None:
            result['actionTime'] = self.action_time
        if self.dingtalk_id is not None:
            result['dingtalkId'] = self.dingtalk_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.expire_date is not None:
            result['expireDate'] = self.expire_date
        if self.nick is not None:
            result['nick'] = self.nick
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionTime') is not None:
            self.action_time = m.get('actionTime')
        if m.get('dingtalkId') is not None:
            self.dingtalk_id = m.get('dingtalkId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('expireDate') is not None:
            self.expire_date = m.get('expireDate')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        return self


class QueryRedeemVipMemberResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        query_results: List[QueryRedeemVipMemberResponseBodyQueryResults] = None,
        result: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.query_results = query_results
        self.result = result

    def validate(self):
        if self.query_results:
            for k in self.query_results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        result['queryResults'] = []
        if self.query_results is not None:
            for k in self.query_results:
                result['queryResults'].append(k.to_map() if k else None)
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        self.query_results = []
        if m.get('queryResults') is not None:
            for k in m.get('queryResults'):
                temp_model = QueryRedeemVipMemberResponseBodyQueryResults()
                self.query_results.append(temp_model.from_map(k))
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class QueryRedeemVipMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRedeemVipMemberResponseBody = None,
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
            temp_model = QueryRedeemVipMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryVipMemberInfoHeaders(TeaModel):
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


class QueryVipMemberInfoRequest(TeaModel):
    def __init__(
        self,
        channel_code: str = None,
    ):
        self.channel_code = channel_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        return self


class QueryVipMemberInfoResponseBody(TeaModel):
    def __init__(
        self,
        expire_time: str = None,
        is_vip: bool = None,
    ):
        self.expire_time = expire_time
        self.is_vip = is_vip

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.is_vip is not None:
            result['isVip'] = self.is_vip
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('isVip') is not None:
            self.is_vip = m.get('isVip')
        return self


class QueryVipMemberInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryVipMemberInfoResponseBody = None,
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
            temp_model = QueryVipMemberInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


