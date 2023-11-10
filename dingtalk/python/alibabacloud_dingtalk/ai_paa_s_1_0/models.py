# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


class ExecuteAgentHeaders(TeaModel):
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


class ExecuteAgentRequestInputs(TeaModel):
    def __init__(
        self,
        card_data: Any = None,
        card_template_id: str = None,
        input: str = None,
    ):
        self.card_data = card_data
        self.card_template_id = card_template_id
        self.input = input

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.input is not None:
            result['input'] = self.input
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('input') is not None:
            self.input = m.get('input')
        return self


class ExecuteAgentRequest(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        inputs: ExecuteAgentRequestInputs = None,
        scenario_code: str = None,
        scenario_instance_id: str = None,
        skill_id: str = None,
    ):
        self.agent_code = agent_code
        self.inputs = inputs
        self.scenario_code = scenario_code
        self.scenario_instance_id = scenario_instance_id
        self.skill_id = skill_id

    def validate(self):
        if self.inputs:
            self.inputs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.inputs is not None:
            result['inputs'] = self.inputs.to_map()
        if self.scenario_code is not None:
            result['scenarioCode'] = self.scenario_code
        if self.scenario_instance_id is not None:
            result['scenarioInstanceId'] = self.scenario_instance_id
        if self.skill_id is not None:
            result['skillId'] = self.skill_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('inputs') is not None:
            temp_model = ExecuteAgentRequestInputs()
            self.inputs = temp_model.from_map(m['inputs'])
        if m.get('scenarioCode') is not None:
            self.scenario_code = m.get('scenarioCode')
        if m.get('scenarioInstanceId') is not None:
            self.scenario_instance_id = m.get('scenarioInstanceId')
        if m.get('skillId') is not None:
            self.skill_id = m.get('skillId')
        return self


class ExecuteAgentResponseBodyResult(TeaModel):
    def __init__(
        self,
        execute_result: str = None,
        skill_id: str = None,
    ):
        self.execute_result = execute_result
        self.skill_id = skill_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.execute_result is not None:
            result['executeResult'] = self.execute_result
        if self.skill_id is not None:
            result['skillId'] = self.skill_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executeResult') is not None:
            self.execute_result = m.get('executeResult')
        if m.get('skillId') is not None:
            self.skill_id = m.get('skillId')
        return self


class ExecuteAgentResponseBody(TeaModel):
    def __init__(
        self,
        result: ExecuteAgentResponseBodyResult = None,
    ):
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
            temp_model = ExecuteAgentResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ExecuteAgentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteAgentResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = ExecuteAgentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LiandanluExclusiveModelHeaders(TeaModel):
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


class LiandanluExclusiveModelRequest(TeaModel):
    def __init__(
        self,
        model_id: str = None,
        module: str = None,
        prompt: str = None,
        user_id: str = None,
    ):
        self.model_id = model_id
        self.module = module
        self.prompt = prompt
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.module is not None:
            result['module'] = self.module
        if self.prompt is not None:
            result['prompt'] = self.prompt
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('module') is not None:
            self.module = m.get('module')
        if m.get('prompt') is not None:
            self.prompt = m.get('prompt')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class LiandanluExclusiveModelResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: Dict[str, Any] = None,
    ):
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


class LiandanluExclusiveModelResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LiandanluExclusiveModelResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = LiandanluExclusiveModelResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConversationMessageForAIHeaders(TeaModel):
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


class QueryConversationMessageForAIRequest(TeaModel):
    def __init__(
        self,
        open_msg_ids: List[str] = None,
        recent_days: int = None,
        recent_hours: int = None,
        recent_n: int = None,
    ):
        self.open_msg_ids = open_msg_ids
        self.recent_days = recent_days
        self.recent_hours = recent_hours
        self.recent_n = recent_n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_msg_ids is not None:
            result['openMsgIds'] = self.open_msg_ids
        if self.recent_days is not None:
            result['recentDays'] = self.recent_days
        if self.recent_hours is not None:
            result['recentHours'] = self.recent_hours
        if self.recent_n is not None:
            result['recentN'] = self.recent_n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMsgIds') is not None:
            self.open_msg_ids = m.get('openMsgIds')
        if m.get('recentDays') is not None:
            self.recent_days = m.get('recentDays')
        if m.get('recentHours') is not None:
            self.recent_hours = m.get('recentHours')
        if m.get('recentN') is not None:
            self.recent_n = m.get('recentN')
        return self


class QueryConversationMessageForAIShrinkRequest(TeaModel):
    def __init__(
        self,
        open_msg_ids_shrink: str = None,
        recent_days: int = None,
        recent_hours: int = None,
        recent_n: int = None,
    ):
        self.open_msg_ids_shrink = open_msg_ids_shrink
        self.recent_days = recent_days
        self.recent_hours = recent_hours
        self.recent_n = recent_n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_msg_ids_shrink is not None:
            result['openMsgIds'] = self.open_msg_ids_shrink
        if self.recent_days is not None:
            result['recentDays'] = self.recent_days
        if self.recent_hours is not None:
            result['recentHours'] = self.recent_hours
        if self.recent_n is not None:
            result['recentN'] = self.recent_n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMsgIds') is not None:
            self.open_msg_ids_shrink = m.get('openMsgIds')
        if m.get('recentDays') is not None:
            self.recent_days = m.get('recentDays')
        if m.get('recentHours') is not None:
            self.recent_hours = m.get('recentHours')
        if m.get('recentN') is not None:
            self.recent_n = m.get('recentN')
        return self


class QueryConversationMessageForAIResponseBodyMessagesAtUsers(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        nick: str = None,
        type: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.agent_code = agent_code
        self.nick = nick
        self.type = type
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.nick is not None:
            result['nick'] = self.nick
        if self.type is not None:
            result['type'] = self.type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryConversationMessageForAIResponseBodyMessagesSender(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        nick: str = None,
        type: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.agent_code = agent_code
        self.nick = nick
        self.type = type
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.nick is not None:
            result['nick'] = self.nick
        if self.type is not None:
            result['type'] = self.type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryConversationMessageForAIResponseBodyMessages(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_users: List[QueryConversationMessageForAIResponseBodyMessagesAtUsers] = None,
        msg_content: str = None,
        msg_type: str = None,
        send_time: str = None,
        sender: QueryConversationMessageForAIResponseBodyMessagesSender = None,
        summary: str = None,
    ):
        self.at_all = at_all
        self.at_users = at_users
        self.msg_content = msg_content
        self.msg_type = msg_type
        self.send_time = send_time
        self.sender = sender
        self.summary = summary

    def validate(self):
        if self.at_users:
            for k in self.at_users:
                if k:
                    k.validate()
        if self.sender:
            self.sender.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        result['atUsers'] = []
        if self.at_users is not None:
            for k in self.at_users:
                result['atUsers'].append(k.to_map() if k else None)
        if self.msg_content is not None:
            result['msgContent'] = self.msg_content
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.send_time is not None:
            result['sendTime'] = self.send_time
        if self.sender is not None:
            result['sender'] = self.sender.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        self.at_users = []
        if m.get('atUsers') is not None:
            for k in m.get('atUsers'):
                temp_model = QueryConversationMessageForAIResponseBodyMessagesAtUsers()
                self.at_users.append(temp_model.from_map(k))
        if m.get('msgContent') is not None:
            self.msg_content = m.get('msgContent')
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('sendTime') is not None:
            self.send_time = m.get('sendTime')
        if m.get('sender') is not None:
            temp_model = QueryConversationMessageForAIResponseBodyMessagesSender()
            self.sender = temp_model.from_map(m['sender'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        return self


class QueryConversationMessageForAIResponseBody(TeaModel):
    def __init__(
        self,
        messages: List[QueryConversationMessageForAIResponseBodyMessages] = None,
    ):
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
                temp_model = QueryConversationMessageForAIResponseBodyMessages()
                self.messages.append(temp_model.from_map(k))
        return self


class QueryConversationMessageForAIResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryConversationMessageForAIResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryConversationMessageForAIResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMemoryLearningTaskHeaders(TeaModel):
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


class QueryMemoryLearningTaskRequest(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        learning_code: str = None,
    ):
        self.agent_code = agent_code
        self.learning_code = learning_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.learning_code is not None:
            result['learningCode'] = self.learning_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('learningCode') is not None:
            self.learning_code = m.get('learningCode')
        return self


class QueryMemoryLearningTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        status: str = None,
        success: bool = None,
    ):
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryMemoryLearningTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryMemoryLearningTaskResponseBodyResult = None,
    ):
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
            temp_model = QueryMemoryLearningTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryMemoryLearningTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMemoryLearningTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryMemoryLearningTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubmitMemoryLearningTaskHeaders(TeaModel):
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


class SubmitMemoryLearningTaskRequestContent(TeaModel):
    def __init__(
        self,
        knowledge_base_url: str = None,
        type: str = None,
    ):
        self.knowledge_base_url = knowledge_base_url
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.knowledge_base_url is not None:
            result['knowledgeBaseUrl'] = self.knowledge_base_url
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('knowledgeBaseUrl') is not None:
            self.knowledge_base_url = m.get('knowledgeBaseUrl')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SubmitMemoryLearningTaskRequest(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        content: SubmitMemoryLearningTaskRequestContent = None,
        learning_mode: str = None,
        memory_key: str = None,
    ):
        self.agent_code = agent_code
        self.content = content
        self.learning_mode = learning_mode
        self.memory_key = memory_key

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.learning_mode is not None:
            result['learningMode'] = self.learning_mode
        if self.memory_key is not None:
            result['memoryKey'] = self.memory_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('content') is not None:
            temp_model = SubmitMemoryLearningTaskRequestContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('learningMode') is not None:
            self.learning_mode = m.get('learningMode')
        if m.get('memoryKey') is not None:
            self.memory_key = m.get('memoryKey')
        return self


class SubmitMemoryLearningTaskShrinkRequest(TeaModel):
    def __init__(
        self,
        agent_code: str = None,
        content_shrink: str = None,
        learning_mode: str = None,
        memory_key: str = None,
    ):
        self.agent_code = agent_code
        self.content_shrink = content_shrink
        self.learning_mode = learning_mode
        self.memory_key = memory_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.content_shrink is not None:
            result['content'] = self.content_shrink
        if self.learning_mode is not None:
            result['learningMode'] = self.learning_mode
        if self.memory_key is not None:
            result['memoryKey'] = self.memory_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('content') is not None:
            self.content_shrink = m.get('content')
        if m.get('learningMode') is not None:
            self.learning_mode = m.get('learningMode')
        if m.get('memoryKey') is not None:
            self.memory_key = m.get('memoryKey')
        return self


class SubmitMemoryLearningTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        learning_code: str = None,
        status: str = None,
        success: bool = None,
    ):
        self.learning_code = learning_code
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.learning_code is not None:
            result['learningCode'] = self.learning_code
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('learningCode') is not None:
            self.learning_code = m.get('learningCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SubmitMemoryLearningTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: SubmitMemoryLearningTaskResponseBodyResult = None,
    ):
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
            temp_model = SubmitMemoryLearningTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SubmitMemoryLearningTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SubmitMemoryLearningTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SubmitMemoryLearningTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


