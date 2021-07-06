# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BatchSendOTOHeaders(TeaModel):
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


class BatchSendOTORequest(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
        user_ids: List[str] = None,
        msg_key: str = None,
        msg_param: str = None,
    ):
        # 机器人的robotCode
        self.robot_code = robot_code
        # 被推送会话人员的userId列表
        self.user_ids = user_ids
        # 消息的msgKey
        self.msg_key = msg_key
        # 消息体
        self.msg_param = msg_param

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        return self


class BatchSendOTOResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
        invalid_staff_id_list: List[str] = None,
        flow_controlled_staff_id_list: List[str] = None,
    ):
        # 消息id
        self.process_query_key = process_query_key
        # 无效的用户userId列表
        self.invalid_staff_id_list = invalid_staff_id_list
        # 推送频繁，被限流的用户userId列表
        self.flow_controlled_staff_id_list = flow_controlled_staff_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        if self.invalid_staff_id_list is not None:
            result['invalidStaffIdList'] = self.invalid_staff_id_list
        if self.flow_controlled_staff_id_list is not None:
            result['flowControlledStaffIdList'] = self.flow_controlled_staff_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        if m.get('invalidStaffIdList') is not None:
            self.invalid_staff_id_list = m.get('invalidStaffIdList')
        if m.get('flowControlledStaffIdList') is not None:
            self.flow_controlled_staff_id_list = m.get('flowControlledStaffIdList')
        return self


class BatchSendOTOResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchSendOTOResponseBody = None,
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
            temp_model = BatchSendOTOResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchOTOQueryHeaders(TeaModel):
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


class BatchOTOQueryRequest(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
        process_query_key: str = None,
    ):
        # 机器人robotCode
        self.robot_code = robot_code
        # 消息已读查询标志
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class BatchOTOQueryResponseBodyMessageReadInfoList(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
        read_status: str = None,
        read_timestamp: int = None,
    ):
        # 姓名
        self.name = name
        # 工号
        self.user_id = user_id
        # 已读状态
        self.read_status = read_status
        # 已读时间
        self.read_timestamp = read_timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.read_timestamp is not None:
            result['readTimestamp'] = self.read_timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('readTimestamp') is not None:
            self.read_timestamp = m.get('readTimestamp')
        return self


class BatchOTOQueryResponseBody(TeaModel):
    def __init__(
        self,
        send_status: str = None,
        message_read_info_list: List[BatchOTOQueryResponseBodyMessageReadInfoList] = None,
    ):
        # 消息发送状态
        self.send_status = send_status
        # 消息已读情况
        self.message_read_info_list = message_read_info_list

    def validate(self):
        if self.message_read_info_list:
            for k in self.message_read_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.send_status is not None:
            result['sendStatus'] = self.send_status
        result['messageReadInfoList'] = []
        if self.message_read_info_list is not None:
            for k in self.message_read_info_list:
                result['messageReadInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sendStatus') is not None:
            self.send_status = m.get('sendStatus')
        self.message_read_info_list = []
        if m.get('messageReadInfoList') is not None:
            for k in m.get('messageReadInfoList'):
                temp_model = BatchOTOQueryResponseBodyMessageReadInfoList()
                self.message_read_info_list.append(temp_model.from_map(k))
        return self


class BatchOTOQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchOTOQueryResponseBody = None,
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
            temp_model = BatchOTOQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


