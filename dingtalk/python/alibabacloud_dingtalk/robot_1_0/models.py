# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        process_query_key: str = None,
        robot_code: str = None,
    ):
        # 消息已读查询标志
        self.process_query_key = process_query_key
        # 机器人robotCode
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class BatchOTOQueryResponseBodyMessageReadInfoList(TeaModel):
    def __init__(
        self,
        name: str = None,
        read_status: str = None,
        read_timestamp: int = None,
        user_id: str = None,
    ):
        # 姓名
        self.name = name
        # 已读状态
        self.read_status = read_status
        # 已读时间
        self.read_timestamp = read_timestamp
        # 工号
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
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.read_timestamp is not None:
            result['readTimestamp'] = self.read_timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('readTimestamp') is not None:
            self.read_timestamp = m.get('readTimestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchOTOQueryResponseBody(TeaModel):
    def __init__(
        self,
        message_read_info_list: List[BatchOTOQueryResponseBodyMessageReadInfoList] = None,
        send_status: str = None,
    ):
        # 消息已读情况
        self.message_read_info_list = message_read_info_list
        # 消息发送状态
        self.send_status = send_status

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
        result['messageReadInfoList'] = []
        if self.message_read_info_list is not None:
            for k in self.message_read_info_list:
                result['messageReadInfoList'].append(k.to_map() if k else None)
        if self.send_status is not None:
            result['sendStatus'] = self.send_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.message_read_info_list = []
        if m.get('messageReadInfoList') is not None:
            for k in m.get('messageReadInfoList'):
                temp_model = BatchOTOQueryResponseBodyMessageReadInfoList()
                self.message_read_info_list.append(temp_model.from_map(k))
        if m.get('sendStatus') is not None:
            self.send_status = m.get('sendStatus')
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


class BatchRecallGroupHeaders(TeaModel):
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


class BatchRecallGroupRequest(TeaModel):
    def __init__(
        self,
        chatbot_id: str = None,
        open_conversation_id: str = None,
        process_query_keys: List[str] = None,
    ):
        # 机器人的robotCode
        self.chatbot_id = chatbot_id
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 消息id
        self.process_query_keys = process_query_keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.process_query_keys is not None:
            result['processQueryKeys'] = self.process_query_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('processQueryKeys') is not None:
            self.process_query_keys = m.get('processQueryKeys')
        return self


class BatchRecallGroupResponseBody(TeaModel):
    def __init__(
        self,
        failed_result: Dict[str, str] = None,
        success_result: List[str] = None,
    ):
        # 撤回失败的消息id及原因
        self.failed_result = failed_result
        # 撤回成功的消息id
        self.success_result = success_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed_result is not None:
            result['failedResult'] = self.failed_result
        if self.success_result is not None:
            result['successResult'] = self.success_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failedResult') is not None:
            self.failed_result = m.get('failedResult')
        if m.get('successResult') is not None:
            self.success_result = m.get('successResult')
        return self


class BatchRecallGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchRecallGroupResponseBody = None,
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
            temp_model = BatchRecallGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchRecallOTOHeaders(TeaModel):
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


class BatchRecallOTORequest(TeaModel):
    def __init__(
        self,
        process_query_keys: List[str] = None,
        robot_code: str = None,
    ):
        # 消息id
        self.process_query_keys = process_query_keys
        # 机器人的robotCode
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_keys is not None:
            result['processQueryKeys'] = self.process_query_keys
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKeys') is not None:
            self.process_query_keys = m.get('processQueryKeys')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class BatchRecallOTOResponseBody(TeaModel):
    def __init__(
        self,
        failed_result: Dict[str, str] = None,
        success_result: List[str] = None,
    ):
        # 撤回失败的消息id及对应的失败原因
        self.failed_result = failed_result
        # 撤回成功的消息id
        self.success_result = success_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed_result is not None:
            result['failedResult'] = self.failed_result
        if self.success_result is not None:
            result['successResult'] = self.success_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failedResult') is not None:
            self.failed_result = m.get('failedResult')
        if m.get('successResult') is not None:
            self.success_result = m.get('successResult')
        return self


class BatchRecallOTOResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchRecallOTOResponseBody = None,
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
            temp_model = BatchRecallOTOResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        msg_key: str = None,
        msg_param: str = None,
        robot_code: str = None,
        user_ids: List[str] = None,
    ):
        # 消息的msgKey
        self.msg_key = msg_key
        # 消息体
        self.msg_param = msg_param
        # 机器人的robotCode
        self.robot_code = robot_code
        # 被推送会话人员的userId列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class BatchSendOTOResponseBody(TeaModel):
    def __init__(
        self,
        flow_controlled_staff_id_list: List[str] = None,
        invalid_staff_id_list: List[str] = None,
        process_query_key: str = None,
    ):
        # 推送频繁，被限流的用户userId列表
        self.flow_controlled_staff_id_list = flow_controlled_staff_id_list
        # 无效的用户userId列表
        self.invalid_staff_id_list = invalid_staff_id_list
        # 消息id
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_controlled_staff_id_list is not None:
            result['flowControlledStaffIdList'] = self.flow_controlled_staff_id_list
        if self.invalid_staff_id_list is not None:
            result['invalidStaffIdList'] = self.invalid_staff_id_list
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowControlledStaffIdList') is not None:
            self.flow_controlled_staff_id_list = m.get('flowControlledStaffIdList')
        if m.get('invalidStaffIdList') is not None:
            self.invalid_staff_id_list = m.get('invalidStaffIdList')
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
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


class OrgGroupQueryHeaders(TeaModel):
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


class OrgGroupQueryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        process_query_key: str = None,
        robot_code: str = None,
        token: str = None,
    ):
        # 分页查询每页的数量
        self.max_results = max_results
        # 一次查询后返回的加密的分页凭证，首次查询不填
        self.next_token = next_token
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 发送消息返回的加密消息id
        self.process_query_key = process_query_key
        # 企业机器人的robotcode
        self.robot_code = robot_code
        # 群内机器人的webhook中的Token
        self.token = token

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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class OrgGroupQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        read_user_ids: List[str] = None,
        send_status: str = None,
    ):
        # 分页查询是否还有人员可查询消息已读状态
        self.has_more = has_more
        # 下次分页查询的加密凭证
        self.next_token = next_token
        # 消息已读人的userId列表
        self.read_user_ids = read_user_ids
        # 消息发送状态
        self.send_status = send_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.read_user_ids is not None:
            result['readUserIds'] = self.read_user_ids
        if self.send_status is not None:
            result['sendStatus'] = self.send_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('readUserIds') is not None:
            self.read_user_ids = m.get('readUserIds')
        if m.get('sendStatus') is not None:
            self.send_status = m.get('sendStatus')
        return self


class OrgGroupQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: OrgGroupQueryResponseBody = None,
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
            temp_model = OrgGroupQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OrgGroupRecallHeaders(TeaModel):
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


class OrgGroupRecallRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        process_query_keys: List[str] = None,
        robot_code: str = None,
    ):
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 消息id
        self.process_query_keys = process_query_keys
        # 机器人的robotCode
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
        if self.process_query_keys is not None:
            result['processQueryKeys'] = self.process_query_keys
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('processQueryKeys') is not None:
            self.process_query_keys = m.get('processQueryKeys')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class OrgGroupRecallResponseBody(TeaModel):
    def __init__(
        self,
        failed_result: Dict[str, str] = None,
        success_result: List[str] = None,
    ):
        # 撤回失败的消息id及原因
        self.failed_result = failed_result
        # 撤回成功的消息id
        self.success_result = success_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed_result is not None:
            result['failedResult'] = self.failed_result
        if self.success_result is not None:
            result['successResult'] = self.success_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failedResult') is not None:
            self.failed_result = m.get('failedResult')
        if m.get('successResult') is not None:
            self.success_result = m.get('successResult')
        return self


class OrgGroupRecallResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: OrgGroupRecallResponseBody = None,
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
            temp_model = OrgGroupRecallResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OrgGroupSendHeaders(TeaModel):
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


class OrgGroupSendRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        msg_key: str = None,
        msg_param: str = None,
        open_conversation_id: str = None,
        robot_code: str = None,
        token: str = None,
    ):
        # 酷应用的code
        self.cool_app_code = cool_app_code
        # 消息类型的key
        self.msg_key = msg_key
        # 消息体
        self.msg_param = msg_param
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 群内机器人的code
        self.robot_code = robot_code
        # 群内机器人的webhook中的Token
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class OrgGroupSendResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # 加密消息id
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


class OrgGroupSendResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: OrgGroupSendResponseBody = None,
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
            temp_model = OrgGroupSendResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendRobotDingMessageHeaders(TeaModel):
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


class SendRobotDingMessageRequest(TeaModel):
    def __init__(
        self,
        content_params: Dict[str, str] = None,
        ding_template_id: str = None,
        open_conversation_id: str = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
    ):
        # 模版对应的参数
        self.content_params = content_params
        # 颁发的模版id，可通过宜搭申请：https://yida.alibaba-inc.com/alibaba/web/APP_NSUGAGIQUMI4ESRA7O7D/inst/homepage/#/FORM-WO866371VGXSECXX4M0NC9KSGAT92VSA3TZSK9B
        self.ding_template_id = ding_template_id
        # 群聊的对外开放Id
        self.open_conversation_id = open_conversation_id
        # 接受人的userId列表
        self.receiver_user_id_list = receiver_user_id_list
        # 机器人的Id
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_params is not None:
            result['contentParams'] = self.content_params
        if self.ding_template_id is not None:
            result['dingTemplateId'] = self.ding_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentParams') is not None:
            self.content_params = m.get('contentParams')
        if m.get('dingTemplateId') is not None:
            self.ding_template_id = m.get('dingTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class SendRobotDingMessageResponseBody(TeaModel):
    def __init__(
        self,
        ding_send_result_id: str = None,
    ):
        # 返回的ding消息id
        self.ding_send_result_id = ding_send_result_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_send_result_id is not None:
            result['dingSendResultId'] = self.ding_send_result_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingSendResultId') is not None:
            self.ding_send_result_id = m.get('dingSendResultId')
        return self


class SendRobotDingMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendRobotDingMessageResponseBody = None,
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
            temp_model = SendRobotDingMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInstalledRobotHeaders(TeaModel):
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


class UpdateInstalledRobotRequest(TeaModel):
    def __init__(
        self,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        robot_code: str = None,
        update_type: int = None,
    ):
        # 机器人的简要描述。
        self.brief = brief
        # 机器人的详细描述。
        self.description = description
        # 机器人图标的mediaId。
        self.icon = icon
        # 机器人的名称。
        self.name = name
        # 机器人的robotCode。
        self.robot_code = robot_code
        # 更新名字或头像时是否更新群里已添加机器人的名字或头像。
        # 0-不更新群里机器人名字或头像
        # 1-更新群里机器人名字或头像
        self.update_type = update_type

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
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.update_type is not None:
            result['updateType'] = self.update_type
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
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('updateType') is not None:
            self.update_type = m.get('updateType')
        return self


class UpdateInstalledRobotResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 本次更新操作是否成功。
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


class UpdateInstalledRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInstalledRobotResponseBody = None,
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
            temp_model = UpdateInstalledRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


