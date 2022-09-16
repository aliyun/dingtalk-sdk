# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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
        cause: str = None,
        code: int = None,
    ):
        self.cause = cause
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
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
        conf_title: str = None,
        invite_caller: bool = None,
        invite_user_ids: List[str] = None,
        user_id: str = None,
    ):
        # 会议主题： 文字，不超过20中文
        self.conf_title = conf_title
        # 是否邀请主叫
        self.invite_caller = invite_caller
        # 邀请参会人员UID列表（必须好友或同事）
        self.invite_user_ids = invite_user_ids
        # 会议发起人UID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conf_title is not None:
            result['confTitle'] = self.conf_title
        if self.invite_caller is not None:
            result['inviteCaller'] = self.invite_caller
        if self.invite_user_ids is not None:
            result['inviteUserIds'] = self.invite_user_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confTitle') is not None:
            self.conf_title = m.get('confTitle')
        if m.get('inviteCaller') is not None:
            self.invite_caller = m.get('inviteCaller')
        if m.get('inviteUserIds') is not None:
            self.invite_user_ids = m.get('inviteUserIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        conference_password: str = None,
        external_link_url: str = None,
        host_password: str = None,
        phone_numbers: List[str] = None,
        room_code: str = None,
    ):
        # conferenceId
        self.conference_id = conference_id
        # 会议密码
        self.conference_password = conference_password
        # 入会链接
        self.external_link_url = external_link_url
        # 主持人密码
        self.host_password = host_password
        # 电话入会号码
        self.phone_numbers = phone_numbers
        self.room_code = room_code

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
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.host_password is not None:
            result['hostPassword'] = self.host_password
        if self.phone_numbers is not None:
            result['phoneNumbers'] = self.phone_numbers
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('conferencePassword') is not None:
            self.conference_password = m.get('conferencePassword')
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('hostPassword') is not None:
            self.host_password = m.get('hostPassword')
        if m.get('phoneNumbers') is not None:
            self.phone_numbers = m.get('phoneNumbers')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
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


class QueryCloudRecordTextHeaders(TeaModel):
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


class QueryCloudRecordTextRequest(TeaModel):
    def __init__(
        self,
        direction: str = None,
        max_results: int = None,
        next_token: int = None,
        start_time: int = None,
        union_id: str = None,
    ):
        # 0-向前查询，1-向后查询 。 向前查询：此次查询按照时间由小到大的顺序进行。
        self.direction = direction
        # 单页查询的最大条目数，最多2000
        self.max_results = max_results
        # 游标，第一次查询可为空，之后每次带上一次的游标
        self.next_token = next_token
        # 开始时间
        self.start_time = start_time
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.direction is not None:
            result['direction'] = self.direction
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('direction') is not None:
            self.direction = m.get('direction')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        word: str = None,
        word_id: str = None,
    ):
        # 结束时间
        self.end_time = end_time
        # 开始时间
        self.start_time = start_time
        # 单词
        self.word = word
        # 单词id
        self.word_id = word_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.word is not None:
            result['word'] = self.word
        if self.word_id is not None:
            result['wordId'] = self.word_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('word') is not None:
            self.word = m.get('word')
        if m.get('wordId') is not None:
            self.word_id = m.get('wordId')
        return self


class QueryCloudRecordTextResponseBodyParagraphListSentenceList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        sentence: str = None,
        start_time: int = None,
        union_id: str = None,
        word_list: List[QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList] = None,
    ):
        # 结束时间
        self.end_time = end_time
        # 句子
        self.sentence = sentence
        # 开始时间
        self.start_time = start_time
        # 用户unionId
        self.union_id = union_id
        # 单词列表
        self.word_list = word_list

    def validate(self):
        if self.word_list:
            for k in self.word_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.sentence is not None:
            result['sentence'] = self.sentence
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        result['wordList'] = []
        if self.word_list is not None:
            for k in self.word_list:
                result['wordList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('sentence') is not None:
            self.sentence = m.get('sentence')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        self.word_list = []
        if m.get('wordList') is not None:
            for k in m.get('wordList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList()
                self.word_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordTextResponseBodyParagraphList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        next_ttoken: int = None,
        nick_name: str = None,
        paragraph: str = None,
        record_id: int = None,
        sentence_list: List[QueryCloudRecordTextResponseBodyParagraphListSentenceList] = None,
        start_time: int = None,
        status: int = None,
        union_id: str = None,
    ):
        # 结束时间，毫秒
        self.end_time = end_time
        # 游标，下次查询时使用
        self.next_ttoken = next_ttoken
        # 发言人昵称
        self.nick_name = nick_name
        # 段落内容
        self.paragraph = paragraph
        # 云录制id
        self.record_id = record_id
        # 句子列表
        self.sentence_list = sentence_list
        # 开始时间，毫秒
        self.start_time = start_time
        # 状态，暂不解析
        self.status = status
        # 发言人unionId
        self.union_id = union_id

    def validate(self):
        if self.sentence_list:
            for k in self.sentence_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.next_ttoken is not None:
            result['nextTtoken'] = self.next_ttoken
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph
        if self.record_id is not None:
            result['recordId'] = self.record_id
        result['sentenceList'] = []
        if self.sentence_list is not None:
            for k in self.sentence_list:
                result['sentenceList'].append(k.to_map() if k else None)
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nextTtoken') is not None:
            self.next_ttoken = m.get('nextTtoken')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('paragraph') is not None:
            self.paragraph = m.get('paragraph')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        self.sentence_list = []
        if m.get('sentenceList') is not None:
            for k in m.get('sentenceList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphListSentenceList()
                self.sentence_list.append(temp_model.from_map(k))
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordTextResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        paragraph_list: List[QueryCloudRecordTextResponseBodyParagraphList] = None,
    ):
        # 是否有更多
        self.has_more = has_more
        # 段落列表
        self.paragraph_list = paragraph_list

    def validate(self):
        if self.paragraph_list:
            for k in self.paragraph_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['paragraphList'] = []
        if self.paragraph_list is not None:
            for k in self.paragraph_list:
                result['paragraphList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.paragraph_list = []
        if m.get('paragraphList') is not None:
            for k in m.get('paragraphList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphList()
                self.paragraph_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCloudRecordTextResponseBody = None,
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
            temp_model = QueryCloudRecordTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCloudRecordVideoHeaders(TeaModel):
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


class QueryCloudRecordVideoRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # 用户id
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


class QueryCloudRecordVideoResponseBodyVideoList(TeaModel):
    def __init__(
        self,
        duration: int = None,
        end_time: int = None,
        file_size: int = None,
        media_id: str = None,
        record_id: str = None,
        record_type: int = None,
        region_id: str = None,
        start_time: int = None,
        union_id: str = None,
    ):
        # 录制持续时间
        self.duration = duration
        # 录制结束时间
        self.end_time = end_time
        # 文件大小
        self.file_size = file_size
        # 媒体文件id，唯一
        self.media_id = media_id
        # 音视频云录制Id，多份视频recordId一样
        self.record_id = record_id
        # 记录类型,0-普通录制，1-合成的文件
        self.record_type = record_type
        # 媒体文件所在集群id
        self.region_id = region_id
        # 录制开始时间
        self.start_time = start_time
        # 录制人UnionId
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.record_id is not None:
            result['recordId'] = self.record_id
        if self.record_type is not None:
            result['recordType'] = self.record_type
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        if m.get('recordType') is not None:
            self.record_type = m.get('recordType')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordVideoResponseBody(TeaModel):
    def __init__(
        self,
        video_list: List[QueryCloudRecordVideoResponseBodyVideoList] = None,
    ):
        # 视频列表
        self.video_list = video_list

    def validate(self):
        if self.video_list:
            for k in self.video_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['videoList'] = []
        if self.video_list is not None:
            for k in self.video_list:
                result['videoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.video_list = []
        if m.get('videoList') is not None:
            for k in m.get('videoList'):
                temp_model = QueryCloudRecordVideoResponseBodyVideoList()
                self.video_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordVideoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCloudRecordVideoResponseBody = None,
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
            temp_model = QueryCloudRecordVideoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCloudRecordVideoPlayInfoHeaders(TeaModel):
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


class QueryCloudRecordVideoPlayInfoRequest(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        region_id: str = None,
        union_id: str = None,
    ):
        # 媒体文件id
        self.media_id = media_id
        # 集群id
        self.region_id = region_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordVideoPlayInfoResponseBody(TeaModel):
    def __init__(
        self,
        duration: int = None,
        file_size: int = None,
        mp_4file_url: str = None,
        play_url: str = None,
        status: int = None,
    ):
        # 时长
        self.duration = duration
        # 大小
        self.file_size = file_size
        # MP4格式下载链接
        self.mp_4file_url = mp_4file_url
        # 在线播放链接
        self.play_url = play_url
        # 状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.mp_4file_url is not None:
            result['mp4FileUrl'] = self.mp_4file_url
        if self.play_url is not None:
            result['playUrl'] = self.play_url
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('mp4FileUrl') is not None:
            self.mp_4file_url = m.get('mp4FileUrl')
        if m.get('playUrl') is not None:
            self.play_url = m.get('playUrl')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryCloudRecordVideoPlayInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCloudRecordVideoPlayInfoResponseBody = None,
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
            temp_model = QueryCloudRecordVideoPlayInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceInfoHeaders(TeaModel):
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


class QueryConferenceInfoResponseBodyConfInfo(TeaModel):
    def __init__(
        self,
        active_num: int = None,
        attend_num: int = None,
        conf_duration: int = None,
        conference_id: str = None,
        creator_id: str = None,
        creator_nick: str = None,
        end_time: int = None,
        external_link_url: str = None,
        invited_num: int = None,
        room_code: str = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
    ):
        # 当前在会人数
        self.active_num = active_num
        # 累积入会人数
        self.attend_num = attend_num
        # 会议时长
        self.conf_duration = conf_duration
        # 会议id
        self.conference_id = conference_id
        # 会议创建人unionId
        self.creator_id = creator_id
        # 会议创建人昵称
        self.creator_nick = creator_nick
        # 会议结束时间
        self.end_time = end_time
        # 会议web入会链接
        self.external_link_url = external_link_url
        # 邀请人数
        self.invited_num = invited_num
        # 会议码
        self.room_code = room_code
        # 会议开始时间
        self.start_time = start_time
        # 会议状态
        # 0 初始化
        # 1 开始
        # 2 结束
        self.status = status
        # 会议标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_num is not None:
            result['activeNum'] = self.active_num
        if self.attend_num is not None:
            result['attendNum'] = self.attend_num
        if self.conf_duration is not None:
            result['confDuration'] = self.conf_duration
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.invited_num is not None:
            result['invitedNum'] = self.invited_num
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeNum') is not None:
            self.active_num = m.get('activeNum')
        if m.get('attendNum') is not None:
            self.attend_num = m.get('attendNum')
        if m.get('confDuration') is not None:
            self.conf_duration = m.get('confDuration')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('invitedNum') is not None:
            self.invited_num = m.get('invitedNum')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryConferenceInfoResponseBody(TeaModel):
    def __init__(
        self,
        conf_info: QueryConferenceInfoResponseBodyConfInfo = None,
    ):
        # 会议信息结构体
        self.conf_info = conf_info

    def validate(self):
        if self.conf_info:
            self.conf_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conf_info is not None:
            result['confInfo'] = self.conf_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confInfo') is not None:
            temp_model = QueryConferenceInfoResponseBodyConfInfo()
            self.conf_info = temp_model.from_map(m['confInfo'])
        return self


class QueryConferenceInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryConferenceInfoResponseBody = None,
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
            temp_model = QueryConferenceInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceInfoBatchHeaders(TeaModel):
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


class QueryConferenceInfoBatchRequest(TeaModel):
    def __init__(
        self,
        conference_id_list: List[str] = None,
    ):
        self.conference_id_list = conference_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id_list is not None:
            result['conferenceIdList'] = self.conference_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceIdList') is not None:
            self.conference_id_list = m.get('conferenceIdList')
        return self


class QueryConferenceInfoBatchResponseBodyInfosUserList(TeaModel):
    def __init__(
        self,
        attend_status: int = None,
        camera_status: int = None,
        mic_status: int = None,
        nick: str = None,
        reject_description: str = None,
        user_id: str = None,
    ):
        # 在会状态
        self.attend_status = attend_status
        # 摄像头状态
        self.camera_status = camera_status
        # 麦克风状态
        self.mic_status = mic_status
        # 名称
        self.nick = nick
        # 拒绝原因
        self.reject_description = reject_description
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_status is not None:
            result['attendStatus'] = self.attend_status
        if self.camera_status is not None:
            result['cameraStatus'] = self.camera_status
        if self.mic_status is not None:
            result['micStatus'] = self.mic_status
        if self.nick is not None:
            result['nick'] = self.nick
        if self.reject_description is not None:
            result['rejectDescription'] = self.reject_description
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendStatus') is not None:
            self.attend_status = m.get('attendStatus')
        if m.get('cameraStatus') is not None:
            self.camera_status = m.get('cameraStatus')
        if m.get('micStatus') is not None:
            self.mic_status = m.get('micStatus')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('rejectDescription') is not None:
            self.reject_description = m.get('rejectDescription')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryConferenceInfoBatchResponseBodyInfos(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        media_status: int = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
        user_list: List[QueryConferenceInfoBatchResponseBodyInfosUserList] = None,
    ):
        # 会议iD
        self.conference_id = conference_id
        # 媒体状态
        self.media_status = media_status
        # 会议开始时间
        self.start_time = start_time
        # 会议状态
        self.status = status
        # 会议名称
        self.title = title
        # 参会用户列表
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
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.media_status is not None:
            result['mediaStatus'] = self.media_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('mediaStatus') is not None:
            self.media_status = m.get('mediaStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = QueryConferenceInfoBatchResponseBodyInfosUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class QueryConferenceInfoBatchResponseBody(TeaModel):
    def __init__(
        self,
        infos: List[QueryConferenceInfoBatchResponseBodyInfos] = None,
    ):
        # 会议详情列表
        self.infos = infos

    def validate(self):
        if self.infos:
            for k in self.infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['infos'] = []
        if self.infos is not None:
            for k in self.infos:
                result['infos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.infos = []
        if m.get('infos') is not None:
            for k in m.get('infos'):
                temp_model = QueryConferenceInfoBatchResponseBodyInfos()
                self.infos.append(temp_model.from_map(k))
        return self


class QueryConferenceInfoBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryConferenceInfoBatchResponseBody = None,
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
            temp_model = QueryConferenceInfoBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceMembersHeaders(TeaModel):
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


class QueryConferenceMembersRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        # 返回的最大结果数
        self.max_results = max_results
        # 分页token
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryConferenceMembersResponseBodyMemberModels(TeaModel):
    def __init__(
        self,
        attend_status: int = None,
        co_host: bool = None,
        conference_id: str = None,
        duration: int = None,
        host: bool = None,
        join_time: int = None,
        leave_time: int = None,
        outer_org_member: bool = None,
        pstn_join: bool = None,
        user_id: str = None,
        user_nick: str = None,
    ):
        # 成员状态 
        # 1 初始化 
        # 2 呼叫中
        # 3 活跃（在会）
        # 4 入会失败（拒接等）
        # 5 被踢
        # 6 离会
        self.attend_status = attend_status
        # 是否为联席主持人
        self.co_host = co_host
        # 会议id
        self.conference_id = conference_id
        # 在会时长
        self.duration = duration
        # 是否为主持人
        self.host = host
        # 入会时间
        self.join_time = join_time
        # 离会时间
        self.leave_time = leave_time
        # 是否为非会议所属企业内成员
        self.outer_org_member = outer_org_member
        # 是否为pstn入会
        self.pstn_join = pstn_join
        # 用户unionId
        self.user_id = user_id
        # 成员昵称
        self.user_nick = user_nick

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_status is not None:
            result['attendStatus'] = self.attend_status
        if self.co_host is not None:
            result['coHost'] = self.co_host
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.host is not None:
            result['host'] = self.host
        if self.join_time is not None:
            result['joinTime'] = self.join_time
        if self.leave_time is not None:
            result['leaveTime'] = self.leave_time
        if self.outer_org_member is not None:
            result['outerOrgMember'] = self.outer_org_member
        if self.pstn_join is not None:
            result['pstnJoin'] = self.pstn_join
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_nick is not None:
            result['userNick'] = self.user_nick
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendStatus') is not None:
            self.attend_status = m.get('attendStatus')
        if m.get('coHost') is not None:
            self.co_host = m.get('coHost')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('host') is not None:
            self.host = m.get('host')
        if m.get('joinTime') is not None:
            self.join_time = m.get('joinTime')
        if m.get('leaveTime') is not None:
            self.leave_time = m.get('leaveTime')
        if m.get('outerOrgMember') is not None:
            self.outer_org_member = m.get('outerOrgMember')
        if m.get('pstnJoin') is not None:
            self.pstn_join = m.get('pstnJoin')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userNick') is not None:
            self.user_nick = m.get('userNick')
        return self


class QueryConferenceMembersResponseBody(TeaModel):
    def __init__(
        self,
        member_models: List[QueryConferenceMembersResponseBodyMemberModels] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        # 成员列表
        self.member_models = member_models
        # 分页查询下一页token
        self.next_token = next_token
        # 本次返回结果数
        self.total_count = total_count

    def validate(self):
        if self.member_models:
            for k in self.member_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberModels'] = []
        if self.member_models is not None:
            for k in self.member_models:
                result['memberModels'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_models = []
        if m.get('memberModels') is not None:
            for k in m.get('memberModels'):
                temp_model = QueryConferenceMembersResponseBodyMemberModels()
                self.member_models.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryConferenceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryConferenceMembersResponseBody = None,
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
            temp_model = QueryConferenceMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartCloudRecordHeaders(TeaModel):
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


class StartCloudRecordRequest(TeaModel):
    def __init__(
        self,
        mode: str = None,
        small_window_position: str = None,
        union_id: str = None,
    ):
        # 录制模版
        self.mode = mode
        # 小窗位置
        self.small_window_position = small_window_position
        # 会议发起人UID
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.small_window_position is not None:
            result['smallWindowPosition'] = self.small_window_position
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('smallWindowPosition') is not None:
            self.small_window_position = m.get('smallWindowPosition')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StartCloudRecordResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 返回码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StartCloudRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartCloudRecordResponseBody = None,
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
            temp_model = StartCloudRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartStreamOutHeaders(TeaModel):
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


class StartStreamOutRequest(TeaModel):
    def __init__(
        self,
        mode: str = None,
        need_host_join: bool = None,
        small_window_position: str = None,
        stream_name: str = None,
        stream_url_list: List[str] = None,
        union_id: str = None,
    ):
        # 布局
        self.mode = mode
        # 是否需要主持人加入后才允许推流
        self.need_host_join = need_host_join
        # 小窗位置
        self.small_window_position = small_window_position
        self.stream_name = stream_name
        # 推流地址列表, 最多10个，需要以RTMP开头
        self.stream_url_list = stream_url_list
        # 主持人UID
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.need_host_join is not None:
            result['needHostJoin'] = self.need_host_join
        if self.small_window_position is not None:
            result['smallWindowPosition'] = self.small_window_position
        if self.stream_name is not None:
            result['streamName'] = self.stream_name
        if self.stream_url_list is not None:
            result['streamUrlList'] = self.stream_url_list
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('needHostJoin') is not None:
            self.need_host_join = m.get('needHostJoin')
        if m.get('smallWindowPosition') is not None:
            self.small_window_position = m.get('smallWindowPosition')
        if m.get('streamName') is not None:
            self.stream_name = m.get('streamName')
        if m.get('streamUrlList') is not None:
            self.stream_url_list = m.get('streamUrlList')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StartStreamOutResponseBody(TeaModel):
    def __init__(
        self,
        fail_stream_map: Dict[str, Any] = None,
        success_stream_map: Dict[str, Any] = None,
    ):
        # 失败的地址与失败原因映射
        self.fail_stream_map = fail_stream_map
        # 成功推流地址与liveId映射
        self.success_stream_map = success_stream_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_stream_map is not None:
            result['failStreamMap'] = self.fail_stream_map
        if self.success_stream_map is not None:
            result['successStreamMap'] = self.success_stream_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failStreamMap') is not None:
            self.fail_stream_map = m.get('failStreamMap')
        if m.get('successStreamMap') is not None:
            self.success_stream_map = m.get('successStreamMap')
        return self


class StartStreamOutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartStreamOutResponseBody = None,
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
            temp_model = StartStreamOutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StopCloudRecordHeaders(TeaModel):
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


class StopCloudRecordRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # 主持人uid
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


class StopCloudRecordResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 返回码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StopCloudRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StopCloudRecordResponseBody = None,
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
            temp_model = StopCloudRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StopStreamOutHeaders(TeaModel):
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


class StopStreamOutRequest(TeaModel):
    def __init__(
        self,
        stop_all_stream: bool = None,
        stream_id: str = None,
        union_id: str = None,
    ):
        # 是否停止所有流，为true时，则不理会streamId字段
        self.stop_all_stream = stop_all_stream
        # 流id
        self.stream_id = stream_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stop_all_stream is not None:
            result['stopAllStream'] = self.stop_all_stream
        if self.stream_id is not None:
            result['streamId'] = self.stream_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('stopAllStream') is not None:
            self.stop_all_stream = m.get('stopAllStream')
        if m.get('streamId') is not None:
            self.stream_id = m.get('streamId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StopStreamOutResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # conferenceId
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StopStreamOutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StopStreamOutResponseBody = None,
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
            temp_model = StopStreamOutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateVideoConferenceExtInfoHeaders(TeaModel):
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


class UpdateVideoConferenceExtInfoResponseBody(TeaModel):
    def __init__(
        self,
        case: str = None,
        code: str = None,
    ):
        # 失败原因
        self.case = case
        # 返回编码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.case is not None:
            result['case'] = self.case
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('case') is not None:
            self.case = m.get('case')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateVideoConferenceExtInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateVideoConferenceExtInfoResponseBody = None,
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
            temp_model = UpdateVideoConferenceExtInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateVideoConferenceSettingHeaders(TeaModel):
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


class UpdateVideoConferenceSettingRequest(TeaModel):
    def __init__(
        self,
        allow_unmute_self: bool = None,
        auto_transfer_host: bool = None,
        forbidden_share_screen: bool = None,
        lock_conference: bool = None,
        mute_all: bool = None,
        only_internal_employees_join: bool = None,
    ):
        # 允许参会人员取消静音
        self.allow_unmute_self = allow_unmute_self
        # 主持人离会，是否自动转移主持人角色
        self.auto_transfer_host = auto_transfer_host
        # 禁止共享屏幕
        self.forbidden_share_screen = forbidden_share_screen
        # 锁定会议，禁止邀请入会
        self.lock_conference = lock_conference
        # 全员静音
        self.mute_all = mute_all
        # 仅允许企业内员工加入会议
        self.only_internal_employees_join = only_internal_employees_join

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_unmute_self is not None:
            result['allowUnmuteSelf'] = self.allow_unmute_self
        if self.auto_transfer_host is not None:
            result['autoTransferHost'] = self.auto_transfer_host
        if self.forbidden_share_screen is not None:
            result['forbiddenShareScreen'] = self.forbidden_share_screen
        if self.lock_conference is not None:
            result['lockConference'] = self.lock_conference
        if self.mute_all is not None:
            result['muteAll'] = self.mute_all
        if self.only_internal_employees_join is not None:
            result['onlyInternalEmployeesJoin'] = self.only_internal_employees_join
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowUnmuteSelf') is not None:
            self.allow_unmute_self = m.get('allowUnmuteSelf')
        if m.get('autoTransferHost') is not None:
            self.auto_transfer_host = m.get('autoTransferHost')
        if m.get('forbiddenShareScreen') is not None:
            self.forbidden_share_screen = m.get('forbiddenShareScreen')
        if m.get('lockConference') is not None:
            self.lock_conference = m.get('lockConference')
        if m.get('muteAll') is not None:
            self.mute_all = m.get('muteAll')
        if m.get('onlyInternalEmployeesJoin') is not None:
            self.only_internal_employees_join = m.get('onlyInternalEmployeesJoin')
        return self


class UpdateVideoConferenceSettingResponseBody(TeaModel):
    def __init__(
        self,
        case: str = None,
        code: str = None,
    ):
        # 结果详情
        self.case = case
        # 返回编码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.case is not None:
            result['case'] = self.case
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('case') is not None:
            self.case = m.get('case')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateVideoConferenceSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateVideoConferenceSettingResponseBody = None,
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
            temp_model = UpdateVideoConferenceSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


