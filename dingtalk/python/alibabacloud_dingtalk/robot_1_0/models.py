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
        msg_param: str = None,
        msg_key: str = None,
        open_conversation_id: str = None,
        robot_code: str = None,
        token: str = None,
        cool_app_code: str = None,
        ding_token_grant_type: int = None,
        ding_org_id: int = None,
        ding_corp_id: str = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_client_id: str = None,
    ):
        # 消息体
        self.msg_param = msg_param
        # 消息类型的key
        self.msg_key = msg_key
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 群内机器人的code
        self.robot_code = robot_code
        # 群内机器人的webhook中的Token
        self.token = token
        # 酷应用的code
        self.cool_app_code = cool_app_code
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_org_id = ding_org_id
        self.ding_corp_id = ding_corp_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_client_id = ding_client_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.token is not None:
            result['token'] = self.token
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('token') is not None:
            self.token = m.get('token')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
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
        robot_code: str = None,
        process_query_keys: List[str] = None,
    ):
        # 机器人的robotCode
        self.robot_code = robot_code
        # 消息id
        self.process_query_keys = process_query_keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.process_query_keys is not None:
            result['processQueryKeys'] = self.process_query_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('processQueryKeys') is not None:
            self.process_query_keys = m.get('processQueryKeys')
        return self


class BatchRecallOTOResponseBody(TeaModel):
    def __init__(
        self,
        success_result: List[str] = None,
        failed_result: Dict[str, str] = None,
    ):
        # 撤回成功的消息id
        self.success_result = success_result
        # 撤回失败的消息id及对应的失败原因
        self.failed_result = failed_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success_result is not None:
            result['successResult'] = self.success_result
        if self.failed_result is not None:
            result['failedResult'] = self.failed_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('successResult') is not None:
            self.success_result = m.get('successResult')
        if m.get('failedResult') is not None:
            self.failed_result = m.get('failedResult')
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
        open_conversation_id: str = None,
        chatbot_id: str = None,
        process_query_keys: List[str] = None,
    ):
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 机器人的robotCode
        self.chatbot_id = chatbot_id
        # 消息id
        self.process_query_keys = process_query_keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.process_query_keys is not None:
            result['processQueryKeys'] = self.process_query_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('processQueryKeys') is not None:
            self.process_query_keys = m.get('processQueryKeys')
        return self


class BatchRecallGroupResponseBody(TeaModel):
    def __init__(
        self,
        success_result: List[str] = None,
        failed_result: Dict[str, str] = None,
    ):
        # 撤回成功的消息id
        self.success_result = success_result
        # 撤回失败的消息id及原因
        self.failed_result = failed_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success_result is not None:
            result['successResult'] = self.success_result
        if self.failed_result is not None:
            result['failedResult'] = self.failed_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('successResult') is not None:
            self.success_result = m.get('successResult')
        if m.get('failedResult') is not None:
            self.failed_result = m.get('failedResult')
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
        robot_code: str = None,
        open_conversation_id: str = None,
        receiver_user_id_list: List[str] = None,
        ding_template_id: str = None,
        content_params: Dict[str, str] = None,
    ):
        # 机器人的Id
        self.robot_code = robot_code
        # 群聊的对外开放Id
        self.open_conversation_id = open_conversation_id
        # 接受人的userId列表
        self.receiver_user_id_list = receiver_user_id_list
        # 颁发的模版id，可通过宜搭申请：https://yida.alibaba-inc.com/alibaba/web/APP_NSUGAGIQUMI4ESRA7O7D/inst/homepage/#/FORM-WO866371VGXSECXX4M0NC9KSGAT92VSA3TZSK9B
        self.ding_template_id = ding_template_id
        # 模版对应的参数
        self.content_params = content_params

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.ding_template_id is not None:
            result['dingTemplateId'] = self.ding_template_id
        if self.content_params is not None:
            result['contentParams'] = self.content_params
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('dingTemplateId') is not None:
            self.ding_template_id = m.get('dingTemplateId')
        if m.get('contentParams') is not None:
            self.content_params = m.get('contentParams')
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


