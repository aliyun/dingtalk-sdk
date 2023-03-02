# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddOrgTextEmotionHeaders(TeaModel):
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


class AddOrgTextEmotionRequest(TeaModel):
    def __init__(
        self,
        background_media_id: str = None,
        background_media_id_for_panel: str = None,
        dept_id: int = None,
        emotion_name: str = None,
    ):
        # 展示在消息气泡上的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
        # 
        # 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
        self.background_media_id = background_media_id
        # 展示在消息长按菜单的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
        # 
        # 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
        self.background_media_id_for_panel = background_media_id_for_panel
        # 部门Id，设置规则：
        # 
        # -1：当添加企业层面的文字表情时使用-1，此时表情对企业内所有员工可见
        # 
        # 一级部门Id：当添加一级部门层面的文字表情时使用一级部门Id，此时表情对该一级部门及该一级部门下的所有子部门的员工可见
        self.dept_id = dept_id
        # 表情名称，对用户不可见
        self.emotion_name = emotion_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_media_id is not None:
            result['backgroundMediaId'] = self.background_media_id
        if self.background_media_id_for_panel is not None:
            result['backgroundMediaIdForPanel'] = self.background_media_id_for_panel
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_name is not None:
            result['emotionName'] = self.emotion_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundMediaId') is not None:
            self.background_media_id = m.get('backgroundMediaId')
        if m.get('backgroundMediaIdForPanel') is not None:
            self.background_media_id_for_panel = m.get('backgroundMediaIdForPanel')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionName') is not None:
            self.emotion_name = m.get('emotionName')
        return self


class AddOrgTextEmotionResponseBodyResult(TeaModel):
    def __init__(
        self,
        emotion_id: str = None,
    ):
        # 表情Id，用于唯一标识每个企业文字表情
        self.emotion_id = emotion_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.emotion_id is not None:
            result['emotionId'] = self.emotion_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('emotionId') is not None:
            self.emotion_id = m.get('emotionId')
        return self


class AddOrgTextEmotionResponseBody(TeaModel):
    def __init__(
        self,
        result: AddOrgTextEmotionResponseBodyResult = None,
        success: bool = None,
    ):
        # 添加企业文字表情结果
        self.result = result
        # 返回结果
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
            temp_model = AddOrgTextEmotionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddOrgTextEmotionResponseBody = None,
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
            temp_model = AddOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddRobotToConversationHeaders(TeaModel):
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


class AddRobotToConversationRequest(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        open_conversation_id: str = None,
        robot_code: str = None,
    ):
        # 机器人meidaId
        self.icon = icon
        # 机器人名称
        self.name = name
        # 会话id
        self.open_conversation_id = open_conversation_id
        # 机器人编码
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class AddRobotToConversationResponseBody(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
    ):
        # Id of the request
        self.chat_bot_user_id = chat_bot_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        return self


class AddRobotToConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddRobotToConversationResponseBody = None,
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
            temp_model = AddRobotToConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AutoOpenDingTalkConnectHeaders(TeaModel):
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


class AutoOpenDingTalkConnectResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class AutoOpenDingTalkConnectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AutoOpenDingTalkConnectResponseBody = None,
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
            temp_model = AutoOpenDingTalkConnectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryFamilySchoolMessageHeaders(TeaModel):
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


class BatchQueryFamilySchoolMessageRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_message_ids: List[str] = None,
        union_id: str = None,
    ):
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        self.open_message_ids = open_message_ids
        # 用户唯一标识
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_message_ids is not None:
            result['openMessageIds'] = self.open_message_ids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMessageIds') is not None:
            self.open_message_ids = m.get('openMessageIds')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_type: str = None,
        media_id: str = None,
        size: str = None,
        url: str = None,
        video_pic_media_id: str = None,
    ):
        # 消息mediaId文件名称
        self.file_name = file_name
        # 消息mediaId文件类型
        self.file_type = file_type
        # 消息mediaId
        self.media_id = media_id
        # 消息mediaId文件大小
        self.size = size
        # 消息mediaId对应的下载地址
        self.url = url
        # 视频文件缩略图mediaId
        self.video_pic_media_id = video_pic_media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.size is not None:
            result['size'] = self.size
        if self.url is not None:
            result['url'] = self.url
        if self.video_pic_media_id is not None:
            result['videoPicMediaId'] = self.video_pic_media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('videoPicMediaId') is not None:
            self.video_pic_media_id = m.get('videoPicMediaId')
        return self


class BatchQueryFamilySchoolMessageResponseBodyMessages(TeaModel):
    def __init__(
        self,
        content_type: int = None,
        create_at: int = None,
        media_models: List[BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels] = None,
        open_msg_id: str = None,
    ):
        # 消息类型，2-图片、202视频、3100富文本消息
        self.content_type = content_type
        # 消息的创建时间
        self.create_at = create_at
        # media文件对象列表
        self.media_models = media_models
        # 消息的唯一标识
        self.open_msg_id = open_msg_id

    def validate(self):
        if self.media_models:
            for k in self.media_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.create_at is not None:
            result['createAt'] = self.create_at
        result['mediaModels'] = []
        if self.media_models is not None:
            for k in self.media_models:
                result['mediaModels'].append(k.to_map() if k else None)
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        self.media_models = []
        if m.get('mediaModels') is not None:
            for k in m.get('mediaModels'):
                temp_model = BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels()
                self.media_models.append(temp_model.from_map(k))
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        return self


class BatchQueryFamilySchoolMessageResponseBody(TeaModel):
    def __init__(
        self,
        messages: List[BatchQueryFamilySchoolMessageResponseBodyMessages] = None,
    ):
        # 消息数据
        self.messages = messages

    def validate(self):
        if self.messages:
            for k in self.messages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messages'] = []
        if self.messages is not None:
            for k in self.messages:
                result['messages'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.messages = []
        if m.get('messages') is not None:
            for k in m.get('messages'):
                temp_model = BatchQueryFamilySchoolMessageResponseBodyMessages()
                self.messages.append(temp_model.from_map(k))
        return self


class BatchQueryFamilySchoolMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchQueryFamilySchoolMessageResponseBody = None,
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
            temp_model = BatchQueryFamilySchoolMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryGroupMemberHeaders(TeaModel):
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


class BatchQueryGroupMemberRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 本次读取的最大数据记录数量（该入参传入值小于钉钉阈值时返回全部）
        self.max_results = max_results
        # 标记当前开始读取的位置，置空表示从头开始
        self.next_token = next_token
        # 开放群ID
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class BatchQueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        member_user_ids: List[str] = None,
        next_token: str = None,
        success: bool = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # 群成员员工号
        self.member_user_ids = member_user_ids
        # 下一次请求的游标
        self.next_token = next_token
        # result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.member_user_ids is not None:
            result['memberUserIds'] = self.member_user_ids
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('memberUserIds') is not None:
            self.member_user_ids = m.get('memberUserIds')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchQueryGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchQueryGroupMemberResponseBody = None,
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
            temp_model = BatchQueryGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CardTemplateBuildActionHeaders(TeaModel):
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


class CardTemplateBuildActionRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        card_template_json: str = None,
    ):
        # 模板构建的action：含create、save、deploy
        self.action = action
        # 模板构建的dto对象
        self.card_template_json = card_template_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.card_template_json is not None:
            result['cardTemplateJson'] = self.card_template_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('cardTemplateJson') is not None:
            self.card_template_json = m.get('cardTemplateJson')
        return self


class CardTemplateBuildActionResponseBody(TeaModel):
    def __init__(
        self,
        card_template_json: str = None,
    ):
        # 模板构建的dto对象
        self.card_template_json = card_template_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_template_json is not None:
            result['cardTemplateJson'] = self.card_template_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardTemplateJson') is not None:
            self.card_template_json = m.get('cardTemplateJson')
        return self


class CardTemplateBuildActionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CardTemplateBuildActionResponseBody = None,
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
            temp_model = CardTemplateBuildActionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChangeGroupOwnerHeaders(TeaModel):
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


class ChangeGroupOwnerRequest(TeaModel):
    def __init__(
        self,
        group_owner_id: str = None,
        group_owner_type: int = None,
        open_conversation_id: str = None,
    ):
        # 群主在业务系统内的唯一标识
        self.group_owner_id = group_owner_id
        # 群主类型<2.钉内用户类型 3.钉外用户类型>
        self.group_owner_type = group_owner_type
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_owner_type is not None:
            result['groupOwnerType'] = self.group_owner_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupOwnerType') is not None:
            self.group_owner_type = m.get('groupOwnerType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class ChangeGroupOwnerResponseBody(TeaModel):
    def __init__(
        self,
        new_group_owner_id: str = None,
        new_group_owner_type: int = None,
    ):
        # 群主在业务系统内的唯一标识
        self.new_group_owner_id = new_group_owner_id
        # 群主类型<2.钉内用户类型 3.钉外用户类型>
        self.new_group_owner_type = new_group_owner_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_owner_id is not None:
            result['newGroupOwnerId'] = self.new_group_owner_id
        if self.new_group_owner_type is not None:
            result['newGroupOwnerType'] = self.new_group_owner_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupOwnerId') is not None:
            self.new_group_owner_id = m.get('newGroupOwnerId')
        if m.get('newGroupOwnerType') is not None:
            self.new_group_owner_type = m.get('newGroupOwnerType')
        return self


class ChangeGroupOwnerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ChangeGroupOwnerResponseBody = None,
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
            temp_model = ChangeGroupOwnerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChatIdToOpenConversationIdHeaders(TeaModel):
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


class ChatIdToOpenConversationIdResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # openConversationId
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class ChatIdToOpenConversationIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ChatIdToOpenConversationIdResponseBody = None,
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
            temp_model = ChatIdToOpenConversationIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChatSubAdminUpdateHeaders(TeaModel):
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


class ChatSubAdminUpdateRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        role: int = None,
        user_ids: List[str] = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 设置2添加为管理员，设置3删除该管理员
        self.role = role
        # 企业员工工号列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.role is not None:
            result['role'] = self.role
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ChatSubAdminUpdateResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        # result
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


class ChatSubAdminUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ChatSubAdminUpdateResponseBody = None,
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
            temp_model = ChatSubAdminUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCoupleGroupConversationHeaders(TeaModel):
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


class CreateCoupleGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        group_avatar: str = None,
        group_name: str = None,
        group_owner_id: str = None,
        group_template_id: str = None,
        operator_id: str = None,
    ):
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 群头像地址。
        self.group_avatar = group_avatar
        # 群名称。
        self.group_name = group_name
        # 群主在业务系统内的唯一标识
        self.group_owner_id = group_owner_id
        # 群模板Id。
        self.group_template_id = group_template_id
        # 操作者在业务系统内的唯一标识。
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateCoupleGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        open_conversation_id: str = None,
    ):
        # 钉钉群会话id。
        self.conversation_id = conversation_id
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateCoupleGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCoupleGroupConversationResponseBody = None,
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
            temp_model = CreateCoupleGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateGroupConversationHeaders(TeaModel):
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


class CreateGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        group_avatar: str = None,
        group_name: str = None,
        group_owner_id: str = None,
        group_owner_type: int = None,
        group_template_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # 钉外成员列表。
        self.app_user_ids = app_user_ids
        # 群头像地址。
        self.group_avatar = group_avatar
        # 群名称。
        self.group_name = group_name
        # 群主在业务系统内的唯一标识
        self.group_owner_id = group_owner_id
        # 群主类型<2.钉内用户类型 3.钉外用户类型>，如果不指定的话，默认是钉钉用户类型
        self.group_owner_type = group_owner_type
        # 群模板Id。
        self.group_template_id = group_template_id
        # 操作者在业务系统内的唯一标识。
        self.operator_id = operator_id
        # 钉内成员列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_owner_type is not None:
            result['groupOwnerType'] = self.group_owner_type
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupOwnerType') is not None:
            self.group_owner_type = m.get('groupOwnerType')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        conversation_id: str = None,
        open_conversation_id: str = None,
        user_ids: List[str] = None,
    ):
        # 添加成功的钉外成员列表。
        self.app_user_ids = app_user_ids
        # 钉钉群会话Id。
        self.conversation_id = conversation_id
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 添加成功的钉内成员列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateGroupConversationResponseBody = None,
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
            temp_model = CreateGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateInterconnectionHeaders(TeaModel):
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


class CreateInterconnectionRequestInterconnections(TeaModel):
    def __init__(
        self,
        app_user_avatar: str = None,
        app_user_avatar_media_type: int = None,
        app_user_dynamics: str = None,
        app_user_id: str = None,
        app_user_mobile: str = None,
        app_user_name: str = None,
        channel_code: str = None,
        user_id: str = None,
    ):
        # 钉外账号头像链接。
        self.app_user_avatar = app_user_avatar
        # 钉外账号头像类型，取值：
        # 1（http类型）
        self.app_user_avatar_media_type = app_user_avatar_media_type
        # 钉外账号用户动态，例如：认真工作，快乐生活。
        self.app_user_dynamics = app_user_dynamics
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 钉外账号手机号，例如：188****8655。
        self.app_user_mobile = app_user_mobile
        # 钉外账号名称。
        self.app_user_name = app_user_name
        # 渠道code。
        self.channel_code = channel_code
        # 钉内账号userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_avatar is not None:
            result['appUserAvatar'] = self.app_user_avatar
        if self.app_user_avatar_media_type is not None:
            result['appUserAvatarMediaType'] = self.app_user_avatar_media_type
        if self.app_user_dynamics is not None:
            result['appUserDynamics'] = self.app_user_dynamics
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.app_user_mobile is not None:
            result['appUserMobile'] = self.app_user_mobile
        if self.app_user_name is not None:
            result['appUserName'] = self.app_user_name
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserAvatar') is not None:
            self.app_user_avatar = m.get('appUserAvatar')
        if m.get('appUserAvatarMediaType') is not None:
            self.app_user_avatar_media_type = m.get('appUserAvatarMediaType')
        if m.get('appUserDynamics') is not None:
            self.app_user_dynamics = m.get('appUserDynamics')
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('appUserMobile') is not None:
            self.app_user_mobile = m.get('appUserMobile')
        if m.get('appUserName') is not None:
            self.app_user_name = m.get('appUserName')
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateInterconnectionRequest(TeaModel):
    def __init__(
        self,
        interconnections: List[CreateInterconnectionRequestInterconnections] = None,
    ):
        # 要创建的钉外账号列表。
        self.interconnections = interconnections

    def validate(self):
        if self.interconnections:
            for k in self.interconnections:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['interconnections'] = []
        if self.interconnections is not None:
            for k in self.interconnections:
                result['interconnections'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.interconnections = []
        if m.get('interconnections') is not None:
            for k in m.get('interconnections'):
                temp_model = CreateInterconnectionRequestInterconnections()
                self.interconnections.append(temp_model.from_map(k))
        return self


class CreateInterconnectionResponseBodyResults(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        message: str = None,
        user_id: str = None,
    ):
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 失败原因。
        self.message = message
        # 该钉外账号被哪个钉内账号负责。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.message is not None:
            result['message'] = self.message
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateInterconnectionResponseBody(TeaModel):
    def __init__(
        self,
        results: List[CreateInterconnectionResponseBodyResults] = None,
    ):
        # 创建失败的钉外账号列表。
        self.results = results

    def validate(self):
        if self.results:
            for k in self.results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['results'] = []
        if self.results is not None:
            for k in self.results:
                result['results'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.results = []
        if m.get('results') is not None:
            for k in m.get('results'):
                temp_model = CreateInterconnectionResponseBodyResults()
                self.results.append(temp_model.from_map(k))
        return self


class CreateInterconnectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateInterconnectionResponseBody = None,
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
            temp_model = CreateInterconnectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSceneGroupConversationHeaders(TeaModel):
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


class CreateSceneGroupConversationRequestManagementOptions(TeaModel):
    def __init__(
        self,
        chat_banned_type: int = None,
        management_type: int = None,
        mention_all_authority: int = None,
        searchable: int = None,
        show_history_type: int = None,
        validation_type: int = None,
    ):
        # 群禁言，0-默认，不禁言，1-全员禁言
        self.chat_banned_type = chat_banned_type
        # 管理类型，0-默认，所有人可管理，1-仅群主可管理
        self.management_type = management_type
        # @ all 权限，0-默认，所有人，1-仅群主可@all
        self.mention_all_authority = mention_all_authority
        # 群可搜索，0-默认，不可搜索，1-可搜索
        self.searchable = searchable
        # 新成员是否可查看聊天历史消息，0-默认，否，1-是
        self.show_history_type = show_history_type
        # 入群验证，0：不入群验证（默认） 1：入群验证
        self.validation_type = validation_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_banned_type is not None:
            result['chatBannedType'] = self.chat_banned_type
        if self.management_type is not None:
            result['managementType'] = self.management_type
        if self.mention_all_authority is not None:
            result['mentionAllAuthority'] = self.mention_all_authority
        if self.searchable is not None:
            result['searchable'] = self.searchable
        if self.show_history_type is not None:
            result['showHistoryType'] = self.show_history_type
        if self.validation_type is not None:
            result['validationType'] = self.validation_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBannedType') is not None:
            self.chat_banned_type = m.get('chatBannedType')
        if m.get('managementType') is not None:
            self.management_type = m.get('managementType')
        if m.get('mentionAllAuthority') is not None:
            self.mention_all_authority = m.get('mentionAllAuthority')
        if m.get('searchable') is not None:
            self.searchable = m.get('searchable')
        if m.get('showHistoryType') is not None:
            self.show_history_type = m.get('showHistoryType')
        if m.get('validationType') is not None:
            self.validation_type = m.get('validationType')
        return self


class CreateSceneGroupConversationRequest(TeaModel):
    def __init__(
        self,
        features: Dict[str, str] = None,
        group_name: str = None,
        group_owner_id: str = None,
        icon: str = None,
        management_options: CreateSceneGroupConversationRequestManagementOptions = None,
        template_id: str = None,
        user_id_list: List[str] = None,
        uuid: str = None,
    ):
        # 功能增强
        self.features = features
        # 群名称。
        self.group_name = group_name
        # 群主(钉外用户)userId。
        self.group_owner_id = group_owner_id
        # 群头像。
        self.icon = icon
        self.management_options = management_options
        # 群模板Id。
        self.template_id = template_id
        self.user_id_list = user_id_list
        # 建群去重的业务ID。
        self.uuid = uuid

    def validate(self):
        if self.management_options:
            self.management_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.features is not None:
            result['features'] = self.features
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.icon is not None:
            result['icon'] = self.icon
        if self.management_options is not None:
            result['managementOptions'] = self.management_options.to_map()
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('features') is not None:
            self.features = m.get('features')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('managementOptions') is not None:
            temp_model = CreateSceneGroupConversationRequestManagementOptions()
            self.management_options = temp_model.from_map(m['managementOptions'])
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class CreateSceneGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateSceneGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateSceneGroupConversationResponseBody = None,
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
            temp_model = CreateSceneGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateStoreGroupConversationHeaders(TeaModel):
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


class CreateStoreGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        business_unique_key: str = None,
        group_avatar: str = None,
        group_name: str = None,
        group_template_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 外部业务唯一标识（店铺唯一标识）。
        self.business_unique_key = business_unique_key
        # 群头像地址。
        self.group_avatar = group_avatar
        # 群名称。
        self.group_name = group_name
        # 群模板Id。
        self.group_template_id = group_template_id
        # 操作者在业务系统内的唯一标识。
        self.operator_id = operator_id
        # 钉内成员列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.business_unique_key is not None:
            result['businessUniqueKey'] = self.business_unique_key
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('businessUniqueKey') is not None:
            self.business_unique_key = m.get('businessUniqueKey')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateStoreGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        open_conversation_id: str = None,
    ):
        # 钉钉群会话id
        self.conversation_id = conversation_id
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateStoreGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateStoreGroupConversationResponseBody = None,
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
            temp_model = CreateStoreGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteOrgTextEmotionHeaders(TeaModel):
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


class DeleteOrgTextEmotionRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        emotion_ids: List[str] = None,
    ):
        # 表情所属部门Id：
        # -1：当文字表情属于企业层面时使用-1
        # 一级部门Id：当文字表情属于一级部门层面时使用一级部门Id
        self.dept_id = dept_id
        # 要删除的表情Id列表。请注意，该列表中的所有表情Id一定要同属于deptId
        self.emotion_ids = emotion_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_ids is not None:
            result['emotionIds'] = self.emotion_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionIds') is not None:
            self.emotion_ids = m.get('emotionIds')
        return self


class DeleteOrgTextEmotionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 返回结果
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


class DeleteOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteOrgTextEmotionResponseBody = None,
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
            temp_model = DeleteOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DismissGroupConversationHeaders(TeaModel):
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


class DismissGroupConversationRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class DismissGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class DismissGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DismissGroupConversationResponseBody = None,
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
            temp_model = DismissGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConversationUrlHeaders(TeaModel):
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


class GetConversationUrlRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        channel_code: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 钉外账号在业务系统内的唯一标志。
        self.app_user_id = app_user_id
        # 渠道code。
        self.channel_code = channel_code
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 钉内账号userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetConversationUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # ToB会话地址
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


class GetConversationUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetConversationUrlResponseBody = None,
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
            temp_model = GetConversationUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFamilySchoolConversationMsgHeaders(TeaModel):
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


class GetFamilySchoolConversationMsgRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        msg_types: List[int] = None,
        next_token: int = None,
        open_conversation_id: str = None,
        union_id: str = None,
    ):
        # 查询最大消息数
        self.max_results = max_results
        # 要查询的消息类型
        self.msg_types = msg_types
        # 下一次查询的游标，毫秒值
        self.next_token = next_token
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 用户唯一标识
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.msg_types is not None:
            result['msgTypes'] = self.msg_types
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('msgTypes') is not None:
            self.msg_types = m.get('msgTypes')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_type: str = None,
        media_id: str = None,
        size: str = None,
        url: str = None,
        video_pic_media_id: str = None,
    ):
        # 消息mediaId文件名称
        self.file_name = file_name
        # 消息mediaId文件类型
        self.file_type = file_type
        # 消息mediaId
        self.media_id = media_id
        # 消息mediaId文件大小
        self.size = size
        # 消息mediaId对应的下载地址
        self.url = url
        # 视频文件缩略图mediaId
        self.video_pic_media_id = video_pic_media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.size is not None:
            result['size'] = self.size
        if self.url is not None:
            result['url'] = self.url
        if self.video_pic_media_id is not None:
            result['videoPicMediaId'] = self.video_pic_media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('videoPicMediaId') is not None:
            self.video_pic_media_id = m.get('videoPicMediaId')
        return self


class GetFamilySchoolConversationMsgResponseBodyMessages(TeaModel):
    def __init__(
        self,
        content_type: int = None,
        create_at: int = None,
        media_models: List[GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels] = None,
        open_msg_id: str = None,
    ):
        # 消息类型，2-图片、202视频、3100富文本消息
        self.content_type = content_type
        # 消息的创建时间
        self.create_at = create_at
        # media文件对象列表
        self.media_models = media_models
        # 消息的唯一标识
        self.open_msg_id = open_msg_id

    def validate(self):
        if self.media_models:
            for k in self.media_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.create_at is not None:
            result['createAt'] = self.create_at
        result['mediaModels'] = []
        if self.media_models is not None:
            for k in self.media_models:
                result['mediaModels'].append(k.to_map() if k else None)
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        self.media_models = []
        if m.get('mediaModels') is not None:
            for k in m.get('mediaModels'):
                temp_model = GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels()
                self.media_models.append(temp_model.from_map(k))
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        return self


class GetFamilySchoolConversationMsgResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        has_more: str = None,
        messages: List[GetFamilySchoolConversationMsgResponseBodyMessages] = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        # 企业名称，corp123
        self.corp_id = corp_id
        # 是否有更多数据
        self.has_more = has_more
        # 消息数据
        self.messages = messages
        # 查询下次消息的游标,时间毫秒值
        self.next_token = next_token
        # 开放群Id
        self.open_conversation_id = open_conversation_id

    def validate(self):
        if self.messages:
            for k in self.messages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['messages'] = []
        if self.messages is not None:
            for k in self.messages:
                result['messages'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.messages = []
        if m.get('messages') is not None:
            for k in m.get('messages'):
                temp_model = GetFamilySchoolConversationMsgResponseBodyMessages()
                self.messages.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetFamilySchoolConversationMsgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFamilySchoolConversationMsgResponseBody = None,
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
            temp_model = GetFamilySchoolConversationMsgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFamilySchoolConversationsHeaders(TeaModel):
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


class GetFamilySchoolConversationsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        union_id: str = None,
    ):
        # 获取家校群数量
        self.max_results = max_results
        # 时间的毫秒值，分页游标
        self.next_token = next_token
        # 用户身份ID
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFamilySchoolConversationsResponseBodyGroupInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        dept_name_chain: List[str] = None,
        group_name: str = None,
        group_type: str = None,
        join_group_time: int = None,
        open_conversation_id: str = None,
    ):
        # 企业名称
        self.corp_id = corp_id
        # 部门名称链
        self.dept_name_chain = dept_name_chain
        # 群名称
        self.group_name = group_name
        # 群类型
        self.group_type = group_type
        # 进群时间
        self.join_group_time = join_group_time
        # 群开放ID
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_name_chain is not None:
            result['deptNameChain'] = self.dept_name_chain
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.join_group_time is not None:
            result['joinGroupTime'] = self.join_group_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptNameChain') is not None:
            self.dept_name_chain = m.get('deptNameChain')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('joinGroupTime') is not None:
            self.join_group_time = m.get('joinGroupTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetFamilySchoolConversationsResponseBody(TeaModel):
    def __init__(
        self,
        group_info_list: List[GetFamilySchoolConversationsResponseBodyGroupInfoList] = None,
        has_more: str = None,
        next_token: str = None,
    ):
        self.group_info_list = group_info_list
        # 是否还有数据
        self.has_more = has_more
        # 返回下一页游标
        self.next_token = next_token

    def validate(self):
        if self.group_info_list:
            for k in self.group_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfoList'] = []
        if self.group_info_list is not None:
            for k in self.group_info_list:
                result['groupInfoList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_info_list = []
        if m.get('groupInfoList') is not None:
            for k in m.get('groupInfoList'):
                temp_model = GetFamilySchoolConversationsResponseBodyGroupInfoList()
                self.group_info_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetFamilySchoolConversationsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFamilySchoolConversationsResponseBody = None,
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
            temp_model = GetFamilySchoolConversationsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInterconnectionUrlHeaders(TeaModel):
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


class GetInterconnectionUrlRequest(TeaModel):
    def __init__(
        self,
        app_user_avatar: str = None,
        app_user_avatar_type: int = None,
        app_user_id: str = None,
        app_user_mobile_number: str = None,
        app_user_name: str = None,
        msg_page_type: int = None,
        qr_code: str = None,
        signature: str = None,
        source_code: str = None,
        source_type: int = None,
        user_id: str = None,
    ):
        # appUserAvatar
        self.app_user_avatar = app_user_avatar
        # appUserAvatarType
        self.app_user_avatar_type = app_user_avatar_type
        # appUserId
        self.app_user_id = app_user_id
        # appUserMobileNumber
        self.app_user_mobile_number = app_user_mobile_number
        # appUserName
        self.app_user_name = app_user_name
        # msgPageType
        self.msg_page_type = msg_page_type
        # qrCode
        self.qr_code = qr_code
        # signature
        self.signature = signature
        # sourceCode
        self.source_code = source_code
        # sourceType
        self.source_type = source_type
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_avatar is not None:
            result['appUserAvatar'] = self.app_user_avatar
        if self.app_user_avatar_type is not None:
            result['appUserAvatarType'] = self.app_user_avatar_type
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.app_user_mobile_number is not None:
            result['appUserMobileNumber'] = self.app_user_mobile_number
        if self.app_user_name is not None:
            result['appUserName'] = self.app_user_name
        if self.msg_page_type is not None:
            result['msgPageType'] = self.msg_page_type
        if self.qr_code is not None:
            result['qrCode'] = self.qr_code
        if self.signature is not None:
            result['signature'] = self.signature
        if self.source_code is not None:
            result['sourceCode'] = self.source_code
        if self.source_type is not None:
            result['sourceType'] = self.source_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserAvatar') is not None:
            self.app_user_avatar = m.get('appUserAvatar')
        if m.get('appUserAvatarType') is not None:
            self.app_user_avatar_type = m.get('appUserAvatarType')
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('appUserMobileNumber') is not None:
            self.app_user_mobile_number = m.get('appUserMobileNumber')
        if m.get('appUserName') is not None:
            self.app_user_name = m.get('appUserName')
        if m.get('msgPageType') is not None:
            self.msg_page_type = m.get('msgPageType')
        if m.get('qrCode') is not None:
            self.qr_code = m.get('qrCode')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sourceCode') is not None:
            self.source_code = m.get('sourceCode')
        if m.get('sourceType') is not None:
            self.source_type = m.get('sourceType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInterconnectionUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # 会话url
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


class GetInterconnectionUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetInterconnectionUrlResponseBody = None,
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
            temp_model = GetInterconnectionUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSceneGroupInfoHeaders(TeaModel):
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


class GetSceneGroupInfoRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 开放群ID
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetSceneGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        group_url: str = None,
        icon: str = None,
        open_conversation_id: str = None,
        owner_user_id: str = None,
        success: bool = None,
        template_id: str = None,
        title: str = None,
    ):
        # 群url
        self.group_url = group_url
        # 群头像mediaId
        self.icon = icon
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 群主员工id
        self.owner_user_id = owner_user_id
        # result
        self.success = success
        # 场景群模板ID
        self.template_id = template_id
        # 群名称
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.success is not None:
            result['success'] = self.success
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetSceneGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSceneGroupInfoResponseBody = None,
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
            temp_model = GetSceneGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSceneGroupMembersHeaders(TeaModel):
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


class GetSceneGroupMembersRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        cursor: str = None,
        open_conversation_id: str = None,
        size: int = None,
    ):
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 分页游标，首页传0
        self.cursor = cursor
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 本次查询返回数量上限（该入参传入值小于钉钉阈值时不启用）
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class GetSceneGroupMembersResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        member_user_ids: List[str] = None,
        next_cursor: str = None,
        success: bool = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # 群成员员工号
        self.member_user_ids = member_user_ids
        # 下一次请求的游标
        self.next_cursor = next_cursor
        # result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.member_user_ids is not None:
            result['memberUserIds'] = self.member_user_ids
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('memberUserIds') is not None:
            self.member_user_ids = m.get('memberUserIds')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSceneGroupMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSceneGroupMembersResponseBody = None,
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
            temp_model = GetSceneGroupMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupBanWordsHeaders(TeaModel):
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


class GroupBanWordsRequest(TeaModel):
    def __init__(
        self,
        ban_words_mode: int = None,
        open_conversation_id: str = None,
        options: Dict[str, Any] = None,
    ):
        # 禁言模式
        self.ban_words_mode = ban_words_mode
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 扩展参数
        self.options = options

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_mode is not None:
            result['banWordsMode'] = self.ban_words_mode
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.options is not None:
            result['options'] = self.options
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsMode') is not None:
            self.ban_words_mode = m.get('banWordsMode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('options') is not None:
            self.options = m.get('options')
        return self


class GroupBanWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class GroupCapacityInquiryHeaders(TeaModel):
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


class GroupCapacityInquiryRequest(TeaModel):
    def __init__(
        self,
        effective_duration: str = None,
        open_conversation_id: str = None,
        operator: str = None,
        options: Dict[str, Any] = None,
        target_capacity: int = None,
    ):
        # 有效生命周期
        self.effective_duration = effective_duration
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 扩展参数
        self.options = options
        # 目标容量
        self.target_capacity = target_capacity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.effective_duration is not None:
            result['effectiveDuration'] = self.effective_duration
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.options is not None:
            result['options'] = self.options
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('effectiveDuration') is not None:
            self.effective_duration = m.get('effectiveDuration')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        return self


class GroupCapacityInquiryResponseBody(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        created_at: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, Any] = None,
        group_owner: str = None,
        group_title: str = None,
        marked_price: int = None,
        member_count: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        # 实际价格
        self.actual_price = actual_price
        # 群创建时间
        self.created_at = created_at
        # 当前容量
        self.current_capacity = current_capacity
        # 当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 群主userId
        self.group_owner = group_owner
        # 群标题
        self.group_title = group_title
        # 标价
        self.marked_price = marked_price
        # 群人数
        self.member_count = member_count
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title is not None:
            result['groupTitle'] = self.group_title
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitle') is not None:
            self.group_title = m.get('groupTitle')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityInquiryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupCapacityInquiryResponseBody = None,
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
            temp_model = GroupCapacityInquiryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupCapacityOrderConfirmHeaders(TeaModel):
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


class GroupCapacityOrderConfirmRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        order_id: str = None,
    ):
        # 操作人工号
        self.operator = operator
        # 订单号
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class GroupCapacityOrderConfirmResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 本次操作是否成功
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


class GroupCapacityOrderConfirmResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupCapacityOrderConfirmResponseBody = None,
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
            temp_model = GroupCapacityOrderConfirmResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupCapacityOrderPlaceHeaders(TeaModel):
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


class GroupCapacityOrderPlaceRequest(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, Any] = None,
        marked_price: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        # 实际价格
        self.actual_price = actual_price
        # 当前容量
        self.current_capacity = current_capacity
        # 当前操当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 标价
        self.marked_price = marked_price
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityOrderPlaceResponseBody(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, str] = None,
        marked_price: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        order_id: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        # 实际价格
        self.actual_price = actual_price
        # 当前容量
        self.current_capacity = current_capacity
        # 当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 标价
        self.marked_price = marked_price
        # 群标识
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 订单号
        self.order_id = order_id
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityOrderPlaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupCapacityOrderPlaceResponseBody = None,
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
            temp_model = GroupCapacityOrderPlaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupManageQueryHeaders(TeaModel):
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


class GroupManageQueryRequest(TeaModel):
    def __init__(
        self,
        created_after: int = None,
        group_id: str = None,
        group_member_samples: List[str] = None,
        group_owner: str = None,
        group_title_keywords: List[str] = None,
        group_url: str = None,
        max_results: int = None,
        members_over: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        # 建群时间不早于（辅助性条件，结合非排他条件使用）
        self.created_after = created_after
        # 群号
        self.group_id = group_id
        # 群成员样例工号列表
        self.group_member_samples = group_member_samples
        # 群主工号
        self.group_owner = group_owner
        # 群标题关键词列表
        self.group_title_keywords = group_title_keywords
        # 群链接
        self.group_url = group_url
        # 分页拉取的页大小, 最大不可超过1000
        self.max_results = max_results
        # 群成员数下限（辅助性条件，结合非排他条件使用）
        self.members_over = members_over
        # 分页拉取游标, 若不指定，则从头开始拉
        self.next_token = next_token
        # 开放群id
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_after is not None:
            result['createdAfter'] = self.created_after
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_member_samples is not None:
            result['groupMemberSamples'] = self.group_member_samples
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title_keywords is not None:
            result['groupTitleKeywords'] = self.group_title_keywords
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.members_over is not None:
            result['membersOver'] = self.members_over
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAfter') is not None:
            self.created_after = m.get('createdAfter')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupMemberSamples') is not None:
            self.group_member_samples = m.get('groupMemberSamples')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitleKeywords') is not None:
            self.group_title_keywords = m.get('groupTitleKeywords')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('membersOver') is not None:
            self.members_over = m.get('membersOver')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GroupManageQueryResponseBodyGroupInfoList(TeaModel):
    def __init__(
        self,
        ban_words_mode: int = None,
        capacity: int = None,
        created_at: int = None,
        ext_info: Dict[str, Any] = None,
        group_admin_list: List[str] = None,
        group_owner: str = None,
        group_title: str = None,
        member_count: int = None,
        open_conversation_id: str = None,
        type: str = None,
    ):
        # 禁言模式
        self.ban_words_mode = ban_words_mode
        # 群容量
        self.capacity = capacity
        # 群创建时间
        self.created_at = created_at
        # 扩展信息
        self.ext_info = ext_info
        self.group_admin_list = group_admin_list
        # 群主userid
        self.group_owner = group_owner
        # 群标题
        self.group_title = group_title
        # 当前群人数
        self.member_count = member_count
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 群类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_mode is not None:
            result['banWordsMode'] = self.ban_words_mode
        if self.capacity is not None:
            result['capacity'] = self.capacity
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.group_admin_list is not None:
            result['groupAdminList'] = self.group_admin_list
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title is not None:
            result['groupTitle'] = self.group_title
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsMode') is not None:
            self.ban_words_mode = m.get('banWordsMode')
        if m.get('capacity') is not None:
            self.capacity = m.get('capacity')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('groupAdminList') is not None:
            self.group_admin_list = m.get('groupAdminList')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitle') is not None:
            self.group_title = m.get('groupTitle')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GroupManageQueryResponseBody(TeaModel):
    def __init__(
        self,
        group_info_list: List[GroupManageQueryResponseBodyGroupInfoList] = None,
        has_more: bool = None,
        next_token: str = None,
    ):
        # 群信息列表
        self.group_info_list = group_info_list
        # 分页拉取时, 是否还有更多
        self.has_more = has_more
        # 分页拉取游标, 请求下一页时回传
        self.next_token = next_token

    def validate(self):
        if self.group_info_list:
            for k in self.group_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfoList'] = []
        if self.group_info_list is not None:
            for k in self.group_info_list:
                result['groupInfoList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_info_list = []
        if m.get('groupInfoList') is not None:
            for k in m.get('groupInfoList'):
                temp_model = GroupManageQueryResponseBodyGroupInfoList()
                self.group_info_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GroupManageQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupManageQueryResponseBody = None,
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
            temp_model = GroupManageQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupManageReduceHeaders(TeaModel):
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


class GroupManageReduceRequest(TeaModel):
    def __init__(
        self,
        capacity_limit: int = None,
        open_conversation_id: str = None,
        options: Dict[str, Any] = None,
    ):
        # 群容量限定值
        self.capacity_limit = capacity_limit
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 扩展参数
        self.options = options

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.capacity_limit is not None:
            result['capacityLimit'] = self.capacity_limit
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.options is not None:
            result['options'] = self.options
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('capacityLimit') is not None:
            self.capacity_limit = m.get('capacityLimit')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('options') is not None:
            self.options = m.get('options')
        return self


class GroupManageReduceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class InstallRobotToOrgHeaders(TeaModel):
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


class InstallRobotToOrgRequest(TeaModel):
    def __init__(
        self,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        robot_code: str = None,
    ):
        # 简介
        self.brief = brief
        # 描述
        self.description = description
        # 机器人meidaId
        self.icon = icon
        # 机器人名称
        self.name = name
        # 消息回调验证token
        self.outgoing_token = outgoing_token
        # 消息回调地址
        self.outgoing_url = outgoing_url
        # 预览图mediaId
        self.preview_media_id = preview_media_id
        # 机器人编码
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class InstallRobotToOrgResponseBody(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        # Id of the request
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class InstallRobotToOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InstallRobotToOrgResponseBody = None,
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
            temp_model = InstallRobotToOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InteractiveCardCreateInstanceHeaders(TeaModel):
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


class InteractiveCardCreateInstanceRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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


class PrivateDataValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
        card_media_id_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-普通文本类型
        self.card_param_map = card_param_map
        # 卡片模板内容替换参数-多媒体类型
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


class InteractiveCardCreateInstanceRequest(TeaModel):
    def __init__(
        self,
        callback_route_key: str = None,
        card_data: InteractiveCardCreateInstanceRequestCardData = None,
        card_template_id: str = None,
        chat_bot_id: str = None,
        conversation_type: int = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        self.card_data = card_data
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        self.chat_bot_id = chat_bot_id
        # 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        self.conversation_type = conversation_type
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 指定用户可见的按钮列表（key：用户userId；value：用户数据）
        self.private_data = private_data
        # 是否开启卡片纯拉模式
        self.pull_strategy = pull_strategy
        # 接收人userId列表
        self.receiver_user_id_list = receiver_user_id_list
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
        # 用户ID类型：1：staffId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.chat_bot_id is not None:
            result['chatBotId'] = self.chat_bot_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = InteractiveCardCreateInstanceRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('chatBotId') is not None:
            self.chat_bot_id = m.get('chatBotId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class InteractiveCardCreateInstanceResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class InteractiveCardCreateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InteractiveCardCreateInstanceResponseBody = None,
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
            temp_model = InteractiveCardCreateInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListOrgTextEmotionHeaders(TeaModel):
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


class ListOrgTextEmotionResponseBodyResultEmotions(TeaModel):
    def __init__(
        self,
        background_media_id: str = None,
        background_media_id_for_panel: str = None,
        dept_id: int = None,
        emotion_id: str = None,
        emotion_name: str = None,
        status: int = None,
    ):
        # 展示在消息气泡中的文字表情的mediaId
        self.background_media_id = background_media_id
        # 展示在消息长按菜单中的文字表情的mediaId
        self.background_media_id_for_panel = background_media_id_for_panel
        # 表情所属部门Id：
        # -1：该表情为企业层面的文字表情
        # 一级部门Id：该表情为一级部门层面的文字表情
        self.dept_id = dept_id
        # 表情Id
        self.emotion_id = emotion_id
        # 表情名称，对用户不可见
        self.emotion_name = emotion_name
        # 表情状态
        # 0：已删除
        # 1：可用
        # 2：安全审核不通过
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_media_id is not None:
            result['backgroundMediaId'] = self.background_media_id
        if self.background_media_id_for_panel is not None:
            result['backgroundMediaIdForPanel'] = self.background_media_id_for_panel
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_id is not None:
            result['emotionId'] = self.emotion_id
        if self.emotion_name is not None:
            result['emotionName'] = self.emotion_name
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundMediaId') is not None:
            self.background_media_id = m.get('backgroundMediaId')
        if m.get('backgroundMediaIdForPanel') is not None:
            self.background_media_id_for_panel = m.get('backgroundMediaIdForPanel')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionId') is not None:
            self.emotion_id = m.get('emotionId')
        if m.get('emotionName') is not None:
            self.emotion_name = m.get('emotionName')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListOrgTextEmotionResponseBodyResult(TeaModel):
    def __init__(
        self,
        emotions: List[ListOrgTextEmotionResponseBodyResultEmotions] = None,
    ):
        # 企业文字表情列表
        self.emotions = emotions

    def validate(self):
        if self.emotions:
            for k in self.emotions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['emotions'] = []
        if self.emotions is not None:
            for k in self.emotions:
                result['emotions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emotions = []
        if m.get('emotions') is not None:
            for k in m.get('emotions'):
                temp_model = ListOrgTextEmotionResponseBodyResultEmotions()
                self.emotions.append(temp_model.from_map(k))
        return self


class ListOrgTextEmotionResponseBody(TeaModel):
    def __init__(
        self,
        result: ListOrgTextEmotionResponseBodyResult = None,
        success: bool = None,
    ):
        # 拉取企业文字表情结果
        self.result = result
        # 返回结果
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
            temp_model = ListOrgTextEmotionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListOrgTextEmotionResponseBody = None,
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
            temp_model = ListOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupInfoByMemberAuthHeaders(TeaModel):
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


class QueryGroupInfoByMemberAuthRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 群的openConversationId
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupInfoByMemberAuthResponseBody(TeaModel):
    def __init__(
        self,
        member_count: int = None,
    ):
        # 群内总人数
        self.member_count = member_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        return self


class QueryGroupInfoByMemberAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupInfoByMemberAuthResponseBody = None,
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
            temp_model = QueryGroupInfoByMemberAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMemberHeaders(TeaModel):
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


class QueryGroupMemberRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberResponseBodyGroupMembers(TeaModel):
    def __init__(
        self,
        group_member_avatar: str = None,
        group_member_dynamics: str = None,
        group_member_id: str = None,
        group_member_name: str = None,
        group_member_type: int = None,
    ):
        # 群成员头像地址。
        self.group_member_avatar = group_member_avatar
        # 群成员动态信息。
        self.group_member_dynamics = group_member_dynamics
        # 群成员Id。
        self.group_member_id = group_member_id
        # 群成员名称。
        self.group_member_name = group_member_name
        # 群成员类型。
        self.group_member_type = group_member_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_member_avatar is not None:
            result['groupMemberAvatar'] = self.group_member_avatar
        if self.group_member_dynamics is not None:
            result['groupMemberDynamics'] = self.group_member_dynamics
        if self.group_member_id is not None:
            result['groupMemberId'] = self.group_member_id
        if self.group_member_name is not None:
            result['groupMemberName'] = self.group_member_name
        if self.group_member_type is not None:
            result['groupMemberType'] = self.group_member_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMemberAvatar') is not None:
            self.group_member_avatar = m.get('groupMemberAvatar')
        if m.get('groupMemberDynamics') is not None:
            self.group_member_dynamics = m.get('groupMemberDynamics')
        if m.get('groupMemberId') is not None:
            self.group_member_id = m.get('groupMemberId')
        if m.get('groupMemberName') is not None:
            self.group_member_name = m.get('groupMemberName')
        if m.get('groupMemberType') is not None:
            self.group_member_type = m.get('groupMemberType')
        return self


class QueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        group_members: List[QueryGroupMemberResponseBodyGroupMembers] = None,
        open_conversation_id: str = None,
    ):
        # 群成员列表。
        self.group_members = group_members
        # 群会话Id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        if self.group_members:
            for k in self.group_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMembers'] = []
        if self.group_members is not None:
            for k in self.group_members:
                result['groupMembers'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_members = []
        if m.get('groupMembers') is not None:
            for k in m.get('groupMembers'):
                temp_model = QueryGroupMemberResponseBodyGroupMembers()
                self.group_members.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupMemberResponseBody = None,
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
            temp_model = QueryGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMemberByMemberAuthHeaders(TeaModel):
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


class QueryGroupMemberByMemberAuthRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 群的openConversationId
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList(TeaModel):
    def __init__(
        self,
        group_nick_name: str = None,
        org_name: str = None,
        profile_photo_url: str = None,
        user_id: str = None,
    ):
        # 群内昵称
        # 
        self.group_nick_name = group_nick_name
        # 企业内成员姓名
        self.org_name = org_name
        # 头像url
        self.profile_photo_url = profile_photo_url
        # 员工id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_nick_name is not None:
            result['groupNickName'] = self.group_nick_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.profile_photo_url is not None:
            result['profilePhotoUrl'] = self.profile_photo_url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNickName') is not None:
            self.group_nick_name = m.get('groupNickName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('profilePhotoUrl') is not None:
            self.profile_photo_url = m.get('profilePhotoUrl')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGroupMemberByMemberAuthResponseBody(TeaModel):
    def __init__(
        self,
        group_member_list: List[QueryGroupMemberByMemberAuthResponseBodyGroupMemberList] = None,
    ):
        # 群成员列表
        self.group_member_list = group_member_list

    def validate(self):
        if self.group_member_list:
            for k in self.group_member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMemberList'] = []
        if self.group_member_list is not None:
            for k in self.group_member_list:
                result['groupMemberList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_member_list = []
        if m.get('groupMemberList') is not None:
            for k in m.get('groupMemberList'):
                temp_model = QueryGroupMemberByMemberAuthResponseBodyGroupMemberList()
                self.group_member_list.append(temp_model.from_map(k))
        return self


class QueryGroupMemberByMemberAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupMemberByMemberAuthResponseBody = None,
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
            temp_model = QueryGroupMemberByMemberAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMuteStatusHeaders(TeaModel):
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


class QueryGroupMuteStatusRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 开放的会话ID
        self.open_conversation_id = open_conversation_id
        # 群成员的员工工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGroupMuteStatusResponseBodyUserMuteResult(TeaModel):
    def __init__(
        self,
        mute_end_time: int = None,
        mute_start_time: int = None,
        user_mute_mode: bool = None,
    ):
        # 禁言结束时间
        self.mute_end_time = mute_end_time
        # 禁言开始时间
        self.mute_start_time = mute_start_time
        # 成员禁言状态
        self.user_mute_mode = user_mute_mode

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mute_end_time is not None:
            result['muteEndTime'] = self.mute_end_time
        if self.mute_start_time is not None:
            result['muteStartTime'] = self.mute_start_time
        if self.user_mute_mode is not None:
            result['userMuteMode'] = self.user_mute_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('muteEndTime') is not None:
            self.mute_end_time = m.get('muteEndTime')
        if m.get('muteStartTime') is not None:
            self.mute_start_time = m.get('muteStartTime')
        if m.get('userMuteMode') is not None:
            self.user_mute_mode = m.get('userMuteMode')
        return self


class QueryGroupMuteStatusResponseBody(TeaModel):
    def __init__(
        self,
        group_mute_mode: bool = None,
        user_mute_result: QueryGroupMuteStatusResponseBodyUserMuteResult = None,
    ):
        # 群禁言状态
        self.group_mute_mode = group_mute_mode
        self.user_mute_result = user_mute_result

    def validate(self):
        if self.user_mute_result:
            self.user_mute_result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_mute_mode is not None:
            result['groupMuteMode'] = self.group_mute_mode
        if self.user_mute_result is not None:
            result['userMuteResult'] = self.user_mute_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMuteMode') is not None:
            self.group_mute_mode = m.get('groupMuteMode')
        if m.get('userMuteResult') is not None:
            temp_model = QueryGroupMuteStatusResponseBodyUserMuteResult()
            self.user_mute_result = temp_model.from_map(m['userMuteResult'])
        return self


class QueryGroupMuteStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupMuteStatusResponseBody = None,
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
            temp_model = QueryGroupMuteStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMembersOfGroupRoleHeaders(TeaModel):
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


class QueryMembersOfGroupRoleRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_id: str = None,
        timestamp: int = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 开放群角色id
        self.open_role_id = open_role_id
        # 时间戳
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class QueryMembersOfGroupRoleResponseBody(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # userIds
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryMembersOfGroupRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryMembersOfGroupRoleResponseBody = None,
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
            temp_model = QueryMembersOfGroupRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySceneGroupTemplateRobotHeaders(TeaModel):
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


class QuerySceneGroupTemplateRobotRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        robot_code: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class QuerySceneGroupTemplateRobotResponseBodyResult(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        user_id: str = None,
    ):
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySceneGroupTemplateRobotResponseBody(TeaModel):
    def __init__(
        self,
        result: QuerySceneGroupTemplateRobotResponseBodyResult = None,
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
            temp_model = QuerySceneGroupTemplateRobotResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QuerySceneGroupTemplateRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySceneGroupTemplateRobotResponseBody = None,
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
            temp_model = QuerySceneGroupTemplateRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySingleGroupHeaders(TeaModel):
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


class QuerySingleGroupRequestGroupMembers(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        user_id: str = None,
    ):
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 钉内账号userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySingleGroupRequest(TeaModel):
    def __init__(
        self,
        group_members: List[QuerySingleGroupRequestGroupMembers] = None,
        group_template_id: str = None,
    ):
        # 群成员列表。
        self.group_members = group_members
        # 群模版Id。
        self.group_template_id = group_template_id

    def validate(self):
        if self.group_members:
            for k in self.group_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMembers'] = []
        if self.group_members is not None:
            for k in self.group_members:
                result['groupMembers'].append(k.to_map() if k else None)
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_members = []
        if m.get('groupMembers') is not None:
            for k in m.get('groupMembers'):
                temp_model = QuerySingleGroupRequestGroupMembers()
                self.group_members.append(temp_model.from_map(k))
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        return self


class QuerySingleGroupResponseBodyOpenConversations(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 钉外账号在业务系统内的唯一标识。
        self.app_user_id = app_user_id
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 钉内账号userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySingleGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversations: List[QuerySingleGroupResponseBodyOpenConversations] = None,
    ):
        # 群会话列表。
        self.open_conversations = open_conversations

    def validate(self):
        if self.open_conversations:
            for k in self.open_conversations:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['openConversations'] = []
        if self.open_conversations is not None:
            for k in self.open_conversations:
                result['openConversations'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.open_conversations = []
        if m.get('openConversations') is not None:
            for k in m.get('openConversations'):
                temp_model = QuerySingleGroupResponseBodyOpenConversations()
                self.open_conversations.append(temp_model.from_map(k))
        return self


class QuerySingleGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySingleGroupResponseBody = None,
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
            temp_model = QuerySingleGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUnReadMessageHeaders(TeaModel):
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


class QueryUnReadMessageRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        open_conversation_ids: List[str] = None,
    ):
        # 钉外账号在业务系统内的唯一标志。
        self.app_user_id = app_user_id
        # 群会话Id列表。
        self.open_conversation_ids = open_conversation_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        return self


class QueryUnReadMessageResponseBodyUnReadItems(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        un_read_count: int = None,
    ):
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 未读消息数。
        self.un_read_count = un_read_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.un_read_count is not None:
            result['unReadCount'] = self.un_read_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('unReadCount') is not None:
            self.un_read_count = m.get('unReadCount')
        return self


class QueryUnReadMessageResponseBody(TeaModel):
    def __init__(
        self,
        un_read_count: int = None,
        un_read_items: List[QueryUnReadMessageResponseBodyUnReadItems] = None,
    ):
        # 未读消息数。
        self.un_read_count = un_read_count
        # 未读消息列表。
        self.un_read_items = un_read_items

    def validate(self):
        if self.un_read_items:
            for k in self.un_read_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.un_read_count is not None:
            result['unReadCount'] = self.un_read_count
        result['unReadItems'] = []
        if self.un_read_items is not None:
            for k in self.un_read_items:
                result['unReadItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unReadCount') is not None:
            self.un_read_count = m.get('unReadCount')
        self.un_read_items = []
        if m.get('unReadItems') is not None:
            for k in m.get('unReadItems'):
                temp_model = QueryUnReadMessageResponseBodyUnReadItems()
                self.un_read_items.append(temp_model.from_map(k))
        return self


class QueryUnReadMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUnReadMessageResponseBody = None,
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
            temp_model = QueryUnReadMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveRobotFromConversationHeaders(TeaModel):
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


class RemoveRobotFromConversationRequest(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
        open_conversation_id: str = None,
    ):
        # 机器人在会话里的id
        self.chat_bot_user_id = chat_bot_user_id
        # 会话id
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class RemoveRobotFromConversationResponseBody(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
    ):
        # Id of the request
        self.chat_bot_user_id = chat_bot_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        return self


class RemoveRobotFromConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveRobotFromConversationResponseBody = None,
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
            temp_model = RemoveRobotFromConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendInteractiveCardHeaders(TeaModel):
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


class SendInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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


class SendInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        support_forward: bool = None,
    ):
        # 是否支持转发
        self.support_forward = support_forward

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class SendInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        at_open_ids: Dict[str, str] = None,
        callback_route_key: str = None,
        card_data: SendInteractiveCardRequestCardData = None,
        card_options: SendInteractiveCardRequestCardOptions = None,
        card_template_id: str = None,
        chat_bot_id: str = None,
        conversation_type: int = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        # 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
        self.at_open_ids = at_open_ids
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        # 卡片公共主体部分数据
        self.card_data = card_data
        # 卡片属性
        self.card_options = card_options
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        self.chat_bot_id = chat_bot_id
        # 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        self.conversation_type = conversation_type
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        self.private_data = private_data
        # 是否开启卡片纯拉模式
        self.pull_strategy = pull_strategy
        # 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
        self.receiver_user_id_list = receiver_user_id_list
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
        # 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_open_ids is not None:
            result['atOpenIds'] = self.at_open_ids
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.chat_bot_id is not None:
            result['chatBotId'] = self.chat_bot_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atOpenIds') is not None:
            self.at_open_ids = m.get('atOpenIds')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = SendInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = SendInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('chatBotId') is not None:
            self.chat_bot_id = m.get('chatBotId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class SendInteractiveCardResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        result: SendInteractiveCardResponseBodyResult = None,
        success: bool = None,
    ):
        # 创建卡片结果
        self.result = result
        # success
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
            temp_model = SendInteractiveCardResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendInteractiveCardResponseBody = None,
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
            temp_model = SendInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendOTOInteractiveCardHeaders(TeaModel):
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


class SendOTOInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-普通文本类型
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class SendOTOInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        support_forward: bool = None,
    ):
        # 是否支持转发
        self.support_forward = support_forward

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class SendOTOInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        at_open_ids: Dict[str, str] = None,
        callback_route_key: str = None,
        card_data: SendOTOInteractiveCardRequestCardData = None,
        card_options: SendOTOInteractiveCardRequestCardOptions = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        # 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
        self.at_open_ids = at_open_ids
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        # 卡片公共主体部分数据
        self.card_data = card_data
        # 卡片属性
        self.card_options = card_options
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        self.private_data = private_data
        # 是否开启卡片纯拉模式
        self.pull_strategy = pull_strategy
        # 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
        self.receiver_user_id_list = receiver_user_id_list
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
        # 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_open_ids is not None:
            result['atOpenIds'] = self.at_open_ids
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atOpenIds') is not None:
            self.at_open_ids = m.get('atOpenIds')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = SendOTOInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = SendOTOInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class SendOTOInteractiveCardResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendOTOInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        result: SendOTOInteractiveCardResponseBodyResult = None,
        success: bool = None,
    ):
        # 创建卡片结果
        self.result = result
        # success
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
            temp_model = SendOTOInteractiveCardResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendOTOInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendOTOInteractiveCardResponseBody = None,
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
            temp_model = SendOTOInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendRobotInteractiveCardHeaders(TeaModel):
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


class SendRobotInteractiveCardRequestSendOptions(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_user_list_json: str = None,
        card_property_json: str = None,
        receiver_list_json: str = None,
    ):
        # 是否@所有人
        self.at_all = at_all
        # 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        self.at_user_list_json = at_user_list_json
        # 卡片特殊属性json串
        self.card_property_json = card_property_json
        # 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
        self.receiver_list_json = receiver_list_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_user_list_json is not None:
            result['atUserListJson'] = self.at_user_list_json
        if self.card_property_json is not None:
            result['cardPropertyJson'] = self.card_property_json
        if self.receiver_list_json is not None:
            result['receiverListJson'] = self.receiver_list_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atUserListJson') is not None:
            self.at_user_list_json = m.get('atUserListJson')
        if m.get('cardPropertyJson') is not None:
            self.card_property_json = m.get('cardPropertyJson')
        if m.get('receiverListJson') is not None:
            self.receiver_list_json = m.get('receiverListJson')
        return self


class SendRobotInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_biz_id: str = None,
        card_data: str = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        pull_strategy: bool = None,
        robot_code: str = None,
        send_options: SendRobotInteractiveCardRequestSendOptions = None,
        single_chat_receiver: str = None,
        union_id_private_data_map: str = None,
        user_id_private_data_map: str = None,
    ):
        # 可交互卡片回调的url【可空：不填写无需回调】
        self.callback_url = callback_url
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.card_biz_id = card_biz_id
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片搭建平台模板ID
        self.card_template_id = card_template_id
        # 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
        self.open_conversation_id = open_conversation_id
        # 是否开启卡片纯拉模式
        self.pull_strategy = pull_strategy
        # 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
        self.robot_code = robot_code
        # 互动卡片发送选项
        self.send_options = send_options
        # 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
        self.single_chat_receiver = single_chat_receiver
        # 卡片模板-userId差异用户参数（json结构体）
        self.union_id_private_data_map = union_id_private_data_map
        # 卡片模板-userId差异用户参数（json结构体）
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.send_options:
            self.send_options.validate()

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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.send_options is not None:
            result['sendOptions'] = self.send_options.to_map()
        if self.single_chat_receiver is not None:
            result['singleChatReceiver'] = self.single_chat_receiver
        if self.union_id_private_data_map is not None:
            result['unionIdPrivateDataMap'] = self.union_id_private_data_map
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
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('sendOptions') is not None:
            temp_model = SendRobotInteractiveCardRequestSendOptions()
            self.send_options = temp_model.from_map(m['sendOptions'])
        if m.get('singleChatReceiver') is not None:
            self.single_chat_receiver = m.get('singleChatReceiver')
        if m.get('unionIdPrivateDataMap') is not None:
            self.union_id_private_data_map = m.get('unionIdPrivateDataMap')
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class SendRobotInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendRobotInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendRobotInteractiveCardResponseBody = None,
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
            temp_model = SendRobotInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendRobotMessageHeaders(TeaModel):
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


class SendRobotMessageRequest(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_app_user_id: str = None,
        at_ding_user_id: str = None,
        msg_content: str = None,
        msg_type: str = None,
        open_conversation_ids: List[str] = None,
        robot_code: str = None,
    ):
        # @群所有人为true， 默认false。
        self.at_all = at_all
        # @钉外账号在业务系统内的唯一标志。
        self.at_app_user_id = at_app_user_id
        # @钉内账号userId。
        self.at_ding_user_id = at_ding_user_id
        # 消息体内容，按照下面参考示例格式上传。
        self.msg_content = msg_content
        # 消息类型 文本：text，图片：photo，markdown：markdown，actionCard：actionCard。
        self.msg_type = msg_type
        # 群会话Id列表。
        self.open_conversation_ids = open_conversation_ids
        # 机器人robotId（robotCode），指定哪个机器人发送消息
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_app_user_id is not None:
            result['atAppUserId'] = self.at_app_user_id
        if self.at_ding_user_id is not None:
            result['atDingUserId'] = self.at_ding_user_id
        if self.msg_content is not None:
            result['msgContent'] = self.msg_content
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atAppUserId') is not None:
            self.at_app_user_id = m.get('atAppUserId')
        if m.get('atDingUserId') is not None:
            self.at_ding_user_id = m.get('atDingUserId')
        if m.get('msgContent') is not None:
            self.msg_content = m.get('msgContent')
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class SendRobotMessageResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 本次操作是否成功。
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


class SendRobotMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendRobotMessageResponseBody = None,
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
            temp_model = SendRobotMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendTemplateInteractiveCardHeaders(TeaModel):
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


class SendTemplateInteractiveCardRequestSendOptions(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_user_list_json: str = None,
        card_property_json: str = None,
        receiver_list_json: str = None,
    ):
        # 是否@所有人
        self.at_all = at_all
        # 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        self.at_user_list_json = at_user_list_json
        # 卡片特殊属性json串
        self.card_property_json = card_property_json
        # 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
        self.receiver_list_json = receiver_list_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_user_list_json is not None:
            result['atUserListJson'] = self.at_user_list_json
        if self.card_property_json is not None:
            result['cardPropertyJson'] = self.card_property_json
        if self.receiver_list_json is not None:
            result['receiverListJson'] = self.receiver_list_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atUserListJson') is not None:
            self.at_user_list_json = m.get('atUserListJson')
        if m.get('cardPropertyJson') is not None:
            self.card_property_json = m.get('cardPropertyJson')
        if m.get('receiverListJson') is not None:
            self.receiver_list_json = m.get('receiverListJson')
        return self


class SendTemplateInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_data: str = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        robot_code: str = None,
        send_options: SendTemplateInteractiveCardRequestSendOptions = None,
        single_chat_receiver: str = None,
    ):
        # 可控制卡片回调的url【可空：不填写无需回调】
        self.callback_url = callback_url
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片内容模板ID，响应模板目前有：TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04 4种
        self.card_template_id = card_template_id
        # 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.out_track_id = out_track_id
        # 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
        self.robot_code = robot_code
        # 互动卡片发送选项
        self.send_options = send_options
        # 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
        self.single_chat_receiver = single_chat_receiver

    def validate(self):
        if self.send_options:
            self.send_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.send_options is not None:
            result['sendOptions'] = self.send_options.to_map()
        if self.single_chat_receiver is not None:
            result['singleChatReceiver'] = self.single_chat_receiver
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('sendOptions') is not None:
            temp_model = SendTemplateInteractiveCardRequestSendOptions()
            self.send_options = temp_model.from_map(m['sendOptions'])
        if m.get('singleChatReceiver') is not None:
            self.single_chat_receiver = m.get('singleChatReceiver')
        return self


class SendTemplateInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendTemplateInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendTemplateInteractiveCardResponseBody = None,
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
            temp_model = SendTemplateInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRightPanelHeaders(TeaModel):
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


class SetRightPanelRequestWebWndParams(TeaModel):
    def __init__(
        self,
        target_url: str = None,
    ):
        # 侧边栏URL
        self.target_url = target_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_url is not None:
            result['targetURL'] = self.target_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetURL') is not None:
            self.target_url = m.get('targetURL')
        return self


class SetRightPanelRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        right_panel_close_permitted: bool = None,
        right_panel_open_status: int = None,
        title: str = None,
        web_wnd_params: SetRightPanelRequestWebWndParams = None,
        width: int = None,
    ):
        # 场景群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 是否允许群成员关闭侧边栏 true-允许 false-不允许
        self.right_panel_close_permitted = right_panel_close_permitted
        # 侧边栏打开状态 1-开启 0-关闭
        self.right_panel_open_status = right_panel_open_status
        # 标题栏文案
        self.title = title
        # 网页侧边栏属性配置
        self.web_wnd_params = web_wnd_params
        # 侧边栏
        self.width = width

    def validate(self):
        if self.web_wnd_params:
            self.web_wnd_params.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.right_panel_close_permitted is not None:
            result['rightPanelClosePermitted'] = self.right_panel_close_permitted
        if self.right_panel_open_status is not None:
            result['rightPanelOpenStatus'] = self.right_panel_open_status
        if self.title is not None:
            result['title'] = self.title
        if self.web_wnd_params is not None:
            result['webWndParams'] = self.web_wnd_params.to_map()
        if self.width is not None:
            result['width'] = self.width
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('rightPanelClosePermitted') is not None:
            self.right_panel_close_permitted = m.get('rightPanelClosePermitted')
        if m.get('rightPanelOpenStatus') is not None:
            self.right_panel_open_status = m.get('rightPanelOpenStatus')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('webWndParams') is not None:
            temp_model = SetRightPanelRequestWebWndParams()
            self.web_wnd_params = temp_model.from_map(m['webWndParams'])
        if m.get('width') is not None:
            self.width = m.get('width')
        return self


class SetRightPanelResponseBody(TeaModel):
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


class SetRightPanelResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SetRightPanelResponseBody = None,
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
            temp_model = SetRightPanelResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TopboxCloseHeaders(TeaModel):
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


class TopboxCloseRequest(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        cool_app_code: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
    ):
        # 发送的会话类型：单聊-0, 群聊-1
        self.conversation_type = conversation_type
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 接收人的员工号列表
        self.receiver_user_id_list = receiver_user_id_list
        # 机器人编码
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class TopboxCloseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class TopboxOpenHeaders(TeaModel):
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


class TopboxOpenRequest(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        cool_app_code: str = None,
        expired_time: int = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        platforms: str = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
    ):
        # 发送的会话类型：单聊-0, 群聊-1
        self.conversation_type = conversation_type
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 吊顶的过期时间（绝对时间）
        self.expired_time = expired_time
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 期望吊顶的端（多个"|"隔开，如："ios|win|"）
        self.platforms = platforms
        # 接收人的员工号列表
        self.receiver_user_id_list = receiver_user_id_list
        # 机器人编码
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.expired_time is not None:
            result['expiredTime'] = self.expired_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.platforms is not None:
            result['platforms'] = self.platforms
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('expiredTime') is not None:
            self.expired_time = m.get('expiredTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('platforms') is not None:
            self.platforms = m.get('platforms')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class TopboxOpenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class UpdateGroupAvatarHeaders(TeaModel):
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


class UpdateGroupAvatarRequest(TeaModel):
    def __init__(
        self,
        group_avatar: str = None,
        open_conversation_id: str = None,
    ):
        # 群头像地址。
        self.group_avatar = group_avatar
        # 群会话id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class UpdateGroupAvatarResponseBody(TeaModel):
    def __init__(
        self,
        new_group_avatar: str = None,
    ):
        # 新头像地址。
        self.new_group_avatar = new_group_avatar

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_avatar is not None:
            result['newGroupAvatar'] = self.new_group_avatar
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupAvatar') is not None:
            self.new_group_avatar = m.get('newGroupAvatar')
        return self


class UpdateGroupAvatarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateGroupAvatarResponseBody = None,
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
            temp_model = UpdateGroupAvatarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupNameHeaders(TeaModel):
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


class UpdateGroupNameRequest(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        open_conversation_id: str = None,
    ):
        # 群名称。
        self.group_name = group_name
        # 群会话id。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class UpdateGroupNameResponseBody(TeaModel):
    def __init__(
        self,
        new_group_name: str = None,
    ):
        # 新群名称
        self.new_group_name = new_group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_name is not None:
            result['newGroupName'] = self.new_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupName') is not None:
            self.new_group_name = m.get('newGroupName')
        return self


class UpdateGroupNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateGroupNameResponseBody = None,
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
            temp_model = UpdateGroupNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupPermissionHeaders(TeaModel):
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


class UpdateGroupPermissionRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        permission_group: str = None,
        status: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群权限项
        self.permission_group = permission_group
        # 状态,0-关闭，1-开启
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.permission_group is not None:
            result['permissionGroup'] = self.permission_group
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('permissionGroup') is not None:
            self.permission_group = m.get('permissionGroup')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateGroupPermissionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # result
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


class UpdateGroupPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateGroupPermissionResponseBody = None,
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
            temp_model = UpdateGroupPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupSubAdminHeaders(TeaModel):
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


class UpdateGroupSubAdminRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        role: int = None,
        user_ids: List[str] = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 2-群管理员 3-普通群成员
        self.role = role
        # 用户ID清单
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.role is not None:
            result['role'] = self.role
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdateGroupSubAdminResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
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


class UpdateGroupSubAdminResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateGroupSubAdminResponseBody = None,
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
            temp_model = UpdateGroupSubAdminResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInteractiveCardHeaders(TeaModel):
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


class UpdateInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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


class UpdateInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        # 按key更新cardData数据(不填默认覆盖更新)
        self.update_card_data_by_key = update_card_data_by_key
        # 按key更新privateData用户数据(不填默认覆盖更新)
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


class UpdateInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        card_data: UpdateInteractiveCardRequestCardData = None,
        card_options: UpdateInteractiveCardRequestCardOptions = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        user_id_type: int = None,
    ):
        # 卡片公共主体部分数据
        self.card_data = card_data
        # 发送可交互卡片的一些功能选项
        self.card_options = card_options
        # 唯一标识一张卡片的外部ID
        self.out_track_id = out_track_id
        # 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        self.private_data = private_data
        # 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardData') is not None:
            temp_model = UpdateInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = UpdateInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class UpdateInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        # result
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


class UpdateInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInteractiveCardResponseBody = None,
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
            temp_model = UpdateInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMemberBanWordsHeaders(TeaModel):
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


class UpdateMemberBanWordsRequest(TeaModel):
    def __init__(
        self,
        mute_duration: int = None,
        mute_status: int = None,
        open_conversation_id: str = None,
        user_id_list: List[str] = None,
    ):
        # 禁言持续时长（单位：毫秒）
        self.mute_duration = mute_duration
        # 禁言状态(0表示取消禁言，1表示禁言)
        self.mute_status = mute_status
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 需要禁言或取消禁言的群成员列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mute_duration is not None:
            result['muteDuration'] = self.mute_duration
        if self.mute_status is not None:
            result['muteStatus'] = self.mute_status
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('muteDuration') is not None:
            self.mute_duration = m.get('muteDuration')
        if m.get('muteStatus') is not None:
            self.mute_status = m.get('muteStatus')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class UpdateMemberBanWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class UpdateMemberGroupNickHeaders(TeaModel):
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


class UpdateMemberGroupNickRequest(TeaModel):
    def __init__(
        self,
        group_nick: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 群昵称
        self.group_nick = group_nick
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_nick is not None:
            result['groupNick'] = self.group_nick
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNick') is not None:
            self.group_nick = m.get('groupNick')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateMemberGroupNickResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # result
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


class UpdateMemberGroupNickResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateMemberGroupNickResponseBody = None,
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
            temp_model = UpdateMemberGroupNickResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRobotInOrgHeaders(TeaModel):
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


class UpdateRobotInOrgRequest(TeaModel):
    def __init__(
        self,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        robot_code: str = None,
    ):
        # 简介
        self.brief = brief
        # 描述
        self.description = description
        # 机器人meidaId
        self.icon = icon
        # 机器人名称
        self.name = name
        # 消息回调验证token
        self.outgoing_token = outgoing_token
        # 消息回调地址
        self.outgoing_url = outgoing_url
        # 预览图mediaId
        self.preview_media_id = preview_media_id
        # 机器人编码
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class UpdateRobotInOrgResponseBody(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        # Id of the request
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class UpdateRobotInOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateRobotInOrgResponseBody = None,
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
            temp_model = UpdateRobotInOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRobotInteractiveCardHeaders(TeaModel):
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


class UpdateRobotInteractiveCardRequestUpdateOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        # 按key更新数据(默认全量更新)
        self.update_card_data_by_key = update_card_data_by_key
        # 按key更新用户数据(默认全量更新)
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


class UpdateRobotInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        card_biz_id: str = None,
        card_data: str = None,
        union_id_private_data_map: str = None,
        update_options: UpdateRobotInteractiveCardRequestUpdateOptions = None,
        user_id_private_data_map: str = None,
    ):
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.card_biz_id = card_biz_id
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片模板-userId差异用户参数（json结构体）
        self.union_id_private_data_map = union_id_private_data_map
        # 互动卡片更新选项
        self.update_options = update_options
        # 卡片模板-userId差异用户参数（json结构体）
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
        if self.union_id_private_data_map is not None:
            result['unionIdPrivateDataMap'] = self.union_id_private_data_map
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
        if m.get('unionIdPrivateDataMap') is not None:
            self.union_id_private_data_map = m.get('unionIdPrivateDataMap')
        if m.get('updateOptions') is not None:
            temp_model = UpdateRobotInteractiveCardRequestUpdateOptions()
            self.update_options = temp_model.from_map(m['updateOptions'])
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class UpdateRobotInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 用于业务方后续查看已读列表的查询key
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class UpdateRobotInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateRobotInteractiveCardResponseBody = None,
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
            temp_model = UpdateRobotInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTheGroupRolesOfGroupMemberHeaders(TeaModel):
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


class UpdateTheGroupRolesOfGroupMemberRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_ids: List[str] = None,
        user_id: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群角色列表
        self.open_role_ids = open_role_ids
        # 用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_role_ids is not None:
            result['openRoleIds'] = self.open_role_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleIds') is not None:
            self.open_role_ids = m.get('openRoleIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateTheGroupRolesOfGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # result
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


class UpdateTheGroupRolesOfGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateTheGroupRolesOfGroupMemberResponseBody = None,
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
            temp_model = UpdateTheGroupRolesOfGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddGroupMemberHeaders(TeaModel):
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


class AddGroupMemberRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        open_conversation_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # 钉外成员列表。
        self.app_user_ids = app_user_ids
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 操作者在业务系统内的唯一标识。
        self.operator_id = operator_id
        # 钉内成员列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        user_ids: List[str] = None,
    ):
        # 添加成功的钉外账号列表。
        self.app_user_ids = app_user_ids
        # 添加成功的钉内账号列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddGroupMemberResponseBody = None,
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
            temp_model = AddGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveGroupMemberHeaders(TeaModel):
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


class RemoveGroupMemberRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        open_conversation_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # 钉外成员列表。
        self.app_user_ids = app_user_ids
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 操作者在业务系统内的唯一标识。
        self.operator_id = operator_id
        # 钉内成员列表。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RemoveGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        # 操作结果
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class RemoveGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveGroupMemberResponseBody = None,
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
            temp_model = RemoveGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendDingMessageHeaders(TeaModel):
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


class SendDingMessageRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        message: str = None,
        message_type: str = None,
        open_conversation_id: str = None,
        receiver_id: str = None,
        sender_id: str = None,
    ):
        # 钉内用户oauth2.0授权码。
        self.code = code
        # 消息内容。
        self.message = message
        # 消息类型
        self.message_type = message_type
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 钉外账号在业务系统内的唯一标志。
        self.receiver_id = receiver_id
        # 钉内账号userId。
        self.sender_id = sender_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_id is not None:
            result['receiverId'] = self.receiver_id
        if self.sender_id is not None:
            result['senderId'] = self.sender_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverId') is not None:
            self.receiver_id = m.get('receiverId')
        if m.get('senderId') is not None:
            self.sender_id = m.get('senderId')
        return self


class SendDingMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # 发送消息请求Id。
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class SendDingMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendDingMessageResponseBody = None,
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
            temp_model = SendDingMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMessageHeaders(TeaModel):
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


class SendMessageRequest(TeaModel):
    def __init__(
        self,
        message: str = None,
        message_type: str = None,
        open_conversation_id: str = None,
        receiver_id: str = None,
        sender_id: str = None,
        source_infos: Dict[str, Any] = None,
    ):
        # 消息内容。
        self.message = message
        # 消息类型。
        self.message_type = message_type
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # 钉内账号userId。
        self.receiver_id = receiver_id
        # 钉外账号在业务系统内的唯一标志。
        self.sender_id = sender_id
        # 渠道按钮跳转信息。
        self.source_infos = source_infos

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_id is not None:
            result['receiverId'] = self.receiver_id
        if self.sender_id is not None:
            result['senderId'] = self.sender_id
        if self.source_infos is not None:
            result['sourceInfos'] = self.source_infos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverId') is not None:
            self.receiver_id = m.get('receiverId')
        if m.get('senderId') is not None:
            self.sender_id = m.get('senderId')
        if m.get('sourceInfos') is not None:
            self.source_infos = m.get('sourceInfos')
        return self


class SendMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # 发送消息请求Id。
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class SendMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendMessageResponseBody = None,
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
            temp_model = SendMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


