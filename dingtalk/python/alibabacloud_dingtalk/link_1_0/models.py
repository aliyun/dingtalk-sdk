# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class ApplyFollowerAuthInfoHeaders(TeaModel):
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


class ApplyFollowerAuthInfoRequest(TeaModel):
    def __init__(
        self,
        field_scope: str = None,
        session_id: str = None,
        user_id: str = None,
    ):
        # 申请的授权数据，多个数据时使用,分隔
        self.field_scope = field_scope
        # 客服会话sessionId
        self.session_id = session_id
        # 用户信息
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_scope is not None:
            result['fieldScope'] = self.field_scope
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldScope') is not None:
            self.field_scope = m.get('fieldScope')
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ApplyFollowerAuthInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_apply_id: str = None,
    ):
        # 发送申请ID
        self.open_apply_id = open_apply_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_apply_id is not None:
            result['openApplyId'] = self.open_apply_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openApplyId') is not None:
            self.open_apply_id = m.get('openApplyId')
        return self


class ApplyFollowerAuthInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: ApplyFollowerAuthInfoResponseBodyResult = None,
    ):
        # 推送结果
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
            temp_model = ApplyFollowerAuthInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ApplyFollowerAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ApplyFollowerAuthInfoResponseBody = None,
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
            temp_model = ApplyFollowerAuthInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseTopBoxInteractiveOTOMessageHeaders(TeaModel):
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


class CloseTopBoxInteractiveOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        card_biz_id: str = None,
        card_template_id: str = None,
        user_id: str = None,
    ):
        # 唯一标识一张卡片的ID，卡片幂等ID
        self.card_biz_id = card_biz_id
        # 卡片模板 ID
        self.card_template_id = card_template_id
        # 用户 userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CloseTopBoxInteractiveOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: CloseTopBoxInteractiveOTOMessageRequestDetail = None,
    ):
        # 卡片参数
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = CloseTopBoxInteractiveOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class CloseTopBoxInteractiveOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
    ):
        # Id of the request
        self.request_id = request_id
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class CloseTopBoxInteractiveOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CloseTopBoxInteractiveOTOMessageResponseBody = None,
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
            temp_model = CloseTopBoxInteractiveOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFollowerAuthInfoHeaders(TeaModel):
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


class GetFollowerAuthInfoRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        user_id: str = None,
    ):
        # 服务窗帐号ID，用于非服务窗自建应用场景下指定服务窗帐号。
        self.account_id = account_id
        # 关注用户的userId
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
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp(TeaModel):
    def __init__(
        self,
        authorized: bool = None,
        corp_name: str = None,
    ):
        # 是否授权主组织信息。
        # 当且仅当此值为true时返回用户主组织信息。
        self.authorized = authorized
        # 主组织名
        self.corp_name = corp_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorized is not None:
            result['authorized'] = self.authorized
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorized') is not None:
            self.authorized = m.get('authorized')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        return self


class GetFollowerAuthInfoResponseBodyResultAuthInfoMobile(TeaModel):
    def __init__(
        self,
        authorized: bool = None,
        mobile: str = None,
        state_code: str = None,
    ):
        # 用户是否授权手机号码信息。
        # 当且仅当此值为true时返回手机号码信息。
        self.authorized = authorized
        # 手机号码
        self.mobile = mobile
        # 地区码
        self.state_code = state_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorized is not None:
            result['authorized'] = self.authorized
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.state_code is not None:
            result['stateCode'] = self.state_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorized') is not None:
            self.authorized = m.get('authorized')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('stateCode') is not None:
            self.state_code = m.get('stateCode')
        return self


class GetFollowerAuthInfoResponseBodyResultAuthInfo(TeaModel):
    def __init__(
        self,
        main_corp: GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp = None,
        mobile: GetFollowerAuthInfoResponseBodyResultAuthInfoMobile = None,
    ):
        # 用户主组织信息
        # 需要用户授权给应用后返回此信息。
        self.main_corp = main_corp
        # 手机号码授权详情。
        # 需要用户授权给应用后返回此信息。
        self.mobile = mobile

    def validate(self):
        if self.main_corp:
            self.main_corp.validate()
        if self.mobile:
            self.mobile.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.main_corp is not None:
            result['mainCorp'] = self.main_corp.to_map()
        if self.mobile is not None:
            result['mobile'] = self.mobile.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mainCorp') is not None:
            temp_model = GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp()
            self.main_corp = temp_model.from_map(m['mainCorp'])
        if m.get('mobile') is not None:
            temp_model = GetFollowerAuthInfoResponseBodyResultAuthInfoMobile()
            self.mobile = temp_model.from_map(m['mobile'])
        return self


class GetFollowerAuthInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        auth_info: GetFollowerAuthInfoResponseBodyResultAuthInfo = None,
    ):
        # 授权详情
        self.auth_info = auth_info

    def validate(self):
        if self.auth_info:
            self.auth_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_info is not None:
            result['authInfo'] = self.auth_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authInfo') is not None:
            temp_model = GetFollowerAuthInfoResponseBodyResultAuthInfo()
            self.auth_info = temp_model.from_map(m['authInfo'])
        return self


class GetFollowerAuthInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetFollowerAuthInfoResponseBodyResult = None,
    ):
        # 响应结果
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
            temp_model = GetFollowerAuthInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetFollowerAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFollowerAuthInfoResponseBody = None,
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
            temp_model = GetFollowerAuthInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFollowerInfoHeaders(TeaModel):
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


class GetFollowerInfoRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.account_id = account_id
        self.union_id = union_id
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFollowerInfoResponseBodyResultUser(TeaModel):
    def __init__(
        self,
        name: str = None,
        timestamp: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.timestamp = timestamp
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFollowerInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        user: GetFollowerInfoResponseBodyResultUser = None,
    ):
        self.user = user

    def validate(self):
        if self.user:
            self.user.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user is not None:
            result['user'] = self.user.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('user') is not None:
            temp_model = GetFollowerInfoResponseBodyResultUser()
            self.user = temp_model.from_map(m['user'])
        return self


class GetFollowerInfoResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: GetFollowerInfoResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 响应结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = GetFollowerInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetFollowerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFollowerInfoResponseBody = None,
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
            temp_model = GetFollowerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPictureDownloadUrlHeaders(TeaModel):
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


class GetPictureDownloadUrlRequest(TeaModel):
    def __init__(
        self,
        download_code: str = None,
        session_id: str = None,
    ):
        self.download_code = download_code
        self.session_id = session_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_code is not None:
            result['downloadCode'] = self.download_code
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadCode') is not None:
            self.download_code = m.get('downloadCode')
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        return self


class GetPictureDownloadUrlResponseBodyResult(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # 关注状态
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


class GetPictureDownloadUrlResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: GetPictureDownloadUrlResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 响应结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = GetPictureDownloadUrlResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetPictureDownloadUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPictureDownloadUrlResponseBody = None,
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
            temp_model = GetPictureDownloadUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFollowerHeaders(TeaModel):
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


class ListFollowerRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # 服务窗帐号ID，用于非服务窗自建应用场景下指定服务窗帐号。
        self.account_id = account_id
        # 分页查询页大小。
        self.max_results = max_results
        # 分页查询下一页token,首页查询此字段可空，其它页查询时需要将此值设置炎上一次接口调用的token
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFollowerResponseBodyResultUserList(TeaModel):
    def __init__(
        self,
        name: str = None,
        timestamp: int = None,
        user_id: str = None,
    ):
        # 关注者昵称
        self.name = name
        # 关注时间 
        self.timestamp = timestamp
        # 关注者userId，可用于消息推送等场景。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListFollowerResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        user_list: List[ListFollowerResponseBodyResultUserList] = None,
    ):
        # 下一页查询位置
        # 当此返回值为空时，则说明全部数据查询完成。
        # 当此返回值不为空时，可以将此值设置为下一次查询的参数。
        self.next_token = next_token
        # 用户列表
        self.user_list = user_list

    def validate(self):
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = ListFollowerResponseBodyResultUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class ListFollowerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: ListFollowerResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 响应结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = ListFollowerResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ListFollowerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListFollowerResponseBody = None,
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
            temp_model = ListFollowerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendAgentOTOMessageHeaders(TeaModel):
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


class SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        # 使用独立跳转ActionCard样式时的跳转链接。
        self.action_url = action_url
        # 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendAgentOTOMessageRequestDetailMessageBodyActionCard(TeaModel):
    def __init__(
        self,
        button_list: List[SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList] = None,
        button_orientation: str = None,
        markdown: str = None,
        single_title: str = None,
        single_url: str = None,
        title: str = None,
    ):
        # 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        self.button_list = button_list
        # 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        self.button_orientation = button_orientation
        # 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        self.markdown = markdown
        # 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        self.single_title = single_title
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        self.single_url = single_url
        # 透出到会话列表和通知的文案
        self.title = title

    def validate(self):
        if self.button_list:
            for k in self.button_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['buttonList'] = []
        if self.button_list is not None:
            for k in self.button_list:
                result['buttonList'].append(k.to_map() if k else None)
        if self.button_orientation is not None:
            result['buttonOrientation'] = self.button_orientation
        if self.markdown is not None:
            result['markdown'] = self.markdown
        if self.single_title is not None:
            result['singleTitle'] = self.single_title
        if self.single_url is not None:
            result['singleUrl'] = self.single_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.button_list = []
        if m.get('buttonList') is not None:
            for k in m.get('buttonList'):
                temp_model = SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList()
                self.button_list.append(temp_model.from_map(k))
        if m.get('buttonOrientation') is not None:
            self.button_orientation = m.get('buttonOrientation')
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        if m.get('singleTitle') is not None:
            self.single_title = m.get('singleTitle')
        if m.get('singleUrl') is not None:
            self.single_url = m.get('singleUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendAgentOTOMessageRequestDetailMessageBodyLink(TeaModel):
    def __init__(
        self,
        message_url: str = None,
        pic_url: str = None,
        text: str = None,
        title: str = None,
    ):
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        self.message_url = message_url
        # 图片地址
        self.pic_url = pic_url
        # 消息描述，建议500字符以内。
        self.text = text
        # 消息标题，建议100字符以内。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_url is not None:
            result['messageUrl'] = self.message_url
        if self.pic_url is not None:
            result['picUrl'] = self.pic_url
        if self.text is not None:
            result['text'] = self.text
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageUrl') is not None:
            self.message_url = m.get('messageUrl')
        if m.get('picUrl') is not None:
            self.pic_url = m.get('picUrl')
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendAgentOTOMessageRequestDetailMessageBodyMarkdown(TeaModel):
    def __init__(
        self,
        text: str = None,
        title: str = None,
    ):
        # markdown格式的消息，建议500字符以内。
        self.text = text
        # 首屏会话透出的展示内容。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendAgentOTOMessageRequestDetailMessageBodyText(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        # 消息内容，建议500字符以内。
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class SendAgentOTOMessageRequestDetailMessageBody(TeaModel):
    def __init__(
        self,
        action_card: SendAgentOTOMessageRequestDetailMessageBodyActionCard = None,
        link: SendAgentOTOMessageRequestDetailMessageBodyLink = None,
        markdown: SendAgentOTOMessageRequestDetailMessageBodyMarkdown = None,
        text: SendAgentOTOMessageRequestDetailMessageBodyText = None,
    ):
        # 卡片消息
        self.action_card = action_card
        # 链接消息类型
        self.link = link
        # markdown消息，仅对消息类型为markdown时有效
        self.markdown = markdown
        # 文本消息体  对于文本类型消息时必填
        self.text = text

    def validate(self):
        if self.action_card:
            self.action_card.validate()
        if self.link:
            self.link.validate()
        if self.markdown:
            self.markdown.validate()
        if self.text:
            self.text.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_card is not None:
            result['actionCard'] = self.action_card.to_map()
        if self.link is not None:
            result['link'] = self.link.to_map()
        if self.markdown is not None:
            result['markdown'] = self.markdown.to_map()
        if self.text is not None:
            result['text'] = self.text.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionCard') is not None:
            temp_model = SendAgentOTOMessageRequestDetailMessageBodyActionCard()
            self.action_card = temp_model.from_map(m['actionCard'])
        if m.get('link') is not None:
            temp_model = SendAgentOTOMessageRequestDetailMessageBodyLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('markdown') is not None:
            temp_model = SendAgentOTOMessageRequestDetailMessageBodyMarkdown()
            self.markdown = temp_model.from_map(m['markdown'])
        if m.get('text') is not None:
            temp_model = SendAgentOTOMessageRequestDetailMessageBodyText()
            self.text = temp_model.from_map(m['text'])
        return self


class SendAgentOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        message_body: SendAgentOTOMessageRequestDetailMessageBody = None,
        msg_type: str = None,
        session_id: str = None,
        user_id: str = None,
        uuid: str = None,
    ):
        # 消息体
        self.message_body = message_body
        # 消息类型
        self.msg_type = msg_type
        self.session_id = session_id
        # 消息接收人id
        self.user_id = user_id
        # 请求唯一 ID
        self.uuid = uuid

    def validate(self):
        if self.message_body:
            self.message_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_body is not None:
            result['messageBody'] = self.message_body.to_map()
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageBody') is not None:
            temp_model = SendAgentOTOMessageRequestDetailMessageBody()
            self.message_body = temp_model.from_map(m['messageBody'])
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class SendAgentOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: SendAgentOTOMessageRequestDetail = None,
    ):
        # 消息详情
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = SendAgentOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class SendAgentOTOMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        # 推送ID
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class SendAgentOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: SendAgentOTOMessageResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 推送结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = SendAgentOTOMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SendAgentOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendAgentOTOMessageResponseBody = None,
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
            temp_model = SendAgentOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendInteractiveOTOMessageHeaders(TeaModel):
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


class SendInteractiveOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_biz_id: str = None,
        card_data: str = None,
        card_template_id: str = None,
        user_id: str = None,
        user_id_private_data_map: str = None,
    ):
        self.callback_url = callback_url
        self.card_biz_id = card_biz_id
        self.card_data = card_data
        self.card_template_id = card_template_id
        # 消息接收人id
        self.user_id = user_id
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_id_private_data_map is not None:
            result['userIdPrivateDataMap'] = self.user_id_private_data_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class SendInteractiveOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: SendInteractiveOTOMessageRequestDetail = None,
    ):
        # 消息详情
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = SendInteractiveOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class SendInteractiveOTOMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        # 推送ID
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class SendInteractiveOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: SendInteractiveOTOMessageResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 推送结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = SendInteractiveOTOMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SendInteractiveOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendInteractiveOTOMessageResponseBody = None,
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
            temp_model = SendInteractiveOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendTopBoxInteractiveOTOMessageHeaders(TeaModel):
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


class SendTopBoxInteractiveOTOMessageRequestDetailCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, Any] = None,
        card_param_map: Dict[str, Any] = None,
    ):
        # 富媒体卡片数据
        self.card_media_id_param_map = card_media_id_param_map
        # 普通文本卡片数据
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class DetailUserIdPrivateDataMapValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, Any] = None,
        card_media_id_param_map: Dict[str, Any] = None,
    ):
        # 卡片模板的文本内容参数。
        self.card_param_map = card_param_map
        # 卡片模板的图片内容参数。
        self.card_media_id_param_map = card_media_id_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        return self


class SendTopBoxInteractiveOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_biz_id: str = None,
        card_data: SendTopBoxInteractiveOTOMessageRequestDetailCardData = None,
        card_template_id: str = None,
        expired_time: int = None,
        user_id: str = None,
        user_id_private_data_map: Dict[str, DetailUserIdPrivateDataMapValue] = None,
    ):
        # 卡片回调 URL 地址，不填则无回调
        self.callback_url = callback_url
        # 唯一标识一张卡片的ID，卡片幂等ID
        self.card_biz_id = card_biz_id
        # 卡片数据
        self.card_data = card_data
        # 卡片模板 ID
        self.card_template_id = card_template_id
        # 失效时间，时间戳（毫秒），最长时间不超过 90 天
        self.expired_time = expired_time
        # 接收人 userId
        self.user_id = user_id
        # 卡片用户差异化数据
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.user_id_private_data_map:
            for v in self.user_id_private_data_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.expired_time is not None:
            result['expiredTime'] = self.expired_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        result['userIdPrivateDataMap'] = {}
        if self.user_id_private_data_map is not None:
            for k, v in self.user_id_private_data_map.items():
                result['userIdPrivateDataMap'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardData') is not None:
            temp_model = SendTopBoxInteractiveOTOMessageRequestDetailCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('expiredTime') is not None:
            self.expired_time = m.get('expiredTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        self.user_id_private_data_map = {}
        if m.get('userIdPrivateDataMap') is not None:
            for k, v in m.get('userIdPrivateDataMap').items():
                temp_model = DetailUserIdPrivateDataMapValue()
                self.user_id_private_data_map[k] = temp_model.from_map(v)
        return self


class SendTopBoxInteractiveOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: SendTopBoxInteractiveOTOMessageRequestDetail = None,
    ):
        # 卡片信息
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = SendTopBoxInteractiveOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class SendTopBoxInteractiveOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
    ):
        # Id of the request
        self.request_id = request_id
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class SendTopBoxInteractiveOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendTopBoxInteractiveOTOMessageResponseBody = None,
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
            temp_model = SendTopBoxInteractiveOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInteractiveOTOMessageHeaders(TeaModel):
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


class UpdateInteractiveOTOMessageRequestDetailUpdateOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        self.update_card_data_by_key = update_card_data_by_key
        self.update_private_data_by_key = update_private_data_by_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.update_card_data_by_key is not None:
            result['updateCardDataByKey'] = self.update_card_data_by_key
        if self.update_private_data_by_key is not None:
            result['updatePrivateDataByKey'] = self.update_private_data_by_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updateCardDataByKey') is not None:
            self.update_card_data_by_key = m.get('updateCardDataByKey')
        if m.get('updatePrivateDataByKey') is not None:
            self.update_private_data_by_key = m.get('updatePrivateDataByKey')
        return self


class UpdateInteractiveOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        card_biz_id: str = None,
        card_data: str = None,
        update_options: UpdateInteractiveOTOMessageRequestDetailUpdateOptions = None,
        user_id_private_data_map: str = None,
    ):
        self.card_biz_id = card_biz_id
        self.card_data = card_data
        self.update_options = update_options
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.update_options:
            self.update_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.update_options is not None:
            result['updateOptions'] = self.update_options.to_map()
        if self.user_id_private_data_map is not None:
            result['userIdPrivateDataMap'] = self.user_id_private_data_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('updateOptions') is not None:
            temp_model = UpdateInteractiveOTOMessageRequestDetailUpdateOptions()
            self.update_options = temp_model.from_map(m['updateOptions'])
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class UpdateInteractiveOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: UpdateInteractiveOTOMessageRequestDetail = None,
    ):
        # 消息详情
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = UpdateInteractiveOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class UpdateInteractiveOTOMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        # 推送ID
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class UpdateInteractiveOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: UpdateInteractiveOTOMessageResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 推送结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = UpdateInteractiveOTOMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateInteractiveOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInteractiveOTOMessageResponseBody = None,
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
            temp_model = UpdateInteractiveOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateShortcutsHeaders(TeaModel):
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


class UpdateShortcutsRequestDetails(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        icon_font: str = None,
        icon_media_id: str = None,
        shortcut_id: str = None,
        slide_icon_media_id: str = None,
        title: str = None,
    ):
        # 跳转链接
        self.action_url = action_url
        # windows侧边栏图标的unicode
        self.icon_font = icon_font
        # 移动端图标
        self.icon_media_id = icon_media_id
        # 插件唯一标识
        self.shortcut_id = shortcut_id
        # 适配mac端侧边栏图标的mediaId
        self.slide_icon_media_id = slide_icon_media_id
        # 插件标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        if self.icon_font is not None:
            result['iconFont'] = self.icon_font
        if self.icon_media_id is not None:
            result['iconMediaId'] = self.icon_media_id
        if self.shortcut_id is not None:
            result['shortcutId'] = self.shortcut_id
        if self.slide_icon_media_id is not None:
            result['slideIconMediaId'] = self.slide_icon_media_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        if m.get('iconFont') is not None:
            self.icon_font = m.get('iconFont')
        if m.get('iconMediaId') is not None:
            self.icon_media_id = m.get('iconMediaId')
        if m.get('shortcutId') is not None:
            self.shortcut_id = m.get('shortcutId')
        if m.get('slideIconMediaId') is not None:
            self.slide_icon_media_id = m.get('slideIconMediaId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class UpdateShortcutsRequest(TeaModel):
    def __init__(
        self,
        details: List[UpdateShortcutsRequestDetails] = None,
        user_id: str = None,
    ):
        # 配置详情
        self.details = details
        # 用户信息
        self.user_id = user_id

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = UpdateShortcutsRequestDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateShortcutsResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class UpdateShortcutsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateShortcutsResponseBody = None,
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
            temp_model = UpdateShortcutsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


