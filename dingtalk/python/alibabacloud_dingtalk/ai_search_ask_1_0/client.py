# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ai_search_ask_1_0 import models as dingtalkai_search_ask__1__0_models
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

    def fetch_login_status_devices_with_options(
        self,
        request: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesRequest,
        headers: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse:
        """
        @summary 查询指定用户的全部已登录设备及其状态
        
        @param request: FetchLoginStatusDevicesRequest
        @param headers: FetchLoginStatusDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FetchLoginStatusDevicesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='FetchLoginStatusDevices',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/fetchLoginStatusDevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse(),
            self.execute(params, req, runtime)
        )

    async def fetch_login_status_devices_with_options_async(
        self,
        request: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesRequest,
        headers: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse:
        """
        @summary 查询指定用户的全部已登录设备及其状态
        
        @param request: FetchLoginStatusDevicesRequest
        @param headers: FetchLoginStatusDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FetchLoginStatusDevicesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='FetchLoginStatusDevices',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/fetchLoginStatusDevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def fetch_login_status_devices(
        self,
        request: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesRequest,
    ) -> dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse:
        """
        @summary 查询指定用户的全部已登录设备及其状态
        
        @param request: FetchLoginStatusDevicesRequest
        @return: FetchLoginStatusDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesHeaders()
        return self.fetch_login_status_devices_with_options(request, headers, runtime)

    async def fetch_login_status_devices_async(
        self,
        request: dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesRequest,
    ) -> dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesResponse:
        """
        @summary 查询指定用户的全部已登录设备及其状态
        
        @param request: FetchLoginStatusDevicesRequest
        @return: FetchLoginStatusDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.FetchLoginStatusDevicesHeaders()
        return await self.fetch_login_status_devices_with_options_async(request, headers, runtime)

    def get_ai_task_result_with_options(
        self,
        request: dingtalkai_search_ask__1__0_models.GetAiTaskResultRequest,
        headers: dingtalkai_search_ask__1__0_models.GetAiTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse:
        """
        @summary 获得ai任务结果
        
        @param request: GetAiTaskResultRequest
        @param headers: GetAiTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAiTaskResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetAiTaskResult',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/getAiTaskResult',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ai_task_result_with_options_async(
        self,
        request: dingtalkai_search_ask__1__0_models.GetAiTaskResultRequest,
        headers: dingtalkai_search_ask__1__0_models.GetAiTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse:
        """
        @summary 获得ai任务结果
        
        @param request: GetAiTaskResultRequest
        @param headers: GetAiTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAiTaskResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetAiTaskResult',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/getAiTaskResult',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ai_task_result(
        self,
        request: dingtalkai_search_ask__1__0_models.GetAiTaskResultRequest,
    ) -> dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse:
        """
        @summary 获得ai任务结果
        
        @param request: GetAiTaskResultRequest
        @return: GetAiTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.GetAiTaskResultHeaders()
        return self.get_ai_task_result_with_options(request, headers, runtime)

    async def get_ai_task_result_async(
        self,
        request: dingtalkai_search_ask__1__0_models.GetAiTaskResultRequest,
    ) -> dingtalkai_search_ask__1__0_models.GetAiTaskResultResponse:
        """
        @summary 获得ai任务结果
        
        @param request: GetAiTaskResultRequest
        @return: GetAiTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.GetAiTaskResultHeaders()
        return await self.get_ai_task_result_with_options_async(request, headers, runtime)

    def retrieve_with_options(
        self,
        request: dingtalkai_search_ask__1__0_models.RetrieveRequest,
        headers: dingtalkai_search_ask__1__0_models.RetrieveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.RetrieveResponse:
        """
        @summary 多数据源召回接口
        
        @param request: RetrieveRequest
        @param headers: RetrieveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.answerer):
            body['answerer'] = request.answerer
        if not UtilClient.is_unset(request.drag_request_context):
            body['dragRequestContext'] = request.drag_request_context
        if not UtilClient.is_unset(request.keyword_list):
            body['keywordList'] = request.keyword_list
        if not UtilClient.is_unset(request.limit):
            body['limit'] = request.limit
        if not UtilClient.is_unset(request.question):
            body['question'] = request.question
        if not UtilClient.is_unset(request.retrieval_extend_params):
            body['retrievalExtendParams'] = request.retrieval_extend_params
        if not UtilClient.is_unset(request.retrieve_score_threshold):
            body['retrieveScoreThreshold'] = request.retrieve_score_threshold
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.token_limit):
            body['tokenLimit'] = request.token_limit
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
            action='Retrieve',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/retrieve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.RetrieveResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_with_options_async(
        self,
        request: dingtalkai_search_ask__1__0_models.RetrieveRequest,
        headers: dingtalkai_search_ask__1__0_models.RetrieveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.RetrieveResponse:
        """
        @summary 多数据源召回接口
        
        @param request: RetrieveRequest
        @param headers: RetrieveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.answerer):
            body['answerer'] = request.answerer
        if not UtilClient.is_unset(request.drag_request_context):
            body['dragRequestContext'] = request.drag_request_context
        if not UtilClient.is_unset(request.keyword_list):
            body['keywordList'] = request.keyword_list
        if not UtilClient.is_unset(request.limit):
            body['limit'] = request.limit
        if not UtilClient.is_unset(request.question):
            body['question'] = request.question
        if not UtilClient.is_unset(request.retrieval_extend_params):
            body['retrievalExtendParams'] = request.retrieval_extend_params
        if not UtilClient.is_unset(request.retrieve_score_threshold):
            body['retrieveScoreThreshold'] = request.retrieve_score_threshold
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.tenant):
            body['tenant'] = request.tenant
        if not UtilClient.is_unset(request.token_limit):
            body['tokenLimit'] = request.token_limit
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
            action='Retrieve',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/retrieve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.RetrieveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve(
        self,
        request: dingtalkai_search_ask__1__0_models.RetrieveRequest,
    ) -> dingtalkai_search_ask__1__0_models.RetrieveResponse:
        """
        @summary 多数据源召回接口
        
        @param request: RetrieveRequest
        @return: RetrieveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.RetrieveHeaders()
        return self.retrieve_with_options(request, headers, runtime)

    async def retrieve_async(
        self,
        request: dingtalkai_search_ask__1__0_models.RetrieveRequest,
    ) -> dingtalkai_search_ask__1__0_models.RetrieveResponse:
        """
        @summary 多数据源召回接口
        
        @param request: RetrieveRequest
        @return: RetrieveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.RetrieveHeaders()
        return await self.retrieve_with_options_async(request, headers, runtime)

    def submit_ai_task_with_options(
        self,
        tmp_req: dingtalkai_search_ask__1__0_models.SubmitAiTaskRequest,
        headers: dingtalkai_search_ask__1__0_models.SubmitAiTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse:
        """
        @summary 提交ai任务
        
        @param tmp_req: SubmitAiTaskRequest
        @param headers: SubmitAiTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitAiTaskResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_search_ask__1__0_models.SubmitAiTaskShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.messages):
            request.messages_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.messages, 'messages', 'json')
        query = {}
        if not UtilClient.is_unset(request.messages_shrink):
            query['messages'] = request.messages_shrink
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
            action='SubmitAiTask',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/submitAiTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def submit_ai_task_with_options_async(
        self,
        tmp_req: dingtalkai_search_ask__1__0_models.SubmitAiTaskRequest,
        headers: dingtalkai_search_ask__1__0_models.SubmitAiTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse:
        """
        @summary 提交ai任务
        
        @param tmp_req: SubmitAiTaskRequest
        @param headers: SubmitAiTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitAiTaskResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkai_search_ask__1__0_models.SubmitAiTaskShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.messages):
            request.messages_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.messages, 'messages', 'json')
        query = {}
        if not UtilClient.is_unset(request.messages_shrink):
            query['messages'] = request.messages_shrink
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
            action='SubmitAiTask',
            version='aiSearchAsk_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiSearchAsk/submitAiTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def submit_ai_task(
        self,
        request: dingtalkai_search_ask__1__0_models.SubmitAiTaskRequest,
    ) -> dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse:
        """
        @summary 提交ai任务
        
        @param request: SubmitAiTaskRequest
        @return: SubmitAiTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.SubmitAiTaskHeaders()
        return self.submit_ai_task_with_options(request, headers, runtime)

    async def submit_ai_task_async(
        self,
        request: dingtalkai_search_ask__1__0_models.SubmitAiTaskRequest,
    ) -> dingtalkai_search_ask__1__0_models.SubmitAiTaskResponse:
        """
        @summary 提交ai任务
        
        @param request: SubmitAiTaskRequest
        @return: SubmitAiTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_search_ask__1__0_models.SubmitAiTaskHeaders()
        return await self.submit_ai_task_with_options_async(request, headers, runtime)
