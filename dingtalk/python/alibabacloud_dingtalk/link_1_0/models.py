# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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


