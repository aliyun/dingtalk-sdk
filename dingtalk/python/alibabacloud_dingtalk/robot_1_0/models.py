# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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
        # This parameter is required.
        self.process_query_key = process_query_key
        # This parameter is required.
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
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.read_status = read_status
        # This parameter is required.
        self.read_timestamp = read_timestamp
        # This parameter is required.
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
        self.message_read_info_list = message_read_info_list
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
        status_code: int = None,
        body: BatchOTOQueryResponseBody = None,
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
        # This parameter is required.
        self.chatbot_id = chatbot_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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
        # This parameter is required.
        self.failed_result = failed_result
        # This parameter is required.
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
        status_code: int = None,
        body: BatchRecallGroupResponseBody = None,
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
        # This parameter is required.
        self.process_query_keys = process_query_keys
        # This parameter is required.
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
        self.failed_result = failed_result
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
        status_code: int = None,
        body: BatchRecallOTOResponseBody = None,
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
            temp_model = BatchRecallOTOResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchRecallPrivateChatHeaders(TeaModel):
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


class BatchRecallPrivateChatRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        process_query_keys: List[str] = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.process_query_keys = process_query_keys
        # This parameter is required.
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


class BatchRecallPrivateChatResponseBody(TeaModel):
    def __init__(
        self,
        failed_result: Dict[str, str] = None,
        success_result: List[str] = None,
    ):
        # This parameter is required.
        self.failed_result = failed_result
        # This parameter is required.
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


class BatchRecallPrivateChatResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchRecallPrivateChatResponseBody = None,
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
            temp_model = BatchRecallPrivateChatResponseBody()
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
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        # This parameter is required.
        self.robot_code = robot_code
        # This parameter is required.
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
        self.flow_controlled_staff_id_list = flow_controlled_staff_id_list
        self.invalid_staff_id_list = invalid_staff_id_list
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
        status_code: int = None,
        body: BatchSendOTOResponseBody = None,
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
            temp_model = BatchSendOTOResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ClearRobotPluginHeaders(TeaModel):
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


class ClearRobotPluginRequest(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        # This parameter is required.
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


class ClearRobotPluginResponseBody(TeaModel):
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


class ClearRobotPluginResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ClearRobotPluginResponseBody = None,
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
            temp_model = ClearRobotPluginResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteRobotAiSkillHeaders(TeaModel):
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


class ExecuteRobotAiSkillRequest(TeaModel):
    def __init__(
        self,
        context: Dict[str, Any] = None,
        input: str = None,
        robot_code: str = None,
        skill_id: str = None,
    ):
        self.context = context
        # This parameter is required.
        self.input = input
        # This parameter is required.
        self.robot_code = robot_code
        self.skill_id = skill_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.context is not None:
            result['context'] = self.context
        if self.input is not None:
            result['input'] = self.input
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.skill_id is not None:
            result['skillId'] = self.skill_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('context') is not None:
            self.context = m.get('context')
        if m.get('input') is not None:
            self.input = m.get('input')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('skillId') is not None:
            self.skill_id = m.get('skillId')
        return self


class ExecuteRobotAiSkillResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        skill_execute_id: str = None,
    ):
        self.result = result
        self.skill_execute_id = skill_execute_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.skill_execute_id is not None:
            result['skillExecuteId'] = self.skill_execute_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('skillExecuteId') is not None:
            self.skill_execute_id = m.get('skillExecuteId')
        return self


class ExecuteRobotAiSkillResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteRobotAiSkillResponseBody = None,
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
            temp_model = ExecuteRobotAiSkillResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBotListInGroupHeaders(TeaModel):
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


class GetBotListInGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
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


class GetBotListInGroupResponseBodyChatbotInstanceVOList(TeaModel):
    def __init__(
        self,
        download_icon_url: str = None,
        name: str = None,
        open_robot_type: int = None,
        robot_code: str = None,
    ):
        self.download_icon_url = download_icon_url
        self.name = name
        self.open_robot_type = open_robot_type
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_icon_url is not None:
            result['downloadIconURL'] = self.download_icon_url
        if self.name is not None:
            result['name'] = self.name
        if self.open_robot_type is not None:
            result['openRobotType'] = self.open_robot_type
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadIconURL') is not None:
            self.download_icon_url = m.get('downloadIconURL')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('openRobotType') is not None:
            self.open_robot_type = m.get('openRobotType')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class GetBotListInGroupResponseBody(TeaModel):
    def __init__(
        self,
        chatbot_instance_volist: List[GetBotListInGroupResponseBodyChatbotInstanceVOList] = None,
    ):
        self.chatbot_instance_volist = chatbot_instance_volist

    def validate(self):
        if self.chatbot_instance_volist:
            for k in self.chatbot_instance_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['chatbotInstanceVOList'] = []
        if self.chatbot_instance_volist is not None:
            for k in self.chatbot_instance_volist:
                result['chatbotInstanceVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.chatbot_instance_volist = []
        if m.get('chatbotInstanceVOList') is not None:
            for k in m.get('chatbotInstanceVOList'):
                temp_model = GetBotListInGroupResponseBodyChatbotInstanceVOList()
                self.chatbot_instance_volist.append(temp_model.from_map(k))
        return self


class GetBotListInGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBotListInGroupResponseBody = None,
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
            temp_model = GetBotListInGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ManageSingleChatRobotStatusHeaders(TeaModel):
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


class ManageSingleChatRobotStatusRequest(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
        status: str = None,
    ):
        # This parameter is required.
        self.robot_code = robot_code
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ManageSingleChatRobotStatusResponseBody(TeaModel):
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


class ManageSingleChatRobotStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ManageSingleChatRobotStatusResponseBody = None,
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
            temp_model = ManageSingleChatRobotStatusResponseBody()
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
        self.max_results = max_results
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.process_query_key = process_query_key
        self.robot_code = robot_code
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
        self.has_more = has_more
        self.next_token = next_token
        self.read_user_ids = read_user_ids
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
        status_code: int = None,
        body: OrgGroupQueryResponseBody = None,
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
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.process_query_keys = process_query_keys
        # This parameter is required.
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
        # This parameter is required.
        self.failed_result = failed_result
        # This parameter is required.
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
        status_code: int = None,
        body: OrgGroupRecallResponseBody = None,
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
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        self.open_conversation_id = open_conversation_id
        self.robot_code = robot_code
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
        # This parameter is required.
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
        status_code: int = None,
        body: OrgGroupSendResponseBody = None,
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
            temp_model = OrgGroupSendResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PrivateChatQueryHeaders(TeaModel):
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


class PrivateChatQueryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        process_query_key: str = None,
        robot_code: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.process_query_key = process_query_key
        self.robot_code = robot_code

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
        return self


class PrivateChatQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        read_user_ids: List[str] = None,
        send_status: str = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.read_user_ids = read_user_ids
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


class PrivateChatQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PrivateChatQueryResponseBody = None,
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
            temp_model = PrivateChatQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PrivateChatSendHeaders(TeaModel):
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


class PrivateChatSendRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        msg_key: str = None,
        msg_param: str = None,
        open_conversation_id: str = None,
        robot_code: str = None,
    ):
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        self.open_conversation_id = open_conversation_id
        self.robot_code = robot_code

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
        return self


class PrivateChatSendResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # This parameter is required.
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


class PrivateChatSendResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PrivateChatSendResponseBody = None,
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
            temp_model = PrivateChatSendResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBotInstanceInGroupInfoHeaders(TeaModel):
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


class QueryBotInstanceInGroupInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.robot_code = robot_code

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
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class QueryBotInstanceInGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        open_conversation_ids: List[str] = None,
    ):
        self.has_more = has_more
        self.open_conversation_ids = open_conversation_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        return self


class QueryBotInstanceInGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBotInstanceInGroupInfoResponseBody = None,
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
            temp_model = QueryBotInstanceInGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRobotPluginHeaders(TeaModel):
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


class QueryRobotPluginRequest(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        # This parameter is required.
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


class QueryRobotPluginResponseBodyPluginInfoList(TeaModel):
    def __init__(
        self,
        icon: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
    ):
        self.icon = icon
        self.mobile_url = mobile_url
        self.name = name
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class QueryRobotPluginResponseBody(TeaModel):
    def __init__(
        self,
        plugin_info_list: List[QueryRobotPluginResponseBodyPluginInfoList] = None,
    ):
        self.plugin_info_list = plugin_info_list

    def validate(self):
        if self.plugin_info_list:
            for k in self.plugin_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['pluginInfoList'] = []
        if self.plugin_info_list is not None:
            for k in self.plugin_info_list:
                result['pluginInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.plugin_info_list = []
        if m.get('pluginInfoList') is not None:
            for k in m.get('pluginInfoList'):
                temp_model = QueryRobotPluginResponseBodyPluginInfoList()
                self.plugin_info_list.append(temp_model.from_map(k))
        return self


class QueryRobotPluginResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRobotPluginResponseBody = None,
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
            temp_model = QueryRobotPluginResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RobotMessageFileDownloadHeaders(TeaModel):
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


class RobotMessageFileDownloadRequest(TeaModel):
    def __init__(
        self,
        download_code: str = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.download_code = download_code
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_code is not None:
            result['downloadCode'] = self.download_code
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadCode') is not None:
            self.download_code = m.get('downloadCode')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class RobotMessageFileDownloadResponseBody(TeaModel):
    def __init__(
        self,
        download_url: str = None,
    ):
        # This parameter is required.
        self.download_url = download_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        return self


class RobotMessageFileDownloadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RobotMessageFileDownloadResponseBody = None,
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
            temp_model = RobotMessageFileDownloadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RobotRecallDingHeaders(TeaModel):
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


class RobotRecallDingRequest(TeaModel):
    def __init__(
        self,
        open_ding_id: str = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.open_ding_id = open_ding_id
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ding_id is not None:
            result['openDingId'] = self.open_ding_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openDingId') is not None:
            self.open_ding_id = m.get('openDingId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class RobotRecallDingResponseBody(TeaModel):
    def __init__(
        self,
        open_ding_id: str = None,
    ):
        self.open_ding_id = open_ding_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ding_id is not None:
            result['openDingId'] = self.open_ding_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openDingId') is not None:
            self.open_ding_id = m.get('openDingId')
        return self


class RobotRecallDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RobotRecallDingResponseBody = None,
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
            temp_model = RobotRecallDingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RobotSendDingHeaders(TeaModel):
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


class RobotSendDingRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        receiver_user_id_list: List[str] = None,
        remind_type: int = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.receiver_user_id_list = receiver_user_id_list
        # This parameter is required.
        self.remind_type = remind_type
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.remind_type is not None:
            result['remindType'] = self.remind_type
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('remindType') is not None:
            self.remind_type = m.get('remindType')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class RobotSendDingResponseBody(TeaModel):
    def __init__(
        self,
        failed_list: Dict[str, Any] = None,
        open_ding_id: str = None,
    ):
        # This parameter is required.
        self.failed_list = failed_list
        # This parameter is required.
        self.open_ding_id = open_ding_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed_list is not None:
            result['failedList'] = self.failed_list
        if self.open_ding_id is not None:
            result['openDingId'] = self.open_ding_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failedList') is not None:
            self.failed_list = m.get('failedList')
        if m.get('openDingId') is not None:
            self.open_ding_id = m.get('openDingId')
        return self


class RobotSendDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RobotSendDingResponseBody = None,
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
            temp_model = RobotSendDingResponseBody()
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
        # This parameter is required.
        self.content_params = content_params
        # This parameter is required.
        self.ding_template_id = ding_template_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.receiver_user_id_list = receiver_user_id_list
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: SendRobotDingMessageResponseBody = None,
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
            temp_model = SendRobotDingMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRobotPluginHeaders(TeaModel):
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


class SetRobotPluginRequestPluginInfoList(TeaModel):
    def __init__(
        self,
        icon: str = None,
        mobile_url: str = None,
        name: str = None,
        pc_url: str = None,
    ):
        # This parameter is required.
        self.icon = icon
        self.mobile_url = mobile_url
        # This parameter is required.
        self.name = name
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class SetRobotPluginRequest(TeaModel):
    def __init__(
        self,
        plugin_info_list: List[SetRobotPluginRequestPluginInfoList] = None,
        robot_code: str = None,
    ):
        self.plugin_info_list = plugin_info_list
        self.robot_code = robot_code

    def validate(self):
        if self.plugin_info_list:
            for k in self.plugin_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['pluginInfoList'] = []
        if self.plugin_info_list is not None:
            for k in self.plugin_info_list:
                result['pluginInfoList'].append(k.to_map() if k else None)
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.plugin_info_list = []
        if m.get('pluginInfoList') is not None:
            for k in m.get('pluginInfoList'):
                temp_model = SetRobotPluginRequestPluginInfoList()
                self.plugin_info_list.append(temp_model.from_map(k))
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class SetRobotPluginResponseBody(TeaModel):
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


class SetRobotPluginResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetRobotPluginResponseBody = None,
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
            temp_model = SetRobotPluginResponseBody()
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
        self.brief = brief
        self.description = description
        self.icon = icon
        self.name = name
        # This parameter is required.
        self.robot_code = robot_code
        # This parameter is required.
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
        status_code: int = None,
        body: UpdateInstalledRobotResponseBody = None,
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
            temp_model = UpdateInstalledRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


