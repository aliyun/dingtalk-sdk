# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ai_paa_s_1_0 import models as dingtalkai_paa_s__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def execute_agent_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
        headers: dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_code):
            body['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.inputs):
            body['inputs'] = request.inputs
        if not UtilClient.is_unset(request.scenario_code):
            body['scenarioCode'] = request.scenario_code
        if not UtilClient.is_unset(request.scenario_instance_id):
            body['scenarioInstanceId'] = request.scenario_instance_id
        if not UtilClient.is_unset(request.skill_id):
            body['skillId'] = request.skill_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExecuteAgent',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/agents/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.ExecuteAgentResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_agent_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
        headers: dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_code):
            body['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.inputs):
            body['inputs'] = request.inputs
        if not UtilClient.is_unset(request.scenario_code):
            body['scenarioCode'] = request.scenario_code
        if not UtilClient.is_unset(request.scenario_instance_id):
            body['scenarioInstanceId'] = request.scenario_instance_id
        if not UtilClient.is_unset(request.skill_id):
            body['skillId'] = request.skill_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExecuteAgent',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/agents/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.ExecuteAgentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_agent(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders()
        return self.execute_agent_with_options(request, headers, runtime)

    async def execute_agent_async(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders()
        return await self.execute_agent_with_options_async(request, headers, runtime)

    def liandanlu_exclusive_model_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.prompt):
            body['prompt'] = request.prompt
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='LiandanluExclusiveModel',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse(),
            self.execute(params, req, runtime)
        )

    async def liandanlu_exclusive_model_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.prompt):
            body['prompt'] = request.prompt
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='LiandanluExclusiveModel',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def liandanlu_exclusive_model(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders()
        return self.liandanlu_exclusive_model_with_options(request, headers, runtime)

    async def liandanlu_exclusive_model_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders()
        return await self.liandanlu_exclusive_model_with_options_async(request, headers, runtime)

    def query_conversation_message_for_aiwith_options(
        self,
        cid: str,
        tmp_req: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.open_msg_ids):
            request.open_msg_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.open_msg_ids, 'openMsgIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.open_msg_ids_shrink):
            query['openMsgIds'] = request.open_msg_ids_shrink
        if not UtilClient.is_unset(request.recent_days):
            query['recentDays'] = request.recent_days
        if not UtilClient.is_unset(request.recent_hours):
            query['recentHours'] = request.recent_hours
        if not UtilClient.is_unset(request.recent_n):
            query['recentN'] = request.recent_n
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryConversationMessageForAI',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/im/{cid}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse(),
            self.execute(params, req, runtime)
        )

    async def query_conversation_message_for_aiwith_options_async(
        self,
        cid: str,
        tmp_req: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.open_msg_ids):
            request.open_msg_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.open_msg_ids, 'openMsgIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.open_msg_ids_shrink):
            query['openMsgIds'] = request.open_msg_ids_shrink
        if not UtilClient.is_unset(request.recent_days):
            query['recentDays'] = request.recent_days
        if not UtilClient.is_unset(request.recent_hours):
            query['recentHours'] = request.recent_hours
        if not UtilClient.is_unset(request.recent_n):
            query['recentN'] = request.recent_n
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryConversationMessageForAI',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/im/{cid}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_conversation_message_for_ai(
        self,
        cid: str,
        request: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders()
        return self.query_conversation_message_for_aiwith_options(cid, request, headers, runtime)

    async def query_conversation_message_for_ai_async(
        self,
        cid: str,
        request: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders()
        return await self.query_conversation_message_for_aiwith_options_async(cid, request, headers, runtime)

    def query_memory_learning_task_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_code):
            query['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.learning_code):
            query['learningCode'] = request.learning_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryMemoryLearningTask',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/learningTask/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def query_memory_learning_task_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_code):
            query['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.learning_code):
            query['learningCode'] = request.learning_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryMemoryLearningTask',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/learningTask/get',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_memory_learning_task(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders()
        return self.query_memory_learning_task_with_options(request, headers, runtime)

    async def query_memory_learning_task_async(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders()
        return await self.query_memory_learning_task_with_options_async(request, headers, runtime)

    def submit_memory_learning_task_with_options(
        self,
        tmp_req: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.content):
            request.content_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.content, 'content', 'json')
        query = {}
        if not UtilClient.is_unset(request.agent_code):
            query['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.content_shrink):
            query['content'] = request.content_shrink
        if not UtilClient.is_unset(request.learning_mode):
            query['learningMode'] = request.learning_mode
        if not UtilClient.is_unset(request.memory_key):
            query['memoryKey'] = request.memory_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SubmitMemoryLearningTask',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/learningTask/put',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def submit_memory_learning_task_with_options_async(
        self,
        tmp_req: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.content):
            request.content_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.content, 'content', 'json')
        query = {}
        if not UtilClient.is_unset(request.agent_code):
            query['agentCode'] = request.agent_code
        if not UtilClient.is_unset(request.content_shrink):
            query['content'] = request.content_shrink
        if not UtilClient.is_unset(request.learning_mode):
            query['learningMode'] = request.learning_mode
        if not UtilClient.is_unset(request.memory_key):
            query['memoryKey'] = request.memory_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SubmitMemoryLearningTask',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/me/memory/learningTask/put',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def submit_memory_learning_task(
        self,
        request: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders()
        return self.submit_memory_learning_task_with_options(request, headers, runtime)

    async def submit_memory_learning_task_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders()
        return await self.submit_memory_learning_task_with_options_async(request, headers, runtime)
