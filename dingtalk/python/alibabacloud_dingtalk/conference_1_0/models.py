# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateVideoConferenceHeaders(TeaModel):
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


class CreateVideoConferenceRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        conf_title: str = None,
        invite_user_ids: List[str] = None,
    ):
        # 会议发起人UID
        self.user_id = user_id
        # 会议主题： 文字，不超过20中文
        self.conf_title = conf_title
        # 邀请参会人员UID列表（必须好友或同事）
        self.invite_user_ids = invite_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.conf_title is not None:
            result['confTitle'] = self.conf_title
        if self.invite_user_ids is not None:
            result['inviteUserIds'] = self.invite_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('confTitle') is not None:
            self.conf_title = m.get('confTitle')
        if m.get('inviteUserIds') is not None:
            self.invite_user_ids = m.get('inviteUserIds')
        return self


class CreateVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        conference_password: str = None,
        host_password: str = None,
        external_link_url: str = None,
        phone_numbers: List[str] = None,
    ):
        # conferenceId
        self.conference_id = conference_id
        # 会议密码
        self.conference_password = conference_password
        # 主持人密码
        self.host_password = host_password
        # 入会链接
        self.external_link_url = external_link_url
        # 电话入会号码
        self.phone_numbers = phone_numbers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.conference_password is not None:
            result['conferencePassword'] = self.conference_password
        if self.host_password is not None:
            result['hostPassword'] = self.host_password
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.phone_numbers is not None:
            result['phoneNumbers'] = self.phone_numbers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('conferencePassword') is not None:
            self.conference_password = m.get('conferencePassword')
        if m.get('hostPassword') is not None:
            self.host_password = m.get('hostPassword')
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('phoneNumbers') is not None:
            self.phone_numbers = m.get('phoneNumbers')
        return self


class CreateVideoConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateVideoConferenceResponseBody = None,
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
            temp_model = CreateVideoConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseVideoConferenceHeaders(TeaModel):
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


class CloseVideoConferenceRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # 员工在当前开发者企业账号范围内的唯一标识
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CloseVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        cause: str = None,
    ):
        self.code = code
        self.cause = cause

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.cause is not None:
            result['cause'] = self.cause
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        return self


class CloseVideoConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CloseVideoConferenceResponseBody = None,
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
            temp_model = CloseVideoConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


