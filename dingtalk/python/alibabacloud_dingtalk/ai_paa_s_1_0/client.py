# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def execute_agent_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
        headers: dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        """
        @summary 执行AI技能
        
        @param request: ExecuteAgentRequest
        @param headers: ExecuteAgentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteAgentResponse
        """
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
        """
        @summary 执行AI技能
        
        @param request: ExecuteAgentRequest
        @param headers: ExecuteAgentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteAgentResponse
        """
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
        """
        @summary 执行AI技能
        
        @param request: ExecuteAgentRequest
        @return: ExecuteAgentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders()
        return self.execute_agent_with_options(request, headers, runtime)

    async def execute_agent_async(
        self,
        request: dingtalkai_paa_s__1__0_models.ExecuteAgentRequest,
    ) -> dingtalkai_paa_s__1__0_models.ExecuteAgentResponse:
        """
        @summary 执行AI技能
        
        @param request: ExecuteAgentRequest
        @return: ExecuteAgentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.ExecuteAgentHeaders()
        return await self.execute_agent_with_options_async(request, headers, runtime)

    def liandan_text_image_get_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanTextImageGetRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanTextImageGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse:
        """
        @summary 炼丹炉文生图任务结果获取
        
        @param request: LiandanTextImageGetRequest
        @param headers: LiandanTextImageGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanTextImageGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='LiandanTextImageGet',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/textToImage/results/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse(),
            self.execute(params, req, runtime)
        )

    async def liandan_text_image_get_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanTextImageGetRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanTextImageGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse:
        """
        @summary 炼丹炉文生图任务结果获取
        
        @param request: LiandanTextImageGetRequest
        @param headers: LiandanTextImageGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanTextImageGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='LiandanTextImageGet',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/textToImage/results/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def liandan_text_image_get(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanTextImageGetRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse:
        """
        @summary 炼丹炉文生图任务结果获取
        
        @param request: LiandanTextImageGetRequest
        @return: LiandanTextImageGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanTextImageGetHeaders()
        return self.liandan_text_image_get_with_options(request, headers, runtime)

    async def liandan_text_image_get_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanTextImageGetRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanTextImageGetResponse:
        """
        @summary 炼丹炉文生图任务结果获取
        
        @param request: LiandanTextImageGetRequest
        @return: LiandanTextImageGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanTextImageGetHeaders()
        return await self.liandan_text_image_get_with_options_async(request, headers, runtime)

    def liandanlu_exclusive_model_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        """
        @summary 炼丹炉专属模型接口
        
        @param request: LiandanluExclusiveModelRequest
        @param headers: LiandanluExclusiveModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanluExclusiveModelResponse
        """
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
        """
        @summary 炼丹炉专属模型接口
        
        @param request: LiandanluExclusiveModelRequest
        @param headers: LiandanluExclusiveModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanluExclusiveModelResponse
        """
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
        """
        @summary 炼丹炉专属模型接口
        
        @param request: LiandanluExclusiveModelRequest
        @return: LiandanluExclusiveModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders()
        return self.liandanlu_exclusive_model_with_options(request, headers, runtime)

    async def liandanlu_exclusive_model_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelResponse:
        """
        @summary 炼丹炉专属模型接口
        
        @param request: LiandanluExclusiveModelRequest
        @return: LiandanluExclusiveModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluExclusiveModelHeaders()
        return await self.liandanlu_exclusive_model_with_options_async(request, headers, runtime)

    def liandanlu_text_to_image_model_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse:
        """
        @summary 炼丹炉通过提示词生成图片
        
        @param request: LiandanluTextToImageModelRequest
        @param headers: LiandanluTextToImageModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanluTextToImageModelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.number):
            body['number'] = request.number
        if not UtilClient.is_unset(request.parameters):
            body['parameters'] = request.parameters
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
            action='LiandanluTextToImageModel',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/textToImage/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse(),
            self.execute(params, req, runtime)
        )

    async def liandanlu_text_to_image_model_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelRequest,
        headers: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse:
        """
        @summary 炼丹炉通过提示词生成图片
        
        @param request: LiandanluTextToImageModelRequest
        @param headers: LiandanluTextToImageModelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LiandanluTextToImageModelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.module):
            body['module'] = request.module
        if not UtilClient.is_unset(request.number):
            body['number'] = request.number
        if not UtilClient.is_unset(request.parameters):
            body['parameters'] = request.parameters
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
            action='LiandanluTextToImageModel',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/textToImage/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def liandanlu_text_to_image_model(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse:
        """
        @summary 炼丹炉通过提示词生成图片
        
        @param request: LiandanluTextToImageModelRequest
        @return: LiandanluTextToImageModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelHeaders()
        return self.liandanlu_text_to_image_model_with_options(request, headers, runtime)

    async def liandanlu_text_to_image_model_async(
        self,
        request: dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelRequest,
    ) -> dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelResponse:
        """
        @summary 炼丹炉通过提示词生成图片
        
        @param request: LiandanluTextToImageModelRequest
        @return: LiandanluTextToImageModelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.LiandanluTextToImageModelHeaders()
        return await self.liandanlu_text_to_image_model_with_options_async(request, headers, runtime)

    def n_lto_frame_service_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.NLToFrameServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.NLToFrameServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse:
        """
        @summary 通过配置的指令，连接用户和系统，训练大模型
        
        @param request: NLToFrameServiceRequest
        @param headers: NLToFrameServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: NLToFrameServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extension_str):
            body['extensionStr'] = request.extension_str
        if not UtilClient.is_unset(request.is_new_model):
            body['isNewModel'] = request.is_new_model
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.model_name):
            body['modelName'] = request.model_name
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
            action='NLToFrameService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/nl2frame',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def n_lto_frame_service_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.NLToFrameServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.NLToFrameServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse:
        """
        @summary 通过配置的指令，连接用户和系统，训练大模型
        
        @param request: NLToFrameServiceRequest
        @param headers: NLToFrameServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: NLToFrameServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extension_str):
            body['extensionStr'] = request.extension_str
        if not UtilClient.is_unset(request.is_new_model):
            body['isNewModel'] = request.is_new_model
        if not UtilClient.is_unset(request.model_id):
            body['modelId'] = request.model_id
        if not UtilClient.is_unset(request.model_name):
            body['modelName'] = request.model_name
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
            action='NLToFrameService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/ai/nl2frame',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def n_lto_frame_service(
        self,
        request: dingtalkai_paa_s__1__0_models.NLToFrameServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse:
        """
        @summary 通过配置的指令，连接用户和系统，训练大模型
        
        @param request: NLToFrameServiceRequest
        @return: NLToFrameServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.NLToFrameServiceHeaders()
        return self.n_lto_frame_service_with_options(request, headers, runtime)

    async def n_lto_frame_service_async(
        self,
        request: dingtalkai_paa_s__1__0_models.NLToFrameServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.NLToFrameServiceResponse:
        """
        @summary 通过配置的指令，连接用户和系统，训练大模型
        
        @param request: NLToFrameServiceRequest
        @return: NLToFrameServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.NLToFrameServiceHeaders()
        return await self.n_lto_frame_service_with_options_async(request, headers, runtime)

    def query_baymax_skill_log_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse:
        """
        @summary Baymax技能执行日志
        
        @param request: QueryBaymaxSkillLogRequest
        @param headers: QueryBaymaxSkillLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBaymaxSkillLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.from_):
            query['from'] = request.from_
        if not UtilClient.is_unset(request.log_level):
            query['logLevel'] = request.log_level
        if not UtilClient.is_unset(request.skill_execute_id):
            query['skillExecuteId'] = request.skill_execute_id
        if not UtilClient.is_unset(request.to):
            query['to'] = request.to
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
            action='QueryBaymaxSkillLog',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/skills/logs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse(),
            self.execute(params, req, runtime)
        )

    async def query_baymax_skill_log_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse:
        """
        @summary Baymax技能执行日志
        
        @param request: QueryBaymaxSkillLogRequest
        @param headers: QueryBaymaxSkillLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBaymaxSkillLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.from_):
            query['from'] = request.from_
        if not UtilClient.is_unset(request.log_level):
            query['logLevel'] = request.log_level
        if not UtilClient.is_unset(request.skill_execute_id):
            query['skillExecuteId'] = request.skill_execute_id
        if not UtilClient.is_unset(request.to):
            query['to'] = request.to
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
            action='QueryBaymaxSkillLog',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/skills/logs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_baymax_skill_log(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse:
        """
        @summary Baymax技能执行日志
        
        @param request: QueryBaymaxSkillLogRequest
        @return: QueryBaymaxSkillLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogHeaders()
        return self.query_baymax_skill_log_with_options(request, headers, runtime)

    async def query_baymax_skill_log_async(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogResponse:
        """
        @summary Baymax技能执行日志
        
        @param request: QueryBaymaxSkillLogRequest
        @return: QueryBaymaxSkillLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryBaymaxSkillLogHeaders()
        return await self.query_baymax_skill_log_with_options_async(request, headers, runtime)

    def query_conversation_message_for_aiwith_options(
        self,
        cid: str,
        tmp_req: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        """
        @summary 查询会话消息并以大模型友好的协议返回
        
        @param tmp_req: QueryConversationMessageForAIRequest
        @param headers: QueryConversationMessageForAIHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConversationMessageForAIResponse
        """
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
        """
        @summary 查询会话消息并以大模型友好的协议返回
        
        @param tmp_req: QueryConversationMessageForAIRequest
        @param headers: QueryConversationMessageForAIHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConversationMessageForAIResponse
        """
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
        """
        @summary 查询会话消息并以大模型友好的协议返回
        
        @param request: QueryConversationMessageForAIRequest
        @return: QueryConversationMessageForAIResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders()
        return self.query_conversation_message_for_aiwith_options(cid, request, headers, runtime)

    async def query_conversation_message_for_ai_async(
        self,
        cid: str,
        request: dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIResponse:
        """
        @summary 查询会话消息并以大模型友好的协议返回
        
        @param request: QueryConversationMessageForAIRequest
        @return: QueryConversationMessageForAIResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryConversationMessageForAIHeaders()
        return await self.query_conversation_message_for_aiwith_options_async(cid, request, headers, runtime)

    def query_memory_learning_task_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        """
        @summary 查询记忆学习进度
        
        @param request: QueryMemoryLearningTaskRequest
        @param headers: QueryMemoryLearningTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMemoryLearningTaskResponse
        """
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
        """
        @summary 查询记忆学习进度
        
        @param request: QueryMemoryLearningTaskRequest
        @param headers: QueryMemoryLearningTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMemoryLearningTaskResponse
        """
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
        """
        @summary 查询记忆学习进度
        
        @param request: QueryMemoryLearningTaskRequest
        @return: QueryMemoryLearningTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders()
        return self.query_memory_learning_task_with_options(request, headers, runtime)

    async def query_memory_learning_task_async(
        self,
        request: dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskResponse:
        """
        @summary 查询记忆学习进度
        
        @param request: QueryMemoryLearningTaskRequest
        @return: QueryMemoryLearningTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.QueryMemoryLearningTaskHeaders()
        return await self.query_memory_learning_task_with_options_async(request, headers, runtime)

    def smart_quote_data_service_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse:
        """
        @summary 添加智能报价数据
        
        @param request: SmartQuoteDataServiceRequest
        @param headers: SmartQuoteDataServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteDataServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='SmartQuoteDataService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/datas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def smart_quote_data_service_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse:
        """
        @summary 添加智能报价数据
        
        @param request: SmartQuoteDataServiceRequest
        @param headers: SmartQuoteDataServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteDataServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='SmartQuoteDataService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/datas',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def smart_quote_data_service(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse:
        """
        @summary 添加智能报价数据
        
        @param request: SmartQuoteDataServiceRequest
        @return: SmartQuoteDataServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceHeaders()
        return self.smart_quote_data_service_with_options(request, headers, runtime)

    async def smart_quote_data_service_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceResponse:
        """
        @summary 添加智能报价数据
        
        @param request: SmartQuoteDataServiceRequest
        @return: SmartQuoteDataServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteDataServiceHeaders()
        return await self.smart_quote_data_service_with_options_async(request, headers, runtime)

    def smart_quote_query_result_service_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse:
        """
        @summary 查询智能报价结果
        
        @param request: SmartQuoteQueryResultServiceRequest
        @param headers: SmartQuoteQueryResultServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteQueryResultServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='SmartQuoteQueryResultService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/results/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def smart_quote_query_result_service_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse:
        """
        @summary 查询智能报价结果
        
        @param request: SmartQuoteQueryResultServiceRequest
        @param headers: SmartQuoteQueryResultServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteQueryResultServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='SmartQuoteQueryResultService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/results/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def smart_quote_query_result_service(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse:
        """
        @summary 查询智能报价结果
        
        @param request: SmartQuoteQueryResultServiceRequest
        @return: SmartQuoteQueryResultServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceHeaders()
        return self.smart_quote_query_result_service_with_options(request, headers, runtime)

    async def smart_quote_query_result_service_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceResponse:
        """
        @summary 查询智能报价结果
        
        @param request: SmartQuoteQueryResultServiceRequest
        @return: SmartQuoteQueryResultServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteQueryResultServiceHeaders()
        return await self.smart_quote_query_result_service_with_options_async(request, headers, runtime)

    def smart_quote_query_service_with_options(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse:
        """
        @summary 查询智能报价
        
        @param request: SmartQuoteQueryServiceRequest
        @param headers: SmartQuoteQueryServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteQueryServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='SmartQuoteQueryService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/triggerQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def smart_quote_query_service_with_options_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceRequest,
        headers: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse:
        """
        @summary 查询智能报价
        
        @param request: SmartQuoteQueryServiceRequest
        @param headers: SmartQuoteQueryServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SmartQuoteQueryServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='SmartQuoteQueryService',
            version='aiPaaS_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiPaaS/nl2x/smartQuotations/triggerQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def smart_quote_query_service(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse:
        """
        @summary 查询智能报价
        
        @param request: SmartQuoteQueryServiceRequest
        @return: SmartQuoteQueryServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceHeaders()
        return self.smart_quote_query_service_with_options(request, headers, runtime)

    async def smart_quote_query_service_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceRequest,
    ) -> dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceResponse:
        """
        @summary 查询智能报价
        
        @param request: SmartQuoteQueryServiceRequest
        @return: SmartQuoteQueryServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SmartQuoteQueryServiceHeaders()
        return await self.smart_quote_query_service_with_options_async(request, headers, runtime)

    def submit_memory_learning_task_with_options(
        self,
        tmp_req: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
        headers: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        """
        @summary 提交记忆学习任务
        
        @param tmp_req: SubmitMemoryLearningTaskRequest
        @param headers: SubmitMemoryLearningTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitMemoryLearningTaskResponse
        """
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
        """
        @summary 提交记忆学习任务
        
        @param tmp_req: SubmitMemoryLearningTaskRequest
        @param headers: SubmitMemoryLearningTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitMemoryLearningTaskResponse
        """
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
        """
        @summary 提交记忆学习任务
        
        @param request: SubmitMemoryLearningTaskRequest
        @return: SubmitMemoryLearningTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders()
        return self.submit_memory_learning_task_with_options(request, headers, runtime)

    async def submit_memory_learning_task_async(
        self,
        request: dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskRequest,
    ) -> dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskResponse:
        """
        @summary 提交记忆学习任务
        
        @param request: SubmitMemoryLearningTaskRequest
        @return: SubmitMemoryLearningTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_paa_s__1__0_models.SubmitMemoryLearningTaskHeaders()
        return await self.submit_memory_learning_task_with_options_async(request, headers, runtime)
